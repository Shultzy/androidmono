using System;
using System.Linq;
using System.Reflection;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MonoDevelop.Android
{
    [Flags]
    public enum GenerationFlags : int
    {
        None = 0,
        KeepIntermediateFiles = 1
    }
    
    public class MonoReflector
    {
        private List<Assembly> assems = new List<Assembly>();
        private static string template = new StreamReader(typeof(MonoReflector).Assembly.GetManifestResourceStream("JavaClassTemplate.java")).ReadToEnd();

        public MonoReflector(params string[] files)
        {
            foreach (string assem in files)
                assems.Add(Assembly.LoadFile(assem));
        }

        public MonoReflector(params Assembly[] files)
        {
            assems.AddRange(assems);
        }

        public bool Generate(GenerationFlags flags)
        {
            foreach (Assembly a in assems)
                Generate(a.GetTypes(), flags);
            //FIXME: compile with sdk here
            if ((flags & GenerationFlags.KeepIntermediateFiles) != GenerationFlags.KeepIntermediateFiles)
            {

            }
            return true;
        }

        public bool Generate(Type[] types, GenerationFlags flags)
        {
            foreach (Type t in types)
            {
                if (!t.IsInterface)
                {
                    Dictionary<MethodInfo, MethodInfo> methods = new Dictionary<MethodInfo, MethodInfo>();
                    bool isBaseClass = false;
                    foreach (MethodInfo subm in t.GetMethods(BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance).Where(x => x.IsVirtual))
                    {
                        if ((subm.MemberType & MemberTypes.Property) == MemberTypes.Property || (subm.MemberType & MemberTypes.Method) == MemberTypes.Method)
                        {
                            MethodInfo androidMethod = FindBaseForMethod(subm, null);
                            if (androidMethod != null)
                            {
                                isBaseClass |= true;
                                methods.Add(subm, androidMethod);
                            }
                            else//must be implementing an interface
                            {
                                androidMethod = FindInterfaceForMethod(subm);
                                if (androidMethod != null)
                                    methods.Add(subm, androidMethod);
                            }
                        }
                    }
                    if (methods.Count > 0)
                    {
                        StringBuilder linkMethods = new StringBuilder(), natives = new StringBuilder();
                        //get the link methods

                        KeyValuePair<MethodInfo, MethodInfo>? first = null;
                        foreach (KeyValuePair<MethodInfo, MethodInfo> pair in methods)
                        {
                            if (first == null)
                                first = pair;
                            StringBuilder args = new StringBuilder(), jniArgs = new StringBuilder();
                            ParameterInfo[] paramInfo = null;
                            foreach (ParameterInfo p in paramInfo = pair.Key.GetParameters())
                                jniArgs.Append(GetJType(p.ParameterType, true, true));
                            for (int i = 0; i < paramInfo.Length; i++)
                            {
                                args.Append(paramInfo[i].ParameterType.FullName);
                                if (i < paramInfo.Length - 1)
                                    args.Append(",");
                            }
                            linkMethods.AppendLine(string.Format("\t\tMonoBridge.link({0}.class, \"{1}\", \"({2}){3}\", \"{4}\");",
                                t.Name, pair.Key.Name, jniArgs, GetJType(pair.Key.ReturnType, true, true), args));
                            args = new StringBuilder();//reuse var

                            for (int i = 0; i < paramInfo.Length; i++)
                            {
                                args.AppendFormat("{0} {1}", paramInfo[i].ParameterType.FullName, paramInfo[i].Name);
                                if (i < paramInfo.Length - 1)
                                    args.Append(",");
                            }
                            natives.AppendLine("\t@Override");
                            natives.AppendLine(string.Format("\t{0} native {1} {2}({3});",
                                pair.Key.IsPublic ? "public" : "protected", GetJLangType(pair.Value.ReturnType), pair.Key.Name, args));
                        }
                        string[] fqcn = SplitFQCN(t.FullName);
                        string basePath = Path.GetDirectoryName(t.Assembly.Location);
                        basePath = Path.Combine(basePath, t.Namespace.Replace('.', Path.DirectorySeparatorChar));
                        Directory.CreateDirectory(basePath);
                        File.WriteAllText(Path.Combine(basePath, t.FullName + ".java"),
                            string.Format(template, fqcn[0], t.Name, isBaseClass ? " extends " : string.Empty, isBaseClass ? first.Value.Value.DeclaringType.FullName : string.Empty, linkMethods, natives));
                    }
                }
            }
            return true;
        }

        private MethodInfo FindBaseForMethod(MethodInfo sub, Type currentSuper)
        {
            if (currentSuper == null)
                return FindBaseForMethod(sub, sub.DeclaringType.BaseType);
            MethodInfo sup = currentSuper.GetMethod(sub.Name, BindingFlags.DeclaredOnly | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public,
                null, sub.GetParameters().Select(x => x.ParameterType).ToArray(), null);
            if (sup != null)
            {
                foreach (var attrib in currentSuper.GetCustomAttributes(false))
                {
                    if (attrib.GetType().FullName == "net.sf.jni4net.attributes.JavaClassAttribute")
                        return sup;
                }
            }
            return currentSuper.BaseType != null ? FindBaseForMethod(sub, currentSuper.BaseType) : null;
        }

        private MethodInfo FindInterfaceForMethod(MethodInfo sub)
        {
            foreach (Type t in sub.DeclaringType.GetInterfaces())
            {
                MethodInfo sup = t.GetMethod(sub.Name, BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public,
                    null, sub.GetParameters().Select(x => x.ParameterType).ToArray(), null);
                if (sup != null)
                {
                    foreach (var attrib in t.GetCustomAttributes(false))
                    {
                        if (attrib.GetType().FullName == "net.sf.jni4net.attributes.JavaInterfaceAttribute")
                            return sup;
                    }
                }
            }
            return null;
        }

        private string GetJType(Type type, bool replace, bool jniClasses)
        {
            string value = string.Empty;
            if (type == typeof(bool))
                value = "Z";
            else if (type == typeof(byte))
                value = "B";
            else if (type == typeof(char))
                value = "C";
            else if (type == typeof(short))
                value = "S";
            else if (type == typeof(int))
                value = "I";
            else if (type == typeof(long))
                value = "J";
            else if (type == typeof(float))
                value = "F";
            else if (type == typeof(double))
                value = "D";
            else if (type == typeof(void))
                value = "V";
            else
                value = jniClasses ? "L" + type.FullName + ";" : type.FullName;
            if (type.IsArray)
                value = "[" + value;
            return replace ? value.Replace('.', '/') : value;
        }

        private string GetJLangType(Type type)
        {
            switch (type.FullName)
            {
                case "System.Boolean":
                    return "bool";
                case "System.Byte":
                    return "byte";
                case "System.Char":
                    return "char";
                case "System.Int16":
                    return "short";
                case "System.Int32":
                    return "int";
                case "System.Int64":
                    return "long";
                case "System.Single":
                    return "float";
                case "System.Double":
                    return "double";
                case "System.Void":
                    return "void";
                default:
                    return type.FullName;
            }
        }

        private string[] SplitFQCN(string fqcn)
        {
            string[] names = fqcn.Split('.');
            StringBuilder b = new StringBuilder();
            for (int i = 0; i < names.Length - 1; i++)
            {
                b.Append(names[i]);
                if (i < names.Length - 2)
                    b.Append(".");
            }
            return new string[] { b.ToString(), names[names.Length - 1] };
            //{ string.Concat(names.Take(names.Length - 1).Select(x => ++index < names.Length - 1 ? x + "." : x).ToArray()), names[names.Length - 1] };
        }
    }
}