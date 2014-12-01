using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Parse.Internal {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.parse.internal']/interface[@name='AsyncCallback']"
	[Register ("com/parse/internal/AsyncCallback", "", "Com.Parse.Internal.IAsyncCallbackInvoker")]
	public partial interface IAsyncCallback : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.internal']/interface[@name='AsyncCallback']/method[@name='onCancel' and count(parameter)=0]"
		[Register ("onCancel", "()V", "GetOnCancelHandler:Com.Parse.Internal.IAsyncCallbackInvoker, ParseNotificationsDroidBinding")]
		void OnCancel ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.internal']/interface[@name='AsyncCallback']/method[@name='onFailure' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("onFailure", "(Ljava/lang/Throwable;)V", "GetOnFailure_Ljava_lang_Throwable_Handler:Com.Parse.Internal.IAsyncCallbackInvoker, ParseNotificationsDroidBinding")]
		void OnFailure (global::Java.Lang.Throwable p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.internal']/interface[@name='AsyncCallback']/method[@name='onSuccess' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("onSuccess", "(Ljava/lang/Object;)V", "GetOnSuccess_Ljava_lang_Object_Handler:Com.Parse.Internal.IAsyncCallbackInvoker, ParseNotificationsDroidBinding")]
		void OnSuccess (global::Java.Lang.Object p0);

	}

	[global::Android.Runtime.Register ("com/parse/internal/AsyncCallback", DoNotGenerateAcw=true)]
	internal class IAsyncCallbackInvoker : global::Java.Lang.Object, IAsyncCallback {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/parse/internal/AsyncCallback");
		IntPtr class_ref;

		public static IAsyncCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAsyncCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.parse.internal.AsyncCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAsyncCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IAsyncCallbackInvoker); }
		}

		static Delegate cb_onCancel;
#pragma warning disable 0169
		static Delegate GetOnCancelHandler ()
		{
			if (cb_onCancel == null)
				cb_onCancel = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnCancel);
			return cb_onCancel;
		}

		static void n_OnCancel (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.Internal.IAsyncCallback __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Internal.IAsyncCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnCancel ();
		}
#pragma warning restore 0169

		IntPtr id_onCancel;
		public void OnCancel ()
		{
			if (id_onCancel == IntPtr.Zero)
				id_onCancel = JNIEnv.GetMethodID (class_ref, "onCancel", "()V");
			JNIEnv.CallVoidMethod (Handle, id_onCancel);
		}

		static Delegate cb_onFailure_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetOnFailure_Ljava_lang_Throwable_Handler ()
		{
			if (cb_onFailure_Ljava_lang_Throwable_ == null)
				cb_onFailure_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnFailure_Ljava_lang_Throwable_);
			return cb_onFailure_Ljava_lang_Throwable_;
		}

		static void n_OnFailure_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.Internal.IAsyncCallback __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Internal.IAsyncCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnFailure (p0);
		}
#pragma warning restore 0169

		IntPtr id_onFailure_Ljava_lang_Throwable_;
		public void OnFailure (global::Java.Lang.Throwable p0)
		{
			if (id_onFailure_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_onFailure_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "onFailure", "(Ljava/lang/Throwable;)V");
			JNIEnv.CallVoidMethod (Handle, id_onFailure_Ljava_lang_Throwable_, new JValue (p0));
		}

		static Delegate cb_onSuccess_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetOnSuccess_Ljava_lang_Object_Handler ()
		{
			if (cb_onSuccess_Ljava_lang_Object_ == null)
				cb_onSuccess_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnSuccess_Ljava_lang_Object_);
			return cb_onSuccess_Ljava_lang_Object_;
		}

		static void n_OnSuccess_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.Internal.IAsyncCallback __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Internal.IAsyncCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSuccess (p0);
		}
#pragma warning restore 0169

		IntPtr id_onSuccess_Ljava_lang_Object_;
		public void OnSuccess (global::Java.Lang.Object p0)
		{
			if (id_onSuccess_Ljava_lang_Object_ == IntPtr.Zero)
				id_onSuccess_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "onSuccess", "(Ljava/lang/Object;)V");
			JNIEnv.CallVoidMethod (Handle, id_onSuccess_Ljava_lang_Object_, new JValue (p0));
		}

	}

}
