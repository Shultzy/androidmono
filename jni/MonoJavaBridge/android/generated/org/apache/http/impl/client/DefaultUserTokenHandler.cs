namespace org.apache.http.impl.client
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DefaultUserTokenHandler : java.lang.Object, org.apache.http.client.UserTokenHandler
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DefaultUserTokenHandler(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getUserToken32927;
		public virtual global::java.lang.Object getUserToken(org.apache.http.protocol.HttpContext arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.DefaultUserTokenHandler._getUserToken32927, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.DefaultUserTokenHandler.staticClass, global::org.apache.http.impl.client.DefaultUserTokenHandler._getUserToken32927, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _DefaultUserTokenHandler32928;
		public DefaultUserTokenHandler() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.client.DefaultUserTokenHandler.staticClass, global::org.apache.http.impl.client.DefaultUserTokenHandler._DefaultUserTokenHandler32928);
			Init(@__env, handle);
		}
		static DefaultUserTokenHandler()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.client.DefaultUserTokenHandler.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/client/DefaultUserTokenHandler"));
			global::org.apache.http.impl.client.DefaultUserTokenHandler._getUserToken32927 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.DefaultUserTokenHandler.staticClass, "getUserToken", "(Lorg/apache/http/protocol/HttpContext;)Ljava/lang/Object;");
			global::org.apache.http.impl.client.DefaultUserTokenHandler._DefaultUserTokenHandler32928 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.DefaultUserTokenHandler.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}
}
