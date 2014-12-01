using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Parse {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.parse']/class[@name='ParseUser']"
	[global::Android.Runtime.Register ("com/parse/ParseUser", DoNotGenerateAcw=true)]
	public partial class ParseUser : global::Com.Parse.ParseObject {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/parse/ParseUser", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ParseUser); }
		}

		protected ParseUser (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.parse']/class[@name='ParseUser']/constructor[@name='ParseUser' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public ParseUser () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ParseUser)) {
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

		static IntPtr id_getCurrentUser;
		public static global::Com.Parse.ParseUser CurrentUser {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseUser']/method[@name='getCurrentUser' and count(parameter)=0]"
			[Register ("getCurrentUser", "()Lcom/parse/ParseUser;", "GetGetCurrentUserHandler")]
			get {
				if (id_getCurrentUser == IntPtr.Zero)
					id_getCurrentUser = JNIEnv.GetStaticMethodID (class_ref, "getCurrentUser", "()Lcom/parse/ParseUser;");
				return global::Java.Lang.Object.GetObject<global::Com.Parse.ParseUser> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getCurrentUser), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getEmail;
#pragma warning disable 0169
		static Delegate GetGetEmailHandler ()
		{
			if (cb_getEmail == null)
				cb_getEmail = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEmail);
			return cb_getEmail;
		}

		static IntPtr n_GetEmail (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.ParseUser __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Email);
		}
#pragma warning restore 0169

		static Delegate cb_setEmail_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetEmail_Ljava_lang_String_Handler ()
		{
			if (cb_setEmail_Ljava_lang_String_ == null)
				cb_setEmail_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetEmail_Ljava_lang_String_);
			return cb_setEmail_Ljava_lang_String_;
		}

		static void n_SetEmail_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.ParseUser __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Email = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getEmail;
		static IntPtr id_setEmail_Ljava_lang_String_;
		public virtual string Email {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseUser']/method[@name='getEmail' and count(parameter)=0]"
			[Register ("getEmail", "()Ljava/lang/String;", "GetGetEmailHandler")]
			get {
				if (id_getEmail == IntPtr.Zero)
					id_getEmail = JNIEnv.GetMethodID (class_ref, "getEmail", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getEmail), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEmail", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseUser']/method[@name='setEmail' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setEmail", "(Ljava/lang/String;)V", "GetSetEmail_Ljava_lang_String_Handler")]
			set {
				if (id_setEmail_Ljava_lang_String_ == IntPtr.Zero)
					id_setEmail_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setEmail", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setEmail_Ljava_lang_String_, new JValue (native_value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setEmail", "(Ljava/lang/String;)V"), new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_isAuthenticated;
#pragma warning disable 0169
		static Delegate GetIsAuthenticatedHandler ()
		{
			if (cb_isAuthenticated == null)
				cb_isAuthenticated = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsAuthenticated);
			return cb_isAuthenticated;
		}

		static bool n_IsAuthenticated (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.ParseUser __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsAuthenticated;
		}
#pragma warning restore 0169

		static IntPtr id_isAuthenticated;
		public virtual bool IsAuthenticated {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseUser']/method[@name='isAuthenticated' and count(parameter)=0]"
			[Register ("isAuthenticated", "()Z", "GetIsAuthenticatedHandler")]
			get {
				if (id_isAuthenticated == IntPtr.Zero)
					id_isAuthenticated = JNIEnv.GetMethodID (class_ref, "isAuthenticated", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isAuthenticated);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isAuthenticated", "()Z"));
			}
		}

		static Delegate cb_isNew;
#pragma warning disable 0169
		static Delegate GetIsNewHandler ()
		{
			if (cb_isNew == null)
				cb_isNew = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsNew);
			return cb_isNew;
		}

		static bool n_IsNew (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.ParseUser __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsNew;
		}
#pragma warning restore 0169

		static IntPtr id_isNew;
		public virtual bool IsNew {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseUser']/method[@name='isNew' and count(parameter)=0]"
			[Register ("isNew", "()Z", "GetIsNewHandler")]
			get {
				if (id_isNew == IntPtr.Zero)
					id_isNew = JNIEnv.GetMethodID (class_ref, "isNew", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isNew);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isNew", "()Z"));
			}
		}

		static IntPtr id_getQuery;
		public static global::Com.Parse.ParseQuery Query {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseUser']/method[@name='getQuery' and count(parameter)=0]"
			[Register ("getQuery", "()Lcom/parse/ParseQuery;", "GetGetQueryHandler")]
			get {
				if (id_getQuery == IntPtr.Zero)
					id_getQuery = JNIEnv.GetStaticMethodID (class_ref, "getQuery", "()Lcom/parse/ParseQuery;");
				return global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getQuery), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getSessionToken;
#pragma warning disable 0169
		static Delegate GetGetSessionTokenHandler ()
		{
			if (cb_getSessionToken == null)
				cb_getSessionToken = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSessionToken);
			return cb_getSessionToken;
		}

		static IntPtr n_GetSessionToken (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.ParseUser __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SessionToken);
		}
