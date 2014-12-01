using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Parse {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.parse']/class[@name='ParseFile']"
	[global::Android.Runtime.Register ("com/parse/ParseFile", DoNotGenerateAcw=true)]
	public partial class ParseFile : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/parse/ParseFile", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ParseFile); }
		}

		protected ParseFile (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_arrayB;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.parse']/class[@name='ParseFile']/constructor[@name='ParseFile' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]']]"
		[Register (".ctor", "(Ljava/lang/String;[B)V", "")]
		public ParseFile (string p0, byte[] p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);;
			IntPtr native_p1 = JNIEnv.NewArray (p1);;
			if (GetType () != typeof (ParseFile)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;[B)V", new JValue (native_p0), new JValue (native_p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;[B)V", new JValue (native_p0), new JValue (native_p1));
				JNIEnv.DeleteLocalRef (native_p0);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				return;
			}

			if (id_ctor_Ljava_lang_String_arrayB == IntPtr.Zero)
				id_ctor_Ljava_lang_String_arrayB = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;[B)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_arrayB, new JValue (native_p0), new JValue (native_p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_arrayB, new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_ctor_arrayB;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.parse']/class[@name='ParseFile']/constructor[@name='ParseFile' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register (".ctor", "([B)V", "")]
		public ParseFile (byte[] p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewArray (p0);;
			if (GetType () != typeof (ParseFile)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "([B)V", new JValue (native_p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "([B)V", new JValue (native_p0));
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				return;
			}

			if (id_ctor_arrayB == IntPtr.Zero)
				id_ctor_arrayB = JNIEnv.GetMethodID (class_ref, "<init>", "([B)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayB, new JValue (native_p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_arrayB, new JValue (native_p0));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_isDataAvailable;
#pragma warning disable 0169
		static Delegate GetIsDataAvailableHandler ()
		{
			if (cb_isDataAvailable == null)
				cb_isDataAvailable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDataAvailable);
			return cb_isDataAvailable;
		}

		static bool n_IsDataAvailable (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.ParseFile __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseFile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDataAvailable;
		}
#pragma warning restore 0169

		static IntPtr id_isDataAvailable;
		public virtual bool IsDataAvailable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseFile']/method[@name='isDataAvailable' and count(parameter)=0]"
			[Register ("isDataAvailable", "()Z", "GetIsDataAvailableHandler")]
			get {
				if (id_isDataAvailable == IntPtr.Zero)
					id_isDataAvailable = JNIEnv.GetMethodID (class_ref, "isDataAvailable", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isDataAvailable);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isDataAvailable", "()Z"));
			}
		}

		static Delegate cb_isDirty;
#pragma warning disable 0169
		static Delegate GetIsDirtyHandler ()
		{
			if (cb_isDirty == null)
				cb_isDirty = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDirty);
			return cb_isDirty;
		}

		static bool n_IsDirty (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.ParseFile __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseFile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDirty;
		}
#pragma warning restore 0169

		static IntPtr id_isDirty;
		public virtual bool IsDirty {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseFile']/method[@name='isDirty' and count(parameter)=0]"
			[Register ("isDirty", "()Z", "GetIsDirtyHandler")]
			get {
				if (id_isDirty == IntPtr.Zero)
					id_isDirty = JNIEnv.GetMethodID (class_ref, "isDirty", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isDirty);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isDirty", "()Z"));
			}
		}

		static Delegate cb_getName;
#pragma warning disable 0169
		static Delegate GetGetNameHandler ()
		{
			if (cb_getName == null)
				cb_getName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetName);
			return cb_getName;
		}

		static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.ParseFile __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseFile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		static IntPtr id_getName;
		public virtual string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseFile']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
			get {
				if (id_getName == IntPtr.Zero)
					id_getName = JNIEnv.GetMethodID (class_ref, "getName", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getName), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getUrl;
#pragma warning disable 0169
		static Delegate GetGetUrlHandler ()
		{
			if (cb_getUrl == null)
				cb_getUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUrl);
			return cb_getUrl;
		}

		static IntPtr n_GetUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.ParseFile __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseFile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Url);
		}
