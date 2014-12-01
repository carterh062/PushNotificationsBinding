using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Parse {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.parse']/class[@name='ParseQuery']"
	[global::Android.Runtime.Register ("com/parse/ParseQuery", DoNotGenerateAcw=true)]
	public partial class ParseQuery : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.parse']/class[@name='ParseQuery.CachePolicy']"
		[global::Android.Runtime.Register ("com/parse/ParseQuery$CachePolicy", DoNotGenerateAcw=true)]
		public sealed partial class CachePolicy : global::Java.Lang.Enum {


			static IntPtr CACHE_ELSE_NETWORK_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='ParseQuery.CachePolicy']/field[@name='CACHE_ELSE_NETWORK']"
			[Register ("CACHE_ELSE_NETWORK")]
			public static global::Com.Parse.ParseQuery.CachePolicy CacheElseNetwork {
				get {
					if (CACHE_ELSE_NETWORK_jfieldId == IntPtr.Zero)
						CACHE_ELSE_NETWORK_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CACHE_ELSE_NETWORK", "Lcom/parse/ParseQuery$CachePolicy;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CACHE_ELSE_NETWORK_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery.CachePolicy> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (CACHE_ELSE_NETWORK_jfieldId == IntPtr.Zero)
						CACHE_ELSE_NETWORK_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CACHE_ELSE_NETWORK", "Lcom/parse/ParseQuery$CachePolicy;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, CACHE_ELSE_NETWORK_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr CACHE_ONLY_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='ParseQuery.CachePolicy']/field[@name='CACHE_ONLY']"
			[Register ("CACHE_ONLY")]
			public static global::Com.Parse.ParseQuery.CachePolicy CacheOnly {
				get {
					if (CACHE_ONLY_jfieldId == IntPtr.Zero)
						CACHE_ONLY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CACHE_ONLY", "Lcom/parse/ParseQuery$CachePolicy;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CACHE_ONLY_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery.CachePolicy> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (CACHE_ONLY_jfieldId == IntPtr.Zero)
						CACHE_ONLY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CACHE_ONLY", "Lcom/parse/ParseQuery$CachePolicy;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, CACHE_ONLY_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr CACHE_THEN_NETWORK_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='ParseQuery.CachePolicy']/field[@name='CACHE_THEN_NETWORK']"
			[Register ("CACHE_THEN_NETWORK")]
			public static global::Com.Parse.ParseQuery.CachePolicy CacheThenNetwork {
				get {
					if (CACHE_THEN_NETWORK_jfieldId == IntPtr.Zero)
						CACHE_THEN_NETWORK_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CACHE_THEN_NETWORK", "Lcom/parse/ParseQuery$CachePolicy;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CACHE_THEN_NETWORK_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery.CachePolicy> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (CACHE_THEN_NETWORK_jfieldId == IntPtr.Zero)
						CACHE_THEN_NETWORK_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CACHE_THEN_NETWORK", "Lcom/parse/ParseQuery$CachePolicy;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, CACHE_THEN_NETWORK_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr IGNORE_CACHE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='ParseQuery.CachePolicy']/field[@name='IGNORE_CACHE']"
			[Register ("IGNORE_CACHE")]
			public static global::Com.Parse.ParseQuery.CachePolicy IgnoreCache {
				get {
					if (IGNORE_CACHE_jfieldId == IntPtr.Zero)
						IGNORE_CACHE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IGNORE_CACHE", "Lcom/parse/ParseQuery$CachePolicy;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, IGNORE_CACHE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery.CachePolicy> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (IGNORE_CACHE_jfieldId == IntPtr.Zero)
						IGNORE_CACHE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IGNORE_CACHE", "Lcom/parse/ParseQuery$CachePolicy;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, IGNORE_CACHE_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr NETWORK_ELSE_CACHE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='ParseQuery.CachePolicy']/field[@name='NETWORK_ELSE_CACHE']"
			[Register ("NETWORK_ELSE_CACHE")]
			public static global::Com.Parse.ParseQuery.CachePolicy NetworkElseCache {
				get {
					if (NETWORK_ELSE_CACHE_jfieldId == IntPtr.Zero)
						NETWORK_ELSE_CACHE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NETWORK_ELSE_CACHE", "Lcom/parse/ParseQuery$CachePolicy;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NETWORK_ELSE_CACHE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery.CachePolicy> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (NETWORK_ELSE_CACHE_jfieldId == IntPtr.Zero)
						NETWORK_ELSE_CACHE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NETWORK_ELSE_CACHE", "Lcom/parse/ParseQuery$CachePolicy;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, NETWORK_ELSE_CACHE_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr NETWORK_ONLY_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='ParseQuery.CachePolicy']/field[@name='NETWORK_ONLY']"
			[Register ("NETWORK_ONLY")]
			public static global::Com.Parse.ParseQuery.CachePolicy NetworkOnly {
				get {
					if (NETWORK_ONLY_jfieldId == IntPtr.Zero)
						NETWORK_ONLY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NETWORK_ONLY", "Lcom/parse/ParseQuery$CachePolicy;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NETWORK_ONLY_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery.CachePolicy> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (NETWORK_ONLY_jfieldId == IntPtr.Zero)
						NETWORK_ONLY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NETWORK_ONLY", "Lcom/parse/ParseQuery$CachePolicy;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, NETWORK_ONLY_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/parse/ParseQuery$CachePolicy", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (CachePolicy); }
			}

			internal CachePolicy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseQuery.CachePolicy']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/parse/ParseQuery$CachePolicy;", "")]
			public static global::Com.Parse.ParseQuery.CachePolicy ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/parse/ParseQuery$CachePolicy;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				global::Com.Parse.ParseQuery.CachePolicy __ret = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery.CachePolicy> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseQuery.CachePolicy']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/parse/ParseQuery$CachePolicy;", "")]
			public static global::Com.Parse.ParseQuery.CachePolicy[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/parse/ParseQuery$CachePolicy;");
				return (global::Com.Parse.ParseQuery.CachePolicy[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Parse.ParseQuery.CachePolicy));
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.parse']/interface[@name='ParseQuery.CallableWithCachePolicy']"
		[Register ("com/parse/ParseQuery$CallableWithCachePolicy", "", "Com.Parse.ParseQuery/ICallableWithCachePolicyInvoker")]
		public partial interface ICallableWithCachePolicy : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/interface[@name='ParseQuery.CallableWithCachePolicy']/method[@name='call' and count(parameter)=1 and parameter[1][@type='com.parse.ParseQuery.CachePolicy']]"
			[Register ("call", "(Lcom/parse/ParseQuery$CachePolicy;)Ljava/lang/Object;", "GetCall_Lcom_parse_ParseQuery_CachePolicy_Handler:Com.Parse.ParseQuery/ICallableWithCachePolicyInvoker, ParseNotificationsDroidBinding")]
			global::Java.Lang.Object Call (global::Com.Parse.ParseQuery.CachePolicy p0);

		}

		[global::Android.Runtime.Register ("com/parse/ParseQuery$CallableWithCachePolicy", DoNotGenerateAcw=true)]
		internal class ICallableWithCachePolicyInvoker : global::Java.Lang.Object, ICallableWithCachePolicy {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/parse/ParseQuery$CallableWithCachePolicy");
			IntPtr class_ref;

			public static ICallableWithCachePolicy GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ICallableWithCachePolicy> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.parse.ParseQuery.CallableWithCachePolicy"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ICallableWithCachePolicyInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (ICallableWithCachePolicyInvoker); }
			}

			static Delegate cb_call_Lcom_parse_ParseQuery_CachePolicy_;
#pragma warning disable 0169
			static Delegate GetCall_Lcom_parse_ParseQuery_CachePolicy_Handler ()
			{
				if (cb_call_Lcom_parse_ParseQuery_CachePolicy_ == null)
					cb_call_Lcom_parse_ParseQuery_CachePolicy_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Call_Lcom_parse_ParseQuery_CachePolicy_);
				return cb_call_Lcom_parse_ParseQuery_CachePolicy_;
			}

			static IntPtr n_Call_Lcom_parse_ParseQuery_CachePolicy_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Parse.ParseQuery.ICallableWithCachePolicy __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery.ICallableWithCachePolicy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Parse.ParseQuery.CachePolicy p0 = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery.CachePolicy> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Call (p0));
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_call_Lcom_parse_ParseQuery_CachePolicy_;
			public global::Java.Lang.Object Call (global::Com.Parse.ParseQuery.CachePolicy p0)
			{
				if (id_call_Lcom_parse_ParseQuery_CachePolicy_ == IntPtr.Zero)
					id_call_Lcom_parse_ParseQuery_CachePolicy_ = JNIEnv.GetMethodID (class_ref, "call", "(Lcom/parse/ParseQuery$CachePolicy;)Ljava/lang/Object;");
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (Handle, id_call_Lcom_parse_ParseQuery_CachePolicy_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.parse']/interface[@name='ParseQuery.CommandDelegate']"
		[Register ("com/parse/ParseQuery$CommandDelegate", "", "Com.Parse.ParseQuery/ICommandDelegateInvoker")]
		public partial interface ICommandDelegate : IJavaObject {

		}

		[global::Android.Runtime.Register ("com/parse/ParseQuery$CommandDelegate", DoNotGenerateAcw=true)]
		internal class ICommandDelegateInvoker : global::Java.Lang.Object, ICommandDelegate {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/parse/ParseQuery$CommandDelegate");
			IntPtr class_ref;

			public static ICommandDelegate GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ICommandDelegate> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.parse.ParseQuery.CommandDelegate"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ICommandDelegateInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (ICommandDelegateInvoker); }
			}

		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/parse/ParseQuery", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ParseQuery); }
		}

		protected ParseQuery (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_Class_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.parse']/class[@name='ParseQuery']/constructor[@name='ParseQuery' and count(parameter)=1 and parameter[1][@type='java.lang.Class']]"
		[Register (".ctor", "(Ljava/lang/Class;)V", "")]
		public ParseQuery (global::Java.Lang.Class p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ParseQuery)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/Class;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/Class;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Ljava_lang_Class_ == IntPtr.Zero)
				id_ctor_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/Class;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_Class_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_Class_, new JValue (p0));
		}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.parse']/class[@name='ParseQuery']/constructor[@name='ParseQuery' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public ParseQuery (string p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);;
			if (GetType () != typeof (ParseQuery)) {
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
			global::Com.Parse.ParseQuery __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ClassName);
		}
#pragma warning restore 0169

		static IntPtr id_getClassName;
		public virtual string ClassName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseQuery']/method[@name='getClassName' and count(parameter)=0]"
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

		static Delegate cb_getFirst;
#pragma warning disable 0169
		static Delegate GetGetFirstHandler ()
		{
			if (cb_getFirst == null)
				cb_getFirst = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFirst);
			return cb_getFirst;
		}

		static IntPtr n_GetFirst (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.ParseQuery __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.First);
		}
#pragma warning restore 0169

		static IntPtr id_getFirst;
		public virtual global::Java.Lang.Object First {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseQuery']/method[@name='getFirst' and count(parameter)=0]"
			[Register ("getFirst", "()Lcom/parse/ParseObject;", "GetGetFirstHandler")]
			get {
				if (id_getFirst == IntPtr.Zero)
					id_getFirst = JNIEnv.GetMethodID (class_ref, "getFirst", "()Lcom/parse/ParseObject;");

				if (GetType () == ThresholdType)
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_getFirst), JniHandleOwnership.TransferLocalRef);
				else
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFirst", "()Lcom/parse/ParseObject;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_hasCachedResult;
#pragma warning disable 0169
		static Delegate GetHasCachedResultHandler ()
		{
			if (cb_hasCachedResult == null)
				cb_hasCachedResult = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasCachedResult);
			return cb_hasCachedResult;
		}

		static bool n_HasCachedResult (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.ParseQuery __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasCachedResult;
		}
