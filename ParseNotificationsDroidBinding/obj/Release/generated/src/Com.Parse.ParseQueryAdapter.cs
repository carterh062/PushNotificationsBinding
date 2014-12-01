using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Parse {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.parse']/class[@name='ParseQueryAdapter']"
	[global::Android.Runtime.Register ("com/parse/ParseQueryAdapter", DoNotGenerateAcw=true)]
	public partial class ParseQueryAdapter : global::Android.Widget.BaseAdapter {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.parse']/interface[@name='ParseQueryAdapter.OnQueryLoadListener']"
		[Register ("com/parse/ParseQueryAdapter$OnQueryLoadListener", "", "Com.Parse.ParseQueryAdapter/IOnQueryLoadListenerInvoker")]
		public partial interface IOnQueryLoadListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/interface[@name='ParseQueryAdapter.OnQueryLoadListener']/method[@name='onLoaded' and count(parameter)=2 and parameter[1][@type='java.util.List'] and parameter[2][@type='java.lang.Exception']]"
			[Register ("onLoaded", "(Ljava/util/List;Ljava/lang/Exception;)V", "GetOnLoaded_Ljava_util_List_Ljava_lang_Exception_Handler:Com.Parse.ParseQueryAdapter/IOnQueryLoadListenerInvoker, ParseNotificationsDroidBinding")]
			void OnLoaded (global::System.Collections.IList p0, global::Java.Lang.Exception p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/interface[@name='ParseQueryAdapter.OnQueryLoadListener']/method[@name='onLoading' and count(parameter)=0]"
			[Register ("onLoading", "()V", "GetOnLoadingHandler:Com.Parse.ParseQueryAdapter/IOnQueryLoadListenerInvoker, ParseNotificationsDroidBinding")]
			void OnLoading ();

		}

		[global::Android.Runtime.Register ("com/parse/ParseQueryAdapter$OnQueryLoadListener", DoNotGenerateAcw=true)]
		internal class IOnQueryLoadListenerInvoker : global::Java.Lang.Object, IOnQueryLoadListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/parse/ParseQueryAdapter$OnQueryLoadListener");
			IntPtr class_ref;

			public static IOnQueryLoadListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnQueryLoadListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.parse.ParseQueryAdapter.OnQueryLoadListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnQueryLoadListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IOnQueryLoadListenerInvoker); }
			}

			static Delegate cb_onLoaded_Ljava_util_List_Ljava_lang_Exception_;
#pragma warning disable 0169
			static Delegate GetOnLoaded_Ljava_util_List_Ljava_lang_Exception_Handler ()
			{
				if (cb_onLoaded_Ljava_util_List_Ljava_lang_Exception_ == null)
					cb_onLoaded_Ljava_util_List_Ljava_lang_Exception_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnLoaded_Ljava_util_List_Ljava_lang_Exception_);
				return cb_onLoaded_Ljava_util_List_Ljava_lang_Exception_;
			}

			static void n_OnLoaded_Ljava_util_List_Ljava_lang_Exception_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Parse.ParseQueryAdapter.IOnQueryLoadListener __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQueryAdapter.IOnQueryLoadListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				System.Collections.IList p0 = global::Android.Runtime.JavaList.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Exception p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnLoaded (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onLoaded_Ljava_util_List_Ljava_lang_Exception_;
			public void OnLoaded (global::System.Collections.IList p0, global::Java.Lang.Exception p1)
			{
				if (id_onLoaded_Ljava_util_List_Ljava_lang_Exception_ == IntPtr.Zero)
					id_onLoaded_Ljava_util_List_Ljava_lang_Exception_ = JNIEnv.GetMethodID (class_ref, "onLoaded", "(Ljava/util/List;Ljava/lang/Exception;)V");
				IntPtr native_p0 = global::Android.Runtime.JavaList.ToLocalJniHandle (p0);
				JNIEnv.CallVoidMethod (Handle, id_onLoaded_Ljava_util_List_Ljava_lang_Exception_, new JValue (native_p0), new JValue (p1));
				JNIEnv.DeleteLocalRef (native_p0);
			}

			static Delegate cb_onLoading;
#pragma warning disable 0169
			static Delegate GetOnLoadingHandler ()
			{
				if (cb_onLoading == null)
					cb_onLoading = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnLoading);
				return cb_onLoading;
			}

			static void n_OnLoading (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Parse.ParseQueryAdapter.IOnQueryLoadListener __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQueryAdapter.IOnQueryLoadListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnLoading ();
			}
