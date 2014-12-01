using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Parse.Entity.Mime {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.parse.entity.mime']/class[@name='HttpMultipart']"
	[global::Android.Runtime.Register ("com/parse/entity/mime/HttpMultipart", DoNotGenerateAcw=true)]
	public partial class HttpMultipart : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/parse/entity/mime/HttpMultipart", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HttpMultipart); }
		}

		protected HttpMultipart (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.parse.entity.mime']/class[@name='HttpMultipart']/constructor[@name='HttpMultipart' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public HttpMultipart (string p0, string p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);;
			IntPtr native_p1 = JNIEnv.NewString (p1);;
			if (GetType () != typeof (HttpMultipart)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Ljava/lang/String;)V", new JValue (native_p0), new JValue (native_p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Ljava/lang/String;)V", new JValue (native_p0), new JValue (native_p1));
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				return;
			}

			if (id_ctor_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_ctor_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_nio_charset_Charset_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.parse.entity.mime']/class[@name='HttpMultipart']/constructor[@name='HttpMultipart' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.nio.charset.Charset'] and parameter[3][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/nio/charset/Charset;Ljava/lang/String;)V", "")]
		public HttpMultipart (string p0, global::Java.Nio.Charset.Charset p1, string p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);;
			IntPtr native_p2 = JNIEnv.NewString (p2);;
			if (GetType () != typeof (HttpMultipart)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Ljava/nio/charset/Charset;Ljava/lang/String;)V", new JValue (native_p0), new JValue (p1), new JValue (native_p2)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Ljava/nio/charset/Charset;Ljava/lang/String;)V", new JValue (native_p0), new JValue (p1), new JValue (native_p2));
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p2);
				return;
			}

			if (id_ctor_Ljava_lang_String_Ljava_nio_charset_Charset_Ljava_lang_String_ == IntPtr.Zero)
				id_ctor_Ljava_lang_String_Ljava_nio_charset_Charset_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/nio/charset/Charset;Ljava/lang/String;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_nio_charset_Charset_Ljava_lang_String_, new JValue (native_p0), new JValue (p1), new JValue (native_p2)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_nio_charset_Charset_Ljava_lang_String_, new JValue (native_p0), new JValue (p1), new JValue (native_p2));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_nio_charset_Charset_Ljava_lang_String_Lcom_parse_entity_mime_HttpMultipartMode_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.parse.entity.mime']/class[@name='HttpMultipart']/constructor[@name='HttpMultipart' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.nio.charset.Charset'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.parse.entity.mime.HttpMultipartMode']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/nio/charset/Charset;Ljava/lang/String;Lcom/parse/entity/mime/HttpMultipartMode;)V", "")]
		public HttpMultipart (string p0, global::Java.Nio.Charset.Charset p1, string p2, global::Com.Parse.Entity.Mime.HttpMultipartMode p3) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);;
			IntPtr native_p2 = JNIEnv.NewString (p2);;
			if (GetType () != typeof (HttpMultipart)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Ljava/nio/charset/Charset;Ljava/lang/String;Lcom/parse/entity/mime/HttpMultipartMode;)V", new JValue (native_p0), new JValue (p1), new JValue (native_p2), new JValue (p3)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Ljava/nio/charset/Charset;Ljava/lang/String;Lcom/parse/entity/mime/HttpMultipartMode;)V", new JValue (native_p0), new JValue (p1), new JValue (native_p2), new JValue (p3));
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p2);
				return;
			}

			if (id_ctor_Ljava_lang_String_Ljava_nio_charset_Charset_Ljava_lang_String_Lcom_parse_entity_mime_HttpMultipartMode_ == IntPtr.Zero)
				id_ctor_Ljava_lang_String_Ljava_nio_charset_Charset_Ljava_lang_String_Lcom_parse_entity_mime_HttpMultipartMode_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/nio/charset/Charset;Ljava/lang/String;Lcom/parse/entity/mime/HttpMultipartMode;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_nio_charset_Charset_Ljava_lang_String_Lcom_parse_entity_mime_HttpMultipartMode_, new JValue (native_p0), new JValue (p1), new JValue (native_p2), new JValue (p3)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_nio_charset_Charset_Ljava_lang_String_Lcom_parse_entity_mime_HttpMultipartMode_, new JValue (native_p0), new JValue (p1), new JValue (native_p2), new JValue (p3));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static Delegate cb_getBodyParts;
