namespace junit.framework
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ComparisonFailure : junit.framework.AssertionFailedError
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ComparisonFailure(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.lang.String Message
		{
			get
			{
				return getMessage();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMessage31372;
		public override global::java.lang.String getMessage()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::junit.framework.ComparisonFailure._getMessage31372)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::junit.framework.ComparisonFailure.staticClass, global::junit.framework.ComparisonFailure._getMessage31372)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _ComparisonFailure31373;
		public ComparisonFailure(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(junit.framework.ComparisonFailure.staticClass, global::junit.framework.ComparisonFailure._ComparisonFailure31373, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static ComparisonFailure()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::junit.framework.ComparisonFailure.staticClass = @__env.NewGlobalRef(@__env.FindClass("junit/framework/ComparisonFailure"));
			global::junit.framework.ComparisonFailure._getMessage31372 = @__env.GetMethodIDNoThrow(global::junit.framework.ComparisonFailure.staticClass, "getMessage", "()Ljava/lang/String;");
			global::junit.framework.ComparisonFailure._ComparisonFailure31373 = @__env.GetMethodIDNoThrow(global::junit.framework.ComparisonFailure.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