#pragma warning restore 0169

			IntPtr id_onLoading;
			public void OnLoading ()
			{
				if (id_onLoading == IntPtr.Zero)
					id_onLoading = JNIEnv.GetMethodID (class_ref, "onLoading", "()V");
				JNIEnv.CallVoidMethod (Handle, id_onLoading);
			}

		}

		public partial class LoadedEventArgs : global::System.EventArgs {

			public LoadedEventArgs (global::System.Collections.IList p0, global::Java.Lang.Exception p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			global::System.Collections.IList p0;
			public global::System.Collections.IList P0 {
				get { return p0; }
			}

			global::Java.Lang.Exception p1;
			public global::Java.Lang.Exception P1 {
				get { return p1; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/parse/ParseQueryAdapter_OnQueryLoadListenerImplementor")]
		internal sealed class IOnQueryLoadListenerImplementor : global::Java.Lang.Object, IOnQueryLoadListener {

			object sender;

			public IOnQueryLoadListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/parse/ParseQueryAdapter_OnQueryLoadListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<LoadedEventArgs> OnLoadedHandler;
#pragma warning restore 0649

			public void OnLoaded (global::System.Collections.IList p0, global::Java.Lang.Exception p1)
			{
				var __h = OnLoadedHandler;
				if (__h != null)
					__h (sender, new LoadedEventArgs (p0, p1));
			}
#pragma warning disable 0649
			public EventHandler OnLoadingHandler;
#pragma warning restore 0649

			public void OnLoading ()
			{
				var __h = OnLoadingHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}

			internal static bool __IsEmpty (IOnQueryLoadListenerImplementor value)
			{
				return value.OnLoadedHandler == null && value.OnLoadingHandler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.parse']/interface[@name='ParseQueryAdapter.QueryFactory']"
		[Register ("com/parse/ParseQueryAdapter$QueryFactory", "", "Com.Parse.ParseQueryAdapter/IQueryFactoryInvoker")]
		public partial interface IQueryFactory : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/interface[@name='ParseQueryAdapter.QueryFactory']/method[@name='create' and count(parameter)=0]"
			[Register ("create", "()Lcom/parse/ParseQuery;", "GetCreateHandler:Com.Parse.ParseQueryAdapter/IQueryFactoryInvoker, ParseNotificationsDroidBinding")]
			global::Com.Parse.ParseQuery Create ();

		}

		[global::Android.Runtime.Register ("com/parse/ParseQueryAdapter$QueryFactory", DoNotGenerateAcw=true)]
		internal class IQueryFactoryInvoker : global::Java.Lang.Object, IQueryFactory {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/parse/ParseQueryAdapter$QueryFactory");
			IntPtr class_ref;

			public static IQueryFactory GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IQueryFactory> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.parse.ParseQueryAdapter.QueryFactory"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IQueryFactoryInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IQueryFactoryInvoker); }
			}

			static Delegate cb_create;
#pragma warning disable 0169
			static Delegate GetCreateHandler ()
			{
				if (cb_create == null)
					cb_create = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Create);
				return cb_create;
			}

			static IntPtr n_Create (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Parse.ParseQueryAdapter.IQueryFactory __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQueryAdapter.IQueryFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Create ());
			}
#pragma warning restore 0169

			IntPtr id_create;
			public global::Com.Parse.ParseQuery Create ()
			{
				if (id_create == IntPtr.Zero)
					id_create = JNIEnv.GetMethodID (class_ref, "create", "()Lcom/parse/ParseQuery;");
				return global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (JNIEnv.CallObjectMethod (Handle, id_create), JniHandleOwnership.TransferLocalRef);
			}

		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/parse/ParseQueryAdapter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ParseQueryAdapter); }
		}

		protected ParseQueryAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.parse']/class[@name='ParseQueryAdapter']/constructor[@name='ParseQueryAdapter' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public ParseQueryAdapter (global::Android.Content.Context p0, string p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);;
			if (GetType () != typeof (ParseQueryAdapter)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Ljava/lang/String;)V", new JValue (p0), new JValue (native_p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Ljava/lang/String;)V", new JValue (p0), new JValue (native_p1));
				JNIEnv.DeleteLocalRef (native_p1);
				return;
			}

			if (id_ctor_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Ljava/lang/String;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_, new JValue (p0), new JValue (native_p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_, new JValue (p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_ctor_Landroid_content_Context_Lcom_parse_ParseQueryAdapter_QueryFactory_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.parse']/class[@name='ParseQueryAdapter']/constructor[@name='ParseQueryAdapter' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.parse.ParseQueryAdapter.QueryFactory']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/parse/ParseQueryAdapter$QueryFactory;)V", "")]
		public ParseQueryAdapter (global::Android.Content.Context p0, global::Com.Parse.ParseQueryAdapter.IQueryFactory p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ParseQueryAdapter)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Lcom/parse/ParseQueryAdapter$QueryFactory;)V", new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Lcom/parse/ParseQueryAdapter$QueryFactory;)V", new JValue (p0), new JValue (p1));
				return;
			}

			if (id_ctor_Landroid_content_Context_Lcom_parse_ParseQueryAdapter_QueryFactory_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_Lcom_parse_ParseQueryAdapter_QueryFactory_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Lcom/parse/ParseQueryAdapter$QueryFactory;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Lcom_parse_ParseQueryAdapter_QueryFactory_, new JValue (p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Lcom_parse_ParseQueryAdapter_QueryFactory_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_ctor_Landroid_content_Context_Ljava_lang_Class_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.parse']/class[@name='ParseQueryAdapter']/constructor[@name='ParseQueryAdapter' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.Class']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/lang/Class;)V", "")]
		public ParseQueryAdapter (global::Android.Content.Context p0, global::Java.Lang.Class p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ParseQueryAdapter)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Ljava/lang/Class;)V", new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Ljava/lang/Class;)V", new JValue (p0), new JValue (p1));
				return;
			}

			if (id_ctor_Landroid_content_Context_Ljava_lang_Class_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Ljava/lang/Class;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Ljava_lang_Class_, new JValue (p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Ljava_lang_Class_, new JValue (p0), new JValue (p1));
		}

		static Delegate cb_getContext;
