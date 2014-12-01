using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Parse.Codec.Binary {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.parse.codec.binary']/class[@name='Base64OutputStream']"
	[global::Android.Runtime.Register ("com/parse/codec/binary/Base64OutputStream", DoNotGenerateAcw=true)]
	public partial class Base64OutputStream : global::Com.Parse.Codec.Binary.BaseNCodecOutputStream {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/parse/codec/binary/Base64OutputStream", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Base64OutputStream); }
		}

		protected Base64OutputStream (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_io_OutputStream_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.parse.codec.binary']/class[@name='Base64OutputStream']/constructor[@name='Base64OutputStream' and count(parameter)=1 and parameter[1][@type='java.io.OutputStream']]"
		[Register (".ctor", "(Ljava/io/OutputStream;)V", "")]
		public Base64OutputStream (global::System.IO.Stream p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (p0);;
			if (GetType () != typeof (Base64OutputStream)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/io/OutputStream;)V", new JValue (native_p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/io/OutputStream;)V", new JValue (native_p0));
				JNIEnv.DeleteLocalRef (native_p0);
				return;
			}

			if (id_ctor_Ljava_io_OutputStream_ == IntPtr.Zero)
				id_ctor_Ljava_io_OutputStream_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/io/OutputStream;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_io_OutputStream_, new JValue (native_p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_io_OutputStream_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_ctor_Ljava_io_OutputStream_Z;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.parse.codec.binary']/class[@name='Base64OutputStream']/constructor[@name='Base64OutputStream' and count(parameter)=2 and parameter[1][@type='java.io.OutputStream'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(Ljava/io/OutputStream;Z)V", "")]
		public Base64OutputStream (global::System.IO.Stream p0, bool p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (p0);;
			if (GetType () != typeof (Base64OutputStream)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/io/OutputStream;Z)V", new JValue (native_p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/io/OutputStream;Z)V", new JValue (native_p0), new JValue (p1));
				JNIEnv.DeleteLocalRef (native_p0);
				return;
			}

			if (id_ctor_Ljava_io_OutputStream_Z == IntPtr.Zero)
				id_ctor_Ljava_io_OutputStream_Z = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/io/OutputStream;Z)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_io_OutputStream_Z, new JValue (native_p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_io_OutputStream_Z, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_ctor_Ljava_io_OutputStream_ZIarrayB;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.parse.codec.binary']/class[@name='Base64OutputStream']/constructor[@name='Base64OutputStream' and count(parameter)=4 and parameter[1][@type='java.io.OutputStream'] and parameter[2][@type='boolean'] and parameter[3][@type='int'] and parameter[4][@type='byte[]']]"
		[Register (".ctor", "(Ljava/io/OutputStream;ZI[B)V", "")]
		public Base64OutputStream (global::System.IO.Stream p0, bool p1, int p2, byte[] p3) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (p0);;
			IntPtr native_p3 = JNIEnv.NewArray (p3);;
			if (GetType () != typeof (Base64OutputStream)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/io/OutputStream;ZI[B)V", new JValue (native_p0), new JValue (p1), new JValue (p2), new JValue (native_p3)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/io/OutputStream;ZI[B)V", new JValue (native_p0), new JValue (p1), new JValue (p2), new JValue (native_p3));
				JNIEnv.DeleteLocalRef (native_p0);
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
				return;
			}

			if (id_ctor_Ljava_io_OutputStream_ZIarrayB == IntPtr.Zero)
				id_ctor_Ljava_io_OutputStream_ZIarrayB = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/io/OutputStream;ZI[B)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_io_OutputStream_ZIarrayB, new JValue (native_p0), new JValue (p1), new JValue (p2), new JValue (native_p3)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_io_OutputStream_ZIarrayB, new JValue (native_p0), new JValue (p1), new JValue (p2), new JValue (native_p3));
			JNIEnv.DeleteLocalRef (native_p0);
			if (p3 != null) {
				JNIEnv.CopyArray (native_p3, p3);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

	}
}
