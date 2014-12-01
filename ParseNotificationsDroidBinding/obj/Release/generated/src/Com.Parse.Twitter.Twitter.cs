using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Parse.Twitter {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.parse.twitter']/class[@name='Twitter']"
	[global::Android.Runtime.Register ("com/parse/twitter/Twitter", DoNotGenerateAcw=true)]
	public partial class Twitter : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/parse/twitter/Twitter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Twitter); }
		}

		protected Twitter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.parse.twitter']/class[@name='Twitter']/constructor[@name='Twitter' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public Twitter (string p0, string p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);;
			IntPtr native_p1 = JNIEnv.NewString (p1);;
			if (GetType () != typeof (Twitter)) {
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

		static Delegate cb_getAuthToken;
#pragma warning disable 0169
		static Delegate GetGetAuthTokenHandler ()
		{
			if (cb_getAuthToken == null)
				cb_getAuthToken = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAuthToken);
			return cb_getAuthToken;
		}

		static IntPtr n_GetAuthToken (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.Twitter.Twitter __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Twitter.Twitter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AuthToken);
		}
#pragma warning restore 0169

		static Delegate cb_setAuthToken_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAuthToken_Ljava_lang_String_Handler ()
		{
			if (cb_setAuthToken_Ljava_lang_String_ == null)
				cb_setAuthToken_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAuthToken_Ljava_lang_String_);
			return cb_setAuthToken_Ljava_lang_String_;
		}

		static void n_SetAuthToken_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.Twitter.Twitter __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Twitter.Twitter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AuthToken = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAuthToken;
		static IntPtr id_setAuthToken_Ljava_lang_String_;
		public virtual string AuthToken {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.twitter']/class[@name='Twitter']/method[@name='getAuthToken' and count(parameter)=0]"
			[Register ("getAuthToken", "()Ljava/lang/String;", "GetGetAuthTokenHandler")]
			get {
				if (id_getAuthToken == IntPtr.Zero)
					id_getAuthToken = JNIEnv.GetMethodID (class_ref, "getAuthToken", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getAuthToken), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAuthToken", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.twitter']/class[@name='Twitter']/method[@name='setAuthToken' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAuthToken", "(Ljava/lang/String;)V", "GetSetAuthToken_Ljava_lang_String_Handler")]
			set {
				if (id_setAuthToken_Ljava_lang_String_ == IntPtr.Zero)
					id_setAuthToken_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAuthToken", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setAuthToken_Ljava_lang_String_, new JValue (native_value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAuthToken", "(Ljava/lang/String;)V"), new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_getAuthTokenSecret;
#pragma warning disable 0169
		static Delegate GetGetAuthTokenSecretHandler ()
		{
			if (cb_getAuthTokenSecret == null)
				cb_getAuthTokenSecret = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAuthTokenSecret);
			return cb_getAuthTokenSecret;
		}

		static IntPtr n_GetAuthTokenSecret (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.Twitter.Twitter __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Twitter.Twitter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AuthTokenSecret);
		}
#pragma warning restore 0169

		static Delegate cb_setAuthTokenSecret_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAuthTokenSecret_Ljava_lang_String_Handler ()
		{
			if (cb_setAuthTokenSecret_Ljava_lang_String_ == null)
				cb_setAuthTokenSecret_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAuthTokenSecret_Ljava_lang_String_);
			return cb_setAuthTokenSecret_Ljava_lang_String_;
		}

		static void n_SetAuthTokenSecret_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.Twitter.Twitter __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Twitter.Twitter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AuthTokenSecret = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAuthTokenSecret;
		static IntPtr id_setAuthTokenSecret_Ljava_lang_String_;
		public virtual string AuthTokenSecret {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.twitter']/class[@name='Twitter']/method[@name='getAuthTokenSecret' and count(parameter)=0]"
			[Register ("getAuthTokenSecret", "()Ljava/lang/String;", "GetGetAuthTokenSecretHandler")]
			get {
				if (id_getAuthTokenSecret == IntPtr.Zero)
					id_getAuthTokenSecret = JNIEnv.GetMethodID (class_ref, "getAuthTokenSecret", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getAuthTokenSecret), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAuthTokenSecret", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.twitter']/class[@name='Twitter']/method[@name='setAuthTokenSecret' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAuthTokenSecret", "(Ljava/lang/String;)V", "GetSetAuthTokenSecret_Ljava_lang_String_Handler")]
			set {
				if (id_setAuthTokenSecret_Ljava_lang_String_ == IntPtr.Zero)
					id_setAuthTokenSecret_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAuthTokenSecret", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setAuthTokenSecret_Ljava_lang_String_, new JValue (native_value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAuthTokenSecret", "(Ljava/lang/String;)V"), new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
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
			global::Com.Parse.Twitter.Twitter __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Twitter.Twitter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ConsumerKey);
		}
