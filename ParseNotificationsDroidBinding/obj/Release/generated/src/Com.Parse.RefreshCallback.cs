using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Parse {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.parse']/class[@name='RefreshCallback']"
	[global::Android.Runtime.Register ("com/parse/RefreshCallback", DoNotGenerateAcw=true)]
	public abstract partial class RefreshCallback : global::Com.Parse.ParseCallback {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/parse/RefreshCallback", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RefreshCallback); }
		}

		protected RefreshCallback (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.parse']/class[@name='RefreshCallback']/constructor[@name='RefreshCallback' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public RefreshCallback () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (RefreshCallback)) {
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

		static Delegate cb_done_Lcom_parse_ParseObject_Lcom_parse_ParseException_;
#pragma warning disable 0169
		static Delegate GetDone_Lcom_parse_ParseObject_Lcom_parse_ParseException_Handler ()
		{
			if (cb_done_Lcom_parse_ParseObject_Lcom_parse_ParseException_ == null)
				cb_done_Lcom_parse_ParseObject_Lcom_parse_ParseException_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Done_Lcom_parse_ParseObject_Lcom_parse_ParseException_);
			return cb_done_Lcom_parse_ParseObject_Lcom_parse_ParseException_;
		}

		static void n_Done_Lcom_parse_ParseObject_Lcom_parse_ParseException_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Parse.RefreshCallback __this = global::Java.Lang.Object.GetObject<global::Com.Parse.RefreshCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Parse.ParseObject p0 = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseObject> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Parse.ParseException p1 = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseException> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Done (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='RefreshCallback']/method[@name='done' and count(parameter)=2 and parameter[1][@type='com.parse.ParseObject'] and parameter[2][@type='com.parse.ParseException']]"
		[Register ("done", "(Lcom/parse/ParseObject;Lcom/parse/ParseException;)V", "GetDone_Lcom_parse_ParseObject_Lcom_parse_ParseException_Handler")]
		public abstract void Done (global::Com.Parse.ParseObject p0, global::Com.Parse.ParseException p1);

	}

	[global::Android.Runtime.Register ("com/parse/RefreshCallback", DoNotGenerateAcw=true)]
	internal partial class RefreshCallbackInvoker : RefreshCallback {

		public RefreshCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (RefreshCallbackInvoker); }
		}

		static IntPtr id_done_Lcom_parse_ParseObject_Lcom_parse_ParseException_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='RefreshCallback']/method[@name='done' and count(parameter)=2 and parameter[1][@type='com.parse.ParseObject'] and parameter[2][@type='com.parse.ParseException']]"
		[Register ("done", "(Lcom/parse/ParseObject;Lcom/parse/ParseException;)V", "GetDone_Lcom_parse_ParseObject_Lcom_parse_ParseException_Handler")]
		public override void Done (global::Com.Parse.ParseObject p0, global::Com.Parse.ParseException p1)
		{
			if (id_done_Lcom_parse_ParseObject_Lcom_parse_ParseException_ == IntPtr.Zero)
				id_done_Lcom_parse_ParseObject_Lcom_parse_ParseException_ = JNIEnv.GetMethodID (class_ref, "done", "(Lcom/parse/ParseObject;Lcom/parse/ParseException;)V");
			JNIEnv.CallVoidMethod  (Handle, id_done_Lcom_parse_ParseObject_Lcom_parse_ParseException_, new JValue (p0), new JValue (p1));
		}

	}

}
