using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Parse.Signpost {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.parse.signpost']/class[@name='AbstractOAuthProvider']"
	[global::Android.Runtime.Register ("com/parse/signpost/AbstractOAuthProvider", DoNotGenerateAcw=true)]
	public abstract partial class AbstractOAuthProvider : global::Java.Lang.Object, global::Com.Parse.Signpost.IOAuthProvider {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/parse/signpost/AbstractOAuthProvider", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AbstractOAuthProvider); }
		}

		protected AbstractOAuthProvider (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.parse.signpost']/class[@name='AbstractOAuthProvider']/constructor[@name='AbstractOAuthProvider' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public AbstractOAuthProvider (string p0, string p1, string p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);;
			IntPtr native_p1 = JNIEnv.NewString (p1);;
			IntPtr native_p2 = JNIEnv.NewString (p2);;
			if (GetType () != typeof (AbstractOAuthProvider)) {
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

		static Delegate cb_getAccessTokenEndpointUrl;
#pragma warning disable 0169
		static Delegate GetGetAccessTokenEndpointUrlHandler ()
		{
			if (cb_getAccessTokenEndpointUrl == null)
				cb_getAccessTokenEndpointUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAccessTokenEndpointUrl);
			return cb_getAccessTokenEndpointUrl;
		}

		static IntPtr n_GetAccessTokenEndpointUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.Signpost.AbstractOAuthProvider __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.AbstractOAuthProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AccessTokenEndpointUrl);
		}
#pragma warning restore 0169

		static IntPtr id_getAccessTokenEndpointUrl;
		public virtual string AccessTokenEndpointUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.signpost']/class[@name='AbstractOAuthProvider']/method[@name='getAccessTokenEndpointUrl' and count(parameter)=0]"
			[Register ("getAccessTokenEndpointUrl", "()Ljava/lang/String;", "GetGetAccessTokenEndpointUrlHandler")]
			get {
				if (id_getAccessTokenEndpointUrl == IntPtr.Zero)
					id_getAccessTokenEndpointUrl = JNIEnv.GetMethodID (class_ref, "getAccessTokenEndpointUrl", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getAccessTokenEndpointUrl), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAccessTokenEndpointUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getAuthorizationWebsiteUrl;
#pragma warning disable 0169
		static Delegate GetGetAuthorizationWebsiteUrlHandler ()
		{
			if (cb_getAuthorizationWebsiteUrl == null)
				cb_getAuthorizationWebsiteUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAuthorizationWebsiteUrl);
			return cb_getAuthorizationWebsiteUrl;
		}

		static IntPtr n_GetAuthorizationWebsiteUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.Signpost.AbstractOAuthProvider __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.AbstractOAuthProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AuthorizationWebsiteUrl);
		}
#pragma warning restore 0169

		static IntPtr id_getAuthorizationWebsiteUrl;
		public virtual string AuthorizationWebsiteUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.signpost']/class[@name='AbstractOAuthProvider']/method[@name='getAuthorizationWebsiteUrl' and count(parameter)=0]"
			[Register ("getAuthorizationWebsiteUrl", "()Ljava/lang/String;", "GetGetAuthorizationWebsiteUrlHandler")]
			get {
				if (id_getAuthorizationWebsiteUrl == IntPtr.Zero)
					id_getAuthorizationWebsiteUrl = JNIEnv.GetMethodID (class_ref, "getAuthorizationWebsiteUrl", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getAuthorizationWebsiteUrl), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAuthorizationWebsiteUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_isOAuth10a;
#pragma warning disable 0169
		static Delegate GetIsOAuth10aHandler ()
		{
			if (cb_isOAuth10a == null)
				cb_isOAuth10a = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsOAuth10a);
			return cb_isOAuth10a;
		}

		static bool n_IsOAuth10a (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.Signpost.AbstractOAuthProvider __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.AbstractOAuthProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.OAuth10a;
		}
#pragma warning restore 0169

		static Delegate cb_setOAuth10a_Z;