#pragma warning restore 0169

		static IntPtr id_getUrl;
		public virtual string Url {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseFile']/method[@name='getUrl' and count(parameter)=0]"
			[Register ("getUrl", "()Ljava/lang/String;", "GetGetUrlHandler")]
			get {
				if (id_getUrl == IntPtr.Zero)
					id_getUrl = JNIEnv.GetMethodID (class_ref, "getUrl", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getUrl), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_cancel;
#pragma warning disable 0169
		static Delegate GetCancelHandler ()
		{
			if (cb_cancel == null)
				cb_cancel = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Cancel);
			return cb_cancel;
		}

		static void n_Cancel (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.ParseFile __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseFile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Cancel ();
		}
#pragma warning restore 0169

		static IntPtr id_cancel;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseFile']/method[@name='cancel' and count(parameter)=0]"
		[Register ("cancel", "()V", "GetCancelHandler")]
		public virtual void Cancel ()
		{
			if (id_cancel == IntPtr.Zero)
				id_cancel = JNIEnv.GetMethodID (class_ref, "cancel", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_cancel);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "cancel", "()V"));
		}

		static Delegate cb_getData;
#pragma warning disable 0169
		static Delegate GetGetDataHandler ()
		{
			if (cb_getData == null)
				cb_getData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetData);
			return cb_getData;
		}

		static IntPtr n_GetData (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.ParseFile __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseFile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetData ());
		}
#pragma warning restore 0169

		static IntPtr id_getData;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseFile']/method[@name='getData' and count(parameter)=0]"
		[Register ("getData", "()[B", "GetGetDataHandler")]
		public virtual byte[] GetData ()
		{
			if (id_getData == IntPtr.Zero)
				id_getData = JNIEnv.GetMethodID (class_ref, "getData", "()[B");

			if (GetType () == ThresholdType)
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getData), JniHandleOwnership.TransferLocalRef, typeof (byte));
			else
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getData", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
		}

		static Delegate cb_getDataInBackground_Lcom_parse_GetDataCallback_;
#pragma warning disable 0169
		static Delegate GetGetDataInBackground_Lcom_parse_GetDataCallback_Handler ()
		{
			if (cb_getDataInBackground_Lcom_parse_GetDataCallback_ == null)
				cb_getDataInBackground_Lcom_parse_GetDataCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_GetDataInBackground_Lcom_parse_GetDataCallback_);
			return cb_getDataInBackground_Lcom_parse_GetDataCallback_;
		}

		static void n_GetDataInBackground_Lcom_parse_GetDataCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.ParseFile __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseFile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Parse.GetDataCallback p0 = global::Java.Lang.Object.GetObject<global::Com.Parse.GetDataCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.GetDataInBackground (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getDataInBackground_Lcom_parse_GetDataCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseFile']/method[@name='getDataInBackground' and count(parameter)=1 and parameter[1][@type='com.parse.GetDataCallback']]"
		[Register ("getDataInBackground", "(Lcom/parse/GetDataCallback;)V", "GetGetDataInBackground_Lcom_parse_GetDataCallback_Handler")]
		public virtual void GetDataInBackground (global::Com.Parse.GetDataCallback p0)
		{
			if (id_getDataInBackground_Lcom_parse_GetDataCallback_ == IntPtr.Zero)
				id_getDataInBackground_Lcom_parse_GetDataCallback_ = JNIEnv.GetMethodID (class_ref, "getDataInBackground", "(Lcom/parse/GetDataCallback;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_getDataInBackground_Lcom_parse_GetDataCallback_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDataInBackground", "(Lcom/parse/GetDataCallback;)V"), new JValue (p0));
		}

		static Delegate cb_getDataInBackground_Lcom_parse_GetDataCallback_Lcom_parse_ProgressCallback_;
