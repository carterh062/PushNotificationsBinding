using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Parse.Gdata {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.parse.gdata']/class[@name='PercentEscaper']"
	[global::Android.Runtime.Register ("com/parse/gdata/PercentEscaper", DoNotGenerateAcw=true)]
	public partial class PercentEscaper : global::Com.Parse.Gdata.UnicodeEscaper {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.parse.gdata']/class[@name='PercentEscaper']/field[@name='SAFECHARS_URLENCODER']"
		[Register ("SAFECHARS_URLENCODER")]
		public const string SafecharsUrlencoder = (string) "-_.*";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.parse.gdata']/class[@name='PercentEscaper']/field[@name='SAFEPATHCHARS_URLENCODER']"
		[Register ("SAFEPATHCHARS_URLENCODER")]
		public const string SafepathcharsUrlencoder = (string) "-_.!~*'()@:$&,;=";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.parse.gdata']/class[@name='PercentEscaper']/field[@name='SAFEQUERYSTRINGCHARS_URLENCODER']"
		[Register ("SAFEQUERYSTRINGCHARS_URLENCODER")]
		public const string SafequerystringcharsUrlencoder = (string) "-_.!~*'()@:$,;/?:";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/parse/gdata/PercentEscaper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PercentEscaper); }
		}

		protected PercentEscaper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Z;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.parse.gdata']/class[@name='PercentEscaper']/constructor[@name='PercentEscaper' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(Ljava/lang/String;Z)V", "")]
		public PercentEscaper (string p0, bool p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);;
			if (GetType () != typeof (PercentEscaper)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Z)V", new JValue (native_p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Z)V", new JValue (native_p0), new JValue (p1));
				JNIEnv.DeleteLocalRef (native_p0);
				return;
			}

			if (id_ctor_Ljava_lang_String_Z == IntPtr.Zero)
				id_ctor_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Z)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Z, new JValue (native_p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Z, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_escape_I;
#pragma warning disable 0169
		static Delegate GetEscape_IHandler ()
		{
			if (cb_escape_I == null)
				cb_escape_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_Escape_I);
			return cb_escape_I;
		}

		static IntPtr n_Escape_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Parse.Gdata.PercentEscaper __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Gdata.PercentEscaper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.Escape (p0));
		}
#pragma warning restore 0169

		static IntPtr id_escape_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.gdata']/class[@name='PercentEscaper']/method[@name='escape' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("escape", "(I)[C", "GetEscape_IHandler")]
		protected override char[] Escape (int p0)
		{
			if (id_escape_I == IntPtr.Zero)
				id_escape_I = JNIEnv.GetMethodID (class_ref, "escape", "(I)[C");

			if (GetType () == ThresholdType)
				return (char[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_escape_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef, typeof (char));
			else
				return (char[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "escape", "(I)[C"), new JValue (p0)), JniHandleOwnership.TransferLocalRef, typeof (char));
		}

	}
}
