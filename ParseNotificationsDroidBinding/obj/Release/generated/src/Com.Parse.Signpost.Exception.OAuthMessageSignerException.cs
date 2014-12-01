using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Parse.Signpost.Exception {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.parse.signpost.exception']/class[@name='OAuthMessageSignerException']"
	[global::Android.Runtime.Register ("com/parse/signpost/exception/OAuthMessageSignerException", DoNotGenerateAcw=true)]
	public partial class OAuthMessageSignerException : global::Com.Parse.Signpost.Exception.OAuthException {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/parse/signpost/exception/OAuthMessageSignerException", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (OAuthMessageSignerException); }
		}

		protected OAuthMessageSignerException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.parse.signpost.exception']/class[@name='OAuthMessageSignerException']/constructor[@name='OAuthMessageSignerException' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public OAuthMessageSignerException (string p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);;
			if (GetType () != typeof (OAuthMessageSignerException)) {
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

		static IntPtr id_ctor_Ljava_lang_Exception_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.parse.signpost.exception']/class[@name='OAuthMessageSignerException']/constructor[@name='OAuthMessageSignerException' and count(parameter)=1 and parameter[1][@type='java.lang.Exception']]"
		[Register (".ctor", "(Ljava/lang/Exception;)V", "")]
		public OAuthMessageSignerException (global::Java.Lang.Exception p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (OAuthMessageSignerException)) {
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

	}
}
