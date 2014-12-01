using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Parse.Entity.Mime {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.parse.entity.mime']/class[@name='Header']"
	[global::Android.Runtime.Register ("com/parse/entity/mime/Header", DoNotGenerateAcw=true)]
	public partial class Header : global::Java.Lang.Object, global::Java.Lang.IIterable {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/parse/entity/mime/Header", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Header); }
		}

		protected Header (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.parse.entity.mime']/class[@name='Header']/constructor[@name='Header' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public Header () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (Header)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
		}

		static Delegate cb_getFields;
#pragma warning disable 0169
		static Delegate GetGetFieldsHandler ()
		{
			if (cb_getFields == null)
				cb_getFields = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFields);
			return cb_getFields;
		}

		static IntPtr n_GetFields (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.Entity.Mime.Header __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Entity.Mime.Header> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Parse.Entity.Mime.MinimalField>.ToLocalJniHandle (__this.Fields);
		}
#pragma warning restore 0169

		static IntPtr id_getFields;
		public virtual global::System.Collections.Generic.IList<global::Com.Parse.Entity.Mime.MinimalField> Fields {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.entity.mime']/class[@name='Header']/method[@name='getFields' and count(parameter)=0]"
			[Register ("getFields", "()Ljava/util/List;", "GetGetFieldsHandler")]
			get {
				if (id_getFields == IntPtr.Zero)
					id_getFields = JNIEnv.GetMethodID (class_ref, "getFields", "()Ljava/util/List;");

				if (GetType () == ThresholdType)
					return global::Android.Runtime.JavaList<global::Com.Parse.Entity.Mime.MinimalField>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getFields), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaList<global::Com.Parse.Entity.Mime.MinimalField>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFields", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_addField_Lcom_parse_entity_mime_MinimalField_;
#pragma warning disable 0169
		static Delegate GetAddField_Lcom_parse_entity_mime_MinimalField_Handler ()
		{
			if (cb_addField_Lcom_parse_entity_mime_MinimalField_ == null)
				cb_addField_Lcom_parse_entity_mime_MinimalField_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddField_Lcom_parse_entity_mime_MinimalField_);
			return cb_addField_Lcom_parse_entity_mime_MinimalField_;
		}

		static void n_AddField_Lcom_parse_entity_mime_MinimalField_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.Entity.Mime.Header __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Entity.Mime.Header> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Parse.Entity.Mime.MinimalField p0 = global::Java.Lang.Object.GetObject<global::Com.Parse.Entity.Mime.MinimalField> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddField (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addField_Lcom_parse_entity_mime_MinimalField_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.entity.mime']/class[@name='Header']/method[@name='addField' and count(parameter)=1 and parameter[1][@type='com.parse.entity.mime.MinimalField']]"
		[Register ("addField", "(Lcom/parse/entity/mime/MinimalField;)V", "GetAddField_Lcom_parse_entity_mime_MinimalField_Handler")]
		public virtual void AddField (global::Com.Parse.Entity.Mime.MinimalField p0)
		{
			if (id_addField_Lcom_parse_entity_mime_MinimalField_ == IntPtr.Zero)
				id_addField_Lcom_parse_entity_mime_MinimalField_ = JNIEnv.GetMethodID (class_ref, "addField", "(Lcom/parse/entity/mime/MinimalField;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_addField_Lcom_parse_entity_mime_MinimalField_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addField", "(Lcom/parse/entity/mime/MinimalField;)V"), new JValue (p0));
		}

		static Delegate cb_getField_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetField_Ljava_lang_String_Handler ()
		{
			if (cb_getField_Ljava_lang_String_ == null)
				cb_getField_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetField_Ljava_lang_String_);
			return cb_getField_Ljava_lang_String_;
		}

		static IntPtr n_GetField_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.Entity.Mime.Header __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Entity.Mime.Header> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetField (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getField_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.entity.mime']/class[@name='Header']/method[@name='getField' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getField", "(Ljava/lang/String;)Lcom/parse/entity/mime/MinimalField;", "GetGetField_Ljava_lang_String_Handler")]
		public virtual global::Com.Parse.Entity.Mime.MinimalField GetField (string p0)
		{
			if (id_getField_Ljava_lang_String_ == IntPtr.Zero)
				id_getField_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getField", "(Ljava/lang/String;)Lcom/parse/entity/mime/MinimalField;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Com.Parse.Entity.Mime.MinimalField __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Parse.Entity.Mime.MinimalField> (JNIEnv.CallObjectMethod  (Handle, id_getField_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Parse.Entity.Mime.MinimalField> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getField", "(Ljava/lang/String;)Lcom/parse/entity/mime/MinimalField;"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getFields_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetFields_Ljava_lang_String_Handler ()
		{
			if (cb_getFields_Ljava_lang_String_ == null)
				cb_getFields_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetFields_Ljava_lang_String_);
			return cb_getFields_Ljava_lang_String_;
		}

		static IntPtr n_GetFields_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.Entity.Mime.Header __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Entity.Mime.Header> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Com.Parse.Entity.Mime.MinimalField>.ToLocalJniHandle (__this.GetFields (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getFields_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.entity.mime']/class[@name='Header']/method[@name='getFields' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getFields", "(Ljava/lang/String;)Ljava/util/List;", "GetGetFields_Ljava_lang_String_Handler")]
		public virtual global::System.Collections.Generic.IList<global::Com.Parse.Entity.Mime.MinimalField> GetFields (string p0)
		{
			if (id_getFields_Ljava_lang_String_ == IntPtr.Zero)
				id_getFields_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getFields", "(Ljava/lang/String;)Ljava/util/List;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::System.Collections.Generic.IList<global::Com.Parse.Entity.Mime.MinimalField> __ret;
			if (GetType () == ThresholdType)
				__ret = global::Android.Runtime.JavaList<global::Com.Parse.Entity.Mime.MinimalField>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getFields_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Android.Runtime.JavaList<global::Com.Parse.Entity.Mime.MinimalField>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFields", "(Ljava/lang/String;)Ljava/util/List;"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_iterator;
#pragma warning disable 0169
		static Delegate GetIteratorHandler ()
		{
			if (cb_iterator == null)
				cb_iterator = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Iterator);
			return cb_iterator;
		}

		static IntPtr n_Iterator (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.Entity.Mime.Header __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Entity.Mime.Header> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Iterator ());
		}
#pragma warning restore 0169

		static IntPtr id_iterator;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.entity.mime']/class[@name='Header']/method[@name='iterator' and count(parameter)=0]"
		[Register ("iterator", "()Ljava/util/Iterator;", "GetIteratorHandler")]
		public virtual global::Java.Util.IIterator Iterator ()
		{
			if (id_iterator == IntPtr.Zero)
				id_iterator = JNIEnv.GetMethodID (class_ref, "iterator", "()Ljava/util/Iterator;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Java.Util.IIterator> (JNIEnv.CallObjectMethod  (Handle, id_iterator), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Java.Util.IIterator> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "iterator", "()Ljava/util/Iterator;")), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_removeFields_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemoveFields_Ljava_lang_String_Handler ()
		{
			if (cb_removeFields_Ljava_lang_String_ == null)
				cb_removeFields_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_RemoveFields_Ljava_lang_String_);
			return cb_removeFields_Ljava_lang_String_;
		}

		static int n_RemoveFields_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.Entity.Mime.Header __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Entity.Mime.Header> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.RemoveFields (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_removeFields_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.entity.mime']/class[@name='Header']/method[@name='removeFields' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("removeFields", "(Ljava/lang/String;)I", "GetRemoveFields_Ljava_lang_String_Handler")]
		public virtual int RemoveFields (string p0)
		{
			if (id_removeFields_Ljava_lang_String_ == IntPtr.Zero)
				id_removeFields_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "removeFields", "(Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			int __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallIntMethod  (Handle, id_removeFields_Ljava_lang_String_, new JValue (native_p0));
			else
				__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeFields", "(Ljava/lang/String;)I"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_setField_Lcom_parse_entity_mime_MinimalField_;
#pragma warning disable 0169
		static Delegate GetSetField_Lcom_parse_entity_mime_MinimalField_Handler ()
		{
			if (cb_setField_Lcom_parse_entity_mime_MinimalField_ == null)
				cb_setField_Lcom_parse_entity_mime_MinimalField_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetField_Lcom_parse_entity_mime_MinimalField_);
			return cb_setField_Lcom_parse_entity_mime_MinimalField_;
		}

		static void n_SetField_Lcom_parse_entity_mime_MinimalField_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.Entity.Mime.Header __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Entity.Mime.Header> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Parse.Entity.Mime.MinimalField p0 = global::Java.Lang.Object.GetObject<global::Com.Parse.Entity.Mime.MinimalField> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetField (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setField_Lcom_parse_entity_mime_MinimalField_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.entity.mime']/class[@name='Header']/method[@name='setField' and count(parameter)=1 and parameter[1][@type='com.parse.entity.mime.MinimalField']]"
		[Register ("setField", "(Lcom/parse/entity/mime/MinimalField;)V", "GetSetField_Lcom_parse_entity_mime_MinimalField_Handler")]
		public virtual void SetField (global::Com.Parse.Entity.Mime.MinimalField p0)
		{
			if (id_setField_Lcom_parse_entity_mime_MinimalField_ == IntPtr.Zero)
				id_setField_Lcom_parse_entity_mime_MinimalField_ = JNIEnv.GetMethodID (class_ref, "setField", "(Lcom/parse/entity/mime/MinimalField;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setField_Lcom_parse_entity_mime_MinimalField_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setField", "(Lcom/parse/entity/mime/MinimalField;)V"), new JValue (p0));
		}

	}
}
