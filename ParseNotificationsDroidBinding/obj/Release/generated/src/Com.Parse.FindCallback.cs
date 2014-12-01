using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Parse {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.parse']/class[@name='FindCallback']"
	[global::Android.Runtime.Register ("com/parse/FindCallback", DoNotGenerateAcw=true)]
	public abstract partial class FindCallback : global::Com.Parse.ParseCallback {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/parse/FindCallback", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FindCallback); }
		}

		protected FindCallback (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.parse']/class[@name='FindCallback']/constructor[@name='FindCallback' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public FindCallback () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (FindCallback)) {
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

		static Delegate cb_done_Ljava_util_List_Lcom_parse_ParseException_;
#pragma warning disable 0169
		static Delegate GetDone_Ljava_util_List_Lcom_parse_ParseException_Handler ()
		{
			if (cb_done_Ljava_util_List_Lcom_parse_ParseException_ == null)
				cb_done_Ljava_util_List_Lcom_parse_ParseException_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Done_Ljava_util_List_Lcom_parse_ParseException_);
			return cb_done_Ljava_util_List_Lcom_parse_ParseException_;
		}

		static void n_Done_Ljava_util_List_Lcom_parse_ParseException_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Parse.FindCallback __this = global::Java.Lang.Object.GetObject<global::Com.Parse.FindCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.IList p0 = global::Android.Runtime.JavaList.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Parse.ParseException p1 = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseException> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Done (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='FindCallback']/method[@name='done' and count(parameter)=2 and parameter[1][@type='java.util.List'] and parameter[2][@type='com.parse.ParseException']]"
		[Register ("done", "(Ljava/util/List;Lcom/parse/ParseException;)V", "GetDone_Ljava_util_List_Lcom_parse_ParseException_Handler")]
		public abstract void Done (global::System.Collections.IList p0, global::Com.Parse.ParseException p1);

	}

	[global::Android.Runtime.Register ("com/parse/FindCallback", DoNotGenerateAcw=true)]
	internal partial class FindCallbackInvoker : FindCallback {

		public FindCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (FindCallbackInvoker); }
		}

		static IntPtr id_done_Ljava_util_List_Lcom_parse_ParseException_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='FindCallback']/method[@name='done' and count(parameter)=2 and parameter[1][@type='java.util.List'] and parameter[2][@type='com.parse.ParseException']]"
		[Register ("done", "(Ljava/util/List;Lcom/parse/ParseException;)V", "GetDone_Ljava_util_List_Lcom_parse_ParseException_Handler")]
		public override void Done (global::System.Collections.IList p0, global::Com.Parse.ParseException p1)
		{
			if (id_done_Ljava_util_List_Lcom_parse_ParseException_ == IntPtr.Zero)
				id_done_Ljava_util_List_Lcom_parse_ParseException_ = JNIEnv.GetMethodID (class_ref, "done", "(Ljava/util/List;Lcom/parse/ParseException;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList.ToLocalJniHandle (p0);
			JNIEnv.CallVoidMethod  (Handle, id_done_Ljava_util_List_Lcom_parse_ParseException_, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

}
