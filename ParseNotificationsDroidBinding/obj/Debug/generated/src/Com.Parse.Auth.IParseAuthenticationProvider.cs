using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Parse.Auth {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.parse.auth']/interface[@name='ParseAuthenticationProvider.ParseAuthenticationCallback']"
	[Register ("com/parse/auth/ParseAuthenticationProvider$ParseAuthenticationCallback", "", "Com.Parse.Auth.IParseAuthenticationProviderParseAuthenticationCallbackInvoker")]
	public partial interface IParseAuthenticationProviderParseAuthenticationCallback : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.auth']/interface[@name='ParseAuthenticationProvider.ParseAuthenticationCallback']/method[@name='onCancel' and count(parameter)=0]"
		[Register ("onCancel", "()V", "GetOnCancelHandler:Com.Parse.Auth.IParseAuthenticationProviderParseAuthenticationCallbackInvoker, ParseNotificationsDroidBinding")]
		void OnCancel ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.auth']/interface[@name='ParseAuthenticationProvider.ParseAuthenticationCallback']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("onError", "(Ljava/lang/Throwable;)V", "GetOnError_Ljava_lang_Throwable_Handler:Com.Parse.Auth.IParseAuthenticationProviderParseAuthenticationCallbackInvoker, ParseNotificationsDroidBinding")]
		void OnError (global::Java.Lang.Throwable p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.auth']/interface[@name='ParseAuthenticationProvider.ParseAuthenticationCallback']/method[@name='onSuccess' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("onSuccess", "(Lorg/json/JSONObject;)V", "GetOnSuccess_Lorg_json_JSONObject_Handler:Com.Parse.Auth.IParseAuthenticationProviderParseAuthenticationCallbackInvoker, ParseNotificationsDroidBinding")]
		void OnSuccess (global::Org.Json.JSONObject p0);

	}

	[global::Android.Runtime.Register ("com/parse/auth/ParseAuthenticationProvider$ParseAuthenticationCallback", DoNotGenerateAcw=true)]
	internal class IParseAuthenticationProviderParseAuthenticationCallbackInvoker : global::Java.Lang.Object, IParseAuthenticationProviderParseAuthenticationCallback {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/parse/auth/ParseAuthenticationProvider$ParseAuthenticationCallback");
		IntPtr class_ref;

		public static IParseAuthenticationProviderParseAuthenticationCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IParseAuthenticationProviderParseAuthenticationCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.parse.auth.ParseAuthenticationProvider.ParseAuthenticationCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IParseAuthenticationProviderParseAuthenticationCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IParseAuthenticationProviderParseAuthenticationCallbackInvoker); }
		}

		static Delegate cb_onCancel;
#pragma warning disable 0169
		static Delegate GetOnCancelHandler ()
		{
			if (cb_onCancel == null)
				cb_onCancel = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnCancel);
			return cb_onCancel;
		}

		static void n_OnCancel (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.Auth.IParseAuthenticationProviderParseAuthenticationCallback __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Auth.IParseAuthenticationProviderParseAuthenticationCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnCancel ();
		}
#pragma warning restore 0169

		IntPtr id_onCancel;
		public void OnCancel ()
		{
			if (id_onCancel == IntPtr.Zero)
				id_onCancel = JNIEnv.GetMethodID (class_ref, "onCancel", "()V");
			JNIEnv.CallVoidMethod (Handle, id_onCancel);
		}

		static Delegate cb_onError_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetOnError_Ljava_lang_Throwable_Handler ()
		{
			if (cb_onError_Ljava_lang_Throwable_ == null)
				cb_onError_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnError_Ljava_lang_Throwable_);
			return cb_onError_Ljava_lang_Throwable_;
		}

		static void n_OnError_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.Auth.IParseAuthenticationProviderParseAuthenticationCallback __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Auth.IParseAuthenticationProviderParseAuthenticationCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnError (p0);
		}
#pragma warning restore 0169

		IntPtr id_onError_Ljava_lang_Throwable_;
		public void OnError (global::Java.Lang.Throwable p0)
		{
			if (id_onError_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_onError_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "onError", "(Ljava/lang/Throwable;)V");
			JNIEnv.CallVoidMethod (Handle, id_onError_Ljava_lang_Throwable_, new JValue (p0));
		}

		static Delegate cb_onSuccess_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetOnSuccess_Lorg_json_JSONObject_Handler ()
		{
			if (cb_onSuccess_Lorg_json_JSONObject_ == null)
				cb_onSuccess_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnSuccess_Lorg_json_JSONObject_);
			return cb_onSuccess_Lorg_json_JSONObject_;
		}

		static void n_OnSuccess_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.Auth.IParseAuthenticationProviderParseAuthenticationCallback __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Auth.IParseAuthenticationProviderParseAuthenticationCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSuccess (p0);
		}
