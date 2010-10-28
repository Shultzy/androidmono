namespace org.apache.http.conn.ssl
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class StrictHostnameVerifier : org.apache.http.conn.ssl.AbstractVerifier
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected StrictHostnameVerifier(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString32356;
		public sealed override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.ssl.StrictHostnameVerifier._toString32356)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.ssl.StrictHostnameVerifier.staticClass, global::org.apache.http.conn.ssl.StrictHostnameVerifier._toString32356)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _verify32357;
		public sealed override void verify(java.lang.String arg0, java.lang.String[] arg1, java.lang.String[] arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.ssl.StrictHostnameVerifier._verify32357, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.ssl.StrictHostnameVerifier.staticClass, global::org.apache.http.conn.ssl.StrictHostnameVerifier._verify32357, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _StrictHostnameVerifier32358;
		public StrictHostnameVerifier() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.conn.ssl.StrictHostnameVerifier.staticClass, global::org.apache.http.conn.ssl.StrictHostnameVerifier._StrictHostnameVerifier32358);
			Init(@__env, handle);
		}
		static StrictHostnameVerifier()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.conn.ssl.StrictHostnameVerifier.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/conn/ssl/StrictHostnameVerifier"));
			global::org.apache.http.conn.ssl.StrictHostnameVerifier._toString32356 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ssl.StrictHostnameVerifier.staticClass, "toString", "()Ljava/lang/String;");
			global::org.apache.http.conn.ssl.StrictHostnameVerifier._verify32357 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ssl.StrictHostnameVerifier.staticClass, "verify", "(Ljava/lang/String;[Ljava/lang/String;[Ljava/lang/String;)V");
			global::org.apache.http.conn.ssl.StrictHostnameVerifier._StrictHostnameVerifier32358 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ssl.StrictHostnameVerifier.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}
}
