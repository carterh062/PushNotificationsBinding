using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Parse.Entity.Mime {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.parse.entity.mime']/class[@name='FormBodyPart']"
	[global::Android.Runtime.Register ("com/parse/entity/mime/FormBodyPart", DoNotGenerateAcw=true)]
	public partial class FormBodyPart : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/parse/entity/mime/FormBodyPart", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FormBodyPart); }
		}

		protected FormBodyPart (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Lcom_parse_entity_mime_content_ContentBody_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.parse.entity.mime']/class[@name='FormBodyPart']/constructor[@name='FormBodyPart' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.parse.entity.mime.content.ContentBody']]"
		[Register (".ctor", "(Ljava/lang/String;Lcom/parse/entity/mime/content/ContentBody;)V", "")]
		public FormBodyPart (string p0, global::Com.Parse.Entity.Mime.Content.IContentBody p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);;
			if (GetType () != typeof (FormBodyPart)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Lcom/parse/entity/mime/content/ContentBody;)V", new JValue (native_p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Lcom/parse/entity/mime/content/ContentBody;)V", new JValue (native_p0), new JValue (p1));
				JNIEnv.DeleteLocalRef (native_p0);
				return;
			}

			if (id_ctor_Ljava_lang_String_Lcom_parse_entity_mime_content_ContentBody_ == IntPtr.Zero)
				id_ctor_Ljava_lang_String_Lcom_parse_entity_mime_content_ContentBody_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Lcom/parse/entity/mime/content/ContentBody;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Lcom_parse_entity_mime_content_ContentBody_, new JValue (native_p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Lcom_parse_entity_mime_content_ContentBody_, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_getBody;
#pragma warning disable 0169
		static Delegate GetGetBodyHandler ()
		{
			if (cb_getBody == null)
				cb_getBody = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBody);
			return cb_getBody;
		}

		static IntPtr n_GetBody (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.Entity.Mime.FormBodyPart __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Entity.Mime.FormBodyPart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Body);
		}
