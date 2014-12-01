using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Parse.Entity.Mime {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.parse.entity.mime']/class[@name='MIME']"
	[global::Android.Runtime.Register ("com/parse/entity/mime/MIME", DoNotGenerateAcw=true)]
	public sealed partial class MIME : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.parse.entity.mime']/class[@name='MIME']/field[@name='CONTENT_DISPOSITION']"
		[Register ("CONTENT_DISPOSITION")]
		public const string ContentDisposition = (string) "Content-Disposition";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.parse.entity.mime']/class[@name='MIME']/field[@name='CONTENT_TRANSFER_ENC']"
		[Register ("CONTENT_TRANSFER_ENC")]
		public const string ContentTransferEnc = (string) "Content-Transfer-Encoding";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.parse.entity.mime']/class[@name='MIME']/field[@name='CONTENT_TYPE']"
		[Register ("CONTENT_TYPE")]
		public const string ContentType = (string) "Content-Type";

		static IntPtr DEFAULT_CHARSET_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.parse.entity.mime']/class[@name='MIME']/field[@name='DEFAULT_CHARSET']"
		[Register ("DEFAULT_CHARSET")]
		public static global::Java.Nio.Charset.Charset DefaultCharset {
			get {
				if (DEFAULT_CHARSET_jfieldId == IntPtr.Zero)
					DEFAULT_CHARSET_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEFAULT_CHARSET", "Ljava/nio/charset/Charset;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DEFAULT_CHARSET_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Nio.Charset.Charset> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (DEFAULT_CHARSET_jfieldId == IntPtr.Zero)
					DEFAULT_CHARSET_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEFAULT_CHARSET", "Ljava/nio/charset/Charset;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, DEFAULT_CHARSET_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.parse.entity.mime']/class[@name='MIME']/field[@name='ENC_8BIT']"
		[Register ("ENC_8BIT")]
		public const string Enc8bit = (string) "8bit";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.parse.entity.mime']/class[@name='MIME']/field[@name='ENC_BINARY']"
		[Register ("ENC_BINARY")]
		public const string EncBinary = (string) "binary";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/parse/entity/mime/MIME", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MIME); }
		}

		internal MIME (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.parse.entity.mime']/class[@name='MIME']/constructor[@name='MIME' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public MIME () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (MIME)) {
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