#pragma warning restore 0169

		static Delegate cb_setConsumerKey_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetConsumerKey_Ljava_lang_String_Handler ()
		{
			if (cb_setConsumerKey_Ljava_lang_String_ == null)
				cb_setConsumerKey_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetConsumerKey_Ljava_lang_String_);
			return cb_setConsumerKey_Ljava_lang_String_;
		}

		static void n_SetConsumerKey_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.Twitter.Twitter __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Twitter.Twitter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ConsumerKey = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getConsumerKey;
		static IntPtr id_setConsumerKey_Ljava_lang_String_;
		public virtual string ConsumerKey {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.twitter']/class[@name='Twitter']/method[@name='getConsumerKey' and count(parameter)=0]"
			[Register ("getConsumerKey", "()Ljava/lang/String;", "GetGetConsumerKeyHandler")]
			get {
				if (id_getConsumerKey == IntPtr.Zero)
					id_getConsumerKey = JNIEnv.GetMethodID (class_ref, "getConsumerKey", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getConsumerKey), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getConsumerKey", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.twitter']/class[@name='Twitter']/method[@name='setConsumerKey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setConsumerKey", "(Ljava/lang/String;)V", "GetSetConsumerKey_Ljava_lang_String_Handler")]
			set {
				if (id_setConsumerKey_Ljava_lang_String_ == IntPtr.Zero)
					id_setConsumerKey_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setConsumerKey", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setConsumerKey_Ljava_lang_String_, new JValue (native_value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setConsumerKey", "(Ljava/lang/String;)V"), new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
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
			global::Com.Parse.Twitter.Twitter __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Twitter.Twitter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ConsumerSecret);
		}
#pragma warning restore 0169

		static Delegate cb_setConsumerSecret_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetConsumerSecret_Ljava_lang_String_Handler ()
		{
			if (cb_setConsumerSecret_Ljava_lang_String_ == null)
				cb_setConsumerSecret_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetConsumerSecret_Ljava_lang_String_);
			return cb_setConsumerSecret_Ljava_lang_String_;
		}

		static void n_SetConsumerSecret_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.Twitter.Twitter __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Twitter.Twitter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ConsumerSecret = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getConsumerSecret;
		static IntPtr id_setConsumerSecret_Ljava_lang_String_;
		public virtual string ConsumerSecret {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.twitter']/class[@name='Twitter']/method[@name='getConsumerSecret' and count(parameter)=0]"
			[Register ("getConsumerSecret", "()Ljava/lang/String;", "GetGetConsumerSecretHandler")]
			get {
				if (id_getConsumerSecret == IntPtr.Zero)
					id_getConsumerSecret = JNIEnv.GetMethodID (class_ref, "getConsumerSecret", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getConsumerSecret), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getConsumerSecret", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.twitter']/class[@name='Twitter']/method[@name='setConsumerSecret' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setConsumerSecret", "(Ljava/lang/String;)V", "GetSetConsumerSecret_Ljava_lang_String_Handler")]
			set {
				if (id_setConsumerSecret_Ljava_lang_String_ == IntPtr.Zero)
					id_setConsumerSecret_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setConsumerSecret", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setConsumerSecret_Ljava_lang_String_, new JValue (native_value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setConsumerSecret", "(Ljava/lang/String;)V"), new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_getScreenName;
