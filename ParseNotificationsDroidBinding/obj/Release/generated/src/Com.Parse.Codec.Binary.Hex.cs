using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Parse.Codec.Binary {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.parse.codec.binary']/class[@name='Hex']"
	[global::Android.Runtime.Register ("com/parse/codec/binary/Hex", DoNotGenerateAcw=true)]
	public partial class Hex : global::Java.Lang.Object, global::Com.Parse.Codec.IBinaryDecoder, global::Com.Parse.Codec.IBinaryEncoder {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.parse.codec.binary']/class[@name='Hex']/field[@name='DEFAULT_CHARSET_NAME']"
		[Register ("DEFAULT_CHARSET_NAME")]
		public const string DefaultCharsetName = (string) "UTF-8";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/parse/codec/binary/Hex", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Hex); }
		}

		protected Hex (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.parse.codec.binary']/class[@name='Hex']/constructor[@name='Hex' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public Hex () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (Hex)) {
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

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.parse.codec.binary']/class[@name='Hex']/constructor[@name='Hex' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public Hex (string p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);;
			if (GetType () != typeof (Hex)) {
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

		static Delegate cb_getCharsetName;
#pragma warning disable 0169
		static Delegate GetGetCharsetNameHandler ()
		{
			if (cb_getCharsetName == null)
				cb_getCharsetName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCharsetName);
			return cb_getCharsetName;
		}

		static IntPtr n_GetCharsetName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.Codec.Binary.Hex __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Codec.Binary.Hex> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CharsetName);
		}
