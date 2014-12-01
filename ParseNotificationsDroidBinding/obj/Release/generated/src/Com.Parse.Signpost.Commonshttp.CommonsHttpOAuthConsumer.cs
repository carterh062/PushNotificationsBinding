using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Parse.Signpost.Commonshttp {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.parse.signpost.commonshttp']/class[@name='CommonsHttpOAuthConsumer']"
	[global::Android.Runtime.Register ("com/parse/signpost/commonshttp/CommonsHttpOAuthConsumer", DoNotGenerateAcw=true)]
	public partial class CommonsHttpOAuthConsumer : global::Com.Parse.Signpost.AbstractOAuthConsumer {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/parse/signpost/commonshttp/CommonsHttpOAuthConsumer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CommonsHttpOAuthConsumer); }
		}

		protected CommonsHttpOAuthConsumer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.parse.signpost.commonshttp']/class[@name='CommonsHttpOAuthConsumer']/constructor[@name='CommonsHttpOAuthConsumer' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public CommonsHttpOAuthConsumer (string p0, string p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);;
			IntPtr native_p1 = JNIEnv.NewString (p1);;
			if (GetType () != typeof (CommonsHttpOAuthConsumer)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Ljava/lang/String;)V", new JValue (native_p0), new JValue (native_p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Ljava/lang/String;)V", new JValue (native_p0), new JValue (native_p1));
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				return;
			}

			if (id_ctor_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_ctor_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_wrap_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetWrap_Ljava_lang_Object_Handler ()
		{
			if (cb_wrap_Ljava_lang_Object_ == null)
				cb_wrap_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Wrap_Ljava_lang_Object_);
			return cb_wrap_Ljava_lang_Object_;
		}

		static IntPtr n_Wrap_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.Signpost.Commonshttp.CommonsHttpOAuthConsumer __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.Commonshttp.CommonsHttpOAuthConsumer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Wrap (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_wrap_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.signpost.commonshttp']/class[@name='CommonsHttpOAuthConsumer']/method[@name='wrap' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("wrap", "(Ljava/lang/Object;)Lcom/parse/signpost/http/HttpRequest;", "GetWrap_Ljava_lang_Object_Handler")]
		protected override global::Com.Parse.Signpost.Http.IHttpRequest Wrap (global::Java.Lang.Object p0)
		{
			if (id_wrap_Ljava_lang_Object_ == IntPtr.Zero)
				id_wrap_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "wrap", "(Ljava/lang/Object;)Lcom/parse/signpost/http/HttpRequest;");

			global::Com.Parse.Signpost.Http.IHttpRequest __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.Http.IHttpRequest> (JNIEnv.CallObjectMethod  (Handle, id_wrap_Ljava_lang_Object_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.Http.IHttpRequest> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "wrap", "(Ljava/lang/Object;)Lcom/parse/signpost/http/HttpRequest;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}
}
