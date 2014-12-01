using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Parse {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.parse']/class[@name='ParseInstallation']"
	[global::Android.Runtime.Register ("com/parse/ParseInstallation", DoNotGenerateAcw=true)]
	public partial class ParseInstallation : global::Com.Parse.ParseObject {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/parse/ParseInstallation", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ParseInstallation); }
		}

		protected ParseInstallation (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.parse']/class[@name='ParseInstallation']/constructor[@name='ParseInstallation' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public ParseInstallation () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ParseInstallation)) {
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

		static IntPtr id_getCurrentInstallation;
		public static global::Com.Parse.ParseInstallation CurrentInstallation {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseInstallation']/method[@name='getCurrentInstallation' and count(parameter)=0]"
			[Register ("getCurrentInstallation", "()Lcom/parse/ParseInstallation;", "GetGetCurrentInstallationHandler")]
			get {
				if (id_getCurrentInstallation == IntPtr.Zero)
					id_getCurrentInstallation = JNIEnv.GetStaticMethodID (class_ref, "getCurrentInstallation", "()Lcom/parse/ParseInstallation;");
				return global::Java.Lang.Object.GetObject<global::Com.Parse.ParseInstallation> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getCurrentInstallation), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getInstallationId;
#pragma warning disable 0169
		static Delegate GetGetInstallationIdHandler ()
		{
			if (cb_getInstallationId == null)
				cb_getInstallationId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetInstallationId);
			return cb_getInstallationId;
		}

		static IntPtr n_GetInstallationId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.ParseInstallation __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseInstallation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.InstallationId);
		}
#pragma warning restore 0169

		static IntPtr id_getInstallationId;
		public virtual string InstallationId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseInstallation']/method[@name='getInstallationId' and count(parameter)=0]"
			[Register ("getInstallationId", "()Ljava/lang/String;", "GetGetInstallationIdHandler")]
			get {
				if (id_getInstallationId == IntPtr.Zero)
					id_getInstallationId = JNIEnv.GetMethodID (class_ref, "getInstallationId", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getInstallationId), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getInstallationId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getQuery;
		public static global::Com.Parse.ParseQuery Query {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseInstallation']/method[@name='getQuery' and count(parameter)=0]"
			[Register ("getQuery", "()Lcom/parse/ParseQuery;", "GetGetQueryHandler")]
			get {
				if (id_getQuery == IntPtr.Zero)
					id_getQuery = JNIEnv.GetStaticMethodID (class_ref, "getQuery", "()Lcom/parse/ParseQuery;");
				return global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getQuery), JniHandleOwnership.TransferLocalRef);
			}
		}

	}
}
