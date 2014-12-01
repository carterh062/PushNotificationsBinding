using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Parse.Entity.Mime {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.parse.entity.mime']/class[@name='MultipartEntity']"
	[global::Android.Runtime.Register ("com/parse/entity/mime/MultipartEntity", DoNotGenerateAcw=true)]
	public partial class MultipartEntity : global::Java.Lang.Object, global::Org.Apache.Http.IHttpEntity {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/parse/entity/mime/MultipartEntity", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MultipartEntity); }
		}

		protected MultipartEntity (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_parse_entity_mime_HttpMultipartMode_Ljava_lang_String_Ljava_nio_charset_Charset_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.parse.entity.mime']/class[@name='MultipartEntity']/constructor[@name='MultipartEntity' and count(parameter)=3 and parameter[1][@type='com.parse.entity.mime.HttpMultipartMode'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.nio.charset.Charset']]"
		[Register (".ctor", "(Lcom/parse/entity/mime/HttpMultipartMode;Ljava/lang/String;Ljava/nio/charset/Charset;)V", "")]
		public MultipartEntity (global::Com.Parse.Entity.Mime.HttpMultipartMode p0, string p1, global::Java.Nio.Charset.Charset p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);;
			if (GetType () != typeof (MultipartEntity)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/parse/entity/mime/HttpMultipartMode;Ljava/lang/String;Ljava/nio/charset/Charset;)V", new JValue (p0), new JValue (native_p1), new JValue (p2)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/parse/entity/mime/HttpMultipartMode;Ljava/lang/String;Ljava/nio/charset/Charset;)V", new JValue (p0), new JValue (native_p1), new JValue (p2));
				JNIEnv.DeleteLocalRef (native_p1);
				return;
			}

			if (id_ctor_Lcom_parse_entity_mime_HttpMultipartMode_Ljava_lang_String_Ljava_nio_charset_Charset_ == IntPtr.Zero)
				id_ctor_Lcom_parse_entity_mime_HttpMultipartMode_Ljava_lang_String_Ljava_nio_charset_Charset_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/parse/entity/mime/HttpMultipartMode;Ljava/lang/String;Ljava/nio/charset/Charset;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_parse_entity_mime_HttpMultipartMode_Ljava_lang_String_Ljava_nio_charset_Charset_, new JValue (p0), new JValue (native_p1), new JValue (p2)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_parse_entity_mime_HttpMultipartMode_Ljava_lang_String_Ljava_nio_charset_Charset_, new JValue (p0), new JValue (native_p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_ctor_Lcom_parse_entity_mime_HttpMultipartMode_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.parse.entity.mime']/class[@name='MultipartEntity']/constructor[@name='MultipartEntity' and count(parameter)=1 and parameter[1][@type='com.parse.entity.mime.HttpMultipartMode']]"
		[Register (".ctor", "(Lcom/parse/entity/mime/HttpMultipartMode;)V", "")]
		public MultipartEntity (global::Com.Parse.Entity.Mime.HttpMultipartMode p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (MultipartEntity)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/parse/entity/mime/HttpMultipartMode;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/parse/entity/mime/HttpMultipartMode;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Lcom_parse_entity_mime_HttpMultipartMode_ == IntPtr.Zero)
				id_ctor_Lcom_parse_entity_mime_HttpMultipartMode_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/parse/entity/mime/HttpMultipartMode;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_parse_entity_mime_HttpMultipartMode_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_parse_entity_mime_HttpMultipartMode_, new JValue (p0));
		}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.parse.entity.mime']/class[@name='MultipartEntity']/constructor[@name='MultipartEntity' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public MultipartEntity () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (MultipartEntity)) {
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

		static Delegate cb_getContent;
#pragma warning disable 0169
		static Delegate GetGetContentHandler ()
		{
			if (cb_getContent == null)
				cb_getContent = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContent);
			return cb_getContent;
		}

		static IntPtr n_GetContent (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.Entity.Mime.MultipartEntity __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Entity.Mime.MultipartEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (__this.Content);
		}
