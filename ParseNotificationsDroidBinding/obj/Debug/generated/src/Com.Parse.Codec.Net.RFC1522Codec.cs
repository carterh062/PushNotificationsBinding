using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Parse.Codec.Net {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.parse.codec.net']/class[@name='RFC1522Codec']"
	[global::Android.Runtime.Register ("com/parse/codec/net/RFC1522Codec", DoNotGenerateAcw=true)]
	public abstract partial class RFC1522Codec : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.parse.codec.net']/class[@name='RFC1522Codec']/field[@name='POSTFIX']"
		[Register ("POSTFIX")]
		protected const string Postfix = (string) "?=";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.parse.codec.net']/class[@name='RFC1522Codec']/field[@name='PREFIX']"
		[Register ("PREFIX")]
		protected const string Prefix = (string) "=?";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.parse.codec.net']/class[@name='RFC1522Codec']/field[@name='SEP']"
		[Register ("SEP")]
		protected const char Sep = (char) (char)63;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/parse/codec/net/RFC1522Codec", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RFC1522Codec); }
		}

		protected RFC1522Codec (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getEncoding;
#pragma warning disable 0169
		static Delegate GetGetEncodingHandler ()
		{
			if (cb_getEncoding == null)
				cb_getEncoding = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEncoding);
			return cb_getEncoding;
		}

		static IntPtr n_GetEncoding (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.Codec.Net.RFC1522Codec __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Codec.Net.RFC1522Codec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Encoding);
		}
#pragma warning restore 0169

		protected abstract string Encoding {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.net']/class[@name='RFC1522Codec']/method[@name='getEncoding' and count(parameter)=0]"
			[Register ("getEncoding", "()Ljava/lang/String;", "GetGetEncodingHandler")] get;
		}

		static Delegate cb_decodeText_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDecodeText_Ljava_lang_String_Handler ()
		{
			if (cb_decodeText_Ljava_lang_String_ == null)
				cb_decodeText_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_DecodeText_Ljava_lang_String_);
			return cb_decodeText_Ljava_lang_String_;
		}

		static IntPtr n_DecodeText_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.Codec.Net.RFC1522Codec __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Codec.Net.RFC1522Codec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.DecodeText (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_decodeText_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.net']/class[@name='RFC1522Codec']/method[@name='decodeText' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("decodeText", "(Ljava/lang/String;)Ljava/lang/String;", "GetDecodeText_Ljava_lang_String_Handler")]
		protected virtual string DecodeText (string p0)
		{
			if (id_decodeText_Ljava_lang_String_ == IntPtr.Zero)
				id_decodeText_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "decodeText", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			string __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_decodeText_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "decodeText", "(Ljava/lang/String;)Ljava/lang/String;"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_doDecoding_arrayB;
#pragma warning disable 0169
		static Delegate GetDoDecoding_arrayBHandler ()
		{
			if (cb_doDecoding_arrayB == null)
				cb_doDecoding_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_DoDecoding_arrayB);
			return cb_doDecoding_arrayB;
		}

		static IntPtr n_DoDecoding_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.Codec.Net.RFC1522Codec __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Codec.Net.RFC1522Codec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.NewArray (__this.DoDecoding (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.net']/class[@name='RFC1522Codec']/method[@name='doDecoding' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("doDecoding", "([B)[B", "GetDoDecoding_arrayBHandler")]
		protected abstract byte[] DoDecoding (byte[] p0);

		static Delegate cb_doEncoding_arrayB;
#pragma warning disable 0169
		static Delegate GetDoEncoding_arrayBHandler ()
		{
			if (cb_doEncoding_arrayB == null)
				cb_doEncoding_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_DoEncoding_arrayB);
			return cb_doEncoding_arrayB;
		}

		static IntPtr n_DoEncoding_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.Codec.Net.RFC1522Codec __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Codec.Net.RFC1522Codec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.NewArray (__this.DoEncoding (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.net']/class[@name='RFC1522Codec']/method[@name='doEncoding' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("doEncoding", "([B)[B", "GetDoEncoding_arrayBHandler")]
		protected abstract byte[] DoEncoding (byte[] p0);

		static Delegate cb_encodeText_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetEncodeText_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_encodeText_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_encodeText_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_EncodeText_Ljava_lang_String_Ljava_lang_String_);
			return cb_encodeText_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_EncodeText_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Parse.Codec.Net.RFC1522Codec __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Codec.Net.RFC1522Codec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.EncodeText (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_encodeText_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.net']/class[@name='RFC1522Codec']/method[@name='encodeText' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("encodeText", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "GetEncodeText_Ljava_lang_String_Ljava_lang_String_Handler")]
		protected virtual string EncodeText (string p0, string p1)
		{
			if (id_encodeText_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_encodeText_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "encodeText", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);

			string __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_encodeText_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "encodeText", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;"), new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

	}

	[global::Android.Runtime.Register ("com/parse/codec/net/RFC1522Codec", DoNotGenerateAcw=true)]
	internal partial class RFC1522CodecInvoker : RFC1522Codec {

		public RFC1522CodecInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (RFC1522CodecInvoker); }
		}

		static IntPtr id_getEncoding;
		protected override string Encoding {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.net']/class[@name='RFC1522Codec']/method[@name='getEncoding' and count(parameter)=0]"
			[Register ("getEncoding", "()Ljava/lang/String;", "GetGetEncodingHandler")]
			get {
				if (id_getEncoding == IntPtr.Zero)
					id_getEncoding = JNIEnv.GetMethodID (class_ref, "getEncoding", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getEncoding), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_doDecoding_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.net']/class[@name='RFC1522Codec']/method[@name='doDecoding' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("doDecoding", "([B)[B", "GetDoDecoding_arrayBHandler")]
		protected override byte[] DoDecoding (byte[] p0)
		{
			if (id_doDecoding_arrayB == IntPtr.Zero)
				id_doDecoding_arrayB = JNIEnv.GetMethodID (class_ref, "doDecoding", "([B)[B");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_doDecoding_arrayB, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef, typeof (byte));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static IntPtr id_doEncoding_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.net']/class[@name='RFC1522Codec']/method[@name='doEncoding' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("doEncoding", "([B)[B", "GetDoEncoding_arrayBHandler")]
		protected override byte[] DoEncoding (byte[] p0)
		{
			if (id_doEncoding_arrayB == IntPtr.Zero)
				id_doEncoding_arrayB = JNIEnv.GetMethodID (class_ref, "doEncoding", "([B)[B");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_doEncoding_arrayB, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef, typeof (byte));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

	}

}
