using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Parse.Codec.Binary {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.parse.codec.binary']/class[@name='Base64InputStream']"
	[global::Android.Runtime.Register ("com/parse/codec/binary/Base64InputStream", DoNotGenerateAcw=true)]
	public partial class Base64InputStream : global::Com.Parse.Codec.Binary.BaseNCodecInputStream {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/parse/codec/binary/Base64InputStream", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Base64InputStream); }
		}

		protected Base64InputStream (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_io_InputStream_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.parse.codec.binary']/class[@name='Base64InputStream']/constructor[@name='Base64InputStream' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register (".ctor", "(Ljava/io/InputStream;)V", "")]
		public Base64InputStream (global::System.IO.Stream p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);;
			if (GetType () != typeof (Base64InputStream)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/io/InputStream;)V", new JValue (native_p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/io/InputStream;)V", new JValue (native_p0));
				JNIEnv.DeleteLocalRef (native_p0);
				return;
			}

			if (id_ctor_Ljava_io_InputStream_ == IntPtr.Zero)
				id_ctor_Ljava_io_InputStream_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/io/InputStream;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_io_InputStream_, new JValue (native_p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_io_InputStream_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_ctor_Ljava_io_InputStream_Z;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.parse.codec.binary']/class[@name='Base64InputStream']/constructor[@name='Base64InputStream' and count(parameter)=2 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(Ljava/io/InputStream;Z)V", "")]
		public Base64InputStream (global::System.IO.Stream p0, bool p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);;
			if (GetType () != typeof (Base64InputStream)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/io/InputStream;Z)V", new JValue (native_p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/io/InputStream;Z)V", new JValue (native_p0), new JValue (p1));
				JNIEnv.DeleteLocalRef (native_p0);
				return;
			}

			if (id_ctor_Ljava_io_InputStream_Z == IntPtr.Zero)
				id_ctor_Ljava_io_InputStream_Z = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/io/InputStream;Z)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_io_InputStream_Z, new JValue (native_p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_io_InputStream_Z, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_ctor_Ljava_io_InputStream_ZIarrayB;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.parse.codec.binary']/class[@name='Base64InputStream']/constructor[@name='Base64InputStream' and count(parameter)=4 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='boolean'] and parameter[3][@type='int'] and parameter[4][@type='byte[]']]"
		[Register (".ctor", "(Ljava/io/InputStream;ZI[B)V", "")]
		public Base64InputStream (global::System.IO.Stream p0, bool p1, int p2, byte[] p3) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);;
			IntPtr native_p3 = JNIEnv.NewArray (p3);;
			if (GetType () != typeof (Base64InputStream)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/io/InputStream;ZI[B)V", new JValue (native_p0), new JValue (p1), new JValue (p2), new JValue (native_p3)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/io/InputStream;ZI[B)V", new JValue (native_p0), new JValue (p1), new JValue (p2), new JValue (native_p3));
				JNIEnv.DeleteLocalRef (native_p0);
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
				return;
			}

			if (id_ctor_Ljava_io_InputStream_ZIarrayB == IntPtr.Zero)
				id_ctor_Ljava_io_InputStream_ZIarrayB = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/io/InputStream;ZI[B)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_io_InputStream_ZIarrayB, new JValue (native_p0), new JValue (p1), new JValue (p2), new JValue (native_p3)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_io_InputStream_ZIarrayB, new JValue (native_p0), new JValue (p1), new JValue (p2), new JValue (native_p3));
			JNIEnv.DeleteLocalRef (native_p0);
			if (p3 != null) {
				JNIEnv.CopyArray (native_p3, p3);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

	}
}