#pragma warning disable 0169
		static Delegate GetGetDataInBackground_Lcom_parse_GetDataCallback_Lcom_parse_ProgressCallback_Handler ()
		{
			if (cb_getDataInBackground_Lcom_parse_GetDataCallback_Lcom_parse_ProgressCallback_ == null)
				cb_getDataInBackground_Lcom_parse_GetDataCallback_Lcom_parse_ProgressCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetDataInBackground_Lcom_parse_GetDataCallback_Lcom_parse_ProgressCallback_);
			return cb_getDataInBackground_Lcom_parse_GetDataCallback_Lcom_parse_ProgressCallback_;
		}

		static void n_GetDataInBackground_Lcom_parse_GetDataCallback_Lcom_parse_ProgressCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Parse.ParseFile __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseFile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Parse.GetDataCallback p0 = global::Java.Lang.Object.GetObject<global::Com.Parse.GetDataCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Parse.ProgressCallback p1 = global::Java.Lang.Object.GetObject<global::Com.Parse.ProgressCallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.GetDataInBackground (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_getDataInBackground_Lcom_parse_GetDataCallback_Lcom_parse_ProgressCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseFile']/method[@name='getDataInBackground' and count(parameter)=2 and parameter[1][@type='com.parse.GetDataCallback'] and parameter[2][@type='com.parse.ProgressCallback']]"
		[Register ("getDataInBackground", "(Lcom/parse/GetDataCallback;Lcom/parse/ProgressCallback;)V", "GetGetDataInBackground_Lcom_parse_GetDataCallback_Lcom_parse_ProgressCallback_Handler")]
		public virtual void GetDataInBackground (global::Com.Parse.GetDataCallback p0, global::Com.Parse.ProgressCallback p1)
		{
			if (id_getDataInBackground_Lcom_parse_GetDataCallback_Lcom_parse_ProgressCallback_ == IntPtr.Zero)
				id_getDataInBackground_Lcom_parse_GetDataCallback_Lcom_parse_ProgressCallback_ = JNIEnv.GetMethodID (class_ref, "getDataInBackground", "(Lcom/parse/GetDataCallback;Lcom/parse/ProgressCallback;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_getDataInBackground_Lcom_parse_GetDataCallback_Lcom_parse_ProgressCallback_, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDataInBackground", "(Lcom/parse/GetDataCallback;Lcom/parse/ProgressCallback;)V"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_save;
#pragma warning disable 0169
		static Delegate GetSaveHandler ()
		{
			if (cb_save == null)
				cb_save = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Save);
			return cb_save;
		}

		static void n_Save (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.ParseFile __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseFile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Save ();
		}
#pragma warning restore 0169

		static IntPtr id_save;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseFile']/method[@name='save' and count(parameter)=0]"
		[Register ("save", "()V", "GetSaveHandler")]
		public virtual void Save ()
		{
			if (id_save == IntPtr.Zero)
				id_save = JNIEnv.GetMethodID (class_ref, "save", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_save);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "save", "()V"));
		}

		static Delegate cb_saveInBackground;
#pragma warning disable 0169
		static Delegate GetSaveInBackgroundHandler ()
		{
			if (cb_saveInBackground == null)
				cb_saveInBackground = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SaveInBackground);
			return cb_saveInBackground;
		}

		static void n_SaveInBackground (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.ParseFile __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseFile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SaveInBackground ();
		}
#pragma warning restore 0169

		static IntPtr id_saveInBackground;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseFile']/method[@name='saveInBackground' and count(parameter)=0]"
		[Register ("saveInBackground", "()V", "GetSaveInBackgroundHandler")]
		public virtual void SaveInBackground ()
		{
			if (id_saveInBackground == IntPtr.Zero)
				id_saveInBackground = JNIEnv.GetMethodID (class_ref, "saveInBackground", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_saveInBackground);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "saveInBackground", "()V"));
		}

		static Delegate cb_saveInBackground_Lcom_parse_SaveCallback_;
