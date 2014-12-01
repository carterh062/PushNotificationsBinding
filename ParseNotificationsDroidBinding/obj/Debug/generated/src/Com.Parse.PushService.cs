using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Parse {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.parse']/class[@name='PushService']"
	[global::Android.Runtime.Register ("com/parse/PushService", DoNotGenerateAcw=true)]
	public sealed partial class PushService : global::Android.App.Service {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.parse']/class[@name='PushService.ServiceState']"
		[global::Android.Runtime.Register ("com/parse/PushService$ServiceState", DoNotGenerateAcw=true)]
		public sealed partial class ServiceState : global::Java.Lang.Enum {


			static IntPtr ABORTING_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='PushService.ServiceState']/field[@name='ABORTING']"
			[Register ("ABORTING")]
			public static global::Com.Parse.PushService.ServiceState Aborting {
				get {
					if (ABORTING_jfieldId == IntPtr.Zero)
						ABORTING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ABORTING", "Lcom/parse/PushService$ServiceState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ABORTING_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Parse.PushService.ServiceState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (ABORTING_jfieldId == IntPtr.Zero)
						ABORTING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ABORTING", "Lcom/parse/PushService$ServiceState;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, ABORTING_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr DESTRUCTING_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='PushService.ServiceState']/field[@name='DESTRUCTING']"
			[Register ("DESTRUCTING")]
			public static global::Com.Parse.PushService.ServiceState Destructing {
				get {
					if (DESTRUCTING_jfieldId == IntPtr.Zero)
						DESTRUCTING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DESTRUCTING", "Lcom/parse/PushService$ServiceState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DESTRUCTING_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Parse.PushService.ServiceState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (DESTRUCTING_jfieldId == IntPtr.Zero)
						DESTRUCTING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DESTRUCTING", "Lcom/parse/PushService$ServiceState;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, DESTRUCTING_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr RUNNING_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='PushService.ServiceState']/field[@name='RUNNING']"
			[Register ("RUNNING")]
			public static global::Com.Parse.PushService.ServiceState Running {
				get {
					if (RUNNING_jfieldId == IntPtr.Zero)
						RUNNING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RUNNING", "Lcom/parse/PushService$ServiceState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, RUNNING_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Parse.PushService.ServiceState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (RUNNING_jfieldId == IntPtr.Zero)
						RUNNING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RUNNING", "Lcom/parse/PushService$ServiceState;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, RUNNING_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr STOPPED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='PushService.ServiceState']/field[@name='STOPPED']"
			[Register ("STOPPED")]
			public static global::Com.Parse.PushService.ServiceState Stopped {
				get {
					if (STOPPED_jfieldId == IntPtr.Zero)
						STOPPED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "STOPPED", "Lcom/parse/PushService$ServiceState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, STOPPED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Parse.PushService.ServiceState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (STOPPED_jfieldId == IntPtr.Zero)
						STOPPED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "STOPPED", "Lcom/parse/PushService$ServiceState;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, STOPPED_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/parse/PushService$ServiceState", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ServiceState); }
			}

			internal ServiceState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/parse/PushService", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PushService); }
		}

		internal PushService (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.parse']/class[@name='PushService']/constructor[@name='PushService' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public PushService () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (PushService)) {
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

		static IntPtr id_getSubscriptions_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='PushService']/method[@name='getSubscriptions' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getSubscriptions", "(Landroid/content/Context;)Ljava/util/Set;", "")]
		public static global::System.Collections.Generic.ICollection<string> GetSubscriptions (global::Android.Content.Context p0)
		{
			if (id_getSubscriptions_Landroid_content_Context_ == IntPtr.Zero)
				id_getSubscriptions_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getSubscriptions", "(Landroid/content/Context;)Ljava/util/Set;");
			global::System.Collections.Generic.ICollection<string> __ret = global::Android.Runtime.JavaSet<string>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_getSubscriptions_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_onBind_Landroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='PushService']/method[@name='onBind' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
		[Register ("onBind", "(Landroid/content/Intent;)Landroid/os/IBinder;", "")]
		public override global::Android.OS.IBinder OnBind (global::Android.Content.Intent p0)
		{
			if (id_onBind_Landroid_content_Intent_ == IntPtr.Zero)
				id_onBind_Landroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "onBind", "(Landroid/content/Intent;)Landroid/os/IBinder;");
			global::Android.OS.IBinder __ret = global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (JNIEnv.CallObjectMethod  (Handle, id_onBind_Landroid_content_Intent_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_setDefaultPushCallback_Landroid_content_Context_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='PushService']/method[@name='setDefaultPushCallback' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.Class']]"
		[Register ("setDefaultPushCallback", "(Landroid/content/Context;Ljava/lang/Class;)V", "")]
		public static void SetDefaultPushCallback (global::Android.Content.Context p0, global::Java.Lang.Class p1)
		{
			if (id_setDefaultPushCallback_Landroid_content_Context_Ljava_lang_Class_ == IntPtr.Zero)
				id_setDefaultPushCallback_Landroid_content_Context_Ljava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "setDefaultPushCallback", "(Landroid/content/Context;Ljava/lang/Class;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_setDefaultPushCallback_Landroid_content_Context_Ljava_lang_Class_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_setDefaultPushCallback_Landroid_content_Context_Ljava_lang_Class_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='PushService']/method[@name='setDefaultPushCallback' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.Class'] and parameter[3][@type='int']]"
		[Register ("setDefaultPushCallback", "(Landroid/content/Context;Ljava/lang/Class;I)V", "")]
		public static void SetDefaultPushCallback (global::Android.Content.Context p0, global::Java.Lang.Class p1, int p2)
		{
			if (id_setDefaultPushCallback_Landroid_content_Context_Ljava_lang_Class_I == IntPtr.Zero)
				id_setDefaultPushCallback_Landroid_content_Context_Ljava_lang_Class_I = JNIEnv.GetStaticMethodID (class_ref, "setDefaultPushCallback", "(Landroid/content/Context;Ljava/lang/Class;I)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_setDefaultPushCallback_Landroid_content_Context_Ljava_lang_Class_I, new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static IntPtr id_startServiceIfRequired_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='PushService']/method[@name='startServiceIfRequired' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("startServiceIfRequired", "(Landroid/content/Context;)V", "")]
		public static void StartServiceIfRequired (global::Android.Content.Context p0)
		{
			if (id_startServiceIfRequired_Landroid_content_Context_ == IntPtr.Zero)
				id_startServiceIfRequired_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "startServiceIfRequired", "(Landroid/content/Context;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_startServiceIfRequired_Landroid_content_Context_, new JValue (p0));
		}

		static IntPtr id_subscribe_Landroid_content_Context_Ljava_lang_String_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='PushService']/method[@name='subscribe' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Class']]"
		[Register ("subscribe", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/Class;)V", "")]
		public static void Subscribe (global::Android.Content.Context p0, string p1, global::Java.Lang.Class p2)
		{
			if (id_subscribe_Landroid_content_Context_Ljava_lang_String_Ljava_lang_Class_ == IntPtr.Zero)
				id_subscribe_Landroid_content_Context_Ljava_lang_String_Ljava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "subscribe", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/Class;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_subscribe_Landroid_content_Context_Ljava_lang_String_Ljava_lang_Class_, new JValue (p0), new JValue (native_p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_subscribe_Landroid_content_Context_Ljava_lang_String_Ljava_lang_Class_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='PushService']/method[@name='subscribe' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Class'] and parameter[4][@type='int']]"
		[Register ("subscribe", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/Class;I)V", "")]
		public static void Subscribe (global::Android.Content.Context p0, string p1, global::Java.Lang.Class p2, int p3)
		{
			if (id_subscribe_Landroid_content_Context_Ljava_lang_String_Ljava_lang_Class_I == IntPtr.Zero)
				id_subscribe_Landroid_content_Context_Ljava_lang_String_Ljava_lang_Class_I = JNIEnv.GetStaticMethodID (class_ref, "subscribe", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/Class;I)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_subscribe_Landroid_content_Context_Ljava_lang_String_Ljava_lang_Class_I, new JValue (p0), new JValue (native_p1), new JValue (p2), new JValue (p3));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_unsubscribe_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='PushService']/method[@name='unsubscribe' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("unsubscribe", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public static void Unsubscribe (global::Android.Content.Context p0, string p1)
		{
			if (id_unsubscribe_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_unsubscribe_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "unsubscribe", "(Landroid/content/Context;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_unsubscribe_Landroid_content_Context_Ljava_lang_String_, new JValue (p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p1);
		}

	}
}
