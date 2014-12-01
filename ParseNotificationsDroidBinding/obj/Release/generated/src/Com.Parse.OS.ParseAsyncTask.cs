using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Parse.OS {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.parse.os']/class[@name='ParseAsyncTask']"
	[global::Android.Runtime.Register ("com/parse/os/ParseAsyncTask", DoNotGenerateAcw=true)]
	public abstract partial class ParseAsyncTask : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.parse.os']/class[@name='ParseAsyncTask.InternalHandler']"
		[global::Android.Runtime.Register ("com/parse/os/ParseAsyncTask$InternalHandler", DoNotGenerateAcw=true)]
		public partial class InternalHandler : global::Android.OS.Handler {

			protected InternalHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.parse.os']/class[@name='ParseAsyncTask.ParseAsyncTaskResult']"
		[global::Android.Runtime.Register ("com/parse/os/ParseAsyncTask$ParseAsyncTaskResult", DoNotGenerateAcw=true)]
		public partial class ParseAsyncTaskResult : global::Java.Lang.Object {

			protected ParseAsyncTaskResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.parse.os']/class[@name='ParseAsyncTask.Status']"
		[global::Android.Runtime.Register ("com/parse/os/ParseAsyncTask$Status", DoNotGenerateAcw=true)]
		public sealed partial class Status : global::Java.Lang.Enum {


			static IntPtr FINISHED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse.os']/class[@name='ParseAsyncTask.Status']/field[@name='FINISHED']"
			[Register ("FINISHED")]
			public static global::Com.Parse.OS.ParseAsyncTask.Status Finished {
				get {
					if (FINISHED_jfieldId == IntPtr.Zero)
						FINISHED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FINISHED", "Lcom/parse/os/ParseAsyncTask$Status;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FINISHED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Parse.OS.ParseAsyncTask.Status> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (FINISHED_jfieldId == IntPtr.Zero)
						FINISHED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FINISHED", "Lcom/parse/os/ParseAsyncTask$Status;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, FINISHED_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr PENDING_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse.os']/class[@name='ParseAsyncTask.Status']/field[@name='PENDING']"
			[Register ("PENDING")]
			public static global::Com.Parse.OS.ParseAsyncTask.Status Pending {
				get {
					if (PENDING_jfieldId == IntPtr.Zero)
						PENDING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PENDING", "Lcom/parse/os/ParseAsyncTask$Status;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PENDING_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Parse.OS.ParseAsyncTask.Status> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (PENDING_jfieldId == IntPtr.Zero)
						PENDING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PENDING", "Lcom/parse/os/ParseAsyncTask$Status;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, PENDING_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr RUNNING_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse.os']/class[@name='ParseAsyncTask.Status']/field[@name='RUNNING']"
			[Register ("RUNNING")]
			public static global::Com.Parse.OS.ParseAsyncTask.Status Running {
				get {
					if (RUNNING_jfieldId == IntPtr.Zero)
						RUNNING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RUNNING", "Lcom/parse/os/ParseAsyncTask$Status;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, RUNNING_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Parse.OS.ParseAsyncTask.Status> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (RUNNING_jfieldId == IntPtr.Zero)
						RUNNING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RUNNING", "Lcom/parse/os/ParseAsyncTask$Status;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, RUNNING_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/parse/os/ParseAsyncTask$Status", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Status); }
			}

			internal Status (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.os']/class[@name='ParseAsyncTask.Status']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/parse/os/ParseAsyncTask$Status;", "")]
			public static global::Com.Parse.OS.ParseAsyncTask.Status ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/parse/os/ParseAsyncTask$Status;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				global::Com.Parse.OS.ParseAsyncTask.Status __ret = global::Java.Lang.Object.GetObject<global::Com.Parse.OS.ParseAsyncTask.Status> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.os']/class[@name='ParseAsyncTask.Status']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/parse/os/ParseAsyncTask$Status;", "")]
			public static global::Com.Parse.OS.ParseAsyncTask.Status[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/parse/os/ParseAsyncTask$Status;");
				return (global::Com.Parse.OS.ParseAsyncTask.Status[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Parse.OS.ParseAsyncTask.Status));
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.parse.os']/class[@name='ParseAsyncTask.WorkerRunnable']"
		[global::Android.Runtime.Register ("com/parse/os/ParseAsyncTask$WorkerRunnable", DoNotGenerateAcw=true)]
		public abstract partial class WorkerRunnable : global::Java.Lang.Object, global::Java.Util.Concurrent.ICallable {

			protected WorkerRunnable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_call;
#pragma warning disable 0169
			static Delegate GetCallHandler ()
			{
				if (cb_call == null)
					cb_call = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Call);
				return cb_call;
			}

			static IntPtr n_Call (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Parse.OS.ParseAsyncTask.WorkerRunnable __this = global::Java.Lang.Object.GetObject<global::Com.Parse.OS.ParseAsyncTask.WorkerRunnable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Call ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.os']/class[@name='ParseAsyncTask.WorkerRunnable']/method[@name='call' and count(parameter)=0]"
			[Register ("call", "()Ljava/lang/Object;", "GetCallHandler")]
			public abstract global::Java.Lang.Object Call ();

		}

		[global::Android.Runtime.Register ("com/parse/os/ParseAsyncTask$WorkerRunnable", DoNotGenerateAcw=true)]
		internal partial class WorkerRunnableInvoker : WorkerRunnable {

			public WorkerRunnableInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

			protected override global::System.Type ThresholdType {
				get { return typeof (WorkerRunnableInvoker); }
			}

			static IntPtr id_call;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.os']/class[@name='ParseAsyncTask.WorkerRunnable']/method[@name='call' and count(parameter)=0]"
			[Register ("call", "()Ljava/lang/Object;", "GetCallHandler")]
			public override global::Java.Lang.Object Call ()
			{
				if (id_call == IntPtr.Zero)
					id_call = JNIEnv.GetMethodID (class_ref, "call", "()Ljava/lang/Object;");
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_call), JniHandleOwnership.TransferLocalRef);
			}

		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/parse/os/ParseAsyncTask", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ParseAsyncTask); }
		}

		protected ParseAsyncTask (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.parse.os']/class[@name='ParseAsyncTask']/constructor[@name='ParseAsyncTask' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public ParseAsyncTask () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ParseAsyncTask)) {
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

		static IntPtr id_isCancelled;
		public bool IsCancelled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.os']/class[@name='ParseAsyncTask']/method[@name='isCancelled' and count(parameter)=0]"
			[Register ("isCancelled", "()Z", "GetIsCancelledHandler")]
			get {
				if (id_isCancelled == IntPtr.Zero)
					id_isCancelled = JNIEnv.GetMethodID (class_ref, "isCancelled", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_isCancelled);
			}
		}

		static IntPtr id_cancel_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.os']/class[@name='ParseAsyncTask']/method[@name='cancel' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("cancel", "(Z)Z", "")]
		public bool Cancel (bool p0)
		{
			if (id_cancel_Z == IntPtr.Zero)
				id_cancel_Z = JNIEnv.GetMethodID (class_ref, "cancel", "(Z)Z");
			return JNIEnv.CallBooleanMethod  (Handle, id_cancel_Z, new JValue (p0));
		}

		static Delegate cb_doInBackground_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetDoInBackground_arrayLjava_lang_Object_Handler ()
		{
			if (cb_doInBackground_arrayLjava_lang_Object_ == null)
				cb_doInBackground_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_DoInBackground_arrayLjava_lang_Object_);
			return cb_doInBackground_arrayLjava_lang_Object_;
		}

		static IntPtr n_DoInBackground_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.OS.ParseAsyncTask __this = global::Java.Lang.Object.GetObject<global::Com.Parse.OS.ParseAsyncTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object[] p0 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DoInBackground (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.os']/class[@name='ParseAsyncTask']/method[@name='doInBackground' and count(parameter)=1 and parameter[1][@type='java.lang.Object...']]"
		[Register ("doInBackground", "([Ljava/lang/Object;)Ljava/lang/Object;", "GetDoInBackground_arrayLjava_lang_Object_Handler")]
		protected abstract global::Java.Lang.Object DoInBackground (params global:: Java.Lang.Object[] p0);

		static IntPtr id_execute_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.os']/class[@name='ParseAsyncTask']/method[@name='execute' and count(parameter)=1 and parameter[1][@type='java.lang.Object...']]"
		[Register ("execute", "([Ljava/lang/Object;)Lcom/parse/os/ParseAsyncTask;", "")]
		public global::Com.Parse.OS.ParseAsyncTask Execute (params global:: Java.Lang.Object[] p0)
		{
			if (id_execute_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_execute_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "execute", "([Ljava/lang/Object;)Lcom/parse/os/ParseAsyncTask;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			global::Com.Parse.OS.ParseAsyncTask __ret = global::Java.Lang.Object.GetObject<global::Com.Parse.OS.ParseAsyncTask> (JNIEnv.CallObjectMethod  (Handle, id_execute_arrayLjava_lang_Object_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static IntPtr id_get;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.os']/class[@name='ParseAsyncTask']/method[@name='get' and count(parameter)=0]"
		[Register ("get", "()Ljava/lang/Object;", "")]
		public global::Java.Lang.Object Get ()
		{
			if (id_get == IntPtr.Zero)
				id_get = JNIEnv.GetMethodID (class_ref, "get", "()Ljava/lang/Object;");
			return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_get), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_get_JLjava_util_concurrent_TimeUnit_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.os']/class[@name='ParseAsyncTask']/method[@name='get' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit']]"
		[Register ("get", "(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;", "")]
		public global::Java.Lang.Object Get (long p0, global::Java.Util.Concurrent.TimeUnit p1)
		{
			if (id_get_JLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
				id_get_JLjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID (class_ref, "get", "(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;");
			global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_get_JLjava_util_concurrent_TimeUnit_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_getStatus;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.os']/class[@name='ParseAsyncTask']/method[@name='getStatus' and count(parameter)=0]"
		[Register ("getStatus", "()Lcom/parse/os/ParseAsyncTask$Status;", "")]
		public global::Com.Parse.OS.ParseAsyncTask.Status GetStatus ()
		{
			if (id_getStatus == IntPtr.Zero)
				id_getStatus = JNIEnv.GetMethodID (class_ref, "getStatus", "()Lcom/parse/os/ParseAsyncTask$Status;");
			return global::Java.Lang.Object.GetObject<global::Com.Parse.OS.ParseAsyncTask.Status> (JNIEnv.CallObjectMethod  (Handle, id_getStatus), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_onCancelled;
#pragma warning disable 0169
		static Delegate GetOnCancelledHandler ()
		{
			if (cb_onCancelled == null)
				cb_onCancelled = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnCancelled);
			return cb_onCancelled;
		}

		static void n_OnCancelled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.OS.ParseAsyncTask __this = global::Java.Lang.Object.GetObject<global::Com.Parse.OS.ParseAsyncTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnCancelled ();
		}
#pragma warning restore 0169

		static IntPtr id_onCancelled;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.os']/class[@name='ParseAsyncTask']/method[@name='onCancelled' and count(parameter)=0]"
		[Register ("onCancelled", "()V", "GetOnCancelledHandler")]
		protected virtual void OnCancelled ()
		{
			if (id_onCancelled == IntPtr.Zero)
				id_onCancelled = JNIEnv.GetMethodID (class_ref, "onCancelled", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onCancelled);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onCancelled", "()V"));
		}

		static Delegate cb_onPostExecute_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetOnPostExecute_Ljava_lang_Object_Handler ()
		{
			if (cb_onPostExecute_Ljava_lang_Object_ == null)
				cb_onPostExecute_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnPostExecute_Ljava_lang_Object_);
			return cb_onPostExecute_Ljava_lang_Object_;
		}

		static void n_OnPostExecute_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.OS.ParseAsyncTask __this = global::Java.Lang.Object.GetObject<global::Com.Parse.OS.ParseAsyncTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnPostExecute (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onPostExecute_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.os']/class[@name='ParseAsyncTask']/method[@name='onPostExecute' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("onPostExecute", "(Ljava/lang/Object;)V", "GetOnPostExecute_Ljava_lang_Object_Handler")]
		protected virtual void OnPostExecute (global::Java.Lang.Object p0)
		{
			if (id_onPostExecute_Ljava_lang_Object_ == IntPtr.Zero)
				id_onPostExecute_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "onPostExecute", "(Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onPostExecute_Ljava_lang_Object_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onPostExecute", "(Ljava/lang/Object;)V"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_onPreExecute;
#pragma warning disable 0169
		static Delegate GetOnPreExecuteHandler ()
		{
			if (cb_onPreExecute == null)
				cb_onPreExecute = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnPreExecute);
			return cb_onPreExecute;
		}

		static void n_OnPreExecute (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.OS.ParseAsyncTask __this = global::Java.Lang.Object.GetObject<global::Com.Parse.OS.ParseAsyncTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnPreExecute ();
		}
#pragma warning restore 0169

		static IntPtr id_onPreExecute;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.os']/class[@name='ParseAsyncTask']/method[@name='onPreExecute' and count(parameter)=0]"
		[Register ("onPreExecute", "()V", "GetOnPreExecuteHandler")]
		protected virtual void OnPreExecute ()
		{
			if (id_onPreExecute == IntPtr.Zero)
				id_onPreExecute = JNIEnv.GetMethodID (class_ref, "onPreExecute", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onPreExecute);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onPreExecute", "()V"));
		}

		static Delegate cb_onProgressUpdate_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetOnProgressUpdate_arrayLjava_lang_Object_Handler ()
		{
			if (cb_onProgressUpdate_arrayLjava_lang_Object_ == null)
				cb_onProgressUpdate_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnProgressUpdate_arrayLjava_lang_Object_);
			return cb_onProgressUpdate_arrayLjava_lang_Object_;
		}

		static void n_OnProgressUpdate_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.OS.ParseAsyncTask __this = global::Java.Lang.Object.GetObject<global::Com.Parse.OS.ParseAsyncTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object[] p0 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			__this.OnProgressUpdate (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_onProgressUpdate_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.os']/class[@name='ParseAsyncTask']/method[@name='onProgressUpdate' and count(parameter)=1 and parameter[1][@type='java.lang.Object...']]"
		[Register ("onProgressUpdate", "([Ljava/lang/Object;)V", "GetOnProgressUpdate_arrayLjava_lang_Object_Handler")]
		protected virtual void OnProgressUpdate (params global:: Java.Lang.Object[] p0)
		{
			if (id_onProgressUpdate_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_onProgressUpdate_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "onProgressUpdate", "([Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onProgressUpdate_arrayLjava_lang_Object_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onProgressUpdate", "([Ljava/lang/Object;)V"), new JValue (native_p0));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_publishProgress_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.os']/class[@name='ParseAsyncTask']/method[@name='publishProgress' and count(parameter)=1 and parameter[1][@type='java.lang.Object...']]"
		[Register ("publishProgress", "([Ljava/lang/Object;)V", "")]
		protected void PublishProgress (params global:: Java.Lang.Object[] p0)
		{
			if (id_publishProgress_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_publishProgress_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "publishProgress", "([Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JNIEnv.CallVoidMethod  (Handle, id_publishProgress_arrayLjava_lang_Object_, new JValue (native_p0));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}

	[global::Android.Runtime.Register ("com/parse/os/ParseAsyncTask", DoNotGenerateAcw=true)]
	internal partial class ParseAsyncTaskInvoker : ParseAsyncTask {

		public ParseAsyncTaskInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (ParseAsyncTaskInvoker); }
		}

		static IntPtr id_doInBackground_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.os']/class[@name='ParseAsyncTask']/method[@name='doInBackground' and count(parameter)=1 and parameter[1][@type='java.lang.Object...']]"
		[Register ("doInBackground", "([Ljava/lang/Object;)Ljava/lang/Object;", "GetDoInBackground_arrayLjava_lang_Object_Handler")]
		protected override global::Java.Lang.Object DoInBackground (params global:: Java.Lang.Object[] p0)
		{
			if (id_doInBackground_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_doInBackground_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "doInBackground", "([Ljava/lang/Object;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_doInBackground_arrayLjava_lang_Object_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

	}

}
