namespace android.app
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AliasActivity : android.app.Activity
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AliasActivity()
		{
			InitJNI();
		}
		protected AliasActivity(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onCreate444;
		protected override void onCreate(android.os.Bundle arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.AliasActivity._onCreate444, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.AliasActivity.staticClass, global::android.app.AliasActivity._onCreate444, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _AliasActivity445;
		public AliasActivity()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.AliasActivity.staticClass, global::android.app.AliasActivity._AliasActivity445);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.app.AliasActivity.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/AliasActivity"));
			global::android.app.AliasActivity._onCreate444 = @__env.GetMethodIDNoThrow(global::android.app.AliasActivity.staticClass, "onCreate", "(Landroid/os/Bundle;)V");
			global::android.app.AliasActivity._AliasActivity445 = @__env.GetMethodIDNoThrow(global::android.app.AliasActivity.staticClass, "<init>", "()V");
		}
	}
}