#pragma warning disable 0169
		static Delegate GetGetScreenNameHandler ()
		{
			if (cb_getScreenName == null)
				cb_getScreenName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetScreenName);
			return cb_getScreenName;
		}

		static IntPtr n_GetScreenName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.Twitter.Twitter __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Twitter.Twitter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ScreenName);
		}
#pragma warning restore 0169

		static Delegate cb_setScreenName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetScreenName_Ljava_lang_String_Handler ()
		{
			if (cb_setScreenName_Ljava_lang_String_ == null)
				cb_setScreenName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetScreenName_Ljava_lang_String_);
			return cb_setScreenName_Ljava_lang_String_;
		}

		static void n_SetScreenName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.Twitter.Twitter __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Twitter.Twitter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ScreenName = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getScreenName;
		static IntPtr id_setScreenName_Ljava_lang_String_;
		public virtual string ScreenName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.twitter']/class[@name='Twitter']/method[@name='getScreenName' and count(parameter)=0]"
			[Register ("getScreenName", "()Ljava/lang/String;", "GetGetScreenNameHandler")]
			get {
				if (id_getScreenName == IntPtr.Zero)
					id_getScreenName = JNIEnv.GetMethodID (class_ref, "getScreenName", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getScreenName), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getScreenName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.twitter']/class[@name='Twitter']/method[@name='setScreenName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setScreenName", "(Ljava/lang/String;)V", "GetSetScreenName_Ljava_lang_String_Handler")]
			set {
				if (id_setScreenName_Ljava_lang_String_ == IntPtr.Zero)
					id_setScreenName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setScreenName", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setScreenName_Ljava_lang_String_, new JValue (native_value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setScreenName", "(Ljava/lang/String;)V"), new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_getUserId;
#pragma warning disable 0169
		static Delegate GetGetUserIdHandler ()
		{
			if (cb_getUserId == null)
				cb_getUserId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUserId);
			return cb_getUserId;
		}

		static IntPtr n_GetUserId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.Twitter.Twitter __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Twitter.Twitter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.UserId);
		}