#pragma warning restore 0169

		static IntPtr id_getContent;
		public virtual global::System.IO.Stream Content {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.entity.mime']/class[@name='MultipartEntity']/method[@name='getContent' and count(parameter)=0]"
			[Register ("getContent", "()Ljava/io/InputStream;", "GetGetContentHandler")]
			get {
				if (id_getContent == IntPtr.Zero)
					id_getContent = JNIEnv.GetMethodID (class_ref, "getContent", "()Ljava/io/InputStream;");

				if (GetType () == ThresholdType)
					return global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getContent), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getContent", "()Ljava/io/InputStream;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getContentEncoding;
#pragma warning disable 0169
		static Delegate GetGetContentEncodingHandler ()
		{
			if (cb_getContentEncoding == null)
				cb_getContentEncoding = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContentEncoding);
			return cb_getContentEncoding;
		}

		static IntPtr n_GetContentEncoding (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.Entity.Mime.MultipartEntity __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Entity.Mime.MultipartEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ContentEncoding);
		}
#pragma warning restore 0169

		static IntPtr id_getContentEncoding;
		public virtual global::Org.Apache.Http.IHeader ContentEncoding {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.entity.mime']/class[@name='MultipartEntity']/method[@name='getContentEncoding' and count(parameter)=0]"
			[Register ("getContentEncoding", "()Lorg/apache/http/Header;", "GetGetContentEncodingHandler")]
			get {
				if (id_getContentEncoding == IntPtr.Zero)
					id_getContentEncoding = JNIEnv.GetMethodID (class_ref, "getContentEncoding", "()Lorg/apache/http/Header;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Http.IHeader> (JNIEnv.CallObjectMethod  (Handle, id_getContentEncoding), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Http.IHeader> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getContentEncoding", "()Lorg/apache/http/Header;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getContentLength;
#pragma warning disable 0169
		static Delegate GetGetContentLengthHandler ()
		{
			if (cb_getContentLength == null)
				cb_getContentLength = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetContentLength);
			return cb_getContentLength;
		}

		static long n_GetContentLength (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.Entity.Mime.MultipartEntity __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Entity.Mime.MultipartEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ContentLength;
		}
#pragma warning restore 0169

		static IntPtr id_getContentLength;
		public virtual long ContentLength {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.entity.mime']/class[@name='MultipartEntity']/method[@name='getContentLength' and count(parameter)=0]"
			[Register ("getContentLength", "()J", "GetGetContentLengthHandler")]
			get {
				if (id_getContentLength == IntPtr.Zero)
					id_getContentLength = JNIEnv.GetMethodID (class_ref, "getContentLength", "()J");

				if (GetType () == ThresholdType)
					return JNIEnv.CallLongMethod  (Handle, id_getContentLength);
				else
					return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getContentLength", "()J"));
			}
		}

		static Delegate cb_getContentType;
#pragma warning disable 0169
		static Delegate GetGetContentTypeHandler ()
		{
			if (cb_getContentType == null)
				cb_getContentType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContentType);
			return cb_getContentType;
		}

		static IntPtr n_GetContentType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.Entity.Mime.MultipartEntity __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Entity.Mime.MultipartEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ContentType);
		}
#pragma warning restore 0169

		static IntPtr id_getContentType;
		public virtual global::Org.Apache.Http.IHeader ContentType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.entity.mime']/class[@name='MultipartEntity']/method[@name='getContentType' and count(parameter)=0]"
			[Register ("getContentType", "()Lorg/apache/http/Header;", "GetGetContentTypeHandler")]
			get {
				if (id_getContentType == IntPtr.Zero)
					id_getContentType = JNIEnv.GetMethodID (class_ref, "getContentType", "()Lorg/apache/http/Header;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Http.IHeader> (JNIEnv.CallObjectMethod  (Handle, id_getContentType), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Http.IHeader> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getContentType", "()Lorg/apache/http/Header;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_isChunked;
#pragma warning disable 0169
		static Delegate GetIsChunkedHandler ()
		{
			if (cb_isChunked == null)
				cb_isChunked = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsChunked);
			return cb_isChunked;
		}

		static bool n_IsChunked (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.Entity.Mime.MultipartEntity __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Entity.Mime.MultipartEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsChunked;
		}
#pragma warning restore 0169

		static IntPtr id_isChunked;
		public virtual bool IsChunked {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.entity.mime']/class[@name='MultipartEntity']/method[@name='isChunked' and count(parameter)=0]"
			[Register ("isChunked", "()Z", "GetIsChunkedHandler")]
			get {
				if (id_isChunked == IntPtr.Zero)
					id_isChunked = JNIEnv.GetMethodID (class_ref, "isChunked", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isChunked);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isChunked", "()Z"));
			}
		}

		static Delegate cb_isRepeatable;
#pragma warning disable 0169
		static Delegate GetIsRepeatableHandler ()
		{
			if (cb_isRepeatable == null)
				cb_isRepeatable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsRepeatable);
			return cb_isRepeatable;
		}

		static bool n_IsRepeatable (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.Entity.Mime.MultipartEntity __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Entity.Mime.MultipartEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsRepeatable;
		}
