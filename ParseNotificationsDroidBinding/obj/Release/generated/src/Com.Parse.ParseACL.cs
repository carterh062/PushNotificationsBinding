using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Parse {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.parse']/class[@name='ParseACL']"
	[global::Android.Runtime.Register ("com/parse/ParseACL", DoNotGenerateAcw=true)]
	public partial class ParseACL : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.parse']/class[@name='ParseACL.UserResolutionListener']"
		[global::Android.Runtime.Register ("com/parse/ParseACL$UserResolutionListener", DoNotGenerateAcw=true)]
		public partial class UserResolutionListener : global::Com.Parse.GetCallback {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/parse/ParseACL$UserResolutionListener", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (UserResolutionListener); }
			}

			protected UserResolutionListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_parse_ParseACL_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.parse']/class[@name='ParseACL.UserResolutionListener']/constructor[@name='ParseACL.UserResolutionListener' and count(parameter)=1 and parameter[1][@type='com.parse.ParseACL']]"
			[Register (".ctor", "(Lcom/parse/ParseACL;)V", "")]
			public UserResolutionListener (global::Com.Parse.ParseACL p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (UserResolutionListener)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/parse/ParseACL;)V", new JValue (p0)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/parse/ParseACL;)V", new JValue (p0));
					return;
				}

				if (id_ctor_Lcom_parse_ParseACL_ == IntPtr.Zero)
					id_ctor_Lcom_parse_ParseACL_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/parse/ParseACL;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_parse_ParseACL_, new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_parse_ParseACL_, new JValue (p0));
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/parse/ParseACL", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ParseACL); }
		}

		protected ParseACL (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_parse_ParseUser_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.parse']/class[@name='ParseACL']/constructor[@name='ParseACL' and count(parameter)=1 and parameter[1][@type='com.parse.ParseUser']]"
		[Register (".ctor", "(Lcom/parse/ParseUser;)V", "")]
		public ParseACL (global::Com.Parse.ParseUser p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ParseACL)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/parse/ParseUser;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/parse/ParseUser;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Lcom_parse_ParseUser_ == IntPtr.Zero)
				id_ctor_Lcom_parse_ParseUser_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/parse/ParseUser;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_parse_ParseUser_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_parse_ParseUser_, new JValue (p0));
		}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.parse']/class[@name='ParseACL']/constructor[@name='ParseACL' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public ParseACL () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ParseACL)) {
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

		static Delegate cb_getPublicReadAccess;
#pragma warning disable 0169
		static Delegate GetGetPublicReadAccessHandler ()
		{
			if (cb_getPublicReadAccess == null)
				cb_getPublicReadAccess = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetPublicReadAccess);
			return cb_getPublicReadAccess;
		}

		static bool n_GetPublicReadAccess (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.ParseACL __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseACL> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PublicReadAccess;
		}
#pragma warning restore 0169

		static Delegate cb_setPublicReadAccess_Z;
#pragma warning disable 0169
		static Delegate GetSetPublicReadAccess_ZHandler ()
		{
			if (cb_setPublicReadAccess_Z == null)
				cb_setPublicReadAccess_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetPublicReadAccess_Z);
			return cb_setPublicReadAccess_Z;
		}

		static void n_SetPublicReadAccess_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Parse.ParseACL __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseACL> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PublicReadAccess = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getPublicReadAccess;
		static IntPtr id_setPublicReadAccess_Z;
		public virtual bool PublicReadAccess {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseACL']/method[@name='getPublicReadAccess' and count(parameter)=0]"
			[Register ("getPublicReadAccess", "()Z", "GetGetPublicReadAccessHandler")]
			get {
				if (id_getPublicReadAccess == IntPtr.Zero)
					id_getPublicReadAccess = JNIEnv.GetMethodID (class_ref, "getPublicReadAccess", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_getPublicReadAccess);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPublicReadAccess", "()Z"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseACL']/method[@name='setPublicReadAccess' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setPublicReadAccess", "(Z)V", "GetSetPublicReadAccess_ZHandler")]
			set {
				if (id_setPublicReadAccess_Z == IntPtr.Zero)
					id_setPublicReadAccess_Z = JNIEnv.GetMethodID (class_ref, "setPublicReadAccess", "(Z)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setPublicReadAccess_Z, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPublicReadAccess", "(Z)V"), new JValue (value));
			}
		}

		static Delegate cb_getPublicWriteAccess;
