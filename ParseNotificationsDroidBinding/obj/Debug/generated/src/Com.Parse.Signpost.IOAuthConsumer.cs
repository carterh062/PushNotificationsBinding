using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Parse.Signpost {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.parse.signpost']/interface[@name='OAuthConsumer']"
	[Register ("com/parse/signpost/OAuthConsumer", "", "Com.Parse.Signpost.IOAuthConsumerInvoker")]
	public partial interface IOAuthConsumer : global::Java.IO.ISerializable {

		string ConsumerKey {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.signpost']/interface[@name='OAuthConsumer']/method[@name='getConsumerKey' and count(parameter)=0]"
			[Register ("getConsumerKey", "()Ljava/lang/String;", "GetGetConsumerKeyHandler:Com.Parse.Signpost.IOAuthConsumerInvoker, ParseNotificationsDroidBinding")] get;
		}

		string ConsumerSecret {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.signpost']/interface[@name='OAuthConsumer']/method[@name='getConsumerSecret' and count(parameter)=0]"
			[Register ("getConsumerSecret", "()Ljava/lang/String;", "GetGetConsumerSecretHandler:Com.Parse.Signpost.IOAuthConsumerInvoker, ParseNotificationsDroidBinding")] get;
		}

		global::Com.Parse.Signpost.Http.HttpParameters RequestParameters {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.signpost']/interface[@name='OAuthConsumer']/method[@name='getRequestParameters' and count(parameter)=0]"
			[Register ("getRequestParameters", "()Lcom/parse/signpost/http/HttpParameters;", "GetGetRequestParametersHandler:Com.Parse.Signpost.IOAuthConsumerInvoker, ParseNotificationsDroidBinding")] get;
		}

		string Token {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.signpost']/interface[@name='OAuthConsumer']/method[@name='getToken' and count(parameter)=0]"
			[Register ("getToken", "()Ljava/lang/String;", "GetGetTokenHandler:Com.Parse.Signpost.IOAuthConsumerInvoker, ParseNotificationsDroidBinding")] get;
		}

		string TokenSecret {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.signpost']/interface[@name='OAuthConsumer']/method[@name='getTokenSecret' and count(parameter)=0]"
			[Register ("getTokenSecret", "()Ljava/lang/String;", "GetGetTokenSecretHandler:Com.Parse.Signpost.IOAuthConsumerInvoker, ParseNotificationsDroidBinding")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.signpost']/interface[@name='OAuthConsumer']/method[@name='setAdditionalParameters' and count(parameter)=1 and parameter[1][@type='com.parse.signpost.http.HttpParameters']]"
		[Register ("setAdditionalParameters", "(Lcom/parse/signpost/http/HttpParameters;)V", "GetSetAdditionalParameters_Lcom_parse_signpost_http_HttpParameters_Handler:Com.Parse.Signpost.IOAuthConsumerInvoker, ParseNotificationsDroidBinding")]
		void SetAdditionalParameters (global::Com.Parse.Signpost.Http.HttpParameters p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.signpost']/interface[@name='OAuthConsumer']/method[@name='setMessageSigner' and count(parameter)=1 and parameter[1][@type='com.parse.signpost.signature.OAuthMessageSigner']]"
		[Register ("setMessageSigner", "(Lcom/parse/signpost/signature/OAuthMessageSigner;)V", "GetSetMessageSigner_Lcom_parse_signpost_signature_OAuthMessageSigner_Handler:Com.Parse.Signpost.IOAuthConsumerInvoker, ParseNotificationsDroidBinding")]
		void SetMessageSigner (global::Com.Parse.Signpost.Signature.OAuthMessageSigner p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.signpost']/interface[@name='OAuthConsumer']/method[@name='setSendEmptyTokens' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setSendEmptyTokens", "(Z)V", "GetSetSendEmptyTokens_ZHandler:Com.Parse.Signpost.IOAuthConsumerInvoker, ParseNotificationsDroidBinding")]
		void SetSendEmptyTokens (bool p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.signpost']/interface[@name='OAuthConsumer']/method[@name='setSigningStrategy' and count(parameter)=1 and parameter[1][@type='com.parse.signpost.signature.SigningStrategy']]"
		[Register ("setSigningStrategy", "(Lcom/parse/signpost/signature/SigningStrategy;)V", "GetSetSigningStrategy_Lcom_parse_signpost_signature_SigningStrategy_Handler:Com.Parse.Signpost.IOAuthConsumerInvoker, ParseNotificationsDroidBinding")]
		void SetSigningStrategy (global::Com.Parse.Signpost.Signature.ISigningStrategy p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.signpost']/interface[@name='OAuthConsumer']/method[@name='setTokenWithSecret' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("setTokenWithSecret", "(Ljava/lang/String;Ljava/lang/String;)V", "GetSetTokenWithSecret_Ljava_lang_String_Ljava_lang_String_Handler:Com.Parse.Signpost.IOAuthConsumerInvoker, ParseNotificationsDroidBinding")]
		void SetTokenWithSecret (string p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.signpost']/interface[@name='OAuthConsumer']/method[@name='sign' and count(parameter)=1 and parameter[1][@type='com.parse.signpost.http.HttpRequest']]"
		[Register ("sign", "(Lcom/parse/signpost/http/HttpRequest;)Lcom/parse/signpost/http/HttpRequest;", "GetSign_Lcom_parse_signpost_http_HttpRequest_Handler:Com.Parse.Signpost.IOAuthConsumerInvoker, ParseNotificationsDroidBinding")]
		global::Com.Parse.Signpost.Http.IHttpRequest Sign (global::Com.Parse.Signpost.Http.IHttpRequest p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.signpost']/interface[@name='OAuthConsumer']/method[@name='sign' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("sign", "(Ljava/lang/Object;)Lcom/parse/signpost/http/HttpRequest;", "GetSign_Ljava_lang_Object_Handler:Com.Parse.Signpost.IOAuthConsumerInvoker, ParseNotificationsDroidBinding")]
		global::Com.Parse.Signpost.Http.IHttpRequest Sign (global::Java.Lang.Object p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.signpost']/interface[@name='OAuthConsumer']/method[@name='sign' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("sign", "(Ljava/lang/String;)Ljava/lang/String;", "GetSign_Ljava_lang_String_Handler:Com.Parse.Signpost.IOAuthConsumerInvoker, ParseNotificationsDroidBinding")]
		string Sign (string p0);

	}

	[global::Android.Runtime.Register ("com/parse/signpost/OAuthConsumer", DoNotGenerateAcw=true)]
	internal class IOAuthConsumerInvoker : global::Java.Lang.Object, IOAuthConsumer {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/parse/signpost/OAuthConsumer");
		IntPtr class_ref;

		public static IOAuthConsumer GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOAuthConsumer> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.parse.signpost.OAuthConsumer"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOAuthConsumerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IOAuthConsumerInvoker); }
		}

		static Delegate cb_getConsumerKey;
#pragma warning disable 0169
		static Delegate GetGetConsumerKeyHandler ()
		{
			if (cb_getConsumerKey == null)
				cb_getConsumerKey = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetConsumerKey);
			return cb_getConsumerKey;
		}

		static IntPtr n_GetConsumerKey (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.Signpost.IOAuthConsumer __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.IOAuthConsumer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ConsumerKey);
		}
#pragma warning restore 0169

		IntPtr id_getConsumerKey;
		public string ConsumerKey {
			get {
				if (id_getConsumerKey == IntPtr.Zero)
					id_getConsumerKey = JNIEnv.GetMethodID (class_ref, "getConsumerKey", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getConsumerKey), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getConsumerSecret;
#pragma warning disable 0169
		static Delegate GetGetConsumerSecretHandler ()
		{
			if (cb_getConsumerSecret == null)
				cb_getConsumerSecret = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetConsumerSecret);
			return cb_getConsumerSecret;
		}

		static IntPtr n_GetConsumerSecret (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.Signpost.IOAuthConsumer __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.IOAuthConsumer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ConsumerSecret);
		}
#pragma warning restore 0169

		IntPtr id_getConsumerSecret;
		public string ConsumerSecret {
			get {
				if (id_getConsumerSecret == IntPtr.Zero)
					id_getConsumerSecret = JNIEnv.GetMethodID (class_ref, "getConsumerSecret", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getConsumerSecret), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getRequestParameters;
#pragma warning disable 0169
		static Delegate GetGetRequestParametersHandler ()
		{
			if (cb_getRequestParameters == null)
				cb_getRequestParameters = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRequestParameters);
			return cb_getRequestParameters;
		}

		static IntPtr n_GetRequestParameters (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.Signpost.IOAuthConsumer __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.IOAuthConsumer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RequestParameters);
		}
#pragma warning restore 0169

		IntPtr id_getRequestParameters;
		public global::Com.Parse.Signpost.Http.HttpParameters RequestParameters {
			get {
				if (id_getRequestParameters == IntPtr.Zero)
					id_getRequestParameters = JNIEnv.GetMethodID (class_ref, "getRequestParameters", "()Lcom/parse/signpost/http/HttpParameters;");
				return global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.Http.HttpParameters> (JNIEnv.CallObjectMethod (Handle, id_getRequestParameters), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getToken;
#pragma warning disable 0169
		static Delegate GetGetTokenHandler ()
		{
			if (cb_getToken == null)
				cb_getToken = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetToken);
			return cb_getToken;
		}

		static IntPtr n_GetToken (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.Signpost.IOAuthConsumer __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.IOAuthConsumer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Token);
		}
#pragma warning restore 0169

		IntPtr id_getToken;
		public string Token {
			get {
				if (id_getToken == IntPtr.Zero)
					id_getToken = JNIEnv.GetMethodID (class_ref, "getToken", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getToken), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getTokenSecret;
#pragma warning disable 0169
		static Delegate GetGetTokenSecretHandler ()
		{
			if (cb_getTokenSecret == null)
				cb_getTokenSecret = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTokenSecret);
			return cb_getTokenSecret;
		}

		static IntPtr n_GetTokenSecret (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.Signpost.IOAuthConsumer __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.IOAuthConsumer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TokenSecret);
		}
#pragma warning restore 0169

		IntPtr id_getTokenSecret;
		public string TokenSecret {
			get {
				if (id_getTokenSecret == IntPtr.Zero)
					id_getTokenSecret = JNIEnv.GetMethodID (class_ref, "getTokenSecret", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getTokenSecret), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_setAdditionalParameters_Lcom_parse_signpost_http_HttpParameters_;
#pragma warning disable 0169
		static Delegate GetSetAdditionalParameters_Lcom_parse_signpost_http_HttpParameters_Handler ()
		{
			if (cb_setAdditionalParameters_Lcom_parse_signpost_http_HttpParameters_ == null)
				cb_setAdditionalParameters_Lcom_parse_signpost_http_HttpParameters_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAdditionalParameters_Lcom_parse_signpost_http_HttpParameters_);
			return cb_setAdditionalParameters_Lcom_parse_signpost_http_HttpParameters_;
		}

		static void n_SetAdditionalParameters_Lcom_parse_signpost_http_HttpParameters_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.Signpost.IOAuthConsumer __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.IOAuthConsumer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Parse.Signpost.Http.HttpParameters p0 = global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.Http.HttpParameters> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetAdditionalParameters (p0);
		}
#pragma warning restore 0169

		IntPtr id_setAdditionalParameters_Lcom_parse_signpost_http_HttpParameters_;
		public void SetAdditionalParameters (global::Com.Parse.Signpost.Http.HttpParameters p0)
		{
			if (id_setAdditionalParameters_Lcom_parse_signpost_http_HttpParameters_ == IntPtr.Zero)
				id_setAdditionalParameters_Lcom_parse_signpost_http_HttpParameters_ = JNIEnv.GetMethodID (class_ref, "setAdditionalParameters", "(Lcom/parse/signpost/http/HttpParameters;)V");
			JNIEnv.CallVoidMethod (Handle, id_setAdditionalParameters_Lcom_parse_signpost_http_HttpParameters_, new JValue (p0));
		}

		static Delegate cb_setMessageSigner_Lcom_parse_signpost_signature_OAuthMessageSigner_;
#pragma warning disable 0169
		static Delegate GetSetMessageSigner_Lcom_parse_signpost_signature_OAuthMessageSigner_Handler ()
		{
			if (cb_setMessageSigner_Lcom_parse_signpost_signature_OAuthMessageSigner_ == null)
				cb_setMessageSigner_Lcom_parse_signpost_signature_OAuthMessageSigner_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMessageSigner_Lcom_parse_signpost_signature_OAuthMessageSigner_);
			return cb_setMessageSigner_Lcom_parse_signpost_signature_OAuthMessageSigner_;
		}

		static void n_SetMessageSigner_Lcom_parse_signpost_signature_OAuthMessageSigner_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.Signpost.IOAuthConsumer __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.IOAuthConsumer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Parse.Signpost.Signature.OAuthMessageSigner p0 = global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.Signature.OAuthMessageSigner> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetMessageSigner (p0);
		}
#pragma warning restore 0169

		IntPtr id_setMessageSigner_Lcom_parse_signpost_signature_OAuthMessageSigner_;
		public void SetMessageSigner (global::Com.Parse.Signpost.Signature.OAuthMessageSigner p0)
		{
			if (id_setMessageSigner_Lcom_parse_signpost_signature_OAuthMessageSigner_ == IntPtr.Zero)
				id_setMessageSigner_Lcom_parse_signpost_signature_OAuthMessageSigner_ = JNIEnv.GetMethodID (class_ref, "setMessageSigner", "(Lcom/parse/signpost/signature/OAuthMessageSigner;)V");
			JNIEnv.CallVoidMethod (Handle, id_setMessageSigner_Lcom_parse_signpost_signature_OAuthMessageSigner_, new JValue (p0));
		}

		static Delegate cb_setSendEmptyTokens_Z;
#pragma warning disable 0169
		static Delegate GetSetSendEmptyTokens_ZHandler ()
		{
			if (cb_setSendEmptyTokens_Z == null)
				cb_setSendEmptyTokens_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetSendEmptyTokens_Z);
			return cb_setSendEmptyTokens_Z;
		}

		static void n_SetSendEmptyTokens_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Parse.Signpost.IOAuthConsumer __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.IOAuthConsumer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetSendEmptyTokens (p0);
		}
#pragma warning restore 0169

		IntPtr id_setSendEmptyTokens_Z;
		public void SetSendEmptyTokens (bool p0)
		{
			if (id_setSendEmptyTokens_Z == IntPtr.Zero)
				id_setSendEmptyTokens_Z = JNIEnv.GetMethodID (class_ref, "setSendEmptyTokens", "(Z)V");
			JNIEnv.CallVoidMethod (Handle, id_setSendEmptyTokens_Z, new JValue (p0));
		}

		static Delegate cb_setSigningStrategy_Lcom_parse_signpost_signature_SigningStrategy_;
#pragma warning disable 0169
		static Delegate GetSetSigningStrategy_Lcom_parse_signpost_signature_SigningStrategy_Handler ()
		{
			if (cb_setSigningStrategy_Lcom_parse_signpost_signature_SigningStrategy_ == null)
				cb_setSigningStrategy_Lcom_parse_signpost_signature_SigningStrategy_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSigningStrategy_Lcom_parse_signpost_signature_SigningStrategy_);
			return cb_setSigningStrategy_Lcom_parse_signpost_signature_SigningStrategy_;
		}

		static void n_SetSigningStrategy_Lcom_parse_signpost_signature_SigningStrategy_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.Signpost.IOAuthConsumer __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.IOAuthConsumer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Parse.Signpost.Signature.ISigningStrategy p0 = (global::Com.Parse.Signpost.Signature.ISigningStrategy)global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.Signature.ISigningStrategy> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetSigningStrategy (p0);
		}
#pragma warning restore 0169

		IntPtr id_setSigningStrategy_Lcom_parse_signpost_signature_SigningStrategy_;
		public void SetSigningStrategy (global::Com.Parse.Signpost.Signature.ISigningStrategy p0)
		{
			if (id_setSigningStrategy_Lcom_parse_signpost_signature_SigningStrategy_ == IntPtr.Zero)
				id_setSigningStrategy_Lcom_parse_signpost_signature_SigningStrategy_ = JNIEnv.GetMethodID (class_ref, "setSigningStrategy", "(Lcom/parse/signpost/signature/SigningStrategy;)V");
			JNIEnv.CallVoidMethod (Handle, id_setSigningStrategy_Lcom_parse_signpost_signature_SigningStrategy_, new JValue (p0));
		}

		static Delegate cb_setTokenWithSecret_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTokenWithSecret_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_setTokenWithSecret_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_setTokenWithSecret_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetTokenWithSecret_Ljava_lang_String_Ljava_lang_String_);
			return cb_setTokenWithSecret_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_SetTokenWithSecret_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Parse.Signpost.IOAuthConsumer __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.IOAuthConsumer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetTokenWithSecret (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_setTokenWithSecret_Ljava_lang_String_Ljava_lang_String_;
		public void SetTokenWithSecret (string p0, string p1)
		{
			if (id_setTokenWithSecret_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_setTokenWithSecret_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTokenWithSecret", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallVoidMethod (Handle, id_setTokenWithSecret_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_sign_Lcom_parse_signpost_http_HttpRequest_;
#pragma warning disable 0169
		static Delegate GetSign_Lcom_parse_signpost_http_HttpRequest_Handler ()
		{
			if (cb_sign_Lcom_parse_signpost_http_HttpRequest_ == null)
				cb_sign_Lcom_parse_signpost_http_HttpRequest_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Sign_Lcom_parse_signpost_http_HttpRequest_);
			return cb_sign_Lcom_parse_signpost_http_HttpRequest_;
		}

		static IntPtr n_Sign_Lcom_parse_signpost_http_HttpRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.Signpost.IOAuthConsumer __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.IOAuthConsumer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Parse.Signpost.Http.IHttpRequest p0 = (global::Com.Parse.Signpost.Http.IHttpRequest)global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.Http.IHttpRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Sign (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_sign_Lcom_parse_signpost_http_HttpRequest_;
		public global::Com.Parse.Signpost.Http.IHttpRequest Sign (global::Com.Parse.Signpost.Http.IHttpRequest p0)
		{
			if (id_sign_Lcom_parse_signpost_http_HttpRequest_ == IntPtr.Zero)
				id_sign_Lcom_parse_signpost_http_HttpRequest_ = JNIEnv.GetMethodID (class_ref, "sign", "(Lcom/parse/signpost/http/HttpRequest;)Lcom/parse/signpost/http/HttpRequest;");
			global::Com.Parse.Signpost.Http.IHttpRequest __ret = global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.Http.IHttpRequest> (JNIEnv.CallObjectMethod (Handle, id_sign_Lcom_parse_signpost_http_HttpRequest_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_sign_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetSign_Ljava_lang_Object_Handler ()
		{
			if (cb_sign_Ljava_lang_Object_ == null)
				cb_sign_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Sign_Ljava_lang_Object_);
			return cb_sign_Ljava_lang_Object_;
		}

		static IntPtr n_Sign_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.Signpost.IOAuthConsumer __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.IOAuthConsumer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Sign (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_sign_Ljava_lang_Object_;
		public global::Com.Parse.Signpost.Http.IHttpRequest Sign (global::Java.Lang.Object p0)
		{
			if (id_sign_Ljava_lang_Object_ == IntPtr.Zero)
				id_sign_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "sign", "(Ljava/lang/Object;)Lcom/parse/signpost/http/HttpRequest;");
			global::Com.Parse.Signpost.Http.IHttpRequest __ret = global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.Http.IHttpRequest> (JNIEnv.CallObjectMethod (Handle, id_sign_Ljava_lang_Object_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_sign_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSign_Ljava_lang_String_Handler ()
		{
			if (cb_sign_Ljava_lang_String_ == null)
				cb_sign_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Sign_Ljava_lang_String_);
			return cb_sign_Ljava_lang_String_;
		}

		static IntPtr n_Sign_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.Signpost.IOAuthConsumer __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.IOAuthConsumer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Sign (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_sign_Ljava_lang_String_;
		public string Sign (string p0)
		{
			if (id_sign_Ljava_lang_String_ == IntPtr.Zero)
				id_sign_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "sign", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_sign_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}

}
