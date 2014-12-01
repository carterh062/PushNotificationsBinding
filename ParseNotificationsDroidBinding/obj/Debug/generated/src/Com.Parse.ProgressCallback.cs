using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Parse {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.parse']/class[@name='ProgressCallback']"
	[global::Android.Runtime.Register ("com/parse/ProgressCallback", DoNotGenerateAcw=true)]
	public abstract partial class ProgressCallback : global::Com.Parse.ParseCallback {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/parse/ProgressCallback", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ProgressCallback); }
		}

		protected ProgressCallback (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.parse']/class[@name='ProgressCallback']/constructor[@name='ProgressCallback' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public ProgressCallback () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ProgressCallback)) {
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

		static Delegate cb_done_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetDone_Ljava_lang_Integer_Handler ()
		{
			if (cb_done_Ljava_lang_Integer_ == null)
				cb_done_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Done_Ljava_lang_Integer_);
			return cb_done_Ljava_lang_Integer_;
		}

		static void n_Done_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.ProgressCallback __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ProgressCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Done (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ProgressCallback']/method[@name='done' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
		[Register ("done", "(Ljava/lang/Integer;)V", "GetDone_Ljava_lang_Integer_Handler")]
		public abstract void Done (global::Java.Lang.Integer p0);

	}

	[global::Android.Runtime.Register ("com/parse/ProgressCallback", DoNotGenerateAcw=true)]
	internal partial class ProgressCallbackInvoker : ProgressCallback {

		public ProgressCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (ProgressCallbackInvoker); }
		}

		static IntPtr id_done_Ljava_lang_Integer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ProgressCallback']/method[@name='done' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
		[Register ("done", "(Ljava/lang/Integer;)V", "GetDone_Ljava_lang_Integer_Handler")]
		public override void Done (global::Java.Lang.Integer p0)
		{
			if (id_done_Ljava_lang_Integer_ == IntPtr.Zero)
				id_done_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "done", "(Ljava/lang/Integer;)V");
			JNIEnv.CallVoidMethod  (Handle, id_done_Ljava_lang_Integer_, new JValue (p0));
		}

	}

}
