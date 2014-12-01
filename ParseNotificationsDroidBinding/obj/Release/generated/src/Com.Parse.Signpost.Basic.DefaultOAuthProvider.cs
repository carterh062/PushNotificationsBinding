using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Parse.Signpost.Basic {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.parse.signpost.basic']/class[@name='DefaultOAuthProvider']"
	[global::Android.Runtime.Register ("com/parse/signpost/basic/DefaultOAuthProvider", DoNotGenerateAcw=true)]
	public partial class DefaultOAuthProvider : global::Com.Parse.Signpost.AbstractOAuthProvider {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/parse/signpost/basic/DefaultOAuthProvider", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DefaultOAuthProvider); }
		}

		protected DefaultOAuthProvider (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.parse.signpost.basic']/class[@name='DefaultOAuthProvider']/constructor[@name='DefaultOAuthProvider' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public DefaultOAuthProvider (string p0, string p1, string p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);;
			IntPtr native_p1 = JNIEnv.NewString (p1);;
			IntPtr native_p2 = JNIEnv.NewString (p2);;
			if (GetType () != typeof (DefaultOAuthProvider)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", new JValue (native_p0), new JValue (native_p1), new JValue (native_p2)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", new JValue (native_p0), new JValue (native_p1), new JValue (native_p2));
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				return;
			}

			if (id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1), new JValue (native_p2)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1), new JValue (native_p2));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static Delegate cb_createRequest_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCreateRequest_Ljava_lang_String_Handler ()
		{
			if (cb_createRequest_Ljava_lang_String_ == null)
				cb_createRequest_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateRequest_Ljava_lang_String_);
			return cb_createRequest_Ljava_lang_String_;
		}

		static IntPtr n_CreateRequest_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.Signpost.Basic.DefaultOAuthProvider __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.Basic.DefaultOAuthProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateRequest (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_createRequest_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.signpost.basic']/class[@name='DefaultOAuthProvider']/method[@name='createRequest' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("createRequest", "(Ljava/lang/String;)Lcom/parse/signpost/http/HttpRequest;", "GetCreateRequest_Ljava_lang_String_Handler")]
		protected override global::Com.Parse.Signpost.Http.IHttpRequest CreateRequest (string p0)
		{
			if (id_createRequest_Ljava_lang_String_ == IntPtr.Zero)
				id_createRequest_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "createRequest", "(Ljava/lang/String;)Lcom/parse/signpost/http/HttpRequest;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Com.Parse.Signpost.Http.IHttpRequest __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.Http.IHttpRequest> (JNIEnv.CallObjectMethod  (Handle, id_createRequest_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.Http.IHttpRequest> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createRequest", "(Ljava/lang/String;)Lcom/parse/signpost/http/HttpRequest;"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_sendRequest_Lcom_parse_signpost_http_HttpRequest_;
#pragma warning disable 0169
		static Delegate GetSendRequest_Lcom_parse_signpost_http_HttpRequest_Handler ()
		{
			if (cb_sendRequest_Lcom_parse_signpost_http_HttpRequest_ == null)
				cb_sendRequest_Lcom_parse_signpost_http_HttpRequest_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SendRequest_Lcom_parse_signpost_http_HttpRequest_);
			return cb_sendRequest_Lcom_parse_signpost_http_HttpRequest_;
		}

		static IntPtr n_SendRequest_Lcom_parse_signpost_http_HttpRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.Signpost.Basic.DefaultOAuthProvider __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.Basic.DefaultOAuthProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Parse.Signpost.Http.IHttpRequest p0 = (global::Com.Parse.Signpost.Http.IHttpRequest)global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.Http.IHttpRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SendRequest (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_sendRequest_Lcom_parse_signpost_http_HttpRequest_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.signpost.basic']/class[@name='DefaultOAuthProvider']/method[@name='sendRequest' and count(parameter)=1 and parameter[1][@type='com.parse.signpost.http.HttpRequest']]"
		[Register ("sendRequest", "(Lcom/parse/signpost/http/HttpRequest;)Lcom/parse/signpost/http/HttpResponse;", "GetSendRequest_Lcom_parse_signpost_http_HttpRequest_Handler")]
		protected override global::Com.Parse.Signpost.Http.IHttpResponse SendRequest (global::Com.Parse.Signpost.Http.IHttpRequest p0)
		{
			if (id_sendRequest_Lcom_parse_signpost_http_HttpRequest_ == IntPtr.Zero)
				id_sendRequest_Lcom_parse_signpost_http_HttpRequest_ = JNIEnv.GetMethodID (class_ref, "sendRequest", "(Lcom/parse/signpost/http/HttpRequest;)Lcom/parse/signpost/http/HttpResponse;");

			global::Com.Parse.Signpost.Http.IHttpResponse __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.Http.IHttpResponse> (JNIEnv.CallObjectMethod  (Handle, id_sendRequest_Lcom_parse_signpost_http_HttpRequest_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.Http.IHttpResponse> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendRequest", "(Lcom/parse/signpost/http/HttpRequest;)Lcom/parse/signpost/http/HttpResponse;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}
}
