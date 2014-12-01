using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Parse.Codec.Binary {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.parse.codec.binary']/class[@name='StringUtils']"
	[global::Android.Runtime.Register ("com/parse/codec/binary/StringUtils", DoNotGenerateAcw=true)]
	public partial class StringUtils : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/parse/codec/binary/StringUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (StringUtils); }
		}

		protected StringUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.parse.codec.binary']/class[@name='StringUtils']/constructor[@name='StringUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public StringUtils () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (StringUtils)) {
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

		static IntPtr id_getBytesIso8859_1_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.binary']/class[@name='StringUtils']/method[@name='getBytesIso8859_1' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getBytesIso8859_1", "(Ljava/lang/String;)[B", "")]
		public static byte[] GetBytesIso8859_1 (string p0)
		{
			if (id_getBytesIso8859_1_Ljava_lang_String_ == IntPtr.Zero)
				id_getBytesIso8859_1_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getBytesIso8859_1", "(Ljava/lang/String;)[B");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_getBytesIso8859_1_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef, typeof (byte));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_getBytesUnchecked_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.binary']/class[@name='StringUtils']/method[@name='getBytesUnchecked' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("getBytesUnchecked", "(Ljava/lang/String;Ljava/lang/String;)[B", "")]
		public static byte[] GetBytesUnchecked (string p0, string p1)
		{
			if (id_getBytesUnchecked_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_getBytesUnchecked_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getBytesUnchecked", "(Ljava/lang/String;Ljava/lang/String;)[B");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_getBytesUnchecked_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef, typeof (byte));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static IntPtr id_getBytesUsAscii_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.binary']/class[@name='StringUtils']/method[@name='getBytesUsAscii' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getBytesUsAscii", "(Ljava/lang/String;)[B", "")]
		public static byte[] GetBytesUsAscii (string p0)
		{
			if (id_getBytesUsAscii_Ljava_lang_String_ == IntPtr.Zero)
				id_getBytesUsAscii_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getBytesUsAscii", "(Ljava/lang/String;)[B");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_getBytesUsAscii_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef, typeof (byte));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_getBytesUtf16_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.binary']/class[@name='StringUtils']/method[@name='getBytesUtf16' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getBytesUtf16", "(Ljava/lang/String;)[B", "")]
		public static byte[] GetBytesUtf16 (string p0)
		{
			if (id_getBytesUtf16_Ljava_lang_String_ == IntPtr.Zero)
				id_getBytesUtf16_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getBytesUtf16", "(Ljava/lang/String;)[B");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_getBytesUtf16_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef, typeof (byte));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_getBytesUtf16Be_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.binary']/class[@name='StringUtils']/method[@name='getBytesUtf16Be' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getBytesUtf16Be", "(Ljava/lang/String;)[B", "")]
		public static byte[] GetBytesUtf16Be (string p0)
		{
			if (id_getBytesUtf16Be_Ljava_lang_String_ == IntPtr.Zero)
				id_getBytesUtf16Be_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getBytesUtf16Be", "(Ljava/lang/String;)[B");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_getBytesUtf16Be_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef, typeof (byte));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_getBytesUtf16Le_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.binary']/class[@name='StringUtils']/method[@name='getBytesUtf16Le' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getBytesUtf16Le", "(Ljava/lang/String;)[B", "")]
		public static byte[] GetBytesUtf16Le (string p0)
		{
			if (id_getBytesUtf16Le_Ljava_lang_String_ == IntPtr.Zero)
				id_getBytesUtf16Le_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getBytesUtf16Le", "(Ljava/lang/String;)[B");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_getBytesUtf16Le_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef, typeof (byte));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_getBytesUtf8_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.binary']/class[@name='StringUtils']/method[@name='getBytesUtf8' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getBytesUtf8", "(Ljava/lang/String;)[B", "")]
		public static byte[] GetBytesUtf8 (string p0)
		{
			if (id_getBytesUtf8_Ljava_lang_String_ == IntPtr.Zero)
				id_getBytesUtf8_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getBytesUtf8", "(Ljava/lang/String;)[B");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_getBytesUtf8_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef, typeof (byte));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_newString_arrayBLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.binary']/class[@name='StringUtils']/method[@name='newString' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='java.lang.String']]"
		[Register ("newString", "([BLjava/lang/String;)Ljava/lang/String;", "")]
		public static string NewString (byte[] p0, string p1)
		{
			if (id_newString_arrayBLjava_lang_String_ == IntPtr.Zero)
				id_newString_arrayBLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "newString", "([BLjava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_newString_arrayBLjava_lang_String_, new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static IntPtr id_newStringIso8859_1_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.binary']/class[@name='StringUtils']/method[@name='newStringIso8859_1' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("newStringIso8859_1", "([B)Ljava/lang/String;", "")]
		public static string NewStringIso8859_1 (byte[] p0)
		{
			if (id_newStringIso8859_1_arrayB == IntPtr.Zero)
				id_newStringIso8859_1_arrayB = JNIEnv.GetStaticMethodID (class_ref, "newStringIso8859_1", "([B)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_newStringIso8859_1_arrayB, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static IntPtr id_newStringUsAscii_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.binary']/class[@name='StringUtils']/method[@name='newStringUsAscii' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("newStringUsAscii", "([B)Ljava/lang/String;", "")]
		public static string NewStringUsAscii (byte[] p0)
		{
			if (id_newStringUsAscii_arrayB == IntPtr.Zero)
				id_newStringUsAscii_arrayB = JNIEnv.GetStaticMethodID (class_ref, "newStringUsAscii", "([B)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_newStringUsAscii_arrayB, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static IntPtr id_newStringUtf16_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.binary']/class[@name='StringUtils']/method[@name='newStringUtf16' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("newStringUtf16", "([B)Ljava/lang/String;", "")]
		public static string NewStringUtf16 (byte[] p0)
		{
			if (id_newStringUtf16_arrayB == IntPtr.Zero)
				id_newStringUtf16_arrayB = JNIEnv.GetStaticMethodID (class_ref, "newStringUtf16", "([B)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_newStringUtf16_arrayB, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static IntPtr id_newStringUtf16Be_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.binary']/class[@name='StringUtils']/method[@name='newStringUtf16Be' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("newStringUtf16Be", "([B)Ljava/lang/String;", "")]
		public static string NewStringUtf16Be (byte[] p0)
		{
			if (id_newStringUtf16Be_arrayB == IntPtr.Zero)
				id_newStringUtf16Be_arrayB = JNIEnv.GetStaticMethodID (class_ref, "newStringUtf16Be", "([B)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_newStringUtf16Be_arrayB, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static IntPtr id_newStringUtf16Le_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.binary']/class[@name='StringUtils']/method[@name='newStringUtf16Le' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("newStringUtf16Le", "([B)Ljava/lang/String;", "")]
		public static string NewStringUtf16Le (byte[] p0)
		{
			if (id_newStringUtf16Le_arrayB == IntPtr.Zero)
				id_newStringUtf16Le_arrayB = JNIEnv.GetStaticMethodID (class_ref, "newStringUtf16Le", "([B)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_newStringUtf16Le_arrayB, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static IntPtr id_newStringUtf8_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.binary']/class[@name='StringUtils']/method[@name='newStringUtf8' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("newStringUtf8", "([B)Ljava/lang/String;", "")]
		public static string NewStringUtf8 (byte[] p0)
		{
			if (id_newStringUtf8_arrayB == IntPtr.Zero)
				id_newStringUtf8_arrayB = JNIEnv.GetStaticMethodID (class_ref, "newStringUtf8", "([B)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_newStringUtf8_arrayB, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

	}
}
