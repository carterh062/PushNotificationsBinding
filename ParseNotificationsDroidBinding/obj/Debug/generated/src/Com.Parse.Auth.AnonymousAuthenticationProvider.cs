using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Parse.Auth {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.parse.auth']/class[@name='AnonymousAuthenticationProvider']"
	[global::Android.Runtime.Register ("com/parse/auth/AnonymousAuthenticationProvider", DoNotGenerateAcw=true)]
	public partial class AnonymousAuthenticationProvider : global::Java.Lang.Object, global::Com.Parse.Auth.IParseAuthenticationProvider {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/parse/auth/AnonymousAuthenticationProvider", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AnonymousAuthenticationProvider); }
		}

		protected AnonymousAuthenticationProvider (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.parse.auth']/class[@name='AnonymousAuthenticationProvider']/constructor[@name='AnonymousAuthenticationProvider' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public AnonymousAuthenticationProvider () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (AnonymousAuthenticationProvider)) {
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

		static Delegate cb_getAuthData;
#pragma warning disable 0169
		static Delegate GetGetAuthDataHandler ()
		{
			if (cb_getAuthData == null)
				cb_getAuthData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAuthData);
			return cb_getAuthData;
		}

		static IntPtr n_GetAuthData (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.Auth.AnonymousAuthenticationProvider __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Auth.AnonymousAuthenticationProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AuthData);
		}
#pragma warning restore 0169

		static IntPtr id_getAuthData;
		public virtual global::Org.Json.JSONObject AuthData {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.auth']/class[@name='AnonymousAuthenticationProvider']/method[@name='getAuthData' and count(parameter)=0]"
			[Register ("getAuthData", "()Lorg/json/JSONObject;", "GetGetAuthDataHandler")]
			get {
				if (id_getAuthData == IntPtr.Zero)
					id_getAuthData = JNIEnv.GetMethodID (class_ref, "getAuthData", "()Lorg/json/JSONObject;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallObjectMethod  (Handle, id_getAuthData), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAuthData", "()Lorg/json/JSONObject;")), JniHandleOwnership.TransferLocalRef);
			}
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
			global::Com.Parse.Auth.AnonymousAuthenticationProvider __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Auth.AnonymousAuthenticationProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AuthType);
		}
#pragma warning restore 0169

		static IntPtr id_getAuthType;
		public virtual string AuthType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.auth']/class[@name='AnonymousAuthenticationProvider']/method[@name='getAuthType' and count(parameter)=0]"
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
			global::Com.Parse.Auth.AnonymousAuthenticationProvider __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Auth.AnonymousAuthenticationProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Parse.Auth.IParseAuthenticationProviderParseAuthenticationCallback p0 = (global::Com.Parse.Auth.IParseAuthenticationProviderParseAuthenticationCallback)global::Java.Lang.Object.GetObject<global::Com.Parse.Auth.IParseAuthenticationProviderParseAuthenticationCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Authenticate (p0);
		}
#pragma warning restore 0169

		static IntPtr id_authenticate_Lcom_parse_auth_ParseAuthenticationProvider_ParseAuthenticationCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.auth']/class[@name='AnonymousAuthenticationProvider']/method[@name='authenticate' and count(parameter)=1 and parameter[1][@type='com.parse.auth.ParseAuthenticationProvider.ParseAuthenticationCallback']]"
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
			global::Com.Parse.Auth.AnonymousAuthenticationProvider __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Auth.AnonymousAuthenticationProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Cancel ();
		}
#pragma warning restore 0169

		static IntPtr id_cancel;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.auth']/class[@name='AnonymousAuthenticationProvider']/method[@name='cancel' and count(parameter)=0]"
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
			global::Com.Parse.Auth.AnonymousAuthenticationProvider __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Auth.AnonymousAuthenticationProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Deauthenticate ();
		}
#pragma warning restore 0169

		static IntPtr id_deauthenticate;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.auth']/class[@name='AnonymousAuthenticationProvider']/method[@name='deauthenticate' and count(parameter)=0]"
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
			global::Com.Parse.Auth.AnonymousAuthenticationProvider __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Auth.AnonymousAuthenticationProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RestoreAuthentication (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_restoreAuthentication_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.auth']/class[@name='AnonymousAuthenticationProvider']/method[@name='restoreAuthentication' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
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

	}
}
