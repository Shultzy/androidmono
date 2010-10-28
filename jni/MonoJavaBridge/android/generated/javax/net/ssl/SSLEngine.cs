namespace javax.net.ssl
{
	[global::MonoJavaBridge.JavaClass(typeof(global::javax.net.ssl.SSLEngine_))]
	public abstract partial class SSLEngine : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SSLEngine(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _wrap29912;
		public virtual global::javax.net.ssl.SSLEngineResult wrap(java.nio.ByteBuffer[] arg0, java.nio.ByteBuffer arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine._wrap29912, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as javax.net.ssl.SSLEngineResult;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine.staticClass, global::javax.net.ssl.SSLEngine._wrap29912, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as javax.net.ssl.SSLEngineResult;
		}
		internal static global::MonoJavaBridge.MethodId _wrap29913;
		public abstract global::javax.net.ssl.SSLEngineResult wrap(java.nio.ByteBuffer[] arg0, int arg1, int arg2, java.nio.ByteBuffer arg3);
		internal static global::MonoJavaBridge.MethodId _wrap29914;
		public virtual global::javax.net.ssl.SSLEngineResult wrap(java.nio.ByteBuffer arg0, java.nio.ByteBuffer arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine._wrap29914, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as javax.net.ssl.SSLEngineResult;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine.staticClass, global::javax.net.ssl.SSLEngine._wrap29914, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as javax.net.ssl.SSLEngineResult;
		}
		internal static global::MonoJavaBridge.MethodId _getSupportedCipherSuites29915;
		public abstract global::java.lang.String[] getSupportedCipherSuites();
		internal static global::MonoJavaBridge.MethodId _unwrap29916;
		public virtual global::javax.net.ssl.SSLEngineResult unwrap(java.nio.ByteBuffer arg0, java.nio.ByteBuffer arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine._unwrap29916, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as javax.net.ssl.SSLEngineResult;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine.staticClass, global::javax.net.ssl.SSLEngine._unwrap29916, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as javax.net.ssl.SSLEngineResult;
		}
		internal static global::MonoJavaBridge.MethodId _unwrap29917;
		public virtual global::javax.net.ssl.SSLEngineResult unwrap(java.nio.ByteBuffer arg0, java.nio.ByteBuffer[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine._unwrap29917, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as javax.net.ssl.SSLEngineResult;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine.staticClass, global::javax.net.ssl.SSLEngine._unwrap29917, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as javax.net.ssl.SSLEngineResult;
		}
		internal static global::MonoJavaBridge.MethodId _unwrap29918;
		public abstract global::javax.net.ssl.SSLEngineResult unwrap(java.nio.ByteBuffer arg0, java.nio.ByteBuffer[] arg1, int arg2, int arg3);
		internal static global::MonoJavaBridge.MethodId _getSession29919;
		public abstract global::javax.net.ssl.SSLSession getSession();
		internal static global::MonoJavaBridge.MethodId _getEnabledCipherSuites29920;
		public abstract global::java.lang.String[] getEnabledCipherSuites();
		internal static global::MonoJavaBridge.MethodId _setEnabledCipherSuites29921;
		public abstract void setEnabledCipherSuites(java.lang.String[] arg0);
		internal static global::MonoJavaBridge.MethodId _getSupportedProtocols29922;
		public abstract global::java.lang.String[] getSupportedProtocols();
		internal static global::MonoJavaBridge.MethodId _getEnabledProtocols29923;
		public abstract global::java.lang.String[] getEnabledProtocols();
		internal static global::MonoJavaBridge.MethodId _setEnabledProtocols29924;
		public abstract void setEnabledProtocols(java.lang.String[] arg0);
		internal static global::MonoJavaBridge.MethodId _setUseClientMode29925;
		public abstract void setUseClientMode(bool arg0);
		internal static global::MonoJavaBridge.MethodId _getUseClientMode29926;
		public abstract bool getUseClientMode();
		internal static global::MonoJavaBridge.MethodId _setNeedClientAuth29927;
		public abstract void setNeedClientAuth(bool arg0);
		internal static global::MonoJavaBridge.MethodId _getNeedClientAuth29928;
		public abstract bool getNeedClientAuth();
		internal static global::MonoJavaBridge.MethodId _setWantClientAuth29929;
		public abstract void setWantClientAuth(bool arg0);
		internal static global::MonoJavaBridge.MethodId _getWantClientAuth29930;
		public abstract bool getWantClientAuth();
		internal static global::MonoJavaBridge.MethodId _setEnableSessionCreation29931;
		public abstract void setEnableSessionCreation(bool arg0);
		internal static global::MonoJavaBridge.MethodId _getEnableSessionCreation29932;
		public abstract bool getEnableSessionCreation();
		internal static global::MonoJavaBridge.MethodId _getPeerHost29933;
		public virtual global::java.lang.String getPeerHost()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine._getPeerHost29933)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine.staticClass, global::javax.net.ssl.SSLEngine._getPeerHost29933)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getPeerPort29934;
		public virtual int getPeerPort()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine._getPeerPort29934);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine.staticClass, global::javax.net.ssl.SSLEngine._getPeerPort29934);
		}
		internal static global::MonoJavaBridge.MethodId _getDelegatedTask29935;
		public abstract global::java.lang.Runnable getDelegatedTask();
		internal static global::MonoJavaBridge.MethodId _closeInbound29936;
		public abstract void closeInbound();
		internal static global::MonoJavaBridge.MethodId _isInboundDone29937;
		public abstract bool isInboundDone();
		internal static global::MonoJavaBridge.MethodId _closeOutbound29938;
		public abstract void closeOutbound();
		internal static global::MonoJavaBridge.MethodId _isOutboundDone29939;
		public abstract bool isOutboundDone();
		internal static global::MonoJavaBridge.MethodId _beginHandshake29940;
		public abstract void beginHandshake();
		internal static global::MonoJavaBridge.MethodId _getHandshakeStatus29941;
		public abstract global::javax.net.ssl.SSLEngineResult.HandshakeStatus getHandshakeStatus();
		internal static global::MonoJavaBridge.MethodId _SSLEngine29942;
		protected SSLEngine(java.lang.String arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.net.ssl.SSLEngine.staticClass, global::javax.net.ssl.SSLEngine._SSLEngine29942, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SSLEngine29943;
		protected SSLEngine() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.net.ssl.SSLEngine.staticClass, global::javax.net.ssl.SSLEngine._SSLEngine29943);
			Init(@__env, handle);
		}
		static SSLEngine()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.ssl.SSLEngine.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ssl/SSLEngine"));
			global::javax.net.ssl.SSLEngine._wrap29912 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine.staticClass, "wrap", "([Ljava/nio/ByteBuffer;Ljava/nio/ByteBuffer;)Ljavax/net/ssl/SSLEngineResult;");
			global::javax.net.ssl.SSLEngine._wrap29913 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine.staticClass, "wrap", "([Ljava/nio/ByteBuffer;IILjava/nio/ByteBuffer;)Ljavax/net/ssl/SSLEngineResult;");
			global::javax.net.ssl.SSLEngine._wrap29914 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine.staticClass, "wrap", "(Ljava/nio/ByteBuffer;Ljava/nio/ByteBuffer;)Ljavax/net/ssl/SSLEngineResult;");
			global::javax.net.ssl.SSLEngine._getSupportedCipherSuites29915 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine.staticClass, "getSupportedCipherSuites", "()[Ljava/lang/String;");
			global::javax.net.ssl.SSLEngine._unwrap29916 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine.staticClass, "unwrap", "(Ljava/nio/ByteBuffer;Ljava/nio/ByteBuffer;)Ljavax/net/ssl/SSLEngineResult;");
			global::javax.net.ssl.SSLEngine._unwrap29917 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine.staticClass, "unwrap", "(Ljava/nio/ByteBuffer;[Ljava/nio/ByteBuffer;)Ljavax/net/ssl/SSLEngineResult;");
			global::javax.net.ssl.SSLEngine._unwrap29918 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine.staticClass, "unwrap", "(Ljava/nio/ByteBuffer;[Ljava/nio/ByteBuffer;II)Ljavax/net/ssl/SSLEngineResult;");
			global::javax.net.ssl.SSLEngine._getSession29919 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine.staticClass, "getSession", "()Ljavax/net/ssl/SSLSession;");
			global::javax.net.ssl.SSLEngine._getEnabledCipherSuites29920 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine.staticClass, "getEnabledCipherSuites", "()[Ljava/lang/String;");
			global::javax.net.ssl.SSLEngine._setEnabledCipherSuites29921 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine.staticClass, "setEnabledCipherSuites", "([Ljava/lang/String;)V");
			global::javax.net.ssl.SSLEngine._getSupportedProtocols29922 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine.staticClass, "getSupportedProtocols", "()[Ljava/lang/String;");
			global::javax.net.ssl.SSLEngine._getEnabledProtocols29923 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine.staticClass, "getEnabledProtocols", "()[Ljava/lang/String;");
			global::javax.net.ssl.SSLEngine._setEnabledProtocols29924 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine.staticClass, "setEnabledProtocols", "([Ljava/lang/String;)V");
			global::javax.net.ssl.SSLEngine._setUseClientMode29925 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine.staticClass, "setUseClientMode", "(Z)V");
			global::javax.net.ssl.SSLEngine._getUseClientMode29926 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine.staticClass, "getUseClientMode", "()Z");
			global::javax.net.ssl.SSLEngine._setNeedClientAuth29927 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine.staticClass, "setNeedClientAuth", "(Z)V");
			global::javax.net.ssl.SSLEngine._getNeedClientAuth29928 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine.staticClass, "getNeedClientAuth", "()Z");
			global::javax.net.ssl.SSLEngine._setWantClientAuth29929 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine.staticClass, "setWantClientAuth", "(Z)V");
			global::javax.net.ssl.SSLEngine._getWantClientAuth29930 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine.staticClass, "getWantClientAuth", "()Z");
			global::javax.net.ssl.SSLEngine._setEnableSessionCreation29931 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine.staticClass, "setEnableSessionCreation", "(Z)V");
			global::javax.net.ssl.SSLEngine._getEnableSessionCreation29932 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine.staticClass, "getEnableSessionCreation", "()Z");
			global::javax.net.ssl.SSLEngine._getPeerHost29933 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine.staticClass, "getPeerHost", "()Ljava/lang/String;");
			global::javax.net.ssl.SSLEngine._getPeerPort29934 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine.staticClass, "getPeerPort", "()I");
			global::javax.net.ssl.SSLEngine._getDelegatedTask29935 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine.staticClass, "getDelegatedTask", "()Ljava/lang/Runnable;");
			global::javax.net.ssl.SSLEngine._closeInbound29936 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine.staticClass, "closeInbound", "()V");
			global::javax.net.ssl.SSLEngine._isInboundDone29937 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine.staticClass, "isInboundDone", "()Z");
			global::javax.net.ssl.SSLEngine._closeOutbound29938 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine.staticClass, "closeOutbound", "()V");
			global::javax.net.ssl.SSLEngine._isOutboundDone29939 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine.staticClass, "isOutboundDone", "()Z");
			global::javax.net.ssl.SSLEngine._beginHandshake29940 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine.staticClass, "beginHandshake", "()V");
			global::javax.net.ssl.SSLEngine._getHandshakeStatus29941 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine.staticClass, "getHandshakeStatus", "()Ljavax/net/ssl/SSLEngineResult$HandshakeStatus;");
			global::javax.net.ssl.SSLEngine._SSLEngine29942 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine.staticClass, "<init>", "(Ljava/lang/String;I)V");
			global::javax.net.ssl.SSLEngine._SSLEngine29943 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.net.ssl.SSLEngine))]
	internal sealed partial class SSLEngine_ : javax.net.ssl.SSLEngine
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal SSLEngine_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _wrap29944;
		public override global::javax.net.ssl.SSLEngineResult wrap(java.nio.ByteBuffer[] arg0, int arg1, int arg2, java.nio.ByteBuffer arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_._wrap29944, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as javax.net.ssl.SSLEngineResult;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_.staticClass, global::javax.net.ssl.SSLEngine_._wrap29944, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as javax.net.ssl.SSLEngineResult;
		}
		internal static global::MonoJavaBridge.MethodId _getSupportedCipherSuites29945;
		public override global::java.lang.String[] getSupportedCipherSuites()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_._getSupportedCipherSuites29945)) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_.staticClass, global::javax.net.ssl.SSLEngine_._getSupportedCipherSuites29945)) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _unwrap29946;
		public override global::javax.net.ssl.SSLEngineResult unwrap(java.nio.ByteBuffer arg0, java.nio.ByteBuffer[] arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_._unwrap29946, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as javax.net.ssl.SSLEngineResult;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_.staticClass, global::javax.net.ssl.SSLEngine_._unwrap29946, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as javax.net.ssl.SSLEngineResult;
		}
		internal static global::MonoJavaBridge.MethodId _getSession29947;
		public override global::javax.net.ssl.SSLSession getSession()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.net.ssl.SSLSession>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_._getSession29947)) as javax.net.ssl.SSLSession;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.net.ssl.SSLSession>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_.staticClass, global::javax.net.ssl.SSLEngine_._getSession29947)) as javax.net.ssl.SSLSession;
		}
		internal static global::MonoJavaBridge.MethodId _getEnabledCipherSuites29948;
		public override global::java.lang.String[] getEnabledCipherSuites()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_._getEnabledCipherSuites29948)) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_.staticClass, global::javax.net.ssl.SSLEngine_._getEnabledCipherSuites29948)) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _setEnabledCipherSuites29949;
		public override void setEnabledCipherSuites(java.lang.String[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_._setEnabledCipherSuites29949, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_.staticClass, global::javax.net.ssl.SSLEngine_._setEnabledCipherSuites29949, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSupportedProtocols29950;
		public override global::java.lang.String[] getSupportedProtocols()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_._getSupportedProtocols29950)) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_.staticClass, global::javax.net.ssl.SSLEngine_._getSupportedProtocols29950)) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _getEnabledProtocols29951;
		public override global::java.lang.String[] getEnabledProtocols()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_._getEnabledProtocols29951)) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_.staticClass, global::javax.net.ssl.SSLEngine_._getEnabledProtocols29951)) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _setEnabledProtocols29952;
		public override void setEnabledProtocols(java.lang.String[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_._setEnabledProtocols29952, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_.staticClass, global::javax.net.ssl.SSLEngine_._setEnabledProtocols29952, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setUseClientMode29953;
		public override void setUseClientMode(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_._setUseClientMode29953, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_.staticClass, global::javax.net.ssl.SSLEngine_._setUseClientMode29953, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getUseClientMode29954;
		public override bool getUseClientMode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_._getUseClientMode29954);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_.staticClass, global::javax.net.ssl.SSLEngine_._getUseClientMode29954);
		}
		internal static global::MonoJavaBridge.MethodId _setNeedClientAuth29955;
		public override void setNeedClientAuth(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_._setNeedClientAuth29955, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_.staticClass, global::javax.net.ssl.SSLEngine_._setNeedClientAuth29955, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getNeedClientAuth29956;
		public override bool getNeedClientAuth()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_._getNeedClientAuth29956);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_.staticClass, global::javax.net.ssl.SSLEngine_._getNeedClientAuth29956);
		}
		internal static global::MonoJavaBridge.MethodId _setWantClientAuth29957;
		public override void setWantClientAuth(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_._setWantClientAuth29957, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_.staticClass, global::javax.net.ssl.SSLEngine_._setWantClientAuth29957, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getWantClientAuth29958;
		public override bool getWantClientAuth()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_._getWantClientAuth29958);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_.staticClass, global::javax.net.ssl.SSLEngine_._getWantClientAuth29958);
		}
		internal static global::MonoJavaBridge.MethodId _setEnableSessionCreation29959;
		public override void setEnableSessionCreation(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_._setEnableSessionCreation29959, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_.staticClass, global::javax.net.ssl.SSLEngine_._setEnableSessionCreation29959, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getEnableSessionCreation29960;
		public override bool getEnableSessionCreation()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_._getEnableSessionCreation29960);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_.staticClass, global::javax.net.ssl.SSLEngine_._getEnableSessionCreation29960);
		}
		internal static global::MonoJavaBridge.MethodId _getDelegatedTask29961;
		public override global::java.lang.Runnable getDelegatedTask()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Runnable>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_._getDelegatedTask29961)) as java.lang.Runnable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Runnable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_.staticClass, global::javax.net.ssl.SSLEngine_._getDelegatedTask29961)) as java.lang.Runnable;
		}
		internal static global::MonoJavaBridge.MethodId _closeInbound29962;
		public override void closeInbound()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_._closeInbound29962);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_.staticClass, global::javax.net.ssl.SSLEngine_._closeInbound29962);
		}
		internal static global::MonoJavaBridge.MethodId _isInboundDone29963;
		public override bool isInboundDone()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_._isInboundDone29963);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_.staticClass, global::javax.net.ssl.SSLEngine_._isInboundDone29963);
		}
		internal static global::MonoJavaBridge.MethodId _closeOutbound29964;
		public override void closeOutbound()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_._closeOutbound29964);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_.staticClass, global::javax.net.ssl.SSLEngine_._closeOutbound29964);
		}
		internal static global::MonoJavaBridge.MethodId _isOutboundDone29965;
		public override bool isOutboundDone()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_._isOutboundDone29965);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_.staticClass, global::javax.net.ssl.SSLEngine_._isOutboundDone29965);
		}
		internal static global::MonoJavaBridge.MethodId _beginHandshake29966;
		public override void beginHandshake()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_._beginHandshake29966);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_.staticClass, global::javax.net.ssl.SSLEngine_._beginHandshake29966);
		}
		internal static global::MonoJavaBridge.MethodId _getHandshakeStatus29967;
		public override global::javax.net.ssl.SSLEngineResult.HandshakeStatus getHandshakeStatus()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<javax.net.ssl.SSLEngineResult.HandshakeStatus>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_._getHandshakeStatus29967)) as javax.net.ssl.SSLEngineResult.HandshakeStatus;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<javax.net.ssl.SSLEngineResult.HandshakeStatus>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLEngine_.staticClass, global::javax.net.ssl.SSLEngine_._getHandshakeStatus29967)) as javax.net.ssl.SSLEngineResult.HandshakeStatus;
		}
		static SSLEngine_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.ssl.SSLEngine_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ssl/SSLEngine"));
			global::javax.net.ssl.SSLEngine_._wrap29944 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine_.staticClass, "wrap", "([Ljava/nio/ByteBuffer;IILjava/nio/ByteBuffer;)Ljavax/net/ssl/SSLEngineResult;");
			global::javax.net.ssl.SSLEngine_._getSupportedCipherSuites29945 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine_.staticClass, "getSupportedCipherSuites", "()[Ljava/lang/String;");
			global::javax.net.ssl.SSLEngine_._unwrap29946 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine_.staticClass, "unwrap", "(Ljava/nio/ByteBuffer;[Ljava/nio/ByteBuffer;II)Ljavax/net/ssl/SSLEngineResult;");
			global::javax.net.ssl.SSLEngine_._getSession29947 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine_.staticClass, "getSession", "()Ljavax/net/ssl/SSLSession;");
			global::javax.net.ssl.SSLEngine_._getEnabledCipherSuites29948 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine_.staticClass, "getEnabledCipherSuites", "()[Ljava/lang/String;");
			global::javax.net.ssl.SSLEngine_._setEnabledCipherSuites29949 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine_.staticClass, "setEnabledCipherSuites", "([Ljava/lang/String;)V");
			global::javax.net.ssl.SSLEngine_._getSupportedProtocols29950 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine_.staticClass, "getSupportedProtocols", "()[Ljava/lang/String;");
			global::javax.net.ssl.SSLEngine_._getEnabledProtocols29951 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine_.staticClass, "getEnabledProtocols", "()[Ljava/lang/String;");
			global::javax.net.ssl.SSLEngine_._setEnabledProtocols29952 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine_.staticClass, "setEnabledProtocols", "([Ljava/lang/String;)V");
			global::javax.net.ssl.SSLEngine_._setUseClientMode29953 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine_.staticClass, "setUseClientMode", "(Z)V");
			global::javax.net.ssl.SSLEngine_._getUseClientMode29954 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine_.staticClass, "getUseClientMode", "()Z");
			global::javax.net.ssl.SSLEngine_._setNeedClientAuth29955 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine_.staticClass, "setNeedClientAuth", "(Z)V");
			global::javax.net.ssl.SSLEngine_._getNeedClientAuth29956 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine_.staticClass, "getNeedClientAuth", "()Z");
			global::javax.net.ssl.SSLEngine_._setWantClientAuth29957 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine_.staticClass, "setWantClientAuth", "(Z)V");
			global::javax.net.ssl.SSLEngine_._getWantClientAuth29958 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine_.staticClass, "getWantClientAuth", "()Z");
			global::javax.net.ssl.SSLEngine_._setEnableSessionCreation29959 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine_.staticClass, "setEnableSessionCreation", "(Z)V");
			global::javax.net.ssl.SSLEngine_._getEnableSessionCreation29960 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine_.staticClass, "getEnableSessionCreation", "()Z");
			global::javax.net.ssl.SSLEngine_._getDelegatedTask29961 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine_.staticClass, "getDelegatedTask", "()Ljava/lang/Runnable;");
			global::javax.net.ssl.SSLEngine_._closeInbound29962 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine_.staticClass, "closeInbound", "()V");
			global::javax.net.ssl.SSLEngine_._isInboundDone29963 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine_.staticClass, "isInboundDone", "()Z");
			global::javax.net.ssl.SSLEngine_._closeOutbound29964 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine_.staticClass, "closeOutbound", "()V");
			global::javax.net.ssl.SSLEngine_._isOutboundDone29965 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine_.staticClass, "isOutboundDone", "()Z");
			global::javax.net.ssl.SSLEngine_._beginHandshake29966 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine_.staticClass, "beginHandshake", "()V");
			global::javax.net.ssl.SSLEngine_._getHandshakeStatus29967 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngine_.staticClass, "getHandshakeStatus", "()Ljavax/net/ssl/SSLEngineResult$HandshakeStatus;");
		}
		internal static void InitJNI()
		{
		}
	}
}