#pragma warning restore 0169

		static IntPtr id_getCharsetName;
		public virtual string CharsetName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.binary']/class[@name='Hex']/method[@name='getCharsetName' and count(parameter)=0]"
			[Register ("getCharsetName", "()Ljava/lang/String;", "GetGetCharsetNameHandler")]
			get {
				if (id_getCharsetName == IntPtr.Zero)
					id_getCharsetName = JNIEnv.GetMethodID (class_ref, "getCharsetName", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getCharsetName), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCharsetName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_decode_arrayB;
#pragma warning disable 0169
		static Delegate GetDecode_arrayBHandler ()
		{
			if (cb_decode_arrayB == null)
				cb_decode_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Decode_arrayB);
			return cb_decode_arrayB;
		}

		static IntPtr n_Decode_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.Codec.Binary.Hex __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Codec.Binary.Hex> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.NewArray (__this.Decode (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_decode_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.binary']/class[@name='Hex']/method[@name='decode' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("decode", "([B)[B", "GetDecode_arrayBHandler")]
		public virtual byte[] Decode (byte[] p0)
		{
			if (id_decode_arrayB == IntPtr.Zero)
				id_decode_arrayB = JNIEnv.GetMethodID (class_ref, "decode", "([B)[B");
			IntPtr native_p0 = JNIEnv.NewArray (p0);

			byte[] __ret;
			if (GetType () == ThresholdType)
				__ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_decode_arrayB, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef, typeof (byte));
			else
				__ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "decode", "([B)[B"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef, typeof (byte));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate cb_decode_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetDecode_Ljava_lang_Object_Handler ()
		{
			if (cb_decode_Ljava_lang_Object_ == null)
				cb_decode_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Decode_Ljava_lang_Object_);
			return cb_decode_Ljava_lang_Object_;
		}

		static IntPtr n_Decode_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.Codec.Binary.Hex __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Codec.Binary.Hex> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Decode (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_decode_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.binary']/class[@name='Hex']/method[@name='decode' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("decode", "(Ljava/lang/Object;)Ljava/lang/Object;", "GetDecode_Ljava_lang_Object_Handler")]
		public virtual global::Java.Lang.Object Decode (global::Java.Lang.Object p0)
		{
			if (id_decode_Ljava_lang_Object_ == IntPtr.Zero)
				id_decode_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "decode", "(Ljava/lang/Object;)Ljava/lang/Object;");

			global::Java.Lang.Object __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_decode_Ljava_lang_Object_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "decode", "(Ljava/lang/Object;)Ljava/lang/Object;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_decodeHex_arrayC;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.binary']/class[@name='Hex']/method[@name='decodeHex' and count(parameter)=1 and parameter[1][@type='char[]']]"
		[Register ("decodeHex", "([C)[B", "")]
		public static byte[] DecodeHex (char[] p0)
		{
			if (id_decodeHex_arrayC == IntPtr.Zero)
				id_decodeHex_arrayC = JNIEnv.GetStaticMethodID (class_ref, "decodeHex", "([C)[B");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_decodeHex_arrayC, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef, typeof (byte));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate cb_encode_arrayB;
#pragma warning disable 0169
		static Delegate GetEncode_arrayBHandler ()
		{
			if (cb_encode_arrayB == null)
				cb_encode_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Encode_arrayB);
			return cb_encode_arrayB;
		}

		static IntPtr n_Encode_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.Codec.Binary.Hex __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Codec.Binary.Hex> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.NewArray (__this.Encode (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_encode_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.binary']/class[@name='Hex']/method[@name='encode' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("encode", "([B)[B", "GetEncode_arrayBHandler")]
		public virtual byte[] Encode (byte[] p0)
		{
			if (id_encode_arrayB == IntPtr.Zero)
				id_encode_arrayB = JNIEnv.GetMethodID (class_ref, "encode", "([B)[B");
			IntPtr native_p0 = JNIEnv.NewArray (p0);

			byte[] __ret;
			if (GetType () == ThresholdType)
				__ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_encode_arrayB, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef, typeof (byte));
			else
				__ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "encode", "([B)[B"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef, typeof (byte));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate cb_encode_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetEncode_Ljava_lang_Object_Handler ()
		{
			if (cb_encode_Ljava_lang_Object_ == null)
				cb_encode_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Encode_Ljava_lang_Object_);
			return cb_encode_Ljava_lang_Object_;
		}

		static IntPtr n_Encode_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.Codec.Binary.Hex __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Codec.Binary.Hex> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Encode (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_encode_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.binary']/class[@name='Hex']/method[@name='encode' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("encode", "(Ljava/lang/Object;)Ljava/lang/Object;", "GetEncode_Ljava_lang_Object_Handler")]
		public virtual global::Java.Lang.Object Encode (global::Java.Lang.Object p0)
		{
			if (id_encode_Ljava_lang_Object_ == IntPtr.Zero)
				id_encode_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "encode", "(Ljava/lang/Object;)Ljava/lang/Object;");

			global::Java.Lang.Object __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_encode_Ljava_lang_Object_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "encode", "(Ljava/lang/Object;)Ljava/lang/Object;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_encodeHex_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.binary']/class[@name='Hex']/method[@name='encodeHex' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("encodeHex", "([B)[C", "")]
		public static char[] EncodeHex (byte[] p0)
		{
			if (id_encodeHex_arrayB == IntPtr.Zero)
				id_encodeHex_arrayB = JNIEnv.GetStaticMethodID (class_ref, "encodeHex", "([B)[C");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			char[] __ret = (char[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_encodeHex_arrayB, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef, typeof (char));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static IntPtr id_encodeHex_arrayBZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.binary']/class[@name='Hex']/method[@name='encodeHex' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='boolean']]"
		[Register ("encodeHex", "([BZ)[C", "")]
		public static char[] EncodeHex (byte[] p0, bool p1)
		{
			if (id_encodeHex_arrayBZ == IntPtr.Zero)
				id_encodeHex_arrayBZ = JNIEnv.GetStaticMethodID (class_ref, "encodeHex", "([BZ)[C");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			char[] __ret = (char[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_encodeHex_arrayBZ, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef, typeof (char));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static IntPtr id_encodeHex_arrayBarrayC;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.binary']/class[@name='Hex']/method[@name='encodeHex' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='char[]']]"
		[Register ("encodeHex", "([B[C)[C", "")]
		protected static char[] EncodeHex (byte[] p0, char[] p1)
		{
			if (id_encodeHex_arrayBarrayC == IntPtr.Zero)
				id_encodeHex_arrayBarrayC = JNIEnv.GetStaticMethodID (class_ref, "encodeHex", "([B[C)[C");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			char[] __ret = (char[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_encodeHex_arrayBarrayC, new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef, typeof (char));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

		static IntPtr id_encodeHexString_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.binary']/class[@name='Hex']/method[@name='encodeHexString' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("encodeHexString", "([B)Ljava/lang/String;", "")]
		public static string EncodeHexString (byte[] p0)
		{
			if (id_encodeHexString_arrayB == IntPtr.Zero)
				id_encodeHexString_arrayB = JNIEnv.GetStaticMethodID (class_ref, "encodeHexString", "([B)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_encodeHexString_arrayB, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static IntPtr id_toDigit_CI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.binary']/class[@name='Hex']/method[@name='toDigit' and count(parameter)=2 and parameter[1][@type='char'] and parameter[2][@type='int']]"
		[Register ("toDigit", "(CI)I", "")]
		protected static int ToDigit (char p0, int p1)
		{
			if (id_toDigit_CI == IntPtr.Zero)
				id_toDigit_CI = JNIEnv.GetStaticMethodID (class_ref, "toDigit", "(CI)I");
			return JNIEnv.CallStaticIntMethod  (class_ref, id_toDigit_CI, new JValue (p0), new JValue (p1));
		}

	}
}