#pragma warning disable 0169
		static Delegate GetSaveInBackground_Lcom_parse_SaveCallback_Handler ()
		{
			if (cb_saveInBackground_Lcom_parse_SaveCallback_ == null)
				cb_saveInBackground_Lcom_parse_SaveCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SaveInBackground_Lcom_parse_SaveCallback_);
			return cb_saveInBackground_Lcom_parse_SaveCallback_;
		}

		static void n_SaveInBackground_Lcom_parse_SaveCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.ParseFile __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseFile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Parse.SaveCallback p0 = global::Java.Lang.Object.GetObject<global::Com.Parse.SaveCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SaveInBackground (p0);
		}
#pragma warning restore 0169

		static IntPtr id_saveInBackground_Lcom_parse_SaveCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseFile']/method[@name='saveInBackground' and count(parameter)=1 and parameter[1][@type='com.parse.SaveCallback']]"
		[Register ("saveInBackground", "(Lcom/parse/SaveCallback;)V", "GetSaveInBackground_Lcom_parse_SaveCallback_Handler")]
		public virtual void SaveInBackground (global::Com.Parse.SaveCallback p0)
		{
			if (id_saveInBackground_Lcom_parse_SaveCallback_ == IntPtr.Zero)
				id_saveInBackground_Lcom_parse_SaveCallback_ = JNIEnv.GetMethodID (class_ref, "saveInBackground", "(Lcom/parse/SaveCallback;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_saveInBackground_Lcom_parse_SaveCallback_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "saveInBackground", "(Lcom/parse/SaveCallback;)V"), new JValue (p0));
		}

		static Delegate cb_saveInBackground_Lcom_parse_SaveCallback_Lcom_parse_ProgressCallback_;
#pragma warning disable 0169
		static Delegate GetSaveInBackground_Lcom_parse_SaveCallback_Lcom_parse_ProgressCallback_Handler ()
		{
			if (cb_saveInBackground_Lcom_parse_SaveCallback_Lcom_parse_ProgressCallback_ == null)
				cb_saveInBackground_Lcom_parse_SaveCallback_Lcom_parse_ProgressCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SaveInBackground_Lcom_parse_SaveCallback_Lcom_parse_ProgressCallback_);
			return cb_saveInBackground_Lcom_parse_SaveCallback_Lcom_parse_ProgressCallback_;
		}

		static void n_SaveInBackground_Lcom_parse_SaveCallback_Lcom_parse_ProgressCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Parse.ParseFile __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseFile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Parse.SaveCallback p0 = global::Java.Lang.Object.GetObject<global::Com.Parse.SaveCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Parse.ProgressCallback p1 = global::Java.Lang.Object.GetObject<global::Com.Parse.ProgressCallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SaveInBackground (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_saveInBackground_Lcom_parse_SaveCallback_Lcom_parse_ProgressCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseFile']/method[@name='saveInBackground' and count(parameter)=2 and parameter[1][@type='com.parse.SaveCallback'] and parameter[2][@type='com.parse.ProgressCallback']]"
		[Register ("saveInBackground", "(Lcom/parse/SaveCallback;Lcom/parse/ProgressCallback;)V", "GetSaveInBackground_Lcom_parse_SaveCallback_Lcom_parse_ProgressCallback_Handler")]
		public virtual void SaveInBackground (global::Com.Parse.SaveCallback p0, global::Com.Parse.ProgressCallback p1)
		{
			if (id_saveInBackground_Lcom_parse_SaveCallback_Lcom_parse_ProgressCallback_ == IntPtr.Zero)
				id_saveInBackground_Lcom_parse_SaveCallback_Lcom_parse_ProgressCallback_ = JNIEnv.GetMethodID (class_ref, "saveInBackground", "(Lcom/parse/SaveCallback;Lcom/parse/ProgressCallback;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_saveInBackground_Lcom_parse_SaveCallback_Lcom_parse_ProgressCallback_, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "saveInBackground", "(Lcom/parse/SaveCallback;Lcom/parse/ProgressCallback;)V"), new JValue (p0), new JValue (p1));
		}

	}
}
