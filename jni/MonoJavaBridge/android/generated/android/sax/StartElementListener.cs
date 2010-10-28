namespace android.sax
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.sax.StartElementListener_))]
	public partial interface StartElementListener  : global::MonoJavaBridge.IJavaObject 
	{
		void start(org.xml.sax.Attributes arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.sax.StartElementListener))]
	internal sealed partial class StartElementListener_ : java.lang.Object, StartElementListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal StartElementListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _start11617;
		void android.sax.StartElementListener.start(org.xml.sax.Attributes arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.sax.StartElementListener_._start11617, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.sax.StartElementListener_.staticClass, global::android.sax.StartElementListener_._start11617, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static StartElementListener_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.sax.StartElementListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/sax/StartElementListener"));
			global::android.sax.StartElementListener_._start11617 = @__env.GetMethodIDNoThrow(global::android.sax.StartElementListener_.staticClass, "start", "(Lorg/xml/sax/Attributes;)V");
		}
		internal static void InitJNI()
		{
		}
	}

	public delegate void StartElementListenerDelegate(org.xml.sax.Attributes arg0);

	internal partial class StartElementListenerDelegateWrapper : java.lang.Object, StartElementListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected StartElementListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _StartElementListenerDelegateWrapper11618;
		public StartElementListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.sax.StartElementListenerDelegateWrapper.staticClass, global::android.sax.StartElementListenerDelegateWrapper._StartElementListenerDelegateWrapper11618);
			Init(@__env, handle);
		}
		static StartElementListenerDelegateWrapper()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.sax.StartElementListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/sax/StartElementListenerDelegateWrapper"));
			global::android.sax.StartElementListenerDelegateWrapper._StartElementListenerDelegateWrapper11618 = @__env.GetMethodIDNoThrow(global::android.sax.StartElementListenerDelegateWrapper.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}
	internal partial class StartElementListenerDelegateWrapper
	{
		private StartElementListenerDelegate myDelegate;
		public void start(org.xml.sax.Attributes arg0)
		{
			myDelegate(arg0);
		}
		public static implicit operator StartElementListenerDelegateWrapper(StartElementListenerDelegate d)
		{
			global::android.sax.StartElementListenerDelegateWrapper ret = new global::android.sax.StartElementListenerDelegateWrapper();
			ret.myDelegate = d;
			global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
			return ret;
		}
	}
}
