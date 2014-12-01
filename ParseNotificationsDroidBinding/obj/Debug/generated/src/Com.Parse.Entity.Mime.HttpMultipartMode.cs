using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Parse.Entity.Mime {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.parse.entity.mime']/class[@name='HttpMultipartMode']"
	[global::Android.Runtime.Register ("com/parse/entity/mime/HttpMultipartMode", DoNotGenerateAcw=true)]
	public sealed partial class HttpMultipartMode : global::Java.Lang.Enum {


		static IntPtr BROWSER_COMPATIBLE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.parse.entity.mime']/class[@name='HttpMultipartMode']/field[@name='BROWSER_COMPATIBLE']"
		[Register ("BROWSER_COMPATIBLE")]
		public static global::Com.Parse.Entity.Mime.HttpMultipartMode BrowserCompatible {
			get {
				if (BROWSER_COMPATIBLE_jfieldId == IntPtr.Zero)
					BROWSER_COMPATIBLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BROWSER_COMPATIBLE", "Lcom/parse/entity/mime/HttpMultipartMode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BROWSER_COMPATIBLE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Parse.Entity.Mime.HttpMultipartMode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (BROWSER_COMPATIBLE_jfieldId == IntPtr.Zero)
					BROWSER_COMPATIBLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BROWSER_COMPATIBLE", "Lcom/parse/entity/mime/HttpMultipartMode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, BROWSER_COMPATIBLE_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr STRICT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.parse.entity.mime']/class[@name='HttpMultipartMode']/field[@name='STRICT']"
		[Register ("STRICT")]
		public static global::Com.Parse.Entity.Mime.HttpMultipartMode Strict {
			get {
				if (STRICT_jfieldId == IntPtr.Zero)
					STRICT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "STRICT", "Lcom/parse/entity/mime/HttpMultipartMode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, STRICT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Parse.Entity.Mime.HttpMultipartMode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (STRICT_jfieldId == IntPtr.Zero)
					STRICT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "STRICT", "Lcom/parse/entity/mime/HttpMultipartMode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, STRICT_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/parse/entity/mime/HttpMultipartMode", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HttpMultipartMode); }
		}

		internal HttpMultipartMode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.entity.mime']/class[@name='HttpMultipartMode']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/parse/entity/mime/HttpMultipartMode;", "")]
		public static global::Com.Parse.Entity.Mime.HttpMultipartMode ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/parse/entity/mime/HttpMultipartMode;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Com.Parse.Entity.Mime.HttpMultipartMode __ret = global::Java.Lang.Object.GetObject<global::Com.Parse.Entity.Mime.HttpMultipartMode> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.entity.mime']/class[@name='HttpMultipartMode']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/parse/entity/mime/HttpMultipartMode;", "")]
		public static global::Com.Parse.Entity.Mime.HttpMultipartMode[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/parse/entity/mime/HttpMultipartMode;");
			return (global::Com.Parse.Entity.Mime.HttpMultipartMode[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Parse.Entity.Mime.HttpMultipartMode));
		}

	}
}