#pragma warning restore 0169

		IntPtr id_onSuccess_Lorg_json_JSONObject_;
		public void OnSuccess (global::Org.Json.JSONObject p0)
		{
			if (id_onSuccess_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_onSuccess_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "onSuccess", "(Lorg/json/JSONObject;)V");
			JNIEnv.CallVoidMethod (Handle, id_onSuccess_Lorg_json_JSONObject_, new JValue (p0));
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.parse.auth']/interface[@name='ParseAuthenticationProvider']"
	[Register ("com/parse/auth/ParseAuthenticationProvider", "", "Com.Parse.Auth.IParseAuthenticationProviderInvoker")]
	public partial interface IParseAuthenticationProvider : IJavaObject {

		string AuthType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.auth']/interface[@name='ParseAuthenticationProvider']/method[@name='getAuthType' and count(parameter)=0]"
			[Register ("getAuthType", "()Ljava/lang/String;", "GetGetAuthTypeHandler:Com.Parse.Auth.IParseAuthenticationProviderInvoker, ParseNotificationsDroidBinding")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.auth']/interface[@name='ParseAuthenticationProvider']/method[@name='authenticate' and count(parameter)=1 and parameter[1][@type='com.parse.auth.ParseAuthenticationProvider.ParseAuthenticationCallback']]"
		[Register ("authenticate", "(Lcom/parse/auth/ParseAuthenticationProvider$ParseAuthenticationCallback;)V", "GetAuthenticate_Lcom_parse_auth_ParseAuthenticationProvider_ParseAuthenticationCallback_Handler:Com.Parse.Auth.IParseAuthenticationProviderInvoker, ParseNotificationsDroidBinding")]
		void Authenticate (global::Com.Parse.Auth.IParseAuthenticationProviderParseAuthenticationCallback p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.auth']/interface[@name='ParseAuthenticationProvider']/method[@name='cancel' and count(parameter)=0]"
		[Register ("cancel", "()V", "GetCancelHandler:Com.Parse.Auth.IParseAuthenticationProviderInvoker, ParseNotificationsDroidBinding")]
		void Cancel ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.auth']/interface[@name='ParseAuthenticationProvider']/method[@name='deauthenticate' and count(parameter)=0]"
		[Register ("deauthenticate", "()V", "GetDeauthenticateHandler:Com.Parse.Auth.IParseAuthenticationProviderInvoker, ParseNotificationsDroidBinding")]
		void Deauthenticate ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.auth']/interface[@name='ParseAuthenticationProvider']/method[@name='restoreAuthentication' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("restoreAuthentication", "(Lorg/json/JSONObject;)Z", "GetRestoreAuthentication_Lorg_json_JSONObject_Handler:Com.Parse.Auth.IParseAuthenticationProviderInvoker, ParseNotificationsDroidBinding")]
		bool RestoreAuthentication (global::Org.Json.JSONObject p0);

	}

	[global::Android.Runtime.Register ("com/parse/auth/ParseAuthenticationProvider", DoNotGenerateAcw=true)]
	internal class IParseAuthenticationProviderInvoker : global::Java.Lang.Object, IParseAuthenticationProvider {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/parse/auth/ParseAuthenticationProvider");
		IntPtr class_ref;

		public static IParseAuthenticationProvider GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IParseAuthenticationProvider> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.parse.auth.ParseAuthenticationProvider"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IParseAuthenticationProviderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IParseAuthenticationProviderInvoker); }
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
			global::Com.Parse.Auth.IParseAuthenticationProvider __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Auth.IParseAuthenticationProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AuthType);
		}
#pragma warning restore 0169

		IntPtr id_getAuthType;
		public string AuthType {
			get {
				if (id_getAuthType == IntPtr.Zero)
					id_getAuthType = JNIEnv.GetMethodID (class_ref, "getAuthType", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getAuthType), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Parse.Auth.IParseAuthenticationProvider __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Auth.IParseAuthenticationProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Parse.Auth.IParseAuthenticationProviderParseAuthenticationCallback p0 = (global::Com.Parse.Auth.IParseAuthenticationProviderParseAuthenticationCallback)global::Java.Lang.Object.GetObject<global::Com.Parse.Auth.IParseAuthenticationProviderParseAuthenticationCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Authenticate (p0);
		}
#pragma warning restore 0169

		IntPtr id_authenticate_Lcom_parse_auth_ParseAuthenticationProvider_ParseAuthenticationCallback_;
		public void Authenticate (global::Com.Parse.Auth.IParseAuthenticationProviderParseAuthenticationCallback p0)
		{
			if (id_authenticate_Lcom_parse_auth_ParseAuthenticationProvider_ParseAuthenticationCallback_ == IntPtr.Zero)
				id_authenticate_Lcom_parse_auth_ParseAuthenticationProvider_ParseAuthenticationCallback_ = JNIEnv.GetMethodID (class_ref, "authenticate", "(Lcom/parse/auth/ParseAuthenticationProvider$ParseAuthenticationCallback;)V");
			JNIEnv.CallVoidMethod (Handle, id_authenticate_Lcom_parse_auth_ParseAuthenticationProvider_ParseAuthenticationCallback_, new JValue (p0));
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
			global::Com.Parse.Auth.IParseAuthenticationProvider __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Auth.IParseAuthenticationProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Cancel ();
		}
#pragma warning restore 0169

		IntPtr id_cancel;
		public void Cancel ()
		{
			if (id_cancel == IntPtr.Zero)
				id_cancel = JNIEnv.GetMethodID (class_ref, "cancel", "()V");
			JNIEnv.CallVoidMethod (Handle, id_cancel);
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
			global::Com.Parse.Auth.IParseAuthenticationProvider __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Auth.IParseAuthenticationProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Deauthenticate ();
		}
#pragma warning restore 0169

		IntPtr id_deauthenticate;
		public void Deauthenticate ()
		{
			if (id_deauthenticate == IntPtr.Zero)
				id_deauthenticate = JNIEnv.GetMethodID (class_ref, "deauthenticate", "()V");
			JNIEnv.CallVoidMethod (Handle, id_deauthenticate);
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
			global::Com.Parse.Auth.IParseAuthenticationProvider __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Auth.IParseAuthenticationProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RestoreAuthentication (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_restoreAuthentication_Lorg_json_JSONObject_;
		public bool RestoreAuthentication (global::Org.Json.JSONObject p0)
		{
			if (id_restoreAuthentication_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_restoreAuthentication_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "restoreAuthentication", "(Lorg/json/JSONObject;)Z");
			bool __ret = JNIEnv.CallBooleanMethod (Handle, id_restoreAuthentication_Lorg_json_JSONObject_, new JValue (p0));
			return __ret;
		}

	}

}