#pragma warning disable 0169
		static Delegate GetGetContextHandler ()
		{
			if (cb_getContext == null)
				cb_getContext = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContext);
			return cb_getContext;
		}

		static IntPtr n_GetContext (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.ParseQueryAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQueryAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Context);
		}
#pragma warning restore 0169

		static IntPtr id_getContext;
		public virtual global::Android.Content.Context Context {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseQueryAdapter']/method[@name='getContext' and count(parameter)=0]"
			[Register ("getContext", "()Landroid/content/Context;", "GetGetContextHandler")]
			get {
				if (id_getContext == IntPtr.Zero)
					id_getContext = JNIEnv.GetMethodID (class_ref, "getContext", "()Landroid/content/Context;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (JNIEnv.CallObjectMethod  (Handle, id_getContext), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getContext", "()Landroid/content/Context;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getCount;
#pragma warning disable 0169
		static Delegate GetGetCountHandler ()
		{
			if (cb_getCount == null)
				cb_getCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCount);
			return cb_getCount;
		}

		static int n_GetCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.ParseQueryAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQueryAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Count;
		}
#pragma warning restore 0169

		static IntPtr id_getCount;
		public override int Count {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseQueryAdapter']/method[@name='getCount' and count(parameter)=0]"
			[Register ("getCount", "()I", "GetGetCountHandler")]
			get {
				if (id_getCount == IntPtr.Zero)
					id_getCount = JNIEnv.GetMethodID (class_ref, "getCount", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getCount);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCount", "()I"));
			}
		}

		static Delegate cb_getObjectsPerPage;
#pragma warning disable 0169
		static Delegate GetGetObjectsPerPageHandler ()
		{
			if (cb_getObjectsPerPage == null)
				cb_getObjectsPerPage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetObjectsPerPage);
			return cb_getObjectsPerPage;
		}

		static int n_GetObjectsPerPage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.ParseQueryAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQueryAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ObjectsPerPage;
		}
#pragma warning restore 0169

		static Delegate cb_setObjectsPerPage_I;