#pragma warning restore 0169

		static Delegate cb_setUserId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetUserId_Ljava_lang_String_Handler ()
		{
			if (cb_setUserId_Ljava_lang_String_ == null)
				cb_setUserId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetUserId_Ljava_lang_String_);
			return cb_setUserId_Ljava_lang_String_;
		}

		static void n_SetUserId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.Twitter.Twitter __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Twitter.Twitter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UserId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getUserId;
		static IntPtr id_setUserId_Ljava_lang_String_;
		public virtual string UserId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.twitter']/class[@name='Twitter']/method[@name='getUserId' and count(parameter)=0]"
			[Register ("getUserId", "()Ljava/lang/String;", "GetGetUserIdHandler")]
			get {
				if (id_getUserId == IntPtr.Zero)
					id_getUserId = JNIEnv.GetMethodID (class_ref, "getUserId", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getUserId), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUserId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.twitter']/class[@name='Twitter']/method[@name='setUserId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setUserId", "(Ljava/lang/String;)V", "GetSetUserId_Ljava_lang_String_Handler")]
			set {
				if (id_setUserId_Ljava_lang_String_ == IntPtr.Zero)
					id_setUserId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setUserId", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setUserId_Ljava_lang_String_, new JValue (native_value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUserId", "(Ljava/lang/String;)V"), new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_authorize_Landroid_content_Context_Lcom_parse_internal_AsyncCallback_;
#pragma warning disable 0169
		static Delegate GetAuthorize_Landroid_content_Context_Lcom_parse_internal_AsyncCallback_Handler ()
		{
			if (cb_authorize_Landroid_content_Context_Lcom_parse_internal_AsyncCallback_ == null)
				cb_authorize_Landroid_content_Context_Lcom_parse_internal_AsyncCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Authorize_Landroid_content_Context_Lcom_parse_internal_AsyncCallback_);
			return cb_authorize_Landroid_content_Context_Lcom_parse_internal_AsyncCallback_;
		}

		static void n_Authorize_Landroid_content_Context_Lcom_parse_internal_AsyncCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Parse.Twitter.Twitter __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Twitter.Twitter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Parse.Internal.IAsyncCallback p1 = (global::Com.Parse.Internal.IAsyncCallback)global::Java.Lang.Object.GetObject<global::Com.Parse.Internal.IAsyncCallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Authorize (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_authorize_Landroid_content_Context_Lcom_parse_internal_AsyncCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.twitter']/class[@name='Twitter']/method[@name='authorize' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.parse.internal.AsyncCallback']]"
		[Register ("authorize", "(Landroid/content/Context;Lcom/parse/internal/AsyncCallback;)V", "GetAuthorize_Landroid_content_Context_Lcom_parse_internal_AsyncCallback_Handler")]
		public virtual void Authorize (global::Android.Content.Context p0, global::Com.Parse.Internal.IAsyncCallback p1)
		{
			if (id_authorize_Landroid_content_Context_Lcom_parse_internal_AsyncCallback_ == IntPtr.Zero)
				id_authorize_Landroid_content_Context_Lcom_parse_internal_AsyncCallback_ = JNIEnv.GetMethodID (class_ref, "authorize", "(Landroid/content/Context;Lcom/parse/internal/AsyncCallback;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_authorize_Landroid_content_Context_Lcom_parse_internal_AsyncCallback_, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "authorize", "(Landroid/content/Context;Lcom/parse/internal/AsyncCallback;)V"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_signRequest_Lorg_apache_http_client_methods_HttpUriRequest_;
#pragma warning disable 0169
		static Delegate GetSignRequest_Lorg_apache_http_client_methods_HttpUriRequest_Handler ()
		{
			if (cb_signRequest_Lorg_apache_http_client_methods_HttpUriRequest_ == null)
				cb_signRequest_Lorg_apache_http_client_methods_HttpUriRequest_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SignRequest_Lorg_apache_http_client_methods_HttpUriRequest_);
			return cb_signRequest_Lorg_apache_http_client_methods_HttpUriRequest_;
		}

		static void n_SignRequest_Lorg_apache_http_client_methods_HttpUriRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.Twitter.Twitter __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Twitter.Twitter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Apache.Http.Client.Methods.IHttpUriRequest p0 = (global::Org.Apache.Http.Client.Methods.IHttpUriRequest)global::Java.Lang.Object.GetObject<global::Org.Apache.Http.Client.Methods.IHttpUriRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SignRequest (p0);
		}
#pragma warning restore 0169

		static IntPtr id_signRequest_Lorg_apache_http_client_methods_HttpUriRequest_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.twitter']/class[@name='Twitter']/method[@name='signRequest' and count(parameter)=1 and parameter[1][@type='org.apache.http.client.methods.HttpUriRequest']]"
		[Register ("signRequest", "(Lorg/apache/http/client/methods/HttpUriRequest;)V", "GetSignRequest_Lorg_apache_http_client_methods_HttpUriRequest_Handler")]
		public virtual void SignRequest (global::Org.Apache.Http.Client.Methods.IHttpUriRequest p0)
		{
			if (id_signRequest_Lorg_apache_http_client_methods_HttpUriRequest_ == IntPtr.Zero)
				id_signRequest_Lorg_apache_http_client_methods_HttpUriRequest_ = JNIEnv.GetMethodID (class_ref, "signRequest", "(Lorg/apache/http/client/methods/HttpUriRequest;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_signRequest_Lorg_apache_http_client_methods_HttpUriRequest_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "signRequest", "(Lorg/apache/http/client/methods/HttpUriRequest;)V"), new JValue (p0));
		}

	}
}