#pragma warning restore 0169

		static IntPtr id_isRepeatable;
		public virtual bool IsRepeatable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.entity.mime']/class[@name='MultipartEntity']/method[@name='isRepeatable' and count(parameter)=0]"
			[Register ("isRepeatable", "()Z", "GetIsRepeatableHandler")]
			get {
				if (id_isRepeatable == IntPtr.Zero)
					id_isRepeatable = JNIEnv.GetMethodID (class_ref, "isRepeatable", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isRepeatable);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isRepeatable", "()Z"));
			}
		}

		static Delegate cb_isStreaming;
#pragma warning disable 0169
		static Delegate GetIsStreamingHandler ()
		{
			if (cb_isStreaming == null)
				cb_isStreaming = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsStreaming);
			return cb_isStreaming;
		}

		static bool n_IsStreaming (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.Entity.Mime.MultipartEntity __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Entity.Mime.MultipartEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsStreaming;
		}
#pragma warning restore 0169

		static IntPtr id_isStreaming;
		public virtual bool IsStreaming {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.entity.mime']/class[@name='MultipartEntity']/method[@name='isStreaming' and count(parameter)=0]"
			[Register ("isStreaming", "()Z", "GetIsStreamingHandler")]
			get {
				if (id_isStreaming == IntPtr.Zero)
					id_isStreaming = JNIEnv.GetMethodID (class_ref, "isStreaming", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isStreaming);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isStreaming", "()Z"));
			}
		}

		static Delegate cb_addPart_Lcom_parse_entity_mime_FormBodyPart_;
#pragma warning disable 0169
		static Delegate GetAddPart_Lcom_parse_entity_mime_FormBodyPart_Handler ()
		{
			if (cb_addPart_Lcom_parse_entity_mime_FormBodyPart_ == null)
				cb_addPart_Lcom_parse_entity_mime_FormBodyPart_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddPart_Lcom_parse_entity_mime_FormBodyPart_);
			return cb_addPart_Lcom_parse_entity_mime_FormBodyPart_;
		}

		static void n_AddPart_Lcom_parse_entity_mime_FormBodyPart_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.Entity.Mime.MultipartEntity __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Entity.Mime.MultipartEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Parse.Entity.Mime.FormBodyPart p0 = global::Java.Lang.Object.GetObject<global::Com.Parse.Entity.Mime.FormBodyPart> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddPart (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addPart_Lcom_parse_entity_mime_FormBodyPart_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.entity.mime']/class[@name='MultipartEntity']/method[@name='addPart' and count(parameter)=1 and parameter[1][@type='com.parse.entity.mime.FormBodyPart']]"
		[Register ("addPart", "(Lcom/parse/entity/mime/FormBodyPart;)V", "GetAddPart_Lcom_parse_entity_mime_FormBodyPart_Handler")]
		public virtual void AddPart (global::Com.Parse.Entity.Mime.FormBodyPart p0)
		{
			if (id_addPart_Lcom_parse_entity_mime_FormBodyPart_ == IntPtr.Zero)
				id_addPart_Lcom_parse_entity_mime_FormBodyPart_ = JNIEnv.GetMethodID (class_ref, "addPart", "(Lcom/parse/entity/mime/FormBodyPart;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_addPart_Lcom_parse_entity_mime_FormBodyPart_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addPart", "(Lcom/parse/entity/mime/FormBodyPart;)V"), new JValue (p0));
		}

		static Delegate cb_addPart_Ljava_lang_String_Lcom_parse_entity_mime_content_ContentBody_;
