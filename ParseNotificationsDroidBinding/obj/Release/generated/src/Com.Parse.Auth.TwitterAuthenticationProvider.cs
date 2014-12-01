using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Parse.Auth {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.parse.auth']/class[@name='TwitterAuthenticationProvider']"
	[global::Android.Runtime.Register ("com/parse/auth/TwitterAuthenticationProvider", DoNotGenerateAcw=true)]
	public partial class TwitterAuthenticationProvider : global::Java.Lang.Object, global::Com.Parse.Auth.IParseAuthenticationProvider {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/parse/auth/TwitterAuthenticationProvider", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TwitterAuthenticationProvider); }
		}

		protected TwitterAuthenticationProvider (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_parse_twitter_Twitter_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.parse.auth']/class[@name='TwitterAuthenticationProvider']/constructor[@name='TwitterAuthenticationProvider' and count(parameter)=1 and parameter[1][@type='com.parse.twitter.Twitter']]"
		[Register (".ctor", "(Lcom/parse/twitter/Twitter;)V", "")]
		public TwitterAuthenticationProvider (global::Com.Parse.Twitter.Twitter p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (TwitterAuthenticationProvider)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/parse/twitter/Twitter;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/parse/twitter/Twitter;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Lcom_parse_twitter_Twitter_ == IntPtr.Zero)
				id_ctor_Lcom_parse_twitter_Twitter_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/parse/twitter/Twitter;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_parse_twitter_Twitter_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_parse_twitter_Twitter_, new JValue (p0));
		}

		static Delegate cb_getAuthType;
#pragma warning disable 0169
		static Delegate GetGetAuthTypeHandler ()
		{
			if (cb_getAuthType == null)
				cb_getAuthType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAuthType);
			return cb_getAuthType;
		}

		static IntPtr n_GetAuthType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.Auth.TwitterAuthenticationProvider __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Auth.TwitterAuthenticationProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AuthType);
		}
#pragma warning restore 0169

		static IntPtr id_getAuthType;
		public virtual string AuthType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.auth']/class[@name='TwitterAuthenticationProvider']/method[@name='getAuthType' and count(parameter)=0]"
			[Register ("getAuthType", "()Ljava/lang/String;", "GetGetAuthTypeHandler")]
			get {
				if (id_getAuthType == IntPtr.Zero)
					id_getAuthType = JNIEnv.GetMethodID (class_ref, "getAuthType", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getAuthType), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAuthType", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getTwitter;
#pragma warning disable 0169
		static Delegate GetGetTwitterHandler ()
		{
			if (cb_getTwitter == null)
				cb_getTwitter = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTwitter);
			return cb_getTwitter;
		}

		static IntPtr n_GetTwitter (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.Auth.TwitterAuthenticationProvider __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Auth.TwitterAuthenticationProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Twitter);
		}
#pragma warning restore 0169

		static IntPtr id_getTwitter;
		public virtual global::Com.Parse.Twitter.Twitter Twitter {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.auth']/class[@name='TwitterAuthenticationProvider']/method[@name='getTwitter' and count(parameter)=0]"
			[Register ("getTwitter", "()Lcom/parse/twitter/Twitter;", "GetGetTwitterHandler")]
			get {
				if (id_getTwitter == IntPtr.Zero)
					id_getTwitter = JNIEnv.GetMethodID (class_ref, "getTwitter", "()Lcom/parse/twitter/Twitter;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Parse.Twitter.Twitter> (JNIEnv.CallObjectMethod  (Handle, id_getTwitter), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Parse.Twitter.Twitter> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTwitter", "()Lcom/parse/twitter/Twitter;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_authenticate_Lcom_parse_auth_ParseAuthenticationProvider_ParseAuthenticationCallback_;
#pragma warning disable 0169
		static Delegate GetAuthenticate_Lcom_parse_auth_ParseAuthenticationProvider_ParseAuthenticationCallback_Handler ()
		{
			if (cb_authenticate_Lcom_parse_auth_ParseAuthenticationProvider_ParseAuthenticationCallback_ == null)
				cb_authenticate_Lcom_parse_auth_ParseAuthenticationProvider_ParseAuthenticationCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Authenticate_Lcom_parse_auth_ParseAuthenticationProvider_ParseAuthenticationCallback_);
			return cb_authenticate_Lcom_parse_auth_ParseAuthenticationProvider_ParseAuthenticationCallback_;
		}

		static void n_Authenticate_Lcom_parse_auth_ParseAuthenticationProvider_ParseAuthenticationCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.Auth.TwitterAuthenticationProvider __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Auth.TwitterAuthenticationProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Parse.Auth.IParseAuthenticationProviderParseAuthenticationCallback p0 = (global::Com.Parse.Auth.IParseAuthenticationProviderParseAuthenticationCallback)global::Java.Lang.Object.GetObject<global::Com.Parse.Auth.IParseAuthenticationProviderParseAuthenticationCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Authenticate (p0);
		}
#pragma warning restore 0169

		static IntPtr id_authenticate_Lcom_parse_auth_ParseAuthenticationProvider_ParseAuthenticationCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.auth']/class[@name='TwitterAuthenticationProvider']/method[@name='authenticate' and count(parameter)=1 and parameter[1][@type='com.parse.auth.ParseAuthenticationProvider.ParseAuthenticationCallback']]"
		[Register ("authenticate", "(Lcom/parse/auth/ParseAuthenticationProvider$ParseAuthenticationCallback;)V", "GetAuthenticate_Lcom_parse_auth_ParseAuthenticationProvider_ParseAuthenticationCallback_Handler")]
		public virtual void Authenticate (global::Com.Parse.Auth.IParseAuthenticationProviderParseAuthenticationCallback p0)
		{
			if (id_authenticate_Lcom_parse_auth_ParseAuthenticationProvider_ParseAuthenticationCallback_ == IntPtr.Zero)
				id_authenticate_Lcom_parse_auth_ParseAuthenticationProvider_ParseAuthenticationCallback_ = JNIEnv.GetMethodID (class_ref, "authenticate", "(Lcom/parse/auth/ParseAuthenticationProvider$ParseAuthenticationCallback;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_authenticate_Lcom_parse_auth_ParseAuthenticationProvider_ParseAuthenticationCallback_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "authenticate", "(Lcom/parse/auth/ParseAuthenticationProvider$ParseAuthenticationCallback;)V"), new JValue (p0));
		}

		static Delegate cb_cancel;
#pragma warning disable 0169
		static Delegate GetCancelHandler ()
		{
			if (cb_cancel == null)
				cb_cancel = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Cancel);
			return cb_cancel;
		}

		static void n_Cancel (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.Auth.TwitterAuthenticationProvider __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Auth.TwitterAuthenticationProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Cancel ();
		}
#pragma warning restore 0169

		static IntPtr id_cancel;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.auth']/class[@name='TwitterAuthenticationProvider']/method[@name='cancel' and count(parameter)=0]"
		[Register ("cancel", "()V", "GetCancelHandler")]
		public virtual void Cancel ()
		{
			if (id_cancel == IntPtr.Zero)
				id_cancel = JNIEnv.GetMethodID (class_ref, "cancel", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_cancel);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "cancel", "()V"));
		}

		static Delegate cb_deauthenticate;
