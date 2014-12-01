using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Parse {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.parse']/class[@name='ParseObject']"
	[global::Android.Runtime.Register ("com/parse/ParseObject", DoNotGenerateAcw=true)]
	public partial class ParseObject : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/parse/ParseObject", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ParseObject); }
		}

		protected ParseObject (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.parse']/class[@name='ParseObject']/constructor[@name='ParseObject' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public ParseObject (string p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);;
			if (GetType () != typeof (ParseObject)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;)V", new JValue (native_p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;)V", new JValue (native_p0));
				JNIEnv.DeleteLocalRef (native_p0);
				return;
			}

			if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
				id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_, new JValue (native_p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.parse']/class[@name='ParseObject']/constructor[@name='ParseObject' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		protected ParseObject () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ParseObject)) {
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

		static Delegate cb_getACL;
#pragma warning disable 0169
		static Delegate GetGetACLHandler ()
		{
			if (cb_getACL == null)
				cb_getACL = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetACL);
			return cb_getACL;
		}

		static IntPtr n_GetACL (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.ParseObject __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ACL);
		}
#pragma warning restore 0169

		static Delegate cb_setACL_Lcom_parse_ParseACL_;
#pragma warning disable 0169
		static Delegate GetSetACL_Lcom_parse_ParseACL_Handler ()
		{
			if (cb_setACL_Lcom_parse_ParseACL_ == null)
				cb_setACL_Lcom_parse_ParseACL_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetACL_Lcom_parse_ParseACL_);
			return cb_setACL_Lcom_parse_ParseACL_;
		}

		static void n_SetACL_Lcom_parse_ParseACL_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.ParseObject __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Parse.ParseACL p0 = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseACL> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ACL = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getACL;
		static IntPtr id_setACL_Lcom_parse_ParseACL_;
		public virtual global::Com.Parse.ParseACL ACL {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseObject']/method[@name='getACL' and count(parameter)=0]"
			[Register ("getACL", "()Lcom/parse/ParseACL;", "GetGetACLHandler")]
			get {
				if (id_getACL == IntPtr.Zero)
					id_getACL = JNIEnv.GetMethodID (class_ref, "getACL", "()Lcom/parse/ParseACL;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Parse.ParseACL> (JNIEnv.CallObjectMethod  (Handle, id_getACL), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Parse.ParseACL> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getACL", "()Lcom/parse/ParseACL;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseObject']/method[@name='setACL' and count(parameter)=1 and parameter[1][@type='com.parse.ParseACL']]"
			[Register ("setACL", "(Lcom/parse/ParseACL;)V", "GetSetACL_Lcom_parse_ParseACL_Handler")]
			set {
				if (id_setACL_Lcom_parse_ParseACL_ == IntPtr.Zero)
					id_setACL_Lcom_parse_ParseACL_ = JNIEnv.GetMethodID (class_ref, "setACL", "(Lcom/parse/ParseACL;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setACL_Lcom_parse_ParseACL_, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setACL", "(Lcom/parse/ParseACL;)V"), new JValue (value));
			}
		}

		static Delegate cb_getClassName;
#pragma warning disable 0169
		static Delegate GetGetClassNameHandler ()
		{
			if (cb_getClassName == null)
				cb_getClassName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetClassName);
			return cb_getClassName;
		}

		static IntPtr n_GetClassName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.ParseObject __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ClassName);
		}
#pragma warning restore 0169

		static IntPtr id_getClassName;
		public virtual string ClassName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseObject']/method[@name='getClassName' and count(parameter)=0]"
			[Register ("getClassName", "()Ljava/lang/String;", "GetGetClassNameHandler")]
			get {
				if (id_getClassName == IntPtr.Zero)
					id_getClassName = JNIEnv.GetMethodID (class_ref, "getClassName", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getClassName), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getClassName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getCreatedAt;
#pragma warning disable 0169
		static Delegate GetGetCreatedAtHandler ()
		{
			if (cb_getCreatedAt == null)
				cb_getCreatedAt = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCreatedAt);
			return cb_getCreatedAt;
		}

		static IntPtr n_GetCreatedAt (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.ParseObject __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CreatedAt);
		}
#pragma warning restore 0169

		static IntPtr id_getCreatedAt;
		public virtual global::Java.Util.Date CreatedAt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseObject']/method[@name='getCreatedAt' and count(parameter)=0]"
			[Register ("getCreatedAt", "()Ljava/util/Date;", "GetGetCreatedAtHandler")]
			get {
				if (id_getCreatedAt == IntPtr.Zero)
					id_getCreatedAt = JNIEnv.GetMethodID (class_ref, "getCreatedAt", "()Ljava/util/Date;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod  (Handle, id_getCreatedAt), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCreatedAt", "()Ljava/util/Date;")), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Parse.ParseObject __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDataAvailable;
		}
#pragma warning restore 0169

		static IntPtr id_isDataAvailable;
		public virtual bool IsDataAvailable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseObject']/method[@name='isDataAvailable' and count(parameter)=0]"
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

		static Delegate cb_getObjectId;
#pragma warning disable 0169
		static Delegate GetGetObjectIdHandler ()
		{
			if (cb_getObjectId == null)
				cb_getObjectId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetObjectId);
			return cb_getObjectId;
		}

		static IntPtr n_GetObjectId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.ParseObject __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ObjectId);
		}
#pragma warning restore 0169

		static Delegate cb_setObjectId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetObjectId_Ljava_lang_String_Handler ()
		{
			if (cb_setObjectId_Ljava_lang_String_ == null)
				cb_setObjectId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetObjectId_Ljava_lang_String_);
			return cb_setObjectId_Ljava_lang_String_;
		}

		static void n_SetObjectId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.ParseObject __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ObjectId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getObjectId;
		static IntPtr id_setObjectId_Ljava_lang_String_;
		public virtual string ObjectId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseObject']/method[@name='getObjectId' and count(parameter)=0]"
			[Register ("getObjectId", "()Ljava/lang/String;", "GetGetObjectIdHandler")]
			get {
				if (id_getObjectId == IntPtr.Zero)
					id_getObjectId = JNIEnv.GetMethodID (class_ref, "getObjectId", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getObjectId), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getObjectId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseObject']/method[@name='setObjectId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setObjectId", "(Ljava/lang/String;)V", "GetSetObjectId_Ljava_lang_String_Handler")]
			set {
				if (id_setObjectId_Ljava_lang_String_ == IntPtr.Zero)
					id_setObjectId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setObjectId", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setObjectId_Ljava_lang_String_, new JValue (native_value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setObjectId", "(Ljava/lang/String;)V"), new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_getUpdatedAt;
#pragma warning disable 0169
		static Delegate GetGetUpdatedAtHandler ()
		{
			if (cb_getUpdatedAt == null)
				cb_getUpdatedAt = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUpdatedAt);
			return cb_getUpdatedAt;
		}

		static IntPtr n_GetUpdatedAt (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.ParseObject __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.UpdatedAt);
		}