#pragma warning disable 0169
		static Delegate GetAddPart_Ljava_lang_String_Lcom_parse_entity_mime_content_ContentBody_Handler ()
		{
			if (cb_addPart_Ljava_lang_String_Lcom_parse_entity_mime_content_ContentBody_ == null)
				cb_addPart_Ljava_lang_String_Lcom_parse_entity_mime_content_ContentBody_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddPart_Ljava_lang_String_Lcom_parse_entity_mime_content_ContentBody_);
			return cb_addPart_Ljava_lang_String_Lcom_parse_entity_mime_content_ContentBody_;
		}

		static void n_AddPart_Ljava_lang_String_Lcom_parse_entity_mime_content_ContentBody_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Parse.Entity.Mime.MultipartEntity __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Entity.Mime.MultipartEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Parse.Entity.Mime.Content.IContentBody p1 = (global::Com.Parse.Entity.Mime.Content.IContentBody)global::Java.Lang.Object.GetObject<global::Com.Parse.Entity.Mime.Content.IContentBody> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.AddPart (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_addPart_Ljava_lang_String_Lcom_parse_entity_mime_content_ContentBody_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.entity.mime']/class[@name='MultipartEntity']/method[@name='addPart' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.parse.entity.mime.content.ContentBody']]"
		[Register ("addPart", "(Ljava/lang/String;Lcom/parse/entity/mime/content/ContentBody;)V", "GetAddPart_Ljava_lang_String_Lcom_parse_entity_mime_content_ContentBody_Handler")]
		public virtual void AddPart (string p0, global::Com.Parse.Entity.Mime.Content.IContentBody p1)
		{
			if (id_addPart_Ljava_lang_String_Lcom_parse_entity_mime_content_ContentBody_ == IntPtr.Zero)
				id_addPart_Ljava_lang_String_Lcom_parse_entity_mime_content_ContentBody_ = JNIEnv.GetMethodID (class_ref, "addPart", "(Ljava/lang/String;Lcom/parse/entity/mime/content/ContentBody;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_addPart_Ljava_lang_String_Lcom_parse_entity_mime_content_ContentBody_, new JValue (native_p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addPart", "(Ljava/lang/String;Lcom/parse/entity/mime/content/ContentBody;)V"), new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_consumeContent;
#pragma warning disable 0169
		static Delegate GetConsumeContentHandler ()
		{
			if (cb_consumeContent == null)
				cb_consumeContent = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ConsumeContent);
			return cb_consumeContent;
		}

		static void n_ConsumeContent (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.Entity.Mime.MultipartEntity __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Entity.Mime.MultipartEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ConsumeContent ();
		}
#pragma warning restore 0169

		static IntPtr id_consumeContent;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.entity.mime']/class[@name='MultipartEntity']/method[@name='consumeContent' and count(parameter)=0]"
		[Register ("consumeContent", "()V", "GetConsumeContentHandler")]
		public virtual void ConsumeContent ()
		{
			if (id_consumeContent == IntPtr.Zero)
				id_consumeContent = JNIEnv.GetMethodID (class_ref, "consumeContent", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_consumeContent);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "consumeContent", "()V"));
		}

		static Delegate cb_generateBoundary;
#pragma warning disable 0169
		static Delegate GetGenerateBoundaryHandler ()
		{
			if (cb_generateBoundary == null)
				cb_generateBoundary = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GenerateBoundary);
			return cb_generateBoundary;
		}

		static IntPtr n_GenerateBoundary (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.Entity.Mime.MultipartEntity __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Entity.Mime.MultipartEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GenerateBoundary ());
		}
