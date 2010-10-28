namespace java.util.logging
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class MemoryHandler : java.util.logging.Handler
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected MemoryHandler(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _push28089;
		public virtual void push()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.logging.MemoryHandler._push28089);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.logging.MemoryHandler.staticClass, global::java.util.logging.MemoryHandler._push28089);
		}
		internal static global::MonoJavaBridge.MethodId _flush28090;
		public override void flush()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.logging.MemoryHandler._flush28090);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.logging.MemoryHandler.staticClass, global::java.util.logging.MemoryHandler._flush28090);
		}
		internal static global::MonoJavaBridge.MethodId _close28091;
		public override void close()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.logging.MemoryHandler._close28091);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.logging.MemoryHandler.staticClass, global::java.util.logging.MemoryHandler._close28091);
		}
		internal static global::MonoJavaBridge.MethodId _isLoggable28092;
		public override bool isLoggable(java.util.logging.LogRecord arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.logging.MemoryHandler._isLoggable28092, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.logging.MemoryHandler.staticClass, global::java.util.logging.MemoryHandler._isLoggable28092, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _publish28093;
		public override void publish(java.util.logging.LogRecord arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.logging.MemoryHandler._publish28093, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.logging.MemoryHandler.staticClass, global::java.util.logging.MemoryHandler._publish28093, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setPushLevel28094;
		public virtual void setPushLevel(java.util.logging.Level arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.logging.MemoryHandler._setPushLevel28094, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.logging.MemoryHandler.staticClass, global::java.util.logging.MemoryHandler._setPushLevel28094, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.util.logging.Level PushLevel
		{
			get
			{
				return getPushLevel();
			}
			set
			{
				setPushLevel(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPushLevel28095;
		public virtual global::java.util.logging.Level getPushLevel()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.logging.MemoryHandler._getPushLevel28095)) as java.util.logging.Level;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.logging.MemoryHandler.staticClass, global::java.util.logging.MemoryHandler._getPushLevel28095)) as java.util.logging.Level;
		}
		internal static global::MonoJavaBridge.MethodId _MemoryHandler28096;
		public MemoryHandler() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.logging.MemoryHandler.staticClass, global::java.util.logging.MemoryHandler._MemoryHandler28096);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _MemoryHandler28097;
		public MemoryHandler(java.util.logging.Handler arg0, int arg1, java.util.logging.Level arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.logging.MemoryHandler.staticClass, global::java.util.logging.MemoryHandler._MemoryHandler28097, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static MemoryHandler()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.logging.MemoryHandler.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/logging/MemoryHandler"));
			global::java.util.logging.MemoryHandler._push28089 = @__env.GetMethodIDNoThrow(global::java.util.logging.MemoryHandler.staticClass, "push", "()V");
			global::java.util.logging.MemoryHandler._flush28090 = @__env.GetMethodIDNoThrow(global::java.util.logging.MemoryHandler.staticClass, "flush", "()V");
			global::java.util.logging.MemoryHandler._close28091 = @__env.GetMethodIDNoThrow(global::java.util.logging.MemoryHandler.staticClass, "close", "()V");
			global::java.util.logging.MemoryHandler._isLoggable28092 = @__env.GetMethodIDNoThrow(global::java.util.logging.MemoryHandler.staticClass, "isLoggable", "(Ljava/util/logging/LogRecord;)Z");
			global::java.util.logging.MemoryHandler._publish28093 = @__env.GetMethodIDNoThrow(global::java.util.logging.MemoryHandler.staticClass, "publish", "(Ljava/util/logging/LogRecord;)V");
			global::java.util.logging.MemoryHandler._setPushLevel28094 = @__env.GetMethodIDNoThrow(global::java.util.logging.MemoryHandler.staticClass, "setPushLevel", "(Ljava/util/logging/Level;)V");
			global::java.util.logging.MemoryHandler._getPushLevel28095 = @__env.GetMethodIDNoThrow(global::java.util.logging.MemoryHandler.staticClass, "getPushLevel", "()Ljava/util/logging/Level;");
			global::java.util.logging.MemoryHandler._MemoryHandler28096 = @__env.GetMethodIDNoThrow(global::java.util.logging.MemoryHandler.staticClass, "<init>", "()V");
			global::java.util.logging.MemoryHandler._MemoryHandler28097 = @__env.GetMethodIDNoThrow(global::java.util.logging.MemoryHandler.staticClass, "<init>", "(Ljava/util/logging/Handler;ILjava/util/logging/Level;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
