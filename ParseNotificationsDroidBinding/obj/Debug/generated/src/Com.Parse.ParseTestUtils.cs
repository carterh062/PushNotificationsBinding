using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Parse {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.parse']/class[@name='ParseTestUtils']"
	[global::Android.Runtime.Register ("com/parse/ParseTestUtils", DoNotGenerateAcw=true)]
	public partial class ParseTestUtils : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/parse/ParseTestUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ParseTestUtils); }
		}

		protected ParseTestUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.parse']/class[@name='ParseTestUtils']/constructor[@name='ParseTestUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public ParseTestUtils () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ParseTestUtils)) {
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

		static IntPtr id_getIgnoreAfterTime;
		public static string IgnoreAfterTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseTestUtils']/method[@name='getIgnoreAfterTime' and count(parameter)=0]"
			[Register ("getIgnoreAfterTime", "()Ljava/lang/String;", "GetGetIgnoreAfterTimeHandler")]
			get {
				if (id_getIgnoreAfterTime == IntPtr.Zero)
					id_getIgnoreAfterTime = JNIEnv.GetStaticMethodID (class_ref, "getIgnoreAfterTime", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getIgnoreAfterTime), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getLastTime;
		public static string LastTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseTestUtils']/method[@name='getLastTime' and count(parameter)=0]"
			[Register ("getLastTime", "()Ljava/lang/String;", "GetGetLastTimeHandler")]
			get {
				if (id_getLastTime == IntPtr.Zero)
					id_getLastTime = JNIEnv.GetStaticMethodID (class_ref, "getLastTime", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getLastTime), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_allowSleep_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseTestUtils']/method[@name='allowSleep' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("allowSleep", "(I)V", "")]
		public static void AllowSleep (int p0)
		{
			if (id_allowSleep_I == IntPtr.Zero)
				id_allowSleep_I = JNIEnv.GetStaticMethodID (class_ref, "allowSleep", "(I)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_allowSleep_I, new JValue (p0));
		}

		static IntPtr id_assertFinishes;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseTestUtils']/method[@name='assertFinishes' and count(parameter)=0]"
		[Register ("assertFinishes", "()V", "")]
		public static void AssertFinishes ()
		{
			if (id_assertFinishes == IntPtr.Zero)
				id_assertFinishes = JNIEnv.GetStaticMethodID (class_ref, "assertFinishes", "()V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_assertFinishes);
		}

		static IntPtr id_assertSlept;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseTestUtils']/method[@name='assertSlept' and count(parameter)=0]"
		[Register ("assertSlept", "()V", "")]
		public static void AssertSlept ()
		{
			if (id_assertSlept == IntPtr.Zero)
				id_assertSlept = JNIEnv.GetStaticMethodID (class_ref, "assertSlept", "()V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_assertSlept);
		}

		static IntPtr id_beginFakeSleep;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseTestUtils']/method[@name='beginFakeSleep' and count(parameter)=0]"
		[Register ("beginFakeSleep", "()V", "")]
		public static void BeginFakeSleep ()
		{
			if (id_beginFakeSleep == IntPtr.Zero)
				id_beginFakeSleep = JNIEnv.GetStaticMethodID (class_ref, "beginFakeSleep", "()V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_beginFakeSleep);
		}

		static IntPtr id_clearApp;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseTestUtils']/method[@name='clearApp' and count(parameter)=0]"
		[Register ("clearApp", "()V", "")]
		public static void ClearApp ()
		{
			if (id_clearApp == IntPtr.Zero)
				id_clearApp = JNIEnv.GetStaticMethodID (class_ref, "clearApp", "()V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_clearApp);
		}

		static IntPtr id_clearCurrentInstallationFromMemory;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseTestUtils']/method[@name='clearCurrentInstallationFromMemory' and count(parameter)=0]"
		[Register ("clearCurrentInstallationFromMemory", "()V", "")]
		public static void ClearCurrentInstallationFromMemory ()
		{
			if (id_clearCurrentInstallationFromMemory == IntPtr.Zero)
				id_clearCurrentInstallationFromMemory = JNIEnv.GetStaticMethodID (class_ref, "clearCurrentInstallationFromMemory", "()V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_clearCurrentInstallationFromMemory);
		}

		static IntPtr id_clearFiles;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseTestUtils']/method[@name='clearFiles' and count(parameter)=0]"
		[Register ("clearFiles", "()V", "")]
		public static void ClearFiles ()
		{
			if (id_clearFiles == IntPtr.Zero)
				id_clearFiles = JNIEnv.GetStaticMethodID (class_ref, "clearFiles", "()V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_clearFiles);
		}

		static IntPtr id_clearPushRouterStateFromMemory;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseTestUtils']/method[@name='clearPushRouterStateFromMemory' and count(parameter)=0]"
		[Register ("clearPushRouterStateFromMemory", "()V", "")]
		public static void ClearPushRouterStateFromMemory ()
		{
			if (id_clearPushRouterStateFromMemory == IntPtr.Zero)
				id_clearPushRouterStateFromMemory = JNIEnv.GetStaticMethodID (class_ref, "clearPushRouterStateFromMemory", "()V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_clearPushRouterStateFromMemory);
		}

		static IntPtr id_commandCacheUnexpectedEvents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseTestUtils']/method[@name='commandCacheUnexpectedEvents' and count(parameter)=0]"
		[Register ("commandCacheUnexpectedEvents", "()I", "")]
		public static int CommandCacheUnexpectedEvents ()
		{
			if (id_commandCacheUnexpectedEvents == IntPtr.Zero)
				id_commandCacheUnexpectedEvents = JNIEnv.GetStaticMethodID (class_ref, "commandCacheUnexpectedEvents", "()I");
			return JNIEnv.CallStaticIntMethod  (class_ref, id_commandCacheUnexpectedEvents);
		}

		static IntPtr id_consecutiveFailures;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseTestUtils']/method[@name='consecutiveFailures' and count(parameter)=0]"
		[Register ("consecutiveFailures", "()I", "")]
		public static int ConsecutiveFailures ()
		{
			if (id_consecutiveFailures == IntPtr.Zero)
				id_consecutiveFailures = JNIEnv.GetStaticMethodID (class_ref, "consecutiveFailures", "()I");
			return JNIEnv.CallStaticIntMethod  (class_ref, id_consecutiveFailures);
		}

		static IntPtr id_disconnectCommandCache;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseTestUtils']/method[@name='disconnectCommandCache' and count(parameter)=0]"
		[Register ("disconnectCommandCache", "()V", "")]
		public static void DisconnectCommandCache ()
		{
			if (id_disconnectCommandCache == IntPtr.Zero)
				id_disconnectCommandCache = JNIEnv.GetStaticMethodID (class_ref, "disconnectCommandCache", "()V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_disconnectCommandCache);
		}

		static IntPtr id_endFakeSleep;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseTestUtils']/method[@name='endFakeSleep' and count(parameter)=0]"
		[Register ("endFakeSleep", "()V", "")]
		public static void EndFakeSleep ()
		{
			if (id_endFakeSleep == IntPtr.Zero)
				id_endFakeSleep = JNIEnv.GetStaticMethodID (class_ref, "endFakeSleep", "()V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_endFakeSleep);
		}

		static IntPtr id_finish;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseTestUtils']/method[@name='finish' and count(parameter)=0]"
		[Register ("finish", "()V", "")]
		public static void Finish ()
		{
			if (id_finish == IntPtr.Zero)
				id_finish = JNIEnv.GetStaticMethodID (class_ref, "finish", "()V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_finish);
		}

		static IntPtr id_getInstallationId_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseTestUtils']/method[@name='getInstallationId' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getInstallationId", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static string GetInstallationId (global::Android.Content.Context p0)
		{
			if (id_getInstallationId_Landroid_content_Context_ == IntPtr.Zero)
				id_getInstallationId_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getInstallationId", "(Landroid/content/Context;)Ljava/lang/String;");
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstallationId_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_getObjectFromDisk_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseTestUtils']/method[@name='getObjectFromDisk' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("getObjectFromDisk", "(Landroid/content/Context;Ljava/lang/String;)Lcom/parse/ParseObject;", "")]
		public static global::Com.Parse.ParseObject GetObjectFromDisk (global::Android.Content.Context p0, string p1)
		{
			if (id_getObjectFromDisk_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_getObjectFromDisk_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getObjectFromDisk", "(Landroid/content/Context;Ljava/lang/String;)Lcom/parse/ParseObject;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			global::Com.Parse.ParseObject __ret = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseObject> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getObjectFromDisk_Landroid_content_Context_Ljava_lang_String_, new JValue (p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static IntPtr id_getPushRequestJSON_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseTestUtils']/method[@name='getPushRequestJSON' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getPushRequestJSON", "(Landroid/content/Context;)Lorg/json/JSONObject;", "")]
		public static global::Org.Json.JSONObject GetPushRequestJSON (global::Android.Content.Context p0)
		{
			if (id_getPushRequestJSON_Landroid_content_Context_ == IntPtr.Zero)
				id_getPushRequestJSON_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getPushRequestJSON", "(Landroid/content/Context;)Lorg/json/JSONObject;");
			global::Org.Json.JSONObject __ret = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getPushRequestJSON_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_getUserObjectFromDisk_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseTestUtils']/method[@name='getUserObjectFromDisk' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("getUserObjectFromDisk", "(Landroid/content/Context;Ljava/lang/String;)Lcom/parse/ParseUser;", "")]
		public static global::Com.Parse.ParseUser GetUserObjectFromDisk (global::Android.Content.Context p0, string p1)
		{
			if (id_getUserObjectFromDisk_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_getUserObjectFromDisk_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getUserObjectFromDisk", "(Landroid/content/Context;Ljava/lang/String;)Lcom/parse/ParseUser;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			global::Com.Parse.ParseUser __ret = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseUser> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getUserObjectFromDisk_Landroid_content_Context_Ljava_lang_String_, new JValue (p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static IntPtr id_initSynchronizer;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseTestUtils']/method[@name='initSynchronizer' and count(parameter)=0]"
		[Register ("initSynchronizer", "()V", "")]
		public static void InitSynchronizer ()
		{
			if (id_initSynchronizer == IntPtr.Zero)
				id_initSynchronizer = JNIEnv.GetStaticMethodID (class_ref, "initSynchronizer", "()V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_initSynchronizer);
		}

		static IntPtr id_keySet_Lcom_parse_ParseObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseTestUtils']/method[@name='keySet' and count(parameter)=1 and parameter[1][@type='com.parse.ParseObject']]"
		[Register ("keySet", "(Lcom/parse/ParseObject;)Ljava/util/Set;", "")]
		public static global::System.Collections.Generic.ICollection<string> KeySet (global::Com.Parse.ParseObject p0)
		{
			if (id_keySet_Lcom_parse_ParseObject_ == IntPtr.Zero)
				id_keySet_Lcom_parse_ParseObject_ = JNIEnv.GetStaticMethodID (class_ref, "keySet", "(Lcom/parse/ParseObject;)Ljava/util/Set;");
			global::System.Collections.Generic.ICollection<string> __ret = global::Android.Runtime.JavaSet<string>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_keySet_Lcom_parse_ParseObject_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_mockPushServer;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseTestUtils']/method[@name='mockPushServer' and count(parameter)=0]"
		[Register ("mockPushServer", "()Ljava/net/ServerSocket;", "")]
		public static global::Java.Net.ServerSocket MockPushServer ()
		{
			if (id_mockPushServer == IntPtr.Zero)
				id_mockPushServer = JNIEnv.GetStaticMethodID (class_ref, "mockPushServer", "()Ljava/net/ServerSocket;");
			return global::Java.Lang.Object.GetObject<global::Java.Net.ServerSocket> (JNIEnv.CallStaticObjectMethod  (class_ref, id_mockPushServer), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_mockV8Client;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseTestUtils']/method[@name='mockV8Client' and count(parameter)=0]"
		[Register ("mockV8Client", "()V", "")]
		public static void MockV8Client ()
		{
			if (id_mockV8Client == IntPtr.Zero)
				id_mockV8Client = JNIEnv.GetStaticMethodID (class_ref, "mockV8Client", "()V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_mockV8Client);
		}

		static IntPtr id_numKeyValueCacheFiles;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseTestUtils']/method[@name='numKeyValueCacheFiles' and count(parameter)=0]"
		[Register ("numKeyValueCacheFiles", "()I", "")]
		public static int NumKeyValueCacheFiles ()
		{
			if (id_numKeyValueCacheFiles == IntPtr.Zero)
				id_numKeyValueCacheFiles = JNIEnv.GetStaticMethodID (class_ref, "numKeyValueCacheFiles", "()I");
			return JNIEnv.CallStaticIntMethod  (class_ref, id_numKeyValueCacheFiles);
		}

		static IntPtr id_onPush_Landroid_content_Context_Ljava_lang_String_Lcom_parse_PushCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseTestUtils']/method[@name='onPush' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.parse.PushCallback']]"
		[Register ("onPush", "(Landroid/content/Context;Ljava/lang/String;Lcom/parse/PushCallback;)V", "")]
		public static void OnPush (global::Android.Content.Context p0, string p1, global::Com.Parse.PushCallback p2)
		{
			if (id_onPush_Landroid_content_Context_Ljava_lang_String_Lcom_parse_PushCallback_ == IntPtr.Zero)
				id_onPush_Landroid_content_Context_Ljava_lang_String_Lcom_parse_PushCallback_ = JNIEnv.GetStaticMethodID (class_ref, "onPush", "(Landroid/content/Context;Ljava/lang/String;Lcom/parse/PushCallback;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_onPush_Landroid_content_Context_Ljava_lang_String_Lcom_parse_PushCallback_, new JValue (p0), new JValue (native_p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_pushRoutes_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseTestUtils']/method[@name='pushRoutes' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("pushRoutes", "(Landroid/content/Context;)Ljava/util/Set;", "")]
		public static global::System.Collections.Generic.ICollection<string> PushRoutes (global::Android.Content.Context p0)
		{
			if (id_pushRoutes_Landroid_content_Context_ == IntPtr.Zero)
				id_pushRoutes_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "pushRoutes", "(Landroid/content/Context;)Ljava/util/Set;");
			global::System.Collections.Generic.ICollection<string> __ret = global::Android.Runtime.JavaSet<string>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_pushRoutes_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_reconnectCommandCache;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseTestUtils']/method[@name='reconnectCommandCache' and count(parameter)=0]"
		[Register ("reconnectCommandCache", "()V", "")]
		public static void ReconnectCommandCache ()
		{
			if (id_reconnectCommandCache == IntPtr.Zero)
				id_reconnectCommandCache = JNIEnv.GetStaticMethodID (class_ref, "reconnectCommandCache", "()V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_reconnectCommandCache);
		}

		static IntPtr id_recursiveDelete_Ljava_io_File_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseTestUtils']/method[@name='recursiveDelete' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("recursiveDelete", "(Ljava/io/File;)V", "")]
		public static void RecursiveDelete (global::Java.IO.File p0)
		{
			if (id_recursiveDelete_Ljava_io_File_ == IntPtr.Zero)
				id_recursiveDelete_Ljava_io_File_ = JNIEnv.GetStaticMethodID (class_ref, "recursiveDelete", "(Ljava/io/File;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_recursiveDelete_Ljava_io_File_, new JValue (p0));
		}

		static IntPtr id_resetCommandCache;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseTestUtils']/method[@name='resetCommandCache' and count(parameter)=0]"
		[Register ("resetCommandCache", "()V", "")]
		public static void ResetCommandCache ()
		{
			if (id_resetCommandCache == IntPtr.Zero)
				id_resetCommandCache = JNIEnv.GetStaticMethodID (class_ref, "resetCommandCache", "()V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_resetCommandCache);
		}

		static IntPtr id_saveObjectToDisk_Lcom_parse_ParseObject_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseTestUtils']/method[@name='saveObjectToDisk' and count(parameter)=3 and parameter[1][@type='com.parse.ParseObject'] and parameter[2][@type='android.content.Context'] and parameter[3][@type='java.lang.String']]"
		[Register ("saveObjectToDisk", "(Lcom/parse/ParseObject;Landroid/content/Context;Ljava/lang/String;)V", "")]
		public static void SaveObjectToDisk (global::Com.Parse.ParseObject p0, global::Android.Content.Context p1, string p2)
		{
			if (id_saveObjectToDisk_Lcom_parse_ParseObject_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_saveObjectToDisk_Lcom_parse_ParseObject_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "saveObjectToDisk", "(Lcom/parse/ParseObject;Landroid/content/Context;Ljava/lang/String;)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_saveObjectToDisk_Lcom_parse_ParseObject_Landroid_content_Context_Ljava_lang_String_, new JValue (p0), new JValue (p1), new JValue (native_p2));
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static IntPtr id_saveStringToDisk_Ljava_lang_String_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseTestUtils']/method[@name='saveStringToDisk' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.content.Context'] and parameter[3][@type='java.lang.String']]"
		[Register ("saveStringToDisk", "(Ljava/lang/String;Landroid/content/Context;Ljava/lang/String;)V", "")]
		public static void SaveStringToDisk (string p0, global::Android.Content.Context p1, string p2)
		{
			if (id_saveStringToDisk_Ljava_lang_String_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_saveStringToDisk_Ljava_lang_String_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "saveStringToDisk", "(Ljava/lang/String;Landroid/content/Context;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_saveStringToDisk_Ljava_lang_String_Landroid_content_Context_Ljava_lang_String_, new JValue (native_p0), new JValue (p1), new JValue (native_p2));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static IntPtr id_setCommandInitialDelay_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseTestUtils']/method[@name='setCommandInitialDelay' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("setCommandInitialDelay", "(D)V", "")]
		public static void SetCommandInitialDelay (double p0)
		{
			if (id_setCommandInitialDelay_D == IntPtr.Zero)
				id_setCommandInitialDelay_D = JNIEnv.GetStaticMethodID (class_ref, "setCommandInitialDelay", "(D)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_setCommandInitialDelay_D, new JValue (p0));
		}

		static IntPtr id_setMaxKeyValueCacheBytes_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseTestUtils']/method[@name='setMaxKeyValueCacheBytes' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setMaxKeyValueCacheBytes", "(I)V", "")]
		public static void SetMaxKeyValueCacheBytes (int p0)
		{
			if (id_setMaxKeyValueCacheBytes_I == IntPtr.Zero)
				id_setMaxKeyValueCacheBytes_I = JNIEnv.GetStaticMethodID (class_ref, "setMaxKeyValueCacheBytes", "(I)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_setMaxKeyValueCacheBytes_I, new JValue (p0));
		}

		static IntPtr id_setMaxKeyValueCacheFiles_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseTestUtils']/method[@name='setMaxKeyValueCacheFiles' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setMaxKeyValueCacheFiles", "(I)V", "")]
		public static void SetMaxKeyValueCacheFiles (int p0)
		{
			if (id_setMaxKeyValueCacheFiles_I == IntPtr.Zero)
				id_setMaxKeyValueCacheFiles_I = JNIEnv.GetStaticMethodID (class_ref, "setMaxKeyValueCacheFiles", "(I)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_setMaxKeyValueCacheFiles_I, new JValue (p0));
		}

		static IntPtr id_setPushHistoryLength_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseTestUtils']/method[@name='setPushHistoryLength' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setPushHistoryLength", "(I)I", "")]
		public static int SetPushHistoryLength (int p0)
		{
			if (id_setPushHistoryLength_I == IntPtr.Zero)
				id_setPushHistoryLength_I = JNIEnv.GetStaticMethodID (class_ref, "setPushHistoryLength", "(I)I");
			return JNIEnv.CallStaticIntMethod  (class_ref, id_setPushHistoryLength_I, new JValue (p0));
		}

		static IntPtr id_setUpPushTest_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseTestUtils']/method[@name='setUpPushTest' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("setUpPushTest", "(Landroid/content/Context;)V", "")]
		public static void SetUpPushTest (global::Android.Content.Context p0)
		{
			if (id_setUpPushTest_Landroid_content_Context_ == IntPtr.Zero)
				id_setUpPushTest_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "setUpPushTest", "(Landroid/content/Context;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_setUpPushTest_Landroid_content_Context_, new JValue (p0));
		}

		static IntPtr id_start_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseTestUtils']/method[@name='start' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("start", "(I)V", "")]
		public static void Start (int p0)
		{
			if (id_start_I == IntPtr.Zero)
				id_start_I = JNIEnv.GetStaticMethodID (class_ref, "start", "(I)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_start_I, new JValue (p0));
		}

		static IntPtr id_startServiceIfRequired_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseTestUtils']/method[@name='startServiceIfRequired' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("startServiceIfRequired", "(Landroid/content/Context;)V", "")]
		public static void StartServiceIfRequired (global::Android.Content.Context p0)
		{
			if (id_startServiceIfRequired_Landroid_content_Context_ == IntPtr.Zero)
				id_startServiceIfRequired_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "startServiceIfRequired", "(Landroid/content/Context;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_startServiceIfRequired_Landroid_content_Context_, new JValue (p0));
		}

		static IntPtr id_tearDownPushTest_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseTestUtils']/method[@name='tearDownPushTest' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("tearDownPushTest", "(Landroid/content/Context;)V", "")]
		public static void TearDownPushTest (global::Android.Content.Context p0)
		{
			if (id_tearDownPushTest_Landroid_content_Context_ == IntPtr.Zero)
				id_tearDownPushTest_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "tearDownPushTest", "(Landroid/content/Context;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_tearDownPushTest_Landroid_content_Context_, new JValue (p0));
		}

		static IntPtr id_totalNotifications;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseTestUtils']/method[@name='totalNotifications' and count(parameter)=0]"
		[Register ("totalNotifications", "()I", "")]
		public static int TotalNotifications ()
		{
			if (id_totalNotifications == IntPtr.Zero)
				id_totalNotifications = JNIEnv.GetStaticMethodID (class_ref, "totalNotifications", "()I");
			return JNIEnv.CallStaticIntMethod  (class_ref, id_totalNotifications);
		}

		static IntPtr id_unmockV8Client;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseTestUtils']/method[@name='unmockV8Client' and count(parameter)=0]"
		[Register ("unmockV8Client", "()V", "")]
		public static void UnmockV8Client ()
		{
			if (id_unmockV8Client == IntPtr.Zero)
				id_unmockV8Client = JNIEnv.GetStaticMethodID (class_ref, "unmockV8Client", "()V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_unmockV8Client);
		}

		static IntPtr id_useBadServerPort_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseTestUtils']/method[@name='useBadServerPort' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("useBadServerPort", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static string UseBadServerPort (string p0)
		{
			if (id_useBadServerPort_Ljava_lang_String_ == IntPtr.Zero)
				id_useBadServerPort_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "useBadServerPort", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_useBadServerPort_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_useDevPushServer;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseTestUtils']/method[@name='useDevPushServer' and count(parameter)=0]"
		[Register ("useDevPushServer", "()V", "")]
		public static void UseDevPushServer ()
		{
			if (id_useDevPushServer == IntPtr.Zero)
				id_useDevPushServer = JNIEnv.GetStaticMethodID (class_ref, "useDevPushServer", "()V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_useDevPushServer);
		}

		static IntPtr id_useInvalidServer;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseTestUtils']/method[@name='useInvalidServer' and count(parameter)=0]"
		[Register ("useInvalidServer", "()Ljava/lang/String;", "")]
		public static string UseInvalidServer ()
		{
			if (id_useInvalidServer == IntPtr.Zero)
				id_useInvalidServer = JNIEnv.GetStaticMethodID (class_ref, "useInvalidServer", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_useInvalidServer), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_useServer_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseTestUtils']/method[@name='useServer' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("useServer", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static string UseServer (string p0)
		{
			if (id_useServer_Ljava_lang_String_ == IntPtr.Zero)
				id_useServer_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "useServer", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_useServer_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_waitForCommandCacheEnqueue;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseTestUtils']/method[@name='waitForCommandCacheEnqueue' and count(parameter)=0]"
		[Register ("waitForCommandCacheEnqueue", "()Z", "")]
		public static bool WaitForCommandCacheEnqueue ()
		{
			if (id_waitForCommandCacheEnqueue == IntPtr.Zero)
				id_waitForCommandCacheEnqueue = JNIEnv.GetStaticMethodID (class_ref, "waitForCommandCacheEnqueue", "()Z");
			return JNIEnv.CallStaticBooleanMethod  (class_ref, id_waitForCommandCacheEnqueue);
		}

		static IntPtr id_waitForCommandCacheFailure;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseTestUtils']/method[@name='waitForCommandCacheFailure' and count(parameter)=0]"
		[Register ("waitForCommandCacheFailure", "()Z", "")]
		public static bool WaitForCommandCacheFailure ()
		{
			if (id_waitForCommandCacheFailure == IntPtr.Zero)
				id_waitForCommandCacheFailure = JNIEnv.GetStaticMethodID (class_ref, "waitForCommandCacheFailure", "()Z");
			return JNIEnv.CallStaticBooleanMethod  (class_ref, id_waitForCommandCacheFailure);
		}

		static IntPtr id_waitForCommandCacheSuccess;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseTestUtils']/method[@name='waitForCommandCacheSuccess' and count(parameter)=0]"
		[Register ("waitForCommandCacheSuccess", "()Z", "")]
		public static bool WaitForCommandCacheSuccess ()
		{
			if (id_waitForCommandCacheSuccess == IntPtr.Zero)
				id_waitForCommandCacheSuccess = JNIEnv.GetStaticMethodID (class_ref, "waitForCommandCacheSuccess", "()Z");
			return JNIEnv.CallStaticBooleanMethod  (class_ref, id_waitForCommandCacheSuccess);
		}

	}
}
