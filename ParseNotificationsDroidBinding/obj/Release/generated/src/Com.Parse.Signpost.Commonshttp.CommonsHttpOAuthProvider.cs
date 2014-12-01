using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Parse.Signpost.Commonshttp {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.parse.signpost.commonshttp']/class[@name='CommonsHttpOAuthProvider']"
	[global::Android.Runtime.Register ("com/parse/signpost/commonshttp/CommonsHttpOAuthProvider", DoNotGenerateAcw=true)]
	public partial class CommonsHttpOAuthProvider : global::Com.Parse.Signpost.AbstractOAuthProvider {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/parse/signpost/commonshttp/CommonsHttpOAuthProvider", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CommonsHttpOAuthProvider); }
		}

		protected CommonsHttpOAuthProvider (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.parse.signpost.commonshttp']/class[@name='CommonsHttpOAuthProvider']/constructor[@name='CommonsHttpOAuthProvider' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public CommonsHttpOAuthProvider (string p0, string p1, string p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);;
			IntPtr native_p1 = JNIEnv.NewString (p1);;
			IntPtr native_p2 = JNIEnv.NewString (p2);;
			if (GetType () != typeof (CommonsHttpOAuthProvider)) {
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

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lorg_apache_http_client_HttpClient_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.parse.signpost.commonshttp']/class[@name='CommonsHttpOAuthProvider']/constructor[@name='CommonsHttpOAuthProvider' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='org.apache.http.client.HttpClient']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lorg/apache/http/client/HttpClient;)V", "")]
		public CommonsHttpOAuthProvider (string p0, string p1, string p2, global::Org.Apache.Http.Client.IHttpClient p3) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);;
			IntPtr native_p1 = JNIEnv.NewString (p1);;
			IntPtr native_p2 = JNIEnv.NewString (p2);;
			if (GetType () != typeof (CommonsHttpOAuthProvider)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lorg/apache/http/client/HttpClient;)V", new JValue (native_p0), new JValue (native_p1), new JValue (native_p2), new JValue (p3)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lorg/apache/http/client/HttpClient;)V", new JValue (native_p0), new JValue (native_p1), new JValue (native_p2), new JValue (p3));
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				return;
			}

			if (id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lorg_apache_http_client_HttpClient_ == IntPtr.Zero)
				id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lorg_apache_http_client_HttpClient_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lorg/apache/http/client/HttpClient;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lorg_apache_http_client_HttpClient_, new JValue (native_p0), new JValue (native_p1), new JValue (native_p2), new JValue (p3)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lorg_apache_http_client_HttpClient_, new JValue (native_p0), new JValue (native_p1), new JValue (native_p2), new JValue (p3));
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
			global::Com.Parse.Signpost.Commonshttp.CommonsHttpOAuthProvider __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.Commonshttp.CommonsHttpOAuthProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateRequest (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_createRequest_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.signpost.commonshttp']/class[@name='CommonsHttpOAuthProvider']/method[@name='createRequest' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Parse.Signpost.Commonshttp.CommonsHttpOAuthProvider __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.Commonshttp.CommonsHttpOAuthProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Parse.Signpost.Http.IHttpRequest p0 = (global::Com.Parse.Signpost.Http.IHttpRequest)global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.Http.IHttpRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SendRequest (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_sendRequest_Lcom_parse_signpost_http_HttpRequest_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.signpost.commonshttp']/class[@name='CommonsHttpOAuthProvider']/method[@name='sendRequest' and count(parameter)=1 and parameter[1][@type='com.parse.signpost.http.HttpRequest']]"
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

		static Delegate cb_setHttpClient_Lorg_apache_http_client_HttpClient_;
#pragma warning disable 0169
		static Delegate GetSetHttpClient_Lorg_apache_http_client_HttpClient_Handler ()
		{
			if (cb_setHttpClient_Lorg_apache_http_client_HttpClient_ == null)
				cb_setHttpClient_Lorg_apache_http_client_HttpClient_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetHttpClient_Lorg_apache_http_client_HttpClient_);
			return cb_setHttpClient_Lorg_apache_http_client_HttpClient_;
		}

		static void n_SetHttpClient_Lorg_apache_http_client_HttpClient_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.Signpost.Commonshttp.CommonsHttpOAuthProvider __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.Commonshttp.CommonsHttpOAuthProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Apache.Http.Client.IHttpClient p0 = (global::Org.Apache.Http.Client.IHttpClient)global::Java.Lang.Object.GetObject<global::Org.Apache.Http.Client.IHttpClient> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetHttpClient (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setHttpClient_Lorg_apache_http_client_HttpClient_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.signpost.commonshttp']/class[@name='CommonsHttpOAuthProvider']/method[@name='setHttpClient' and count(parameter)=1 and parameter[1][@type='org.apache.http.client.HttpClient']]"
		[Register ("setHttpClient", "(Lorg/apache/http/client/HttpClient;)V", "GetSetHttpClient_Lorg_apache_http_client_HttpClient_Handler")]
		public virtual void SetHttpClient (global::Org.Apache.Http.Client.IHttpClient p0)
		{
			if (id_setHttpClient_Lorg_apache_http_client_HttpClient_ == IntPtr.Zero)
				id_setHttpClient_Lorg_apache_http_client_HttpClient_ = JNIEnv.GetMethodID (class_ref, "setHttpClient", "(Lorg/apache/http/client/HttpClient;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setHttpClient_Lorg_apache_http_client_HttpClient_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setHttpClient", "(Lorg/apache/http/client/HttpClient;)V"), new JValue (p0));
		}

	}
}