#pragma warning disable 0169
		static Delegate GetSetOAuth10a_ZHandler ()
		{
			if (cb_setOAuth10a_Z == null)
				cb_setOAuth10a_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetOAuth10a_Z);
			return cb_setOAuth10a_Z;
		}

		static void n_SetOAuth10a_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Parse.Signpost.AbstractOAuthProvider __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.AbstractOAuthProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OAuth10a = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isOAuth10a;
		static IntPtr id_setOAuth10a_Z;
		public virtual bool OAuth10a {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.signpost']/class[@name='AbstractOAuthProvider']/method[@name='isOAuth10a' and count(parameter)=0]"
			[Register ("isOAuth10a", "()Z", "GetIsOAuth10aHandler")]
			get {
				if (id_isOAuth10a == IntPtr.Zero)
					id_isOAuth10a = JNIEnv.GetMethodID (class_ref, "isOAuth10a", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isOAuth10a);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isOAuth10a", "()Z"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.signpost']/class[@name='AbstractOAuthProvider']/method[@name='setOAuth10a' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setOAuth10a", "(Z)V", "GetSetOAuth10a_ZHandler")]
			set {
				if (id_setOAuth10a_Z == IntPtr.Zero)
					id_setOAuth10a_Z = JNIEnv.GetMethodID (class_ref, "setOAuth10a", "(Z)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setOAuth10a_Z, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOAuth10a", "(Z)V"), new JValue (value));
			}
		}

		static Delegate cb_getRequestHeaders;
#pragma warning disable 0169
		static Delegate GetGetRequestHeadersHandler ()
		{
			if (cb_getRequestHeaders == null)
				cb_getRequestHeaders = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRequestHeaders);
			return cb_getRequestHeaders;
		}

		static IntPtr n_GetRequestHeaders (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.Signpost.AbstractOAuthProvider __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.AbstractOAuthProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.RequestHeaders);
		}
#pragma warning restore 0169

		static IntPtr id_getRequestHeaders;
		public virtual global::System.Collections.Generic.IDictionary<string, string> RequestHeaders {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.signpost']/class[@name='AbstractOAuthProvider']/method[@name='getRequestHeaders' and count(parameter)=0]"
			[Register ("getRequestHeaders", "()Ljava/util/Map;", "GetGetRequestHeadersHandler")]
			get {
				if (id_getRequestHeaders == IntPtr.Zero)
					id_getRequestHeaders = JNIEnv.GetMethodID (class_ref, "getRequestHeaders", "()Ljava/util/Map;");

				if (GetType () == ThresholdType)
					return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getRequestHeaders), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRequestHeaders", "()Ljava/util/Map;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getRequestTokenEndpointUrl;
#pragma warning disable 0169
		static Delegate GetGetRequestTokenEndpointUrlHandler ()
		{
			if (cb_getRequestTokenEndpointUrl == null)
				cb_getRequestTokenEndpointUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRequestTokenEndpointUrl);
			return cb_getRequestTokenEndpointUrl;
		}

		static IntPtr n_GetRequestTokenEndpointUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.Signpost.AbstractOAuthProvider __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.AbstractOAuthProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RequestTokenEndpointUrl);
		}
#pragma warning restore 0169

		static IntPtr id_getRequestTokenEndpointUrl;
		public virtual string RequestTokenEndpointUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.signpost']/class[@name='AbstractOAuthProvider']/method[@name='getRequestTokenEndpointUrl' and count(parameter)=0]"
			[Register ("getRequestTokenEndpointUrl", "()Ljava/lang/String;", "GetGetRequestTokenEndpointUrlHandler")]
			get {
				if (id_getRequestTokenEndpointUrl == IntPtr.Zero)
					id_getRequestTokenEndpointUrl = JNIEnv.GetMethodID (class_ref, "getRequestTokenEndpointUrl", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getRequestTokenEndpointUrl), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRequestTokenEndpointUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getResponseParameters;
#pragma warning disable 0169
		static Delegate GetGetResponseParametersHandler ()
		{
			if (cb_getResponseParameters == null)
				cb_getResponseParameters = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetResponseParameters);
			return cb_getResponseParameters;
		}

		static IntPtr n_GetResponseParameters (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.Signpost.AbstractOAuthProvider __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.AbstractOAuthProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ResponseParameters);
		}
#pragma warning restore 0169

		static Delegate cb_setResponseParameters_Lcom_parse_signpost_http_HttpParameters_;