#pragma warning disable 0169
		static Delegate GetGetPublicWriteAccessHandler ()
		{
			if (cb_getPublicWriteAccess == null)
				cb_getPublicWriteAccess = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetPublicWriteAccess);
			return cb_getPublicWriteAccess;
		}

		static bool n_GetPublicWriteAccess (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.ParseACL __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseACL> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PublicWriteAccess;
		}
#pragma warning restore 0169

		static Delegate cb_setPublicWriteAccess_Z;
#pragma warning disable 0169
		static Delegate GetSetPublicWriteAccess_ZHandler ()
		{
			if (cb_setPublicWriteAccess_Z == null)
				cb_setPublicWriteAccess_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetPublicWriteAccess_Z);
			return cb_setPublicWriteAccess_Z;
		}

		static void n_SetPublicWriteAccess_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Parse.ParseACL __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseACL> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PublicWriteAccess = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getPublicWriteAccess;
		static IntPtr id_setPublicWriteAccess_Z;
		public virtual bool PublicWriteAccess {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseACL']/method[@name='getPublicWriteAccess' and count(parameter)=0]"
			[Register ("getPublicWriteAccess", "()Z", "GetGetPublicWriteAccessHandler")]
			get {
				if (id_getPublicWriteAccess == IntPtr.Zero)
					id_getPublicWriteAccess = JNIEnv.GetMethodID (class_ref, "getPublicWriteAccess", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_getPublicWriteAccess);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPublicWriteAccess", "()Z"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseACL']/method[@name='setPublicWriteAccess' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setPublicWriteAccess", "(Z)V", "GetSetPublicWriteAccess_ZHandler")]
			set {
				if (id_setPublicWriteAccess_Z == IntPtr.Zero)
					id_setPublicWriteAccess_Z = JNIEnv.GetMethodID (class_ref, "setPublicWriteAccess", "(Z)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setPublicWriteAccess_Z, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPublicWriteAccess", "(Z)V"), new JValue (value));
			}
		}

		static Delegate cb_getReadAccess_Lcom_parse_ParseUser_;
