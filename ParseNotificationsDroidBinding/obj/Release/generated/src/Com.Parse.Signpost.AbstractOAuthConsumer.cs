using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Parse.Signpost {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.parse.signpost']/class[@name='AbstractOAuthConsumer']"
	[global::Android.Runtime.Register ("com/parse/signpost/AbstractOAuthConsumer", DoNotGenerateAcw=true)]
	public abstract partial class AbstractOAuthConsumer : global::Java.Lang.Object, global::Com.Parse.Signpost.IOAuthConsumer {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/parse/signpost/AbstractOAuthConsumer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AbstractOAuthConsumer); }
		}

		protected AbstractOAuthConsumer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.parse.signpost']/class[@name='AbstractOAuthConsumer']/constructor[@name='AbstractOAuthConsumer' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public AbstractOAuthConsumer (string p0, string p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);;
			IntPtr native_p1 = JNIEnv.NewString (p1);;
			if (GetType () != typeof (AbstractOAuthConsumer)) {
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
			global::Com.Parse.Signpost.AbstractOAuthConsumer __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.AbstractOAuthConsumer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ConsumerKey);
		}
#pragma warning restore 0169

		static IntPtr id_getConsumerKey;
		public virtual string ConsumerKey {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.signpost']/class[@name='AbstractOAuthConsumer']/method[@name='getConsumerKey' and count(parameter)=0]"
			[Register ("getConsumerKey", "()Ljava/lang/String;", "GetGetConsumerKeyHandler")]
			get {
				if (id_getConsumerKey == IntPtr.Zero)
					id_getConsumerKey = JNIEnv.GetMethodID (class_ref, "getConsumerKey", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getConsumerKey), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getConsumerKey", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Parse.Signpost.AbstractOAuthConsumer __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.AbstractOAuthConsumer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ConsumerSecret);
		}
#pragma warning restore 0169

		static IntPtr id_getConsumerSecret;
		public virtual string ConsumerSecret {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.signpost']/class[@name='AbstractOAuthConsumer']/method[@name='getConsumerSecret' and count(parameter)=0]"
			[Register ("getConsumerSecret", "()Ljava/lang/String;", "GetGetConsumerSecretHandler")]
			get {
				if (id_getConsumerSecret == IntPtr.Zero)
					id_getConsumerSecret = JNIEnv.GetMethodID (class_ref, "getConsumerSecret", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getConsumerSecret), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getConsumerSecret", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Parse.Signpost.AbstractOAuthConsumer __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.AbstractOAuthConsumer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RequestParameters);
		}
#pragma warning restore 0169

		static IntPtr id_getRequestParameters;
		public virtual global::Com.Parse.Signpost.Http.HttpParameters RequestParameters {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.signpost']/class[@name='AbstractOAuthConsumer']/method[@name='getRequestParameters' and count(parameter)=0]"
			[Register ("getRequestParameters", "()Lcom/parse/signpost/http/HttpParameters;", "GetGetRequestParametersHandler")]
			get {
				if (id_getRequestParameters == IntPtr.Zero)
					id_getRequestParameters = JNIEnv.GetMethodID (class_ref, "getRequestParameters", "()Lcom/parse/signpost/http/HttpParameters;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.Http.HttpParameters> (JNIEnv.CallObjectMethod  (Handle, id_getRequestParameters), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.Http.HttpParameters> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRequestParameters", "()Lcom/parse/signpost/http/HttpParameters;")), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Parse.Signpost.AbstractOAuthConsumer __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.AbstractOAuthConsumer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Token);
		}
#pragma warning restore 0169

		static IntPtr id_getToken;
		public virtual string Token {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.signpost']/class[@name='AbstractOAuthConsumer']/method[@name='getToken' and count(parameter)=0]"
			[Register ("getToken", "()Ljava/lang/String;", "GetGetTokenHandler")]
			get {
				if (id_getToken == IntPtr.Zero)
					id_getToken = JNIEnv.GetMethodID (class_ref, "getToken", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getToken), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getToken", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Parse.Signpost.AbstractOAuthConsumer __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.AbstractOAuthConsumer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TokenSecret);
		}
#pragma warning restore 0169

		static IntPtr id_getTokenSecret;
		public virtual string TokenSecret {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.signpost']/class[@name='AbstractOAuthConsumer']/method[@name='getTokenSecret' and count(parameter)=0]"
			[Register ("getTokenSecret", "()Ljava/lang/String;", "GetGetTokenSecretHandler")]
			get {
				if (id_getTokenSecret == IntPtr.Zero)
					id_getTokenSecret = JNIEnv.GetMethodID (class_ref, "getTokenSecret", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getTokenSecret), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTokenSecret", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_collectBodyParameters_Lcom_parse_signpost_http_HttpRequest_Lcom_parse_signpost_http_HttpParameters_;
#pragma warning disable 0169
		static Delegate GetCollectBodyParameters_Lcom_parse_signpost_http_HttpRequest_Lcom_parse_signpost_http_HttpParameters_Handler ()
		{
			if (cb_collectBodyParameters_Lcom_parse_signpost_http_HttpRequest_Lcom_parse_signpost_http_HttpParameters_ == null)
				cb_collectBodyParameters_Lcom_parse_signpost_http_HttpRequest_Lcom_parse_signpost_http_HttpParameters_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_CollectBodyParameters_Lcom_parse_signpost_http_HttpRequest_Lcom_parse_signpost_http_HttpParameters_);
			return cb_collectBodyParameters_Lcom_parse_signpost_http_HttpRequest_Lcom_parse_signpost_http_HttpParameters_;
		}

		static void n_CollectBodyParameters_Lcom_parse_signpost_http_HttpRequest_Lcom_parse_signpost_http_HttpParameters_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Parse.Signpost.AbstractOAuthConsumer __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.AbstractOAuthConsumer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Parse.Signpost.Http.IHttpRequest p0 = (global::Com.Parse.Signpost.Http.IHttpRequest)global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.Http.IHttpRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Parse.Signpost.Http.HttpParameters p1 = global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.Http.HttpParameters> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.CollectBodyParameters (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_collectBodyParameters_Lcom_parse_signpost_http_HttpRequest_Lcom_parse_signpost_http_HttpParameters_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.signpost']/class[@name='AbstractOAuthConsumer']/method[@name='collectBodyParameters' and count(parameter)=2 and parameter[1][@type='com.parse.signpost.http.HttpRequest'] and parameter[2][@type='com.parse.signpost.http.HttpParameters']]"
		[Register ("collectBodyParameters", "(Lcom/parse/signpost/http/HttpRequest;Lcom/parse/signpost/http/HttpParameters;)V", "GetCollectBodyParameters_Lcom_parse_signpost_http_HttpRequest_Lcom_parse_signpost_http_HttpParameters_Handler")]
		protected virtual void CollectBodyParameters (global::Com.Parse.Signpost.Http.IHttpRequest p0, global::Com.Parse.Signpost.Http.HttpParameters p1)
		{
			if (id_collectBodyParameters_Lcom_parse_signpost_http_HttpRequest_Lcom_parse_signpost_http_HttpParameters_ == IntPtr.Zero)
				id_collectBodyParameters_Lcom_parse_signpost_http_HttpRequest_Lcom_parse_signpost_http_HttpParameters_ = JNIEnv.GetMethodID (class_ref, "collectBodyParameters", "(Lcom/parse/signpost/http/HttpRequest;Lcom/parse/signpost/http/HttpParameters;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_collectBodyParameters_Lcom_parse_signpost_http_HttpRequest_Lcom_parse_signpost_http_HttpParameters_, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "collectBodyParameters", "(Lcom/parse/signpost/http/HttpRequest;Lcom/parse/signpost/http/HttpParameters;)V"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_collectHeaderParameters_Lcom_parse_signpost_http_HttpRequest_Lcom_parse_signpost_http_HttpParameters_;
#pragma warning disable 0169
		static Delegate GetCollectHeaderParameters_Lcom_parse_signpost_http_HttpRequest_Lcom_parse_signpost_http_HttpParameters_Handler ()
		{
			if (cb_collectHeaderParameters_Lcom_parse_signpost_http_HttpRequest_Lcom_parse_signpost_http_HttpParameters_ == null)
				cb_collectHeaderParameters_Lcom_parse_signpost_http_HttpRequest_Lcom_parse_signpost_http_HttpParameters_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_CollectHeaderParameters_Lcom_parse_signpost_http_HttpRequest_Lcom_parse_signpost_http_HttpParameters_);
			return cb_collectHeaderParameters_Lcom_parse_signpost_http_HttpRequest_Lcom_parse_signpost_http_HttpParameters_;
		}

		static void n_CollectHeaderParameters_Lcom_parse_signpost_http_HttpRequest_Lcom_parse_signpost_http_HttpParameters_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Parse.Signpost.AbstractOAuthConsumer __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.AbstractOAuthConsumer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Parse.Signpost.Http.IHttpRequest p0 = (global::Com.Parse.Signpost.Http.IHttpRequest)global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.Http.IHttpRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Parse.Signpost.Http.HttpParameters p1 = global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.Http.HttpParameters> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.CollectHeaderParameters (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_collectHeaderParameters_Lcom_parse_signpost_http_HttpRequest_Lcom_parse_signpost_http_HttpParameters_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.signpost']/class[@name='AbstractOAuthConsumer']/method[@name='collectHeaderParameters' and count(parameter)=2 and parameter[1][@type='com.parse.signpost.http.HttpRequest'] and parameter[2][@type='com.parse.signpost.http.HttpParameters']]"
		[Register ("collectHeaderParameters", "(Lcom/parse/signpost/http/HttpRequest;Lcom/parse/signpost/http/HttpParameters;)V", "GetCollectHeaderParameters_Lcom_parse_signpost_http_HttpRequest_Lcom_parse_signpost_http_HttpParameters_Handler")]
		protected virtual void CollectHeaderParameters (global::Com.Parse.Signpost.Http.IHttpRequest p0, global::Com.Parse.Signpost.Http.HttpParameters p1)
		{
			if (id_collectHeaderParameters_Lcom_parse_signpost_http_HttpRequest_Lcom_parse_signpost_http_HttpParameters_ == IntPtr.Zero)
				id_collectHeaderParameters_Lcom_parse_signpost_http_HttpRequest_Lcom_parse_signpost_http_HttpParameters_ = JNIEnv.GetMethodID (class_ref, "collectHeaderParameters", "(Lcom/parse/signpost/http/HttpRequest;Lcom/parse/signpost/http/HttpParameters;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_collectHeaderParameters_Lcom_parse_signpost_http_HttpRequest_Lcom_parse_signpost_http_HttpParameters_, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "collectHeaderParameters", "(Lcom/parse/signpost/http/HttpRequest;Lcom/parse/signpost/http/HttpParameters;)V"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_collectQueryParameters_Lcom_parse_signpost_http_HttpRequest_Lcom_parse_signpost_http_HttpParameters_;
#pragma warning disable 0169
		static Delegate GetCollectQueryParameters_Lcom_parse_signpost_http_HttpRequest_Lcom_parse_signpost_http_HttpParameters_Handler ()
		{
			if (cb_collectQueryParameters_Lcom_parse_signpost_http_HttpRequest_Lcom_parse_signpost_http_HttpParameters_ == null)
				cb_collectQueryParameters_Lcom_parse_signpost_http_HttpRequest_Lcom_parse_signpost_http_HttpParameters_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_CollectQueryParameters_Lcom_parse_signpost_http_HttpRequest_Lcom_parse_signpost_http_HttpParameters_);
			return cb_collectQueryParameters_Lcom_parse_signpost_http_HttpRequest_Lcom_parse_signpost_http_HttpParameters_;
		}

		static void n_CollectQueryParameters_Lcom_parse_signpost_http_HttpRequest_Lcom_parse_signpost_http_HttpParameters_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Parse.Signpost.AbstractOAuthConsumer __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.AbstractOAuthConsumer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Parse.Signpost.Http.IHttpRequest p0 = (global::Com.Parse.Signpost.Http.IHttpRequest)global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.Http.IHttpRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Parse.Signpost.Http.HttpParameters p1 = global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.Http.HttpParameters> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.CollectQueryParameters (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_collectQueryParameters_Lcom_parse_signpost_http_HttpRequest_Lcom_parse_signpost_http_HttpParameters_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.signpost']/class[@name='AbstractOAuthConsumer']/method[@name='collectQueryParameters' and count(parameter)=2 and parameter[1][@type='com.parse.signpost.http.HttpRequest'] and parameter[2][@type='com.parse.signpost.http.HttpParameters']]"
		[Register ("collectQueryParameters", "(Lcom/parse/signpost/http/HttpRequest;Lcom/parse/signpost/http/HttpParameters;)V", "GetCollectQueryParameters_Lcom_parse_signpost_http_HttpRequest_Lcom_parse_signpost_http_HttpParameters_Handler")]
		protected virtual void CollectQueryParameters (global::Com.Parse.Signpost.Http.IHttpRequest p0, global::Com.Parse.Signpost.Http.HttpParameters p1)
		{
			if (id_collectQueryParameters_Lcom_parse_signpost_http_HttpRequest_Lcom_parse_signpost_http_HttpParameters_ == IntPtr.Zero)
				id_collectQueryParameters_Lcom_parse_signpost_http_HttpRequest_Lcom_parse_signpost_http_HttpParameters_ = JNIEnv.GetMethodID (class_ref, "collectQueryParameters", "(Lcom/parse/signpost/http/HttpRequest;Lcom/parse/signpost/http/HttpParameters;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_collectQueryParameters_Lcom_parse_signpost_http_HttpRequest_Lcom_parse_signpost_http_HttpParameters_, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "collectQueryParameters", "(Lcom/parse/signpost/http/HttpRequest;Lcom/parse/signpost/http/HttpParameters;)V"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_completeOAuthParameters_Lcom_parse_signpost_http_HttpParameters_;
#pragma warning disable 0169
		static Delegate GetCompleteOAuthParameters_Lcom_parse_signpost_http_HttpParameters_Handler ()
		{
			if (cb_completeOAuthParameters_Lcom_parse_signpost_http_HttpParameters_ == null)
				cb_completeOAuthParameters_Lcom_parse_signpost_http_HttpParameters_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_CompleteOAuthParameters_Lcom_parse_signpost_http_HttpParameters_);
			return cb_completeOAuthParameters_Lcom_parse_signpost_http_HttpParameters_;
		}

		static void n_CompleteOAuthParameters_Lcom_parse_signpost_http_HttpParameters_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.Signpost.AbstractOAuthConsumer __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.AbstractOAuthConsumer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Parse.Signpost.Http.HttpParameters p0 = global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.Http.HttpParameters> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CompleteOAuthParameters (p0);
		}
#pragma warning restore 0169

		static IntPtr id_completeOAuthParameters_Lcom_parse_signpost_http_HttpParameters_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.signpost']/class[@name='AbstractOAuthConsumer']/method[@name='completeOAuthParameters' and count(parameter)=1 and parameter[1][@type='com.parse.signpost.http.HttpParameters']]"
		[Register ("completeOAuthParameters", "(Lcom/parse/signpost/http/HttpParameters;)V", "GetCompleteOAuthParameters_Lcom_parse_signpost_http_HttpParameters_Handler")]
		protected virtual void CompleteOAuthParameters (global::Com.Parse.Signpost.Http.HttpParameters p0)
		{
			if (id_completeOAuthParameters_Lcom_parse_signpost_http_HttpParameters_ == IntPtr.Zero)
				id_completeOAuthParameters_Lcom_parse_signpost_http_HttpParameters_ = JNIEnv.GetMethodID (class_ref, "completeOAuthParameters", "(Lcom/parse/signpost/http/HttpParameters;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_completeOAuthParameters_Lcom_parse_signpost_http_HttpParameters_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "completeOAuthParameters", "(Lcom/parse/signpost/http/HttpParameters;)V"), new JValue (p0));
		}

		static Delegate cb_generateNonce;
#pragma warning disable 0169
		static Delegate GetGenerateNonceHandler ()
		{
			if (cb_generateNonce == null)
				cb_generateNonce = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GenerateNonce);
			return cb_generateNonce;
		}

		static IntPtr n_GenerateNonce (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.Signpost.AbstractOAuthConsumer __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.AbstractOAuthConsumer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GenerateNonce ());
		}
#pragma warning restore 0169

		static IntPtr id_generateNonce;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.signpost']/class[@name='AbstractOAuthConsumer']/method[@name='generateNonce' and count(parameter)=0]"
		[Register ("generateNonce", "()Ljava/lang/String;", "GetGenerateNonceHandler")]
		protected virtual string GenerateNonce ()
		{
			if (id_generateNonce == IntPtr.Zero)
				id_generateNonce = JNIEnv.GetMethodID (class_ref, "generateNonce", "()Ljava/lang/String;");

			if (GetType () == ThresholdType)
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_generateNonce), JniHandleOwnership.TransferLocalRef);
			else
				return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "generateNonce", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_generateTimestamp;
#pragma warning disable 0169
		static Delegate GetGenerateTimestampHandler ()
		{
			if (cb_generateTimestamp == null)
				cb_generateTimestamp = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GenerateTimestamp);
			return cb_generateTimestamp;
		}

		static IntPtr n_GenerateTimestamp (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.Signpost.AbstractOAuthConsumer __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.AbstractOAuthConsumer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GenerateTimestamp ());
		}
#pragma warning restore 0169

		static IntPtr id_generateTimestamp;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.signpost']/class[@name='AbstractOAuthConsumer']/method[@name='generateTimestamp' and count(parameter)=0]"
		[Register ("generateTimestamp", "()Ljava/lang/String;", "GetGenerateTimestampHandler")]
		protected virtual string GenerateTimestamp ()
		{
			if (id_generateTimestamp == IntPtr.Zero)
				id_generateTimestamp = JNIEnv.GetMethodID (class_ref, "generateTimestamp", "()Ljava/lang/String;");

			if (GetType () == ThresholdType)
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_generateTimestamp), JniHandleOwnership.TransferLocalRef);
			else
				return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "generateTimestamp", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Parse.Signpost.AbstractOAuthConsumer __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.AbstractOAuthConsumer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Parse.Signpost.Http.HttpParameters p0 = global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.Http.HttpParameters> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetAdditionalParameters (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setAdditionalParameters_Lcom_parse_signpost_http_HttpParameters_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.signpost']/class[@name='AbstractOAuthConsumer']/method[@name='setAdditionalParameters' and count(parameter)=1 and parameter[1][@type='com.parse.signpost.http.HttpParameters']]"
		[Register ("setAdditionalParameters", "(Lcom/parse/signpost/http/HttpParameters;)V", "GetSetAdditionalParameters_Lcom_parse_signpost_http_HttpParameters_Handler")]
		public virtual void SetAdditionalParameters (global::Com.Parse.Signpost.Http.HttpParameters p0)
		{
			if (id_setAdditionalParameters_Lcom_parse_signpost_http_HttpParameters_ == IntPtr.Zero)
				id_setAdditionalParameters_Lcom_parse_signpost_http_HttpParameters_ = JNIEnv.GetMethodID (class_ref, "setAdditionalParameters", "(Lcom/parse/signpost/http/HttpParameters;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setAdditionalParameters_Lcom_parse_signpost_http_HttpParameters_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAdditionalParameters", "(Lcom/parse/signpost/http/HttpParameters;)V"), new JValue (p0));
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
			global::Com.Parse.Signpost.AbstractOAuthConsumer __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.AbstractOAuthConsumer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Parse.Signpost.Signature.OAuthMessageSigner p0 = global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.Signature.OAuthMessageSigner> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetMessageSigner (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setMessageSigner_Lcom_parse_signpost_signature_OAuthMessageSigner_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.signpost']/class[@name='AbstractOAuthConsumer']/method[@name='setMessageSigner' and count(parameter)=1 and parameter[1][@type='com.parse.signpost.signature.OAuthMessageSigner']]"
		[Register ("setMessageSigner", "(Lcom/parse/signpost/signature/OAuthMessageSigner;)V", "GetSetMessageSigner_Lcom_parse_signpost_signature_OAuthMessageSigner_Handler")]
		public virtual void SetMessageSigner (global::Com.Parse.Signpost.Signature.OAuthMessageSigner p0)
		{
			if (id_setMessageSigner_Lcom_parse_signpost_signature_OAuthMessageSigner_ == IntPtr.Zero)
				id_setMessageSigner_Lcom_parse_signpost_signature_OAuthMessageSigner_ = JNIEnv.GetMethodID (class_ref, "setMessageSigner", "(Lcom/parse/signpost/signature/OAuthMessageSigner;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setMessageSigner_Lcom_parse_signpost_signature_OAuthMessageSigner_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMessageSigner", "(Lcom/parse/signpost/signature/OAuthMessageSigner;)V"), new JValue (p0));
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
			global::Com.Parse.Signpost.AbstractOAuthConsumer __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.AbstractOAuthConsumer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetSendEmptyTokens (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setSendEmptyTokens_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.signpost']/class[@name='AbstractOAuthConsumer']/method[@name='setSendEmptyTokens' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setSendEmptyTokens", "(Z)V", "GetSetSendEmptyTokens_ZHandler")]
		public virtual void SetSendEmptyTokens (bool p0)
		{
			if (id_setSendEmptyTokens_Z == IntPtr.Zero)
				id_setSendEmptyTokens_Z = JNIEnv.GetMethodID (class_ref, "setSendEmptyTokens", "(Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setSendEmptyTokens_Z, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSendEmptyTokens", "(Z)V"), new JValue (p0));
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
			global::Com.Parse.Signpost.AbstractOAuthConsumer __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.AbstractOAuthConsumer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Parse.Signpost.Signature.ISigningStrategy p0 = (global::Com.Parse.Signpost.Signature.ISigningStrategy)global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.Signature.ISigningStrategy> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetSigningStrategy (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setSigningStrategy_Lcom_parse_signpost_signature_SigningStrategy_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.signpost']/class[@name='AbstractOAuthConsumer']/method[@name='setSigningStrategy' and count(parameter)=1 and parameter[1][@type='com.parse.signpost.signature.SigningStrategy']]"
		[Register ("setSigningStrategy", "(Lcom/parse/signpost/signature/SigningStrategy;)V", "GetSetSigningStrategy_Lcom_parse_signpost_signature_SigningStrategy_Handler")]
		public virtual void SetSigningStrategy (global::Com.Parse.Signpost.Signature.ISigningStrategy p0)
		{
			if (id_setSigningStrategy_Lcom_parse_signpost_signature_SigningStrategy_ == IntPtr.Zero)
				id_setSigningStrategy_Lcom_parse_signpost_signature_SigningStrategy_ = JNIEnv.GetMethodID (class_ref, "setSigningStrategy", "(Lcom/parse/signpost/signature/SigningStrategy;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setSigningStrategy_Lcom_parse_signpost_signature_SigningStrategy_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSigningStrategy", "(Lcom/parse/signpost/signature/SigningStrategy;)V"), new JValue (p0));
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
			global::Com.Parse.Signpost.AbstractOAuthConsumer __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.AbstractOAuthConsumer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetTokenWithSecret (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setTokenWithSecret_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.signpost']/class[@name='AbstractOAuthConsumer']/method[@name='setTokenWithSecret' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("setTokenWithSecret", "(Ljava/lang/String;Ljava/lang/String;)V", "GetSetTokenWithSecret_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual void SetTokenWithSecret (string p0, string p1)
		{
			if (id_setTokenWithSecret_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_setTokenWithSecret_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTokenWithSecret", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setTokenWithSecret_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTokenWithSecret", "(Ljava/lang/String;Ljava/lang/String;)V"), new JValue (native_p0), new JValue (native_p1));
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
			global::Com.Parse.Signpost.AbstractOAuthConsumer __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.AbstractOAuthConsumer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Parse.Signpost.Http.IHttpRequest p0 = (global::Com.Parse.Signpost.Http.IHttpRequest)global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.Http.IHttpRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Sign (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_sign_Lcom_parse_signpost_http_HttpRequest_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.signpost']/class[@name='AbstractOAuthConsumer']/method[@name='sign' and count(parameter)=1 and parameter[1][@type='com.parse.signpost.http.HttpRequest']]"
		[Register ("sign", "(Lcom/parse/signpost/http/HttpRequest;)Lcom/parse/signpost/http/HttpRequest;", "GetSign_Lcom_parse_signpost_http_HttpRequest_Handler")]
		public virtual global::Com.Parse.Signpost.Http.IHttpRequest Sign (global::Com.Parse.Signpost.Http.IHttpRequest p0)
		{
			if (id_sign_Lcom_parse_signpost_http_HttpRequest_ == IntPtr.Zero)
				id_sign_Lcom_parse_signpost_http_HttpRequest_ = JNIEnv.GetMethodID (class_ref, "sign", "(Lcom/parse/signpost/http/HttpRequest;)Lcom/parse/signpost/http/HttpRequest;");

			global::Com.Parse.Signpost.Http.IHttpRequest __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.Http.IHttpRequest> (JNIEnv.CallObjectMethod  (Handle, id_sign_Lcom_parse_signpost_http_HttpRequest_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.Http.IHttpRequest> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sign", "(Lcom/parse/signpost/http/HttpRequest;)Lcom/parse/signpost/http/HttpRequest;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Parse.Signpost.AbstractOAuthConsumer __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.AbstractOAuthConsumer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Sign (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_sign_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.signpost']/class[@name='AbstractOAuthConsumer']/method[@name='sign' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("sign", "(Ljava/lang/Object;)Lcom/parse/signpost/http/HttpRequest;", "GetSign_Ljava_lang_Object_Handler")]
		public virtual global::Com.Parse.Signpost.Http.IHttpRequest Sign (global::Java.Lang.Object p0)
		{
			if (id_sign_Ljava_lang_Object_ == IntPtr.Zero)
				id_sign_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "sign", "(Ljava/lang/Object;)Lcom/parse/signpost/http/HttpRequest;");

			global::Com.Parse.Signpost.Http.IHttpRequest __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.Http.IHttpRequest> (JNIEnv.CallObjectMethod  (Handle, id_sign_Ljava_lang_Object_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.Http.IHttpRequest> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sign", "(Ljava/lang/Object;)Lcom/parse/signpost/http/HttpRequest;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Parse.Signpost.AbstractOAuthConsumer __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.AbstractOAuthConsumer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Sign (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_sign_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.signpost']/class[@name='AbstractOAuthConsumer']/method[@name='sign' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("sign", "(Ljava/lang/String;)Ljava/lang/String;", "GetSign_Ljava_lang_String_Handler")]
		public virtual string Sign (string p0)
		{
			if (id_sign_Ljava_lang_String_ == IntPtr.Zero)
				id_sign_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "sign", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			string __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_sign_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sign", "(Ljava/lang/String;)Ljava/lang/String;"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_wrap_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetWrap_Ljava_lang_Object_Handler ()
		{
			if (cb_wrap_Ljava_lang_Object_ == null)
				cb_wrap_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Wrap_Ljava_lang_Object_);
			return cb_wrap_Ljava_lang_Object_;
		}

		static IntPtr n_Wrap_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.Signpost.AbstractOAuthConsumer __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.AbstractOAuthConsumer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Wrap (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.signpost']/class[@name='AbstractOAuthConsumer']/method[@name='wrap' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("wrap", "(Ljava/lang/Object;)Lcom/parse/signpost/http/HttpRequest;", "GetWrap_Ljava_lang_Object_Handler")]
		protected abstract global::Com.Parse.Signpost.Http.IHttpRequest Wrap (global::Java.Lang.Object p0);

	}

	[global::Android.Runtime.Register ("com/parse/signpost/AbstractOAuthConsumer", DoNotGenerateAcw=true)]
	internal partial class AbstractOAuthConsumerInvoker : AbstractOAuthConsumer {

		public AbstractOAuthConsumerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (AbstractOAuthConsumerInvoker); }
		}

		static IntPtr id_wrap_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.signpost']/class[@name='AbstractOAuthConsumer']/method[@name='wrap' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("wrap", "(Ljava/lang/Object;)Lcom/parse/signpost/http/HttpRequest;", "GetWrap_Ljava_lang_Object_Handler")]
		protected override global::Com.Parse.Signpost.Http.IHttpRequest Wrap (global::Java.Lang.Object p0)
		{
			if (id_wrap_Ljava_lang_Object_ == IntPtr.Zero)
				id_wrap_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "wrap", "(Ljava/lang/Object;)Lcom/parse/signpost/http/HttpRequest;");
			global::Com.Parse.Signpost.Http.IHttpRequest __ret = global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.Http.IHttpRequest> (JNIEnv.CallObjectMethod  (Handle, id_wrap_Ljava_lang_Object_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}

}