#pragma warning restore 0169

		static IntPtr id_getUpdatedAt;
		public virtual global::Java.Util.Date UpdatedAt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseObject']/method[@name='getUpdatedAt' and count(parameter)=0]"
			[Register ("getUpdatedAt", "()Ljava/util/Date;", "GetGetUpdatedAtHandler")]
			get {
				if (id_getUpdatedAt == IntPtr.Zero)
					id_getUpdatedAt = JNIEnv.GetMethodID (class_ref, "getUpdatedAt", "()Ljava/util/Date;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod  (Handle, id_getUpdatedAt), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUpdatedAt", "()Ljava/util/Date;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_add_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetAdd_Ljava_lang_String_Ljava_lang_Object_Handler ()
		{
			if (cb_add_Ljava_lang_String_Ljava_lang_Object_ == null)
				cb_add_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Add_Ljava_lang_String_Ljava_lang_Object_);
			return cb_add_Ljava_lang_String_Ljava_lang_Object_;
		}

		static void n_Add_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Parse.ParseObject __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Add (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_add_Ljava_lang_String_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseObject']/method[@name='add' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
		[Register ("add", "(Ljava/lang/String;Ljava/lang/Object;)V", "GetAdd_Ljava_lang_String_Ljava_lang_Object_Handler")]
		public virtual void Add (string p0, global::Java.Lang.Object p1)
		{
			if (id_add_Ljava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
				id_add_Ljava_lang_String_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "add", "(Ljava/lang/String;Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_add_Ljava_lang_String_Ljava_lang_Object_, new JValue (native_p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "add", "(Ljava/lang/String;Ljava/lang/Object;)V"), new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_addAll_Ljava_lang_String_Ljava_util_Collection_;
#pragma warning disable 0169
		static Delegate GetAddAll_Ljava_lang_String_Ljava_util_Collection_Handler ()
		{
			if (cb_addAll_Ljava_lang_String_Ljava_util_Collection_ == null)
				cb_addAll_Ljava_lang_String_Ljava_util_Collection_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddAll_Ljava_lang_String_Ljava_util_Collection_);
			return cb_addAll_Ljava_lang_String_Ljava_util_Collection_;
		}

		static void n_AddAll_Ljava_lang_String_Ljava_util_Collection_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Parse.ParseObject __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.ICollection<object> p1 = global::Android.Runtime.JavaCollection<object>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.AddAll (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_addAll_Ljava_lang_String_Ljava_util_Collection_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseObject']/method[@name='addAll' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Collection']]"
		[Register ("addAll", "(Ljava/lang/String;Ljava/util/Collection;)V", "GetAddAll_Ljava_lang_String_Ljava_util_Collection_Handler")]
		public virtual void AddAll (string p0, global::System.Collections.Generic.ICollection<object> p1)
		{
			if (id_addAll_Ljava_lang_String_Ljava_util_Collection_ == IntPtr.Zero)
				id_addAll_Ljava_lang_String_Ljava_util_Collection_ = JNIEnv.GetMethodID (class_ref, "addAll", "(Ljava/lang/String;Ljava/util/Collection;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaCollection<object>.ToLocalJniHandle (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_addAll_Ljava_lang_String_Ljava_util_Collection_, new JValue (native_p0), new JValue (native_p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addAll", "(Ljava/lang/String;Ljava/util/Collection;)V"), new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_addAllUnique_Ljava_lang_String_Ljava_util_Collection_;
#pragma warning disable 0169
		static Delegate GetAddAllUnique_Ljava_lang_String_Ljava_util_Collection_Handler ()
		{
			if (cb_addAllUnique_Ljava_lang_String_Ljava_util_Collection_ == null)
				cb_addAllUnique_Ljava_lang_String_Ljava_util_Collection_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddAllUnique_Ljava_lang_String_Ljava_util_Collection_);
			return cb_addAllUnique_Ljava_lang_String_Ljava_util_Collection_;
		}

		static void n_AddAllUnique_Ljava_lang_String_Ljava_util_Collection_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Parse.ParseObject __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.ICollection<object> p1 = global::Android.Runtime.JavaCollection<object>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.AddAllUnique (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_addAllUnique_Ljava_lang_String_Ljava_util_Collection_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseObject']/method[@name='addAllUnique' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Collection']]"
		[Register ("addAllUnique", "(Ljava/lang/String;Ljava/util/Collection;)V", "GetAddAllUnique_Ljava_lang_String_Ljava_util_Collection_Handler")]
		public virtual void AddAllUnique (string p0, global::System.Collections.Generic.ICollection<object> p1)
		{
			if (id_addAllUnique_Ljava_lang_String_Ljava_util_Collection_ == IntPtr.Zero)
				id_addAllUnique_Ljava_lang_String_Ljava_util_Collection_ = JNIEnv.GetMethodID (class_ref, "addAllUnique", "(Ljava/lang/String;Ljava/util/Collection;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaCollection<object>.ToLocalJniHandle (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_addAllUnique_Ljava_lang_String_Ljava_util_Collection_, new JValue (native_p0), new JValue (native_p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addAllUnique", "(Ljava/lang/String;Ljava/util/Collection;)V"), new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_addUnique_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetAddUnique_Ljava_lang_String_Ljava_lang_Object_Handler ()
		{
			if (cb_addUnique_Ljava_lang_String_Ljava_lang_Object_ == null)
				cb_addUnique_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddUnique_Ljava_lang_String_Ljava_lang_Object_);
			return cb_addUnique_Ljava_lang_String_Ljava_lang_Object_;
		}

		static void n_AddUnique_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Parse.ParseObject __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.AddUnique (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_addUnique_Ljava_lang_String_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseObject']/method[@name='addUnique' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
		[Register ("addUnique", "(Ljava/lang/String;Ljava/lang/Object;)V", "GetAddUnique_Ljava_lang_String_Ljava_lang_Object_Handler")]
		public virtual void AddUnique (string p0, global::Java.Lang.Object p1)
		{
			if (id_addUnique_Ljava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
				id_addUnique_Ljava_lang_String_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "addUnique", "(Ljava/lang/String;Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_addUnique_Ljava_lang_String_Ljava_lang_Object_, new JValue (native_p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addUnique", "(Ljava/lang/String;Ljava/lang/Object;)V"), new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_containsKey_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetContainsKey_Ljava_lang_String_Handler ()
		{
			if (cb_containsKey_Ljava_lang_String_ == null)
				cb_containsKey_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_ContainsKey_Ljava_lang_String_);
			return cb_containsKey_Ljava_lang_String_;
		}

		static bool n_ContainsKey_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.ParseObject __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ContainsKey (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_containsKey_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseObject']/method[@name='containsKey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("containsKey", "(Ljava/lang/String;)Z", "GetContainsKey_Ljava_lang_String_Handler")]
		public virtual bool ContainsKey (string p0)
		{
			if (id_containsKey_Ljava_lang_String_ == IntPtr.Zero)
				id_containsKey_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "containsKey", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_containsKey_Ljava_lang_String_, new JValue (native_p0));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "containsKey", "(Ljava/lang/String;)Z"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_create_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseObject']/method[@name='create' and count(parameter)=1 and parameter[1][@type='java.lang.Class']]"
		[Register ("create", "(Ljava/lang/Class;)Lcom/parse/ParseObject;", "")]
		public static global::Java.Lang.Object Create (global::Java.Lang.Class p0)
		{
			if (id_create_Ljava_lang_Class_ == IntPtr.Zero)
				id_create_Ljava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "create", "(Ljava/lang/Class;)Lcom/parse/ParseObject;");
			global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_Ljava_lang_Class_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_create_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseObject']/method[@name='create' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("create", "(Ljava/lang/String;)Lcom/parse/ParseObject;", "")]
		public static global::Com.Parse.ParseObject Create (string p0)
		{
			if (id_create_Ljava_lang_String_ == IntPtr.Zero)
				id_create_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "create", "(Ljava/lang/String;)Lcom/parse/ParseObject;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Com.Parse.ParseObject __ret = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseObject> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_createWithoutData_Ljava_lang_Class_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseObject']/method[@name='createWithoutData' and count(parameter)=2 and parameter[1][@type='java.lang.Class'] and parameter[2][@type='java.lang.String']]"
		[Register ("createWithoutData", "(Ljava/lang/Class;Ljava/lang/String;)Lcom/parse/ParseObject;", "")]
		public static global::Java.Lang.Object CreateWithoutData (global::Java.Lang.Class p0, string p1)
		{
			if (id_createWithoutData_Ljava_lang_Class_Ljava_lang_String_ == IntPtr.Zero)
				id_createWithoutData_Ljava_lang_Class_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "createWithoutData", "(Ljava/lang/Class;Ljava/lang/String;)Lcom/parse/ParseObject;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createWithoutData_Ljava_lang_Class_Ljava_lang_String_, new JValue (p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static IntPtr id_createWithoutData_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseObject']/method[@name='createWithoutData' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("createWithoutData", "(Ljava/lang/String;Ljava/lang/String;)Lcom/parse/ParseObject;", "")]
		public static global::Com.Parse.ParseObject CreateWithoutData (string p0, string p1)
		{
			if (id_createWithoutData_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_createWithoutData_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "createWithoutData", "(Ljava/lang/String;Ljava/lang/String;)Lcom/parse/ParseObject;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			global::Com.Parse.ParseObject __ret = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseObject> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createWithoutData_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static IntPtr id_delete;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseObject']/method[@name='delete' and count(parameter)=0]"
		[Register ("delete", "()V", "")]
		public void Delete ()
		{
			if (id_delete == IntPtr.Zero)
				id_delete = JNIEnv.GetMethodID (class_ref, "delete", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_delete);
		}

		static IntPtr id_deleteAll_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseObject']/method[@name='deleteAll' and count(parameter)=1 and parameter[1][@type='java.util.List']]"
		[Register ("deleteAll", "(Ljava/util/List;)V", "")]
		public static void DeleteAll (global::System.Collections.Generic.IList<global::Com.Parse.ParseObject> p0)
		{
			if (id_deleteAll_Ljava_util_List_ == IntPtr.Zero)
				id_deleteAll_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "deleteAll", "(Ljava/util/List;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Parse.ParseObject>.ToLocalJniHandle (p0);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_deleteAll_Ljava_util_List_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_deleteAllInBackground_Ljava_util_List_Lcom_parse_DeleteCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseObject']/method[@name='deleteAllInBackground' and count(parameter)=2 and parameter[1][@type='java.util.List'] and parameter[2][@type='com.parse.DeleteCallback']]"
		[Register ("deleteAllInBackground", "(Ljava/util/List;Lcom/parse/DeleteCallback;)V", "")]
		public static void DeleteAllInBackground (global::System.Collections.Generic.IList<global::Com.Parse.ParseObject> p0, global::Com.Parse.DeleteCallback p1)
		{
			if (id_deleteAllInBackground_Ljava_util_List_Lcom_parse_DeleteCallback_ == IntPtr.Zero)
				id_deleteAllInBackground_Ljava_util_List_Lcom_parse_DeleteCallback_ = JNIEnv.GetStaticMethodID (class_ref, "deleteAllInBackground", "(Ljava/util/List;Lcom/parse/DeleteCallback;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Parse.ParseObject>.ToLocalJniHandle (p0);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_deleteAllInBackground_Ljava_util_List_Lcom_parse_DeleteCallback_, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_deleteEventually;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseObject']/method[@name='deleteEventually' and count(parameter)=0]"
		[Register ("deleteEventually", "()V", "")]
		public void DeleteEventually ()
		{
			if (id_deleteEventually == IntPtr.Zero)
				id_deleteEventually = JNIEnv.GetMethodID (class_ref, "deleteEventually", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_deleteEventually);
		}

		static IntPtr id_deleteEventually_Lcom_parse_DeleteCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseObject']/method[@name='deleteEventually' and count(parameter)=1 and parameter[1][@type='com.parse.DeleteCallback']]"
		[Register ("deleteEventually", "(Lcom/parse/DeleteCallback;)V", "")]
		public void DeleteEventually (global::Com.Parse.DeleteCallback p0)
		{
			if (id_deleteEventually_Lcom_parse_DeleteCallback_ == IntPtr.Zero)
				id_deleteEventually_Lcom_parse_DeleteCallback_ = JNIEnv.GetMethodID (class_ref, "deleteEventually", "(Lcom/parse/DeleteCallback;)V");
			JNIEnv.CallVoidMethod  (Handle, id_deleteEventually_Lcom_parse_DeleteCallback_, new JValue (p0));
		}

		static IntPtr id_deleteInBackground;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseObject']/method[@name='deleteInBackground' and count(parameter)=0]"
		[Register ("deleteInBackground", "()V", "")]
		public void DeleteInBackground ()
		{
			if (id_deleteInBackground == IntPtr.Zero)
				id_deleteInBackground = JNIEnv.GetMethodID (class_ref, "deleteInBackground", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_deleteInBackground);
		}

		static IntPtr id_deleteInBackground_Lcom_parse_DeleteCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseObject']/method[@name='deleteInBackground' and count(parameter)=1 and parameter[1][@type='com.parse.DeleteCallback']]"
		[Register ("deleteInBackground", "(Lcom/parse/DeleteCallback;)V", "")]
		public void DeleteInBackground (global::Com.Parse.DeleteCallback p0)
		{
			if (id_deleteInBackground_Lcom_parse_DeleteCallback_ == IntPtr.Zero)
				id_deleteInBackground_Lcom_parse_DeleteCallback_ = JNIEnv.GetMethodID (class_ref, "deleteInBackground", "(Lcom/parse/DeleteCallback;)V");
			JNIEnv.CallVoidMethod  (Handle, id_deleteInBackground_Lcom_parse_DeleteCallback_, new JValue (p0));
		}

		static Delegate cb_fetch;
#pragma warning disable 0169
		static Delegate GetFetchHandler ()
		{
			if (cb_fetch == null)
				cb_fetch = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Fetch);
			return cb_fetch;
		}

		static IntPtr n_Fetch (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.ParseObject __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Fetch ());
		}
#pragma warning restore 0169

		static IntPtr id_fetch;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseObject']/method[@name='fetch' and count(parameter)=0]"
		[Register ("fetch", "()Lcom/parse/ParseObject;", "GetFetchHandler")]
		public virtual global::Java.Lang.Object Fetch ()
		{
			if (id_fetch == IntPtr.Zero)
				id_fetch = JNIEnv.GetMethodID (class_ref, "fetch", "()Lcom/parse/ParseObject;");

			if (GetType () == ThresholdType)
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_fetch), JniHandleOwnership.TransferLocalRef);
			else
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "fetch", "()Lcom/parse/ParseObject;")), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_fetchAll_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseObject']/method[@name='fetchAll' and count(parameter)=1 and parameter[1][@type='java.util.List']]"
		[Register ("fetchAll", "(Ljava/util/List;)Ljava/util/List;", "")]
		public static global::System.Collections.Generic.IList<global::Com.Parse.ParseObject> FetchAll (global::System.Collections.Generic.IList<global::Com.Parse.ParseObject> p0)
		{
			if (id_fetchAll_Ljava_util_List_ == IntPtr.Zero)
				id_fetchAll_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "fetchAll", "(Ljava/util/List;)Ljava/util/List;");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Parse.ParseObject>.ToLocalJniHandle (p0);
			global::System.Collections.Generic.IList<global::Com.Parse.ParseObject> __ret = global::Android.Runtime.JavaList<global::Com.Parse.ParseObject>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_fetchAll_Ljava_util_List_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_fetchAllIfNeeded_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseObject']/method[@name='fetchAllIfNeeded' and count(parameter)=1 and parameter[1][@type='java.util.List']]"
		[Register ("fetchAllIfNeeded", "(Ljava/util/List;)Ljava/util/List;", "")]
		public static global::System.Collections.IList FetchAllIfNeeded (global::System.Collections.IList p0)
		{
			if (id_fetchAllIfNeeded_Ljava_util_List_ == IntPtr.Zero)
				id_fetchAllIfNeeded_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "fetchAllIfNeeded", "(Ljava/util/List;)Ljava/util/List;");
			IntPtr native_p0 = global::Android.Runtime.JavaList.ToLocalJniHandle (p0);
			global::System.Collections.IList __ret = global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_fetchAllIfNeeded_Ljava_util_List_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_fetchAllIfNeededInBackground_Ljava_util_List_Lcom_parse_FindCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseObject']/method[@name='fetchAllIfNeededInBackground' and count(parameter)=2 and parameter[1][@type='java.util.List'] and parameter[2][@type='com.parse.FindCallback']]"
		[Register ("fetchAllIfNeededInBackground", "(Ljava/util/List;Lcom/parse/FindCallback;)V", "")]
		public static void FetchAllIfNeededInBackground (global::System.Collections.IList p0, global::Com.Parse.FindCallback p1)
		{
			if (id_fetchAllIfNeededInBackground_Ljava_util_List_Lcom_parse_FindCallback_ == IntPtr.Zero)
				id_fetchAllIfNeededInBackground_Ljava_util_List_Lcom_parse_FindCallback_ = JNIEnv.GetStaticMethodID (class_ref, "fetchAllIfNeededInBackground", "(Ljava/util/List;Lcom/parse/FindCallback;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList.ToLocalJniHandle (p0);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_fetchAllIfNeededInBackground_Ljava_util_List_Lcom_parse_FindCallback_, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_fetchAllInBackground_Ljava_util_List_Lcom_parse_FindCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseObject']/method[@name='fetchAllInBackground' and count(parameter)=2 and parameter[1][@type='java.util.List'] and parameter[2][@type='com.parse.FindCallback']]"
		[Register ("fetchAllInBackground", "(Ljava/util/List;Lcom/parse/FindCallback;)V", "")]
		public static void FetchAllInBackground (global::System.Collections.IList p0, global::Com.Parse.FindCallback p1)
		{
			if (id_fetchAllInBackground_Ljava_util_List_Lcom_parse_FindCallback_ == IntPtr.Zero)
				id_fetchAllInBackground_Ljava_util_List_Lcom_parse_FindCallback_ = JNIEnv.GetStaticMethodID (class_ref, "fetchAllInBackground", "(Ljava/util/List;Lcom/parse/FindCallback;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList.ToLocalJniHandle (p0);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_fetchAllInBackground_Ljava_util_List_Lcom_parse_FindCallback_, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_fetchIfNeeded;
#pragma warning disable 0169
		static Delegate GetFetchIfNeededHandler ()
		{
			if (cb_fetchIfNeeded == null)
				cb_fetchIfNeeded = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_FetchIfNeeded);
			return cb_fetchIfNeeded;
		}

		static IntPtr n_FetchIfNeeded (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.ParseObject __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FetchIfNeeded ());
		}
#pragma warning restore 0169

		static IntPtr id_fetchIfNeeded;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseObject']/method[@name='fetchIfNeeded' and count(parameter)=0]"
		[Register ("fetchIfNeeded", "()Lcom/parse/ParseObject;", "GetFetchIfNeededHandler")]
		public virtual global::Java.Lang.Object FetchIfNeeded ()
		{
			if (id_fetchIfNeeded == IntPtr.Zero)
				id_fetchIfNeeded = JNIEnv.GetMethodID (class_ref, "fetchIfNeeded", "()Lcom/parse/ParseObject;");

			if (GetType () == ThresholdType)
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_fetchIfNeeded), JniHandleOwnership.TransferLocalRef);
			else
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "fetchIfNeeded", "()Lcom/parse/ParseObject;")), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_fetchIfNeededInBackground_Lcom_parse_GetCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseObject']/method[@name='fetchIfNeededInBackground' and count(parameter)=1 and parameter[1][@type='com.parse.GetCallback']]"
		[Register ("fetchIfNeededInBackground", "(Lcom/parse/GetCallback;)V", "")]
		public void FetchIfNeededInBackground (global::Com.Parse.GetCallback p0)
		{
			if (id_fetchIfNeededInBackground_Lcom_parse_GetCallback_ == IntPtr.Zero)
				id_fetchIfNeededInBackground_Lcom_parse_GetCallback_ = JNIEnv.GetMethodID (class_ref, "fetchIfNeededInBackground", "(Lcom/parse/GetCallback;)V");
			JNIEnv.CallVoidMethod  (Handle, id_fetchIfNeededInBackground_Lcom_parse_GetCallback_, new JValue (p0));
		}

		static IntPtr id_fetchInBackground_Lcom_parse_GetCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseObject']/method[@name='fetchInBackground' and count(parameter)=1 and parameter[1][@type='com.parse.GetCallback']]"
		[Register ("fetchInBackground", "(Lcom/parse/GetCallback;)V", "")]
		public void FetchInBackground (global::Com.Parse.GetCallback p0)
		{
			if (id_fetchInBackground_Lcom_parse_GetCallback_ == IntPtr.Zero)
				id_fetchInBackground_Lcom_parse_GetCallback_ = JNIEnv.GetMethodID (class_ref, "fetchInBackground", "(Lcom/parse/GetCallback;)V");
			JNIEnv.CallVoidMethod  (Handle, id_fetchInBackground_Lcom_parse_GetCallback_, new JValue (p0));
		}

		static Delegate cb_get_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGet_Ljava_lang_String_Handler ()
		{
			if (cb_get_Ljava_lang_String_ == null)
				cb_get_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Get_Ljava_lang_String_);
			return cb_get_Ljava_lang_String_;
		}

		static IntPtr n_Get_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.ParseObject __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Get (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_get_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseObject']/method[@name='get' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("get", "(Ljava/lang/String;)Ljava/lang/Object;", "GetGet_Ljava_lang_String_Handler")]
		public virtual global::Java.Lang.Object Get (string p0)
		{
			if (id_get_Ljava_lang_String_ == IntPtr.Zero)
				id_get_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "get", "(Ljava/lang/String;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Java.Lang.Object __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_get_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get", "(Ljava/lang/String;)Ljava/lang/Object;"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getBoolean_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetBoolean_Ljava_lang_String_Handler ()
		{
			if (cb_getBoolean_Ljava_lang_String_ == null)
				cb_getBoolean_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_GetBoolean_Ljava_lang_String_);
			return cb_getBoolean_Ljava_lang_String_;
		}

		static bool n_GetBoolean_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.ParseObject __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.GetBoolean (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getBoolean_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseObject']/method[@name='getBoolean' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getBoolean", "(Ljava/lang/String;)Z", "GetGetBoolean_Ljava_lang_String_Handler")]
		public virtual bool GetBoolean (string p0)
		{
			if (id_getBoolean_Ljava_lang_String_ == IntPtr.Zero)
				id_getBoolean_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getBoolean", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_getBoolean_Ljava_lang_String_, new JValue (native_p0));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBoolean", "(Ljava/lang/String;)Z"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getBytes_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetBytes_Ljava_lang_String_Handler ()
		{
			if (cb_getBytes_Ljava_lang_String_ == null)
				cb_getBytes_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetBytes_Ljava_lang_String_);
			return cb_getBytes_Ljava_lang_String_;
		}

		static IntPtr n_GetBytes_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.ParseObject __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.GetBytes (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getBytes_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseObject']/method[@name='getBytes' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getBytes", "(Ljava/lang/String;)[B", "GetGetBytes_Ljava_lang_String_Handler")]
		public virtual byte[] GetBytes (string p0)
		{
			if (id_getBytes_Ljava_lang_String_ == IntPtr.Zero)
				id_getBytes_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getBytes", "(Ljava/lang/String;)[B");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			byte[] __ret;
			if (GetType () == ThresholdType)
				__ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getBytes_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef, typeof (byte));
			else
				__ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBytes", "(Ljava/lang/String;)[B"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef, typeof (byte));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getDate_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetDate_Ljava_lang_String_Handler ()
		{
			if (cb_getDate_Ljava_lang_String_ == null)
				cb_getDate_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetDate_Ljava_lang_String_);
			return cb_getDate_Ljava_lang_String_;
		}

		static IntPtr n_GetDate_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.ParseObject __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetDate (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getDate_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseObject']/method[@name='getDate' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getDate", "(Ljava/lang/String;)Ljava/util/Date;", "GetGetDate_Ljava_lang_String_Handler")]
		public virtual global::Java.Util.Date GetDate (string p0)
		{
			if (id_getDate_Ljava_lang_String_ == IntPtr.Zero)
				id_getDate_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getDate", "(Ljava/lang/String;)Ljava/util/Date;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Java.Util.Date __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod  (Handle, id_getDate_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDate", "(Ljava/lang/String;)Ljava/util/Date;"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getDouble_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetDouble_Ljava_lang_String_Handler ()
		{
			if (cb_getDouble_Ljava_lang_String_ == null)
				cb_getDouble_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, double>) n_GetDouble_Ljava_lang_String_);
			return cb_getDouble_Ljava_lang_String_;
		}

		static double n_GetDouble_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.ParseObject __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			double __ret = __this.GetDouble (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getDouble_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseObject']/method[@name='getDouble' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getDouble", "(Ljava/lang/String;)D", "GetGetDouble_Ljava_lang_String_Handler")]
		public virtual double GetDouble (string p0)
		{
			if (id_getDouble_Ljava_lang_String_ == IntPtr.Zero)
				id_getDouble_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getDouble", "(Ljava/lang/String;)D");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			double __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallDoubleMethod  (Handle, id_getDouble_Ljava_lang_String_, new JValue (native_p0));
			else
				__ret = JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDouble", "(Ljava/lang/String;)D"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getInt_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetInt_Ljava_lang_String_Handler ()
		{
			if (cb_getInt_Ljava_lang_String_ == null)
				cb_getInt_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_GetInt_Ljava_lang_String_);
			return cb_getInt_Ljava_lang_String_;
		}

		static int n_GetInt_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.ParseObject __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetInt (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getInt_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseObject']/method[@name='getInt' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getInt", "(Ljava/lang/String;)I", "GetGetInt_Ljava_lang_String_Handler")]
		public virtual int GetInt (string p0)
		{
			if (id_getInt_Ljava_lang_String_ == IntPtr.Zero)
				id_getInt_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getInt", "(Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			int __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallIntMethod  (Handle, id_getInt_Ljava_lang_String_, new JValue (native_p0));
			else
				__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getInt", "(Ljava/lang/String;)I"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getJSONArray_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetJSONArray_Ljava_lang_String_Handler ()
		{
			if (cb_getJSONArray_Ljava_lang_String_ == null)
				cb_getJSONArray_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetJSONArray_Ljava_lang_String_);
			return cb_getJSONArray_Ljava_lang_String_;
		}

		static IntPtr n_GetJSONArray_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.ParseObject __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetJSONArray (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getJSONArray_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseObject']/method[@name='getJSONArray' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getJSONArray", "(Ljava/lang/String;)Lorg/json/JSONArray;", "GetGetJSONArray_Ljava_lang_String_Handler")]
		public virtual global::Org.Json.JSONArray GetJSONArray (string p0)
		{
			if (id_getJSONArray_Ljava_lang_String_ == IntPtr.Zero)
				id_getJSONArray_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getJSONArray", "(Ljava/lang/String;)Lorg/json/JSONArray;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Org.Json.JSONArray __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Org.Json.JSONArray> (JNIEnv.CallObjectMethod  (Handle, id_getJSONArray_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Org.Json.JSONArray> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getJSONArray", "(Ljava/lang/String;)Lorg/json/JSONArray;"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getJSONObject_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetJSONObject_Ljava_lang_String_Handler ()
		{
			if (cb_getJSONObject_Ljava_lang_String_ == null)
				cb_getJSONObject_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetJSONObject_Ljava_lang_String_);
			return cb_getJSONObject_Ljava_lang_String_;
		}

		static IntPtr n_GetJSONObject_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.ParseObject __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetJSONObject (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getJSONObject_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseObject']/method[@name='getJSONObject' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getJSONObject", "(Ljava/lang/String;)Lorg/json/JSONObject;", "GetGetJSONObject_Ljava_lang_String_Handler")]
		public virtual global::Org.Json.JSONObject GetJSONObject (string p0)
		{
			if (id_getJSONObject_Ljava_lang_String_ == IntPtr.Zero)
				id_getJSONObject_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getJSONObject", "(Ljava/lang/String;)Lorg/json/JSONObject;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Org.Json.JSONObject __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallObjectMethod  (Handle, id_getJSONObject_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getJSONObject", "(Ljava/lang/String;)Lorg/json/JSONObject;"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getList_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetList_Ljava_lang_String_Handler ()
		{
			if (cb_getList_Ljava_lang_String_ == null)
				cb_getList_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetList_Ljava_lang_String_);
			return cb_getList_Ljava_lang_String_;
		}

		static IntPtr n_GetList_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.ParseObject __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList.ToLocalJniHandle (__this.GetList (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getList_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseObject']/method[@name='getList' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getList", "(Ljava/lang/String;)Ljava/util/List;", "GetGetList_Ljava_lang_String_Handler")]
		public virtual global::System.Collections.IList GetList (string p0)
		{
			if (id_getList_Ljava_lang_String_ == IntPtr.Zero)
				id_getList_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getList", "(Ljava/lang/String;)Ljava/util/List;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::System.Collections.IList __ret;
			if (GetType () == ThresholdType)
				__ret = global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getList_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getList", "(Ljava/lang/String;)Ljava/util/List;"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getLong_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetLong_Ljava_lang_String_Handler ()
		{
			if (cb_getLong_Ljava_lang_String_ == null)
				cb_getLong_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, long>) n_GetLong_Ljava_lang_String_);
			return cb_getLong_Ljava_lang_String_;
		}

		static long n_GetLong_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.ParseObject __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.GetLong (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getLong_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseObject']/method[@name='getLong' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getLong", "(Ljava/lang/String;)J", "GetGetLong_Ljava_lang_String_Handler")]
		public virtual long GetLong (string p0)
		{
			if (id_getLong_Ljava_lang_String_ == IntPtr.Zero)
				id_getLong_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getLong", "(Ljava/lang/String;)J");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			long __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallLongMethod  (Handle, id_getLong_Ljava_lang_String_, new JValue (native_p0));
			else
				__ret = JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLong", "(Ljava/lang/String;)J"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getMap_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetMap_Ljava_lang_String_Handler ()
		{
			if (cb_getMap_Ljava_lang_String_ == null)
				cb_getMap_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetMap_Ljava_lang_String_);
			return cb_getMap_Ljava_lang_String_;
		}

		static IntPtr n_GetMap_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.ParseObject __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (__this.GetMap (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getMap_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseObject']/method[@name='getMap' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getMap", "(Ljava/lang/String;)Ljava/util/Map;", "GetGetMap_Ljava_lang_String_Handler")]
		public virtual global::System.Collections.IDictionary GetMap (string p0)
		{
			if (id_getMap_Ljava_lang_String_ == IntPtr.Zero)
				id_getMap_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getMap", "(Ljava/lang/String;)Ljava/util/Map;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::System.Collections.IDictionary __ret;
			if (GetType () == ThresholdType)
				__ret = global::Android.Runtime.JavaDictionary.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getMap_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Android.Runtime.JavaDictionary.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMap", "(Ljava/lang/String;)Ljava/util/Map;"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getNumber_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetNumber_Ljava_lang_String_Handler ()
		{
			if (cb_getNumber_Ljava_lang_String_ == null)
				cb_getNumber_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetNumber_Ljava_lang_String_);
			return cb_getNumber_Ljava_lang_String_;
		}

		static IntPtr n_GetNumber_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.ParseObject __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetNumber (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getNumber_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseObject']/method[@name='getNumber' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getNumber", "(Ljava/lang/String;)Ljava/lang/Number;", "GetGetNumber_Ljava_lang_String_Handler")]
		public virtual global::Java.Lang.Number GetNumber (string p0)
		{
			if (id_getNumber_Ljava_lang_String_ == IntPtr.Zero)
				id_getNumber_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getNumber", "(Ljava/lang/String;)Ljava/lang/Number;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Java.Lang.Number __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Number> (JNIEnv.CallObjectMethod  (Handle, id_getNumber_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Number> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNumber", "(Ljava/lang/String;)Ljava/lang/Number;"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getParseFile_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetParseFile_Ljava_lang_String_Handler ()
		{
			if (cb_getParseFile_Ljava_lang_String_ == null)
				cb_getParseFile_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetParseFile_Ljava_lang_String_);
			return cb_getParseFile_Ljava_lang_String_;
		}

		static IntPtr n_GetParseFile_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.ParseObject __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetParseFile (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getParseFile_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseObject']/method[@name='getParseFile' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getParseFile", "(Ljava/lang/String;)Lcom/parse/ParseFile;", "GetGetParseFile_Ljava_lang_String_Handler")]
		public virtual global::Com.Parse.ParseFile GetParseFile (string p0)
		{
			if (id_getParseFile_Ljava_lang_String_ == IntPtr.Zero)
				id_getParseFile_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getParseFile", "(Ljava/lang/String;)Lcom/parse/ParseFile;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Com.Parse.ParseFile __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseFile> (JNIEnv.CallObjectMethod  (Handle, id_getParseFile_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseFile> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getParseFile", "(Ljava/lang/String;)Lcom/parse/ParseFile;"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getParseGeoPoint_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetParseGeoPoint_Ljava_lang_String_Handler ()
		{
			if (cb_getParseGeoPoint_Ljava_lang_String_ == null)
				cb_getParseGeoPoint_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetParseGeoPoint_Ljava_lang_String_);
			return cb_getParseGeoPoint_Ljava_lang_String_;
		}

		static IntPtr n_GetParseGeoPoint_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.ParseObject __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetParseGeoPoint (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getParseGeoPoint_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseObject']/method[@name='getParseGeoPoint' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getParseGeoPoint", "(Ljava/lang/String;)Lcom/parse/ParseGeoPoint;", "GetGetParseGeoPoint_Ljava_lang_String_Handler")]
		public virtual global::Com.Parse.ParseGeoPoint GetParseGeoPoint (string p0)
		{
			if (id_getParseGeoPoint_Ljava_lang_String_ == IntPtr.Zero)
				id_getParseGeoPoint_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getParseGeoPoint", "(Ljava/lang/String;)Lcom/parse/ParseGeoPoint;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Com.Parse.ParseGeoPoint __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseGeoPoint> (JNIEnv.CallObjectMethod  (Handle, id_getParseGeoPoint_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseGeoPoint> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getParseGeoPoint", "(Ljava/lang/String;)Lcom/parse/ParseGeoPoint;"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getParseObject_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetParseObject_Ljava_lang_String_Handler ()
		{
			if (cb_getParseObject_Ljava_lang_String_ == null)
				cb_getParseObject_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetParseObject_Ljava_lang_String_);
			return cb_getParseObject_Ljava_lang_String_;
		}

		static IntPtr n_GetParseObject_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.ParseObject __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetParseObject (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getParseObject_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseObject']/method[@name='getParseObject' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getParseObject", "(Ljava/lang/String;)Lcom/parse/ParseObject;", "GetGetParseObject_Ljava_lang_String_Handler")]
		public virtual global::Com.Parse.ParseObject GetParseObject (string p0)
		{
			if (id_getParseObject_Ljava_lang_String_ == IntPtr.Zero)
				id_getParseObject_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getParseObject", "(Ljava/lang/String;)Lcom/parse/ParseObject;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Com.Parse.ParseObject __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseObject> (JNIEnv.CallObjectMethod  (Handle, id_getParseObject_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseObject> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getParseObject", "(Ljava/lang/String;)Lcom/parse/ParseObject;"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getParseUser_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetParseUser_Ljava_lang_String_Handler ()
		{
			if (cb_getParseUser_Ljava_lang_String_ == null)
				cb_getParseUser_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetParseUser_Ljava_lang_String_);
			return cb_getParseUser_Ljava_lang_String_;
		}

		static IntPtr n_GetParseUser_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.ParseObject __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetParseUser (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getParseUser_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseObject']/method[@name='getParseUser' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getParseUser", "(Ljava/lang/String;)Lcom/parse/ParseUser;", "GetGetParseUser_Ljava_lang_String_Handler")]
		public virtual global::Com.Parse.ParseUser GetParseUser (string p0)
		{
			if (id_getParseUser_Ljava_lang_String_ == IntPtr.Zero)
				id_getParseUser_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getParseUser", "(Ljava/lang/String;)Lcom/parse/ParseUser;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Com.Parse.ParseUser __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseUser> (JNIEnv.CallObjectMethod  (Handle, id_getParseUser_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseUser> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getParseUser", "(Ljava/lang/String;)Lcom/parse/ParseUser;"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getRelation_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetRelation_Ljava_lang_String_Handler ()
		{
			if (cb_getRelation_Ljava_lang_String_ == null)
				cb_getRelation_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetRelation_Ljava_lang_String_);
			return cb_getRelation_Ljava_lang_String_;
		}

		static IntPtr n_GetRelation_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.ParseObject __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetRelation (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getRelation_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseObject']/method[@name='getRelation' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getRelation", "(Ljava/lang/String;)Lcom/parse/ParseRelation;", "GetGetRelation_Ljava_lang_String_Handler")]
		public virtual global::Com.Parse.ParseRelation GetRelation (string p0)
		{
			if (id_getRelation_Ljava_lang_String_ == IntPtr.Zero)
				id_getRelation_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getRelation", "(Ljava/lang/String;)Lcom/parse/ParseRelation;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Com.Parse.ParseRelation __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseRelation> (JNIEnv.CallObjectMethod  (Handle, id_getRelation_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseRelation> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRelation", "(Ljava/lang/String;)Lcom/parse/ParseRelation;"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getString_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetString_Ljava_lang_String_Handler ()
		{
			if (cb_getString_Ljava_lang_String_ == null)
				cb_getString_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetString_Ljava_lang_String_);
			return cb_getString_Ljava_lang_String_;
		}

		static IntPtr n_GetString_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.ParseObject __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetString (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getString_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseObject']/method[@name='getString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getString", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetString_Ljava_lang_String_Handler")]
		public virtual string GetString (string p0)
		{
			if (id_getString_Ljava_lang_String_ == IntPtr.Zero)
				id_getString_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getString", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			string __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getString_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getString", "(Ljava/lang/String;)Ljava/lang/String;"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_has_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetHas_Ljava_lang_String_Handler ()
		{
			if (cb_has_Ljava_lang_String_ == null)
				cb_has_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Has_Ljava_lang_String_);
			return cb_has_Ljava_lang_String_;
		}

		static bool n_Has_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.ParseObject __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Has (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_has_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseObject']/method[@name='has' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("has", "(Ljava/lang/String;)Z", "GetHas_Ljava_lang_String_Handler")]
		public virtual bool Has (string p0)
		{
			if (id_has_Ljava_lang_String_ == IntPtr.Zero)
				id_has_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "has", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_has_Ljava_lang_String_, new JValue (native_p0));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "has", "(Ljava/lang/String;)Z"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_hasSameId_Lcom_parse_ParseObject_;
#pragma warning disable 0169
		static Delegate GetHasSameId_Lcom_parse_ParseObject_Handler ()
		{
			if (cb_hasSameId_Lcom_parse_ParseObject_ == null)
				cb_hasSameId_Lcom_parse_ParseObject_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_HasSameId_Lcom_parse_ParseObject_);
			return cb_hasSameId_Lcom_parse_ParseObject_;
		}

		static bool n_HasSameId_Lcom_parse_ParseObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.ParseObject __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Parse.ParseObject p0 = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseObject> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.HasSameId (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_hasSameId_Lcom_parse_ParseObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseObject']/method[@name='hasSameId' and count(parameter)=1 and parameter[1][@type='com.parse.ParseObject']]"
		[Register ("hasSameId", "(Lcom/parse/ParseObject;)Z", "GetHasSameId_Lcom_parse_ParseObject_Handler")]
		public virtual bool HasSameId (global::Com.Parse.ParseObject p0)
		{
			if (id_hasSameId_Lcom_parse_ParseObject_ == IntPtr.Zero)
				id_hasSameId_Lcom_parse_ParseObject_ = JNIEnv.GetMethodID (class_ref, "hasSameId", "(Lcom/parse/ParseObject;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_hasSameId_Lcom_parse_ParseObject_, new JValue (p0));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hasSameId", "(Lcom/parse/ParseObject;)Z"), new JValue (p0));
			return __ret;
		}

		static Delegate cb_increment_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetIncrement_Ljava_lang_String_Handler ()
		{
			if (cb_increment_Ljava_lang_String_ == null)
				cb_increment_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Increment_Ljava_lang_String_);
			return cb_increment_Ljava_lang_String_;
		}

		static void n_Increment_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.ParseObject __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Increment (p0);
		}
#pragma warning restore 0169

		static IntPtr id_increment_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseObject']/method[@name='increment' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("increment", "(Ljava/lang/String;)V", "GetIncrement_Ljava_lang_String_Handler")]
		public virtual void Increment (string p0)
		{
			if (id_increment_Ljava_lang_String_ == IntPtr.Zero)
				id_increment_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "increment", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_increment_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "increment", "(Ljava/lang/String;)V"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_increment_Ljava_lang_String_Ljava_lang_Number_;
#pragma warning disable 0169
		static Delegate GetIncrement_Ljava_lang_String_Ljava_lang_Number_Handler ()
		{
			if (cb_increment_Ljava_lang_String_Ljava_lang_Number_ == null)
				cb_increment_Ljava_lang_String_Ljava_lang_Number_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Increment_Ljava_lang_String_Ljava_lang_Number_);
			return cb_increment_Ljava_lang_String_Ljava_lang_Number_;
		}

		static void n_Increment_Ljava_lang_String_Ljava_lang_Number_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Parse.ParseObject __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Number p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Number> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Increment (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_increment_Ljava_lang_String_Ljava_lang_Number_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseObject']/method[@name='increment' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Number']]"
		[Register ("increment", "(Ljava/lang/String;Ljava/lang/Number;)V", "GetIncrement_Ljava_lang_String_Ljava_lang_Number_Handler")]
		public virtual void Increment (string p0, global::Java.Lang.Number p1)
		{
			if (id_increment_Ljava_lang_String_Ljava_lang_Number_ == IntPtr.Zero)
				id_increment_Ljava_lang_String_Ljava_lang_Number_ = JNIEnv.GetMethodID (class_ref, "increment", "(Ljava/lang/String;Ljava/lang/Number;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_increment_Ljava_lang_String_Ljava_lang_Number_, new JValue (native_p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "increment", "(Ljava/lang/String;Ljava/lang/Number;)V"), new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_keySet;
#pragma warning disable 0169
		static Delegate GetKeySetHandler ()
		{
			if (cb_keySet == null)
				cb_keySet = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_KeySet);
			return cb_keySet;
		}

		static IntPtr n_KeySet (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.ParseObject __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (__this.KeySet ());
		}
#pragma warning restore 0169

		static IntPtr id_keySet;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseObject']/method[@name='keySet' and count(parameter)=0]"
		[Register ("keySet", "()Ljava/util/Set;", "GetKeySetHandler")]
		public virtual global::System.Collections.Generic.ICollection<string> KeySet ()
		{
			if (id_keySet == IntPtr.Zero)
				id_keySet = JNIEnv.GetMethodID (class_ref, "keySet", "()Ljava/util/Set;");

			if (GetType () == ThresholdType)
				return global::Android.Runtime.JavaSet<string>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_keySet), JniHandleOwnership.TransferLocalRef);
			else
				return global::Android.Runtime.JavaSet<string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "keySet", "()Ljava/util/Set;")), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_put_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetPut_Ljava_lang_String_Ljava_lang_Object_Handler ()
		{
			if (cb_put_Ljava_lang_String_Ljava_lang_Object_ == null)
				cb_put_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Put_Ljava_lang_String_Ljava_lang_Object_);
			return cb_put_Ljava_lang_String_Ljava_lang_Object_;
		}

		static void n_Put_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Parse.ParseObject __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Put (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_put_Ljava_lang_String_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseObject']/method[@name='put' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
		[Register ("put", "(Ljava/lang/String;Ljava/lang/Object;)V", "GetPut_Ljava_lang_String_Ljava_lang_Object_Handler")]
		public virtual void Put (string p0, global::Java.Lang.Object p1)
		{
			if (id_put_Ljava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
				id_put_Ljava_lang_String_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "put", "(Ljava/lang/String;Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_put_Ljava_lang_String_Ljava_lang_Object_, new JValue (native_p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "put", "(Ljava/lang/String;Ljava/lang/Object;)V"), new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_refresh;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseObject']/method[@name='refresh' and count(parameter)=0]"
		[Register ("refresh", "()V", "")]
		public void Refresh ()
		{
			if (id_refresh == IntPtr.Zero)
				id_refresh = JNIEnv.GetMethodID (class_ref, "refresh", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_refresh);
		}

		static IntPtr id_refreshInBackground_Lcom_parse_RefreshCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseObject']/method[@name='refreshInBackground' and count(parameter)=1 and parameter[1][@type='com.parse.RefreshCallback']]"
		[Register ("refreshInBackground", "(Lcom/parse/RefreshCallback;)V", "")]
		public void RefreshInBackground (global::Com.Parse.RefreshCallback p0)
		{
			if (id_refreshInBackground_Lcom_parse_RefreshCallback_ == IntPtr.Zero)
				id_refreshInBackground_Lcom_parse_RefreshCallback_ = JNIEnv.GetMethodID (class_ref, "refreshInBackground", "(Lcom/parse/RefreshCallback;)V");
			JNIEnv.CallVoidMethod  (Handle, id_refreshInBackground_Lcom_parse_RefreshCallback_, new JValue (p0));
		}

		static IntPtr id_registerSubclass_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseObject']/method[@name='registerSubclass' and count(parameter)=1 and parameter[1][@type='java.lang.Class']]"
		[Register ("registerSubclass", "(Ljava/lang/Class;)V", "")]
		public static void RegisterSubclass (global::Java.Lang.Class p0)
		{
			if (id_registerSubclass_Ljava_lang_Class_ == IntPtr.Zero)
				id_registerSubclass_Ljava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "registerSubclass", "(Ljava/lang/Class;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_registerSubclass_Ljava_lang_Class_, new JValue (p0));
		}

		static Delegate cb_remove_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemove_Ljava_lang_String_Handler ()
		{
			if (cb_remove_Ljava_lang_String_ == null)
				cb_remove_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Remove_Ljava_lang_String_);
			return cb_remove_Ljava_lang_String_;
		}

		static void n_Remove_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.ParseObject __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Remove (p0);
		}
#pragma warning restore 0169

		static IntPtr id_remove_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseObject']/method[@name='remove' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("remove", "(Ljava/lang/String;)V", "GetRemove_Ljava_lang_String_Handler")]
		public virtual void Remove (string p0)
		{
			if (id_remove_Ljava_lang_String_ == IntPtr.Zero)
				id_remove_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "remove", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_remove_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "remove", "(Ljava/lang/String;)V"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_removeAll_Ljava_lang_String_Ljava_util_Collection_;
#pragma warning disable 0169
		static Delegate GetRemoveAll_Ljava_lang_String_Ljava_util_Collection_Handler ()
		{
			if (cb_removeAll_Ljava_lang_String_Ljava_util_Collection_ == null)
				cb_removeAll_Ljava_lang_String_Ljava_util_Collection_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_RemoveAll_Ljava_lang_String_Ljava_util_Collection_);
			return cb_removeAll_Ljava_lang_String_Ljava_util_Collection_;
		}

		static void n_RemoveAll_Ljava_lang_String_Ljava_util_Collection_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Parse.ParseObject __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.ICollection<object> p1 = global::Android.Runtime.JavaCollection<object>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.RemoveAll (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_removeAll_Ljava_lang_String_Ljava_util_Collection_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseObject']/method[@name='removeAll' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Collection']]"
		[Register ("removeAll", "(Ljava/lang/String;Ljava/util/Collection;)V", "GetRemoveAll_Ljava_lang_String_Ljava_util_Collection_Handler")]
		public virtual void RemoveAll (string p0, global::System.Collections.Generic.ICollection<object> p1)
		{
			if (id_removeAll_Ljava_lang_String_Ljava_util_Collection_ == IntPtr.Zero)
				id_removeAll_Ljava_lang_String_Ljava_util_Collection_ = JNIEnv.GetMethodID (class_ref, "removeAll", "(Ljava/lang/String;Ljava/util/Collection;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaCollection<object>.ToLocalJniHandle (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_removeAll_Ljava_lang_String_Ljava_util_Collection_, new JValue (native_p0), new JValue (native_p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeAll", "(Ljava/lang/String;Ljava/util/Collection;)V"), new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_save;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseObject']/method[@name='save' and count(parameter)=0]"
		[Register ("save", "()V", "")]
		public void Save ()
		{
			if (id_save == IntPtr.Zero)
				id_save = JNIEnv.GetMethodID (class_ref, "save", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_save);
		}

		static IntPtr id_saveAll_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseObject']/method[@name='saveAll' and count(parameter)=1 and parameter[1][@type='java.util.List']]"
		[Register ("saveAll", "(Ljava/util/List;)V", "")]
		public static void SaveAll (global::System.Collections.Generic.IList<global::Com.Parse.ParseObject> p0)
		{
			if (id_saveAll_Ljava_util_List_ == IntPtr.Zero)
				id_saveAll_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "saveAll", "(Ljava/util/List;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Parse.ParseObject>.ToLocalJniHandle (p0);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_saveAll_Ljava_util_List_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_saveAllInBackground_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseObject']/method[@name='saveAllInBackground' and count(parameter)=1 and parameter[1][@type='java.util.List']]"
		[Register ("saveAllInBackground", "(Ljava/util/List;)V", "")]
		public static void SaveAllInBackground (global::System.Collections.Generic.IList<global::Com.Parse.ParseObject> p0)
		{
			if (id_saveAllInBackground_Ljava_util_List_ == IntPtr.Zero)
				id_saveAllInBackground_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "saveAllInBackground", "(Ljava/util/List;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Parse.ParseObject>.ToLocalJniHandle (p0);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_saveAllInBackground_Ljava_util_List_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_saveAllInBackground_Ljava_util_List_Lcom_parse_SaveCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseObject']/method[@name='saveAllInBackground' and count(parameter)=2 and parameter[1][@type='java.util.List'] and parameter[2][@type='com.parse.SaveCallback']]"
		[Register ("saveAllInBackground", "(Ljava/util/List;Lcom/parse/SaveCallback;)V", "")]
		public static void SaveAllInBackground (global::System.Collections.Generic.IList<global::Com.Parse.ParseObject> p0, global::Com.Parse.SaveCallback p1)
		{
			if (id_saveAllInBackground_Ljava_util_List_Lcom_parse_SaveCallback_ == IntPtr.Zero)
				id_saveAllInBackground_Ljava_util_List_Lcom_parse_SaveCallback_ = JNIEnv.GetStaticMethodID (class_ref, "saveAllInBackground", "(Ljava/util/List;Lcom/parse/SaveCallback;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Parse.ParseObject>.ToLocalJniHandle (p0);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_saveAllInBackground_Ljava_util_List_Lcom_parse_SaveCallback_, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_saveEventually;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseObject']/method[@name='saveEventually' and count(parameter)=0]"
		[Register ("saveEventually", "()V", "")]
		public void SaveEventually ()
		{
			if (id_saveEventually == IntPtr.Zero)
				id_saveEventually = JNIEnv.GetMethodID (class_ref, "saveEventually", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_saveEventually);
		}

		static Delegate cb_saveEventually_Lcom_parse_SaveCallback_;
#pragma warning disable 0169
		static Delegate GetSaveEventually_Lcom_parse_SaveCallback_Handler ()
		{
			if (cb_saveEventually_Lcom_parse_SaveCallback_ == null)
				cb_saveEventually_Lcom_parse_SaveCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SaveEventually_Lcom_parse_SaveCallback_);
			return cb_saveEventually_Lcom_parse_SaveCallback_;
		}

		static void n_SaveEventually_Lcom_parse_SaveCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.ParseObject __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Parse.SaveCallback p0 = global::Java.Lang.Object.GetObject<global::Com.Parse.SaveCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SaveEventually (p0);
		}
#pragma warning restore 0169

		static IntPtr id_saveEventually_Lcom_parse_SaveCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseObject']/method[@name='saveEventually' and count(parameter)=1 and parameter[1][@type='com.parse.SaveCallback']]"
		[Register ("saveEventually", "(Lcom/parse/SaveCallback;)V", "GetSaveEventually_Lcom_parse_SaveCallback_Handler")]
		public virtual void SaveEventually (global::Com.Parse.SaveCallback p0)
		{
			if (id_saveEventually_Lcom_parse_SaveCallback_ == IntPtr.Zero)
				id_saveEventually_Lcom_parse_SaveCallback_ = JNIEnv.GetMethodID (class_ref, "saveEventually", "(Lcom/parse/SaveCallback;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_saveEventually_Lcom_parse_SaveCallback_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "saveEventually", "(Lcom/parse/SaveCallback;)V"), new JValue (p0));
		}

		static IntPtr id_saveInBackground;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseObject']/method[@name='saveInBackground' and count(parameter)=0]"
		[Register ("saveInBackground", "()V", "")]
		public void SaveInBackground ()
		{
			if (id_saveInBackground == IntPtr.Zero)
				id_saveInBackground = JNIEnv.GetMethodID (class_ref, "saveInBackground", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_saveInBackground);
		}

		static IntPtr id_saveInBackground_Lcom_parse_SaveCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseObject']/method[@name='saveInBackground' and count(parameter)=1 and parameter[1][@type='com.parse.SaveCallback']]"
		[Register ("saveInBackground", "(Lcom/parse/SaveCallback;)V", "")]
		public void SaveInBackground (global::Com.Parse.SaveCallback p0)
		{
			if (id_saveInBackground_Lcom_parse_SaveCallback_ == IntPtr.Zero)
				id_saveInBackground_Lcom_parse_SaveCallback_ = JNIEnv.GetMethodID (class_ref, "saveInBackground", "(Lcom/parse/SaveCallback;)V");
			JNIEnv.CallVoidMethod  (Handle, id_saveInBackground_Lcom_parse_SaveCallback_, new JValue (p0));
		}

	}
}
