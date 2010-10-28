namespace org.xml.sax.helpers
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AttributeListImpl : java.lang.Object, AttributeList
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AttributeListImpl(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new int Length
		{
			get
			{
				return getLength();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLength35149;
		public virtual int getLength()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.xml.sax.helpers.AttributeListImpl._getLength35149);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.xml.sax.helpers.AttributeListImpl.staticClass, global::org.xml.sax.helpers.AttributeListImpl._getLength35149);
		}
		internal static global::MonoJavaBridge.MethodId _clear35150;
		public virtual void clear()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.AttributeListImpl._clear35150);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.AttributeListImpl.staticClass, global::org.xml.sax.helpers.AttributeListImpl._clear35150);
		}
		internal static global::MonoJavaBridge.MethodId _getName35151;
		public virtual global::java.lang.String getName(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.helpers.AttributeListImpl._getName35151, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.helpers.AttributeListImpl.staticClass, global::org.xml.sax.helpers.AttributeListImpl._getName35151, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getValue35152;
		public virtual global::java.lang.String getValue(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.helpers.AttributeListImpl._getValue35152, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.helpers.AttributeListImpl.staticClass, global::org.xml.sax.helpers.AttributeListImpl._getValue35152, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getValue35153;
		public virtual global::java.lang.String getValue(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.helpers.AttributeListImpl._getValue35153, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.helpers.AttributeListImpl.staticClass, global::org.xml.sax.helpers.AttributeListImpl._getValue35153, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getType35154;
		public virtual global::java.lang.String getType(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.helpers.AttributeListImpl._getType35154, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.helpers.AttributeListImpl.staticClass, global::org.xml.sax.helpers.AttributeListImpl._getType35154, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getType35155;
		public virtual global::java.lang.String getType(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.helpers.AttributeListImpl._getType35155, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.helpers.AttributeListImpl.staticClass, global::org.xml.sax.helpers.AttributeListImpl._getType35155, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _addAttribute35156;
		public virtual void addAttribute(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.AttributeListImpl._addAttribute35156, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.AttributeListImpl.staticClass, global::org.xml.sax.helpers.AttributeListImpl._addAttribute35156, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _removeAttribute35157;
		public virtual void removeAttribute(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.AttributeListImpl._removeAttribute35157, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.AttributeListImpl.staticClass, global::org.xml.sax.helpers.AttributeListImpl._removeAttribute35157, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::org.xml.sax.AttributeList AttributeList
		{
			set
			{
				setAttributeList(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setAttributeList35158;
		public virtual void setAttributeList(org.xml.sax.AttributeList arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.AttributeListImpl._setAttributeList35158, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.AttributeListImpl.staticClass, global::org.xml.sax.helpers.AttributeListImpl._setAttributeList35158, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _AttributeListImpl35159;
		public AttributeListImpl() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.xml.sax.helpers.AttributeListImpl.staticClass, global::org.xml.sax.helpers.AttributeListImpl._AttributeListImpl35159);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AttributeListImpl35160;
		public AttributeListImpl(org.xml.sax.AttributeList arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.xml.sax.helpers.AttributeListImpl.staticClass, global::org.xml.sax.helpers.AttributeListImpl._AttributeListImpl35160, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static AttributeListImpl()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.xml.sax.helpers.AttributeListImpl.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/xml/sax/helpers/AttributeListImpl"));
			global::org.xml.sax.helpers.AttributeListImpl._getLength35149 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.AttributeListImpl.staticClass, "getLength", "()I");
			global::org.xml.sax.helpers.AttributeListImpl._clear35150 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.AttributeListImpl.staticClass, "clear", "()V");
			global::org.xml.sax.helpers.AttributeListImpl._getName35151 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.AttributeListImpl.staticClass, "getName", "(I)Ljava/lang/String;");
			global::org.xml.sax.helpers.AttributeListImpl._getValue35152 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.AttributeListImpl.staticClass, "getValue", "(Ljava/lang/String;)Ljava/lang/String;");
			global::org.xml.sax.helpers.AttributeListImpl._getValue35153 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.AttributeListImpl.staticClass, "getValue", "(I)Ljava/lang/String;");
			global::org.xml.sax.helpers.AttributeListImpl._getType35154 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.AttributeListImpl.staticClass, "getType", "(I)Ljava/lang/String;");
			global::org.xml.sax.helpers.AttributeListImpl._getType35155 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.AttributeListImpl.staticClass, "getType", "(Ljava/lang/String;)Ljava/lang/String;");
			global::org.xml.sax.helpers.AttributeListImpl._addAttribute35156 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.AttributeListImpl.staticClass, "addAttribute", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::org.xml.sax.helpers.AttributeListImpl._removeAttribute35157 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.AttributeListImpl.staticClass, "removeAttribute", "(Ljava/lang/String;)V");
			global::org.xml.sax.helpers.AttributeListImpl._setAttributeList35158 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.AttributeListImpl.staticClass, "setAttributeList", "(Lorg/xml/sax/AttributeList;)V");
			global::org.xml.sax.helpers.AttributeListImpl._AttributeListImpl35159 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.AttributeListImpl.staticClass, "<init>", "()V");
			global::org.xml.sax.helpers.AttributeListImpl._AttributeListImpl35160 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.AttributeListImpl.staticClass, "<init>", "(Lorg/xml/sax/AttributeList;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
