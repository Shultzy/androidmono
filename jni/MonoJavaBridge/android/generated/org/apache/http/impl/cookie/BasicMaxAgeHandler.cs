namespace org.apache.http.impl.cookie
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BasicMaxAgeHandler : org.apache.http.impl.cookie.AbstractCookieAttributeHandler
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected BasicMaxAgeHandler(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _parse33259;
		public override void parse(org.apache.http.cookie.SetCookie arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.cookie.BasicMaxAgeHandler._parse33259, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.cookie.BasicMaxAgeHandler.staticClass, global::org.apache.http.impl.cookie.BasicMaxAgeHandler._parse33259, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _BasicMaxAgeHandler33260;
		public BasicMaxAgeHandler() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.cookie.BasicMaxAgeHandler.staticClass, global::org.apache.http.impl.cookie.BasicMaxAgeHandler._BasicMaxAgeHandler33260);
			Init(@__env, handle);
		}
		static BasicMaxAgeHandler()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.cookie.BasicMaxAgeHandler.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/cookie/BasicMaxAgeHandler"));
			global::org.apache.http.impl.cookie.BasicMaxAgeHandler._parse33259 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.BasicMaxAgeHandler.staticClass, "parse", "(Lorg/apache/http/cookie/SetCookie;Ljava/lang/String;)V");
			global::org.apache.http.impl.cookie.BasicMaxAgeHandler._BasicMaxAgeHandler33260 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.BasicMaxAgeHandler.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}
}
