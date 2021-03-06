using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Parse.Signpost.Commonshttp {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.parse.signpost.commonshttp']/class[@name='HttpResponseAdapter']"
	[global::Android.Runtime.Register ("com/parse/signpost/commonshttp/HttpResponseAdapter", DoNotGenerateAcw=true)]
	public partial class HttpResponseAdapter : global::Java.Lang.Object, global::Com.Parse.Signpost.Http.IHttpResponse {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/parse/signpost/commonshttp/HttpResponseAdapter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HttpResponseAdapter); }
		}

		protected HttpResponseAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_apache_http_HttpResponse_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.parse.signpost.commonshttp']/class[@name='HttpResponseAdapter']/constructor[@name='HttpResponseAdapter' and count(parameter)=1 and parameter[1][@type='org.apache.http.HttpResponse']]"
		[Register (".ctor", "(Lorg/apache/http/HttpResponse;)V", "")]
		public HttpResponseAdapter (global::Org.Apache.Http.IHttpResponse p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (HttpResponseAdapter)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/apache/http/HttpResponse;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorg/apache/http/HttpResponse;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Lorg_apache_http_HttpResponse_ == IntPtr.Zero)
				id_ctor_Lorg_apache_http_HttpResponse_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/apache/http/HttpResponse;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_apache_http_HttpResponse_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_apache_http_HttpResponse_, new JValue (p0));
		}

		static Delegate cb_getContent;
#pragma warning disable 0169
		static Delegate GetGetContentHandler ()
		{
			if (cb_getContent == null)
				cb_getContent = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContent);
			return cb_getContent;
		}

		static IntPtr n_GetContent (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.Signpost.Commonshttp.HttpResponseAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.Commonshttp.HttpResponseAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (__this.Content);
		}
#pragma warning restore 0169

		static IntPtr id_getContent;
		public virtual global::System.IO.Stream Content {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.signpost.commonshttp']/class[@name='HttpResponseAdapter']/method[@name='getContent' and count(parameter)=0]"
			[Register ("getContent", "()Ljava/io/InputStream;", "GetGetContentHandler")]
			get {
				if (id_getContent == IntPtr.Zero)
					id_getContent = JNIEnv.GetMethodID (class_ref, "getContent", "()Ljava/io/InputStream;");

				if (GetType () == ThresholdType)
					return global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getContent), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getContent", "()Ljava/io/InputStream;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getReasonPhrase;
#pragma warning disable 0169
		static Delegate GetGetReasonPhraseHandler ()
		{
			if (cb_getReasonPhrase == null)
				cb_getReasonPhrase = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetReasonPhrase);
			return cb_getReasonPhrase;
		}

		static IntPtr n_GetReasonPhrase (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.Signpost.Commonshttp.HttpResponseAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.Commonshttp.HttpResponseAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ReasonPhrase);
		}
#pragma warning restore 0169

		static IntPtr id_getReasonPhrase;
		public virtual string ReasonPhrase {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.signpost.commonshttp']/class[@name='HttpResponseAdapter']/method[@name='getReasonPhrase' and count(parameter)=0]"
			[Register ("getReasonPhrase", "()Ljava/lang/String;", "GetGetReasonPhraseHandler")]
			get {
				if (id_getReasonPhrase == IntPtr.Zero)
					id_getReasonPhrase = JNIEnv.GetMethodID (class_ref, "getReasonPhrase", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getReasonPhrase), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getReasonPhrase", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getStatusCode;
#pragma warning disable 0169
		static Delegate GetGetStatusCodeHandler ()
		{
			if (cb_getStatusCode == null)
				cb_getStatusCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetStatusCode);
			return cb_getStatusCode;
		}

		static int n_GetStatusCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.Signpost.Commonshttp.HttpResponseAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.Commonshttp.HttpResponseAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StatusCode;
		}
#pragma warning restore 0169

		static IntPtr id_getStatusCode;
		public virtual int StatusCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.signpost.commonshttp']/class[@name='HttpResponseAdapter']/method[@name='getStatusCode' and count(parameter)=0]"
			[Register ("getStatusCode", "()I", "GetGetStatusCodeHandler")]
			get {
				if (id_getStatusCode == IntPtr.Zero)
					id_getStatusCode = JNIEnv.GetMethodID (class_ref, "getStatusCode", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getStatusCode);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStatusCode", "()I"));
			}
		}

		static Delegate cb_unwrap;
#pragma warning disable 0169
		static Delegate GetUnwrapHandler ()
		{
			if (cb_unwrap == null)
				cb_unwrap = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Unwrap);
			return cb_unwrap;
		}

		static IntPtr n_Unwrap (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.Signpost.Commonshttp.HttpResponseAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Signpost.Commonshttp.HttpResponseAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Unwrap ());
		}
#pragma warning restore 0169

		static IntPtr id_unwrap;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.signpost.commonshttp']/class[@name='HttpResponseAdapter']/method[@name='unwrap' and count(parameter)=0]"
		[Register ("unwrap", "()Ljava/lang/Object;", "GetUnwrapHandler")]
		public virtual global::Java.Lang.Object Unwrap ()
		{
			if (id_unwrap == IntPtr.Zero)
				id_unwrap = JNIEnv.GetMethodID (class_ref, "unwrap", "()Ljava/lang/Object;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_unwrap), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "unwrap", "()Ljava/lang/Object;")), JniHandleOwnership.TransferLocalRef);
		}

	}
}
