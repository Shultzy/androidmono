namespace android.content.res
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class AssetManager : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AssetManager()
		{
			InitJNI();
		}
		internal AssetManager(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class AssetInputStream : java.io.InputStream
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static AssetInputStream()
			{
				InitJNI();
			}
			internal AssetInputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _close2225;
			public sealed override void close() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.content.res.AssetManager.AssetInputStream._close2225);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.res.AssetManager.AssetInputStream.staticClass, global::android.content.res.AssetManager.AssetInputStream._close2225);
			}
			internal static global::MonoJavaBridge.MethodId _mark2226;
			public sealed override void mark(int arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.content.res.AssetManager.AssetInputStream._mark2226, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.res.AssetManager.AssetInputStream.staticClass, global::android.content.res.AssetManager.AssetInputStream._mark2226, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _reset2227;
			public sealed override void reset() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.content.res.AssetManager.AssetInputStream._reset2227);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.res.AssetManager.AssetInputStream.staticClass, global::android.content.res.AssetManager.AssetInputStream._reset2227);
			}
			internal static global::MonoJavaBridge.MethodId _read2228;
			public sealed override int read() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.content.res.AssetManager.AssetInputStream._read2228);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.res.AssetManager.AssetInputStream.staticClass, global::android.content.res.AssetManager.AssetInputStream._read2228);
			}
			internal static global::MonoJavaBridge.MethodId _read2229;
			public sealed override int read(byte[] arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.content.res.AssetManager.AssetInputStream._read2229, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.res.AssetManager.AssetInputStream.staticClass, global::android.content.res.AssetManager.AssetInputStream._read2229, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _read2230;
			public sealed override int read(byte[] arg0, int arg1, int arg2) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.content.res.AssetManager.AssetInputStream._read2230, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.res.AssetManager.AssetInputStream.staticClass, global::android.content.res.AssetManager.AssetInputStream._read2230, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			internal static global::MonoJavaBridge.MethodId _skip2231;
			public sealed override long skip(long arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallLongMethod(this.JvmHandle, global::android.content.res.AssetManager.AssetInputStream._skip2231, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.content.res.AssetManager.AssetInputStream.staticClass, global::android.content.res.AssetManager.AssetInputStream._skip2231, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _available2232;
			public sealed override int available() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.content.res.AssetManager.AssetInputStream._available2232);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.res.AssetManager.AssetInputStream.staticClass, global::android.content.res.AssetManager.AssetInputStream._available2232);
			}
			internal static global::MonoJavaBridge.MethodId _markSupported2233;
			public sealed override bool markSupported() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.res.AssetManager.AssetInputStream._markSupported2233);
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.res.AssetManager.AssetInputStream.staticClass, global::android.content.res.AssetManager.AssetInputStream._markSupported2233);
			}
			internal static global::MonoJavaBridge.MethodId _getAssetInt2234;
			public int getAssetInt() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.content.res.AssetManager.AssetInputStream._getAssetInt2234);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.res.AssetManager.AssetInputStream.staticClass, global::android.content.res.AssetManager.AssetInputStream._getAssetInt2234);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.content.res.AssetManager.AssetInputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/res/AssetManager$AssetInputStream"));
				global::android.content.res.AssetManager.AssetInputStream._close2225 = @__env.GetMethodIDNoThrow(global::android.content.res.AssetManager.AssetInputStream.staticClass, "close", "()V");
				global::android.content.res.AssetManager.AssetInputStream._mark2226 = @__env.GetMethodIDNoThrow(global::android.content.res.AssetManager.AssetInputStream.staticClass, "mark", "(I)V");
				global::android.content.res.AssetManager.AssetInputStream._reset2227 = @__env.GetMethodIDNoThrow(global::android.content.res.AssetManager.AssetInputStream.staticClass, "reset", "()V");
				global::android.content.res.AssetManager.AssetInputStream._read2228 = @__env.GetMethodIDNoThrow(global::android.content.res.AssetManager.AssetInputStream.staticClass, "read", "()I");
				global::android.content.res.AssetManager.AssetInputStream._read2229 = @__env.GetMethodIDNoThrow(global::android.content.res.AssetManager.AssetInputStream.staticClass, "read", "([B)I");
				global::android.content.res.AssetManager.AssetInputStream._read2230 = @__env.GetMethodIDNoThrow(global::android.content.res.AssetManager.AssetInputStream.staticClass, "read", "([BII)I");
				global::android.content.res.AssetManager.AssetInputStream._skip2231 = @__env.GetMethodIDNoThrow(global::android.content.res.AssetManager.AssetInputStream.staticClass, "skip", "(J)J");
				global::android.content.res.AssetManager.AssetInputStream._available2232 = @__env.GetMethodIDNoThrow(global::android.content.res.AssetManager.AssetInputStream.staticClass, "available", "()I");
				global::android.content.res.AssetManager.AssetInputStream._markSupported2233 = @__env.GetMethodIDNoThrow(global::android.content.res.AssetManager.AssetInputStream.staticClass, "markSupported", "()Z");
				global::android.content.res.AssetManager.AssetInputStream._getAssetInt2234 = @__env.GetMethodIDNoThrow(global::android.content.res.AssetManager.AssetInputStream.staticClass, "getAssetInt", "()I");
			}
		}
		internal static global::MonoJavaBridge.MethodId _list2235;
		public global::java.lang.String[] list(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.res.AssetManager._list2235, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.res.AssetManager.staticClass, global::android.content.res.AssetManager._list2235, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _close2236;
		public void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.res.AssetManager._close2236);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.res.AssetManager.staticClass, global::android.content.res.AssetManager._close2236);
		}
		internal static global::MonoJavaBridge.MethodId _open2237;
		public global::java.io.InputStream open(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.res.AssetManager._open2237, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.io.InputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.res.AssetManager.staticClass, global::android.content.res.AssetManager._open2237, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _open2238;
		public global::java.io.InputStream open(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.res.AssetManager._open2238, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.InputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.res.AssetManager.staticClass, global::android.content.res.AssetManager._open2238, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _openFd2239;
		public global::android.content.res.AssetFileDescriptor openFd(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.res.AssetManager._openFd2239, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.res.AssetFileDescriptor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.res.AssetManager.staticClass, global::android.content.res.AssetManager._openFd2239, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.res.AssetFileDescriptor;
		}
		internal static global::MonoJavaBridge.MethodId _openNonAssetFd2240;
		public global::android.content.res.AssetFileDescriptor openNonAssetFd(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.res.AssetManager._openNonAssetFd2240, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.res.AssetFileDescriptor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.res.AssetManager.staticClass, global::android.content.res.AssetManager._openNonAssetFd2240, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.res.AssetFileDescriptor;
		}
		internal static global::MonoJavaBridge.MethodId _openNonAssetFd2241;
		public global::android.content.res.AssetFileDescriptor openNonAssetFd(int arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.res.AssetManager._openNonAssetFd2241, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.res.AssetFileDescriptor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.res.AssetManager.staticClass, global::android.content.res.AssetManager._openNonAssetFd2241, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.res.AssetFileDescriptor;
		}
		internal static global::MonoJavaBridge.MethodId _openXmlResourceParser2242;
		public global::android.content.res.XmlResourceParser openXmlResourceParser(int arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.content.res.XmlResourceParser>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.res.AssetManager._openXmlResourceParser2242, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.res.XmlResourceParser;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.content.res.XmlResourceParser>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.res.AssetManager.staticClass, global::android.content.res.AssetManager._openXmlResourceParser2242, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.res.XmlResourceParser;
		}
		internal static global::MonoJavaBridge.MethodId _openXmlResourceParser2243;
		public global::android.content.res.XmlResourceParser openXmlResourceParser(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.content.res.XmlResourceParser>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.res.AssetManager._openXmlResourceParser2243, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.res.XmlResourceParser;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.content.res.XmlResourceParser>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.res.AssetManager.staticClass, global::android.content.res.AssetManager._openXmlResourceParser2243, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.res.XmlResourceParser;
		}
		internal static global::MonoJavaBridge.MethodId _getLocales2244;
		public global::java.lang.String[] getLocales() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.res.AssetManager._getLocales2244)) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.res.AssetManager.staticClass, global::android.content.res.AssetManager._getLocales2244)) as java.lang.String[];
		}
		public static int ACCESS_UNKNOWN
		{
			get
			{
				return 0;
			}
		}
		public static int ACCESS_RANDOM
		{
			get
			{
				return 1;
			}
		}
		public static int ACCESS_STREAMING
		{
			get
			{
				return 2;
			}
		}
		public static int ACCESS_BUFFER
		{
			get
			{
				return 3;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.res.AssetManager.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/res/AssetManager"));
			global::android.content.res.AssetManager._list2235 = @__env.GetMethodIDNoThrow(global::android.content.res.AssetManager.staticClass, "list", "(Ljava/lang/String;)[Ljava/lang/String;");
			global::android.content.res.AssetManager._close2236 = @__env.GetMethodIDNoThrow(global::android.content.res.AssetManager.staticClass, "close", "()V");
			global::android.content.res.AssetManager._open2237 = @__env.GetMethodIDNoThrow(global::android.content.res.AssetManager.staticClass, "open", "(Ljava/lang/String;I)Ljava/io/InputStream;");
			global::android.content.res.AssetManager._open2238 = @__env.GetMethodIDNoThrow(global::android.content.res.AssetManager.staticClass, "open", "(Ljava/lang/String;)Ljava/io/InputStream;");
			global::android.content.res.AssetManager._openFd2239 = @__env.GetMethodIDNoThrow(global::android.content.res.AssetManager.staticClass, "openFd", "(Ljava/lang/String;)Landroid/content/res/AssetFileDescriptor;");
			global::android.content.res.AssetManager._openNonAssetFd2240 = @__env.GetMethodIDNoThrow(global::android.content.res.AssetManager.staticClass, "openNonAssetFd", "(Ljava/lang/String;)Landroid/content/res/AssetFileDescriptor;");
			global::android.content.res.AssetManager._openNonAssetFd2241 = @__env.GetMethodIDNoThrow(global::android.content.res.AssetManager.staticClass, "openNonAssetFd", "(ILjava/lang/String;)Landroid/content/res/AssetFileDescriptor;");
			global::android.content.res.AssetManager._openXmlResourceParser2242 = @__env.GetMethodIDNoThrow(global::android.content.res.AssetManager.staticClass, "openXmlResourceParser", "(ILjava/lang/String;)Landroid/content/res/XmlResourceParser;");
			global::android.content.res.AssetManager._openXmlResourceParser2243 = @__env.GetMethodIDNoThrow(global::android.content.res.AssetManager.staticClass, "openXmlResourceParser", "(Ljava/lang/String;)Landroid/content/res/XmlResourceParser;");
			global::android.content.res.AssetManager._getLocales2244 = @__env.GetMethodIDNoThrow(global::android.content.res.AssetManager.staticClass, "getLocales", "()[Ljava/lang/String;");
		}
	}
}