#pragma warning disable 0169
		static Delegate GetGetBodyPartsHandler ()
		{
			if (cb_getBodyParts == null)
				cb_getBodyParts = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBodyParts);
			return cb_getBodyParts;
		}

		static IntPtr n_GetBodyParts (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.Entity.Mime.HttpMultipart __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Entity.Mime.HttpMultipart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Parse.Entity.Mime.FormBodyPart>.ToLocalJniHandle (__this.BodyParts);
		}
#pragma warning restore 0169

		static IntPtr id_getBodyParts;
		public virtual global::System.Collections.Generic.IList<global::Com.Parse.Entity.Mime.FormBodyPart> BodyParts {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.entity.mime']/class[@name='HttpMultipart']/method[@name='getBodyParts' and count(parameter)=0]"
			[Register ("getBodyParts", "()Ljava/util/List;", "GetGetBodyPartsHandler")]
			get {
				if (id_getBodyParts == IntPtr.Zero)
					id_getBodyParts = JNIEnv.GetMethodID (class_ref, "getBodyParts", "()Ljava/util/List;");

				if (GetType () == ThresholdType)
					return global::Android.Runtime.JavaList<global::Com.Parse.Entity.Mime.FormBodyPart>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getBodyParts), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaList<global::Com.Parse.Entity.Mime.FormBodyPart>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBodyParts", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getBoundary;
#pragma warning disable 0169
		static Delegate GetGetBoundaryHandler ()
		{
			if (cb_getBoundary == null)
				cb_getBoundary = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBoundary);
			return cb_getBoundary;
		}

		static IntPtr n_GetBoundary (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.Entity.Mime.HttpMultipart __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Entity.Mime.HttpMultipart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Boundary);
		}
#pragma warning restore 0169

		static IntPtr id_getBoundary;
		public virtual string Boundary {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.entity.mime']/class[@name='HttpMultipart']/method[@name='getBoundary' and count(parameter)=0]"
			[Register ("getBoundary", "()Ljava/lang/String;", "GetGetBoundaryHandler")]
			get {
				if (id_getBoundary == IntPtr.Zero)
					id_getBoundary = JNIEnv.GetMethodID (class_ref, "getBoundary", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getBoundary), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBoundary", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getCharset;
#pragma warning disable 0169
		static Delegate GetGetCharsetHandler ()
		{
			if (cb_getCharset == null)
				cb_getCharset = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCharset);
			return cb_getCharset;
		}

		static IntPtr n_GetCharset (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.Entity.Mime.HttpMultipart __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Entity.Mime.HttpMultipart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Charset);
		}
#pragma warning restore 0169

		static IntPtr id_getCharset;
		public virtual global::Java.Nio.Charset.Charset Charset {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.entity.mime']/class[@name='HttpMultipart']/method[@name='getCharset' and count(parameter)=0]"
			[Register ("getCharset", "()Ljava/nio/charset/Charset;", "GetGetCharsetHandler")]
			get {
				if (id_getCharset == IntPtr.Zero)
					id_getCharset = JNIEnv.GetMethodID (class_ref, "getCharset", "()Ljava/nio/charset/Charset;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Nio.Charset.Charset> (JNIEnv.CallObjectMethod  (Handle, id_getCharset), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Nio.Charset.Charset> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCharset", "()Ljava/nio/charset/Charset;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getMode;
#pragma warning disable 0169
		static Delegate GetGetModeHandler ()
		{
			if (cb_getMode == null)
				cb_getMode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMode);
			return cb_getMode;
		}

		static IntPtr n_GetMode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.Entity.Mime.HttpMultipart __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Entity.Mime.HttpMultipart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Mode);
		}
#pragma warning restore 0169

		static IntPtr id_getMode;
		public virtual global::Com.Parse.Entity.Mime.HttpMultipartMode Mode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.entity.mime']/class[@name='HttpMultipart']/method[@name='getMode' and count(parameter)=0]"
			[Register ("getMode", "()Lcom/parse/entity/mime/HttpMultipartMode;", "GetGetModeHandler")]
			get {
				if (id_getMode == IntPtr.Zero)
					id_getMode = JNIEnv.GetMethodID (class_ref, "getMode", "()Lcom/parse/entity/mime/HttpMultipartMode;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Parse.Entity.Mime.HttpMultipartMode> (JNIEnv.CallObjectMethod  (Handle, id_getMode), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Parse.Entity.Mime.HttpMultipartMode> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMode", "()Lcom/parse/entity/mime/HttpMultipartMode;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getSubType;
#pragma warning disable 0169
		static Delegate GetGetSubTypeHandler ()
		{
			if (cb_getSubType == null)
				cb_getSubType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSubType);
			return cb_getSubType;
		}

		static IntPtr n_GetSubType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.Entity.Mime.HttpMultipart __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Entity.Mime.HttpMultipart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SubType);
		}
