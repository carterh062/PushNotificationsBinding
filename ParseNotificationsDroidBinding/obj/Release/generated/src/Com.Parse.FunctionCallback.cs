using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Parse {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.parse']/class[@name='FunctionCallback']"
	[global::Android.Runtime.Register ("com/parse/FunctionCallback", DoNotGenerateAcw=true)]
	public abstract partial class FunctionCallback : global::Com.Parse.ParseCallback {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/parse/FunctionCallback", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FunctionCallback); }
		}

		protected FunctionCallback (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.parse']/class[@name='FunctionCallback']/constructor[@name='FunctionCallback' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public FunctionCallback () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (FunctionCallback)) {
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

		static Delegate cb_done_Ljava_lang_Object_Lcom_parse_ParseException_;
#pragma warning disable 0169
		static Delegate GetDone_Ljava_lang_Object_Lcom_parse_ParseException_Handler ()
		{
			if (cb_done_Ljava_lang_Object_Lcom_parse_ParseException_ == null)
				cb_done_Ljava_lang_Object_Lcom_parse_ParseException_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Done_Ljava_lang_Object_Lcom_parse_ParseException_);
			return cb_done_Ljava_lang_Object_Lcom_parse_ParseException_;
		}

		static void n_Done_Ljava_lang_Object_Lcom_parse_ParseException_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Parse.FunctionCallback __this = global::Java.Lang.Object.GetObject<global::Com.Parse.FunctionCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Parse.ParseException p1 = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseException> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Done (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='FunctionCallback']/method[@name='done' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='com.parse.ParseException']]"
		[Register ("done", "(Ljava/lang/Object;Lcom/parse/ParseException;)V", "GetDone_Ljava_lang_Object_Lcom_parse_ParseException_Handler")]
		public abstract void Done (global::Java.Lang.Object p0, global::Com.Parse.ParseException p1);

	}

	[global::Android.Runtime.Register ("com/parse/FunctionCallback", DoNotGenerateAcw=true)]
	internal partial class FunctionCallbackInvoker : FunctionCallback {

		public FunctionCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (FunctionCallbackInvoker); }
		}

		static IntPtr id_done_Ljava_lang_Object_Lcom_parse_ParseException_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='FunctionCallback']/method[@name='done' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='com.parse.ParseException']]"
		[Register ("done", "(Ljava/lang/Object;Lcom/parse/ParseException;)V", "GetDone_Ljava_lang_Object_Lcom_parse_ParseException_Handler")]
		public override void Done (global::Java.Lang.Object p0, global::Com.Parse.ParseException p1)
		{
			if (id_done_Ljava_lang_Object_Lcom_parse_ParseException_ == IntPtr.Zero)
				id_done_Ljava_lang_Object_Lcom_parse_ParseException_ = JNIEnv.GetMethodID (class_ref, "done", "(Ljava/lang/Object;Lcom/parse/ParseException;)V");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JNIEnv.CallVoidMethod  (Handle, id_done_Ljava_lang_Object_Lcom_parse_ParseException_, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

}