#pragma warning restore 0169

		static IntPtr id_getBody;
		public virtual global::Com.Parse.Entity.Mime.Content.IContentBody Body {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.entity.mime']/class[@name='FormBodyPart']/method[@name='getBody' and count(parameter)=0]"
			[Register ("getBody", "()Lcom/parse/entity/mime/content/ContentBody;", "GetGetBodyHandler")]
			get {
				if (id_getBody == IntPtr.Zero)
					id_getBody = JNIEnv.GetMethodID (class_ref, "getBody", "()Lcom/parse/entity/mime/content/ContentBody;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Parse.Entity.Mime.Content.IContentBody> (JNIEnv.CallObjectMethod  (Handle, id_getBody), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Parse.Entity.Mime.Content.IContentBody> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBody", "()Lcom/parse/entity/mime/content/ContentBody;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getHeader;
#pragma warning disable 0169
		static Delegate GetGetHeaderHandler ()
		{
			if (cb_getHeader == null)
				cb_getHeader = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHeader);
			return cb_getHeader;
		}

		static IntPtr n_GetHeader (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.Entity.Mime.FormBodyPart __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Entity.Mime.FormBodyPart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Header);
		}
#pragma warning restore 0169

		static IntPtr id_getHeader;
		public virtual global::Com.Parse.Entity.Mime.Header Header {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.entity.mime']/class[@name='FormBodyPart']/method[@name='getHeader' and count(parameter)=0]"
			[Register ("getHeader", "()Lcom/parse/entity/mime/Header;", "GetGetHeaderHandler")]
			get {
				if (id_getHeader == IntPtr.Zero)
					id_getHeader = JNIEnv.GetMethodID (class_ref, "getHeader", "()Lcom/parse/entity/mime/Header;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Parse.Entity.Mime.Header> (JNIEnv.CallObjectMethod  (Handle, id_getHeader), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Parse.Entity.Mime.Header> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHeader", "()Lcom/parse/entity/mime/Header;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getName;
#pragma warning disable 0169
		static Delegate GetGetNameHandler ()
		{
			if (cb_getName == null)
				cb_getName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetName);
			return cb_getName;
		}

		static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.Entity.Mime.FormBodyPart __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Entity.Mime.FormBodyPart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		static IntPtr id_getName;
		public virtual string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.entity.mime']/class[@name='FormBodyPart']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
			get {
				if (id_getName == IntPtr.Zero)
					id_getName = JNIEnv.GetMethodID (class_ref, "getName", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getName), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_addField_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddField_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_addField_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_addField_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddField_Ljava_lang_String_Ljava_lang_String_);
			return cb_addField_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_AddField_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Parse.Entity.Mime.FormBodyPart __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Entity.Mime.FormBodyPart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.AddField (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_addField_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.entity.mime']/class[@name='FormBodyPart']/method[@name='addField' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("addField", "(Ljava/lang/String;Ljava/lang/String;)V", "GetAddField_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual void AddField (string p0, string p1)
		{
			if (id_addField_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_addField_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addField", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_addField_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addField", "(Ljava/lang/String;Ljava/lang/String;)V"), new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_generateContentDisp_Lcom_parse_entity_mime_content_ContentBody_;
#pragma warning disable 0169
		static Delegate GetGenerateContentDisp_Lcom_parse_entity_mime_content_ContentBody_Handler ()
		{
			if (cb_generateContentDisp_Lcom_parse_entity_mime_content_ContentBody_ == null)
				cb_generateContentDisp_Lcom_parse_entity_mime_content_ContentBody_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_GenerateContentDisp_Lcom_parse_entity_mime_content_ContentBody_);
			return cb_generateContentDisp_Lcom_parse_entity_mime_content_ContentBody_;
		}

		static void n_GenerateContentDisp_Lcom_parse_entity_mime_content_ContentBody_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.Entity.Mime.FormBodyPart __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Entity.Mime.FormBodyPart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Parse.Entity.Mime.Content.IContentBody p0 = (global::Com.Parse.Entity.Mime.Content.IContentBody)global::Java.Lang.Object.GetObject<global::Com.Parse.Entity.Mime.Content.IContentBody> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.GenerateContentDisp (p0);
		}
#pragma warning restore 0169

		static IntPtr id_generateContentDisp_Lcom_parse_entity_mime_content_ContentBody_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.entity.mime']/class[@name='FormBodyPart']/method[@name='generateContentDisp' and count(parameter)=1 and parameter[1][@type='com.parse.entity.mime.content.ContentBody']]"
		[Register ("generateContentDisp", "(Lcom/parse/entity/mime/content/ContentBody;)V", "GetGenerateContentDisp_Lcom_parse_entity_mime_content_ContentBody_Handler")]
		protected virtual void GenerateContentDisp (global::Com.Parse.Entity.Mime.Content.IContentBody p0)
		{
			if (id_generateContentDisp_Lcom_parse_entity_mime_content_ContentBody_ == IntPtr.Zero)
				id_generateContentDisp_Lcom_parse_entity_mime_content_ContentBody_ = JNIEnv.GetMethodID (class_ref, "generateContentDisp", "(Lcom/parse/entity/mime/content/ContentBody;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_generateContentDisp_Lcom_parse_entity_mime_content_ContentBody_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "generateContentDisp", "(Lcom/parse/entity/mime/content/ContentBody;)V"), new JValue (p0));
		}

		static Delegate cb_generateContentType_Lcom_parse_entity_mime_content_ContentBody_;
#pragma warning disable 0169
		static Delegate GetGenerateContentType_Lcom_parse_entity_mime_content_ContentBody_Handler ()
		{
			if (cb_generateContentType_Lcom_parse_entity_mime_content_ContentBody_ == null)
				cb_generateContentType_Lcom_parse_entity_mime_content_ContentBody_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_GenerateContentType_Lcom_parse_entity_mime_content_ContentBody_);
			return cb_generateContentType_Lcom_parse_entity_mime_content_ContentBody_;
		}

		static void n_GenerateContentType_Lcom_parse_entity_mime_content_ContentBody_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.Entity.Mime.FormBodyPart __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Entity.Mime.FormBodyPart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Parse.Entity.Mime.Content.IContentBody p0 = (global::Com.Parse.Entity.Mime.Content.IContentBody)global::Java.Lang.Object.GetObject<global::Com.Parse.Entity.Mime.Content.IContentBody> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.GenerateContentType (p0);
		}
#pragma warning restore 0169

		static IntPtr id_generateContentType_Lcom_parse_entity_mime_content_ContentBody_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.entity.mime']/class[@name='FormBodyPart']/method[@name='generateContentType' and count(parameter)=1 and parameter[1][@type='com.parse.entity.mime.content.ContentBody']]"
		[Register ("generateContentType", "(Lcom/parse/entity/mime/content/ContentBody;)V", "GetGenerateContentType_Lcom_parse_entity_mime_content_ContentBody_Handler")]
		protected virtual void GenerateContentType (global::Com.Parse.Entity.Mime.Content.IContentBody p0)
		{
			if (id_generateContentType_Lcom_parse_entity_mime_content_ContentBody_ == IntPtr.Zero)
				id_generateContentType_Lcom_parse_entity_mime_content_ContentBody_ = JNIEnv.GetMethodID (class_ref, "generateContentType", "(Lcom/parse/entity/mime/content/ContentBody;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_generateContentType_Lcom_parse_entity_mime_content_ContentBody_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "generateContentType", "(Lcom/parse/entity/mime/content/ContentBody;)V"), new JValue (p0));
		}

		static Delegate cb_generateTransferEncoding_Lcom_parse_entity_mime_content_ContentBody_;
#pragma warning disable 0169
		static Delegate GetGenerateTransferEncoding_Lcom_parse_entity_mime_content_ContentBody_Handler ()
		{
			if (cb_generateTransferEncoding_Lcom_parse_entity_mime_content_ContentBody_ == null)
				cb_generateTransferEncoding_Lcom_parse_entity_mime_content_ContentBody_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_GenerateTransferEncoding_Lcom_parse_entity_mime_content_ContentBody_);
			return cb_generateTransferEncoding_Lcom_parse_entity_mime_content_ContentBody_;
		}

		static void n_GenerateTransferEncoding_Lcom_parse_entity_mime_content_ContentBody_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.Entity.Mime.FormBodyPart __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Entity.Mime.FormBodyPart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Parse.Entity.Mime.Content.IContentBody p0 = (global::Com.Parse.Entity.Mime.Content.IContentBody)global::Java.Lang.Object.GetObject<global::Com.Parse.Entity.Mime.Content.IContentBody> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.GenerateTransferEncoding (p0);
		}
#pragma warning restore 0169

		static IntPtr id_generateTransferEncoding_Lcom_parse_entity_mime_content_ContentBody_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.entity.mime']/class[@name='FormBodyPart']/method[@name='generateTransferEncoding' and count(parameter)=1 and parameter[1][@type='com.parse.entity.mime.content.ContentBody']]"
		[Register ("generateTransferEncoding", "(Lcom/parse/entity/mime/content/ContentBody;)V", "GetGenerateTransferEncoding_Lcom_parse_entity_mime_content_ContentBody_Handler")]
		protected virtual void GenerateTransferEncoding (global::Com.Parse.Entity.Mime.Content.IContentBody p0)
		{
			if (id_generateTransferEncoding_Lcom_parse_entity_mime_content_ContentBody_ == IntPtr.Zero)
				id_generateTransferEncoding_Lcom_parse_entity_mime_content_ContentBody_ = JNIEnv.GetMethodID (class_ref, "generateTransferEncoding", "(Lcom/parse/entity/mime/content/ContentBody;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_generateTransferEncoding_Lcom_parse_entity_mime_content_ContentBody_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "generateTransferEncoding", "(Lcom/parse/entity/mime/content/ContentBody;)V"), new JValue (p0));
		}

	}
}