#pragma warning disable 0169
		static Delegate GetDeauthenticateHandler ()
		{
			if (cb_deauthenticate == null)
				cb_deauthenticate = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Deauthenticate);
			return cb_deauthenticate;
		}

		static void n_Deauthenticate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.Auth.TwitterAuthenticationProvider __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Auth.TwitterAuthenticationProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Deauthenticate ();
		}
#pragma warning restore 0169

		static IntPtr id_deauthenticate;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.auth']/class[@name='TwitterAuthenticationProvider']/method[@name='deauthenticate' and count(parameter)=0]"
		[Register ("deauthenticate", "()V", "GetDeauthenticateHandler")]
		public virtual void Deauthenticate ()
		{
			if (id_deauthenticate == IntPtr.Zero)
				id_deauthenticate = JNIEnv.GetMethodID (class_ref, "deauthenticate", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_deauthenticate);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "deauthenticate", "()V"));
		}

		static Delegate cb_getAuthData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetAuthData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_getAuthData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_getAuthData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetAuthData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_getAuthData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_GetAuthData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Parse.Auth.TwitterAuthenticationProvider __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Auth.TwitterAuthenticationProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetAuthData (p0, p1, p2, p3));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getAuthData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.auth']/class[@name='TwitterAuthenticationProvider']/method[@name='getAuthData' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("getAuthData", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lorg/json/JSONObject;", "GetGetAuthData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual global::Org.Json.JSONObject GetAuthData (string p0, string p1, string p2, string p3)
		{
			if (id_getAuthData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_getAuthData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getAuthData", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lorg/json/JSONObject;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);

			global::Org.Json.JSONObject __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallObjectMethod  (Handle, id_getAuthData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1), new JValue (native_p2), new JValue (native_p3)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAuthData", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lorg/json/JSONObject;"), new JValue (native_p0), new JValue (native_p1), new JValue (native_p2), new JValue (native_p3)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			JNIEnv.DeleteLocalRef (native_p3);
			return __ret;
		}

		static Delegate cb_restoreAuthentication_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetRestoreAuthentication_Lorg_json_JSONObject_Handler ()
		{
			if (cb_restoreAuthentication_Lorg_json_JSONObject_ == null)
				cb_restoreAuthentication_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_RestoreAuthentication_Lorg_json_JSONObject_);
			return cb_restoreAuthentication_Lorg_json_JSONObject_;
		}

		static bool n_RestoreAuthentication_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.Auth.TwitterAuthenticationProvider __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Auth.TwitterAuthenticationProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RestoreAuthentication (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_restoreAuthentication_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.auth']/class[@name='TwitterAuthenticationProvider']/method[@name='restoreAuthentication' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("restoreAuthentication", "(Lorg/json/JSONObject;)Z", "GetRestoreAuthentication_Lorg_json_JSONObject_Handler")]
		public virtual bool RestoreAuthentication (global::Org.Json.JSONObject p0)
		{
			if (id_restoreAuthentication_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_restoreAuthentication_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "restoreAuthentication", "(Lorg/json/JSONObject;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_restoreAuthentication_Lorg_json_JSONObject_, new JValue (p0));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "restoreAuthentication", "(Lorg/json/JSONObject;)Z"), new JValue (p0));
			return __ret;
		}

		static Delegate cb_setContext_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetSetContext_Landroid_content_Context_Handler ()
		{
			if (cb_setContext_Landroid_content_Context_ == null)
				cb_setContext_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetContext_Landroid_content_Context_);
			return cb_setContext_Landroid_content_Context_;
		}

		static void n_SetContext_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.Auth.TwitterAuthenticationProvider __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Auth.TwitterAuthenticationProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetContext (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setContext_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.auth']/class[@name='TwitterAuthenticationProvider']/method[@name='setContext' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("setContext", "(Landroid/content/Context;)V", "GetSetContext_Landroid_content_Context_Handler")]
		public virtual void SetContext (global::Android.Content.Context p0)
		{
			if (id_setContext_Landroid_content_Context_ == IntPtr.Zero)
				id_setContext_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "setContext", "(Landroid/content/Context;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setContext_Landroid_content_Context_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setContext", "(Landroid/content/Context;)V"), new JValue (p0));
		}

	}
}
