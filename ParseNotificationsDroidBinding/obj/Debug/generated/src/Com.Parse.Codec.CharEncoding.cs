using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Parse.Codec {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.parse.codec']/class[@name='CharEncoding']"
	[global::Android.Runtime.Register ("com/parse/codec/CharEncoding", DoNotGenerateAcw=true)]
	public partial class CharEncoding : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.parse.codec']/class[@name='CharEncoding']/field[@name='ISO_8859_1']"
		[Register ("ISO_8859_1")]
		public const string Iso88591 = (string) "ISO-8859-1";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.parse.codec']/class[@name='CharEncoding']/field[@name='US_ASCII']"
		[Register ("US_ASCII")]
		public const string UsAscii = (string) "US-ASCII";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.parse.codec']/class[@name='CharEncoding']/field[@name='UTF_16']"
		[Register ("UTF_16")]
		public const string Utf16 = (string) "UTF-16";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.parse.codec']/class[@name='CharEncoding']/field[@name='UTF_16BE']"
		[Register ("UTF_16BE")]
		public const string Utf16be = (string) "UTF-16BE";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.parse.codec']/class[@name='CharEncoding']/field[@name='UTF_16LE']"
		[Register ("UTF_16LE")]
		public const string Utf16le = (string) "UTF-16LE";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.parse.codec']/class[@name='CharEncoding']/field[@name='UTF_8']"
		[Register ("UTF_8")]
		public const string Utf8 = (string) "UTF-8";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/parse/codec/CharEncoding", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CharEncoding); }
		}

		protected CharEncoding (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.parse.codec']/class[@name='CharEncoding']/constructor[@name='CharEncoding' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public CharEncoding () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (CharEncoding)) {
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

	}
}
