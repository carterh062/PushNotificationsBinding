using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Parse {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.parse']/class[@name='CountCallback']"
	[global::Android.Runtime.Register ("com/parse/CountCallback", DoNotGenerateAcw=true)]
	public abstract partial class CountCallback : global::Com.Parse.ParseCallback {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/parse/CountCallback", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CountCallback); }
		}

		protected CountCallback (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.parse']/class[@name='CountCallback']/constructor[@name='CountCallback' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public CountCallback () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (CountCallback)) {
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

		static Delegate cb_done_ILcom_parse_ParseException_;
#pragma warning disable 0169
		static Delegate GetDone_ILcom_parse_ParseException_Handler ()
		{
			if (cb_done_ILcom_parse_ParseException_ == null)
				cb_done_ILcom_parse_ParseException_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_Done_ILcom_parse_ParseException_);
			return cb_done_ILcom_parse_ParseException_;
		}

		static void n_Done_ILcom_parse_ParseException_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Parse.CountCallback __this = global::Java.Lang.Object.GetObject<global::Com.Parse.CountCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Parse.ParseException p1 = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseException> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Done (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='CountCallback']/method[@name='done' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.parse.ParseException']]"
		[Register ("done", "(ILcom/parse/ParseException;)V", "GetDone_ILcom_parse_ParseException_Handler")]
		public abstract void Done (int p0, global::Com.Parse.ParseException p1);

	}

	[global::Android.Runtime.Register ("com/parse/CountCallback", DoNotGenerateAcw=true)]
	internal partial class CountCallbackInvoker : CountCallback {

		public CountCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (CountCallbackInvoker); }
		}

		static IntPtr id_done_ILcom_parse_ParseException_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='CountCallback']/method[@name='done' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.parse.ParseException']]"
		[Register ("done", "(ILcom/parse/ParseException;)V", "GetDone_ILcom_parse_ParseException_Handler")]
		public override void Done (int p0, global::Com.Parse.ParseException p1)
		{
			if (id_done_ILcom_parse_ParseException_ == IntPtr.Zero)
				id_done_ILcom_parse_ParseException_ = JNIEnv.GetMethodID (class_ref, "done", "(ILcom/parse/ParseException;)V");
			JNIEnv.CallVoidMethod  (Handle, id_done_ILcom_parse_ParseException_, new JValue (p0), new JValue (p1));
		}

	}

}
