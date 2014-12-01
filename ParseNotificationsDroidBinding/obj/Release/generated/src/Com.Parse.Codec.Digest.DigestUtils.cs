using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Parse.Codec.Digest {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.parse.codec.digest']/class[@name='DigestUtils']"
	[global::Android.Runtime.Register ("com/parse/codec/digest/DigestUtils", DoNotGenerateAcw=true)]
	public partial class DigestUtils : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/parse/codec/digest/DigestUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DigestUtils); }
		}

		protected DigestUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.parse.codec.digest']/class[@name='DigestUtils']/constructor[@name='DigestUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public DigestUtils () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (DigestUtils)) {
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

		static IntPtr id_md5_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.digest']/class[@name='DigestUtils']/method[@name='md5' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("md5", "([B)[B", "")]
		public static byte[] Md5 (byte[] p0)
		{
			if (id_md5_arrayB == IntPtr.Zero)
				id_md5_arrayB = JNIEnv.GetStaticMethodID (class_ref, "md5", "([B)[B");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_md5_arrayB, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef, typeof (byte));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static IntPtr id_md5_Ljava_io_InputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.digest']/class[@name='DigestUtils']/method[@name='md5' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("md5", "(Ljava/io/InputStream;)[B", "")]
		public static byte[] Md5 (global::System.IO.Stream p0)
		{
			if (id_md5_Ljava_io_InputStream_ == IntPtr.Zero)
				id_md5_Ljava_io_InputStream_ = JNIEnv.GetStaticMethodID (class_ref, "md5", "(Ljava/io/InputStream;)[B");
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_md5_Ljava_io_InputStream_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef, typeof (byte));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_md5_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.digest']/class[@name='DigestUtils']/method[@name='md5' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("md5", "(Ljava/lang/String;)[B", "")]
		public static byte[] Md5 (string p0)
		{
			if (id_md5_Ljava_lang_String_ == IntPtr.Zero)
				id_md5_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "md5", "(Ljava/lang/String;)[B");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_md5_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef, typeof (byte));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_md5Hex_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.digest']/class[@name='DigestUtils']/method[@name='md5Hex' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("md5Hex", "([B)Ljava/lang/String;", "")]
		public static string Md5Hex (byte[] p0)
		{
			if (id_md5Hex_arrayB == IntPtr.Zero)
				id_md5Hex_arrayB = JNIEnv.GetStaticMethodID (class_ref, "md5Hex", "([B)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_md5Hex_arrayB, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static IntPtr id_md5Hex_Ljava_io_InputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.digest']/class[@name='DigestUtils']/method[@name='md5Hex' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("md5Hex", "(Ljava/io/InputStream;)Ljava/lang/String;", "")]
		public static string Md5Hex (global::System.IO.Stream p0)
		{
			if (id_md5Hex_Ljava_io_InputStream_ == IntPtr.Zero)
				id_md5Hex_Ljava_io_InputStream_ = JNIEnv.GetStaticMethodID (class_ref, "md5Hex", "(Ljava/io/InputStream;)Ljava/lang/String;");
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_md5Hex_Ljava_io_InputStream_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_md5Hex_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.digest']/class[@name='DigestUtils']/method[@name='md5Hex' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("md5Hex", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static string Md5Hex (string p0)
		{
			if (id_md5Hex_Ljava_lang_String_ == IntPtr.Zero)
				id_md5Hex_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "md5Hex", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_md5Hex_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_sha256_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.digest']/class[@name='DigestUtils']/method[@name='sha256' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("sha256", "([B)[B", "")]
		public static byte[] Sha256 (byte[] p0)
		{
			if (id_sha256_arrayB == IntPtr.Zero)
				id_sha256_arrayB = JNIEnv.GetStaticMethodID (class_ref, "sha256", "([B)[B");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_sha256_arrayB, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef, typeof (byte));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static IntPtr id_sha256_Ljava_io_InputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.digest']/class[@name='DigestUtils']/method[@name='sha256' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("sha256", "(Ljava/io/InputStream;)[B", "")]
		public static byte[] Sha256 (global::System.IO.Stream p0)
		{
			if (id_sha256_Ljava_io_InputStream_ == IntPtr.Zero)
				id_sha256_Ljava_io_InputStream_ = JNIEnv.GetStaticMethodID (class_ref, "sha256", "(Ljava/io/InputStream;)[B");
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_sha256_Ljava_io_InputStream_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef, typeof (byte));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_sha256_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.digest']/class[@name='DigestUtils']/method[@name='sha256' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("sha256", "(Ljava/lang/String;)[B", "")]
		public static byte[] Sha256 (string p0)
		{
			if (id_sha256_Ljava_lang_String_ == IntPtr.Zero)
				id_sha256_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "sha256", "(Ljava/lang/String;)[B");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_sha256_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef, typeof (byte));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_sha256Hex_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.digest']/class[@name='DigestUtils']/method[@name='sha256Hex' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("sha256Hex", "([B)Ljava/lang/String;", "")]
		public static string Sha256Hex (byte[] p0)
		{
			if (id_sha256Hex_arrayB == IntPtr.Zero)
				id_sha256Hex_arrayB = JNIEnv.GetStaticMethodID (class_ref, "sha256Hex", "([B)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_sha256Hex_arrayB, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static IntPtr id_sha256Hex_Ljava_io_InputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.digest']/class[@name='DigestUtils']/method[@name='sha256Hex' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("sha256Hex", "(Ljava/io/InputStream;)Ljava/lang/String;", "")]
		public static string Sha256Hex (global::System.IO.Stream p0)
		{
			if (id_sha256Hex_Ljava_io_InputStream_ == IntPtr.Zero)
				id_sha256Hex_Ljava_io_InputStream_ = JNIEnv.GetStaticMethodID (class_ref, "sha256Hex", "(Ljava/io/InputStream;)Ljava/lang/String;");
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_sha256Hex_Ljava_io_InputStream_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_sha256Hex_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.digest']/class[@name='DigestUtils']/method[@name='sha256Hex' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("sha256Hex", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static string Sha256Hex (string p0)
		{
			if (id_sha256Hex_Ljava_lang_String_ == IntPtr.Zero)
				id_sha256Hex_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "sha256Hex", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_sha256Hex_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_sha384_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.digest']/class[@name='DigestUtils']/method[@name='sha384' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("sha384", "([B)[B", "")]
		public static byte[] Sha384 (byte[] p0)
		{
			if (id_sha384_arrayB == IntPtr.Zero)
				id_sha384_arrayB = JNIEnv.GetStaticMethodID (class_ref, "sha384", "([B)[B");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_sha384_arrayB, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef, typeof (byte));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static IntPtr id_sha384_Ljava_io_InputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.digest']/class[@name='DigestUtils']/method[@name='sha384' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("sha384", "(Ljava/io/InputStream;)[B", "")]
		public static byte[] Sha384 (global::System.IO.Stream p0)
		{
			if (id_sha384_Ljava_io_InputStream_ == IntPtr.Zero)
				id_sha384_Ljava_io_InputStream_ = JNIEnv.GetStaticMethodID (class_ref, "sha384", "(Ljava/io/InputStream;)[B");
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_sha384_Ljava_io_InputStream_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef, typeof (byte));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_sha384_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.digest']/class[@name='DigestUtils']/method[@name='sha384' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("sha384", "(Ljava/lang/String;)[B", "")]
		public static byte[] Sha384 (string p0)
		{
			if (id_sha384_Ljava_lang_String_ == IntPtr.Zero)
				id_sha384_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "sha384", "(Ljava/lang/String;)[B");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_sha384_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef, typeof (byte));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_sha384Hex_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.digest']/class[@name='DigestUtils']/method[@name='sha384Hex' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("sha384Hex", "([B)Ljava/lang/String;", "")]
		public static string Sha384Hex (byte[] p0)
		{
			if (id_sha384Hex_arrayB == IntPtr.Zero)
				id_sha384Hex_arrayB = JNIEnv.GetStaticMethodID (class_ref, "sha384Hex", "([B)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_sha384Hex_arrayB, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static IntPtr id_sha384Hex_Ljava_io_InputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.digest']/class[@name='DigestUtils']/method[@name='sha384Hex' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("sha384Hex", "(Ljava/io/InputStream;)Ljava/lang/String;", "")]
		public static string Sha384Hex (global::System.IO.Stream p0)
		{
			if (id_sha384Hex_Ljava_io_InputStream_ == IntPtr.Zero)
				id_sha384Hex_Ljava_io_InputStream_ = JNIEnv.GetStaticMethodID (class_ref, "sha384Hex", "(Ljava/io/InputStream;)Ljava/lang/String;");
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_sha384Hex_Ljava_io_InputStream_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_sha384Hex_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.digest']/class[@name='DigestUtils']/method[@name='sha384Hex' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("sha384Hex", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static string Sha384Hex (string p0)
		{
			if (id_sha384Hex_Ljava_lang_String_ == IntPtr.Zero)
				id_sha384Hex_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "sha384Hex", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_sha384Hex_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_sha512_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.digest']/class[@name='DigestUtils']/method[@name='sha512' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("sha512", "([B)[B", "")]
		public static byte[] Sha512 (byte[] p0)
		{
			if (id_sha512_arrayB == IntPtr.Zero)
				id_sha512_arrayB = JNIEnv.GetStaticMethodID (class_ref, "sha512", "([B)[B");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_sha512_arrayB, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef, typeof (byte));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static IntPtr id_sha512_Ljava_io_InputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.digest']/class[@name='DigestUtils']/method[@name='sha512' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("sha512", "(Ljava/io/InputStream;)[B", "")]
		public static byte[] Sha512 (global::System.IO.Stream p0)
		{
			if (id_sha512_Ljava_io_InputStream_ == IntPtr.Zero)
				id_sha512_Ljava_io_InputStream_ = JNIEnv.GetStaticMethodID (class_ref, "sha512", "(Ljava/io/InputStream;)[B");
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_sha512_Ljava_io_InputStream_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef, typeof (byte));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_sha512_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.digest']/class[@name='DigestUtils']/method[@name='sha512' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("sha512", "(Ljava/lang/String;)[B", "")]
		public static byte[] Sha512 (string p0)
		{
			if (id_sha512_Ljava_lang_String_ == IntPtr.Zero)
				id_sha512_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "sha512", "(Ljava/lang/String;)[B");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_sha512_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef, typeof (byte));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_sha512Hex_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.digest']/class[@name='DigestUtils']/method[@name='sha512Hex' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("sha512Hex", "([B)Ljava/lang/String;", "")]
		public static string Sha512Hex (byte[] p0)
		{
			if (id_sha512Hex_arrayB == IntPtr.Zero)
				id_sha512Hex_arrayB = JNIEnv.GetStaticMethodID (class_ref, "sha512Hex", "([B)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_sha512Hex_arrayB, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static IntPtr id_sha512Hex_Ljava_io_InputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.digest']/class[@name='DigestUtils']/method[@name='sha512Hex' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("sha512Hex", "(Ljava/io/InputStream;)Ljava/lang/String;", "")]
		public static string Sha512Hex (global::System.IO.Stream p0)
		{
			if (id_sha512Hex_Ljava_io_InputStream_ == IntPtr.Zero)
				id_sha512Hex_Ljava_io_InputStream_ = JNIEnv.GetStaticMethodID (class_ref, "sha512Hex", "(Ljava/io/InputStream;)Ljava/lang/String;");
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_sha512Hex_Ljava_io_InputStream_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_sha512Hex_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.digest']/class[@name='DigestUtils']/method[@name='sha512Hex' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("sha512Hex", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static string Sha512Hex (string p0)
		{
			if (id_sha512Hex_Ljava_lang_String_ == IntPtr.Zero)
				id_sha512Hex_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "sha512Hex", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_sha512Hex_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_sha_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.digest']/class[@name='DigestUtils']/method[@name='sha' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("sha", "([B)[B", "")]
		public static byte[] Sha (byte[] p0)
		{
			if (id_sha_arrayB == IntPtr.Zero)
				id_sha_arrayB = JNIEnv.GetStaticMethodID (class_ref, "sha", "([B)[B");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_sha_arrayB, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef, typeof (byte));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static IntPtr id_sha_Ljava_io_InputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.digest']/class[@name='DigestUtils']/method[@name='sha' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("sha", "(Ljava/io/InputStream;)[B", "")]
		public static byte[] Sha (global::System.IO.Stream p0)
		{
			if (id_sha_Ljava_io_InputStream_ == IntPtr.Zero)
				id_sha_Ljava_io_InputStream_ = JNIEnv.GetStaticMethodID (class_ref, "sha", "(Ljava/io/InputStream;)[B");
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_sha_Ljava_io_InputStream_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef, typeof (byte));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_sha_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.digest']/class[@name='DigestUtils']/method[@name='sha' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("sha", "(Ljava/lang/String;)[B", "")]
		public static byte[] Sha (string p0)
		{
			if (id_sha_Ljava_lang_String_ == IntPtr.Zero)
				id_sha_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "sha", "(Ljava/lang/String;)[B");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_sha_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef, typeof (byte));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_shaHex_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.digest']/class[@name='DigestUtils']/method[@name='shaHex' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("shaHex", "([B)Ljava/lang/String;", "")]
		public static string ShaHex (byte[] p0)
		{
			if (id_shaHex_arrayB == IntPtr.Zero)
				id_shaHex_arrayB = JNIEnv.GetStaticMethodID (class_ref, "shaHex", "([B)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_shaHex_arrayB, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static IntPtr id_shaHex_Ljava_io_InputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.digest']/class[@name='DigestUtils']/method[@name='shaHex' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("shaHex", "(Ljava/io/InputStream;)Ljava/lang/String;", "")]
		public static string ShaHex (global::System.IO.Stream p0)
		{
			if (id_shaHex_Ljava_io_InputStream_ == IntPtr.Zero)
				id_shaHex_Ljava_io_InputStream_ = JNIEnv.GetStaticMethodID (class_ref, "shaHex", "(Ljava/io/InputStream;)Ljava/lang/String;");
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_shaHex_Ljava_io_InputStream_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_shaHex_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.digest']/class[@name='DigestUtils']/method[@name='shaHex' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("shaHex", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static string ShaHex (string p0)
		{
			if (id_shaHex_Ljava_lang_String_ == IntPtr.Zero)
				id_shaHex_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "shaHex", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_shaHex_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}
}