#pragma warning restore 0169

		static IntPtr id_getSessionToken;
		public virtual string SessionToken {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseUser']/method[@name='getSessionToken' and count(parameter)=0]"
			[Register ("getSessionToken", "()Ljava/lang/String;", "GetGetSessionTokenHandler")]
			get {
				if (id_getSessionToken == IntPtr.Zero)
					id_getSessionToken = JNIEnv.GetMethodID (class_ref, "getSessionToken", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getSessionToken), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSessionToken", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getUsername;
#pragma warning disable 0169
		static Delegate GetGetUsernameHandler ()
		{
			if (cb_getUsername == null)
				cb_getUsername = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUsername);
			return cb_getUsername;
		}

		static IntPtr n_GetUsername (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.ParseUser __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Username);
		}
#pragma warning restore 0169

		static Delegate cb_setUsername_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetUsername_Ljava_lang_String_Handler ()
		{
			if (cb_setUsername_Ljava_lang_String_ == null)
				cb_setUsername_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetUsername_Ljava_lang_String_);
			return cb_setUsername_Ljava_lang_String_;
		}

		static void n_SetUsername_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.ParseUser __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Username = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getUsername;
		static IntPtr id_setUsername_Ljava_lang_String_;
		public virtual string Username {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseUser']/method[@name='getUsername' and count(parameter)=0]"
			[Register ("getUsername", "()Ljava/lang/String;", "GetGetUsernameHandler")]
			get {
				if (id_getUsername == IntPtr.Zero)
					id_getUsername = JNIEnv.GetMethodID (class_ref, "getUsername", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getUsername), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUsername", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseUser']/method[@name='setUsername' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setUsername", "(Ljava/lang/String;)V", "GetSetUsername_Ljava_lang_String_Handler")]
			set {
				if (id_setUsername_Ljava_lang_String_ == IntPtr.Zero)
					id_setUsername_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setUsername", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setUsername_Ljava_lang_String_, new JValue (native_value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUsername", "(Ljava/lang/String;)V"), new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr id_enableAutomaticUser;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseUser']/method[@name='enableAutomaticUser' and count(parameter)=0]"
		[Register ("enableAutomaticUser", "()V", "")]
		public static void EnableAutomaticUser ()
		{
			if (id_enableAutomaticUser == IntPtr.Zero)
				id_enableAutomaticUser = JNIEnv.GetStaticMethodID (class_ref, "enableAutomaticUser", "()V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_enableAutomaticUser);
		}

		static IntPtr id_logIn_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseUser']/method[@name='logIn' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("logIn", "(Ljava/lang/String;Ljava/lang/String;)Lcom/parse/ParseUser;", "")]
		public static global::Com.Parse.ParseUser LogIn (string p0, string p1)
		{
			if (id_logIn_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_logIn_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "logIn", "(Ljava/lang/String;Ljava/lang/String;)Lcom/parse/ParseUser;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			global::Com.Parse.ParseUser __ret = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseUser> (JNIEnv.CallStaticObjectMethod  (class_ref, id_logIn_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static IntPtr id_logInInBackground_Ljava_lang_String_Ljava_lang_String_Lcom_parse_LogInCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseUser']/method[@name='logInInBackground' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.parse.LogInCallback']]"
		[Register ("logInInBackground", "(Ljava/lang/String;Ljava/lang/String;Lcom/parse/LogInCallback;)V", "")]
		public static void LogInInBackground (string p0, string p1, global::Com.Parse.LogInCallback p2)
		{
			if (id_logInInBackground_Ljava_lang_String_Ljava_lang_String_Lcom_parse_LogInCallback_ == IntPtr.Zero)
				id_logInInBackground_Ljava_lang_String_Ljava_lang_String_Lcom_parse_LogInCallback_ = JNIEnv.GetStaticMethodID (class_ref, "logInInBackground", "(Ljava/lang/String;Ljava/lang/String;Lcom/parse/LogInCallback;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_logInInBackground_Ljava_lang_String_Ljava_lang_String_Lcom_parse_LogInCallback_, new JValue (native_p0), new JValue (native_p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_logOut;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseUser']/method[@name='logOut' and count(parameter)=0]"
		[Register ("logOut", "()V", "")]
		public static void LogOut ()
		{
			if (id_logOut == IntPtr.Zero)
				id_logOut = JNIEnv.GetStaticMethodID (class_ref, "logOut", "()V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_logOut);
		}

		static IntPtr id_requestPasswordReset_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseUser']/method[@name='requestPasswordReset' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("requestPasswordReset", "(Ljava/lang/String;)V", "")]
		public static void RequestPasswordReset (string p0)
		{
			if (id_requestPasswordReset_Ljava_lang_String_ == IntPtr.Zero)
				id_requestPasswordReset_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "requestPasswordReset", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_requestPasswordReset_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_requestPasswordResetInBackground_Ljava_lang_String_Lcom_parse_RequestPasswordResetCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseUser']/method[@name='requestPasswordResetInBackground' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.parse.RequestPasswordResetCallback']]"
		[Register ("requestPasswordResetInBackground", "(Ljava/lang/String;Lcom/parse/RequestPasswordResetCallback;)V", "")]
		public static void RequestPasswordResetInBackground (string p0, global::Com.Parse.RequestPasswordResetCallback p1)
		{
			if (id_requestPasswordResetInBackground_Ljava_lang_String_Lcom_parse_RequestPasswordResetCallback_ == IntPtr.Zero)
				id_requestPasswordResetInBackground_Ljava_lang_String_Lcom_parse_RequestPasswordResetCallback_ = JNIEnv.GetStaticMethodID (class_ref, "requestPasswordResetInBackground", "(Ljava/lang/String;Lcom/parse/RequestPasswordResetCallback;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_requestPasswordResetInBackground_Ljava_lang_String_Lcom_parse_RequestPasswordResetCallback_, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_setPassword_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetPassword_Ljava_lang_String_Handler ()
		{
			if (cb_setPassword_Ljava_lang_String_ == null)
				cb_setPassword_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPassword_Ljava_lang_String_);
			return cb_setPassword_Ljava_lang_String_;
		}

		static void n_SetPassword_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.ParseUser __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetPassword (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setPassword_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseUser']/method[@name='setPassword' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setPassword", "(Ljava/lang/String;)V", "GetSetPassword_Ljava_lang_String_Handler")]
		public virtual void SetPassword (string p0)
		{
			if (id_setPassword_Ljava_lang_String_ == IntPtr.Zero)
				id_setPassword_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setPassword", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setPassword_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPassword", "(Ljava/lang/String;)V"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_signUp;
#pragma warning disable 0169
		static Delegate GetSignUpHandler ()
		{
			if (cb_signUp == null)
				cb_signUp = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SignUp);
			return cb_signUp;
		}

		static void n_SignUp (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.ParseUser __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SignUp ();
		}
#pragma warning restore 0169

		static IntPtr id_signUp;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseUser']/method[@name='signUp' and count(parameter)=0]"
		[Register ("signUp", "()V", "GetSignUpHandler")]
		public virtual void SignUp ()
		{
			if (id_signUp == IntPtr.Zero)
				id_signUp = JNIEnv.GetMethodID (class_ref, "signUp", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_signUp);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "signUp", "()V"));
		}

		static Delegate cb_signUpInBackground_Lcom_parse_SignUpCallback_;
#pragma warning disable 0169
		static Delegate GetSignUpInBackground_Lcom_parse_SignUpCallback_Handler ()
		{
			if (cb_signUpInBackground_Lcom_parse_SignUpCallback_ == null)
				cb_signUpInBackground_Lcom_parse_SignUpCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SignUpInBackground_Lcom_parse_SignUpCallback_);
			return cb_signUpInBackground_Lcom_parse_SignUpCallback_;
		}

		static void n_SignUpInBackground_Lcom_parse_SignUpCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.ParseUser __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Parse.SignUpCallback p0 = global::Java.Lang.Object.GetObject<global::Com.Parse.SignUpCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SignUpInBackground (p0);
		}
#pragma warning restore 0169

		static IntPtr id_signUpInBackground_Lcom_parse_SignUpCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseUser']/method[@name='signUpInBackground' and count(parameter)=1 and parameter[1][@type='com.parse.SignUpCallback']]"
		[Register ("signUpInBackground", "(Lcom/parse/SignUpCallback;)V", "GetSignUpInBackground_Lcom_parse_SignUpCallback_Handler")]
		public virtual void SignUpInBackground (global::Com.Parse.SignUpCallback p0)
		{
			if (id_signUpInBackground_Lcom_parse_SignUpCallback_ == IntPtr.Zero)
				id_signUpInBackground_Lcom_parse_SignUpCallback_ = JNIEnv.GetMethodID (class_ref, "signUpInBackground", "(Lcom/parse/SignUpCallback;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_signUpInBackground_Lcom_parse_SignUpCallback_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "signUpInBackground", "(Lcom/parse/SignUpCallback;)V"), new JValue (p0));
		}

	}
}
