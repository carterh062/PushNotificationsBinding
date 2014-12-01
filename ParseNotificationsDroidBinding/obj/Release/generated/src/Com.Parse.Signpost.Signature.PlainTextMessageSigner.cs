using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Parse.Signpost.Signature {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.parse.signpost.signature']/class[@name='PlainTextMessageSigner']"
	[global::Android.Runtime.Register ("com/parse/signpost/signature/PlainTextMessageSigner", DoNotGenerateAcw=true)]
	public partial class PlainTextMessageSigner : global::Com.Parse.Signpost.Signature.OAuthMessageSigner {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/parse/signpost/signature/PlainTextMessageSigner", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PlainTextMessageSigner); }
		}

		protected PlainTextMessageSigner (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.parse.signpost.signature']/class[@name='PlainTextMessageSigner']/constructor[@name='PlainTextMessageSigner' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public PlainTextMessageSigner () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (PlainTextMessageSigner)) {
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

		static Delegate cb_getSignatureMethod;
#pragma warning disable 0169
		static Delegate GetGetSignatureMethodHandler ()
		{
			if (cb_getSignatureMethod == null)
				cb_getSignatureMethod = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSignatureMethod);
			return cb_getSignatureMethod;
		}

		static IntPtr n_GetSignatureMethod (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.Signpost.Signature.PlainTextMessageSigner __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.Signature.PlainTextMessageSigner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SignatureMethod);
		}
#pragma warning restore 0169

		static IntPtr id_getSignatureMethod;
		public override string SignatureMethod {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.signpost.signature']/class[@name='PlainTextMessageSigner']/method[@name='getSignatureMethod' and count(parameter)=0]"
			[Register ("getSignatureMethod", "()Ljava/lang/String;", "GetGetSignatureMethodHandler")]
			get {
				if (id_getSignatureMethod == IntPtr.Zero)
					id_getSignatureMethod = JNIEnv.GetMethodID (class_ref, "getSignatureMethod", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getSignatureMethod), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSignatureMethod", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_sign_Lcom_parse_signpost_http_HttpRequest_Lcom_parse_signpost_http_HttpParameters_;
#pragma warning disable 0169
		static Delegate GetSign_Lcom_parse_signpost_http_HttpRequest_Lcom_parse_signpost_http_HttpParameters_Handler ()
		{
			if (cb_sign_Lcom_parse_signpost_http_HttpRequest_Lcom_parse_signpost_http_HttpParameters_ == null)
				cb_sign_Lcom_parse_signpost_http_HttpRequest_Lcom_parse_signpost_http_HttpParameters_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Sign_Lcom_parse_signpost_http_HttpRequest_Lcom_parse_signpost_http_HttpParameters_);
			return cb_sign_Lcom_parse_signpost_http_HttpRequest_Lcom_parse_signpost_http_HttpParameters_;
		}

		static IntPtr n_Sign_Lcom_parse_signpost_http_HttpRequest_Lcom_parse_signpost_http_HttpParameters_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Parse.Signpost.Signature.PlainTextMessageSigner __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.Signature.PlainTextMessageSigner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Parse.Signpost.Http.IHttpRequest p0 = (global::Com.Parse.Signpost.Http.IHttpRequest)global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.Http.IHttpRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Parse.Signpost.Http.HttpParameters p1 = global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.Http.HttpParameters> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Sign (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_sign_Lcom_parse_signpost_http_HttpRequest_Lcom_parse_signpost_http_HttpParameters_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.signpost.signature']/class[@name='PlainTextMessageSigner']/method[@name='sign' and count(parameter)=2 and parameter[1][@type='com.parse.signpost.http.HttpRequest'] and parameter[2][@type='com.parse.signpost.http.HttpParameters']]"
		[Register ("sign", "(Lcom/parse/signpost/http/HttpRequest;Lcom/parse/signpost/http/HttpParameters;)Ljava/lang/String;", "GetSign_Lcom_parse_signpost_http_HttpRequest_Lcom_parse_signpost_http_HttpParameters_Handler")]
		public override string Sign (global::Com.Parse.Signpost.Http.IHttpRequest p0, global::Com.Parse.Signpost.Http.HttpParameters p1)
		{
			if (id_sign_Lcom_parse_signpost_http_HttpRequest_Lcom_parse_signpost_http_HttpParameters_ == IntPtr.Zero)
				id_sign_Lcom_parse_signpost_http_HttpRequest_Lcom_parse_signpost_http_HttpParameters_ = JNIEnv.GetMethodID (class_ref, "sign", "(Lcom/parse/signpost/http/HttpRequest;Lcom/parse/signpost/http/HttpParameters;)Ljava/lang/String;");

			string __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_sign_Lcom_parse_signpost_http_HttpRequest_Lcom_parse_signpost_http_HttpParameters_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sign", "(Lcom/parse/signpost/http/HttpRequest;Lcom/parse/signpost/http/HttpParameters;)Ljava/lang/String;"), new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}
}