#pragma warning restore 0169

		static IntPtr id_hasCachedResult;
		public virtual bool HasCachedResult {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseQuery']/method[@name='hasCachedResult' and count(parameter)=0]"
			[Register ("hasCachedResult", "()Z", "GetHasCachedResultHandler")]
			get {
				if (id_hasCachedResult == IntPtr.Zero)
					id_hasCachedResult = JNIEnv.GetMethodID (class_ref, "hasCachedResult", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_hasCachedResult);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hasCachedResult", "()Z"));
			}
		}

		static Delegate cb_getLimit;
#pragma warning disable 0169
		static Delegate GetGetLimitHandler ()
		{
			if (cb_getLimit == null)
				cb_getLimit = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetLimit);
			return cb_getLimit;
		}

		static int n_GetLimit (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.ParseQuery __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Limit;
		}
#pragma warning restore 0169

		static Delegate cb_setLimit_I;
#pragma warning disable 0169
		static Delegate GetSetLimit_IHandler ()
		{
			if (cb_setLimit_I == null)
				cb_setLimit_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetLimit_I);
			return cb_setLimit_I;
		}

		static void n_SetLimit_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Parse.ParseQuery __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Limit = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getLimit;
		static IntPtr id_setLimit_I;
		public virtual int Limit {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseQuery']/method[@name='getLimit' and count(parameter)=0]"
			[Register ("getLimit", "()I", "GetGetLimitHandler")]
			get {
				if (id_getLimit == IntPtr.Zero)
					id_getLimit = JNIEnv.GetMethodID (class_ref, "getLimit", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getLimit);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLimit", "()I"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseQuery']/method[@name='setLimit' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setLimit", "(I)V", "GetSetLimit_IHandler")]
			set {
				if (id_setLimit_I == IntPtr.Zero)
					id_setLimit_I = JNIEnv.GetMethodID (class_ref, "setLimit", "(I)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setLimit_I, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLimit", "(I)V"), new JValue (value));
			}
		}

		static Delegate cb_getMaxCacheAge;
#pragma warning disable 0169
		static Delegate GetGetMaxCacheAgeHandler ()
		{
			if (cb_getMaxCacheAge == null)
				cb_getMaxCacheAge = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetMaxCacheAge);
			return cb_getMaxCacheAge;
		}

		static long n_GetMaxCacheAge (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.ParseQuery __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxCacheAge;
		}
#pragma warning restore 0169

		static Delegate cb_setMaxCacheAge_J;
#pragma warning disable 0169
		static Delegate GetSetMaxCacheAge_JHandler ()
		{
			if (cb_setMaxCacheAge_J == null)
				cb_setMaxCacheAge_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetMaxCacheAge_J);
			return cb_setMaxCacheAge_J;
		}

		static void n_SetMaxCacheAge_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Parse.ParseQuery __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MaxCacheAge = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMaxCacheAge;
		static IntPtr id_setMaxCacheAge_J;
		public virtual long MaxCacheAge {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseQuery']/method[@name='getMaxCacheAge' and count(parameter)=0]"
			[Register ("getMaxCacheAge", "()J", "GetGetMaxCacheAgeHandler")]
			get {
				if (id_getMaxCacheAge == IntPtr.Zero)
					id_getMaxCacheAge = JNIEnv.GetMethodID (class_ref, "getMaxCacheAge", "()J");

				if (GetType () == ThresholdType)
					return JNIEnv.CallLongMethod  (Handle, id_getMaxCacheAge);
				else
					return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMaxCacheAge", "()J"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseQuery']/method[@name='setMaxCacheAge' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setMaxCacheAge", "(J)V", "GetSetMaxCacheAge_JHandler")]
			set {
				if (id_setMaxCacheAge_J == IntPtr.Zero)
					id_setMaxCacheAge_J = JNIEnv.GetMethodID (class_ref, "setMaxCacheAge", "(J)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setMaxCacheAge_J, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMaxCacheAge", "(J)V"), new JValue (value));
			}
		}

		static Delegate cb_getSkip;
#pragma warning disable 0169
		static Delegate GetGetSkipHandler ()
		{
			if (cb_getSkip == null)
				cb_getSkip = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSkip);
			return cb_getSkip;
		}

		static int n_GetSkip (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.ParseQuery __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Skip;
		}
#pragma warning restore 0169

		static Delegate cb_setSkip_I;
#pragma warning disable 0169
		static Delegate GetSetSkip_IHandler ()
		{
			if (cb_setSkip_I == null)
				cb_setSkip_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetSkip_I);
			return cb_setSkip_I;
		}

		static void n_SetSkip_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Parse.ParseQuery __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Skip = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getSkip;
		static IntPtr id_setSkip_I;
		public virtual int Skip {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseQuery']/method[@name='getSkip' and count(parameter)=0]"
			[Register ("getSkip", "()I", "GetGetSkipHandler")]
			get {
				if (id_getSkip == IntPtr.Zero)
					id_getSkip = JNIEnv.GetMethodID (class_ref, "getSkip", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getSkip);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSkip", "()I"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseQuery']/method[@name='setSkip' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setSkip", "(I)V", "GetSetSkip_IHandler")]
			set {
				if (id_setSkip_I == IntPtr.Zero)
					id_setSkip_I = JNIEnv.GetMethodID (class_ref, "setSkip", "(I)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setSkip_I, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSkip", "(I)V"), new JValue (value));
			}
		}

		static IntPtr id_getUserQuery;
		[Obsolete (@"deprecated")]
		public static global::Com.Parse.ParseQuery UserQuery {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseQuery']/method[@name='getUserQuery' and count(parameter)=0]"
			[Register ("getUserQuery", "()Lcom/parse/ParseQuery;", "GetGetUserQueryHandler")]
			get {
				if (id_getUserQuery == IntPtr.Zero)
					id_getUserQuery = JNIEnv.GetStaticMethodID (class_ref, "getUserQuery", "()Lcom/parse/ParseQuery;");
				return global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getUserQuery), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_addAscendingOrder_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddAscendingOrder_Ljava_lang_String_Handler ()
		{
			if (cb_addAscendingOrder_Ljava_lang_String_ == null)
				cb_addAscendingOrder_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddAscendingOrder_Ljava_lang_String_);
			return cb_addAscendingOrder_Ljava_lang_String_;
		}

		static IntPtr n_AddAscendingOrder_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.ParseQuery __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddAscendingOrder (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addAscendingOrder_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseQuery']/method[@name='addAscendingOrder' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("addAscendingOrder", "(Ljava/lang/String;)Lcom/parse/ParseQuery;", "GetAddAscendingOrder_Ljava_lang_String_Handler")]
		public virtual global::Com.Parse.ParseQuery AddAscendingOrder (string p0)
		{
			if (id_addAscendingOrder_Ljava_lang_String_ == IntPtr.Zero)
				id_addAscendingOrder_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addAscendingOrder", "(Ljava/lang/String;)Lcom/parse/ParseQuery;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Com.Parse.ParseQuery __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (JNIEnv.CallObjectMethod  (Handle, id_addAscendingOrder_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addAscendingOrder", "(Ljava/lang/String;)Lcom/parse/ParseQuery;"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_addDescendingOrder_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddDescendingOrder_Ljava_lang_String_Handler ()
		{
			if (cb_addDescendingOrder_Ljava_lang_String_ == null)
				cb_addDescendingOrder_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddDescendingOrder_Ljava_lang_String_);
			return cb_addDescendingOrder_Ljava_lang_String_;
		}

		static IntPtr n_AddDescendingOrder_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.ParseQuery __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddDescendingOrder (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addDescendingOrder_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseQuery']/method[@name='addDescendingOrder' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("addDescendingOrder", "(Ljava/lang/String;)Lcom/parse/ParseQuery;", "GetAddDescendingOrder_Ljava_lang_String_Handler")]
		public virtual global::Com.Parse.ParseQuery AddDescendingOrder (string p0)
		{
			if (id_addDescendingOrder_Ljava_lang_String_ == IntPtr.Zero)
				id_addDescendingOrder_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addDescendingOrder", "(Ljava/lang/String;)Lcom/parse/ParseQuery;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Com.Parse.ParseQuery __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (JNIEnv.CallObjectMethod  (Handle, id_addDescendingOrder_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addDescendingOrder", "(Ljava/lang/String;)Lcom/parse/ParseQuery;"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
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
			global::Com.Parse.ParseQuery __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Cancel ();
		}
#pragma warning restore 0169

		static IntPtr id_cancel;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseQuery']/method[@name='cancel' and count(parameter)=0]"
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

		static IntPtr id_clearAllCachedResults;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseQuery']/method[@name='clearAllCachedResults' and count(parameter)=0]"
		[Register ("clearAllCachedResults", "()V", "")]
		public static void ClearAllCachedResults ()
		{
			if (id_clearAllCachedResults == IntPtr.Zero)
				id_clearAllCachedResults = JNIEnv.GetStaticMethodID (class_ref, "clearAllCachedResults", "()V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_clearAllCachedResults);
		}

		static Delegate cb_clearCachedResult;
#pragma warning disable 0169
		static Delegate GetClearCachedResultHandler ()
		{
			if (cb_clearCachedResult == null)
				cb_clearCachedResult = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ClearCachedResult);
			return cb_clearCachedResult;
		}

		static void n_ClearCachedResult (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.ParseQuery __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearCachedResult ();
		}
#pragma warning restore 0169

		static IntPtr id_clearCachedResult;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseQuery']/method[@name='clearCachedResult' and count(parameter)=0]"
		[Register ("clearCachedResult", "()V", "GetClearCachedResultHandler")]
		public virtual void ClearCachedResult ()
		{
			if (id_clearCachedResult == IntPtr.Zero)
				id_clearCachedResult = JNIEnv.GetMethodID (class_ref, "clearCachedResult", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_clearCachedResult);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clearCachedResult", "()V"));
		}

		static Delegate cb_count;
#pragma warning disable 0169
		static Delegate GetCountHandler ()
		{
			if (cb_count == null)
				cb_count = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Count);
			return cb_count;
		}

		static int n_Count (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.ParseQuery __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Count ();
		}
#pragma warning restore 0169

		static IntPtr id_count;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseQuery']/method[@name='count' and count(parameter)=0]"
		[Register ("count", "()I", "GetCountHandler")]
		public virtual int Count ()
		{
			if (id_count == IntPtr.Zero)
				id_count = JNIEnv.GetMethodID (class_ref, "count", "()I");

			if (GetType () == ThresholdType)
				return JNIEnv.CallIntMethod  (Handle, id_count);
			else
				return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "count", "()I"));
		}

		static Delegate cb_countInBackground_Lcom_parse_CountCallback_;
#pragma warning disable 0169
		static Delegate GetCountInBackground_Lcom_parse_CountCallback_Handler ()
		{
			if (cb_countInBackground_Lcom_parse_CountCallback_ == null)
				cb_countInBackground_Lcom_parse_CountCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_CountInBackground_Lcom_parse_CountCallback_);
			return cb_countInBackground_Lcom_parse_CountCallback_;
		}

		static void n_CountInBackground_Lcom_parse_CountCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.ParseQuery __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Parse.CountCallback p0 = global::Java.Lang.Object.GetObject<global::Com.Parse.CountCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CountInBackground (p0);
		}
#pragma warning restore 0169

		static IntPtr id_countInBackground_Lcom_parse_CountCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseQuery']/method[@name='countInBackground' and count(parameter)=1 and parameter[1][@type='com.parse.CountCallback']]"
		[Register ("countInBackground", "(Lcom/parse/CountCallback;)V", "GetCountInBackground_Lcom_parse_CountCallback_Handler")]
		public virtual void CountInBackground (global::Com.Parse.CountCallback p0)
		{
			if (id_countInBackground_Lcom_parse_CountCallback_ == IntPtr.Zero)
				id_countInBackground_Lcom_parse_CountCallback_ = JNIEnv.GetMethodID (class_ref, "countInBackground", "(Lcom/parse/CountCallback;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_countInBackground_Lcom_parse_CountCallback_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "countInBackground", "(Lcom/parse/CountCallback;)V"), new JValue (p0));
		}

		static Delegate cb_find;
#pragma warning disable 0169
		static Delegate GetFindHandler ()
		{
			if (cb_find == null)
				cb_find = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Find);
			return cb_find;
		}

		static IntPtr n_Find (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.ParseQuery __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList.ToLocalJniHandle (__this.Find ());
		}
#pragma warning restore 0169

		static IntPtr id_find;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseQuery']/method[@name='find' and count(parameter)=0]"
		[Register ("find", "()Ljava/util/List;", "GetFindHandler")]
		public virtual global::System.Collections.IList Find ()
		{
			if (id_find == IntPtr.Zero)
				id_find = JNIEnv.GetMethodID (class_ref, "find", "()Ljava/util/List;");

			if (GetType () == ThresholdType)
				return global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_find), JniHandleOwnership.TransferLocalRef);
			else
				return global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "find", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_findInBackground_Lcom_parse_FindCallback_;