#pragma warning restore 0169

		static IntPtr id_getSubType;
		public virtual string SubType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.entity.mime']/class[@name='HttpMultipart']/method[@name='getSubType' and count(parameter)=0]"
			[Register ("getSubType", "()Ljava/lang/String;", "GetGetSubTypeHandler")]
			get {
				if (id_getSubType == IntPtr.Zero)
					id_getSubType = JNIEnv.GetMethodID (class_ref, "getSubType", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getSubType), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSubType", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getTotalLength;
#pragma warning disable 0169
		static Delegate GetGetTotalLengthHandler ()
		{
			if (cb_getTotalLength == null)
				cb_getTotalLength = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetTotalLength);
			return cb_getTotalLength;
		}

		static long n_GetTotalLength (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.Entity.Mime.HttpMultipart __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Entity.Mime.HttpMultipart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TotalLength;
		}
#pragma warning restore 0169

		static IntPtr id_getTotalLength;
		public virtual long TotalLength {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.entity.mime']/class[@name='HttpMultipart']/method[@name='getTotalLength' and count(parameter)=0]"
			[Register ("getTotalLength", "()J", "GetGetTotalLengthHandler")]
			get {
				if (id_getTotalLength == IntPtr.Zero)
					id_getTotalLength = JNIEnv.GetMethodID (class_ref, "getTotalLength", "()J");

				if (GetType () == ThresholdType)
					return JNIEnv.CallLongMethod  (Handle, id_getTotalLength);
				else
					return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTotalLength", "()J"));
			}
		}

		static Delegate cb_addBodyPart_Lcom_parse_entity_mime_FormBodyPart_;
#pragma warning disable 0169
		static Delegate GetAddBodyPart_Lcom_parse_entity_mime_FormBodyPart_Handler ()
		{
			if (cb_addBodyPart_Lcom_parse_entity_mime_FormBodyPart_ == null)
				cb_addBodyPart_Lcom_parse_entity_mime_FormBodyPart_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddBodyPart_Lcom_parse_entity_mime_FormBodyPart_);
			return cb_addBodyPart_Lcom_parse_entity_mime_FormBodyPart_;
		}

		static void n_AddBodyPart_Lcom_parse_entity_mime_FormBodyPart_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.Entity.Mime.HttpMultipart __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Entity.Mime.HttpMultipart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Parse.Entity.Mime.FormBodyPart p0 = global::Java.Lang.Object.GetObject<global::Com.Parse.Entity.Mime.FormBodyPart> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddBodyPart (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addBodyPart_Lcom_parse_entity_mime_FormBodyPart_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.entity.mime']/class[@name='HttpMultipart']/method[@name='addBodyPart' and count(parameter)=1 and parameter[1][@type='com.parse.entity.mime.FormBodyPart']]"
		[Register ("addBodyPart", "(Lcom/parse/entity/mime/FormBodyPart;)V", "GetAddBodyPart_Lcom_parse_entity_mime_FormBodyPart_Handler")]
		public virtual void AddBodyPart (global::Com.Parse.Entity.Mime.FormBodyPart p0)
		{
			if (id_addBodyPart_Lcom_parse_entity_mime_FormBodyPart_ == IntPtr.Zero)
				id_addBodyPart_Lcom_parse_entity_mime_FormBodyPart_ = JNIEnv.GetMethodID (class_ref, "addBodyPart", "(Lcom/parse/entity/mime/FormBodyPart;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_addBodyPart_Lcom_parse_entity_mime_FormBodyPart_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addBodyPart", "(Lcom/parse/entity/mime/FormBodyPart;)V"), new JValue (p0));
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
			global::Com.Parse.Entity.Mime.HttpMultipart __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Entity.Mime.HttpMultipart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream p0 = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.WriteTo (p0);
		}
#pragma warning restore 0169

		static IntPtr id_writeTo_Ljava_io_OutputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.entity.mime']/class[@name='HttpMultipart']/method[@name='writeTo' and count(parameter)=1 and parameter[1][@type='java.io.OutputStream']]"
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
