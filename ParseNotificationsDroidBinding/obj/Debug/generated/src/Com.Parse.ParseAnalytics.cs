using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Parse {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.parse']/class[@name='ParseAnalytics']"
	[global::Android.Runtime.Register ("com/parse/ParseAnalytics", DoNotGenerateAcw=true)]
	public partial class ParseAnalytics : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/parse/ParseAnalytics", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ParseAnalytics); }
		}

		protected ParseAnalytics (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.parse']/class[@name='ParseAnalytics']/constructor[@name='ParseAnalytics' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public ParseAnalytics () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ParseAnalytics)) {
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

		static IntPtr id_trackAppOpened_Landroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseAnalytics']/method[@name='trackAppOpened' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
		[Register ("trackAppOpened", "(Landroid/content/Intent;)V", "")]
		public static void TrackAppOpened (global::Android.Content.Intent p0)
		{
			if (id_trackAppOpened_Landroid_content_Intent_ == IntPtr.Zero)
				id_trackAppOpened_Landroid_content_Intent_ = JNIEnv.GetStaticMethodID (class_ref, "trackAppOpened", "(Landroid/content/Intent;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_trackAppOpened_Landroid_content_Intent_, new JValue (p0));
		}

		static IntPtr id_trackEvent_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseAnalytics']/method[@name='trackEvent' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("trackEvent", "(Ljava/lang/String;)V", "")]
		public static void TrackEvent (string p0)
		{
			if (id_trackEvent_Ljava_lang_String_ == IntPtr.Zero)
				id_trackEvent_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "trackEvent", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_trackEvent_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_trackEvent_Ljava_lang_String_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseAnalytics']/method[@name='trackEvent' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Map']]"
		[Register ("trackEvent", "(Ljava/lang/String;Ljava/util/Map;)V", "")]
		public static void TrackEvent (string p0, global::System.Collections.Generic.IDictionary<string, string> p1)
		{
			if (id_trackEvent_Ljava_lang_String_Ljava_util_Map_ == IntPtr.Zero)
				id_trackEvent_Ljava_lang_String_Ljava_util_Map_ = JNIEnv.GetStaticMethodID (class_ref, "trackEvent", "(Ljava/lang/String;Ljava/util/Map;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p1);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_trackEvent_Ljava_lang_String_Ljava_util_Map_, new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

	}
}