#pragma warning restore 0169

		static IntPtr id_generateBoundary;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.entity.mime']/class[@name='MultipartEntity']/method[@name='generateBoundary' and count(parameter)=0]"
		[Register ("generateBoundary", "()Ljava/lang/String;", "GetGenerateBoundaryHandler")]
		protected virtual string GenerateBoundary ()
		{
			if (id_generateBoundary == IntPtr.Zero)
				id_generateBoundary = JNIEnv.GetMethodID (class_ref, "generateBoundary", "()Ljava/lang/String;");

			if (GetType () == ThresholdType)
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_generateBoundary), JniHandleOwnership.TransferLocalRef);
			else
				return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "generateBoundary", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_generateContentType_Ljava_lang_String_Ljava_nio_charset_Charset_;
#pragma warning disable 0169
		static Delegate GetGenerateContentType_Ljava_lang_String_Ljava_nio_charset_Charset_Handler ()
		{
			if (cb_generateContentType_Ljava_lang_String_Ljava_nio_charset_Charset_ == null)
				cb_generateContentType_Ljava_lang_String_Ljava_nio_charset_Charset_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GenerateContentType_Ljava_lang_String_Ljava_nio_charset_Charset_);
			return cb_generateContentType_Ljava_lang_String_Ljava_nio_charset_Charset_;
		}

		static IntPtr n_GenerateContentType_Ljava_lang_String_Ljava_nio_charset_Charset_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Parse.Entity.Mime.MultipartEntity __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Entity.Mime.MultipartEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.Charset.Charset p1 = global::Java.Lang.Object.GetObject<global::Java.Nio.Charset.Charset> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GenerateContentType (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_generateContentType_Ljava_lang_String_Ljava_nio_charset_Charset_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.entity.mime']/class[@name='MultipartEntity']/method[@name='generateContentType' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.nio.charset.Charset']]"
		[Register ("generateContentType", "(Ljava/lang/String;Ljava/nio/charset/Charset;)Ljava/lang/String;", "GetGenerateContentType_Ljava_lang_String_Ljava_nio_charset_Charset_Handler")]
		protected virtual string GenerateContentType (string p0, global::Java.Nio.Charset.Charset p1)
		{
			if (id_generateContentType_Ljava_lang_String_Ljava_nio_charset_Charset_ == IntPtr.Zero)
				id_generateContentType_Ljava_lang_String_Ljava_nio_charset_Charset_ = JNIEnv.GetMethodID (class_ref, "generateContentType", "(Ljava/lang/String;Ljava/nio/charset/Charset;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			string __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_generateContentType_Ljava_lang_String_Ljava_nio_charset_Charset_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "generateContentType", "(Ljava/lang/String;Ljava/nio/charset/Charset;)Ljava/lang/String;"), new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_writeTo_Ljava_io_OutputStream_;
#pragma warning disable 0169
		static Delegate GetWriteTo_Ljava_io_OutputStream_Handler ()
		{
			if (cb_writeTo_Ljava_io_OutputStream_ == null)
				cb_writeTo_Ljava_io_OutputStream_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_WriteTo_Ljava_io_OutputStream_);
			return cb_writeTo_Ljava_io_OutputStream_;
		}

		static void n_WriteTo_Ljava_io_OutputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.Entity.Mime.MultipartEntity __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Entity.Mime.MultipartEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream p0 = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.WriteTo (p0);
		}
#pragma warning restore 0169

		static IntPtr id_writeTo_Ljava_io_OutputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.entity.mime']/class[@name='MultipartEntity']/method[@name='writeTo' and count(parameter)=1 and parameter[1][@type='java.io.OutputStream']]"
		[Register ("writeTo", "(Ljava/io/OutputStream;)V", "GetWriteTo_Ljava_io_OutputStream_Handler")]
		public virtual void WriteTo (global::System.IO.Stream p0)
		{
			if (id_writeTo_Ljava_io_OutputStream_ == IntPtr.Zero)
				id_writeTo_Ljava_io_OutputStream_ = JNIEnv.GetMethodID (class_ref, "writeTo", "(Ljava/io/OutputStream;)V");
			IntPtr native_p0 = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_writeTo_Ljava_io_OutputStream_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeTo", "(Ljava/io/OutputStream;)V"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}
}