#pragma warning disable 0169
		static Delegate GetFindInBackground_Lcom_parse_FindCallback_Handler ()
		{
			if (cb_findInBackground_Lcom_parse_FindCallback_ == null)
				cb_findInBackground_Lcom_parse_FindCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_FindInBackground_Lcom_parse_FindCallback_);
			return cb_findInBackground_Lcom_parse_FindCallback_;
		}

		static void n_FindInBackground_Lcom_parse_FindCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.ParseQuery __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Parse.FindCallback p0 = global::Java.Lang.Object.GetObject<global::Com.Parse.FindCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.FindInBackground (p0);
		}
#pragma warning restore 0169

		static IntPtr id_findInBackground_Lcom_parse_FindCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseQuery']/method[@name='findInBackground' and count(parameter)=1 and parameter[1][@type='com.parse.FindCallback']]"
		[Register ("findInBackground", "(Lcom/parse/FindCallback;)V", "GetFindInBackground_Lcom_parse_FindCallback_Handler")]
		public virtual void FindInBackground (global::Com.Parse.FindCallback p0)
		{
			if (id_findInBackground_Lcom_parse_FindCallback_ == IntPtr.Zero)
				id_findInBackground_Lcom_parse_FindCallback_ = JNIEnv.GetMethodID (class_ref, "findInBackground", "(Lcom/parse/FindCallback;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_findInBackground_Lcom_parse_FindCallback_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "findInBackground", "(Lcom/parse/FindCallback;)V"), new JValue (p0));
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
			global::Com.Parse.ParseQuery __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Get (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_get_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseQuery']/method[@name='get' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("get", "(Ljava/lang/String;)Lcom/parse/ParseObject;", "GetGet_Ljava_lang_String_Handler")]
		public virtual global::Java.Lang.Object Get (string p0)
		{
			if (id_get_Ljava_lang_String_ == IntPtr.Zero)
				id_get_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "get", "(Ljava/lang/String;)Lcom/parse/ParseObject;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Java.Lang.Object __ret;
			if (GetType () == ThresholdType)
				__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_get_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get", "(Ljava/lang/String;)Lcom/parse/ParseObject;"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getCachePolicy;
#pragma warning disable 0169
		static Delegate GetGetCachePolicyHandler ()
		{
			if (cb_getCachePolicy == null)
				cb_getCachePolicy = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCachePolicy);
			return cb_getCachePolicy;
		}

		static IntPtr n_GetCachePolicy (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.ParseQuery __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetCachePolicy ());
		}
#pragma warning restore 0169

		static IntPtr id_getCachePolicy;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseQuery']/method[@name='getCachePolicy' and count(parameter)=0]"
		[Register ("getCachePolicy", "()Lcom/parse/ParseQuery$CachePolicy;", "GetGetCachePolicyHandler")]
		public virtual global::Com.Parse.ParseQuery.CachePolicy GetCachePolicy ()
		{
			if (id_getCachePolicy == IntPtr.Zero)
				id_getCachePolicy = JNIEnv.GetMethodID (class_ref, "getCachePolicy", "()Lcom/parse/ParseQuery$CachePolicy;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery.CachePolicy> (JNIEnv.CallObjectMethod  (Handle, id_getCachePolicy), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery.CachePolicy> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCachePolicy", "()Lcom/parse/ParseQuery$CachePolicy;")), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_getFirstInBackground_Lcom_parse_GetCallback_;
#pragma warning disable 0169
		static Delegate GetGetFirstInBackground_Lcom_parse_GetCallback_Handler ()
		{
			if (cb_getFirstInBackground_Lcom_parse_GetCallback_ == null)
				cb_getFirstInBackground_Lcom_parse_GetCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_GetFirstInBackground_Lcom_parse_GetCallback_);
			return cb_getFirstInBackground_Lcom_parse_GetCallback_;
		}

		static void n_GetFirstInBackground_Lcom_parse_GetCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.ParseQuery __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Parse.GetCallback p0 = global::Java.Lang.Object.GetObject<global::Com.Parse.GetCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.GetFirstInBackground (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getFirstInBackground_Lcom_parse_GetCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseQuery']/method[@name='getFirstInBackground' and count(parameter)=1 and parameter[1][@type='com.parse.GetCallback']]"
		[Register ("getFirstInBackground", "(Lcom/parse/GetCallback;)V", "GetGetFirstInBackground_Lcom_parse_GetCallback_Handler")]
		public virtual void GetFirstInBackground (global::Com.Parse.GetCallback p0)
		{
			if (id_getFirstInBackground_Lcom_parse_GetCallback_ == IntPtr.Zero)
				id_getFirstInBackground_Lcom_parse_GetCallback_ = JNIEnv.GetMethodID (class_ref, "getFirstInBackground", "(Lcom/parse/GetCallback;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_getFirstInBackground_Lcom_parse_GetCallback_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFirstInBackground", "(Lcom/parse/GetCallback;)V"), new JValue (p0));
		}

		static Delegate cb_getInBackground_Ljava_lang_String_Lcom_parse_GetCallback_;
#pragma warning disable 0169
		static Delegate GetGetInBackground_Ljava_lang_String_Lcom_parse_GetCallback_Handler ()
		{
			if (cb_getInBackground_Ljava_lang_String_Lcom_parse_GetCallback_ == null)
				cb_getInBackground_Ljava_lang_String_Lcom_parse_GetCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetInBackground_Ljava_lang_String_Lcom_parse_GetCallback_);
			return cb_getInBackground_Ljava_lang_String_Lcom_parse_GetCallback_;
		}

		static void n_GetInBackground_Ljava_lang_String_Lcom_parse_GetCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Parse.ParseQuery __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Parse.GetCallback p1 = global::Java.Lang.Object.GetObject<global::Com.Parse.GetCallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.GetInBackground (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_getInBackground_Ljava_lang_String_Lcom_parse_GetCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseQuery']/method[@name='getInBackground' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.parse.GetCallback']]"
		[Register ("getInBackground", "(Ljava/lang/String;Lcom/parse/GetCallback;)V", "GetGetInBackground_Ljava_lang_String_Lcom_parse_GetCallback_Handler")]
		public virtual void GetInBackground (string p0, global::Com.Parse.GetCallback p1)
		{
			if (id_getInBackground_Ljava_lang_String_Lcom_parse_GetCallback_ == IntPtr.Zero)
				id_getInBackground_Ljava_lang_String_Lcom_parse_GetCallback_ = JNIEnv.GetMethodID (class_ref, "getInBackground", "(Ljava/lang/String;Lcom/parse/GetCallback;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_getInBackground_Ljava_lang_String_Lcom_parse_GetCallback_, new JValue (native_p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getInBackground", "(Ljava/lang/String;Lcom/parse/GetCallback;)V"), new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_getQuery_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseQuery']/method[@name='getQuery' and count(parameter)=1 and parameter[1][@type='java.lang.Class']]"
		[Register ("getQuery", "(Ljava/lang/Class;)Lcom/parse/ParseQuery;", "")]
		public static global::Com.Parse.ParseQuery GetQuery (global::Java.Lang.Class p0)
		{
			if (id_getQuery_Ljava_lang_Class_ == IntPtr.Zero)
				id_getQuery_Ljava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "getQuery", "(Ljava/lang/Class;)Lcom/parse/ParseQuery;");
			global::Com.Parse.ParseQuery __ret = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getQuery_Ljava_lang_Class_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_getQuery_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseQuery']/method[@name='getQuery' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getQuery", "(Ljava/lang/String;)Lcom/parse/ParseQuery;", "")]
		public static global::Com.Parse.ParseQuery GetQuery (string p0)
		{
			if (id_getQuery_Ljava_lang_String_ == IntPtr.Zero)
				id_getQuery_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getQuery", "(Ljava/lang/String;)Lcom/parse/ParseQuery;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Com.Parse.ParseQuery __ret = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getQuery_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_include_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetInclude_Ljava_lang_String_Handler ()
		{
			if (cb_include_Ljava_lang_String_ == null)
				cb_include_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Include_Ljava_lang_String_);
			return cb_include_Ljava_lang_String_;
		}

		static void n_Include_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.ParseQuery __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Include (p0);
		}
