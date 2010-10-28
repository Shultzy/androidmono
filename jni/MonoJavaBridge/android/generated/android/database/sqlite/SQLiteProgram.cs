namespace android.database.sqlite
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.database.sqlite.SQLiteProgram_))]
	public abstract partial class SQLiteProgram : android.database.sqlite.SQLiteClosable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SQLiteProgram(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _compile4818;
		protected virtual void compile(java.lang.String arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteProgram._compile4818, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteProgram.staticClass, global::android.database.sqlite.SQLiteProgram._compile4818, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _close4819;
		public virtual void close()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteProgram._close4819);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteProgram.staticClass, global::android.database.sqlite.SQLiteProgram._close4819);
		}
		internal static global::MonoJavaBridge.MethodId _onAllReferencesReleased4820;
		protected override void onAllReferencesReleased()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteProgram._onAllReferencesReleased4820);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteProgram.staticClass, global::android.database.sqlite.SQLiteProgram._onAllReferencesReleased4820);
		}
		internal static global::MonoJavaBridge.MethodId _onAllReferencesReleasedFromContainer4821;
		protected override void onAllReferencesReleasedFromContainer()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteProgram._onAllReferencesReleasedFromContainer4821);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteProgram.staticClass, global::android.database.sqlite.SQLiteProgram._onAllReferencesReleasedFromContainer4821);
		}
		internal static global::MonoJavaBridge.MethodId _bindNull4822;
		public virtual void bindNull(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteProgram._bindNull4822, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteProgram.staticClass, global::android.database.sqlite.SQLiteProgram._bindNull4822, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getUniqueId4823;
		public virtual int getUniqueId()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.database.sqlite.SQLiteProgram._getUniqueId4823);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.database.sqlite.SQLiteProgram.staticClass, global::android.database.sqlite.SQLiteProgram._getUniqueId4823);
		}
		internal static global::MonoJavaBridge.MethodId _bindLong4824;
		public virtual void bindLong(int arg0, long arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteProgram._bindLong4824, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteProgram.staticClass, global::android.database.sqlite.SQLiteProgram._bindLong4824, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _bindDouble4825;
		public virtual void bindDouble(int arg0, double arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteProgram._bindDouble4825, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteProgram.staticClass, global::android.database.sqlite.SQLiteProgram._bindDouble4825, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _bindString4826;
		public virtual void bindString(int arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteProgram._bindString4826, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteProgram.staticClass, global::android.database.sqlite.SQLiteProgram._bindString4826, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _bindBlob4827;
		public virtual void bindBlob(int arg0, byte[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteProgram._bindBlob4827, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteProgram.staticClass, global::android.database.sqlite.SQLiteProgram._bindBlob4827, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _clearBindings4828;
		public virtual void clearBindings()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteProgram._clearBindings4828);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteProgram.staticClass, global::android.database.sqlite.SQLiteProgram._clearBindings4828);
		}
		internal static global::MonoJavaBridge.MethodId _native_compile4829;
		protected virtual void native_compile(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteProgram._native_compile4829, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteProgram.staticClass, global::android.database.sqlite.SQLiteProgram._native_compile4829, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _native_finalize4830;
		protected virtual void native_finalize()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteProgram._native_finalize4830);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteProgram.staticClass, global::android.database.sqlite.SQLiteProgram._native_finalize4830);
		}
		internal static global::MonoJavaBridge.MethodId _native_bind_null4831;
		protected virtual void native_bind_null(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteProgram._native_bind_null4831, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteProgram.staticClass, global::android.database.sqlite.SQLiteProgram._native_bind_null4831, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _native_bind_long4832;
		protected virtual void native_bind_long(int arg0, long arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteProgram._native_bind_long4832, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteProgram.staticClass, global::android.database.sqlite.SQLiteProgram._native_bind_long4832, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _native_bind_double4833;
		protected virtual void native_bind_double(int arg0, double arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteProgram._native_bind_double4833, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteProgram.staticClass, global::android.database.sqlite.SQLiteProgram._native_bind_double4833, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _native_bind_string4834;
		protected virtual void native_bind_string(int arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteProgram._native_bind_string4834, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteProgram.staticClass, global::android.database.sqlite.SQLiteProgram._native_bind_string4834, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _native_bind_blob4835;
		protected virtual void native_bind_blob(int arg0, byte[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteProgram._native_bind_blob4835, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteProgram.staticClass, global::android.database.sqlite.SQLiteProgram._native_bind_blob4835, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		static SQLiteProgram()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.sqlite.SQLiteProgram.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/sqlite/SQLiteProgram"));
			global::android.database.sqlite.SQLiteProgram._compile4818 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteProgram.staticClass, "compile", "(Ljava/lang/String;Z)V");
			global::android.database.sqlite.SQLiteProgram._close4819 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteProgram.staticClass, "close", "()V");
			global::android.database.sqlite.SQLiteProgram._onAllReferencesReleased4820 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteProgram.staticClass, "onAllReferencesReleased", "()V");
			global::android.database.sqlite.SQLiteProgram._onAllReferencesReleasedFromContainer4821 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteProgram.staticClass, "onAllReferencesReleasedFromContainer", "()V");
			global::android.database.sqlite.SQLiteProgram._bindNull4822 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteProgram.staticClass, "bindNull", "(I)V");
			global::android.database.sqlite.SQLiteProgram._getUniqueId4823 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteProgram.staticClass, "getUniqueId", "()I");
			global::android.database.sqlite.SQLiteProgram._bindLong4824 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteProgram.staticClass, "bindLong", "(IJ)V");
			global::android.database.sqlite.SQLiteProgram._bindDouble4825 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteProgram.staticClass, "bindDouble", "(ID)V");
			global::android.database.sqlite.SQLiteProgram._bindString4826 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteProgram.staticClass, "bindString", "(ILjava/lang/String;)V");
			global::android.database.sqlite.SQLiteProgram._bindBlob4827 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteProgram.staticClass, "bindBlob", "(I[B)V");
			global::android.database.sqlite.SQLiteProgram._clearBindings4828 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteProgram.staticClass, "clearBindings", "()V");
			global::android.database.sqlite.SQLiteProgram._native_compile4829 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteProgram.staticClass, "native_compile", "(Ljava/lang/String;)V");
			global::android.database.sqlite.SQLiteProgram._native_finalize4830 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteProgram.staticClass, "native_finalize", "()V");
			global::android.database.sqlite.SQLiteProgram._native_bind_null4831 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteProgram.staticClass, "native_bind_null", "(I)V");
			global::android.database.sqlite.SQLiteProgram._native_bind_long4832 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteProgram.staticClass, "native_bind_long", "(IJ)V");
			global::android.database.sqlite.SQLiteProgram._native_bind_double4833 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteProgram.staticClass, "native_bind_double", "(ID)V");
			global::android.database.sqlite.SQLiteProgram._native_bind_string4834 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteProgram.staticClass, "native_bind_string", "(ILjava/lang/String;)V");
			global::android.database.sqlite.SQLiteProgram._native_bind_blob4835 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteProgram.staticClass, "native_bind_blob", "(I[B)V");
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.database.sqlite.SQLiteProgram))]
	internal sealed partial class SQLiteProgram_ : android.database.sqlite.SQLiteProgram
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal SQLiteProgram_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		static SQLiteProgram_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.sqlite.SQLiteProgram_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/sqlite/SQLiteProgram"));
		}
		internal static void InitJNI()
		{
		}
	}
}
