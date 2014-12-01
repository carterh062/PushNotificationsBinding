using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Parse.Oauth {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.parse.oauth']/class[@name='OAuth1FlowException']"
	[global::Android.Runtime.Register ("com/parse/oauth/OAuth1FlowException", DoNotGenerateAcw=true)]
	public partial class OAuth1FlowException : global::Java.Lang.Exception {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/parse/oauth/OAuth1FlowException", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (OAuth1FlowException); }
		}

		protected OAuth1FlowException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_ILjava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.parse.oauth']/class[@name='OAuth1FlowException']/constructor[@name='OAuth1FlowException' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register (".ctor", "(ILjava/lang/String;Ljava/lang/String;)V", "")]
		public OAuth1FlowException (int p0, string p1, string p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);;
			IntPtr native_p2 = JNIEnv.NewString (p2);;
			if (GetType () != typeof (OAuth1FlowException)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(ILjava/lang/String;Ljava/lang/String;)V", new JValue (p0), new JValue (native_p1), new JValue (native_p2)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(ILjava/lang/String;Ljava/lang/String;)V", new JValue (p0), new JValue (native_p1), new JValue (native_p2));
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				return;
			}

			if (id_ctor_ILjava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_ctor_ILjava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(ILjava/lang/String;Ljava/lang/String;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_ILjava_lang_String_Ljava_lang_String_, new JValue (p0), new JValue (native_p1), new JValue (native_p2)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_ILjava_lang_String_Ljava_lang_String_, new JValue (p0), new JValue (native_p1), new JValue (native_p2));
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static Delegate cb_getDescription;
#pragma warning disable 0169
		static Delegate GetGetDescriptionHandler ()
		{
			if (cb_getDescription == null)
				cb_getDescription = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDescription);
			return cb_getDescription;
		}

		static IntPtr n_GetDescription (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.Oauth.OAuth1FlowException __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Oauth.OAuth1FlowException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Description);
		}
#pragma warning restore 0169

		static IntPtr id_getDescription;
		public virtual string Description {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.oauth']/class[@name='OAuth1FlowException']/method[@name='getDescription' and count(parameter)=0]"
			[Register ("getDescription", "()Ljava/lang/String;", "GetGetDescriptionHandler")]
			get {
				if (id_getDescription == IntPtr.Zero)
					id_getDescription = JNIEnv.GetMethodID (class_ref, "getDescription", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getDescription), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDescription", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getErrorCode;
#pragma warning disable 0169
		static Delegate GetGetErrorCodeHandler ()
		{
			if (cb_getErrorCode == null)
				cb_getErrorCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetErrorCode);
			return cb_getErrorCode;
		}

		static int n_GetErrorCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.Oauth.OAuth1FlowException __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Oauth.OAuth1FlowException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ErrorCode;
		}
#pragma warning restore 0169

		static IntPtr id_getErrorCode;
		public virtual int ErrorCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.oauth']/class[@name='OAuth1FlowException']/method[@name='getErrorCode' and count(parameter)=0]"
			[Register ("getErrorCode", "()I", "GetGetErrorCodeHandler")]
			get {
				if (id_getErrorCode == IntPtr.Zero)
					id_getErrorCode = JNIEnv.GetMethodID (class_ref, "getErrorCode", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getErrorCode);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getErrorCode", "()I"));
			}
		}

		static Delegate cb_getFailingUrl;
#pragma warning disable 0169
		static Delegate GetGetFailingUrlHandler ()
		{
			if (cb_getFailingUrl == null)
				cb_getFailingUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFailingUrl);
			return cb_getFailingUrl;
		}

		static IntPtr n_GetFailingUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.Oauth.OAuth1FlowException __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Oauth.OAuth1FlowException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.FailingUrl);
		}
#pragma warning restore 0169

		static IntPtr id_getFailingUrl;
		public virtual string FailingUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.oauth']/class[@name='OAuth1FlowException']/method[@name='getFailingUrl' and count(parameter)=0]"
			[Register ("getFailingUrl", "()Ljava/lang/String;", "GetGetFailingUrlHandler")]
			get {
				if (id_getFailingUrl == IntPtr.Zero)
					id_getFailingUrl = JNIEnv.GetMethodID (class_ref, "getFailingUrl", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getFailingUrl), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFailingUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
		}

	}
}
