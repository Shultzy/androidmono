namespace android.content
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class SyncStats : java.lang.Object, android.os.Parcelable
	{
		internal static global::java.lang.Class staticClass;
		static SyncStats()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.content.SyncStats), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.content.SyncStats(@__env);
			}
		}
		protected SyncStats(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _clear1548;
		public virtual void clear() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.SyncStats._clear1548);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.SyncStats.staticClass, global::android.content.SyncStats._clear1548);
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString1549;
		public override global::java.lang.String toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.SyncStats._toString1549));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.SyncStats.staticClass, global::android.content.SyncStats._toString1549));
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel1550;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.SyncStats._writeToParcel1550, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.SyncStats.staticClass, global::android.content.SyncStats._writeToParcel1550, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _describeContents1551;
		public virtual int describeContents() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.SyncStats._describeContents1551);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.SyncStats.staticClass, global::android.content.SyncStats._describeContents1551);
		}
		internal static global::net.sf.jni4net.jni.MethodId _SyncStats1552;
		public SyncStats()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.content.SyncStats.staticClass, global::android.content.SyncStats._SyncStats1552, this);
		}
		internal static global::net.sf.jni4net.jni.MethodId _SyncStats1553;
		public SyncStats(android.os.Parcel arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.content.SyncStats.staticClass, global::android.content.SyncStats._SyncStats1553, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.FieldId _numAuthExceptions1554;
		public long numAuthExceptions
		{
			get
			{
				return default(long);
			}
			set
			{
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _numIoExceptions1555;
		public long numIoExceptions
		{
			get
			{
				return default(long);
			}
			set
			{
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _numParseExceptions1556;
		public long numParseExceptions
		{
			get
			{
				return default(long);
			}
			set
			{
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _numConflictDetectedExceptions1557;
		public long numConflictDetectedExceptions
		{
			get
			{
				return default(long);
			}
			set
			{
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _numInserts1558;
		public long numInserts
		{
			get
			{
				return default(long);
			}
			set
			{
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _numUpdates1559;
		public long numUpdates
		{
			get
			{
				return default(long);
			}
			set
			{
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _numDeletes1560;
		public long numDeletes
		{
			get
			{
				return default(long);
			}
			set
			{
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _numEntries1561;
		public long numEntries
		{
			get
			{
				return default(long);
			}
			set
			{
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _numSkippedEntries1562;
		public long numSkippedEntries
		{
			get
			{
				return default(long);
			}
			set
			{
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR1563;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				return default(global::android.os.Parcelable_Creator);
			}
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.content.SyncStats.staticClass = @__class;
			global::android.content.SyncStats._clear1548 = @__env.GetMethodID(global::android.content.SyncStats.staticClass, "clear", "()V");
			global::android.content.SyncStats._toString1549 = @__env.GetMethodID(global::android.content.SyncStats.staticClass, "toString", "()Ljava/lang/String;");
			global::android.content.SyncStats._writeToParcel1550 = @__env.GetMethodID(global::android.content.SyncStats.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.content.SyncStats._describeContents1551 = @__env.GetMethodID(global::android.content.SyncStats.staticClass, "describeContents", "()I");
			global::android.content.SyncStats._SyncStats1552 = @__env.GetMethodID(global::android.content.SyncStats.staticClass, "<init>", "()V");
			global::android.content.SyncStats._SyncStats1553 = @__env.GetMethodID(global::android.content.SyncStats.staticClass, "<init>", "(Landroid/os/Parcel;)V");
		}
	}
}