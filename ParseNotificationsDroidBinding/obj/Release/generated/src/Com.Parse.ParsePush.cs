using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Parse {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.parse']/class[@name='ParsePush']"
	[global::Android.Runtime.Register ("com/parse/ParsePush", DoNotGenerateAcw=true)]
	public partial class ParsePush : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/parse/ParsePush", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ParsePush); }
		}

		protected ParsePush (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.parse']/class[@name='ParsePush']/constructor[@name='ParsePush' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public ParsePush () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ParsePush)) {
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

		static Delegate cb_clearExpiration;
#pragma warning disable 0169
		static Delegate GetClearExpirationHandler ()
		{
			if (cb_clearExpiration == null)
				cb_clearExpiration = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ClearExpiration);
			return cb_clearExpiration;
		}

		static void n_ClearExpiration (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.ParsePush __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParsePush> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearExpiration ();
		}
#pragma warning restore 0169

		static IntPtr id_clearExpiration;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParsePush']/method[@name='clearExpiration' and count(parameter)=0]"
		[Register ("clearExpiration", "()V", "GetClearExpirationHandler")]
		public virtual void ClearExpiration ()
		{
			if (id_clearExpiration == IntPtr.Zero)
				id_clearExpiration = JNIEnv.GetMethodID (class_ref, "clearExpiration", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_clearExpiration);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clearExpiration", "()V"));
		}

		static Delegate cb_send;
#pragma warning disable 0169
		static Delegate GetSendHandler ()
		{
			if (cb_send == null)
				cb_send = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Send);
			return cb_send;
		}

		static void n_Send (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.ParsePush __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParsePush> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Send ();
		}
