namespace java.security
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.security.AlgorithmParameterGeneratorSpi_))]
	public abstract partial class AlgorithmParameterGeneratorSpi : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AlgorithmParameterGeneratorSpi(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _engineInit22856;
		protected abstract void engineInit(int arg0, java.security.SecureRandom arg1);
		internal static global::MonoJavaBridge.MethodId _engineInit22857;
		protected abstract void engineInit(java.security.spec.AlgorithmParameterSpec arg0, java.security.SecureRandom arg1);
		internal static global::MonoJavaBridge.MethodId _engineGenerateParameters22858;
		protected abstract global::java.security.AlgorithmParameters engineGenerateParameters();
		internal static global::MonoJavaBridge.MethodId _AlgorithmParameterGeneratorSpi22859;
		public AlgorithmParameterGeneratorSpi() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.AlgorithmParameterGeneratorSpi.staticClass, global::java.security.AlgorithmParameterGeneratorSpi._AlgorithmParameterGeneratorSpi22859);
			Init(@__env, handle);
		}
		static AlgorithmParameterGeneratorSpi()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.AlgorithmParameterGeneratorSpi.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/AlgorithmParameterGeneratorSpi"));
			global::java.security.AlgorithmParameterGeneratorSpi._engineInit22856 = @__env.GetMethodIDNoThrow(global::java.security.AlgorithmParameterGeneratorSpi.staticClass, "engineInit", "(ILjava/security/SecureRandom;)V");
			global::java.security.AlgorithmParameterGeneratorSpi._engineInit22857 = @__env.GetMethodIDNoThrow(global::java.security.AlgorithmParameterGeneratorSpi.staticClass, "engineInit", "(Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)V");
			global::java.security.AlgorithmParameterGeneratorSpi._engineGenerateParameters22858 = @__env.GetMethodIDNoThrow(global::java.security.AlgorithmParameterGeneratorSpi.staticClass, "engineGenerateParameters", "()Ljava/security/AlgorithmParameters;");
			global::java.security.AlgorithmParameterGeneratorSpi._AlgorithmParameterGeneratorSpi22859 = @__env.GetMethodIDNoThrow(global::java.security.AlgorithmParameterGeneratorSpi.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.AlgorithmParameterGeneratorSpi))]
	internal sealed partial class AlgorithmParameterGeneratorSpi_ : java.security.AlgorithmParameterGeneratorSpi
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal AlgorithmParameterGeneratorSpi_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _engineInit22860;
		protected override void engineInit(int arg0, java.security.SecureRandom arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.AlgorithmParameterGeneratorSpi_._engineInit22860, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.AlgorithmParameterGeneratorSpi_.staticClass, global::java.security.AlgorithmParameterGeneratorSpi_._engineInit22860, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _engineInit22861;
		protected override void engineInit(java.security.spec.AlgorithmParameterSpec arg0, java.security.SecureRandom arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.AlgorithmParameterGeneratorSpi_._engineInit22861, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.AlgorithmParameterGeneratorSpi_.staticClass, global::java.security.AlgorithmParameterGeneratorSpi_._engineInit22861, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _engineGenerateParameters22862;
		protected override global::java.security.AlgorithmParameters engineGenerateParameters()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.AlgorithmParameterGeneratorSpi_._engineGenerateParameters22862)) as java.security.AlgorithmParameters;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.AlgorithmParameterGeneratorSpi_.staticClass, global::java.security.AlgorithmParameterGeneratorSpi_._engineGenerateParameters22862)) as java.security.AlgorithmParameters;
		}
		static AlgorithmParameterGeneratorSpi_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.AlgorithmParameterGeneratorSpi_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/AlgorithmParameterGeneratorSpi"));
			global::java.security.AlgorithmParameterGeneratorSpi_._engineInit22860 = @__env.GetMethodIDNoThrow(global::java.security.AlgorithmParameterGeneratorSpi_.staticClass, "engineInit", "(ILjava/security/SecureRandom;)V");
			global::java.security.AlgorithmParameterGeneratorSpi_._engineInit22861 = @__env.GetMethodIDNoThrow(global::java.security.AlgorithmParameterGeneratorSpi_.staticClass, "engineInit", "(Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)V");
			global::java.security.AlgorithmParameterGeneratorSpi_._engineGenerateParameters22862 = @__env.GetMethodIDNoThrow(global::java.security.AlgorithmParameterGeneratorSpi_.staticClass, "engineGenerateParameters", "()Ljava/security/AlgorithmParameters;");
		}
		internal static void InitJNI()
		{
		}
	}
}
