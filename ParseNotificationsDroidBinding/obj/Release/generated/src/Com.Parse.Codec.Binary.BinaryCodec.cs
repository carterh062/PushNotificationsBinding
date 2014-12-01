using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Parse.Codec.Binary {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.parse.codec.binary']/class[@name='BinaryCodec']"
	[global::Android.Runtime.Register ("com/parse/codec/binary/BinaryCodec", DoNotGenerateAcw=true)]
	public partial class BinaryCodec : global::Java.Lang.Object, global::Com.Parse.Codec.IBinaryDecoder, global::Com.Parse.Codec.IBinaryEncoder {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/parse/codec/binary/BinaryCodec", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BinaryCodec); }
		}

		protected BinaryCodec (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.parse.codec.binary']/class[@name='BinaryCodec']/constructor[@name='BinaryCodec' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public BinaryCodec () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (BinaryCodec)) {
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
			global::Com.Parse.Codec.Binary.BinaryCodec __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Codec.Binary.BinaryCodec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.NewArray (__this.Decode (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_decode_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.binary']/class[@name='BinaryCodec']/method[@name='decode' and count(parameter)=1 and parameter[1][@type='byte[]']]"
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
			global::Com.Parse.Codec.Binary.BinaryCodec __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Codec.Binary.BinaryCodec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Decode (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_decode_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.binary']/class[@name='BinaryCodec']/method[@name='decode' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
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
			global::Com.Parse.Codec.Binary.BinaryCodec __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Codec.Binary.BinaryCodec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.NewArray (__this.Encode (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_encode_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.binary']/class[@name='BinaryCodec']/method[@name='encode' and count(parameter)=1 and parameter[1][@type='byte[]']]"
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
			global::Com.Parse.Codec.Binary.BinaryCodec __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Codec.Binary.BinaryCodec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Encode (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_encode_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.binary']/class[@name='BinaryCodec']/method[@name='encode' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
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

		static IntPtr id_fromAscii_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.binary']/class[@name='BinaryCodec']/method[@name='fromAscii' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("fromAscii", "([B)[B", "")]
		public static byte[] FromAscii (byte[] p0)
		{
			if (id_fromAscii_arrayB == IntPtr.Zero)
				id_fromAscii_arrayB = JNIEnv.GetStaticMethodID (class_ref, "fromAscii", "([B)[B");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromAscii_arrayB, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef, typeof (byte));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static IntPtr id_fromAscii_arrayC;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.binary']/class[@name='BinaryCodec']/method[@name='fromAscii' and count(parameter)=1 and parameter[1][@type='char[]']]"
		[Register ("fromAscii", "([C)[B", "")]
		public static byte[] FromAscii (char[] p0)
		{
			if (id_fromAscii_arrayC == IntPtr.Zero)
				id_fromAscii_arrayC = JNIEnv.GetStaticMethodID (class_ref, "fromAscii", "([C)[B");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromAscii_arrayC, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef, typeof (byte));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static IntPtr id_toAsciiBytes_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.binary']/class[@name='BinaryCodec']/method[@name='toAsciiBytes' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("toAsciiBytes", "([B)[B", "")]
		public static byte[] ToAsciiBytes (byte[] p0)
		{
			if (id_toAsciiBytes_arrayB == IntPtr.Zero)
				id_toAsciiBytes_arrayB = JNIEnv.GetStaticMethodID (class_ref, "toAsciiBytes", "([B)[B");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_toAsciiBytes_arrayB, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef, typeof (byte));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static IntPtr id_toAsciiChars_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.binary']/class[@name='BinaryCodec']/method[@name='toAsciiChars' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("toAsciiChars", "([B)[C", "")]
		public static char[] ToAsciiChars (byte[] p0)
		{
			if (id_toAsciiChars_arrayB == IntPtr.Zero)
				id_toAsciiChars_arrayB = JNIEnv.GetStaticMethodID (class_ref, "toAsciiChars", "([B)[C");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			char[] __ret = (char[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_toAsciiChars_arrayB, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef, typeof (char));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static IntPtr id_toAsciiString_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.binary']/class[@name='BinaryCodec']/method[@name='toAsciiString' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("toAsciiString", "([B)Ljava/lang/String;", "")]
		public static string ToAsciiString (byte[] p0)
		{
			if (id_toAsciiString_arrayB == IntPtr.Zero)
				id_toAsciiString_arrayB = JNIEnv.GetStaticMethodID (class_ref, "toAsciiString", "([B)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_toAsciiString_arrayB, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate cb_toByteArray_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetToByteArray_Ljava_lang_String_Handler ()
		{
			if (cb_toByteArray_Ljava_lang_String_ == null)
				cb_toByteArray_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ToByteArray_Ljava_lang_String_);
			return cb_toByteArray_Ljava_lang_String_;
		}

		static IntPtr n_ToByteArray_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.Codec.Binary.BinaryCodec __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Codec.Binary.BinaryCodec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.ToByteArray (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_toByteArray_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.binary']/class[@name='BinaryCodec']/method[@name='toByteArray' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("toByteArray", "(Ljava/lang/String;)[B", "GetToByteArray_Ljava_lang_String_Handler")]
		public virtual byte[] ToByteArray (string p0)
		{
			if (id_toByteArray_Ljava_lang_String_ == IntPtr.Zero)
				id_toByteArray_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "toByteArray", "(Ljava/lang/String;)[B");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			byte[] __ret;
			if (GetType () == ThresholdType)
				__ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_toByteArray_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef, typeof (byte));
			else
				__ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "toByteArray", "(Ljava/lang/String;)[B"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef, typeof (byte));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}
}
