using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Parse.Signpost.Exception {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.parse.signpost.exception']/class[@name='OAuthNotAuthorizedException']"
	[global::Android.Runtime.Register ("com/parse/signpost/exception/OAuthNotAuthorizedException", DoNotGenerateAcw=true)]
	public partial class OAuthNotAuthorizedException : global::Com.Parse.Signpost.Exception.OAuthException {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/parse/signpost/exception/OAuthNotAuthorizedException", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (OAuthNotAuthorizedException); }
		}

		protected OAuthNotAuthorizedException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.parse.signpost.exception']/class[@name='OAuthNotAuthorizedException']/constructor[@name='OAuthNotAuthorizedException' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public OAuthNotAuthorizedException () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (OAuthNotAuthorizedException)) {
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

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.parse.signpost.exception']/class[@name='OAuthNotAuthorizedException']/constructor[@name='OAuthNotAuthorizedException' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public OAuthNotAuthorizedException (string p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);;
			if (GetType () != typeof (OAuthNotAuthorizedException)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;)V", new JValue (native_p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;)V", new JValue (native_p0));
				JNIEnv.DeleteLocalRef (native_p0);
				return;
			}

			if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
				id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_, new JValue (native_p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_getResponseBody;
#pragma warning disable 0169
		static Delegate GetGetResponseBodyHandler ()
		{
			if (cb_getResponseBody == null)
				cb_getResponseBody = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetResponseBody);
			return cb_getResponseBody;
		}

		static IntPtr n_GetResponseBody (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.Signpost.Exception.OAuthNotAuthorizedException __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.Exception.OAuthNotAuthorizedException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ResponseBody);
		}
#pragma warning restore 0169

		static IntPtr id_getResponseBody;
		public virtual string ResponseBody {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.signpost.exception']/class[@name='OAuthNotAuthorizedException']/method[@name='getResponseBody' and count(parameter)=0]"
			[Register ("getResponseBody", "()Ljava/lang/String;", "GetGetResponseBodyHandler")]
			get {
				if (id_getResponseBody == IntPtr.Zero)
					id_getResponseBody = JNIEnv.GetMethodID (class_ref, "getResponseBody", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getResponseBody), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getResponseBody", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
		}

	}
}
