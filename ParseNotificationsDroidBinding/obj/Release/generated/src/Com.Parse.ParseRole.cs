using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Parse {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.parse']/class[@name='ParseRole']"
	[global::Android.Runtime.Register ("com/parse/ParseRole", DoNotGenerateAcw=true)]
	public partial class ParseRole : global::Com.Parse.ParseObject {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/parse/ParseRole", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ParseRole); }
		}

		protected ParseRole (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Lcom_parse_ParseACL_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.parse']/class[@name='ParseRole']/constructor[@name='ParseRole' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.parse.ParseACL']]"
		[Register (".ctor", "(Ljava/lang/String;Lcom/parse/ParseACL;)V", "")]
		public ParseRole (string p0, global::Com.Parse.ParseACL p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);;
			if (GetType () != typeof (ParseRole)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Lcom/parse/ParseACL;)V", new JValue (native_p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Lcom/parse/ParseACL;)V", new JValue (native_p0), new JValue (p1));
				JNIEnv.DeleteLocalRef (native_p0);
				return;
			}

			if (id_ctor_Ljava_lang_String_Lcom_parse_ParseACL_ == IntPtr.Zero)
				id_ctor_Ljava_lang_String_Lcom_parse_ParseACL_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Lcom/parse/ParseACL;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Lcom_parse_ParseACL_, new JValue (native_p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Lcom_parse_ParseACL_, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.parse']/class[@name='ParseRole']/constructor[@name='ParseRole' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public ParseRole (string p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);;
			if (GetType () != typeof (ParseRole)) {
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
			global::Com.Parse.ParseRole __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseRole> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		static Delegate cb_setName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetName_Ljava_lang_String_Handler ()
		{
			if (cb_setName_Ljava_lang_String_ == null)
				cb_setName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetName_Ljava_lang_String_);
			return cb_setName_Ljava_lang_String_;
		}

		static void n_SetName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.ParseRole __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseRole> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Name = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getName;
		static IntPtr id_setName_Ljava_lang_String_;
		public virtual string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseRole']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
			get {
				if (id_getName == IntPtr.Zero)
					id_getName = JNIEnv.GetMethodID (class_ref, "getName", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getName), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseRole']/method[@name='setName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setName", "(Ljava/lang/String;)V", "GetSetName_Ljava_lang_String_Handler")]
			set {
				if (id_setName_Ljava_lang_String_ == IntPtr.Zero)
					id_setName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setName", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setName_Ljava_lang_String_, new JValue (native_value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setName", "(Ljava/lang/String;)V"), new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr id_getQuery;
		public static global::Com.Parse.ParseQuery Query {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseRole']/method[@name='getQuery' and count(parameter)=0]"
			[Register ("getQuery", "()Lcom/parse/ParseQuery;", "GetGetQueryHandler")]
			get {
				if (id_getQuery == IntPtr.Zero)
					id_getQuery = JNIEnv.GetStaticMethodID (class_ref, "getQuery", "()Lcom/parse/ParseQuery;");
				return global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getQuery), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getRoles;
#pragma warning disable 0169
		static Delegate GetGetRolesHandler ()
		{
			if (cb_getRoles == null)
				cb_getRoles = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRoles);
			return cb_getRoles;
		}

		static IntPtr n_GetRoles (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.ParseRole __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseRole> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Roles);
		}
#pragma warning restore 0169

		static IntPtr id_getRoles;
		public virtual global::Com.Parse.ParseRelation Roles {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseRole']/method[@name='getRoles' and count(parameter)=0]"
			[Register ("getRoles", "()Lcom/parse/ParseRelation;", "GetGetRolesHandler")]
			get {
				if (id_getRoles == IntPtr.Zero)
					id_getRoles = JNIEnv.GetMethodID (class_ref, "getRoles", "()Lcom/parse/ParseRelation;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Parse.ParseRelation> (JNIEnv.CallObjectMethod  (Handle, id_getRoles), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Parse.ParseRelation> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRoles", "()Lcom/parse/ParseRelation;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getUsers;
#pragma warning disable 0169
		static Delegate GetGetUsersHandler ()
		{
			if (cb_getUsers == null)
				cb_getUsers = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUsers);
			return cb_getUsers;
		}

		static IntPtr n_GetUsers (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.ParseRole __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseRole> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Users);
		}
#pragma warning restore 0169

		static IntPtr id_getUsers;
		public virtual global::Com.Parse.ParseRelation Users {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseRole']/method[@name='getUsers' and count(parameter)=0]"
			[Register ("getUsers", "()Lcom/parse/ParseRelation;", "GetGetUsersHandler")]
			get {
				if (id_getUsers == IntPtr.Zero)
					id_getUsers = JNIEnv.GetMethodID (class_ref, "getUsers", "()Lcom/parse/ParseRelation;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Parse.ParseRelation> (JNIEnv.CallObjectMethod  (Handle, id_getUsers), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Parse.ParseRelation> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUsers", "()Lcom/parse/ParseRelation;")), JniHandleOwnership.TransferLocalRef);
			}
		}

	}
}