#pragma warning disable 0169
		static Delegate GetSetObjectsPerPage_IHandler ()
		{
			if (cb_setObjectsPerPage_I == null)
				cb_setObjectsPerPage_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetObjectsPerPage_I);
			return cb_setObjectsPerPage_I;
		}

		static void n_SetObjectsPerPage_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Parse.ParseQueryAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQueryAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ObjectsPerPage = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getObjectsPerPage;
		static IntPtr id_setObjectsPerPage_I;
		public virtual int ObjectsPerPage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseQueryAdapter']/method[@name='getObjectsPerPage' and count(parameter)=0]"
			[Register ("getObjectsPerPage", "()I", "GetGetObjectsPerPageHandler")]
			get {
				if (id_getObjectsPerPage == IntPtr.Zero)
					id_getObjectsPerPage = JNIEnv.GetMethodID (class_ref, "getObjectsPerPage", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getObjectsPerPage);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getObjectsPerPage", "()I"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseQueryAdapter']/method[@name='setObjectsPerPage' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setObjectsPerPage", "(I)V", "GetSetObjectsPerPage_IHandler")]
			set {
				if (id_setObjectsPerPage_I == IntPtr.Zero)
					id_setObjectsPerPage_I = JNIEnv.GetMethodID (class_ref, "setObjectsPerPage", "(I)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setObjectsPerPage_I, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setObjectsPerPage", "(I)V"), new JValue (value));
			}
		}

		static Delegate cb_addOnQueryLoadListener_Lcom_parse_ParseQueryAdapter_OnQueryLoadListener_;
#pragma warning disable 0169
		static Delegate GetAddOnQueryLoadListener_Lcom_parse_ParseQueryAdapter_OnQueryLoadListener_Handler ()
		{
			if (cb_addOnQueryLoadListener_Lcom_parse_ParseQueryAdapter_OnQueryLoadListener_ == null)
				cb_addOnQueryLoadListener_Lcom_parse_ParseQueryAdapter_OnQueryLoadListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddOnQueryLoadListener_Lcom_parse_ParseQueryAdapter_OnQueryLoadListener_);
			return cb_addOnQueryLoadListener_Lcom_parse_ParseQueryAdapter_OnQueryLoadListener_;
		}

		static void n_AddOnQueryLoadListener_Lcom_parse_ParseQueryAdapter_OnQueryLoadListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.ParseQueryAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQueryAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Parse.ParseQueryAdapter.IOnQueryLoadListener p0 = (global::Com.Parse.ParseQueryAdapter.IOnQueryLoadListener)global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQueryAdapter.IOnQueryLoadListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddOnQueryLoadListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addOnQueryLoadListener_Lcom_parse_ParseQueryAdapter_OnQueryLoadListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseQueryAdapter']/method[@name='addOnQueryLoadListener' and count(parameter)=1 and parameter[1][@type='com.parse.ParseQueryAdapter.OnQueryLoadListener']]"
		[Register ("addOnQueryLoadListener", "(Lcom/parse/ParseQueryAdapter$OnQueryLoadListener;)V", "GetAddOnQueryLoadListener_Lcom_parse_ParseQueryAdapter_OnQueryLoadListener_Handler")]
		public virtual void AddOnQueryLoadListener (global::Com.Parse.ParseQueryAdapter.IOnQueryLoadListener p0)
		{
			if (id_addOnQueryLoadListener_Lcom_parse_ParseQueryAdapter_OnQueryLoadListener_ == IntPtr.Zero)
				id_addOnQueryLoadListener_Lcom_parse_ParseQueryAdapter_OnQueryLoadListener_ = JNIEnv.GetMethodID (class_ref, "addOnQueryLoadListener", "(Lcom/parse/ParseQueryAdapter$OnQueryLoadListener;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_addOnQueryLoadListener_Lcom_parse_ParseQueryAdapter_OnQueryLoadListener_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addOnQueryLoadListener", "(Lcom/parse/ParseQueryAdapter$OnQueryLoadListener;)V"), new JValue (p0));
		}

		static Delegate cb_clear;
#pragma warning disable 0169
		static Delegate GetClearHandler ()
		{
			if (cb_clear == null)
				cb_clear = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Clear);
			return cb_clear;
		}

		static void n_Clear (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.ParseQueryAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQueryAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		static IntPtr id_clear;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseQueryAdapter']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "GetClearHandler")]
		public virtual void Clear ()
		{
			if (id_clear == IntPtr.Zero)
				id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_clear);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clear", "()V"));
		}

		static Delegate cb_getItem_I;
