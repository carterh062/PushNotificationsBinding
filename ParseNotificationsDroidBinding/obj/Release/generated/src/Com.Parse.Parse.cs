using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Parse {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.parse']/class[@name='Parse']"
	[global::Android.Runtime.Register ("com/parse/Parse", DoNotGenerateAcw=true)]
	public partial class Parse : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='Parse']/field[@name='LOG_LEVEL_DEBUG']"
		[Register ("LOG_LEVEL_DEBUG")]
		public const int LogLevelDebug = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='Parse']/field[@name='LOG_LEVEL_ERROR']"
		[Register ("LOG_LEVEL_ERROR")]
		public const int LogLevelError = (int) 6;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='Parse']/field[@name='LOG_LEVEL_INFO']"
		[Register ("LOG_LEVEL_INFO")]
		public const int LogLevelInfo = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='Parse']/field[@name='LOG_LEVEL_NONE']"
		[Register ("LOG_LEVEL_NONE")]
		public const int LogLevelNone = (int) 2147483647;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='Parse']/field[@name='LOG_LEVEL_VERBOSE']"
		[Register ("LOG_LEVEL_VERBOSE")]
		public const int LogLevelVerbose = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='Parse']/field[@name='LOG_LEVEL_WARNING']"
		[Register ("LOG_LEVEL_WARNING")]
		public const int LogLevelWarning = (int) 5;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/parse/Parse", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Parse); }
		}

		protected Parse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getLogLevel;
		static IntPtr id_setLogLevel_I;
		public static int LogLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='Parse']/method[@name='getLogLevel' and count(parameter)=0]"
			[Register ("getLogLevel", "()I", "GetGetLogLevelHandler")]
			get {
				if (id_getLogLevel == IntPtr.Zero)
					id_getLogLevel = JNIEnv.GetStaticMethodID (class_ref, "getLogLevel", "()I");
				return JNIEnv.CallStaticIntMethod  (class_ref, id_getLogLevel);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='Parse']/method[@name='setLogLevel' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setLogLevel", "(I)V", "GetSetLogLevel_IHandler")]
			set {
				if (id_setLogLevel_I == IntPtr.Zero)
					id_setLogLevel_I = JNIEnv.GetStaticMethodID (class_ref, "setLogLevel", "(I)V");
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setLogLevel_I, new JValue (value));
			}
		}

		static IntPtr id_initialize_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='Parse']/method[@name='initialize' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("initialize", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static void Initialize (global::Android.Content.Context p0, string p1, string p2)
		{
			if (id_initialize_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_initialize_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "initialize", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_initialize_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_, new JValue (p0), new JValue (native_p1), new JValue (native_p2));
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

	}
}
