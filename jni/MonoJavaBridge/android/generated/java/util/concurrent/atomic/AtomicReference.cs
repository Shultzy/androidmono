namespace java.util.concurrent.atomic
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AtomicReference : java.lang.Object, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AtomicReference(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get27648;
		public virtual global::java.lang.Object get()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicReference._get27648)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicReference.staticClass, global::java.util.concurrent.atomic.AtomicReference._get27648)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _toString27649;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicReference._toString27649)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicReference.staticClass, global::java.util.concurrent.atomic.AtomicReference._toString27649)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _set27650;
		public virtual void set(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicReference._set27650, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicReference.staticClass, global::java.util.concurrent.atomic.AtomicReference._set27650, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _lazySet27651;
		public virtual void lazySet(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicReference._lazySet27651, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicReference.staticClass, global::java.util.concurrent.atomic.AtomicReference._lazySet27651, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getAndSet27652;
		public virtual global::java.lang.Object getAndSet(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicReference._getAndSet27652, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicReference.staticClass, global::java.util.concurrent.atomic.AtomicReference._getAndSet27652, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _compareAndSet27653;
		public virtual bool compareAndSet(java.lang.Object arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicReference._compareAndSet27653, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicReference.staticClass, global::java.util.concurrent.atomic.AtomicReference._compareAndSet27653, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _weakCompareAndSet27654;
		public virtual bool weakCompareAndSet(java.lang.Object arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicReference._weakCompareAndSet27654, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicReference.staticClass, global::java.util.concurrent.atomic.AtomicReference._weakCompareAndSet27654, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _AtomicReference27655;
		public AtomicReference(java.lang.Object arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.atomic.AtomicReference.staticClass, global::java.util.concurrent.atomic.AtomicReference._AtomicReference27655, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AtomicReference27656;
		public AtomicReference() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.atomic.AtomicReference.staticClass, global::java.util.concurrent.atomic.AtomicReference._AtomicReference27656);
			Init(@__env, handle);
		}
		static AtomicReference()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.atomic.AtomicReference.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/atomic/AtomicReference"));
			global::java.util.concurrent.atomic.AtomicReference._get27648 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicReference.staticClass, "get", "()Ljava/lang/Object;");
			global::java.util.concurrent.atomic.AtomicReference._toString27649 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicReference.staticClass, "toString", "()Ljava/lang/String;");
			global::java.util.concurrent.atomic.AtomicReference._set27650 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicReference.staticClass, "set", "(Ljava/lang/Object;)V");
			global::java.util.concurrent.atomic.AtomicReference._lazySet27651 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicReference.staticClass, "lazySet", "(Ljava/lang/Object;)V");
			global::java.util.concurrent.atomic.AtomicReference._getAndSet27652 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicReference.staticClass, "getAndSet", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.concurrent.atomic.AtomicReference._compareAndSet27653 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicReference.staticClass, "compareAndSet", "(Ljava/lang/Object;Ljava/lang/Object;)Z");
			global::java.util.concurrent.atomic.AtomicReference._weakCompareAndSet27654 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicReference.staticClass, "weakCompareAndSet", "(Ljava/lang/Object;Ljava/lang/Object;)Z");
			global::java.util.concurrent.atomic.AtomicReference._AtomicReference27655 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicReference.staticClass, "<init>", "(Ljava/lang/Object;)V");
			global::java.util.concurrent.atomic.AtomicReference._AtomicReference27656 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicReference.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}
}
