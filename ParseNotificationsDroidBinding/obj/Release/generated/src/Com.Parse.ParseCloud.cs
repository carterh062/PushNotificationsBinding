using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Parse {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.parse']/class[@name='ParseCloud']"
	[global::Android.Runtime.Register ("com/parse/ParseCloud", DoNotGenerateAcw=true)]
	public partial class ParseCloud : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/parse/ParseCloud", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ParseCloud); }
		}

		protected ParseCloud (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.parse']/class[@name='ParseCloud']/constructor[@name='ParseCloud' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public ParseCloud () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ParseCloud)) {
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

		static IntPtr id_callFunction_Ljava_lang_String_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseCloud']/method[@name='callFunction' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Map']]"
		[Register ("callFunction", "(Ljava/lang/String;Ljava/util/Map;)Ljava/lang/Object;", "")]
		public static global::Java.Lang.Object CallFunction (string p0, global::System.Collections.Generic.IDictionary<string, object> p1)
		{
			if (id_callFunction_Ljava_lang_String_Ljava_util_Map_ == IntPtr.Zero)
				id_callFunction_Ljava_lang_String_Ljava_util_Map_ = JNIEnv.GetStaticMethodID (class_ref, "callFunction", "(Ljava/lang/String;Ljava/util/Map;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, object>.ToLocalJniHandle (p1);
			global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_callFunction_Ljava_lang_String_Ljava_util_Map_, new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static IntPtr id_callFunctionInBackground_Ljava_lang_String_Ljava_util_Map_Lcom_parse_FunctionCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseCloud']/method[@name='callFunctionInBackground' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Map'] and parameter[3][@type='com.parse.FunctionCallback']]"
		[Register ("callFunctionInBackground", "(Ljava/lang/String;Ljava/util/Map;Lcom/parse/FunctionCallback;)V", "")]
		public static void CallFunctionInBackground (string p0, global::System.Collections.Generic.IDictionary<string, object> p1, global::Com.Parse.FunctionCallback p2)
		{
			if (id_callFunctionInBackground_Ljava_lang_String_Ljava_util_Map_Lcom_parse_FunctionCallback_ == IntPtr.Zero)
				id_callFunctionInBackground_Ljava_lang_String_Ljava_util_Map_Lcom_parse_FunctionCallback_ = JNIEnv.GetStaticMethodID (class_ref, "callFunctionInBackground", "(Ljava/lang/String;Ljava/util/Map;Lcom/parse/FunctionCallback;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, object>.ToLocalJniHandle (p1);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_callFunctionInBackground_Ljava_lang_String_Ljava_util_Map_Lcom_parse_FunctionCallback_, new JValue (native_p0), new JValue (native_p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

	}
}
