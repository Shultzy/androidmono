namespace android.text.style
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class RasterizerSpan : android.text.style.CharacterStyle, UpdateAppearance
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static RasterizerSpan()
		{
			InitJNI();
		}
		protected RasterizerSpan(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getRasterizer8314;
		public virtual global::android.graphics.Rasterizer getRasterizer() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.text.style.RasterizerSpan._getRasterizer8314)) as android.graphics.Rasterizer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.style.RasterizerSpan.staticClass, global::android.text.style.RasterizerSpan._getRasterizer8314)) as android.graphics.Rasterizer;
		}
		internal static global::MonoJavaBridge.MethodId _updateDrawState8315;
		public override void updateDrawState(android.text.TextPaint arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.style.RasterizerSpan._updateDrawState8315, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.style.RasterizerSpan.staticClass, global::android.text.style.RasterizerSpan._updateDrawState8315, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _RasterizerSpan8316;
		public RasterizerSpan(android.graphics.Rasterizer arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.RasterizerSpan.staticClass, global::android.text.style.RasterizerSpan._RasterizerSpan8316, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.style.RasterizerSpan.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/style/RasterizerSpan"));
			global::android.text.style.RasterizerSpan._getRasterizer8314 = @__env.GetMethodIDNoThrow(global::android.text.style.RasterizerSpan.staticClass, "getRasterizer", "()Landroid/graphics/Rasterizer;");
			global::android.text.style.RasterizerSpan._updateDrawState8315 = @__env.GetMethodIDNoThrow(global::android.text.style.RasterizerSpan.staticClass, "updateDrawState", "(Landroid/text/TextPaint;)V");
			global::android.text.style.RasterizerSpan._RasterizerSpan8316 = @__env.GetMethodIDNoThrow(global::android.text.style.RasterizerSpan.staticClass, "<init>", "(Landroid/graphics/Rasterizer;)V");
		}
	}
}
