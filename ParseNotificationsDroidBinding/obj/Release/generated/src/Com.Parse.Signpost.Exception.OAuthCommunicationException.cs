using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Parse.Signpost.Exception {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.parse.signpost.exception']/class[@name='OAuthCommunicationException']"
	[global::Android.Runtime.Register ("com/parse/signpost/exception/OAuthCommunicationException", DoNotGenerateAcw=true)]
	public partial class OAuthCommunicationException : global::Com.Parse.Signpost.Exception.OAuthException {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/parse/signpost/exception/OAuthCommunicationException", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (OAuthCommunicationException); }
		}

		protected OAuthCommunicationException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_Exception_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.parse.signpost.exception']/class[@name='OAuthCommunicationException']/constructor[@name='OAuthCommunicationException' and count(parameter)=1 and parameter[1][@type='java.lang.Exception']]"
		[Register (".ctor", "(Ljava/lang/Exception;)V", "")]
		public OAuthCommunicationException (global::Java.Lang.Exception p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (OAuthCommunicationException)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/Exception;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/Exception;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Ljava_lang_Exception_ == IntPtr.Zero)
				id_ctor_Ljava_lang_Exception_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/Exception;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_Exception_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_Exception_, new JValue (p0));
		}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.parse.signpost.exception']/class[@name='OAuthCommunicationException']/constructor[@name='OAuthCommunicationException' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public OAuthCommunicationException (string p0, string p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);;
			IntPtr native_p1 = JNIEnv.NewString (p1);;
			if (GetType () != typeof (OAuthCommunicationException)) {
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
			global::Com.Parse.Signpost.Exception.OAuthCommunicationException __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.Exception.OAuthCommunicationException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ResponseBody);
		}
#pragma warning restore 0169

		static IntPtr id_getResponseBody;
		public virtual string ResponseBody {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.signpost.exception']/class[@name='OAuthCommunicationException']/method[@name='getResponseBody' and count(parameter)=0]"
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
