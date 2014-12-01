using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Parse {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.parse']/class[@name='PushCallback']"
	[global::Android.Runtime.Register ("com/parse/PushCallback", DoNotGenerateAcw=true)]
	public abstract partial class PushCallback : global::Java.Lang.Object, global::Java.Lang.IRunnable {


		static IntPtr channel_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='PushCallback']/field[@name='channel']"
		[Register ("channel")]
		protected string Channel {
			get {
				if (channel_jfieldId == IntPtr.Zero)
					channel_jfieldId = JNIEnv.GetFieldID (class_ref, "channel", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, channel_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (channel_jfieldId == IntPtr.Zero)
					channel_jfieldId = JNIEnv.GetFieldID (class_ref, "channel", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetField (Handle, channel_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr localData_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='PushCallback']/field[@name='localData']"
		[Register ("localData")]
		protected global::Org.Json.JSONObject LocalData {
			get {
				if (localData_jfieldId == IntPtr.Zero)
					localData_jfieldId = JNIEnv.GetFieldID (class_ref, "localData", "Lorg/json/JSONObject;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, localData_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (localData_jfieldId == IntPtr.Zero)
					localData_jfieldId = JNIEnv.GetFieldID (class_ref, "localData", "Lorg/json/JSONObject;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, localData_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr pushData_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='PushCallback']/field[@name='pushData']"
		[Register ("pushData")]
		protected global::Org.Json.JSONObject PushData {
			get {
				if (pushData_jfieldId == IntPtr.Zero)
					pushData_jfieldId = JNIEnv.GetFieldID (class_ref, "pushData", "Lorg/json/JSONObject;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, pushData_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (pushData_jfieldId == IntPtr.Zero)
					pushData_jfieldId = JNIEnv.GetFieldID (class_ref, "pushData", "Lorg/json/JSONObject;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, pushData_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr service_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='PushCallback']/field[@name='service']"
		[Register ("service")]
		protected global::Android.App.Service Service {
			get {
				if (service_jfieldId == IntPtr.Zero)
					service_jfieldId = JNIEnv.GetFieldID (class_ref, "service", "Landroid/app/Service;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, service_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.App.Service> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (service_jfieldId == IntPtr.Zero)
					service_jfieldId = JNIEnv.GetFieldID (class_ref, "service", "Landroid/app/Service;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, service_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/parse/PushCallback", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PushCallback); }
		}

		protected PushCallback (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.parse']/class[@name='PushCallback']/constructor[@name='PushCallback' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public PushCallback () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (PushCallback)) {
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

		static Delegate cb_setChannel_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetChannel_Ljava_lang_String_Handler ()
		{
			if (cb_setChannel_Ljava_lang_String_ == null)
				cb_setChannel_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetChannel_Ljava_lang_String_);
			return cb_setChannel_Ljava_lang_String_;
		}

		static void n_SetChannel_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.PushCallback __this = global::Java.Lang.Object.GetObject<global::Com.Parse.PushCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetChannel (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setChannel_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='PushCallback']/method[@name='setChannel' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setChannel", "(Ljava/lang/String;)V", "GetSetChannel_Ljava_lang_String_Handler")]
		public virtual void SetChannel (string p0)
		{
			if (id_setChannel_Ljava_lang_String_ == IntPtr.Zero)
				id_setChannel_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setChannel", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setChannel_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setChannel", "(Ljava/lang/String;)V"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_setLocalData_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetSetLocalData_Lorg_json_JSONObject_Handler ()
		{
			if (cb_setLocalData_Lorg_json_JSONObject_ == null)
				cb_setLocalData_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLocalData_Lorg_json_JSONObject_);
			return cb_setLocalData_Lorg_json_JSONObject_;
		}

		static void n_SetLocalData_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.PushCallback __this = global::Java.Lang.Object.GetObject<global::Com.Parse.PushCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetLocalData (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setLocalData_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='PushCallback']/method[@name='setLocalData' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("setLocalData", "(Lorg/json/JSONObject;)V", "GetSetLocalData_Lorg_json_JSONObject_Handler")]
		public virtual void SetLocalData (global::Org.Json.JSONObject p0)
		{
			if (id_setLocalData_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_setLocalData_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "setLocalData", "(Lorg/json/JSONObject;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setLocalData_Lorg_json_JSONObject_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLocalData", "(Lorg/json/JSONObject;)V"), new JValue (p0));
		}

		static Delegate cb_setPushData_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetSetPushData_Lorg_json_JSONObject_Handler ()
		{
			if (cb_setPushData_Lorg_json_JSONObject_ == null)
				cb_setPushData_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPushData_Lorg_json_JSONObject_);
			return cb_setPushData_Lorg_json_JSONObject_;
		}

		static void n_SetPushData_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.PushCallback __this = global::Java.Lang.Object.GetObject<global::Com.Parse.PushCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetPushData (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setPushData_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='PushCallback']/method[@name='setPushData' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("setPushData", "(Lorg/json/JSONObject;)V", "GetSetPushData_Lorg_json_JSONObject_Handler")]
		public virtual void SetPushData (global::Org.Json.JSONObject p0)
		{
			if (id_setPushData_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_setPushData_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "setPushData", "(Lorg/json/JSONObject;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setPushData_Lorg_json_JSONObject_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPushData", "(Lorg/json/JSONObject;)V"), new JValue (p0));
		}

		static Delegate cb_setService_Landroid_app_Service_;
#pragma warning disable 0169
		static Delegate GetSetService_Landroid_app_Service_Handler ()
		{
			if (cb_setService_Landroid_app_Service_ == null)
				cb_setService_Landroid_app_Service_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetService_Landroid_app_Service_);
			return cb_setService_Landroid_app_Service_;
		}

		static void n_SetService_Landroid_app_Service_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.PushCallback __this = global::Java.Lang.Object.GetObject<global::Com.Parse.PushCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Service p0 = global::Java.Lang.Object.GetObject<global::Android.App.Service> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetService (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setService_Landroid_app_Service_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='PushCallback']/method[@name='setService' and count(parameter)=1 and parameter[1][@type='android.app.Service']]"
		[Register ("setService", "(Landroid/app/Service;)V", "GetSetService_Landroid_app_Service_Handler")]
		public virtual void SetService (global::Android.App.Service p0)
		{
			if (id_setService_Landroid_app_Service_ == IntPtr.Zero)
				id_setService_Landroid_app_Service_ = JNIEnv.GetMethodID (class_ref, "setService", "(Landroid/app/Service;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setService_Landroid_app_Service_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setService", "(Landroid/app/Service;)V"), new JValue (p0));
		}

		static Delegate cb_run;
#pragma warning disable 0169
		static Delegate GetRunHandler ()
		{
			if (cb_run == null)
				cb_run = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Run);
			return cb_run;
		}

		static void n_Run (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.PushCallback __this = global::Java.Lang.Object.GetObject<global::Com.Parse.PushCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Run ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='PushCallback']/method[@name='run' and count(parameter)=0]"
		[Register ("run", "()V", "GetRunHandler")]
		public abstract void Run ();

	}

	[global::Android.Runtime.Register ("com/parse/PushCallback", DoNotGenerateAcw=true)]
	internal partial class PushCallbackInvoker : PushCallback {

		public PushCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (PushCallbackInvoker); }
		}

		static IntPtr id_run;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='PushCallback']/method[@name='run' and count(parameter)=0]"
		[Register ("run", "()V", "GetRunHandler")]
		public override void Run ()
		{
			if (id_run == IntPtr.Zero)
				id_run = JNIEnv.GetMethodID (class_ref, "run", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_run);
		}

	}

}
