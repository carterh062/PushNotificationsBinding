using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Parse {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.parse']/class[@name='ParseTwitterUtils']"
	[global::Android.Runtime.Register ("com/parse/ParseTwitterUtils", DoNotGenerateAcw=true)]
	public sealed partial class ParseTwitterUtils : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/parse/ParseTwitterUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ParseTwitterUtils); }
		}

		internal ParseTwitterUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getTwitter;
		public static global::Com.Parse.Twitter.Twitter Twitter {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseTwitterUtils']/method[@name='getTwitter' and count(parameter)=0]"
			[Register ("getTwitter", "()Lcom/parse/twitter/Twitter;", "GetGetTwitterHandler")]
			get {
				if (id_getTwitter == IntPtr.Zero)
					id_getTwitter = JNIEnv.GetStaticMethodID (class_ref, "getTwitter", "()Lcom/parse/twitter/Twitter;");
				return global::Java.Lang.Object.GetObject<global::Com.Parse.Twitter.Twitter> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getTwitter), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_initialize_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseTwitterUtils']/method[@name='initialize' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("initialize", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static void Initialize (string p0, string p1)
		{
			if (id_initialize_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_initialize_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "initialize", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_initialize_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_isLinked_Lcom_parse_ParseUser_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseTwitterUtils']/method[@name='isLinked' and count(parameter)=1 and parameter[1][@type='com.parse.ParseUser']]"
		[Register ("isLinked", "(Lcom/parse/ParseUser;)Z", "")]
		public static bool IsLinked (global::Com.Parse.ParseUser p0)
		{
			if (id_isLinked_Lcom_parse_ParseUser_ == IntPtr.Zero)
				id_isLinked_Lcom_parse_ParseUser_ = JNIEnv.GetStaticMethodID (class_ref, "isLinked", "(Lcom/parse/ParseUser;)Z");
			bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isLinked_Lcom_parse_ParseUser_, new JValue (p0));
			return __ret;
		}

		static IntPtr id_link_Lcom_parse_ParseUser_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseTwitterUtils']/method[@name='link' and count(parameter)=2 and parameter[1][@type='com.parse.ParseUser'] and parameter[2][@type='android.content.Context']]"
		[Register ("link", "(Lcom/parse/ParseUser;Landroid/content/Context;)V", "")]
		public static void Link (global::Com.Parse.ParseUser p0, global::Android.Content.Context p1)
		{
			if (id_link_Lcom_parse_ParseUser_Landroid_content_Context_ == IntPtr.Zero)
				id_link_Lcom_parse_ParseUser_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "link", "(Lcom/parse/ParseUser;Landroid/content/Context;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_link_Lcom_parse_ParseUser_Landroid_content_Context_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_link_Lcom_parse_ParseUser_Landroid_content_Context_Lcom_parse_SaveCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseTwitterUtils']/method[@name='link' and count(parameter)=3 and parameter[1][@type='com.parse.ParseUser'] and parameter[2][@type='android.content.Context'] and parameter[3][@type='com.parse.SaveCallback']]"
		[Register ("link", "(Lcom/parse/ParseUser;Landroid/content/Context;Lcom/parse/SaveCallback;)V", "")]
		public static void Link (global::Com.Parse.ParseUser p0, global::Android.Content.Context p1, global::Com.Parse.SaveCallback p2)
		{
			if (id_link_Lcom_parse_ParseUser_Landroid_content_Context_Lcom_parse_SaveCallback_ == IntPtr.Zero)
				id_link_Lcom_parse_ParseUser_Landroid_content_Context_Lcom_parse_SaveCallback_ = JNIEnv.GetStaticMethodID (class_ref, "link", "(Lcom/parse/ParseUser;Landroid/content/Context;Lcom/parse/SaveCallback;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_link_Lcom_parse_ParseUser_Landroid_content_Context_Lcom_parse_SaveCallback_, new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static IntPtr id_link_Lcom_parse_ParseUser_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseTwitterUtils']/method[@name='link' and count(parameter)=5 and parameter[1][@type='com.parse.ParseUser'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String']]"
		[Register ("link", "(Lcom/parse/ParseUser;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static void Link (global::Com.Parse.ParseUser p0, string p1, string p2, string p3, string p4)
		{
			if (id_link_Lcom_parse_ParseUser_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_link_Lcom_parse_ParseUser_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "link", "(Lcom/parse/ParseUser;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_link_Lcom_parse_ParseUser_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, new JValue (p0), new JValue (native_p1), new JValue (native_p2), new JValue (native_p3), new JValue (native_p4));
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			JNIEnv.DeleteLocalRef (native_p3);
			JNIEnv.DeleteLocalRef (native_p4);
		}

		static IntPtr id_link_Lcom_parse_ParseUser_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_parse_SaveCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseTwitterUtils']/method[@name='link' and count(parameter)=6 and parameter[1][@type='com.parse.ParseUser'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='com.parse.SaveCallback']]"
		[Register ("link", "(Lcom/parse/ParseUser;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/parse/SaveCallback;)V", "")]
		public static void Link (global::Com.Parse.ParseUser p0, string p1, string p2, string p3, string p4, global::Com.Parse.SaveCallback p5)
		{
			if (id_link_Lcom_parse_ParseUser_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_parse_SaveCallback_ == IntPtr.Zero)
				id_link_Lcom_parse_ParseUser_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_parse_SaveCallback_ = JNIEnv.GetStaticMethodID (class_ref, "link", "(Lcom/parse/ParseUser;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/parse/SaveCallback;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_link_Lcom_parse_ParseUser_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_parse_SaveCallback_, new JValue (p0), new JValue (native_p1), new JValue (native_p2), new JValue (native_p3), new JValue (native_p4), new JValue (p5));
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			JNIEnv.DeleteLocalRef (native_p3);
			JNIEnv.DeleteLocalRef (native_p4);
		}

		static IntPtr id_logIn_Landroid_content_Context_Lcom_parse_LogInCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseTwitterUtils']/method[@name='logIn' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.parse.LogInCallback']]"
		[Register ("logIn", "(Landroid/content/Context;Lcom/parse/LogInCallback;)V", "")]
		public static void LogIn (global::Android.Content.Context p0, global::Com.Parse.LogInCallback p1)
		{
			if (id_logIn_Landroid_content_Context_Lcom_parse_LogInCallback_ == IntPtr.Zero)
				id_logIn_Landroid_content_Context_Lcom_parse_LogInCallback_ = JNIEnv.GetStaticMethodID (class_ref, "logIn", "(Landroid/content/Context;Lcom/parse/LogInCallback;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_logIn_Landroid_content_Context_Lcom_parse_LogInCallback_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_logIn_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_parse_LogInCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseTwitterUtils']/method[@name='logIn' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='com.parse.LogInCallback']]"
		[Register ("logIn", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/parse/LogInCallback;)V", "")]
		public static void LogIn (string p0, string p1, string p2, string p3, global::Com.Parse.LogInCallback p4)
		{
			if (id_logIn_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_parse_LogInCallback_ == IntPtr.Zero)
				id_logIn_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_parse_LogInCallback_ = JNIEnv.GetStaticMethodID (class_ref, "logIn", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/parse/LogInCallback;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_logIn_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_parse_LogInCallback_, new JValue (native_p0), new JValue (native_p1), new JValue (native_p2), new JValue (native_p3), new JValue (p4));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			JNIEnv.DeleteLocalRef (native_p3);
		}

		static IntPtr id_unlink_Lcom_parse_ParseUser_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseTwitterUtils']/method[@name='unlink' and count(parameter)=1 and parameter[1][@type='com.parse.ParseUser']]"
		[Register ("unlink", "(Lcom/parse/ParseUser;)V", "")]
		public static void Unlink (global::Com.Parse.ParseUser p0)
		{
			if (id_unlink_Lcom_parse_ParseUser_ == IntPtr.Zero)
				id_unlink_Lcom_parse_ParseUser_ = JNIEnv.GetStaticMethodID (class_ref, "unlink", "(Lcom/parse/ParseUser;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_unlink_Lcom_parse_ParseUser_, new JValue (p0));
		}

		static IntPtr id_unlinkInBackground_Lcom_parse_ParseUser_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseTwitterUtils']/method[@name='unlinkInBackground' and count(parameter)=1 and parameter[1][@type='com.parse.ParseUser']]"
		[Register ("unlinkInBackground", "(Lcom/parse/ParseUser;)V", "")]
		public static void UnlinkInBackground (global::Com.Parse.ParseUser p0)
		{
			if (id_unlinkInBackground_Lcom_parse_ParseUser_ == IntPtr.Zero)
				id_unlinkInBackground_Lcom_parse_ParseUser_ = JNIEnv.GetStaticMethodID (class_ref, "unlinkInBackground", "(Lcom/parse/ParseUser;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_unlinkInBackground_Lcom_parse_ParseUser_, new JValue (p0));
		}

		static IntPtr id_unlinkInBackground_Lcom_parse_ParseUser_Lcom_parse_SaveCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseTwitterUtils']/method[@name='unlinkInBackground' and count(parameter)=2 and parameter[1][@type='com.parse.ParseUser'] and parameter[2][@type='com.parse.SaveCallback']]"
		[Register ("unlinkInBackground", "(Lcom/parse/ParseUser;Lcom/parse/SaveCallback;)V", "")]
		public static void UnlinkInBackground (global::Com.Parse.ParseUser p0, global::Com.Parse.SaveCallback p1)
		{
			if (id_unlinkInBackground_Lcom_parse_ParseUser_Lcom_parse_SaveCallback_ == IntPtr.Zero)
				id_unlinkInBackground_Lcom_parse_ParseUser_Lcom_parse_SaveCallback_ = JNIEnv.GetStaticMethodID (class_ref, "unlinkInBackground", "(Lcom/parse/ParseUser;Lcom/parse/SaveCallback;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_unlinkInBackground_Lcom_parse_ParseUser_Lcom_parse_SaveCallback_, new JValue (p0), new JValue (p1));
		}

	}
}