#pragma warning disable 0169
		static Delegate GetGetItem_IHandler ()
		{
			if (cb_getItem_I == null)
				cb_getItem_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetItem_I);
			return cb_getItem_I;
		}

		static IntPtr n_GetItem_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Parse.ParseQueryAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQueryAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetItem (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getItem_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseQueryAdapter']/method[@name='getItem' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getItem", "(I)Lcom/parse/ParseObject;", "GetGetItem_IHandler")]
		public override global::Java.Lang.Object GetItem (int p0)
		{
			if (id_getItem_I == IntPtr.Zero)
				id_getItem_I = JNIEnv.GetMethodID (class_ref, "getItem", "(I)Lcom/parse/ParseObject;");

			if (GetType () == ThresholdType)
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_getItem_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getItem", "(I)Lcom/parse/ParseObject;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_getItemId_I;
#pragma warning disable 0169
		static Delegate GetGetItemId_IHandler ()
		{
			if (cb_getItemId_I == null)
				cb_getItemId_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, long>) n_GetItemId_I);
			return cb_getItemId_I;
		}

		static long n_GetItemId_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Parse.ParseQueryAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQueryAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetItemId (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getItemId_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseQueryAdapter']/method[@name='getItemId' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getItemId", "(I)J", "GetGetItemId_IHandler")]
		public override long GetItemId (int p0)
		{
			if (id_getItemId_I == IntPtr.Zero)
				id_getItemId_I = JNIEnv.GetMethodID (class_ref, "getItemId", "(I)J");

			if (GetType () == ThresholdType)
				return JNIEnv.CallLongMethod  (Handle, id_getItemId_I, new JValue (p0));
			else
				return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getItemId", "(I)J"), new JValue (p0));
		}

		static Delegate cb_getItemView_Lcom_parse_ParseObject_Landroid_view_View_Landroid_view_ViewGroup_;
#pragma warning disable 0169
		static Delegate GetGetItemView_Lcom_parse_ParseObject_Landroid_view_View_Landroid_view_ViewGroup_Handler ()
		{
			if (cb_getItemView_Lcom_parse_ParseObject_Landroid_view_View_Landroid_view_ViewGroup_ == null)
				cb_getItemView_Lcom_parse_ParseObject_Landroid_view_View_Landroid_view_ViewGroup_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetItemView_Lcom_parse_ParseObject_Landroid_view_View_Landroid_view_ViewGroup_);
			return cb_getItemView_Lcom_parse_ParseObject_Landroid_view_View_Landroid_view_ViewGroup_;
		}

		static IntPtr n_GetItemView_Lcom_parse_ParseObject_Landroid_view_View_Landroid_view_ViewGroup_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Parse.ParseQueryAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQueryAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p1 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.ViewGroup p2 = global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetItemView (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getItemView_Lcom_parse_ParseObject_Landroid_view_View_Landroid_view_ViewGroup_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseQueryAdapter']/method[@name='getItemView' and count(parameter)=3 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='android.view.View'] and parameter[3][@type='android.view.ViewGroup']]"
		[Register ("getItemView", "(Lcom/parse/ParseObject;Landroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;", "GetGetItemView_Lcom_parse_ParseObject_Landroid_view_View_Landroid_view_ViewGroup_Handler")]
		public virtual global::Android.Views.View GetItemView (global::Java.Lang.Object p0, global::Android.Views.View p1, global::Android.Views.ViewGroup p2)
		{
			if (id_getItemView_Lcom_parse_ParseObject_Landroid_view_View_Landroid_view_ViewGroup_ == IntPtr.Zero)
				id_getItemView_Lcom_parse_ParseObject_Landroid_view_View_Landroid_view_ViewGroup_ = JNIEnv.GetMethodID (class_ref, "getItemView", "(Lcom/parse/ParseObject;Landroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);

			global::Android.Views.View __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod  (Handle, id_getItemView_Lcom_parse_ParseObject_Landroid_view_View_Landroid_view_ViewGroup_, new JValue (native_p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getItemView", "(Lcom/parse/ParseObject;Landroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;"), new JValue (native_p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getNextPageView_Landroid_view_View_Landroid_view_ViewGroup_;
#pragma warning disable 0169
		static Delegate GetGetNextPageView_Landroid_view_View_Landroid_view_ViewGroup_Handler ()
		{
			if (cb_getNextPageView_Landroid_view_View_Landroid_view_ViewGroup_ == null)
				cb_getNextPageView_Landroid_view_View_Landroid_view_ViewGroup_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetNextPageView_Landroid_view_View_Landroid_view_ViewGroup_);
			return cb_getNextPageView_Landroid_view_View_Landroid_view_ViewGroup_;
		}

		static IntPtr n_GetNextPageView_Landroid_view_View_Landroid_view_ViewGroup_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Parse.ParseQueryAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQueryAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.ViewGroup p1 = global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetNextPageView (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getNextPageView_Landroid_view_View_Landroid_view_ViewGroup_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseQueryAdapter']/method[@name='getNextPageView' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='android.view.ViewGroup']]"
		[Register ("getNextPageView", "(Landroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;", "GetGetNextPageView_Landroid_view_View_Landroid_view_ViewGroup_Handler")]
		public virtual global::Android.Views.View GetNextPageView (global::Android.Views.View p0, global::Android.Views.ViewGroup p1)
		{
			if (id_getNextPageView_Landroid_view_View_Landroid_view_ViewGroup_ == IntPtr.Zero)
				id_getNextPageView_Landroid_view_View_Landroid_view_ViewGroup_ = JNIEnv.GetMethodID (class_ref, "getNextPageView", "(Landroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;");

			global::Android.Views.View __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod  (Handle, id_getNextPageView_Landroid_view_View_Landroid_view_ViewGroup_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNextPageView", "(Landroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;"), new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_getView_ILandroid_view_View_Landroid_view_ViewGroup_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseQueryAdapter']/method[@name='getView' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='android.view.View'] and parameter[3][@type='android.view.ViewGroup']]"
		[Register ("getView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;", "")]
		public override sealed global::Android.Views.View GetView (int p0, global::Android.Views.View p1, global::Android.Views.ViewGroup p2)
		{
			if (id_getView_ILandroid_view_View_Landroid_view_ViewGroup_ == IntPtr.Zero)
				id_getView_ILandroid_view_View_Landroid_view_ViewGroup_ = JNIEnv.GetMethodID (class_ref, "getView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;");
			global::Android.Views.View __ret = global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod  (Handle, id_getView_ILandroid_view_View_Landroid_view_ViewGroup_, new JValue (p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_loadNextPage;
#pragma warning disable 0169
		static Delegate GetLoadNextPageHandler ()
		{
			if (cb_loadNextPage == null)
				cb_loadNextPage = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_LoadNextPage);
			return cb_loadNextPage;
		}

		static void n_LoadNextPage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.ParseQueryAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQueryAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.LoadNextPage ();
		}
#pragma warning restore 0169

		static IntPtr id_loadNextPage;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseQueryAdapter']/method[@name='loadNextPage' and count(parameter)=0]"
		[Register ("loadNextPage", "()V", "GetLoadNextPageHandler")]
		public virtual void LoadNextPage ()
		{
			if (id_loadNextPage == IntPtr.Zero)
				id_loadNextPage = JNIEnv.GetMethodID (class_ref, "loadNextPage", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_loadNextPage);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "loadNextPage", "()V"));
		}

		static Delegate cb_loadObjects;
#pragma warning disable 0169
		static Delegate GetLoadObjectsHandler ()
		{
			if (cb_loadObjects == null)
				cb_loadObjects = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_LoadObjects);
			return cb_loadObjects;
		}

		static void n_LoadObjects (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.ParseQueryAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQueryAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.LoadObjects ();
		}
#pragma warning restore 0169

		static IntPtr id_loadObjects;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseQueryAdapter']/method[@name='loadObjects' and count(parameter)=0]"
		[Register ("loadObjects", "()V", "GetLoadObjectsHandler")]
		public virtual void LoadObjects ()
		{
			if (id_loadObjects == IntPtr.Zero)
				id_loadObjects = JNIEnv.GetMethodID (class_ref, "loadObjects", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_loadObjects);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "loadObjects", "()V"));
		}

		static Delegate cb_removeOnQueryLoadListener_Lcom_parse_ParseQueryAdapter_OnQueryLoadListener_;
#pragma warning disable 0169
		static Delegate GetRemoveOnQueryLoadListener_Lcom_parse_ParseQueryAdapter_OnQueryLoadListener_Handler ()
		{
			if (cb_removeOnQueryLoadListener_Lcom_parse_ParseQueryAdapter_OnQueryLoadListener_ == null)
				cb_removeOnQueryLoadListener_Lcom_parse_ParseQueryAdapter_OnQueryLoadListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveOnQueryLoadListener_Lcom_parse_ParseQueryAdapter_OnQueryLoadListener_);
			return cb_removeOnQueryLoadListener_Lcom_parse_ParseQueryAdapter_OnQueryLoadListener_;
		}

		static void n_RemoveOnQueryLoadListener_Lcom_parse_ParseQueryAdapter_OnQueryLoadListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.ParseQueryAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQueryAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Parse.ParseQueryAdapter.IOnQueryLoadListener p0 = (global::Com.Parse.ParseQueryAdapter.IOnQueryLoadListener)global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQueryAdapter.IOnQueryLoadListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveOnQueryLoadListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeOnQueryLoadListener_Lcom_parse_ParseQueryAdapter_OnQueryLoadListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseQueryAdapter']/method[@name='removeOnQueryLoadListener' and count(parameter)=1 and parameter[1][@type='com.parse.ParseQueryAdapter.OnQueryLoadListener']]"
		[Register ("removeOnQueryLoadListener", "(Lcom/parse/ParseQueryAdapter$OnQueryLoadListener;)V", "GetRemoveOnQueryLoadListener_Lcom_parse_ParseQueryAdapter_OnQueryLoadListener_Handler")]
		public virtual void RemoveOnQueryLoadListener (global::Com.Parse.ParseQueryAdapter.IOnQueryLoadListener p0)
		{
			if (id_removeOnQueryLoadListener_Lcom_parse_ParseQueryAdapter_OnQueryLoadListener_ == IntPtr.Zero)
				id_removeOnQueryLoadListener_Lcom_parse_ParseQueryAdapter_OnQueryLoadListener_ = JNIEnv.GetMethodID (class_ref, "removeOnQueryLoadListener", "(Lcom/parse/ParseQueryAdapter$OnQueryLoadListener;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_removeOnQueryLoadListener_Lcom_parse_ParseQueryAdapter_OnQueryLoadListener_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeOnQueryLoadListener", "(Lcom/parse/ParseQueryAdapter$OnQueryLoadListener;)V"), new JValue (p0));
		}

		static Delegate cb_setAutoload_Z;
#pragma warning disable 0169
		static Delegate GetSetAutoload_ZHandler ()
		{
			if (cb_setAutoload_Z == null)
				cb_setAutoload_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetAutoload_Z);
			return cb_setAutoload_Z;
		}

		static void n_SetAutoload_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Parse.ParseQueryAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQueryAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetAutoload (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setAutoload_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseQueryAdapter']/method[@name='setAutoload' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setAutoload", "(Z)V", "GetSetAutoload_ZHandler")]
		public virtual void SetAutoload (bool p0)
		{
			if (id_setAutoload_Z == IntPtr.Zero)
				id_setAutoload_Z = JNIEnv.GetMethodID (class_ref, "setAutoload", "(Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setAutoload_Z, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAutoload", "(Z)V"), new JValue (p0));
		}

		static Delegate cb_setImageKey_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetImageKey_Ljava_lang_String_Handler ()
		{
			if (cb_setImageKey_Ljava_lang_String_ == null)
				cb_setImageKey_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetImageKey_Ljava_lang_String_);
			return cb_setImageKey_Ljava_lang_String_;
		}

		static void n_SetImageKey_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.ParseQueryAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQueryAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetImageKey (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setImageKey_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseQueryAdapter']/method[@name='setImageKey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setImageKey", "(Ljava/lang/String;)V", "GetSetImageKey_Ljava_lang_String_Handler")]
		public virtual void SetImageKey (string p0)
		{
			if (id_setImageKey_Ljava_lang_String_ == IntPtr.Zero)
				id_setImageKey_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setImageKey", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setImageKey_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setImageKey", "(Ljava/lang/String;)V"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_setPageOnQuery_ILcom_parse_ParseQuery_;
#pragma warning disable 0169
		static Delegate GetSetPageOnQuery_ILcom_parse_ParseQuery_Handler ()
		{
			if (cb_setPageOnQuery_ILcom_parse_ParseQuery_ == null)
				cb_setPageOnQuery_ILcom_parse_ParseQuery_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_SetPageOnQuery_ILcom_parse_ParseQuery_);
			return cb_setPageOnQuery_ILcom_parse_ParseQuery_;
		}

		static void n_SetPageOnQuery_ILcom_parse_ParseQuery_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Parse.ParseQueryAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQueryAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Parse.ParseQuery p1 = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetPageOnQuery (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setPageOnQuery_ILcom_parse_ParseQuery_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseQueryAdapter']/method[@name='setPageOnQuery' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.parse.ParseQuery']]"
		[Register ("setPageOnQuery", "(ILcom/parse/ParseQuery;)V", "GetSetPageOnQuery_ILcom_parse_ParseQuery_Handler")]
		protected virtual void SetPageOnQuery (int p0, global::Com.Parse.ParseQuery p1)
		{
			if (id_setPageOnQuery_ILcom_parse_ParseQuery_ == IntPtr.Zero)
				id_setPageOnQuery_ILcom_parse_ParseQuery_ = JNIEnv.GetMethodID (class_ref, "setPageOnQuery", "(ILcom/parse/ParseQuery;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setPageOnQuery_ILcom_parse_ParseQuery_, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPageOnQuery", "(ILcom/parse/ParseQuery;)V"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_setPaginationEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetPaginationEnabled_ZHandler ()
		{
			if (cb_setPaginationEnabled_Z == null)
				cb_setPaginationEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetPaginationEnabled_Z);
			return cb_setPaginationEnabled_Z;
		}

		static void n_SetPaginationEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Parse.ParseQueryAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQueryAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetPaginationEnabled (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setPaginationEnabled_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseQueryAdapter']/method[@name='setPaginationEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setPaginationEnabled", "(Z)V", "GetSetPaginationEnabled_ZHandler")]
		public virtual void SetPaginationEnabled (bool p0)
		{
			if (id_setPaginationEnabled_Z == IntPtr.Zero)
				id_setPaginationEnabled_Z = JNIEnv.GetMethodID (class_ref, "setPaginationEnabled", "(Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setPaginationEnabled_Z, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPaginationEnabled", "(Z)V"), new JValue (p0));
		}

		static Delegate cb_setPlaceholder_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetSetPlaceholder_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_setPlaceholder_Landroid_graphics_drawable_Drawable_ == null)
				cb_setPlaceholder_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPlaceholder_Landroid_graphics_drawable_Drawable_);
			return cb_setPlaceholder_Landroid_graphics_drawable_Drawable_;
		}

		static void n_SetPlaceholder_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.ParseQueryAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQueryAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetPlaceholder (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setPlaceholder_Landroid_graphics_drawable_Drawable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseQueryAdapter']/method[@name='setPlaceholder' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register ("setPlaceholder", "(Landroid/graphics/drawable/Drawable;)V", "GetSetPlaceholder_Landroid_graphics_drawable_Drawable_Handler")]
		public virtual void SetPlaceholder (global::Android.Graphics.Drawables.Drawable p0)
		{
			if (id_setPlaceholder_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
				id_setPlaceholder_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID (class_ref, "setPlaceholder", "(Landroid/graphics/drawable/Drawable;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setPlaceholder_Landroid_graphics_drawable_Drawable_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPlaceholder", "(Landroid/graphics/drawable/Drawable;)V"), new JValue (p0));
		}

		static Delegate cb_setTextKey_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTextKey_Ljava_lang_String_Handler ()
		{
			if (cb_setTextKey_Ljava_lang_String_ == null)
				cb_setTextKey_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTextKey_Ljava_lang_String_);
			return cb_setTextKey_Ljava_lang_String_;
		}

		static void n_SetTextKey_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.ParseQueryAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQueryAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetTextKey (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setTextKey_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseQueryAdapter']/method[@name='setTextKey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setTextKey", "(Ljava/lang/String;)V", "GetSetTextKey_Ljava_lang_String_Handler")]
		public virtual void SetTextKey (string p0)
		{
			if (id_setTextKey_Ljava_lang_String_ == IntPtr.Zero)
				id_setTextKey_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTextKey", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setTextKey_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTextKey", "(Ljava/lang/String;)V"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}
}
