using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Parse.Codec.Net {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.parse.codec.net']/class[@name='QuotedPrintableCodec']"
	[global::Android.Runtime.Register ("com/parse/codec/net/QuotedPrintableCodec", DoNotGenerateAcw=true)]
	public partial class QuotedPrintableCodec : global::Java.Lang.Object, global::Com.Parse.Codec.IBinaryDecoder, global::Com.Parse.Codec.IBinaryEncoder, global::Com.Parse.Codec.IStringDecoder, global::Com.Parse.Codec.IStringEncoder {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/parse/codec/net/QuotedPrintableCodec", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (QuotedPrintableCodec); }
		}

		protected QuotedPrintableCodec (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.parse.codec.net']/class[@name='QuotedPrintableCodec']/constructor[@name='QuotedPrintableCodec' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public QuotedPrintableCodec (string p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);;
			if (GetType () != typeof (QuotedPrintableCodec)) {
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

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.parse.codec.net']/class[@name='QuotedPrintableCodec']/constructor[@name='QuotedPrintableCodec' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public QuotedPrintableCodec () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (QuotedPrintableCodec)) {
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

		static Delegate cb_getDefaultCharset;
#pragma warning disable 0169
		static Delegate GetGetDefaultCharsetHandler ()
		{
			if (cb_getDefaultCharset == null)
				cb_getDefaultCharset = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDefaultCharset);
			return cb_getDefaultCharset;
		}

		static IntPtr n_GetDefaultCharset (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.Codec.Net.QuotedPrintableCodec __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Codec.Net.QuotedPrintableCodec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DefaultCharset);
		}
#pragma warning restore 0169

		static IntPtr id_getDefaultCharset;
		public virtual string DefaultCharset {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.net']/class[@name='QuotedPrintableCodec']/method[@name='getDefaultCharset' and count(parameter)=0]"
			[Register ("getDefaultCharset", "()Ljava/lang/String;", "GetGetDefaultCharsetHandler")]
			get {
				if (id_getDefaultCharset == IntPtr.Zero)
					id_getDefaultCharset = JNIEnv.GetMethodID (class_ref, "getDefaultCharset", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getDefaultCharset), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDefaultCharset", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Parse.Codec.Net.QuotedPrintableCodec __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Codec.Net.QuotedPrintableCodec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.NewArray (__this.Decode (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_decode_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.net']/class[@name='QuotedPrintableCodec']/method[@name='decode' and count(parameter)=1 and parameter[1][@type='byte[]']]"
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
			global::Com.Parse.Codec.Net.QuotedPrintableCodec __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Codec.Net.QuotedPrintableCodec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Decode (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_decode_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.net']/class[@name='QuotedPrintableCodec']/method[@name='decode' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
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

		static Delegate cb_decode_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDecode_Ljava_lang_String_Handler ()
		{
			if (cb_decode_Ljava_lang_String_ == null)
				cb_decode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Decode_Ljava_lang_String_);
			return cb_decode_Ljava_lang_String_;
		}

		static IntPtr n_Decode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.Codec.Net.QuotedPrintableCodec __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Codec.Net.QuotedPrintableCodec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Decode (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_decode_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.net']/class[@name='QuotedPrintableCodec']/method[@name='decode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("decode", "(Ljava/lang/String;)Ljava/lang/String;", "GetDecode_Ljava_lang_String_Handler")]
		public virtual string Decode (string p0)
		{
			if (id_decode_Ljava_lang_String_ == IntPtr.Zero)
				id_decode_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "decode", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			string __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_decode_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "decode", "(Ljava/lang/String;)Ljava/lang/String;"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_decode_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDecode_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_decode_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_decode_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Decode_Ljava_lang_String_Ljava_lang_String_);
			return cb_decode_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_Decode_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Parse.Codec.Net.QuotedPrintableCodec __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Codec.Net.QuotedPrintableCodec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Decode (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_decode_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.net']/class[@name='QuotedPrintableCodec']/method[@name='decode' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("decode", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "GetDecode_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual string Decode (string p0, string p1)
		{
			if (id_decode_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_decode_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "decode", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);

			string __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_decode_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "decode", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;"), new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static IntPtr id_decodeQuotedPrintable_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.net']/class[@name='QuotedPrintableCodec']/method[@name='decodeQuotedPrintable' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("decodeQuotedPrintable", "([B)[B", "")]
		public static byte[] DecodeQuotedPrintable (byte[] p0)
		{
			if (id_decodeQuotedPrintable_arrayB == IntPtr.Zero)
				id_decodeQuotedPrintable_arrayB = JNIEnv.GetStaticMethodID (class_ref, "decodeQuotedPrintable", "([B)[B");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_decodeQuotedPrintable_arrayB, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef, typeof (byte));
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
			global::Com.Parse.Codec.Net.QuotedPrintableCodec __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Codec.Net.QuotedPrintableCodec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.NewArray (__this.Encode (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_encode_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.net']/class[@name='QuotedPrintableCodec']/method[@name='encode' and count(parameter)=1 and parameter[1][@type='byte[]']]"
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
			global::Com.Parse.Codec.Net.QuotedPrintableCodec __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Codec.Net.QuotedPrintableCodec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Encode (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_encode_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.net']/class[@name='QuotedPrintableCodec']/method[@name='encode' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
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

		static Delegate cb_encode_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetEncode_Ljava_lang_String_Handler ()
		{
			if (cb_encode_Ljava_lang_String_ == null)
				cb_encode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Encode_Ljava_lang_String_);
			return cb_encode_Ljava_lang_String_;
		}

		static IntPtr n_Encode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.Codec.Net.QuotedPrintableCodec __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Codec.Net.QuotedPrintableCodec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Encode (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_encode_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.net']/class[@name='QuotedPrintableCodec']/method[@name='encode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("encode", "(Ljava/lang/String;)Ljava/lang/String;", "GetEncode_Ljava_lang_String_Handler")]
		public virtual string Encode (string p0)
		{
			if (id_encode_Ljava_lang_String_ == IntPtr.Zero)
				id_encode_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "encode", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			string __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_encode_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "encode", "(Ljava/lang/String;)Ljava/lang/String;"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_encode_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetEncode_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_encode_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_encode_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Encode_Ljava_lang_String_Ljava_lang_String_);
			return cb_encode_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_Encode_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Parse.Codec.Net.QuotedPrintableCodec __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Codec.Net.QuotedPrintableCodec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Encode (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_encode_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.net']/class[@name='QuotedPrintableCodec']/method[@name='encode' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("encode", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "GetEncode_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual string Encode (string p0, string p1)
		{
			if (id_encode_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_encode_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "encode", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);

			string __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_encode_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "encode", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;"), new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static IntPtr id_encodeQuotedPrintable_Ljava_util_BitSet_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.net']/class[@name='QuotedPrintableCodec']/method[@name='encodeQuotedPrintable' and count(parameter)=2 and parameter[1][@type='java.util.BitSet'] and parameter[2][@type='byte[]']]"
		[Register ("encodeQuotedPrintable", "(Ljava/util/BitSet;[B)[B", "")]
		public static byte[] EncodeQuotedPrintable (global::Java.Util.BitSet p0, byte[] p1)
		{
			if (id_encodeQuotedPrintable_Ljava_util_BitSet_arrayB == IntPtr.Zero)
				id_encodeQuotedPrintable_Ljava_util_BitSet_arrayB = JNIEnv.GetStaticMethodID (class_ref, "encodeQuotedPrintable", "(Ljava/util/BitSet;[B)[B");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_encodeQuotedPrintable_Ljava_util_BitSet_arrayB, new JValue (p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef, typeof (byte));
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

	}
}
