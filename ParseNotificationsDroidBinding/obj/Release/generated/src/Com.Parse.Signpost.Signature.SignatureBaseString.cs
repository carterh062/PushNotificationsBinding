using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Parse.Signpost.Signature {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.parse.signpost.signature']/class[@name='SignatureBaseString']"
	[global::Android.Runtime.Register ("com/parse/signpost/signature/SignatureBaseString", DoNotGenerateAcw=true)]
	public partial class SignatureBaseString : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/parse/signpost/signature/SignatureBaseString", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SignatureBaseString); }
		}

		protected SignatureBaseString (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_parse_signpost_http_HttpRequest_Lcom_parse_signpost_http_HttpParameters_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.parse.signpost.signature']/class[@name='SignatureBaseString']/constructor[@name='SignatureBaseString' and count(parameter)=2 and parameter[1][@type='com.parse.signpost.http.HttpRequest'] and parameter[2][@type='com.parse.signpost.http.HttpParameters']]"
		[Register (".ctor", "(Lcom/parse/signpost/http/HttpRequest;Lcom/parse/signpost/http/HttpParameters;)V", "")]
		public SignatureBaseString (global::Com.Parse.Signpost.Http.IHttpRequest p0, global::Com.Parse.Signpost.Http.HttpParameters p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (SignatureBaseString)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/parse/signpost/http/HttpRequest;Lcom/parse/signpost/http/HttpParameters;)V", new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/parse/signpost/http/HttpRequest;Lcom/parse/signpost/http/HttpParameters;)V", new JValue (p0), new JValue (p1));
				return;
			}

			if (id_ctor_Lcom_parse_signpost_http_HttpRequest_Lcom_parse_signpost_http_HttpParameters_ == IntPtr.Zero)
				id_ctor_Lcom_parse_signpost_http_HttpRequest_Lcom_parse_signpost_http_HttpParameters_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/parse/signpost/http/HttpRequest;Lcom/parse/signpost/http/HttpParameters;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_parse_signpost_http_HttpRequest_Lcom_parse_signpost_http_HttpParameters_, new JValue (p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_parse_signpost_http_HttpRequest_Lcom_parse_signpost_http_HttpParameters_, new JValue (p0), new JValue (p1));
		}

		static Delegate cb_generate;
#pragma warning disable 0169
		static Delegate GetGenerateHandler ()
		{
			if (cb_generate == null)
				cb_generate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Generate);
			return cb_generate;
		}

		static IntPtr n_Generate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.Signpost.Signature.SignatureBaseString __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.Signature.SignatureBaseString> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Generate ());
		}
#pragma warning restore 0169

		static IntPtr id_generate;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.signpost.signature']/class[@name='SignatureBaseString']/method[@name='generate' and count(parameter)=0]"
		[Register ("generate", "()Ljava/lang/String;", "GetGenerateHandler")]
		public virtual string Generate ()
		{
			if (id_generate == IntPtr.Zero)
				id_generate = JNIEnv.GetMethodID (class_ref, "generate", "()Ljava/lang/String;");

			if (GetType () == ThresholdType)
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_generate), JniHandleOwnership.TransferLocalRef);
			else
				return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "generate", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_normalizeRequestParameters;
#pragma warning disable 0169
		static Delegate GetNormalizeRequestParametersHandler ()
		{
			if (cb_normalizeRequestParameters == null)
				cb_normalizeRequestParameters = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_NormalizeRequestParameters);
			return cb_normalizeRequestParameters;
		}

		static IntPtr n_NormalizeRequestParameters (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.Signpost.Signature.SignatureBaseString __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.Signature.SignatureBaseString> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.NormalizeRequestParameters ());
		}
#pragma warning restore 0169

		static IntPtr id_normalizeRequestParameters;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.signpost.signature']/class[@name='SignatureBaseString']/method[@name='normalizeRequestParameters' and count(parameter)=0]"
		[Register ("normalizeRequestParameters", "()Ljava/lang/String;", "GetNormalizeRequestParametersHandler")]
		public virtual string NormalizeRequestParameters ()
		{
			if (id_normalizeRequestParameters == IntPtr.Zero)
				id_normalizeRequestParameters = JNIEnv.GetMethodID (class_ref, "normalizeRequestParameters", "()Ljava/lang/String;");

			if (GetType () == ThresholdType)
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_normalizeRequestParameters), JniHandleOwnership.TransferLocalRef);
			else
				return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "normalizeRequestParameters", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_normalizeRequestUrl;
#pragma warning disable 0169
		static Delegate GetNormalizeRequestUrlHandler ()
		{
			if (cb_normalizeRequestUrl == null)
				cb_normalizeRequestUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_NormalizeRequestUrl);
			return cb_normalizeRequestUrl;
		}

		static IntPtr n_NormalizeRequestUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.Signpost.Signature.SignatureBaseString __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.Signature.SignatureBaseString> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.NormalizeRequestUrl ());
		}
#pragma warning restore 0169

		static IntPtr id_normalizeRequestUrl;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.signpost.signature']/class[@name='SignatureBaseString']/method[@name='normalizeRequestUrl' and count(parameter)=0]"
		[Register ("normalizeRequestUrl", "()Ljava/lang/String;", "GetNormalizeRequestUrlHandler")]
		public virtual string NormalizeRequestUrl ()
		{
			if (id_normalizeRequestUrl == IntPtr.Zero)
				id_normalizeRequestUrl = JNIEnv.GetMethodID (class_ref, "normalizeRequestUrl", "()Ljava/lang/String;");

			if (GetType () == ThresholdType)
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_normalizeRequestUrl), JniHandleOwnership.TransferLocalRef);
			else
				return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "normalizeRequestUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
		}

	}
}
