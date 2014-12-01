using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Parse.Codec.Binary {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.parse.codec.binary']/class[@name='BaseNCodecOutputStream']"
	[global::Android.Runtime.Register ("com/parse/codec/binary/BaseNCodecOutputStream", DoNotGenerateAcw=true)]
	public partial class BaseNCodecOutputStream : global::Java.IO.FilterOutputStream {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/parse/codec/binary/BaseNCodecOutputStream", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseNCodecOutputStream); }
		}

		protected BaseNCodecOutputStream (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_io_OutputStream_Lcom_parse_codec_binary_BaseNCodec_Z;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.parse.codec.binary']/class[@name='BaseNCodecOutputStream']/constructor[@name='BaseNCodecOutputStream' and count(parameter)=3 and parameter[1][@type='java.io.OutputStream'] and parameter[2][@type='com.parse.codec.binary.BaseNCodec'] and parameter[3][@type='boolean']]"
		[Register (".ctor", "(Ljava/io/OutputStream;Lcom/parse/codec/binary/BaseNCodec;Z)V", "")]
		public BaseNCodecOutputStream (global::System.IO.Stream p0, global::Com.Parse.Codec.Binary.BaseNCodec p1, bool p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (p0);;
			if (GetType () != typeof (BaseNCodecOutputStream)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/io/OutputStream;Lcom/parse/codec/binary/BaseNCodec;Z)V", new JValue (native_p0), new JValue (p1), new JValue (p2)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/io/OutputStream;Lcom/parse/codec/binary/BaseNCodec;Z)V", new JValue (native_p0), new JValue (p1), new JValue (p2));
				JNIEnv.DeleteLocalRef (native_p0);
				return;
			}

			if (id_ctor_Ljava_io_OutputStream_Lcom_parse_codec_binary_BaseNCodec_Z == IntPtr.Zero)
				id_ctor_Ljava_io_OutputStream_Lcom_parse_codec_binary_BaseNCodec_Z = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/io/OutputStream;Lcom/parse/codec/binary/BaseNCodec;Z)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_io_OutputStream_Lcom_parse_codec_binary_BaseNCodec_Z, new JValue (native_p0), new JValue (p1), new JValue (p2)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_io_OutputStream_Lcom_parse_codec_binary_BaseNCodec_Z, new JValue (native_p0), new JValue (p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}
}
