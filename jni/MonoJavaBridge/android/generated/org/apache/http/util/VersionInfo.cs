namespace org.apache.http.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class VersionInfo : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected VersionInfo(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString34022;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.util.VersionInfo._toString34022)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.util.VersionInfo.staticClass, global::org.apache.http.util.VersionInfo._toString34022)) as java.lang.String;
		}
		public new global::java.lang.String Package
		{
			get
			{
				return getPackage();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPackage34023;
		public virtual global::java.lang.String getPackage()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.util.VersionInfo._getPackage34023)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.util.VersionInfo.staticClass, global::org.apache.http.util.VersionInfo._getPackage34023)) as java.lang.String;
		}
		public new global::java.lang.String Timestamp
		{
			get
			{
				return getTimestamp();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTimestamp34024;
		public virtual global::java.lang.String getTimestamp()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.util.VersionInfo._getTimestamp34024)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.util.VersionInfo.staticClass, global::org.apache.http.util.VersionInfo._getTimestamp34024)) as java.lang.String;
		}
		public new global::java.lang.String Module
		{
			get
			{
				return getModule();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getModule34025;
		public virtual global::java.lang.String getModule()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.util.VersionInfo._getModule34025)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.util.VersionInfo.staticClass, global::org.apache.http.util.VersionInfo._getModule34025)) as java.lang.String;
		}
		public new global::java.lang.String Release
		{
			get
			{
				return getRelease();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRelease34026;
		public virtual global::java.lang.String getRelease()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.util.VersionInfo._getRelease34026)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.util.VersionInfo.staticClass, global::org.apache.http.util.VersionInfo._getRelease34026)) as java.lang.String;
		}
		public new global::java.lang.String Classloader
		{
			get
			{
				return getClassloader();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getClassloader34027;
		public virtual global::java.lang.String getClassloader()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.util.VersionInfo._getClassloader34027)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.util.VersionInfo.staticClass, global::org.apache.http.util.VersionInfo._getClassloader34027)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _loadVersionInfo34028;
		public static global::org.apache.http.util.VersionInfo[] loadVersionInfo(java.lang.String[] arg0, java.lang.ClassLoader arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<org.apache.http.util.VersionInfo>(@__env.CallStaticObjectMethod(org.apache.http.util.VersionInfo.staticClass, global::org.apache.http.util.VersionInfo._loadVersionInfo34028, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.util.VersionInfo[];
		}
		internal static global::MonoJavaBridge.MethodId _loadVersionInfo34029;
		public static global::org.apache.http.util.VersionInfo loadVersionInfo(java.lang.String arg0, java.lang.ClassLoader arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(org.apache.http.util.VersionInfo.staticClass, global::org.apache.http.util.VersionInfo._loadVersionInfo34029, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.util.VersionInfo;
		}
		internal static global::MonoJavaBridge.MethodId _fromMap34030;
		protected static global::org.apache.http.util.VersionInfo fromMap(java.lang.String arg0, java.util.Map arg1, java.lang.ClassLoader arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(org.apache.http.util.VersionInfo.staticClass, global::org.apache.http.util.VersionInfo._fromMap34030, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.util.VersionInfo;
		}
		internal static global::MonoJavaBridge.MethodId _VersionInfo34031;
		protected VersionInfo(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3, java.lang.String arg4) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.util.VersionInfo.staticClass, global::org.apache.http.util.VersionInfo._VersionInfo34031, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			Init(@__env, handle);
		}
		public static global::java.lang.String UNAVAILABLE
		{
			get
			{
				return "UNAVAILABLE";
			}
		}
		public static global::java.lang.String VERSION_PROPERTY_FILE
		{
			get
			{
				return "version.properties";
			}
		}
		public static global::java.lang.String PROPERTY_MODULE
		{
			get
			{
				return "info.module";
			}
		}
		public static global::java.lang.String PROPERTY_RELEASE
		{
			get
			{
				return "info.release";
			}
		}
		public static global::java.lang.String PROPERTY_TIMESTAMP
		{
			get
			{
				return "info.timestamp";
			}
		}
		static VersionInfo()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.util.VersionInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/util/VersionInfo"));
			global::org.apache.http.util.VersionInfo._toString34022 = @__env.GetMethodIDNoThrow(global::org.apache.http.util.VersionInfo.staticClass, "toString", "()Ljava/lang/String;");
			global::org.apache.http.util.VersionInfo._getPackage34023 = @__env.GetMethodIDNoThrow(global::org.apache.http.util.VersionInfo.staticClass, "getPackage", "()Ljava/lang/String;");
			global::org.apache.http.util.VersionInfo._getTimestamp34024 = @__env.GetMethodIDNoThrow(global::org.apache.http.util.VersionInfo.staticClass, "getTimestamp", "()Ljava/lang/String;");
			global::org.apache.http.util.VersionInfo._getModule34025 = @__env.GetMethodIDNoThrow(global::org.apache.http.util.VersionInfo.staticClass, "getModule", "()Ljava/lang/String;");
			global::org.apache.http.util.VersionInfo._getRelease34026 = @__env.GetMethodIDNoThrow(global::org.apache.http.util.VersionInfo.staticClass, "getRelease", "()Ljava/lang/String;");
			global::org.apache.http.util.VersionInfo._getClassloader34027 = @__env.GetMethodIDNoThrow(global::org.apache.http.util.VersionInfo.staticClass, "getClassloader", "()Ljava/lang/String;");
			global::org.apache.http.util.VersionInfo._loadVersionInfo34028 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.util.VersionInfo.staticClass, "loadVersionInfo", "([Ljava/lang/String;Ljava/lang/ClassLoader;)[Lorg/apache/http/util/VersionInfo;");
			global::org.apache.http.util.VersionInfo._loadVersionInfo34029 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.util.VersionInfo.staticClass, "loadVersionInfo", "(Ljava/lang/String;Ljava/lang/ClassLoader;)Lorg/apache/http/util/VersionInfo;");
			global::org.apache.http.util.VersionInfo._fromMap34030 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.util.VersionInfo.staticClass, "fromMap", "(Ljava/lang/String;Ljava/util/Map;Ljava/lang/ClassLoader;)Lorg/apache/http/util/VersionInfo;");
			global::org.apache.http.util.VersionInfo._VersionInfo34031 = @__env.GetMethodIDNoThrow(global::org.apache.http.util.VersionInfo.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