#pragma warning disable 0169
		static Delegate GetGetReadAccess_Lcom_parse_ParseUser_Handler ()
		{
			if (cb_getReadAccess_Lcom_parse_ParseUser_ == null)
				cb_getReadAccess_Lcom_parse_ParseUser_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_GetReadAccess_Lcom_parse_ParseUser_);
			return cb_getReadAccess_Lcom_parse_ParseUser_;
		}

		static bool n_GetReadAccess_Lcom_parse_ParseUser_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.ParseACL __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseACL> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Parse.ParseUser p0 = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseUser> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.GetReadAccess (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getReadAccess_Lcom_parse_ParseUser_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseACL']/method[@name='getReadAccess' and count(parameter)=1 and parameter[1][@type='com.parse.ParseUser']]"
		[Register ("getReadAccess", "(Lcom/parse/ParseUser;)Z", "GetGetReadAccess_Lcom_parse_ParseUser_Handler")]
		public virtual bool GetReadAccess (global::Com.Parse.ParseUser p0)
		{
			if (id_getReadAccess_Lcom_parse_ParseUser_ == IntPtr.Zero)
				id_getReadAccess_Lcom_parse_ParseUser_ = JNIEnv.GetMethodID (class_ref, "getReadAccess", "(Lcom/parse/ParseUser;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_getReadAccess_Lcom_parse_ParseUser_, new JValue (p0));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getReadAccess", "(Lcom/parse/ParseUser;)Z"), new JValue (p0));
			return __ret;
		}

		static Delegate cb_getReadAccess_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetReadAccess_Ljava_lang_String_Handler ()
		{
			if (cb_getReadAccess_Ljava_lang_String_ == null)
				cb_getReadAccess_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_GetReadAccess_Ljava_lang_String_);
			return cb_getReadAccess_Ljava_lang_String_;
		}

		static bool n_GetReadAccess_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.ParseACL __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseACL> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.GetReadAccess (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getReadAccess_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseACL']/method[@name='getReadAccess' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getReadAccess", "(Ljava/lang/String;)Z", "GetGetReadAccess_Ljava_lang_String_Handler")]
		public virtual bool GetReadAccess (string p0)
		{
			if (id_getReadAccess_Ljava_lang_String_ == IntPtr.Zero)
				id_getReadAccess_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getReadAccess", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_getReadAccess_Ljava_lang_String_, new JValue (native_p0));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getReadAccess", "(Ljava/lang/String;)Z"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getRoleReadAccess_Lcom_parse_ParseRole_;
#pragma warning disable 0169
		static Delegate GetGetRoleReadAccess_Lcom_parse_ParseRole_Handler ()
		{
			if (cb_getRoleReadAccess_Lcom_parse_ParseRole_ == null)
				cb_getRoleReadAccess_Lcom_parse_ParseRole_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_GetRoleReadAccess_Lcom_parse_ParseRole_);
			return cb_getRoleReadAccess_Lcom_parse_ParseRole_;
		}

		static bool n_GetRoleReadAccess_Lcom_parse_ParseRole_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.ParseACL __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseACL> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Parse.ParseRole p0 = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseRole> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.GetRoleReadAccess (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getRoleReadAccess_Lcom_parse_ParseRole_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseACL']/method[@name='getRoleReadAccess' and count(parameter)=1 and parameter[1][@type='com.parse.ParseRole']]"
		[Register ("getRoleReadAccess", "(Lcom/parse/ParseRole;)Z", "GetGetRoleReadAccess_Lcom_parse_ParseRole_Handler")]
		public virtual bool GetRoleReadAccess (global::Com.Parse.ParseRole p0)
		{
			if (id_getRoleReadAccess_Lcom_parse_ParseRole_ == IntPtr.Zero)
				id_getRoleReadAccess_Lcom_parse_ParseRole_ = JNIEnv.GetMethodID (class_ref, "getRoleReadAccess", "(Lcom/parse/ParseRole;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_getRoleReadAccess_Lcom_parse_ParseRole_, new JValue (p0));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRoleReadAccess", "(Lcom/parse/ParseRole;)Z"), new JValue (p0));
			return __ret;
		}

		static Delegate cb_getRoleReadAccess_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetRoleReadAccess_Ljava_lang_String_Handler ()
		{
			if (cb_getRoleReadAccess_Ljava_lang_String_ == null)
				cb_getRoleReadAccess_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_GetRoleReadAccess_Ljava_lang_String_);
			return cb_getRoleReadAccess_Ljava_lang_String_;
		}

		static bool n_GetRoleReadAccess_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.ParseACL __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseACL> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.GetRoleReadAccess (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getRoleReadAccess_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseACL']/method[@name='getRoleReadAccess' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getRoleReadAccess", "(Ljava/lang/String;)Z", "GetGetRoleReadAccess_Ljava_lang_String_Handler")]
		public virtual bool GetRoleReadAccess (string p0)
		{
			if (id_getRoleReadAccess_Ljava_lang_String_ == IntPtr.Zero)
				id_getRoleReadAccess_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getRoleReadAccess", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_getRoleReadAccess_Ljava_lang_String_, new JValue (native_p0));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRoleReadAccess", "(Ljava/lang/String;)Z"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getRoleWriteAccess_Lcom_parse_ParseRole_;
#pragma warning disable 0169
		static Delegate GetGetRoleWriteAccess_Lcom_parse_ParseRole_Handler ()
		{
			if (cb_getRoleWriteAccess_Lcom_parse_ParseRole_ == null)
				cb_getRoleWriteAccess_Lcom_parse_ParseRole_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_GetRoleWriteAccess_Lcom_parse_ParseRole_);
			return cb_getRoleWriteAccess_Lcom_parse_ParseRole_;
		}

		static bool n_GetRoleWriteAccess_Lcom_parse_ParseRole_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.ParseACL __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseACL> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Parse.ParseRole p0 = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseRole> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.GetRoleWriteAccess (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getRoleWriteAccess_Lcom_parse_ParseRole_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseACL']/method[@name='getRoleWriteAccess' and count(parameter)=1 and parameter[1][@type='com.parse.ParseRole']]"
		[Register ("getRoleWriteAccess", "(Lcom/parse/ParseRole;)Z", "GetGetRoleWriteAccess_Lcom_parse_ParseRole_Handler")]
		public virtual bool GetRoleWriteAccess (global::Com.Parse.ParseRole p0)
		{
			if (id_getRoleWriteAccess_Lcom_parse_ParseRole_ == IntPtr.Zero)
				id_getRoleWriteAccess_Lcom_parse_ParseRole_ = JNIEnv.GetMethodID (class_ref, "getRoleWriteAccess", "(Lcom/parse/ParseRole;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_getRoleWriteAccess_Lcom_parse_ParseRole_, new JValue (p0));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRoleWriteAccess", "(Lcom/parse/ParseRole;)Z"), new JValue (p0));
			return __ret;
		}

		static Delegate cb_getRoleWriteAccess_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetRoleWriteAccess_Ljava_lang_String_Handler ()
		{
			if (cb_getRoleWriteAccess_Ljava_lang_String_ == null)
				cb_getRoleWriteAccess_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_GetRoleWriteAccess_Ljava_lang_String_);
			return cb_getRoleWriteAccess_Ljava_lang_String_;
		}

		static bool n_GetRoleWriteAccess_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.ParseACL __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseACL> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.GetRoleWriteAccess (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getRoleWriteAccess_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseACL']/method[@name='getRoleWriteAccess' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getRoleWriteAccess", "(Ljava/lang/String;)Z", "GetGetRoleWriteAccess_Ljava_lang_String_Handler")]
		public virtual bool GetRoleWriteAccess (string p0)
		{
			if (id_getRoleWriteAccess_Ljava_lang_String_ == IntPtr.Zero)
				id_getRoleWriteAccess_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getRoleWriteAccess", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_getRoleWriteAccess_Ljava_lang_String_, new JValue (native_p0));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRoleWriteAccess", "(Ljava/lang/String;)Z"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getWriteAccess_Lcom_parse_ParseUser_;
#pragma warning disable 0169
		static Delegate GetGetWriteAccess_Lcom_parse_ParseUser_Handler ()
		{
			if (cb_getWriteAccess_Lcom_parse_ParseUser_ == null)
				cb_getWriteAccess_Lcom_parse_ParseUser_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_GetWriteAccess_Lcom_parse_ParseUser_);
			return cb_getWriteAccess_Lcom_parse_ParseUser_;
		}

		static bool n_GetWriteAccess_Lcom_parse_ParseUser_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.ParseACL __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseACL> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Parse.ParseUser p0 = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseUser> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.GetWriteAccess (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getWriteAccess_Lcom_parse_ParseUser_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseACL']/method[@name='getWriteAccess' and count(parameter)=1 and parameter[1][@type='com.parse.ParseUser']]"
		[Register ("getWriteAccess", "(Lcom/parse/ParseUser;)Z", "GetGetWriteAccess_Lcom_parse_ParseUser_Handler")]
		public virtual bool GetWriteAccess (global::Com.Parse.ParseUser p0)
		{
			if (id_getWriteAccess_Lcom_parse_ParseUser_ == IntPtr.Zero)
				id_getWriteAccess_Lcom_parse_ParseUser_ = JNIEnv.GetMethodID (class_ref, "getWriteAccess", "(Lcom/parse/ParseUser;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_getWriteAccess_Lcom_parse_ParseUser_, new JValue (p0));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getWriteAccess", "(Lcom/parse/ParseUser;)Z"), new JValue (p0));
			return __ret;
		}

		static Delegate cb_getWriteAccess_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetWriteAccess_Ljava_lang_String_Handler ()
		{
			if (cb_getWriteAccess_Ljava_lang_String_ == null)
				cb_getWriteAccess_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_GetWriteAccess_Ljava_lang_String_);
			return cb_getWriteAccess_Ljava_lang_String_;
		}

		static bool n_GetWriteAccess_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.ParseACL __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseACL> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.GetWriteAccess (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getWriteAccess_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseACL']/method[@name='getWriteAccess' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getWriteAccess", "(Ljava/lang/String;)Z", "GetGetWriteAccess_Ljava_lang_String_Handler")]
		public virtual bool GetWriteAccess (string p0)
		{
			if (id_getWriteAccess_Ljava_lang_String_ == IntPtr.Zero)
				id_getWriteAccess_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getWriteAccess", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_getWriteAccess_Ljava_lang_String_, new JValue (native_p0));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getWriteAccess", "(Ljava/lang/String;)Z"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_setDefaultACL_Lcom_parse_ParseACL_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseACL']/method[@name='setDefaultACL' and count(parameter)=2 and parameter[1][@type='com.parse.ParseACL'] and parameter[2][@type='boolean']]"
		[Register ("setDefaultACL", "(Lcom/parse/ParseACL;Z)V", "")]
		public static void SetDefaultACL (global::Com.Parse.ParseACL p0, bool p1)
		{
			if (id_setDefaultACL_Lcom_parse_ParseACL_Z == IntPtr.Zero)
				id_setDefaultACL_Lcom_parse_ParseACL_Z = JNIEnv.GetStaticMethodID (class_ref, "setDefaultACL", "(Lcom/parse/ParseACL;Z)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_setDefaultACL_Lcom_parse_ParseACL_Z, new JValue (p0), new JValue (p1));
		}

		static Delegate cb_setReadAccess_Lcom_parse_ParseUser_Z;
#pragma warning disable 0169
		static Delegate GetSetReadAccess_Lcom_parse_ParseUser_ZHandler ()
		{
			if (cb_setReadAccess_Lcom_parse_ParseUser_Z == null)
				cb_setReadAccess_Lcom_parse_ParseUser_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_SetReadAccess_Lcom_parse_ParseUser_Z);
			return cb_setReadAccess_Lcom_parse_ParseUser_Z;
		}

		static void n_SetReadAccess_Lcom_parse_ParseUser_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Parse.ParseACL __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseACL> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Parse.ParseUser p0 = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseUser> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetReadAccess (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setReadAccess_Lcom_parse_ParseUser_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseACL']/method[@name='setReadAccess' and count(parameter)=2 and parameter[1][@type='com.parse.ParseUser'] and parameter[2][@type='boolean']]"
		[Register ("setReadAccess", "(Lcom/parse/ParseUser;Z)V", "GetSetReadAccess_Lcom_parse_ParseUser_ZHandler")]
		public virtual void SetReadAccess (global::Com.Parse.ParseUser p0, bool p1)
		{
			if (id_setReadAccess_Lcom_parse_ParseUser_Z == IntPtr.Zero)
				id_setReadAccess_Lcom_parse_ParseUser_Z = JNIEnv.GetMethodID (class_ref, "setReadAccess", "(Lcom/parse/ParseUser;Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setReadAccess_Lcom_parse_ParseUser_Z, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setReadAccess", "(Lcom/parse/ParseUser;Z)V"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_setReadAccess_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetSetReadAccess_Ljava_lang_String_ZHandler ()
		{
			if (cb_setReadAccess_Ljava_lang_String_Z == null)
				cb_setReadAccess_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_SetReadAccess_Ljava_lang_String_Z);
			return cb_setReadAccess_Ljava_lang_String_Z;
		}

		static void n_SetReadAccess_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Parse.ParseACL __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseACL> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetReadAccess (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setReadAccess_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseACL']/method[@name='setReadAccess' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("setReadAccess", "(Ljava/lang/String;Z)V", "GetSetReadAccess_Ljava_lang_String_ZHandler")]
		public virtual void SetReadAccess (string p0, bool p1)
		{
			if (id_setReadAccess_Ljava_lang_String_Z == IntPtr.Zero)
				id_setReadAccess_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "setReadAccess", "(Ljava/lang/String;Z)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setReadAccess_Ljava_lang_String_Z, new JValue (native_p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setReadAccess", "(Ljava/lang/String;Z)V"), new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_setRoleReadAccess_Lcom_parse_ParseRole_Z;
#pragma warning disable 0169
		static Delegate GetSetRoleReadAccess_Lcom_parse_ParseRole_ZHandler ()
		{
			if (cb_setRoleReadAccess_Lcom_parse_ParseRole_Z == null)
				cb_setRoleReadAccess_Lcom_parse_ParseRole_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_SetRoleReadAccess_Lcom_parse_ParseRole_Z);
			return cb_setRoleReadAccess_Lcom_parse_ParseRole_Z;
		}

		static void n_SetRoleReadAccess_Lcom_parse_ParseRole_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Parse.ParseACL __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseACL> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Parse.ParseRole p0 = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseRole> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetRoleReadAccess (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setRoleReadAccess_Lcom_parse_ParseRole_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseACL']/method[@name='setRoleReadAccess' and count(parameter)=2 and parameter[1][@type='com.parse.ParseRole'] and parameter[2][@type='boolean']]"
		[Register ("setRoleReadAccess", "(Lcom/parse/ParseRole;Z)V", "GetSetRoleReadAccess_Lcom_parse_ParseRole_ZHandler")]
		public virtual void SetRoleReadAccess (global::Com.Parse.ParseRole p0, bool p1)
		{
			if (id_setRoleReadAccess_Lcom_parse_ParseRole_Z == IntPtr.Zero)
				id_setRoleReadAccess_Lcom_parse_ParseRole_Z = JNIEnv.GetMethodID (class_ref, "setRoleReadAccess", "(Lcom/parse/ParseRole;Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setRoleReadAccess_Lcom_parse_ParseRole_Z, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRoleReadAccess", "(Lcom/parse/ParseRole;Z)V"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_setRoleReadAccess_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetSetRoleReadAccess_Ljava_lang_String_ZHandler ()
		{
			if (cb_setRoleReadAccess_Ljava_lang_String_Z == null)
				cb_setRoleReadAccess_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_SetRoleReadAccess_Ljava_lang_String_Z);
			return cb_setRoleReadAccess_Ljava_lang_String_Z;
		}

		static void n_SetRoleReadAccess_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Parse.ParseACL __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseACL> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetRoleReadAccess (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setRoleReadAccess_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseACL']/method[@name='setRoleReadAccess' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("setRoleReadAccess", "(Ljava/lang/String;Z)V", "GetSetRoleReadAccess_Ljava_lang_String_ZHandler")]
		public virtual void SetRoleReadAccess (string p0, bool p1)
		{
			if (id_setRoleReadAccess_Ljava_lang_String_Z == IntPtr.Zero)
				id_setRoleReadAccess_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "setRoleReadAccess", "(Ljava/lang/String;Z)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setRoleReadAccess_Ljava_lang_String_Z, new JValue (native_p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRoleReadAccess", "(Ljava/lang/String;Z)V"), new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_setRoleWriteAccess_Lcom_parse_ParseRole_Z;
#pragma warning disable 0169
		static Delegate GetSetRoleWriteAccess_Lcom_parse_ParseRole_ZHandler ()
		{
			if (cb_setRoleWriteAccess_Lcom_parse_ParseRole_Z == null)
				cb_setRoleWriteAccess_Lcom_parse_ParseRole_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_SetRoleWriteAccess_Lcom_parse_ParseRole_Z);
			return cb_setRoleWriteAccess_Lcom_parse_ParseRole_Z;
		}

		static void n_SetRoleWriteAccess_Lcom_parse_ParseRole_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Parse.ParseACL __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseACL> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Parse.ParseRole p0 = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseRole> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetRoleWriteAccess (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setRoleWriteAccess_Lcom_parse_ParseRole_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseACL']/method[@name='setRoleWriteAccess' and count(parameter)=2 and parameter[1][@type='com.parse.ParseRole'] and parameter[2][@type='boolean']]"
		[Register ("setRoleWriteAccess", "(Lcom/parse/ParseRole;Z)V", "GetSetRoleWriteAccess_Lcom_parse_ParseRole_ZHandler")]
		public virtual void SetRoleWriteAccess (global::Com.Parse.ParseRole p0, bool p1)
		{
			if (id_setRoleWriteAccess_Lcom_parse_ParseRole_Z == IntPtr.Zero)
				id_setRoleWriteAccess_Lcom_parse_ParseRole_Z = JNIEnv.GetMethodID (class_ref, "setRoleWriteAccess", "(Lcom/parse/ParseRole;Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setRoleWriteAccess_Lcom_parse_ParseRole_Z, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRoleWriteAccess", "(Lcom/parse/ParseRole;Z)V"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_setRoleWriteAccess_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetSetRoleWriteAccess_Ljava_lang_String_ZHandler ()
		{
			if (cb_setRoleWriteAccess_Ljava_lang_String_Z == null)
				cb_setRoleWriteAccess_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_SetRoleWriteAccess_Ljava_lang_String_Z);
			return cb_setRoleWriteAccess_Ljava_lang_String_Z;
		}

		static void n_SetRoleWriteAccess_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Parse.ParseACL __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseACL> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetRoleWriteAccess (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setRoleWriteAccess_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseACL']/method[@name='setRoleWriteAccess' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("setRoleWriteAccess", "(Ljava/lang/String;Z)V", "GetSetRoleWriteAccess_Ljava_lang_String_ZHandler")]
		public virtual void SetRoleWriteAccess (string p0, bool p1)
		{
			if (id_setRoleWriteAccess_Ljava_lang_String_Z == IntPtr.Zero)
				id_setRoleWriteAccess_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "setRoleWriteAccess", "(Ljava/lang/String;Z)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setRoleWriteAccess_Ljava_lang_String_Z, new JValue (native_p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRoleWriteAccess", "(Ljava/lang/String;Z)V"), new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_setWriteAccess_Lcom_parse_ParseUser_Z;
#pragma warning disable 0169
		static Delegate GetSetWriteAccess_Lcom_parse_ParseUser_ZHandler ()
		{
			if (cb_setWriteAccess_Lcom_parse_ParseUser_Z == null)
				cb_setWriteAccess_Lcom_parse_ParseUser_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_SetWriteAccess_Lcom_parse_ParseUser_Z);
			return cb_setWriteAccess_Lcom_parse_ParseUser_Z;
		}

		static void n_SetWriteAccess_Lcom_parse_ParseUser_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Parse.ParseACL __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseACL> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Parse.ParseUser p0 = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseUser> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetWriteAccess (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setWriteAccess_Lcom_parse_ParseUser_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseACL']/method[@name='setWriteAccess' and count(parameter)=2 and parameter[1][@type='com.parse.ParseUser'] and parameter[2][@type='boolean']]"
		[Register ("setWriteAccess", "(Lcom/parse/ParseUser;Z)V", "GetSetWriteAccess_Lcom_parse_ParseUser_ZHandler")]
		public virtual void SetWriteAccess (global::Com.Parse.ParseUser p0, bool p1)
		{
			if (id_setWriteAccess_Lcom_parse_ParseUser_Z == IntPtr.Zero)
				id_setWriteAccess_Lcom_parse_ParseUser_Z = JNIEnv.GetMethodID (class_ref, "setWriteAccess", "(Lcom/parse/ParseUser;Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setWriteAccess_Lcom_parse_ParseUser_Z, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setWriteAccess", "(Lcom/parse/ParseUser;Z)V"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_setWriteAccess_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetSetWriteAccess_Ljava_lang_String_ZHandler ()
		{
			if (cb_setWriteAccess_Ljava_lang_String_Z == null)
				cb_setWriteAccess_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_SetWriteAccess_Ljava_lang_String_Z);
			return cb_setWriteAccess_Ljava_lang_String_Z;
		}

		static void n_SetWriteAccess_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Parse.ParseACL __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseACL> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetWriteAccess (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setWriteAccess_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseACL']/method[@name='setWriteAccess' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("setWriteAccess", "(Ljava/lang/String;Z)V", "GetSetWriteAccess_Ljava_lang_String_ZHandler")]
		public virtual void SetWriteAccess (string p0, bool p1)
		{
			if (id_setWriteAccess_Ljava_lang_String_Z == IntPtr.Zero)
				id_setWriteAccess_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "setWriteAccess", "(Ljava/lang/String;Z)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setWriteAccess_Ljava_lang_String_Z, new JValue (native_p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setWriteAccess", "(Ljava/lang/String;Z)V"), new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}
}
