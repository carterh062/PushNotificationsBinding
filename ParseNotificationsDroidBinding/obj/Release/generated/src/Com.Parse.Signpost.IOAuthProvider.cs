using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Parse.Signpost {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.parse.signpost']/interface[@name='OAuthProvider']"
	[Register ("com/parse/signpost/OAuthProvider", "", "Com.Parse.Signpost.IOAuthProviderInvoker")]
	public partial interface IOAuthProvider : global::Java.IO.ISerializable {

		string AccessTokenEndpointUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.signpost']/interface[@name='OAuthProvider']/method[@name='getAccessTokenEndpointUrl' and count(parameter)=0]"
			[Register ("getAccessTokenEndpointUrl", "()Ljava/lang/String;", "GetGetAccessTokenEndpointUrlHandler:Com.Parse.Signpost.IOAuthProviderInvoker, ParseNotificationsDroidBinding")] get;
		}

		string AuthorizationWebsiteUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.signpost']/interface[@name='OAuthProvider']/method[@name='getAuthorizationWebsiteUrl' and count(parameter)=0]"
			[Register ("getAuthorizationWebsiteUrl", "()Ljava/lang/String;", "GetGetAuthorizationWebsiteUrlHandler:Com.Parse.Signpost.IOAuthProviderInvoker, ParseNotificationsDroidBinding")] get;
		}

		bool OAuth10a {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.signpost']/interface[@name='OAuthProvider']/method[@name='isOAuth10a' and count(parameter)=0]"
			[Register ("isOAuth10a", "()Z", "GetIsOAuth10aHandler:Com.Parse.Signpost.IOAuthProviderInvoker, ParseNotificationsDroidBinding")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.signpost']/interface[@name='OAuthProvider']/method[@name='setOAuth10a' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setOAuth10a", "(Z)V", "GetSetOAuth10a_ZHandler:Com.Parse.Signpost.IOAuthProviderInvoker, ParseNotificationsDroidBinding")] set;
		}

		global::System.Collections.Generic.IDictionary<string, string> RequestHeaders {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.signpost']/interface[@name='OAuthProvider']/method[@name='getRequestHeaders' and count(parameter)=0]"
			[Register ("getRequestHeaders", "()Ljava/util/Map;", "GetGetRequestHeadersHandler:Com.Parse.Signpost.IOAuthProviderInvoker, ParseNotificationsDroidBinding")] get;
		}

		string RequestTokenEndpointUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.signpost']/interface[@name='OAuthProvider']/method[@name='getRequestTokenEndpointUrl' and count(parameter)=0]"
			[Register ("getRequestTokenEndpointUrl", "()Ljava/lang/String;", "GetGetRequestTokenEndpointUrlHandler:Com.Parse.Signpost.IOAuthProviderInvoker, ParseNotificationsDroidBinding")] get;
		}

		global::Com.Parse.Signpost.Http.HttpParameters ResponseParameters {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.signpost']/interface[@name='OAuthProvider']/method[@name='getResponseParameters' and count(parameter)=0]"
			[Register ("getResponseParameters", "()Lcom/parse/signpost/http/HttpParameters;", "GetGetResponseParametersHandler:Com.Parse.Signpost.IOAuthProviderInvoker, ParseNotificationsDroidBinding")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.signpost']/interface[@name='OAuthProvider']/method[@name='setResponseParameters' and count(parameter)=1 and parameter[1][@type='com.parse.signpost.http.HttpParameters']]"
			[Register ("setResponseParameters", "(Lcom/parse/signpost/http/HttpParameters;)V", "GetSetResponseParameters_Lcom_parse_signpost_http_HttpParameters_Handler:Com.Parse.Signpost.IOAuthProviderInvoker, ParseNotificationsDroidBinding")] set;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.signpost']/interface[@name='OAuthProvider']/method[@name='removeListener' and count(parameter)=1 and parameter[1][@type='com.parse.signpost.OAuthProviderListener']]"
		[Register ("removeListener", "(Lcom/parse/signpost/OAuthProviderListener;)V", "GetRemoveListener_Lcom_parse_signpost_OAuthProviderListener_Handler:Com.Parse.Signpost.IOAuthProviderInvoker, ParseNotificationsDroidBinding")]
		void RemoveListener (global::Com.Parse.Signpost.IOAuthProviderListener p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.signpost']/interface[@name='OAuthProvider']/method[@name='retrieveAccessToken' and count(parameter)=2 and parameter[1][@type='com.parse.signpost.OAuthConsumer'] and parameter[2][@type='java.lang.String']]"
		[Register ("retrieveAccessToken", "(Lcom/parse/signpost/OAuthConsumer;Ljava/lang/String;)V", "GetRetrieveAccessToken_Lcom_parse_signpost_OAuthConsumer_Ljava_lang_String_Handler:Com.Parse.Signpost.IOAuthProviderInvoker, ParseNotificationsDroidBinding")]
		void RetrieveAccessToken (global::Com.Parse.Signpost.IOAuthConsumer p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.signpost']/interface[@name='OAuthProvider']/method[@name='retrieveRequestToken' and count(parameter)=2 and parameter[1][@type='com.parse.signpost.OAuthConsumer'] and parameter[2][@type='java.lang.String']]"
		[Register ("retrieveRequestToken", "(Lcom/parse/signpost/OAuthConsumer;Ljava/lang/String;)Ljava/lang/String;", "GetRetrieveRequestToken_Lcom_parse_signpost_OAuthConsumer_Ljava_lang_String_Handler:Com.Parse.Signpost.IOAuthProviderInvoker, ParseNotificationsDroidBinding")]
		string RetrieveRequestToken (global::Com.Parse.Signpost.IOAuthConsumer p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.signpost']/interface[@name='OAuthProvider']/method[@name='setListener' and count(parameter)=1 and parameter[1][@type='com.parse.signpost.OAuthProviderListener']]"
		[Register ("setListener", "(Lcom/parse/signpost/OAuthProviderListener;)V", "GetSetListener_Lcom_parse_signpost_OAuthProviderListener_Handler:Com.Parse.Signpost.IOAuthProviderInvoker, ParseNotificationsDroidBinding")]
		void SetListener (global::Com.Parse.Signpost.IOAuthProviderListener p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.signpost']/interface[@name='OAuthProvider']/method[@name='setRequestHeader' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
[Obsolete (@"deprecated")]
		[Register ("setRequestHeader", "(Ljava/lang/String;Ljava/lang/String;)V", "GetSetRequestHeader_Ljava_lang_String_Ljava_lang_String_Handler:Com.Parse.Signpost.IOAuthProviderInvoker, ParseNotificationsDroidBinding")]
		void SetRequestHeader (string p0, string p1);

	}

	[global::Android.Runtime.Register ("com/parse/signpost/OAuthProvider", DoNotGenerateAcw=true)]
	internal class IOAuthProviderInvoker : global::Java.Lang.Object, IOAuthProvider {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/parse/signpost/OAuthProvider");
		IntPtr class_ref;

		public static IOAuthProvider GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOAuthProvider> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.parse.signpost.OAuthProvider"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOAuthProviderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IOAuthProviderInvoker); }
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
			global::Com.Parse.Signpost.IOAuthProvider __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.IOAuthProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AccessTokenEndpointUrl);
		}
#pragma warning restore 0169

		IntPtr id_getAccessTokenEndpointUrl;
		public string AccessTokenEndpointUrl {
			get {
				if (id_getAccessTokenEndpointUrl == IntPtr.Zero)
					id_getAccessTokenEndpointUrl = JNIEnv.GetMethodID (class_ref, "getAccessTokenEndpointUrl", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getAccessTokenEndpointUrl), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Parse.Signpost.IOAuthProvider __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.IOAuthProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AuthorizationWebsiteUrl);
		}
#pragma warning restore 0169

		IntPtr id_getAuthorizationWebsiteUrl;
		public string AuthorizationWebsiteUrl {
			get {
				if (id_getAuthorizationWebsiteUrl == IntPtr.Zero)
					id_getAuthorizationWebsiteUrl = JNIEnv.GetMethodID (class_ref, "getAuthorizationWebsiteUrl", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getAuthorizationWebsiteUrl), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Parse.Signpost.IOAuthProvider __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.IOAuthProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Parse.Signpost.IOAuthProvider __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.IOAuthProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OAuth10a = p0;
		}
#pragma warning restore 0169

		IntPtr id_isOAuth10a;
		IntPtr id_setOAuth10a_Z;
		public bool OAuth10a {
			get {
				if (id_isOAuth10a == IntPtr.Zero)
					id_isOAuth10a = JNIEnv.GetMethodID (class_ref, "isOAuth10a", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_isOAuth10a);
			}
			set {
				if (id_setOAuth10a_Z == IntPtr.Zero)
					id_setOAuth10a_Z = JNIEnv.GetMethodID (class_ref, "setOAuth10a", "(Z)V");
				JNIEnv.CallVoidMethod (Handle, id_setOAuth10a_Z, new JValue (value));
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
			global::Com.Parse.Signpost.IOAuthProvider __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.IOAuthProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.RequestHeaders);
		}
#pragma warning restore 0169

		IntPtr id_getRequestHeaders;
		public global::System.Collections.Generic.IDictionary<string, string> RequestHeaders {
			get {
				if (id_getRequestHeaders == IntPtr.Zero)
					id_getRequestHeaders = JNIEnv.GetMethodID (class_ref, "getRequestHeaders", "()Ljava/util/Map;");
				return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallObjectMethod (Handle, id_getRequestHeaders), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Parse.Signpost.IOAuthProvider __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.IOAuthProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RequestTokenEndpointUrl);
		}
#pragma warning restore 0169

		IntPtr id_getRequestTokenEndpointUrl;
		public string RequestTokenEndpointUrl {
			get {
				if (id_getRequestTokenEndpointUrl == IntPtr.Zero)
					id_getRequestTokenEndpointUrl = JNIEnv.GetMethodID (class_ref, "getRequestTokenEndpointUrl", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getRequestTokenEndpointUrl), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Parse.Signpost.IOAuthProvider __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.IOAuthProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Parse.Signpost.IOAuthProvider __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.IOAuthProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Parse.Signpost.Http.HttpParameters p0 = global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.Http.HttpParameters> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ResponseParameters = p0;
		}
#pragma warning restore 0169

		IntPtr id_getResponseParameters;
		IntPtr id_setResponseParameters_Lcom_parse_signpost_http_HttpParameters_;
		public global::Com.Parse.Signpost.Http.HttpParameters ResponseParameters {
			get {
				if (id_getResponseParameters == IntPtr.Zero)
					id_getResponseParameters = JNIEnv.GetMethodID (class_ref, "getResponseParameters", "()Lcom/parse/signpost/http/HttpParameters;");
				return global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.Http.HttpParameters> (JNIEnv.CallObjectMethod (Handle, id_getResponseParameters), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setResponseParameters_Lcom_parse_signpost_http_HttpParameters_ == IntPtr.Zero)
					id_setResponseParameters_Lcom_parse_signpost_http_HttpParameters_ = JNIEnv.GetMethodID (class_ref, "setResponseParameters", "(Lcom/parse/signpost/http/HttpParameters;)V");
				JNIEnv.CallVoidMethod (Handle, id_setResponseParameters_Lcom_parse_signpost_http_HttpParameters_, new JValue (value));
			}
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
			global::Com.Parse.Signpost.IOAuthProvider __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.IOAuthProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Parse.Signpost.IOAuthProviderListener p0 = (global::Com.Parse.Signpost.IOAuthProviderListener)global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.IOAuthProviderListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveListener (p0);
		}
#pragma warning restore 0169

		IntPtr id_removeListener_Lcom_parse_signpost_OAuthProviderListener_;
		public void RemoveListener (global::Com.Parse.Signpost.IOAuthProviderListener p0)
		{
			if (id_removeListener_Lcom_parse_signpost_OAuthProviderListener_ == IntPtr.Zero)
				id_removeListener_Lcom_parse_signpost_OAuthProviderListener_ = JNIEnv.GetMethodID (class_ref, "removeListener", "(Lcom/parse/signpost/OAuthProviderListener;)V");
			JNIEnv.CallVoidMethod (Handle, id_removeListener_Lcom_parse_signpost_OAuthProviderListener_, new JValue (p0));
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
			global::Com.Parse.Signpost.IOAuthProvider __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.IOAuthProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Parse.Signpost.IOAuthConsumer p0 = (global::Com.Parse.Signpost.IOAuthConsumer)global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.IOAuthConsumer> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.RetrieveAccessToken (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_retrieveAccessToken_Lcom_parse_signpost_OAuthConsumer_Ljava_lang_String_;
		public void RetrieveAccessToken (global::Com.Parse.Signpost.IOAuthConsumer p0, string p1)
		{
			if (id_retrieveAccessToken_Lcom_parse_signpost_OAuthConsumer_Ljava_lang_String_ == IntPtr.Zero)
				id_retrieveAccessToken_Lcom_parse_signpost_OAuthConsumer_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "retrieveAccessToken", "(Lcom/parse/signpost/OAuthConsumer;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallVoidMethod (Handle, id_retrieveAccessToken_Lcom_parse_signpost_OAuthConsumer_Ljava_lang_String_, new JValue (p0), new JValue (native_p1));
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
			global::Com.Parse.Signpost.IOAuthProvider __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.IOAuthProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Parse.Signpost.IOAuthConsumer p0 = (global::Com.Parse.Signpost.IOAuthConsumer)global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.IOAuthConsumer> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.RetrieveRequestToken (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_retrieveRequestToken_Lcom_parse_signpost_OAuthConsumer_Ljava_lang_String_;
		public string RetrieveRequestToken (global::Com.Parse.Signpost.IOAuthConsumer p0, string p1)
		{
			if (id_retrieveRequestToken_Lcom_parse_signpost_OAuthConsumer_Ljava_lang_String_ == IntPtr.Zero)
				id_retrieveRequestToken_Lcom_parse_signpost_OAuthConsumer_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "retrieveRequestToken", "(Lcom/parse/signpost/OAuthConsumer;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_retrieveRequestToken_Lcom_parse_signpost_OAuthConsumer_Ljava_lang_String_, new JValue (p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

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
			global::Com.Parse.Signpost.IOAuthProvider __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.IOAuthProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Parse.Signpost.IOAuthProviderListener p0 = (global::Com.Parse.Signpost.IOAuthProviderListener)global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.IOAuthProviderListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetListener (p0);
		}
#pragma warning restore 0169

		IntPtr id_setListener_Lcom_parse_signpost_OAuthProviderListener_;
		public void SetListener (global::Com.Parse.Signpost.IOAuthProviderListener p0)
		{
			if (id_setListener_Lcom_parse_signpost_OAuthProviderListener_ == IntPtr.Zero)
				id_setListener_Lcom_parse_signpost_OAuthProviderListener_ = JNIEnv.GetMethodID (class_ref, "setListener", "(Lcom/parse/signpost/OAuthProviderListener;)V");
			JNIEnv.CallVoidMethod (Handle, id_setListener_Lcom_parse_signpost_OAuthProviderListener_, new JValue (p0));
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
			global::Com.Parse.Signpost.IOAuthProvider __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.IOAuthProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetRequestHeader (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_setRequestHeader_Ljava_lang_String_Ljava_lang_String_;
		public void SetRequestHeader (string p0, string p1)
		{
			if (id_setRequestHeader_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_setRequestHeader_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setRequestHeader", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallVoidMethod (Handle, id_setRequestHeader_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

	}

}
