using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Parse.Oauth {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.parse.oauth']/class[@name='OAuth1FlowDialog']"
	[global::Android.Runtime.Register ("com/parse/oauth/OAuth1FlowDialog", DoNotGenerateAcw=true)]
	public partial class OAuth1FlowDialog : global::Android.App.Dialog {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.parse.oauth']/interface[@name='OAuth1FlowDialog.FlowResultHandler']"
		[Register ("com/parse/oauth/OAuth1FlowDialog$FlowResultHandler", "", "Com.Parse.Oauth.OAuth1FlowDialog/IFlowResultHandlerInvoker")]
		public partial interface IFlowResultHandler : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.oauth']/interface[@name='OAuth1FlowDialog.FlowResultHandler']/method[@name='onCancel' and count(parameter)=0]"
			[Register ("onCancel", "()V", "GetOnCancelHandler:Com.Parse.Oauth.OAuth1FlowDialog/IFlowResultHandlerInvoker, ParseNotificationsDroidBinding")]
			void OnCancel ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.oauth']/interface[@name='OAuth1FlowDialog.FlowResultHandler']/method[@name='onComplete' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("onComplete", "(Ljava/lang/String;)V", "GetOnComplete_Ljava_lang_String_Handler:Com.Parse.Oauth.OAuth1FlowDialog/IFlowResultHandlerInvoker, ParseNotificationsDroidBinding")]
			void OnComplete (string p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.oauth']/interface[@name='OAuth1FlowDialog.FlowResultHandler']/method[@name='onError' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
			[Register ("onError", "(ILjava/lang/String;Ljava/lang/String;)V", "GetOnError_ILjava_lang_String_Ljava_lang_String_Handler:Com.Parse.Oauth.OAuth1FlowDialog/IFlowResultHandlerInvoker, ParseNotificationsDroidBinding")]
			void OnError (int p0, string p1, string p2);

		}

		[global::Android.Runtime.Register ("com/parse/oauth/OAuth1FlowDialog$FlowResultHandler", DoNotGenerateAcw=true)]
		internal class IFlowResultHandlerInvoker : global::Java.Lang.Object, IFlowResultHandler {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/parse/oauth/OAuth1FlowDialog$FlowResultHandler");
			IntPtr class_ref;

			public static IFlowResultHandler GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IFlowResultHandler> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.parse.oauth.OAuth1FlowDialog.FlowResultHandler"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IFlowResultHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IFlowResultHandlerInvoker); }
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
				global::Com.Parse.Oauth.OAuth1FlowDialog.IFlowResultHandler __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Oauth.OAuth1FlowDialog.IFlowResultHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

			static Delegate cb_onComplete_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnComplete_Ljava_lang_String_Handler ()
			{
				if (cb_onComplete_Ljava_lang_String_ == null)
					cb_onComplete_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnComplete_Ljava_lang_String_);
				return cb_onComplete_Ljava_lang_String_;
			}

			static void n_OnComplete_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Parse.Oauth.OAuth1FlowDialog.IFlowResultHandler __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Oauth.OAuth1FlowDialog.IFlowResultHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnComplete (p0);
			}
#pragma warning restore 0169

			IntPtr id_onComplete_Ljava_lang_String_;
			public void OnComplete (string p0)
			{
				if (id_onComplete_Ljava_lang_String_ == IntPtr.Zero)
					id_onComplete_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onComplete", "(Ljava/lang/String;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				JNIEnv.CallVoidMethod (Handle, id_onComplete_Ljava_lang_String_, new JValue (native_p0));
				JNIEnv.DeleteLocalRef (native_p0);
			}

			static Delegate cb_onError_ILjava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnError_ILjava_lang_String_Ljava_lang_String_Handler ()
			{
				if (cb_onError_ILjava_lang_String_Ljava_lang_String_ == null)
					cb_onError_ILjava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr, IntPtr>) n_OnError_ILjava_lang_String_Ljava_lang_String_);
				return cb_onError_ILjava_lang_String_Ljava_lang_String_;
			}

			static void n_OnError_ILjava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2)
			{
				global::Com.Parse.Oauth.OAuth1FlowDialog.IFlowResultHandler __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Oauth.OAuth1FlowDialog.IFlowResultHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
				string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
				__this.OnError (p0, p1, p2);
			}
#pragma warning restore 0169

			IntPtr id_onError_ILjava_lang_String_Ljava_lang_String_;
			public void OnError (int p0, string p1, string p2)
			{
				if (id_onError_ILjava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_onError_ILjava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onError", "(ILjava/lang/String;Ljava/lang/String;)V");
				IntPtr native_p1 = JNIEnv.NewString (p1);
				IntPtr native_p2 = JNIEnv.NewString (p2);
				JNIEnv.CallVoidMethod (Handle, id_onError_ILjava_lang_String_Ljava_lang_String_, new JValue (p0), new JValue (native_p1), new JValue (native_p2));
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.parse.oauth']/class[@name='OAuth1FlowDialog.OAuth1WebViewClient']"
		[global::Android.Runtime.Register ("com/parse/oauth/OAuth1FlowDialog$OAuth1WebViewClient", DoNotGenerateAcw=true)]
		public partial class OAuth1WebViewClient : global::Android.Webkit.WebViewClient {

			protected OAuth1WebViewClient (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/parse/oauth/OAuth1FlowDialog", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (OAuth1FlowDialog); }
		}

		protected OAuth1FlowDialog (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_parse_oauth_OAuth1FlowDialog_FlowResultHandler_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.parse.oauth']/class[@name='OAuth1FlowDialog']/constructor[@name='OAuth1FlowDialog' and count(parameter)=5 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='com.parse.oauth.OAuth1FlowDialog.FlowResultHandler']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/parse/oauth/OAuth1FlowDialog$FlowResultHandler;)V", "")]
		public OAuth1FlowDialog (global::Android.Content.Context p0, string p1, string p2, string p3, global::Com.Parse.Oauth.OAuth1FlowDialog.IFlowResultHandler p4) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);;
			IntPtr native_p2 = JNIEnv.NewString (p2);;
			IntPtr native_p3 = JNIEnv.NewString (p3);;
			if (GetType () != typeof (OAuth1FlowDialog)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/parse/oauth/OAuth1FlowDialog$FlowResultHandler;)V", new JValue (p0), new JValue (native_p1), new JValue (native_p2), new JValue (native_p3), new JValue (p4)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/parse/oauth/OAuth1FlowDialog$FlowResultHandler;)V", new JValue (p0), new JValue (native_p1), new JValue (native_p2), new JValue (native_p3), new JValue (p4));
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				return;
			}

			if (id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_parse_oauth_OAuth1FlowDialog_FlowResultHandler_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_parse_oauth_OAuth1FlowDialog_FlowResultHandler_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/parse/oauth/OAuth1FlowDialog$FlowResultHandler;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_parse_oauth_OAuth1FlowDialog_FlowResultHandler_, new JValue (p0), new JValue (native_p1), new JValue (native_p2), new JValue (native_p3), new JValue (p4)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_parse_oauth_OAuth1FlowDialog_FlowResultHandler_, new JValue (p0), new JValue (native_p1), new JValue (native_p2), new JValue (native_p3), new JValue (p4));
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			JNIEnv.DeleteLocalRef (native_p3);
		}

	}
}