#pragma warning disable 0169
		static Delegate GetSetResponseParameters_Lcom_parse_signpost_http_HttpParameters_Handler ()
		{
			if (cb_setResponseParameters_Lcom_parse_signpost_http_HttpParameters_ == null)
				cb_setResponseParameters_Lcom_parse_signpost_http_HttpParameters_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetResponseParameters_Lcom_parse_signpost_http_HttpParameters_);
			return cb_setResponseParameters_Lcom_parse_signpost_http_HttpParameters_;
		}

		static void n_SetResponseParameters_Lcom_parse_signpost_http_HttpParameters_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.Signpost.AbstractOAuthProvider __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.AbstractOAuthProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Parse.Signpost.Http.HttpParameters p0 = global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.Http.HttpParameters> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ResponseParameters = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getResponseParameters;
		static IntPtr id_setResponseParameters_Lcom_parse_signpost_http_HttpParameters_;
		public virtual global::Com.Parse.Signpost.Http.HttpParameters ResponseParameters {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.signpost']/class[@name='AbstractOAuthProvider']/method[@name='getResponseParameters' and count(parameter)=0]"
			[Register ("getResponseParameters", "()Lcom/parse/signpost/http/HttpParameters;", "GetGetResponseParametersHandler")]
			get {
				if (id_getResponseParameters == IntPtr.Zero)
					id_getResponseParameters = JNIEnv.GetMethodID (class_ref, "getResponseParameters", "()Lcom/parse/signpost/http/HttpParameters;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.Http.HttpParameters> (JNIEnv.CallObjectMethod  (Handle, id_getResponseParameters), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.Http.HttpParameters> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getResponseParameters", "()Lcom/parse/signpost/http/HttpParameters;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.signpost']/class[@name='AbstractOAuthProvider']/method[@name='setResponseParameters' and count(parameter)=1 and parameter[1][@type='com.parse.signpost.http.HttpParameters']]"
			[Register ("setResponseParameters", "(Lcom/parse/signpost/http/HttpParameters;)V", "GetSetResponseParameters_Lcom_parse_signpost_http_HttpParameters_Handler")]
			set {
				if (id_setResponseParameters_Lcom_parse_signpost_http_HttpParameters_ == IntPtr.Zero)
					id_setResponseParameters_Lcom_parse_signpost_http_HttpParameters_ = JNIEnv.GetMethodID (class_ref, "setResponseParameters", "(Lcom/parse/signpost/http/HttpParameters;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setResponseParameters_Lcom_parse_signpost_http_HttpParameters_, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setResponseParameters", "(Lcom/parse/signpost/http/HttpParameters;)V"), new JValue (value));
			}
		}

		static Delegate cb_closeConnection_Lcom_parse_signpost_http_HttpRequest_Lcom_parse_signpost_http_HttpResponse_;
#pragma warning disable 0169
		static Delegate GetCloseConnection_Lcom_parse_signpost_http_HttpRequest_Lcom_parse_signpost_http_HttpResponse_Handler ()
		{
			if (cb_closeConnection_Lcom_parse_signpost_http_HttpRequest_Lcom_parse_signpost_http_HttpResponse_ == null)
				cb_closeConnection_Lcom_parse_signpost_http_HttpRequest_Lcom_parse_signpost_http_HttpResponse_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_CloseConnection_Lcom_parse_signpost_http_HttpRequest_Lcom_parse_signpost_http_HttpResponse_);
			return cb_closeConnection_Lcom_parse_signpost_http_HttpRequest_Lcom_parse_signpost_http_HttpResponse_;
		}

		static void n_CloseConnection_Lcom_parse_signpost_http_HttpRequest_Lcom_parse_signpost_http_HttpResponse_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Parse.Signpost.AbstractOAuthProvider __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.AbstractOAuthProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Parse.Signpost.Http.IHttpRequest p0 = (global::Com.Parse.Signpost.Http.IHttpRequest)global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.Http.IHttpRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Parse.Signpost.Http.IHttpResponse p1 = (global::Com.Parse.Signpost.Http.IHttpResponse)global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.Http.IHttpResponse> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.CloseConnection (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_closeConnection_Lcom_parse_signpost_http_HttpRequest_Lcom_parse_signpost_http_HttpResponse_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.signpost']/class[@name='AbstractOAuthProvider']/method[@name='closeConnection' and count(parameter)=2 and parameter[1][@type='com.parse.signpost.http.HttpRequest'] and parameter[2][@type='com.parse.signpost.http.HttpResponse']]"
		[Register ("closeConnection", "(Lcom/parse/signpost/http/HttpRequest;Lcom/parse/signpost/http/HttpResponse;)V", "GetCloseConnection_Lcom_parse_signpost_http_HttpRequest_Lcom_parse_signpost_http_HttpResponse_Handler")]
		protected virtual void CloseConnection (global::Com.Parse.Signpost.Http.IHttpRequest p0, global::Com.Parse.Signpost.Http.IHttpResponse p1)
		{
			if (id_closeConnection_Lcom_parse_signpost_http_HttpRequest_Lcom_parse_signpost_http_HttpResponse_ == IntPtr.Zero)
				id_closeConnection_Lcom_parse_signpost_http_HttpRequest_Lcom_parse_signpost_http_HttpResponse_ = JNIEnv.GetMethodID (class_ref, "closeConnection", "(Lcom/parse/signpost/http/HttpRequest;Lcom/parse/signpost/http/HttpResponse;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_closeConnection_Lcom_parse_signpost_http_HttpRequest_Lcom_parse_signpost_http_HttpResponse_, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "closeConnection", "(Lcom/parse/signpost/http/HttpRequest;Lcom/parse/signpost/http/HttpResponse;)V"), new JValue (p0), new JValue (p1));
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
			global::Com.Parse.Signpost.AbstractOAuthProvider __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.AbstractOAuthProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateRequest (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.signpost']/class[@name='AbstractOAuthProvider']/method[@name='createRequest' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("createRequest", "(Ljava/lang/String;)Lcom/parse/signpost/http/HttpRequest;", "GetCreateRequest_Ljava_lang_String_Handler")]
		protected abstract global::Com.Parse.Signpost.Http.IHttpRequest CreateRequest (string p0);

		static Delegate cb_getResponseParameter_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetResponseParameter_Ljava_lang_String_Handler ()
		{
			if (cb_getResponseParameter_Ljava_lang_String_ == null)
				cb_getResponseParameter_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetResponseParameter_Ljava_lang_String_);
			return cb_getResponseParameter_Ljava_lang_String_;
		}

		static IntPtr n_GetResponseParameter_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.Signpost.AbstractOAuthProvider __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.AbstractOAuthProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetResponseParameter (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getResponseParameter_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.signpost']/class[@name='AbstractOAuthProvider']/method[@name='getResponseParameter' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getResponseParameter", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetResponseParameter_Ljava_lang_String_Handler")]
		protected virtual string GetResponseParameter (string p0)
		{
			if (id_getResponseParameter_Ljava_lang_String_ == IntPtr.Zero)
				id_getResponseParameter_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getResponseParameter", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			string __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getResponseParameter_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getResponseParameter", "(Ljava/lang/String;)Ljava/lang/String;"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_handleUnexpectedResponse_ILcom_parse_signpost_http_HttpResponse_;
#pragma warning disable 0169
		static Delegate GetHandleUnexpectedResponse_ILcom_parse_signpost_http_HttpResponse_Handler ()
		{
			if (cb_handleUnexpectedResponse_ILcom_parse_signpost_http_HttpResponse_ == null)
				cb_handleUnexpectedResponse_ILcom_parse_signpost_http_HttpResponse_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_HandleUnexpectedResponse_ILcom_parse_signpost_http_HttpResponse_);
			return cb_handleUnexpectedResponse_ILcom_parse_signpost_http_HttpResponse_;
		}

		static void n_HandleUnexpectedResponse_ILcom_parse_signpost_http_HttpResponse_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Parse.Signpost.AbstractOAuthProvider __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.AbstractOAuthProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Parse.Signpost.Http.IHttpResponse p1 = (global::Com.Parse.Signpost.Http.IHttpResponse)global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.Http.IHttpResponse> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.HandleUnexpectedResponse (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_handleUnexpectedResponse_ILcom_parse_signpost_http_HttpResponse_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.signpost']/class[@name='AbstractOAuthProvider']/method[@name='handleUnexpectedResponse' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.parse.signpost.http.HttpResponse']]"
		[Register ("handleUnexpectedResponse", "(ILcom/parse/signpost/http/HttpResponse;)V", "GetHandleUnexpectedResponse_ILcom_parse_signpost_http_HttpResponse_Handler")]
		protected virtual void HandleUnexpectedResponse (int p0, global::Com.Parse.Signpost.Http.IHttpResponse p1)
		{
			if (id_handleUnexpectedResponse_ILcom_parse_signpost_http_HttpResponse_ == IntPtr.Zero)
				id_handleUnexpectedResponse_ILcom_parse_signpost_http_HttpResponse_ = JNIEnv.GetMethodID (class_ref, "handleUnexpectedResponse", "(ILcom/parse/signpost/http/HttpResponse;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_handleUnexpectedResponse_ILcom_parse_signpost_http_HttpResponse_, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "handleUnexpectedResponse", "(ILcom/parse/signpost/http/HttpResponse;)V"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_removeListener_Lcom_parse_signpost_OAuthProviderListener_;
#pragma warning disable 0169
		static Delegate GetRemoveListener_Lcom_parse_signpost_OAuthProviderListener_Handler ()
		{
			if (cb_removeListener_Lcom_parse_signpost_OAuthProviderListener_ == null)
				cb_removeListener_Lcom_parse_signpost_OAuthProviderListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveListener_Lcom_parse_signpost_OAuthProviderListener_);
			return cb_removeListener_Lcom_parse_signpost_OAuthProviderListener_;
		}

		static void n_RemoveListener_Lcom_parse_signpost_OAuthProviderListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.Signpost.AbstractOAuthProvider __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.AbstractOAuthProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Parse.Signpost.IOAuthProviderListener p0 = (global::Com.Parse.Signpost.IOAuthProviderListener)global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.IOAuthProviderListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeListener_Lcom_parse_signpost_OAuthProviderListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.signpost']/class[@name='AbstractOAuthProvider']/method[@name='removeListener' and count(parameter)=1 and parameter[1][@type='com.parse.signpost.OAuthProviderListener']]"
		[Register ("removeListener", "(Lcom/parse/signpost/OAuthProviderListener;)V", "GetRemoveListener_Lcom_parse_signpost_OAuthProviderListener_Handler")]
		public virtual void RemoveListener (global::Com.Parse.Signpost.IOAuthProviderListener p0)
		{
			if (id_removeListener_Lcom_parse_signpost_OAuthProviderListener_ == IntPtr.Zero)
				id_removeListener_Lcom_parse_signpost_OAuthProviderListener_ = JNIEnv.GetMethodID (class_ref, "removeListener", "(Lcom/parse/signpost/OAuthProviderListener;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_removeListener_Lcom_parse_signpost_OAuthProviderListener_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeListener", "(Lcom/parse/signpost/OAuthProviderListener;)V"), new JValue (p0));
		}

		static Delegate cb_retrieveAccessToken_Lcom_parse_signpost_OAuthConsumer_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRetrieveAccessToken_Lcom_parse_signpost_OAuthConsumer_Ljava_lang_String_Handler ()
		{
			if (cb_retrieveAccessToken_Lcom_parse_signpost_OAuthConsumer_Ljava_lang_String_ == null)
				cb_retrieveAccessToken_Lcom_parse_signpost_OAuthConsumer_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_RetrieveAccessToken_Lcom_parse_signpost_OAuthConsumer_Ljava_lang_String_);
			return cb_retrieveAccessToken_Lcom_parse_signpost_OAuthConsumer_Ljava_lang_String_;
		}

		static void n_RetrieveAccessToken_Lcom_parse_signpost_OAuthConsumer_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Parse.Signpost.AbstractOAuthProvider __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.AbstractOAuthProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Parse.Signpost.IOAuthConsumer p0 = (global::Com.Parse.Signpost.IOAuthConsumer)global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.IOAuthConsumer> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.RetrieveAccessToken (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_retrieveAccessToken_Lcom_parse_signpost_OAuthConsumer_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.signpost']/class[@name='AbstractOAuthProvider']/method[@name='retrieveAccessToken' and count(parameter)=2 and parameter[1][@type='com.parse.signpost.OAuthConsumer'] and parameter[2][@type='java.lang.String']]"
		[Register ("retrieveAccessToken", "(Lcom/parse/signpost/OAuthConsumer;Ljava/lang/String;)V", "GetRetrieveAccessToken_Lcom_parse_signpost_OAuthConsumer_Ljava_lang_String_Handler")]
		public virtual void RetrieveAccessToken (global::Com.Parse.Signpost.IOAuthConsumer p0, string p1)
		{
			if (id_retrieveAccessToken_Lcom_parse_signpost_OAuthConsumer_Ljava_lang_String_ == IntPtr.Zero)
				id_retrieveAccessToken_Lcom_parse_signpost_OAuthConsumer_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "retrieveAccessToken", "(Lcom/parse/signpost/OAuthConsumer;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_retrieveAccessToken_Lcom_parse_signpost_OAuthConsumer_Ljava_lang_String_, new JValue (p0), new JValue (native_p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "retrieveAccessToken", "(Lcom/parse/signpost/OAuthConsumer;Ljava/lang/String;)V"), new JValue (p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_retrieveRequestToken_Lcom_parse_signpost_OAuthConsumer_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRetrieveRequestToken_Lcom_parse_signpost_OAuthConsumer_Ljava_lang_String_Handler ()
		{
			if (cb_retrieveRequestToken_Lcom_parse_signpost_OAuthConsumer_Ljava_lang_String_ == null)
				cb_retrieveRequestToken_Lcom_parse_signpost_OAuthConsumer_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_RetrieveRequestToken_Lcom_parse_signpost_OAuthConsumer_Ljava_lang_String_);
			return cb_retrieveRequestToken_Lcom_parse_signpost_OAuthConsumer_Ljava_lang_String_;
		}

		static IntPtr n_RetrieveRequestToken_Lcom_parse_signpost_OAuthConsumer_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Parse.Signpost.AbstractOAuthProvider __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.AbstractOAuthProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Parse.Signpost.IOAuthConsumer p0 = (global::Com.Parse.Signpost.IOAuthConsumer)global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.IOAuthConsumer> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.RetrieveRequestToken (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_retrieveRequestToken_Lcom_parse_signpost_OAuthConsumer_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.signpost']/class[@name='AbstractOAuthProvider']/method[@name='retrieveRequestToken' and count(parameter)=2 and parameter[1][@type='com.parse.signpost.OAuthConsumer'] and parameter[2][@type='java.lang.String']]"
		[Register ("retrieveRequestToken", "(Lcom/parse/signpost/OAuthConsumer;Ljava/lang/String;)Ljava/lang/String;", "GetRetrieveRequestToken_Lcom_parse_signpost_OAuthConsumer_Ljava_lang_String_Handler")]
		public virtual string RetrieveRequestToken (global::Com.Parse.Signpost.IOAuthConsumer p0, string p1)
		{
			if (id_retrieveRequestToken_Lcom_parse_signpost_OAuthConsumer_Ljava_lang_String_ == IntPtr.Zero)
				id_retrieveRequestToken_Lcom_parse_signpost_OAuthConsumer_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "retrieveRequestToken", "(Lcom/parse/signpost/OAuthConsumer;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p1 = JNIEnv.NewString (p1);

			string __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_retrieveRequestToken_Lcom_parse_signpost_OAuthConsumer_Ljava_lang_String_, new JValue (p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "retrieveRequestToken", "(Lcom/parse/signpost/OAuthConsumer;Ljava/lang/String;)Ljava/lang/String;"), new JValue (p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_retrieveToken_Lcom_parse_signpost_OAuthConsumer_Ljava_lang_String_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRetrieveToken_Lcom_parse_signpost_OAuthConsumer_Ljava_lang_String_arrayLjava_lang_String_Handler ()
		{
			if (cb_retrieveToken_Lcom_parse_signpost_OAuthConsumer_Ljava_lang_String_arrayLjava_lang_String_ == null)
				cb_retrieveToken_Lcom_parse_signpost_OAuthConsumer_Ljava_lang_String_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_RetrieveToken_Lcom_parse_signpost_OAuthConsumer_Ljava_lang_String_arrayLjava_lang_String_);
			return cb_retrieveToken_Lcom_parse_signpost_OAuthConsumer_Ljava_lang_String_arrayLjava_lang_String_;
		}

		static void n_RetrieveToken_Lcom_parse_signpost_OAuthConsumer_Ljava_lang_String_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Parse.Signpost.AbstractOAuthProvider __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.AbstractOAuthProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Parse.Signpost.IOAuthConsumer p0 = (global::Com.Parse.Signpost.IOAuthConsumer)global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.IOAuthConsumer> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string[] p2 = (string[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (string));
			__this.RetrieveToken (p0, p1, p2);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
		}
#pragma warning restore 0169

		static IntPtr id_retrieveToken_Lcom_parse_signpost_OAuthConsumer_Ljava_lang_String_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.signpost']/class[@name='AbstractOAuthProvider']/method[@name='retrieveToken' and count(parameter)=3 and parameter[1][@type='com.parse.signpost.OAuthConsumer'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String...']]"
		[Register ("retrieveToken", "(Lcom/parse/signpost/OAuthConsumer;Ljava/lang/String;[Ljava/lang/String;)V", "GetRetrieveToken_Lcom_parse_signpost_OAuthConsumer_Ljava_lang_String_arrayLjava_lang_String_Handler")]
		protected virtual void RetrieveToken (global::Com.Parse.Signpost.IOAuthConsumer p0, string p1, params  string[] p2)
		{
			if (id_retrieveToken_Lcom_parse_signpost_OAuthConsumer_Ljava_lang_String_arrayLjava_lang_String_ == IntPtr.Zero)
				id_retrieveToken_Lcom_parse_signpost_OAuthConsumer_Ljava_lang_String_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "retrieveToken", "(Lcom/parse/signpost/OAuthConsumer;Ljava/lang/String;[Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_retrieveToken_Lcom_parse_signpost_OAuthConsumer_Ljava_lang_String_arrayLjava_lang_String_, new JValue (p0), new JValue (native_p1), new JValue (native_p2));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "retrieveToken", "(Lcom/parse/signpost/OAuthConsumer;Ljava/lang/String;[Ljava/lang/String;)V"), new JValue (p0), new JValue (native_p1), new JValue (native_p2));
			JNIEnv.DeleteLocalRef (native_p1);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
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
			global::Com.Parse.Signpost.AbstractOAuthProvider __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.AbstractOAuthProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Parse.Signpost.Http.IHttpRequest p0 = (global::Com.Parse.Signpost.Http.IHttpRequest)global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.Http.IHttpRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SendRequest (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.signpost']/class[@name='AbstractOAuthProvider']/method[@name='sendRequest' and count(parameter)=1 and parameter[1][@type='com.parse.signpost.http.HttpRequest']]"
		[Register ("sendRequest", "(Lcom/parse/signpost/http/HttpRequest;)Lcom/parse/signpost/http/HttpResponse;", "GetSendRequest_Lcom_parse_signpost_http_HttpRequest_Handler")]
		protected abstract global::Com.Parse.Signpost.Http.IHttpResponse SendRequest (global::Com.Parse.Signpost.Http.IHttpRequest p0);

		static Delegate cb_setListener_Lcom_parse_signpost_OAuthProviderListener_;
#pragma warning disable 0169
		static Delegate GetSetListener_Lcom_parse_signpost_OAuthProviderListener_Handler ()
		{
			if (cb_setListener_Lcom_parse_signpost_OAuthProviderListener_ == null)
				cb_setListener_Lcom_parse_signpost_OAuthProviderListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetListener_Lcom_parse_signpost_OAuthProviderListener_);
			return cb_setListener_Lcom_parse_signpost_OAuthProviderListener_;
		}

		static void n_SetListener_Lcom_parse_signpost_OAuthProviderListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.Signpost.AbstractOAuthProvider __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.AbstractOAuthProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Parse.Signpost.IOAuthProviderListener p0 = (global::Com.Parse.Signpost.IOAuthProviderListener)global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.IOAuthProviderListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setListener_Lcom_parse_signpost_OAuthProviderListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.signpost']/class[@name='AbstractOAuthProvider']/method[@name='setListener' and count(parameter)=1 and parameter[1][@type='com.parse.signpost.OAuthProviderListener']]"
		[Register ("setListener", "(Lcom/parse/signpost/OAuthProviderListener;)V", "GetSetListener_Lcom_parse_signpost_OAuthProviderListener_Handler")]
		public virtual void SetListener (global::Com.Parse.Signpost.IOAuthProviderListener p0)
		{
			if (id_setListener_Lcom_parse_signpost_OAuthProviderListener_ == IntPtr.Zero)
				id_setListener_Lcom_parse_signpost_OAuthProviderListener_ = JNIEnv.GetMethodID (class_ref, "setListener", "(Lcom/parse/signpost/OAuthProviderListener;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setListener_Lcom_parse_signpost_OAuthProviderListener_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setListener", "(Lcom/parse/signpost/OAuthProviderListener;)V"), new JValue (p0));
		}

		static Delegate cb_setRequestHeader_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetRequestHeader_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_setRequestHeader_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_setRequestHeader_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetRequestHeader_Ljava_lang_String_Ljava_lang_String_);
			return cb_setRequestHeader_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_SetRequestHeader_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Parse.Signpost.AbstractOAuthProvider __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.AbstractOAuthProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetRequestHeader (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setRequestHeader_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.signpost']/class[@name='AbstractOAuthProvider']/method[@name='setRequestHeader' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("setRequestHeader", "(Ljava/lang/String;Ljava/lang/String;)V", "GetSetRequestHeader_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual void SetRequestHeader (string p0, string p1)
		{
			if (id_setRequestHeader_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_setRequestHeader_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setRequestHeader", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setRequestHeader_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRequestHeader", "(Ljava/lang/String;Ljava/lang/String;)V"), new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

#region "Event implementation for Com.Parse.Signpost.IOAuthProviderListener"

		global::Com.Parse.Signpost.IOAuthProviderListenerImplementor __CreateIOAuthProviderListenerImplementor ()
		{
			return new global::Com.Parse.Signpost.IOAuthProviderListenerImplementor (this);
		}
#endregion
	}

	[global::Android.Runtime.Register ("com/parse/signpost/AbstractOAuthProvider", DoNotGenerateAcw=true)]
	internal partial class AbstractOAuthProviderInvoker : AbstractOAuthProvider {

		public AbstractOAuthProviderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (AbstractOAuthProviderInvoker); }
		}

		static IntPtr id_createRequest_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.signpost']/class[@name='AbstractOAuthProvider']/method[@name='createRequest' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("createRequest", "(Ljava/lang/String;)Lcom/parse/signpost/http/HttpRequest;", "GetCreateRequest_Ljava_lang_String_Handler")]
		protected override global::Com.Parse.Signpost.Http.IHttpRequest CreateRequest (string p0)
		{
			if (id_createRequest_Ljava_lang_String_ == IntPtr.Zero)
				id_createRequest_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "createRequest", "(Ljava/lang/String;)Lcom/parse/signpost/http/HttpRequest;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Com.Parse.Signpost.Http.IHttpRequest __ret = global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.Http.IHttpRequest> (JNIEnv.CallObjectMethod  (Handle, id_createRequest_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_sendRequest_Lcom_parse_signpost_http_HttpRequest_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.signpost']/class[@name='AbstractOAuthProvider']/method[@name='sendRequest' and count(parameter)=1 and parameter[1][@type='com.parse.signpost.http.HttpRequest']]"
		[Register ("sendRequest", "(Lcom/parse/signpost/http/HttpRequest;)Lcom/parse/signpost/http/HttpResponse;", "GetSendRequest_Lcom_parse_signpost_http_HttpRequest_Handler")]
		protected override global::Com.Parse.Signpost.Http.IHttpResponse SendRequest (global::Com.Parse.Signpost.Http.IHttpRequest p0)
		{
			if (id_sendRequest_Lcom_parse_signpost_http_HttpRequest_ == IntPtr.Zero)
				id_sendRequest_Lcom_parse_signpost_http_HttpRequest_ = JNIEnv.GetMethodID (class_ref, "sendRequest", "(Lcom/parse/signpost/http/HttpRequest;)Lcom/parse/signpost/http/HttpResponse;");
			global::Com.Parse.Signpost.Http.IHttpResponse __ret = global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.Http.IHttpResponse> (JNIEnv.CallObjectMethod  (Handle, id_sendRequest_Lcom_parse_signpost_http_HttpRequest_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}

}