#pragma warning restore 0169

		static IntPtr id_include_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseQuery']/method[@name='include' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("include", "(Ljava/lang/String;)V", "GetInclude_Ljava_lang_String_Handler")]
		public virtual void Include (string p0)
		{
			if (id_include_Ljava_lang_String_ == IntPtr.Zero)
				id_include_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "include", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_include_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "include", "(Ljava/lang/String;)V"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_or_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseQuery']/method[@name='or' and count(parameter)=1 and parameter[1][@type='java.util.List']]"
		[Register ("or", "(Ljava/util/List;)Lcom/parse/ParseQuery;", "")]
		public static global::Com.Parse.ParseQuery Or (global::System.Collections.IList p0)
		{
			if (id_or_Ljava_util_List_ == IntPtr.Zero)
				id_or_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "or", "(Ljava/util/List;)Lcom/parse/ParseQuery;");
			IntPtr native_p0 = global::Android.Runtime.JavaList.ToLocalJniHandle (p0);
			global::Com.Parse.ParseQuery __ret = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (JNIEnv.CallStaticObjectMethod  (class_ref, id_or_Ljava_util_List_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_orderByAscending_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOrderByAscending_Ljava_lang_String_Handler ()
		{
			if (cb_orderByAscending_Ljava_lang_String_ == null)
				cb_orderByAscending_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_OrderByAscending_Ljava_lang_String_);
			return cb_orderByAscending_Ljava_lang_String_;
		}

		static IntPtr n_OrderByAscending_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.ParseQuery __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OrderByAscending (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_orderByAscending_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseQuery']/method[@name='orderByAscending' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("orderByAscending", "(Ljava/lang/String;)Lcom/parse/ParseQuery;", "GetOrderByAscending_Ljava_lang_String_Handler")]
		public virtual global::Com.Parse.ParseQuery OrderByAscending (string p0)
		{
			if (id_orderByAscending_Ljava_lang_String_ == IntPtr.Zero)
				id_orderByAscending_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "orderByAscending", "(Ljava/lang/String;)Lcom/parse/ParseQuery;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Com.Parse.ParseQuery __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (JNIEnv.CallObjectMethod  (Handle, id_orderByAscending_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "orderByAscending", "(Ljava/lang/String;)Lcom/parse/ParseQuery;"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_orderByDescending_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOrderByDescending_Ljava_lang_String_Handler ()
		{
			if (cb_orderByDescending_Ljava_lang_String_ == null)
				cb_orderByDescending_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_OrderByDescending_Ljava_lang_String_);
			return cb_orderByDescending_Ljava_lang_String_;
		}

		static IntPtr n_OrderByDescending_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.ParseQuery __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OrderByDescending (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_orderByDescending_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseQuery']/method[@name='orderByDescending' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("orderByDescending", "(Ljava/lang/String;)Lcom/parse/ParseQuery;", "GetOrderByDescending_Ljava_lang_String_Handler")]
		public virtual global::Com.Parse.ParseQuery OrderByDescending (string p0)
		{
			if (id_orderByDescending_Ljava_lang_String_ == IntPtr.Zero)
				id_orderByDescending_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "orderByDescending", "(Ljava/lang/String;)Lcom/parse/ParseQuery;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Com.Parse.ParseQuery __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (JNIEnv.CallObjectMethod  (Handle, id_orderByDescending_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "orderByDescending", "(Ljava/lang/String;)Lcom/parse/ParseQuery;"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_selectKeys_Ljava_util_Collection_;
#pragma warning disable 0169
		static Delegate GetSelectKeys_Ljava_util_Collection_Handler ()
		{
			if (cb_selectKeys_Ljava_util_Collection_ == null)
				cb_selectKeys_Ljava_util_Collection_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SelectKeys_Ljava_util_Collection_);
			return cb_selectKeys_Ljava_util_Collection_;
		}

		static void n_SelectKeys_Ljava_util_Collection_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.ParseQuery __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.ICollection<string> p0 = global::Android.Runtime.JavaCollection<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SelectKeys (p0);
		}
#pragma warning restore 0169

		static IntPtr id_selectKeys_Ljava_util_Collection_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseQuery']/method[@name='selectKeys' and count(parameter)=1 and parameter[1][@type='java.util.Collection']]"
		[Register ("selectKeys", "(Ljava/util/Collection;)V", "GetSelectKeys_Ljava_util_Collection_Handler")]
		public virtual void SelectKeys (global::System.Collections.Generic.ICollection<string> p0)
		{
			if (id_selectKeys_Ljava_util_Collection_ == IntPtr.Zero)
				id_selectKeys_Ljava_util_Collection_ = JNIEnv.GetMethodID (class_ref, "selectKeys", "(Ljava/util/Collection;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaCollection<string>.ToLocalJniHandle (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_selectKeys_Ljava_util_Collection_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "selectKeys", "(Ljava/util/Collection;)V"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_setCachePolicy_Lcom_parse_ParseQuery_CachePolicy_;
#pragma warning disable 0169
		static Delegate GetSetCachePolicy_Lcom_parse_ParseQuery_CachePolicy_Handler ()
		{
			if (cb_setCachePolicy_Lcom_parse_ParseQuery_CachePolicy_ == null)
				cb_setCachePolicy_Lcom_parse_ParseQuery_CachePolicy_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCachePolicy_Lcom_parse_ParseQuery_CachePolicy_);
			return cb_setCachePolicy_Lcom_parse_ParseQuery_CachePolicy_;
		}

		static void n_SetCachePolicy_Lcom_parse_ParseQuery_CachePolicy_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.ParseQuery __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Parse.ParseQuery.CachePolicy p0 = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery.CachePolicy> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetCachePolicy (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setCachePolicy_Lcom_parse_ParseQuery_CachePolicy_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseQuery']/method[@name='setCachePolicy' and count(parameter)=1 and parameter[1][@type='com.parse.ParseQuery.CachePolicy']]"
		[Register ("setCachePolicy", "(Lcom/parse/ParseQuery$CachePolicy;)V", "GetSetCachePolicy_Lcom_parse_ParseQuery_CachePolicy_Handler")]
		public virtual void SetCachePolicy (global::Com.Parse.ParseQuery.CachePolicy p0)
		{
			if (id_setCachePolicy_Lcom_parse_ParseQuery_CachePolicy_ == IntPtr.Zero)
				id_setCachePolicy_Lcom_parse_ParseQuery_CachePolicy_ = JNIEnv.GetMethodID (class_ref, "setCachePolicy", "(Lcom/parse/ParseQuery$CachePolicy;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setCachePolicy_Lcom_parse_ParseQuery_CachePolicy_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCachePolicy", "(Lcom/parse/ParseQuery$CachePolicy;)V"), new JValue (p0));
		}

		static Delegate cb_setTrace_Z;
#pragma warning disable 0169
		static Delegate GetSetTrace_ZHandler ()
		{
			if (cb_setTrace_Z == null)
				cb_setTrace_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetTrace_Z);
			return cb_setTrace_Z;
		}

		static void n_SetTrace_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Parse.ParseQuery __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetTrace (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setTrace_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseQuery']/method[@name='setTrace' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setTrace", "(Z)V", "GetSetTrace_ZHandler")]
		public virtual void SetTrace (bool p0)
		{
			if (id_setTrace_Z == IntPtr.Zero)
				id_setTrace_Z = JNIEnv.GetMethodID (class_ref, "setTrace", "(Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setTrace_Z, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTrace", "(Z)V"), new JValue (p0));
		}

		static Delegate cb_whereContainedIn_Ljava_lang_String_Ljava_util_Collection_;
#pragma warning disable 0169
		static Delegate GetWhereContainedIn_Ljava_lang_String_Ljava_util_Collection_Handler ()
		{
			if (cb_whereContainedIn_Ljava_lang_String_Ljava_util_Collection_ == null)
				cb_whereContainedIn_Ljava_lang_String_Ljava_util_Collection_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_WhereContainedIn_Ljava_lang_String_Ljava_util_Collection_);
			return cb_whereContainedIn_Ljava_lang_String_Ljava_util_Collection_;
		}

		static IntPtr n_WhereContainedIn_Ljava_lang_String_Ljava_util_Collection_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Parse.ParseQuery __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			System.Collections.ICollection p1 = global::Android.Runtime.JavaCollection.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WhereContainedIn (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_whereContainedIn_Ljava_lang_String_Ljava_util_Collection_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseQuery']/method[@name='whereContainedIn' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Collection']]"
		[Register ("whereContainedIn", "(Ljava/lang/String;Ljava/util/Collection;)Lcom/parse/ParseQuery;", "GetWhereContainedIn_Ljava_lang_String_Ljava_util_Collection_Handler")]
		public virtual global::Com.Parse.ParseQuery WhereContainedIn (string p0, global::System.Collections.ICollection p1)
		{
			if (id_whereContainedIn_Ljava_lang_String_Ljava_util_Collection_ == IntPtr.Zero)
				id_whereContainedIn_Ljava_lang_String_Ljava_util_Collection_ = JNIEnv.GetMethodID (class_ref, "whereContainedIn", "(Ljava/lang/String;Ljava/util/Collection;)Lcom/parse/ParseQuery;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaCollection.ToLocalJniHandle (p1);

			global::Com.Parse.ParseQuery __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (JNIEnv.CallObjectMethod  (Handle, id_whereContainedIn_Ljava_lang_String_Ljava_util_Collection_, new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "whereContainedIn", "(Ljava/lang/String;Ljava/util/Collection;)Lcom/parse/ParseQuery;"), new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_whereContains_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetWhereContains_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_whereContains_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_whereContains_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_WhereContains_Ljava_lang_String_Ljava_lang_String_);
			return cb_whereContains_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_WhereContains_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Parse.ParseQuery __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WhereContains (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_whereContains_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseQuery']/method[@name='whereContains' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("whereContains", "(Ljava/lang/String;Ljava/lang/String;)Lcom/parse/ParseQuery;", "GetWhereContains_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual global::Com.Parse.ParseQuery WhereContains (string p0, string p1)
		{
			if (id_whereContains_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_whereContains_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "whereContains", "(Ljava/lang/String;Ljava/lang/String;)Lcom/parse/ParseQuery;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);

			global::Com.Parse.ParseQuery __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (JNIEnv.CallObjectMethod  (Handle, id_whereContains_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "whereContains", "(Ljava/lang/String;Ljava/lang/String;)Lcom/parse/ParseQuery;"), new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_whereContainsAll_Ljava_lang_String_Ljava_util_Collection_;
#pragma warning disable 0169
		static Delegate GetWhereContainsAll_Ljava_lang_String_Ljava_util_Collection_Handler ()
		{
			if (cb_whereContainsAll_Ljava_lang_String_Ljava_util_Collection_ == null)
				cb_whereContainsAll_Ljava_lang_String_Ljava_util_Collection_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_WhereContainsAll_Ljava_lang_String_Ljava_util_Collection_);
			return cb_whereContainsAll_Ljava_lang_String_Ljava_util_Collection_;
		}

		static IntPtr n_WhereContainsAll_Ljava_lang_String_Ljava_util_Collection_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Parse.ParseQuery __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			System.Collections.ICollection p1 = global::Android.Runtime.JavaCollection.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WhereContainsAll (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_whereContainsAll_Ljava_lang_String_Ljava_util_Collection_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseQuery']/method[@name='whereContainsAll' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Collection']]"
		[Register ("whereContainsAll", "(Ljava/lang/String;Ljava/util/Collection;)Lcom/parse/ParseQuery;", "GetWhereContainsAll_Ljava_lang_String_Ljava_util_Collection_Handler")]
		public virtual global::Com.Parse.ParseQuery WhereContainsAll (string p0, global::System.Collections.ICollection p1)
		{
			if (id_whereContainsAll_Ljava_lang_String_Ljava_util_Collection_ == IntPtr.Zero)
				id_whereContainsAll_Ljava_lang_String_Ljava_util_Collection_ = JNIEnv.GetMethodID (class_ref, "whereContainsAll", "(Ljava/lang/String;Ljava/util/Collection;)Lcom/parse/ParseQuery;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaCollection.ToLocalJniHandle (p1);

			global::Com.Parse.ParseQuery __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (JNIEnv.CallObjectMethod  (Handle, id_whereContainsAll_Ljava_lang_String_Ljava_util_Collection_, new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "whereContainsAll", "(Ljava/lang/String;Ljava/util/Collection;)Lcom/parse/ParseQuery;"), new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_whereDoesNotExist_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetWhereDoesNotExist_Ljava_lang_String_Handler ()
		{
			if (cb_whereDoesNotExist_Ljava_lang_String_ == null)
				cb_whereDoesNotExist_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WhereDoesNotExist_Ljava_lang_String_);
			return cb_whereDoesNotExist_Ljava_lang_String_;
		}

		static IntPtr n_WhereDoesNotExist_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.ParseQuery __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WhereDoesNotExist (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_whereDoesNotExist_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseQuery']/method[@name='whereDoesNotExist' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("whereDoesNotExist", "(Ljava/lang/String;)Lcom/parse/ParseQuery;", "GetWhereDoesNotExist_Ljava_lang_String_Handler")]
		public virtual global::Com.Parse.ParseQuery WhereDoesNotExist (string p0)
		{
			if (id_whereDoesNotExist_Ljava_lang_String_ == IntPtr.Zero)
				id_whereDoesNotExist_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "whereDoesNotExist", "(Ljava/lang/String;)Lcom/parse/ParseQuery;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Com.Parse.ParseQuery __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (JNIEnv.CallObjectMethod  (Handle, id_whereDoesNotExist_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "whereDoesNotExist", "(Ljava/lang/String;)Lcom/parse/ParseQuery;"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_whereDoesNotMatchKeyInQuery_Ljava_lang_String_Ljava_lang_String_Lcom_parse_ParseQuery_;
#pragma warning disable 0169
		static Delegate GetWhereDoesNotMatchKeyInQuery_Ljava_lang_String_Ljava_lang_String_Lcom_parse_ParseQuery_Handler ()
		{
			if (cb_whereDoesNotMatchKeyInQuery_Ljava_lang_String_Ljava_lang_String_Lcom_parse_ParseQuery_ == null)
				cb_whereDoesNotMatchKeyInQuery_Ljava_lang_String_Ljava_lang_String_Lcom_parse_ParseQuery_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_WhereDoesNotMatchKeyInQuery_Ljava_lang_String_Ljava_lang_String_Lcom_parse_ParseQuery_);
			return cb_whereDoesNotMatchKeyInQuery_Ljava_lang_String_Ljava_lang_String_Lcom_parse_ParseQuery_;
		}

		static IntPtr n_WhereDoesNotMatchKeyInQuery_Ljava_lang_String_Ljava_lang_String_Lcom_parse_ParseQuery_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Parse.ParseQuery __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Parse.ParseQuery p2 = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WhereDoesNotMatchKeyInQuery (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_whereDoesNotMatchKeyInQuery_Ljava_lang_String_Ljava_lang_String_Lcom_parse_ParseQuery_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseQuery']/method[@name='whereDoesNotMatchKeyInQuery' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.parse.ParseQuery']]"
		[Register ("whereDoesNotMatchKeyInQuery", "(Ljava/lang/String;Ljava/lang/String;Lcom/parse/ParseQuery;)Lcom/parse/ParseQuery;", "GetWhereDoesNotMatchKeyInQuery_Ljava_lang_String_Ljava_lang_String_Lcom_parse_ParseQuery_Handler")]
		public virtual global::Com.Parse.ParseQuery WhereDoesNotMatchKeyInQuery (string p0, string p1, global::Com.Parse.ParseQuery p2)
		{
			if (id_whereDoesNotMatchKeyInQuery_Ljava_lang_String_Ljava_lang_String_Lcom_parse_ParseQuery_ == IntPtr.Zero)
				id_whereDoesNotMatchKeyInQuery_Ljava_lang_String_Ljava_lang_String_Lcom_parse_ParseQuery_ = JNIEnv.GetMethodID (class_ref, "whereDoesNotMatchKeyInQuery", "(Ljava/lang/String;Ljava/lang/String;Lcom/parse/ParseQuery;)Lcom/parse/ParseQuery;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);

			global::Com.Parse.ParseQuery __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (JNIEnv.CallObjectMethod  (Handle, id_whereDoesNotMatchKeyInQuery_Ljava_lang_String_Ljava_lang_String_Lcom_parse_ParseQuery_, new JValue (native_p0), new JValue (native_p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "whereDoesNotMatchKeyInQuery", "(Ljava/lang/String;Ljava/lang/String;Lcom/parse/ParseQuery;)Lcom/parse/ParseQuery;"), new JValue (native_p0), new JValue (native_p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_whereDoesNotMatchQuery_Ljava_lang_String_Lcom_parse_ParseQuery_;
#pragma warning disable 0169
		static Delegate GetWhereDoesNotMatchQuery_Ljava_lang_String_Lcom_parse_ParseQuery_Handler ()
		{
			if (cb_whereDoesNotMatchQuery_Ljava_lang_String_Lcom_parse_ParseQuery_ == null)
				cb_whereDoesNotMatchQuery_Ljava_lang_String_Lcom_parse_ParseQuery_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_WhereDoesNotMatchQuery_Ljava_lang_String_Lcom_parse_ParseQuery_);
			return cb_whereDoesNotMatchQuery_Ljava_lang_String_Lcom_parse_ParseQuery_;
		}

		static IntPtr n_WhereDoesNotMatchQuery_Ljava_lang_String_Lcom_parse_ParseQuery_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Parse.ParseQuery __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Parse.ParseQuery p1 = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WhereDoesNotMatchQuery (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_whereDoesNotMatchQuery_Ljava_lang_String_Lcom_parse_ParseQuery_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseQuery']/method[@name='whereDoesNotMatchQuery' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.parse.ParseQuery']]"
		[Register ("whereDoesNotMatchQuery", "(Ljava/lang/String;Lcom/parse/ParseQuery;)Lcom/parse/ParseQuery;", "GetWhereDoesNotMatchQuery_Ljava_lang_String_Lcom_parse_ParseQuery_Handler")]
		public virtual global::Com.Parse.ParseQuery WhereDoesNotMatchQuery (string p0, global::Com.Parse.ParseQuery p1)
		{
			if (id_whereDoesNotMatchQuery_Ljava_lang_String_Lcom_parse_ParseQuery_ == IntPtr.Zero)
				id_whereDoesNotMatchQuery_Ljava_lang_String_Lcom_parse_ParseQuery_ = JNIEnv.GetMethodID (class_ref, "whereDoesNotMatchQuery", "(Ljava/lang/String;Lcom/parse/ParseQuery;)Lcom/parse/ParseQuery;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Com.Parse.ParseQuery __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (JNIEnv.CallObjectMethod  (Handle, id_whereDoesNotMatchQuery_Ljava_lang_String_Lcom_parse_ParseQuery_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "whereDoesNotMatchQuery", "(Ljava/lang/String;Lcom/parse/ParseQuery;)Lcom/parse/ParseQuery;"), new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_whereEndsWith_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetWhereEndsWith_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_whereEndsWith_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_whereEndsWith_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_WhereEndsWith_Ljava_lang_String_Ljava_lang_String_);
			return cb_whereEndsWith_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_WhereEndsWith_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Parse.ParseQuery __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WhereEndsWith (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_whereEndsWith_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseQuery']/method[@name='whereEndsWith' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("whereEndsWith", "(Ljava/lang/String;Ljava/lang/String;)Lcom/parse/ParseQuery;", "GetWhereEndsWith_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual global::Com.Parse.ParseQuery WhereEndsWith (string p0, string p1)
		{
			if (id_whereEndsWith_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_whereEndsWith_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "whereEndsWith", "(Ljava/lang/String;Ljava/lang/String;)Lcom/parse/ParseQuery;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);

			global::Com.Parse.ParseQuery __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (JNIEnv.CallObjectMethod  (Handle, id_whereEndsWith_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "whereEndsWith", "(Ljava/lang/String;Ljava/lang/String;)Lcom/parse/ParseQuery;"), new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_whereEqualTo_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetWhereEqualTo_Ljava_lang_String_Ljava_lang_Object_Handler ()
		{
			if (cb_whereEqualTo_Ljava_lang_String_Ljava_lang_Object_ == null)
				cb_whereEqualTo_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_WhereEqualTo_Ljava_lang_String_Ljava_lang_Object_);
			return cb_whereEqualTo_Ljava_lang_String_Ljava_lang_Object_;
		}

		static IntPtr n_WhereEqualTo_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Parse.ParseQuery __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WhereEqualTo (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_whereEqualTo_Ljava_lang_String_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseQuery']/method[@name='whereEqualTo' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
		[Register ("whereEqualTo", "(Ljava/lang/String;Ljava/lang/Object;)Lcom/parse/ParseQuery;", "GetWhereEqualTo_Ljava_lang_String_Ljava_lang_Object_Handler")]
		public virtual global::Com.Parse.ParseQuery WhereEqualTo (string p0, global::Java.Lang.Object p1)
		{
			if (id_whereEqualTo_Ljava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
				id_whereEqualTo_Ljava_lang_String_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "whereEqualTo", "(Ljava/lang/String;Ljava/lang/Object;)Lcom/parse/ParseQuery;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Com.Parse.ParseQuery __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (JNIEnv.CallObjectMethod  (Handle, id_whereEqualTo_Ljava_lang_String_Ljava_lang_Object_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "whereEqualTo", "(Ljava/lang/String;Ljava/lang/Object;)Lcom/parse/ParseQuery;"), new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_whereExists_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetWhereExists_Ljava_lang_String_Handler ()
		{
			if (cb_whereExists_Ljava_lang_String_ == null)
				cb_whereExists_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WhereExists_Ljava_lang_String_);
			return cb_whereExists_Ljava_lang_String_;
		}

		static IntPtr n_WhereExists_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.ParseQuery __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WhereExists (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_whereExists_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseQuery']/method[@name='whereExists' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("whereExists", "(Ljava/lang/String;)Lcom/parse/ParseQuery;", "GetWhereExists_Ljava_lang_String_Handler")]
		public virtual global::Com.Parse.ParseQuery WhereExists (string p0)
		{
			if (id_whereExists_Ljava_lang_String_ == IntPtr.Zero)
				id_whereExists_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "whereExists", "(Ljava/lang/String;)Lcom/parse/ParseQuery;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Com.Parse.ParseQuery __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (JNIEnv.CallObjectMethod  (Handle, id_whereExists_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "whereExists", "(Ljava/lang/String;)Lcom/parse/ParseQuery;"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_whereGreaterThan_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetWhereGreaterThan_Ljava_lang_String_Ljava_lang_Object_Handler ()
		{
			if (cb_whereGreaterThan_Ljava_lang_String_Ljava_lang_Object_ == null)
				cb_whereGreaterThan_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_WhereGreaterThan_Ljava_lang_String_Ljava_lang_Object_);
			return cb_whereGreaterThan_Ljava_lang_String_Ljava_lang_Object_;
		}

		static IntPtr n_WhereGreaterThan_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Parse.ParseQuery __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WhereGreaterThan (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_whereGreaterThan_Ljava_lang_String_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseQuery']/method[@name='whereGreaterThan' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
		[Register ("whereGreaterThan", "(Ljava/lang/String;Ljava/lang/Object;)Lcom/parse/ParseQuery;", "GetWhereGreaterThan_Ljava_lang_String_Ljava_lang_Object_Handler")]
		public virtual global::Com.Parse.ParseQuery WhereGreaterThan (string p0, global::Java.Lang.Object p1)
		{
			if (id_whereGreaterThan_Ljava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
				id_whereGreaterThan_Ljava_lang_String_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "whereGreaterThan", "(Ljava/lang/String;Ljava/lang/Object;)Lcom/parse/ParseQuery;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Com.Parse.ParseQuery __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (JNIEnv.CallObjectMethod  (Handle, id_whereGreaterThan_Ljava_lang_String_Ljava_lang_Object_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "whereGreaterThan", "(Ljava/lang/String;Ljava/lang/Object;)Lcom/parse/ParseQuery;"), new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_whereGreaterThanOrEqualTo_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetWhereGreaterThanOrEqualTo_Ljava_lang_String_Ljava_lang_Object_Handler ()
		{
			if (cb_whereGreaterThanOrEqualTo_Ljava_lang_String_Ljava_lang_Object_ == null)
				cb_whereGreaterThanOrEqualTo_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_WhereGreaterThanOrEqualTo_Ljava_lang_String_Ljava_lang_Object_);
			return cb_whereGreaterThanOrEqualTo_Ljava_lang_String_Ljava_lang_Object_;
		}

		static IntPtr n_WhereGreaterThanOrEqualTo_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Parse.ParseQuery __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WhereGreaterThanOrEqualTo (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_whereGreaterThanOrEqualTo_Ljava_lang_String_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseQuery']/method[@name='whereGreaterThanOrEqualTo' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
		[Register ("whereGreaterThanOrEqualTo", "(Ljava/lang/String;Ljava/lang/Object;)Lcom/parse/ParseQuery;", "GetWhereGreaterThanOrEqualTo_Ljava_lang_String_Ljava_lang_Object_Handler")]
		public virtual global::Com.Parse.ParseQuery WhereGreaterThanOrEqualTo (string p0, global::Java.Lang.Object p1)
		{
			if (id_whereGreaterThanOrEqualTo_Ljava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
				id_whereGreaterThanOrEqualTo_Ljava_lang_String_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "whereGreaterThanOrEqualTo", "(Ljava/lang/String;Ljava/lang/Object;)Lcom/parse/ParseQuery;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Com.Parse.ParseQuery __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (JNIEnv.CallObjectMethod  (Handle, id_whereGreaterThanOrEqualTo_Ljava_lang_String_Ljava_lang_Object_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "whereGreaterThanOrEqualTo", "(Ljava/lang/String;Ljava/lang/Object;)Lcom/parse/ParseQuery;"), new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_whereLessThan_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetWhereLessThan_Ljava_lang_String_Ljava_lang_Object_Handler ()
		{
			if (cb_whereLessThan_Ljava_lang_String_Ljava_lang_Object_ == null)
				cb_whereLessThan_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_WhereLessThan_Ljava_lang_String_Ljava_lang_Object_);
			return cb_whereLessThan_Ljava_lang_String_Ljava_lang_Object_;
		}

		static IntPtr n_WhereLessThan_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Parse.ParseQuery __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WhereLessThan (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_whereLessThan_Ljava_lang_String_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseQuery']/method[@name='whereLessThan' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
		[Register ("whereLessThan", "(Ljava/lang/String;Ljava/lang/Object;)Lcom/parse/ParseQuery;", "GetWhereLessThan_Ljava_lang_String_Ljava_lang_Object_Handler")]
		public virtual global::Com.Parse.ParseQuery WhereLessThan (string p0, global::Java.Lang.Object p1)
		{
			if (id_whereLessThan_Ljava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
				id_whereLessThan_Ljava_lang_String_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "whereLessThan", "(Ljava/lang/String;Ljava/lang/Object;)Lcom/parse/ParseQuery;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Com.Parse.ParseQuery __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (JNIEnv.CallObjectMethod  (Handle, id_whereLessThan_Ljava_lang_String_Ljava_lang_Object_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "whereLessThan", "(Ljava/lang/String;Ljava/lang/Object;)Lcom/parse/ParseQuery;"), new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_whereLessThanOrEqualTo_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetWhereLessThanOrEqualTo_Ljava_lang_String_Ljava_lang_Object_Handler ()
		{
			if (cb_whereLessThanOrEqualTo_Ljava_lang_String_Ljava_lang_Object_ == null)
				cb_whereLessThanOrEqualTo_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_WhereLessThanOrEqualTo_Ljava_lang_String_Ljava_lang_Object_);
			return cb_whereLessThanOrEqualTo_Ljava_lang_String_Ljava_lang_Object_;
		}

		static IntPtr n_WhereLessThanOrEqualTo_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Parse.ParseQuery __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WhereLessThanOrEqualTo (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_whereLessThanOrEqualTo_Ljava_lang_String_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseQuery']/method[@name='whereLessThanOrEqualTo' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
		[Register ("whereLessThanOrEqualTo", "(Ljava/lang/String;Ljava/lang/Object;)Lcom/parse/ParseQuery;", "GetWhereLessThanOrEqualTo_Ljava_lang_String_Ljava_lang_Object_Handler")]
		public virtual global::Com.Parse.ParseQuery WhereLessThanOrEqualTo (string p0, global::Java.Lang.Object p1)
		{
			if (id_whereLessThanOrEqualTo_Ljava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
				id_whereLessThanOrEqualTo_Ljava_lang_String_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "whereLessThanOrEqualTo", "(Ljava/lang/String;Ljava/lang/Object;)Lcom/parse/ParseQuery;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Com.Parse.ParseQuery __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (JNIEnv.CallObjectMethod  (Handle, id_whereLessThanOrEqualTo_Ljava_lang_String_Ljava_lang_Object_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "whereLessThanOrEqualTo", "(Ljava/lang/String;Ljava/lang/Object;)Lcom/parse/ParseQuery;"), new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_whereMatches_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetWhereMatches_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_whereMatches_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_whereMatches_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_WhereMatches_Ljava_lang_String_Ljava_lang_String_);
			return cb_whereMatches_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_WhereMatches_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Parse.ParseQuery __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WhereMatches (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_whereMatches_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseQuery']/method[@name='whereMatches' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("whereMatches", "(Ljava/lang/String;Ljava/lang/String;)Lcom/parse/ParseQuery;", "GetWhereMatches_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual global::Com.Parse.ParseQuery WhereMatches (string p0, string p1)
		{
			if (id_whereMatches_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_whereMatches_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "whereMatches", "(Ljava/lang/String;Ljava/lang/String;)Lcom/parse/ParseQuery;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);

			global::Com.Parse.ParseQuery __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (JNIEnv.CallObjectMethod  (Handle, id_whereMatches_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "whereMatches", "(Ljava/lang/String;Ljava/lang/String;)Lcom/parse/ParseQuery;"), new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_whereMatches_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetWhereMatches_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_whereMatches_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_whereMatches_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_WhereMatches_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_whereMatches_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_WhereMatches_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Parse.ParseQuery __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WhereMatches (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_whereMatches_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseQuery']/method[@name='whereMatches' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("whereMatches", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lcom/parse/ParseQuery;", "GetWhereMatches_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual global::Com.Parse.ParseQuery WhereMatches (string p0, string p1, string p2)
		{
			if (id_whereMatches_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_whereMatches_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "whereMatches", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lcom/parse/ParseQuery;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);

			global::Com.Parse.ParseQuery __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (JNIEnv.CallObjectMethod  (Handle, id_whereMatches_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1), new JValue (native_p2)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "whereMatches", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lcom/parse/ParseQuery;"), new JValue (native_p0), new JValue (native_p1), new JValue (native_p2)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			return __ret;
		}

		static Delegate cb_whereMatchesKeyInQuery_Ljava_lang_String_Ljava_lang_String_Lcom_parse_ParseQuery_;
#pragma warning disable 0169
		static Delegate GetWhereMatchesKeyInQuery_Ljava_lang_String_Ljava_lang_String_Lcom_parse_ParseQuery_Handler ()
		{
			if (cb_whereMatchesKeyInQuery_Ljava_lang_String_Ljava_lang_String_Lcom_parse_ParseQuery_ == null)
				cb_whereMatchesKeyInQuery_Ljava_lang_String_Ljava_lang_String_Lcom_parse_ParseQuery_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_WhereMatchesKeyInQuery_Ljava_lang_String_Ljava_lang_String_Lcom_parse_ParseQuery_);
			return cb_whereMatchesKeyInQuery_Ljava_lang_String_Ljava_lang_String_Lcom_parse_ParseQuery_;
		}

		static IntPtr n_WhereMatchesKeyInQuery_Ljava_lang_String_Ljava_lang_String_Lcom_parse_ParseQuery_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Parse.ParseQuery __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Parse.ParseQuery p2 = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WhereMatchesKeyInQuery (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_whereMatchesKeyInQuery_Ljava_lang_String_Ljava_lang_String_Lcom_parse_ParseQuery_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseQuery']/method[@name='whereMatchesKeyInQuery' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.parse.ParseQuery']]"
		[Register ("whereMatchesKeyInQuery", "(Ljava/lang/String;Ljava/lang/String;Lcom/parse/ParseQuery;)Lcom/parse/ParseQuery;", "GetWhereMatchesKeyInQuery_Ljava_lang_String_Ljava_lang_String_Lcom_parse_ParseQuery_Handler")]
		public virtual global::Com.Parse.ParseQuery WhereMatchesKeyInQuery (string p0, string p1, global::Com.Parse.ParseQuery p2)
		{
			if (id_whereMatchesKeyInQuery_Ljava_lang_String_Ljava_lang_String_Lcom_parse_ParseQuery_ == IntPtr.Zero)
				id_whereMatchesKeyInQuery_Ljava_lang_String_Ljava_lang_String_Lcom_parse_ParseQuery_ = JNIEnv.GetMethodID (class_ref, "whereMatchesKeyInQuery", "(Ljava/lang/String;Ljava/lang/String;Lcom/parse/ParseQuery;)Lcom/parse/ParseQuery;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);

			global::Com.Parse.ParseQuery __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (JNIEnv.CallObjectMethod  (Handle, id_whereMatchesKeyInQuery_Ljava_lang_String_Ljava_lang_String_Lcom_parse_ParseQuery_, new JValue (native_p0), new JValue (native_p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "whereMatchesKeyInQuery", "(Ljava/lang/String;Ljava/lang/String;Lcom/parse/ParseQuery;)Lcom/parse/ParseQuery;"), new JValue (native_p0), new JValue (native_p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_whereMatchesQuery_Ljava_lang_String_Lcom_parse_ParseQuery_;
#pragma warning disable 0169
		static Delegate GetWhereMatchesQuery_Ljava_lang_String_Lcom_parse_ParseQuery_Handler ()
		{
			if (cb_whereMatchesQuery_Ljava_lang_String_Lcom_parse_ParseQuery_ == null)
				cb_whereMatchesQuery_Ljava_lang_String_Lcom_parse_ParseQuery_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_WhereMatchesQuery_Ljava_lang_String_Lcom_parse_ParseQuery_);
			return cb_whereMatchesQuery_Ljava_lang_String_Lcom_parse_ParseQuery_;
		}

		static IntPtr n_WhereMatchesQuery_Ljava_lang_String_Lcom_parse_ParseQuery_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Parse.ParseQuery __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Parse.ParseQuery p1 = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WhereMatchesQuery (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_whereMatchesQuery_Ljava_lang_String_Lcom_parse_ParseQuery_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseQuery']/method[@name='whereMatchesQuery' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.parse.ParseQuery']]"
		[Register ("whereMatchesQuery", "(Ljava/lang/String;Lcom/parse/ParseQuery;)Lcom/parse/ParseQuery;", "GetWhereMatchesQuery_Ljava_lang_String_Lcom_parse_ParseQuery_Handler")]
		public virtual global::Com.Parse.ParseQuery WhereMatchesQuery (string p0, global::Com.Parse.ParseQuery p1)
		{
			if (id_whereMatchesQuery_Ljava_lang_String_Lcom_parse_ParseQuery_ == IntPtr.Zero)
				id_whereMatchesQuery_Ljava_lang_String_Lcom_parse_ParseQuery_ = JNIEnv.GetMethodID (class_ref, "whereMatchesQuery", "(Ljava/lang/String;Lcom/parse/ParseQuery;)Lcom/parse/ParseQuery;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Com.Parse.ParseQuery __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (JNIEnv.CallObjectMethod  (Handle, id_whereMatchesQuery_Ljava_lang_String_Lcom_parse_ParseQuery_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "whereMatchesQuery", "(Ljava/lang/String;Lcom/parse/ParseQuery;)Lcom/parse/ParseQuery;"), new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_whereNear_Ljava_lang_String_Lcom_parse_ParseGeoPoint_;
#pragma warning disable 0169
		static Delegate GetWhereNear_Ljava_lang_String_Lcom_parse_ParseGeoPoint_Handler ()
		{
			if (cb_whereNear_Ljava_lang_String_Lcom_parse_ParseGeoPoint_ == null)
				cb_whereNear_Ljava_lang_String_Lcom_parse_ParseGeoPoint_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_WhereNear_Ljava_lang_String_Lcom_parse_ParseGeoPoint_);
			return cb_whereNear_Ljava_lang_String_Lcom_parse_ParseGeoPoint_;
		}

		static IntPtr n_WhereNear_Ljava_lang_String_Lcom_parse_ParseGeoPoint_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Parse.ParseQuery __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Parse.ParseGeoPoint p1 = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseGeoPoint> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WhereNear (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_whereNear_Ljava_lang_String_Lcom_parse_ParseGeoPoint_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseQuery']/method[@name='whereNear' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.parse.ParseGeoPoint']]"
		[Register ("whereNear", "(Ljava/lang/String;Lcom/parse/ParseGeoPoint;)Lcom/parse/ParseQuery;", "GetWhereNear_Ljava_lang_String_Lcom_parse_ParseGeoPoint_Handler")]
		public virtual global::Com.Parse.ParseQuery WhereNear (string p0, global::Com.Parse.ParseGeoPoint p1)
		{
			if (id_whereNear_Ljava_lang_String_Lcom_parse_ParseGeoPoint_ == IntPtr.Zero)
				id_whereNear_Ljava_lang_String_Lcom_parse_ParseGeoPoint_ = JNIEnv.GetMethodID (class_ref, "whereNear", "(Ljava/lang/String;Lcom/parse/ParseGeoPoint;)Lcom/parse/ParseQuery;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Com.Parse.ParseQuery __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (JNIEnv.CallObjectMethod  (Handle, id_whereNear_Ljava_lang_String_Lcom_parse_ParseGeoPoint_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "whereNear", "(Ljava/lang/String;Lcom/parse/ParseGeoPoint;)Lcom/parse/ParseQuery;"), new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_whereNotContainedIn_Ljava_lang_String_Ljava_util_Collection_;
#pragma warning disable 0169
		static Delegate GetWhereNotContainedIn_Ljava_lang_String_Ljava_util_Collection_Handler ()
		{
			if (cb_whereNotContainedIn_Ljava_lang_String_Ljava_util_Collection_ == null)
				cb_whereNotContainedIn_Ljava_lang_String_Ljava_util_Collection_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_WhereNotContainedIn_Ljava_lang_String_Ljava_util_Collection_);
			return cb_whereNotContainedIn_Ljava_lang_String_Ljava_util_Collection_;
		}

		static IntPtr n_WhereNotContainedIn_Ljava_lang_String_Ljava_util_Collection_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Parse.ParseQuery __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			System.Collections.ICollection p1 = global::Android.Runtime.JavaCollection.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WhereNotContainedIn (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_whereNotContainedIn_Ljava_lang_String_Ljava_util_Collection_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseQuery']/method[@name='whereNotContainedIn' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Collection']]"
		[Register ("whereNotContainedIn", "(Ljava/lang/String;Ljava/util/Collection;)Lcom/parse/ParseQuery;", "GetWhereNotContainedIn_Ljava_lang_String_Ljava_util_Collection_Handler")]
		public virtual global::Com.Parse.ParseQuery WhereNotContainedIn (string p0, global::System.Collections.ICollection p1)
		{
			if (id_whereNotContainedIn_Ljava_lang_String_Ljava_util_Collection_ == IntPtr.Zero)
				id_whereNotContainedIn_Ljava_lang_String_Ljava_util_Collection_ = JNIEnv.GetMethodID (class_ref, "whereNotContainedIn", "(Ljava/lang/String;Ljava/util/Collection;)Lcom/parse/ParseQuery;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaCollection.ToLocalJniHandle (p1);

			global::Com.Parse.ParseQuery __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (JNIEnv.CallObjectMethod  (Handle, id_whereNotContainedIn_Ljava_lang_String_Ljava_util_Collection_, new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "whereNotContainedIn", "(Ljava/lang/String;Ljava/util/Collection;)Lcom/parse/ParseQuery;"), new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_whereNotEqualTo_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetWhereNotEqualTo_Ljava_lang_String_Ljava_lang_Object_Handler ()
		{
			if (cb_whereNotEqualTo_Ljava_lang_String_Ljava_lang_Object_ == null)
				cb_whereNotEqualTo_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_WhereNotEqualTo_Ljava_lang_String_Ljava_lang_Object_);
			return cb_whereNotEqualTo_Ljava_lang_String_Ljava_lang_Object_;
		}

		static IntPtr n_WhereNotEqualTo_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Parse.ParseQuery __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WhereNotEqualTo (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_whereNotEqualTo_Ljava_lang_String_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseQuery']/method[@name='whereNotEqualTo' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
		[Register ("whereNotEqualTo", "(Ljava/lang/String;Ljava/lang/Object;)Lcom/parse/ParseQuery;", "GetWhereNotEqualTo_Ljava_lang_String_Ljava_lang_Object_Handler")]
		public virtual global::Com.Parse.ParseQuery WhereNotEqualTo (string p0, global::Java.Lang.Object p1)
		{
			if (id_whereNotEqualTo_Ljava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
				id_whereNotEqualTo_Ljava_lang_String_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "whereNotEqualTo", "(Ljava/lang/String;Ljava/lang/Object;)Lcom/parse/ParseQuery;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Com.Parse.ParseQuery __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (JNIEnv.CallObjectMethod  (Handle, id_whereNotEqualTo_Ljava_lang_String_Ljava_lang_Object_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "whereNotEqualTo", "(Ljava/lang/String;Ljava/lang/Object;)Lcom/parse/ParseQuery;"), new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_whereStartsWith_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetWhereStartsWith_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_whereStartsWith_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_whereStartsWith_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_WhereStartsWith_Ljava_lang_String_Ljava_lang_String_);
			return cb_whereStartsWith_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_WhereStartsWith_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Parse.ParseQuery __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WhereStartsWith (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_whereStartsWith_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseQuery']/method[@name='whereStartsWith' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("whereStartsWith", "(Ljava/lang/String;Ljava/lang/String;)Lcom/parse/ParseQuery;", "GetWhereStartsWith_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual global::Com.Parse.ParseQuery WhereStartsWith (string p0, string p1)
		{
			if (id_whereStartsWith_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_whereStartsWith_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "whereStartsWith", "(Ljava/lang/String;Ljava/lang/String;)Lcom/parse/ParseQuery;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);

			global::Com.Parse.ParseQuery __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (JNIEnv.CallObjectMethod  (Handle, id_whereStartsWith_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "whereStartsWith", "(Ljava/lang/String;Ljava/lang/String;)Lcom/parse/ParseQuery;"), new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_whereWithinGeoBox_Ljava_lang_String_Lcom_parse_ParseGeoPoint_Lcom_parse_ParseGeoPoint_;
#pragma warning disable 0169
		static Delegate GetWhereWithinGeoBox_Ljava_lang_String_Lcom_parse_ParseGeoPoint_Lcom_parse_ParseGeoPoint_Handler ()
		{
			if (cb_whereWithinGeoBox_Ljava_lang_String_Lcom_parse_ParseGeoPoint_Lcom_parse_ParseGeoPoint_ == null)
				cb_whereWithinGeoBox_Ljava_lang_String_Lcom_parse_ParseGeoPoint_Lcom_parse_ParseGeoPoint_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_WhereWithinGeoBox_Ljava_lang_String_Lcom_parse_ParseGeoPoint_Lcom_parse_ParseGeoPoint_);
			return cb_whereWithinGeoBox_Ljava_lang_String_Lcom_parse_ParseGeoPoint_Lcom_parse_ParseGeoPoint_;
		}

		static IntPtr n_WhereWithinGeoBox_Ljava_lang_String_Lcom_parse_ParseGeoPoint_Lcom_parse_ParseGeoPoint_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Parse.ParseQuery __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Parse.ParseGeoPoint p1 = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseGeoPoint> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Parse.ParseGeoPoint p2 = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseGeoPoint> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WhereWithinGeoBox (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_whereWithinGeoBox_Ljava_lang_String_Lcom_parse_ParseGeoPoint_Lcom_parse_ParseGeoPoint_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseQuery']/method[@name='whereWithinGeoBox' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.parse.ParseGeoPoint'] and parameter[3][@type='com.parse.ParseGeoPoint']]"
		[Register ("whereWithinGeoBox", "(Ljava/lang/String;Lcom/parse/ParseGeoPoint;Lcom/parse/ParseGeoPoint;)Lcom/parse/ParseQuery;", "GetWhereWithinGeoBox_Ljava_lang_String_Lcom_parse_ParseGeoPoint_Lcom_parse_ParseGeoPoint_Handler")]
		public virtual global::Com.Parse.ParseQuery WhereWithinGeoBox (string p0, global::Com.Parse.ParseGeoPoint p1, global::Com.Parse.ParseGeoPoint p2)
		{
			if (id_whereWithinGeoBox_Ljava_lang_String_Lcom_parse_ParseGeoPoint_Lcom_parse_ParseGeoPoint_ == IntPtr.Zero)
				id_whereWithinGeoBox_Ljava_lang_String_Lcom_parse_ParseGeoPoint_Lcom_parse_ParseGeoPoint_ = JNIEnv.GetMethodID (class_ref, "whereWithinGeoBox", "(Ljava/lang/String;Lcom/parse/ParseGeoPoint;Lcom/parse/ParseGeoPoint;)Lcom/parse/ParseQuery;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Com.Parse.ParseQuery __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (JNIEnv.CallObjectMethod  (Handle, id_whereWithinGeoBox_Ljava_lang_String_Lcom_parse_ParseGeoPoint_Lcom_parse_ParseGeoPoint_, new JValue (native_p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "whereWithinGeoBox", "(Ljava/lang/String;Lcom/parse/ParseGeoPoint;Lcom/parse/ParseGeoPoint;)Lcom/parse/ParseQuery;"), new JValue (native_p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_whereWithinKilometers_Ljava_lang_String_Lcom_parse_ParseGeoPoint_D;
#pragma warning disable 0169
		static Delegate GetWhereWithinKilometers_Ljava_lang_String_Lcom_parse_ParseGeoPoint_DHandler ()
		{
			if (cb_whereWithinKilometers_Ljava_lang_String_Lcom_parse_ParseGeoPoint_D == null)
				cb_whereWithinKilometers_Ljava_lang_String_Lcom_parse_ParseGeoPoint_D = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, double, IntPtr>) n_WhereWithinKilometers_Ljava_lang_String_Lcom_parse_ParseGeoPoint_D);
			return cb_whereWithinKilometers_Ljava_lang_String_Lcom_parse_ParseGeoPoint_D;
		}

		static IntPtr n_WhereWithinKilometers_Ljava_lang_String_Lcom_parse_ParseGeoPoint_D (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, double p2)
		{
			global::Com.Parse.ParseQuery __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Parse.ParseGeoPoint p1 = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseGeoPoint> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WhereWithinKilometers (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_whereWithinKilometers_Ljava_lang_String_Lcom_parse_ParseGeoPoint_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseQuery']/method[@name='whereWithinKilometers' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.parse.ParseGeoPoint'] and parameter[3][@type='double']]"
		[Register ("whereWithinKilometers", "(Ljava/lang/String;Lcom/parse/ParseGeoPoint;D)Lcom/parse/ParseQuery;", "GetWhereWithinKilometers_Ljava_lang_String_Lcom_parse_ParseGeoPoint_DHandler")]
		public virtual global::Com.Parse.ParseQuery WhereWithinKilometers (string p0, global::Com.Parse.ParseGeoPoint p1, double p2)
		{
			if (id_whereWithinKilometers_Ljava_lang_String_Lcom_parse_ParseGeoPoint_D == IntPtr.Zero)
				id_whereWithinKilometers_Ljava_lang_String_Lcom_parse_ParseGeoPoint_D = JNIEnv.GetMethodID (class_ref, "whereWithinKilometers", "(Ljava/lang/String;Lcom/parse/ParseGeoPoint;D)Lcom/parse/ParseQuery;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Com.Parse.ParseQuery __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (JNIEnv.CallObjectMethod  (Handle, id_whereWithinKilometers_Ljava_lang_String_Lcom_parse_ParseGeoPoint_D, new JValue (native_p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "whereWithinKilometers", "(Ljava/lang/String;Lcom/parse/ParseGeoPoint;D)Lcom/parse/ParseQuery;"), new JValue (native_p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_whereWithinMiles_Ljava_lang_String_Lcom_parse_ParseGeoPoint_D;
#pragma warning disable 0169
		static Delegate GetWhereWithinMiles_Ljava_lang_String_Lcom_parse_ParseGeoPoint_DHandler ()
		{
			if (cb_whereWithinMiles_Ljava_lang_String_Lcom_parse_ParseGeoPoint_D == null)
				cb_whereWithinMiles_Ljava_lang_String_Lcom_parse_ParseGeoPoint_D = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, double, IntPtr>) n_WhereWithinMiles_Ljava_lang_String_Lcom_parse_ParseGeoPoint_D);
			return cb_whereWithinMiles_Ljava_lang_String_Lcom_parse_ParseGeoPoint_D;
		}

		static IntPtr n_WhereWithinMiles_Ljava_lang_String_Lcom_parse_ParseGeoPoint_D (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, double p2)
		{
			global::Com.Parse.ParseQuery __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Parse.ParseGeoPoint p1 = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseGeoPoint> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WhereWithinMiles (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_whereWithinMiles_Ljava_lang_String_Lcom_parse_ParseGeoPoint_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseQuery']/method[@name='whereWithinMiles' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.parse.ParseGeoPoint'] and parameter[3][@type='double']]"
		[Register ("whereWithinMiles", "(Ljava/lang/String;Lcom/parse/ParseGeoPoint;D)Lcom/parse/ParseQuery;", "GetWhereWithinMiles_Ljava_lang_String_Lcom_parse_ParseGeoPoint_DHandler")]
		public virtual global::Com.Parse.ParseQuery WhereWithinMiles (string p0, global::Com.Parse.ParseGeoPoint p1, double p2)
		{
			if (id_whereWithinMiles_Ljava_lang_String_Lcom_parse_ParseGeoPoint_D == IntPtr.Zero)
				id_whereWithinMiles_Ljava_lang_String_Lcom_parse_ParseGeoPoint_D = JNIEnv.GetMethodID (class_ref, "whereWithinMiles", "(Ljava/lang/String;Lcom/parse/ParseGeoPoint;D)Lcom/parse/ParseQuery;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Com.Parse.ParseQuery __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (JNIEnv.CallObjectMethod  (Handle, id_whereWithinMiles_Ljava_lang_String_Lcom_parse_ParseGeoPoint_D, new JValue (native_p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "whereWithinMiles", "(Ljava/lang/String;Lcom/parse/ParseGeoPoint;D)Lcom/parse/ParseQuery;"), new JValue (native_p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_whereWithinRadians_Ljava_lang_String_Lcom_parse_ParseGeoPoint_D;
#pragma warning disable 0169
		static Delegate GetWhereWithinRadians_Ljava_lang_String_Lcom_parse_ParseGeoPoint_DHandler ()
		{
			if (cb_whereWithinRadians_Ljava_lang_String_Lcom_parse_ParseGeoPoint_D == null)
				cb_whereWithinRadians_Ljava_lang_String_Lcom_parse_ParseGeoPoint_D = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, double, IntPtr>) n_WhereWithinRadians_Ljava_lang_String_Lcom_parse_ParseGeoPoint_D);
			return cb_whereWithinRadians_Ljava_lang_String_Lcom_parse_ParseGeoPoint_D;
		}

		static IntPtr n_WhereWithinRadians_Ljava_lang_String_Lcom_parse_ParseGeoPoint_D (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, double p2)
		{
			global::Com.Parse.ParseQuery __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Parse.ParseGeoPoint p1 = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseGeoPoint> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WhereWithinRadians (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_whereWithinRadians_Ljava_lang_String_Lcom_parse_ParseGeoPoint_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseQuery']/method[@name='whereWithinRadians' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.parse.ParseGeoPoint'] and parameter[3][@type='double']]"
		[Register ("whereWithinRadians", "(Ljava/lang/String;Lcom/parse/ParseGeoPoint;D)Lcom/parse/ParseQuery;", "GetWhereWithinRadians_Ljava_lang_String_Lcom_parse_ParseGeoPoint_DHandler")]
		public virtual global::Com.Parse.ParseQuery WhereWithinRadians (string p0, global::Com.Parse.ParseGeoPoint p1, double p2)
		{
			if (id_whereWithinRadians_Ljava_lang_String_Lcom_parse_ParseGeoPoint_D == IntPtr.Zero)
				id_whereWithinRadians_Ljava_lang_String_Lcom_parse_ParseGeoPoint_D = JNIEnv.GetMethodID (class_ref, "whereWithinRadians", "(Ljava/lang/String;Lcom/parse/ParseGeoPoint;D)Lcom/parse/ParseQuery;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Com.Parse.ParseQuery __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (JNIEnv.CallObjectMethod  (Handle, id_whereWithinRadians_Ljava_lang_String_Lcom_parse_ParseGeoPoint_D, new JValue (native_p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "whereWithinRadians", "(Ljava/lang/String;Lcom/parse/ParseGeoPoint;D)Lcom/parse/ParseQuery;"), new JValue (native_p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}
}