#pragma warning restore 0169

		static IntPtr id_send;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParsePush']/method[@name='send' and count(parameter)=0]"
		[Register ("send", "()V", "GetSendHandler")]
		public virtual void Send ()
		{
			if (id_send == IntPtr.Zero)
				id_send = JNIEnv.GetMethodID (class_ref, "send", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_send);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "send", "()V"));
		}

		static IntPtr id_sendDataInBackground_Lorg_json_JSONObject_Lcom_parse_ParseQuery_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParsePush']/method[@name='sendDataInBackground' and count(parameter)=2 and parameter[1][@type='org.json.JSONObject'] and parameter[2][@type='com.parse.ParseQuery']]"
		[Register ("sendDataInBackground", "(Lorg/json/JSONObject;Lcom/parse/ParseQuery;)V", "")]
		public static void SendDataInBackground (global::Org.Json.JSONObject p0, global::Com.Parse.ParseQuery p1)
		{
			if (id_sendDataInBackground_Lorg_json_JSONObject_Lcom_parse_ParseQuery_ == IntPtr.Zero)
				id_sendDataInBackground_Lorg_json_JSONObject_Lcom_parse_ParseQuery_ = JNIEnv.GetStaticMethodID (class_ref, "sendDataInBackground", "(Lorg/json/JSONObject;Lcom/parse/ParseQuery;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_sendDataInBackground_Lorg_json_JSONObject_Lcom_parse_ParseQuery_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_sendDataInBackground_Lorg_json_JSONObject_Lcom_parse_ParseQuery_Lcom_parse_SendCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParsePush']/method[@name='sendDataInBackground' and count(parameter)=3 and parameter[1][@type='org.json.JSONObject'] and parameter[2][@type='com.parse.ParseQuery'] and parameter[3][@type='com.parse.SendCallback']]"
		[Register ("sendDataInBackground", "(Lorg/json/JSONObject;Lcom/parse/ParseQuery;Lcom/parse/SendCallback;)V", "")]
		public static void SendDataInBackground (global::Org.Json.JSONObject p0, global::Com.Parse.ParseQuery p1, global::Com.Parse.SendCallback p2)
		{
			if (id_sendDataInBackground_Lorg_json_JSONObject_Lcom_parse_ParseQuery_Lcom_parse_SendCallback_ == IntPtr.Zero)
				id_sendDataInBackground_Lorg_json_JSONObject_Lcom_parse_ParseQuery_Lcom_parse_SendCallback_ = JNIEnv.GetStaticMethodID (class_ref, "sendDataInBackground", "(Lorg/json/JSONObject;Lcom/parse/ParseQuery;Lcom/parse/SendCallback;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_sendDataInBackground_Lorg_json_JSONObject_Lcom_parse_ParseQuery_Lcom_parse_SendCallback_, new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static Delegate cb_sendInBackground;
#pragma warning disable 0169
		static Delegate GetSendInBackgroundHandler ()
		{
			if (cb_sendInBackground == null)
				cb_sendInBackground = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SendInBackground);
			return cb_sendInBackground;
		}

		static void n_SendInBackground (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.ParsePush __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParsePush> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SendInBackground ();
		}
#pragma warning restore 0169

		static IntPtr id_sendInBackground;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParsePush']/method[@name='sendInBackground' and count(parameter)=0]"
		[Register ("sendInBackground", "()V", "GetSendInBackgroundHandler")]
		public virtual void SendInBackground ()
		{
			if (id_sendInBackground == IntPtr.Zero)
				id_sendInBackground = JNIEnv.GetMethodID (class_ref, "sendInBackground", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_sendInBackground);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendInBackground", "()V"));
		}

		static Delegate cb_sendInBackground_Lcom_parse_SendCallback_;
#pragma warning disable 0169
		static Delegate GetSendInBackground_Lcom_parse_SendCallback_Handler ()
		{
			if (cb_sendInBackground_Lcom_parse_SendCallback_ == null)
				cb_sendInBackground_Lcom_parse_SendCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SendInBackground_Lcom_parse_SendCallback_);
			return cb_sendInBackground_Lcom_parse_SendCallback_;
		}

		static void n_SendInBackground_Lcom_parse_SendCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.ParsePush __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParsePush> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Parse.SendCallback p0 = global::Java.Lang.Object.GetObject<global::Com.Parse.SendCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SendInBackground (p0);
		}
#pragma warning restore 0169

		static IntPtr id_sendInBackground_Lcom_parse_SendCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParsePush']/method[@name='sendInBackground' and count(parameter)=1 and parameter[1][@type='com.parse.SendCallback']]"
		[Register ("sendInBackground", "(Lcom/parse/SendCallback;)V", "GetSendInBackground_Lcom_parse_SendCallback_Handler")]
		public virtual void SendInBackground (global::Com.Parse.SendCallback p0)
		{
			if (id_sendInBackground_Lcom_parse_SendCallback_ == IntPtr.Zero)
				id_sendInBackground_Lcom_parse_SendCallback_ = JNIEnv.GetMethodID (class_ref, "sendInBackground", "(Lcom/parse/SendCallback;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_sendInBackground_Lcom_parse_SendCallback_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendInBackground", "(Lcom/parse/SendCallback;)V"), new JValue (p0));
		}

		static IntPtr id_sendMessageInBackground_Ljava_lang_String_Lcom_parse_ParseQuery_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParsePush']/method[@name='sendMessageInBackground' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.parse.ParseQuery']]"
		[Register ("sendMessageInBackground", "(Ljava/lang/String;Lcom/parse/ParseQuery;)V", "")]
		public static void SendMessageInBackground (string p0, global::Com.Parse.ParseQuery p1)
		{
			if (id_sendMessageInBackground_Ljava_lang_String_Lcom_parse_ParseQuery_ == IntPtr.Zero)
				id_sendMessageInBackground_Ljava_lang_String_Lcom_parse_ParseQuery_ = JNIEnv.GetStaticMethodID (class_ref, "sendMessageInBackground", "(Ljava/lang/String;Lcom/parse/ParseQuery;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_sendMessageInBackground_Ljava_lang_String_Lcom_parse_ParseQuery_, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_sendMessageInBackground_Ljava_lang_String_Lcom_parse_ParseQuery_Lcom_parse_SendCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParsePush']/method[@name='sendMessageInBackground' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.parse.ParseQuery'] and parameter[3][@type='com.parse.SendCallback']]"
		[Register ("sendMessageInBackground", "(Ljava/lang/String;Lcom/parse/ParseQuery;Lcom/parse/SendCallback;)V", "")]
		public static void SendMessageInBackground (string p0, global::Com.Parse.ParseQuery p1, global::Com.Parse.SendCallback p2)
		{
			if (id_sendMessageInBackground_Ljava_lang_String_Lcom_parse_ParseQuery_Lcom_parse_SendCallback_ == IntPtr.Zero)
				id_sendMessageInBackground_Ljava_lang_String_Lcom_parse_ParseQuery_Lcom_parse_SendCallback_ = JNIEnv.GetStaticMethodID (class_ref, "sendMessageInBackground", "(Ljava/lang/String;Lcom/parse/ParseQuery;Lcom/parse/SendCallback;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_sendMessageInBackground_Ljava_lang_String_Lcom_parse_ParseQuery_Lcom_parse_SendCallback_, new JValue (native_p0), new JValue (p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p0);
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
			global::Com.Parse.ParsePush __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParsePush> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetChannel (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setChannel_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParsePush']/method[@name='setChannel' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_setChannels_Ljava_util_Collection_;
#pragma warning disable 0169
		static Delegate GetSetChannels_Ljava_util_Collection_Handler ()
		{
			if (cb_setChannels_Ljava_util_Collection_ == null)
				cb_setChannels_Ljava_util_Collection_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetChannels_Ljava_util_Collection_);
			return cb_setChannels_Ljava_util_Collection_;
		}

		static void n_SetChannels_Ljava_util_Collection_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.ParsePush __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParsePush> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.ICollection<string> p0 = global::Android.Runtime.JavaCollection<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetChannels (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setChannels_Ljava_util_Collection_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParsePush']/method[@name='setChannels' and count(parameter)=1 and parameter[1][@type='java.util.Collection']]"
		[Register ("setChannels", "(Ljava/util/Collection;)V", "GetSetChannels_Ljava_util_Collection_Handler")]
		public virtual void SetChannels (global::System.Collections.Generic.ICollection<string> p0)
		{
			if (id_setChannels_Ljava_util_Collection_ == IntPtr.Zero)
				id_setChannels_Ljava_util_Collection_ = JNIEnv.GetMethodID (class_ref, "setChannels", "(Ljava/util/Collection;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaCollection<string>.ToLocalJniHandle (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setChannels_Ljava_util_Collection_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setChannels", "(Ljava/util/Collection;)V"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_setData_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetSetData_Lorg_json_JSONObject_Handler ()
		{
			if (cb_setData_Lorg_json_JSONObject_ == null)
				cb_setData_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetData_Lorg_json_JSONObject_);
			return cb_setData_Lorg_json_JSONObject_;
		}

		static void n_SetData_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.ParsePush __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParsePush> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetData (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setData_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParsePush']/method[@name='setData' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("setData", "(Lorg/json/JSONObject;)V", "GetSetData_Lorg_json_JSONObject_Handler")]
		public virtual void SetData (global::Org.Json.JSONObject p0)
		{
			if (id_setData_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_setData_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "setData", "(Lorg/json/JSONObject;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setData_Lorg_json_JSONObject_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setData", "(Lorg/json/JSONObject;)V"), new JValue (p0));
		}

		static Delegate cb_setExpirationTime_J;
#pragma warning disable 0169
		static Delegate GetSetExpirationTime_JHandler ()
		{
			if (cb_setExpirationTime_J == null)
				cb_setExpirationTime_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetExpirationTime_J);
			return cb_setExpirationTime_J;
		}

		static void n_SetExpirationTime_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Parse.ParsePush __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParsePush> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetExpirationTime (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setExpirationTime_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParsePush']/method[@name='setExpirationTime' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setExpirationTime", "(J)V", "GetSetExpirationTime_JHandler")]
		public virtual void SetExpirationTime (long p0)
		{
			if (id_setExpirationTime_J == IntPtr.Zero)
				id_setExpirationTime_J = JNIEnv.GetMethodID (class_ref, "setExpirationTime", "(J)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setExpirationTime_J, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setExpirationTime", "(J)V"), new JValue (p0));
		}

		static Delegate cb_setExpirationTimeInterval_J;
#pragma warning disable 0169
		static Delegate GetSetExpirationTimeInterval_JHandler ()
		{
			if (cb_setExpirationTimeInterval_J == null)
				cb_setExpirationTimeInterval_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetExpirationTimeInterval_J);
			return cb_setExpirationTimeInterval_J;
		}

		static void n_SetExpirationTimeInterval_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Parse.ParsePush __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParsePush> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetExpirationTimeInterval (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setExpirationTimeInterval_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParsePush']/method[@name='setExpirationTimeInterval' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setExpirationTimeInterval", "(J)V", "GetSetExpirationTimeInterval_JHandler")]
		public virtual void SetExpirationTimeInterval (long p0)
		{
			if (id_setExpirationTimeInterval_J == IntPtr.Zero)
				id_setExpirationTimeInterval_J = JNIEnv.GetMethodID (class_ref, "setExpirationTimeInterval", "(J)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setExpirationTimeInterval_J, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setExpirationTimeInterval", "(J)V"), new JValue (p0));
		}

		static Delegate cb_setMessage_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetMessage_Ljava_lang_String_Handler ()
		{
			if (cb_setMessage_Ljava_lang_String_ == null)
				cb_setMessage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMessage_Ljava_lang_String_);
			return cb_setMessage_Ljava_lang_String_;
		}

		static void n_SetMessage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.ParsePush __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParsePush> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetMessage (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setMessage_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParsePush']/method[@name='setMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setMessage", "(Ljava/lang/String;)V", "GetSetMessage_Ljava_lang_String_Handler")]
		public virtual void SetMessage (string p0)
		{
			if (id_setMessage_Ljava_lang_String_ == IntPtr.Zero)
				id_setMessage_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setMessage", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setMessage_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMessage", "(Ljava/lang/String;)V"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_setPushToAndroid_Z;
#pragma warning disable 0169
		static Delegate GetSetPushToAndroid_ZHandler ()
		{
			if (cb_setPushToAndroid_Z == null)
				cb_setPushToAndroid_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetPushToAndroid_Z);
			return cb_setPushToAndroid_Z;
		}

		static void n_SetPushToAndroid_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Parse.ParsePush __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParsePush> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetPushToAndroid (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setPushToAndroid_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParsePush']/method[@name='setPushToAndroid' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setPushToAndroid", "(Z)V", "GetSetPushToAndroid_ZHandler")]
		public virtual void SetPushToAndroid (bool p0)
		{
			if (id_setPushToAndroid_Z == IntPtr.Zero)
				id_setPushToAndroid_Z = JNIEnv.GetMethodID (class_ref, "setPushToAndroid", "(Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setPushToAndroid_Z, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPushToAndroid", "(Z)V"), new JValue (p0));
		}

		static Delegate cb_setPushToIOS_Z;
#pragma warning disable 0169
		static Delegate GetSetPushToIOS_ZHandler ()
		{
			if (cb_setPushToIOS_Z == null)
				cb_setPushToIOS_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetPushToIOS_Z);
			return cb_setPushToIOS_Z;
		}

		static void n_SetPushToIOS_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Parse.ParsePush __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParsePush> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetPushToIOS (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setPushToIOS_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParsePush']/method[@name='setPushToIOS' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setPushToIOS", "(Z)V", "GetSetPushToIOS_ZHandler")]
		public virtual void SetPushToIOS (bool p0)
		{
			if (id_setPushToIOS_Z == IntPtr.Zero)
				id_setPushToIOS_Z = JNIEnv.GetMethodID (class_ref, "setPushToIOS", "(Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setPushToIOS_Z, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPushToIOS", "(Z)V"), new JValue (p0));
		}

		static Delegate cb_setQuery_Lcom_parse_ParseQuery_;
#pragma warning disable 0169
		static Delegate GetSetQuery_Lcom_parse_ParseQuery_Handler ()
		{
			if (cb_setQuery_Lcom_parse_ParseQuery_ == null)
				cb_setQuery_Lcom_parse_ParseQuery_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetQuery_Lcom_parse_ParseQuery_);
			return cb_setQuery_Lcom_parse_ParseQuery_;
		}

		static void n_SetQuery_Lcom_parse_ParseQuery_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.ParsePush __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParsePush> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Parse.ParseQuery p0 = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetQuery (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setQuery_Lcom_parse_ParseQuery_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParsePush']/method[@name='setQuery' and count(parameter)=1 and parameter[1][@type='com.parse.ParseQuery']]"
		[Register ("setQuery", "(Lcom/parse/ParseQuery;)V", "GetSetQuery_Lcom_parse_ParseQuery_Handler")]
		public virtual void SetQuery (global::Com.Parse.ParseQuery p0)
		{
			if (id_setQuery_Lcom_parse_ParseQuery_ == IntPtr.Zero)
				id_setQuery_Lcom_parse_ParseQuery_ = JNIEnv.GetMethodID (class_ref, "setQuery", "(Lcom/parse/ParseQuery;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setQuery_Lcom_parse_ParseQuery_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setQuery", "(Lcom/parse/ParseQuery;)V"), new JValue (p0));
		}

	}
}
