using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Parse {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.parse']/class[@name='ParseAnonymousUtils']"
	[global::Android.Runtime.Register ("com/parse/ParseAnonymousUtils", DoNotGenerateAcw=true)]
	public sealed partial class ParseAnonymousUtils : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/parse/ParseAnonymousUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ParseAnonymousUtils); }
		}

		internal ParseAnonymousUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_isLinked_Lcom_parse_ParseUser_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseAnonymousUtils']/method[@name='isLinked' and count(parameter)=1 and parameter[1][@type='com.parse.ParseUser']]"
		[Register ("isLinked", "(Lcom/parse/ParseUser;)Z", "")]
		public static bool IsLinked (global::Com.Parse.ParseUser p0)
		{
			if (id_isLinked_Lcom_parse_ParseUser_ == IntPtr.Zero)
				id_isLinked_Lcom_parse_ParseUser_ = JNIEnv.GetStaticMethodID (class_ref, "isLinked", "(Lcom/parse/ParseUser;)Z");
			bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isLinked_Lcom_parse_ParseUser_, new JValue (p0));
			return __ret;
		}

		static IntPtr id_logIn_Lcom_parse_LogInCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseAnonymousUtils']/method[@name='logIn' and count(parameter)=1 and parameter[1][@type='com.parse.LogInCallback']]"
		[Register ("logIn", "(Lcom/parse/LogInCallback;)V", "")]
		public static void LogIn (global::Com.Parse.LogInCallback p0)
		{
			if (id_logIn_Lcom_parse_LogInCallback_ == IntPtr.Zero)
				id_logIn_Lcom_parse_LogInCallback_ = JNIEnv.GetStaticMethodID (class_ref, "logIn", "(Lcom/parse/LogInCallback;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_logIn_Lcom_parse_LogInCallback_, new JValue (p0));
		}

	}
}
