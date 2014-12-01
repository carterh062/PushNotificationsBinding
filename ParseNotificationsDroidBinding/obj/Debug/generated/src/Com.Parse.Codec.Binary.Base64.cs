using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Parse.Codec.Binary {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.parse.codec.binary']/class[@name='Base64']"
	[global::Android.Runtime.Register ("com/parse/codec/binary/Base64", DoNotGenerateAcw=true)]
	public partial class Base64 : global::Com.Parse.Codec.Binary.BaseNCodec {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/parse/codec/binary/Base64", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Base64); }
		}

		protected Base64 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.parse.codec.binary']/class[@name='Base64']/constructor[@name='Base64' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public Base64 () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (Base64)) {
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

		static IntPtr id_ctor_IarrayB;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.parse.codec.binary']/class[@name='Base64']/constructor[@name='Base64' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
		[Register (".ctor", "(I[B)V", "")]
		public Base64 (int p0, byte[] p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewArray (p1);;
			if (GetType () != typeof (Base64)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(I[B)V", new JValue (p0), new JValue (native_p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(I[B)V", new JValue (p0), new JValue (native_p1));
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				return;
			}

			if (id_ctor_IarrayB == IntPtr.Zero)
				id_ctor_IarrayB = JNIEnv.GetMethodID (class_ref, "<init>", "(I[B)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_IarrayB, new JValue (p0), new JValue (native_p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_IarrayB, new JValue (p0), new JValue (native_p1));
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_ctor_IarrayBZ;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.parse.codec.binary']/class[@name='Base64']/constructor[@name='Base64' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='boolean']]"
		[Register (".ctor", "(I[BZ)V", "")]
		public Base64 (int p0, byte[] p1, bool p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewArray (p1);;
			if (GetType () != typeof (Base64)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(I[BZ)V", new JValue (p0), new JValue (native_p1), new JValue (p2)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(I[BZ)V", new JValue (p0), new JValue (native_p1), new JValue (p2));
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				return;
			}

			if (id_ctor_IarrayBZ == IntPtr.Zero)
				id_ctor_IarrayBZ = JNIEnv.GetMethodID (class_ref, "<init>", "(I[BZ)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_IarrayBZ, new JValue (p0), new JValue (native_p1), new JValue (p2)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_IarrayBZ, new JValue (p0), new JValue (native_p1), new JValue (p2));
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_ctor_Z;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.parse.codec.binary']/class[@name='Base64']/constructor[@name='Base64' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register (".ctor", "(Z)V", "")]
		public Base64 (bool p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (Base64)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Z)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Z)V", new JValue (p0));
				return;
			}

			if (id_ctor_Z == IntPtr.Zero)
				id_ctor_Z = JNIEnv.GetMethodID (class_ref, "<init>", "(Z)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Z, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Z, new JValue (p0));
		}

		static IntPtr id_ctor_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.parse.codec.binary']/class[@name='Base64']/constructor[@name='Base64' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public Base64 (int p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (Base64)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(I)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(I)V", new JValue (p0));
				return;
			}

			if (id_ctor_I == IntPtr.Zero)
				id_ctor_I = JNIEnv.GetMethodID (class_ref, "<init>", "(I)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_I, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_I, new JValue (p0));
		}

		static Delegate cb_isUrlSafe;
#pragma warning disable 0169
		static Delegate GetIsUrlSafeHandler ()
		{
			if (cb_isUrlSafe == null)
				cb_isUrlSafe = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsUrlSafe);
			return cb_isUrlSafe;
		}

		static bool n_IsUrlSafe (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.Codec.Binary.Base64 __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Codec.Binary.Base64> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsUrlSafe;
		}
#pragma warning restore 0169

		static IntPtr id_isUrlSafe;
		public virtual bool IsUrlSafe {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.binary']/class[@name='Base64']/method[@name='isUrlSafe' and count(parameter)=0]"
			[Register ("isUrlSafe", "()Z", "GetIsUrlSafeHandler")]
			get {
				if (id_isUrlSafe == IntPtr.Zero)
					id_isUrlSafe = JNIEnv.GetMethodID (class_ref, "isUrlSafe", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isUrlSafe);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isUrlSafe", "()Z"));
			}
		}

		static IntPtr id_decodeBase64_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.binary']/class[@name='Base64']/method[@name='decodeBase64' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("decodeBase64", "([B)[B", "")]
		public static byte[] DecodeBase64 (byte[] p0)
		{
			if (id_decodeBase64_arrayB == IntPtr.Zero)
				id_decodeBase64_arrayB = JNIEnv.GetStaticMethodID (class_ref, "decodeBase64", "([B)[B");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_decodeBase64_arrayB, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef, typeof (byte));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static IntPtr id_decodeBase64_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.binary']/class[@name='Base64']/method[@name='decodeBase64' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("decodeBase64", "(Ljava/lang/String;)[B", "")]
		public static byte[] DecodeBase64 (string p0)
		{
			if (id_decodeBase64_Ljava_lang_String_ == IntPtr.Zero)
				id_decodeBase64_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "decodeBase64", "(Ljava/lang/String;)[B");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_decodeBase64_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef, typeof (byte));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_decodeInteger_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.binary']/class[@name='Base64']/method[@name='decodeInteger' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("decodeInteger", "([B)Ljava/math/BigInteger;", "")]
		public static global::Java.Math.BigInteger DecodeInteger (byte[] p0)
		{
			if (id_decodeInteger_arrayB == IntPtr.Zero)
				id_decodeInteger_arrayB = JNIEnv.GetStaticMethodID (class_ref, "decodeInteger", "([B)Ljava/math/BigInteger;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			global::Java.Math.BigInteger __ret = global::Java.Lang.Object.GetObject<global::Java.Math.BigInteger> (JNIEnv.CallStaticObjectMethod  (class_ref, id_decodeInteger_arrayB, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static IntPtr id_encodeBase64_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.binary']/class[@name='Base64']/method[@name='encodeBase64' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("encodeBase64", "([B)[B", "")]
		public static byte[] EncodeBase64 (byte[] p0)
		{
			if (id_encodeBase64_arrayB == IntPtr.Zero)
				id_encodeBase64_arrayB = JNIEnv.GetStaticMethodID (class_ref, "encodeBase64", "([B)[B");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_encodeBase64_arrayB, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef, typeof (byte));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static IntPtr id_encodeBase64_arrayBZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.binary']/class[@name='Base64']/method[@name='encodeBase64' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='boolean']]"
		[Register ("encodeBase64", "([BZ)[B", "")]
		public static byte[] EncodeBase64 (byte[] p0, bool p1)
		{
			if (id_encodeBase64_arrayBZ == IntPtr.Zero)
				id_encodeBase64_arrayBZ = JNIEnv.GetStaticMethodID (class_ref, "encodeBase64", "([BZ)[B");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_encodeBase64_arrayBZ, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef, typeof (byte));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static IntPtr id_encodeBase64_arrayBZZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.binary']/class[@name='Base64']/method[@name='encodeBase64' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean']]"
		[Register ("encodeBase64", "([BZZ)[B", "")]
		public static byte[] EncodeBase64 (byte[] p0, bool p1, bool p2)
		{
			if (id_encodeBase64_arrayBZZ == IntPtr.Zero)
				id_encodeBase64_arrayBZZ = JNIEnv.GetStaticMethodID (class_ref, "encodeBase64", "([BZZ)[B");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_encodeBase64_arrayBZZ, new JValue (native_p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef, typeof (byte));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static IntPtr id_encodeBase64_arrayBZZI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.binary']/class[@name='Base64']/method[@name='encodeBase64' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean'] and parameter[4][@type='int']]"
		[Register ("encodeBase64", "([BZZI)[B", "")]
		public static byte[] EncodeBase64 (byte[] p0, bool p1, bool p2, int p3)
		{
			if (id_encodeBase64_arrayBZZI == IntPtr.Zero)
				id_encodeBase64_arrayBZZI = JNIEnv.GetStaticMethodID (class_ref, "encodeBase64", "([BZZI)[B");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_encodeBase64_arrayBZZI, new JValue (native_p0), new JValue (p1), new JValue (p2), new JValue (p3)), JniHandleOwnership.TransferLocalRef, typeof (byte));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static IntPtr id_encodeBase64Chunked_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.binary']/class[@name='Base64']/method[@name='encodeBase64Chunked' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("encodeBase64Chunked", "([B)[B", "")]
		public static byte[] EncodeBase64Chunked (byte[] p0)
		{
			if (id_encodeBase64Chunked_arrayB == IntPtr.Zero)
				id_encodeBase64Chunked_arrayB = JNIEnv.GetStaticMethodID (class_ref, "encodeBase64Chunked", "([B)[B");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_encodeBase64Chunked_arrayB, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef, typeof (byte));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static IntPtr id_encodeBase64String_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.binary']/class[@name='Base64']/method[@name='encodeBase64String' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("encodeBase64String", "([B)Ljava/lang/String;", "")]
		public static string EncodeBase64String (byte[] p0)
		{
			if (id_encodeBase64String_arrayB == IntPtr.Zero)
				id_encodeBase64String_arrayB = JNIEnv.GetStaticMethodID (class_ref, "encodeBase64String", "([B)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_encodeBase64String_arrayB, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static IntPtr id_encodeBase64URLSafe_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.binary']/class[@name='Base64']/method[@name='encodeBase64URLSafe' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("encodeBase64URLSafe", "([B)[B", "")]
		public static byte[] EncodeBase64URLSafe (byte[] p0)
		{
			if (id_encodeBase64URLSafe_arrayB == IntPtr.Zero)
				id_encodeBase64URLSafe_arrayB = JNIEnv.GetStaticMethodID (class_ref, "encodeBase64URLSafe", "([B)[B");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_encodeBase64URLSafe_arrayB, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef, typeof (byte));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static IntPtr id_encodeBase64URLSafeString_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.binary']/class[@name='Base64']/method[@name='encodeBase64URLSafeString' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("encodeBase64URLSafeString", "([B)Ljava/lang/String;", "")]
		public static string EncodeBase64URLSafeString (byte[] p0)
		{
			if (id_encodeBase64URLSafeString_arrayB == IntPtr.Zero)
				id_encodeBase64URLSafeString_arrayB = JNIEnv.GetStaticMethodID (class_ref, "encodeBase64URLSafeString", "([B)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_encodeBase64URLSafeString_arrayB, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static IntPtr id_encodeInteger_Ljava_math_BigInteger_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.binary']/class[@name='Base64']/method[@name='encodeInteger' and count(parameter)=1 and parameter[1][@type='java.math.BigInteger']]"
		[Register ("encodeInteger", "(Ljava/math/BigInteger;)[B", "")]
		public static byte[] EncodeInteger (global::Java.Math.BigInteger p0)
		{
			if (id_encodeInteger_Ljava_math_BigInteger_ == IntPtr.Zero)
				id_encodeInteger_Ljava_math_BigInteger_ = JNIEnv.GetStaticMethodID (class_ref, "encodeInteger", "(Ljava/math/BigInteger;)[B");
			byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_encodeInteger_Ljava_math_BigInteger_, new JValue (p0)), JniHandleOwnership.TransferLocalRef, typeof (byte));
			return __ret;
		}

		static IntPtr id_isArrayByteBase64_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.binary']/class[@name='Base64']/method[@name='isArrayByteBase64' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("isArrayByteBase64", "([B)Z", "")]
		public static bool IsArrayByteBase64 (byte[] p0)
		{
			if (id_isArrayByteBase64_arrayB == IntPtr.Zero)
				id_isArrayByteBase64_arrayB = JNIEnv.GetStaticMethodID (class_ref, "isArrayByteBase64", "([B)Z");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isArrayByteBase64_arrayB, new JValue (native_p0));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static IntPtr id_isBase64_B;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.binary']/class[@name='Base64']/method[@name='isBase64' and count(parameter)=1 and parameter[1][@type='byte']]"
		[Register ("isBase64", "(B)Z", "")]
		public static bool IsBase64 (sbyte p0)
		{
			if (id_isBase64_B == IntPtr.Zero)
				id_isBase64_B = JNIEnv.GetStaticMethodID (class_ref, "isBase64", "(B)Z");
			return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isBase64_B, new JValue (p0));
		}

		static IntPtr id_isBase64_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.binary']/class[@name='Base64']/method[@name='isBase64' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("isBase64", "([B)Z", "")]
		public static bool IsBase64 (byte[] p0)
		{
			if (id_isBase64_arrayB == IntPtr.Zero)
				id_isBase64_arrayB = JNIEnv.GetStaticMethodID (class_ref, "isBase64", "([B)Z");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isBase64_arrayB, new JValue (native_p0));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static IntPtr id_isBase64_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.binary']/class[@name='Base64']/method[@name='isBase64' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isBase64", "(Ljava/lang/String;)Z", "")]
		public static bool IsBase64 (string p0)
		{
			if (id_isBase64_Ljava_lang_String_ == IntPtr.Zero)
				id_isBase64_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "isBase64", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isBase64_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_isInAlphabet_B;
#pragma warning disable 0169
		static Delegate GetIsInAlphabet_BHandler ()
		{
			if (cb_isInAlphabet_B == null)
				cb_isInAlphabet_B = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, sbyte, bool>) n_IsInAlphabet_B);
			return cb_isInAlphabet_B;
		}

		static bool n_IsInAlphabet_B (IntPtr jnienv, IntPtr native__this, sbyte p0)
		{
			global::Com.Parse.Codec.Binary.Base64 __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Codec.Binary.Base64> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsInAlphabet (p0);
		}
#pragma warning restore 0169

		static IntPtr id_isInAlphabet_B;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.binary']/class[@name='Base64']/method[@name='isInAlphabet' and count(parameter)=1 and parameter[1][@type='byte']]"
		[Register ("isInAlphabet", "(B)Z", "GetIsInAlphabet_BHandler")]
		protected override bool IsInAlphabet (sbyte p0)
		{
			if (id_isInAlphabet_B == IntPtr.Zero)
				id_isInAlphabet_B = JNIEnv.GetMethodID (class_ref, "isInAlphabet", "(B)Z");

			if (GetType () == ThresholdType)
				return JNIEnv.CallBooleanMethod  (Handle, id_isInAlphabet_B, new JValue (p0));
			else
				return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isInAlphabet", "(B)Z"), new JValue (p0));
		}

	}
}
