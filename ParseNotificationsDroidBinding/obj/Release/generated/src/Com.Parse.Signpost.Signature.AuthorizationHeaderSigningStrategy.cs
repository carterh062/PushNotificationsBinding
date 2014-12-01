using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Parse.Signpost.Signature {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.parse.signpost.signature']/class[@name='AuthorizationHeaderSigningStrategy']"
	[global::Android.Runtime.Register ("com/parse/signpost/signature/AuthorizationHeaderSigningStrategy", DoNotGenerateAcw=true)]
	public partial class AuthorizationHeaderSigningStrategy : global::Java.Lang.Object, global::Com.Parse.Signpost.Signature.ISigningStrategy {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/parse/signpost/signature/AuthorizationHeaderSigningStrategy", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AuthorizationHeaderSigningStrategy); }
		}

		protected AuthorizationHeaderSigningStrategy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.parse.signpost.signature']/class[@name='AuthorizationHeaderSigningStrategy']/constructor[@name='AuthorizationHeaderSigningStrategy' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public AuthorizationHeaderSigningStrategy () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (AuthorizationHeaderSigningStrategy)) {
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

		static Delegate cb_writeSignature_Ljava_lang_String_Lcom_parse_signpost_http_HttpRequest_Lcom_parse_signpost_http_HttpParameters_;
#pragma warning disable 0169
		static Delegate GetWriteSignature_Ljava_lang_String_Lcom_parse_signpost_http_HttpRequest_Lcom_parse_signpost_http_HttpParameters_Handler ()
		{
			if (cb_writeSignature_Ljava_lang_String_Lcom_parse_signpost_http_HttpRequest_Lcom_parse_signpost_http_HttpParameters_ == null)
				cb_writeSignature_Ljava_lang_String_Lcom_parse_signpost_http_HttpRequest_Lcom_parse_signpost_http_HttpParameters_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_WriteSignature_Ljava_lang_String_Lcom_parse_signpost_http_HttpRequest_Lcom_parse_signpost_http_HttpParameters_);
			return cb_writeSignature_Ljava_lang_String_Lcom_parse_signpost_http_HttpRequest_Lcom_parse_signpost_http_HttpParameters_;
		}

		static IntPtr n_WriteSignature_Ljava_lang_String_Lcom_parse_signpost_http_HttpRequest_Lcom_parse_signpost_http_HttpParameters_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Parse.Signpost.Signature.AuthorizationHeaderSigningStrategy __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.Signature.AuthorizationHeaderSigningStrategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Parse.Signpost.Http.IHttpRequest p1 = (global::Com.Parse.Signpost.Http.IHttpRequest)global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.Http.IHttpRequest> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Parse.Signpost.Http.HttpParameters p2 = global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.Http.HttpParameters> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.WriteSignature (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_writeSignature_Ljava_lang_String_Lcom_parse_signpost_http_HttpRequest_Lcom_parse_signpost_http_HttpParameters_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.signpost.signature']/class[@name='AuthorizationHeaderSigningStrategy']/method[@name='writeSignature' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.parse.signpost.http.HttpRequest'] and parameter[3][@type='com.parse.signpost.http.HttpParameters']]"
		[Register ("writeSignature", "(Ljava/lang/String;Lcom/parse/signpost/http/HttpRequest;Lcom/parse/signpost/http/HttpParameters;)Ljava/lang/String;", "GetWriteSignature_Ljava_lang_String_Lcom_parse_signpost_http_HttpRequest_Lcom_parse_signpost_http_HttpParameters_Handler")]
		public virtual string WriteSignature (string p0, global::Com.Parse.Signpost.Http.IHttpRequest p1, global::Com.Parse.Signpost.Http.HttpParameters p2)
		{
			if (id_writeSignature_Ljava_lang_String_Lcom_parse_signpost_http_HttpRequest_Lcom_parse_signpost_http_HttpParameters_ == IntPtr.Zero)
				id_writeSignature_Ljava_lang_String_Lcom_parse_signpost_http_HttpRequest_Lcom_parse_signpost_http_HttpParameters_ = JNIEnv.GetMethodID (class_ref, "writeSignature", "(Ljava/lang/String;Lcom/parse/signpost/http/HttpRequest;Lcom/parse/signpost/http/HttpParameters;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			string __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_writeSignature_Ljava_lang_String_Lcom_parse_signpost_http_HttpRequest_Lcom_parse_signpost_http_HttpParameters_, new JValue (native_p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeSignature", "(Ljava/lang/String;Lcom/parse/signpost/http/HttpRequest;Lcom/parse/signpost/http/HttpParameters;)Ljava/lang/String;"), new JValue (native_p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}
}
