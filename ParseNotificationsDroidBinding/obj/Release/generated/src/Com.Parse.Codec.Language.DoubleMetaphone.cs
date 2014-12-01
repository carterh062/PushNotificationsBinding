using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Parse.Codec.Language {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.parse.codec.language']/class[@name='DoubleMetaphone']"
	[global::Android.Runtime.Register ("com/parse/codec/language/DoubleMetaphone", DoNotGenerateAcw=true)]
	public partial class DoubleMetaphone : global::Java.Lang.Object, global::Com.Parse.Codec.IStringEncoder {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.parse.codec.language']/class[@name='DoubleMetaphone.DoubleMetaphoneResult']"
		[global::Android.Runtime.Register ("com/parse/codec/language/DoubleMetaphone$DoubleMetaphoneResult", DoNotGenerateAcw=true)]
		public partial class DoubleMetaphoneResult : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/parse/codec/language/DoubleMetaphone$DoubleMetaphoneResult", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (DoubleMetaphoneResult); }
			}

			protected DoubleMetaphoneResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_parse_codec_language_DoubleMetaphone_I;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.parse.codec.language']/class[@name='DoubleMetaphone.DoubleMetaphoneResult']/constructor[@name='DoubleMetaphone.DoubleMetaphoneResult' and count(parameter)=2 and parameter[1][@type='com.parse.codec.language.DoubleMetaphone'] and parameter[2][@type='int']]"
			[Register (".ctor", "(Lcom/parse/codec/language/DoubleMetaphone;I)V", "")]
			public DoubleMetaphoneResult (global::Com.Parse.Codec.Language.DoubleMetaphone __self, int p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (DoubleMetaphoneResult)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";I)V", new JValue (__self), new JValue (p1)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";I)V", new JValue (__self), new JValue (p1));
					return;
				}

				if (id_ctor_Lcom_parse_codec_language_DoubleMetaphone_I == IntPtr.Zero)
					id_ctor_Lcom_parse_codec_language_DoubleMetaphone_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/parse/codec/language/DoubleMetaphone;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_parse_codec_language_DoubleMetaphone_I, new JValue (__self), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_parse_codec_language_DoubleMetaphone_I, new JValue (__self), new JValue (p1));
			}

			static Delegate cb_getAlternate;
#pragma warning disable 0169
			static Delegate GetGetAlternateHandler ()
			{
				if (cb_getAlternate == null)
					cb_getAlternate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAlternate);
				return cb_getAlternate;
			}

			static IntPtr n_GetAlternate (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Parse.Codec.Language.DoubleMetaphone.DoubleMetaphoneResult __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Codec.Language.DoubleMetaphone.DoubleMetaphoneResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.Alternate);
			}
#pragma warning restore 0169

			static IntPtr id_getAlternate;
			public virtual string Alternate {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.language']/class[@name='DoubleMetaphone.DoubleMetaphoneResult']/method[@name='getAlternate' and count(parameter)=0]"
				[Register ("getAlternate", "()Ljava/lang/String;", "GetGetAlternateHandler")]
				get {
					if (id_getAlternate == IntPtr.Zero)
						id_getAlternate = JNIEnv.GetMethodID (class_ref, "getAlternate", "()Ljava/lang/String;");

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getAlternate), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAlternate", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				}
			}

			static Delegate cb_isComplete;
#pragma warning disable 0169
			static Delegate GetIsCompleteHandler ()
			{
				if (cb_isComplete == null)
					cb_isComplete = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsComplete);
				return cb_isComplete;
			}

			static bool n_IsComplete (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Parse.Codec.Language.DoubleMetaphone.DoubleMetaphoneResult __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Codec.Language.DoubleMetaphone.DoubleMetaphoneResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.IsComplete;
			}
#pragma warning restore 0169

			static IntPtr id_isComplete;
			public virtual bool IsComplete {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.language']/class[@name='DoubleMetaphone.DoubleMetaphoneResult']/method[@name='isComplete' and count(parameter)=0]"
				[Register ("isComplete", "()Z", "GetIsCompleteHandler")]
				get {
					if (id_isComplete == IntPtr.Zero)
						id_isComplete = JNIEnv.GetMethodID (class_ref, "isComplete", "()Z");

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isComplete);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isComplete", "()Z"));
				}
			}

			static Delegate cb_getPrimary;
#pragma warning disable 0169
			static Delegate GetGetPrimaryHandler ()
			{
				if (cb_getPrimary == null)
					cb_getPrimary = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPrimary);
				return cb_getPrimary;
			}

			static IntPtr n_GetPrimary (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Parse.Codec.Language.DoubleMetaphone.DoubleMetaphoneResult __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Codec.Language.DoubleMetaphone.DoubleMetaphoneResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.Primary);
			}
#pragma warning restore 0169

			static IntPtr id_getPrimary;
			public virtual string Primary {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.language']/class[@name='DoubleMetaphone.DoubleMetaphoneResult']/method[@name='getPrimary' and count(parameter)=0]"
				[Register ("getPrimary", "()Ljava/lang/String;", "GetGetPrimaryHandler")]
				get {
					if (id_getPrimary == IntPtr.Zero)
						id_getPrimary = JNIEnv.GetMethodID (class_ref, "getPrimary", "()Ljava/lang/String;");

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getPrimary), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPrimary", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				}
			}

			static Delegate cb_append_C;
#pragma warning disable 0169
			static Delegate GetAppend_CHandler ()
			{
				if (cb_append_C == null)
					cb_append_C = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, char>) n_Append_C);
				return cb_append_C;
			}

			static void n_Append_C (IntPtr jnienv, IntPtr native__this, char p0)
			{
				global::Com.Parse.Codec.Language.DoubleMetaphone.DoubleMetaphoneResult __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Codec.Language.DoubleMetaphone.DoubleMetaphoneResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Append (p0);
			}
#pragma warning restore 0169

			static IntPtr id_append_C;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.language']/class[@name='DoubleMetaphone.DoubleMetaphoneResult']/method[@name='append' and count(parameter)=1 and parameter[1][@type='char']]"
			[Register ("append", "(C)V", "GetAppend_CHandler")]
			public virtual void Append (char p0)
			{
				if (id_append_C == IntPtr.Zero)
					id_append_C = JNIEnv.GetMethodID (class_ref, "append", "(C)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_append_C, new JValue (p0));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(C)V"), new JValue (p0));
			}

			static Delegate cb_append_CC;
#pragma warning disable 0169
			static Delegate GetAppend_CCHandler ()
			{
				if (cb_append_CC == null)
					cb_append_CC = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, char, char>) n_Append_CC);
				return cb_append_CC;
			}

			static void n_Append_CC (IntPtr jnienv, IntPtr native__this, char p0, char p1)
			{
				global::Com.Parse.Codec.Language.DoubleMetaphone.DoubleMetaphoneResult __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Codec.Language.DoubleMetaphone.DoubleMetaphoneResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Append (p0, p1);
			}
#pragma warning restore 0169

			static IntPtr id_append_CC;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.language']/class[@name='DoubleMetaphone.DoubleMetaphoneResult']/method[@name='append' and count(parameter)=2 and parameter[1][@type='char'] and parameter[2][@type='char']]"
			[Register ("append", "(CC)V", "GetAppend_CCHandler")]
			public virtual void Append (char p0, char p1)
			{
				if (id_append_CC == IntPtr.Zero)
					id_append_CC = JNIEnv.GetMethodID (class_ref, "append", "(CC)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_append_CC, new JValue (p0), new JValue (p1));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(CC)V"), new JValue (p0), new JValue (p1));
			}

			static Delegate cb_append_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetAppend_Ljava_lang_String_Handler ()
			{
				if (cb_append_Ljava_lang_String_ == null)
					cb_append_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Append_Ljava_lang_String_);
				return cb_append_Ljava_lang_String_;
			}

			static void n_Append_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Parse.Codec.Language.DoubleMetaphone.DoubleMetaphoneResult __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Codec.Language.DoubleMetaphone.DoubleMetaphoneResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.Append (p0);
			}
#pragma warning restore 0169

			static IntPtr id_append_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.language']/class[@name='DoubleMetaphone.DoubleMetaphoneResult']/method[@name='append' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("append", "(Ljava/lang/String;)V", "GetAppend_Ljava_lang_String_Handler")]
			public virtual void Append (string p0)
			{
				if (id_append_Ljava_lang_String_ == IntPtr.Zero)
					id_append_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "append", "(Ljava/lang/String;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_append_Ljava_lang_String_, new JValue (native_p0));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(Ljava/lang/String;)V"), new JValue (native_p0));
				JNIEnv.DeleteLocalRef (native_p0);
			}

			static Delegate cb_append_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetAppend_Ljava_lang_String_Ljava_lang_String_Handler ()
			{
				if (cb_append_Ljava_lang_String_Ljava_lang_String_ == null)
					cb_append_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Append_Ljava_lang_String_Ljava_lang_String_);
				return cb_append_Ljava_lang_String_Ljava_lang_String_;
			}

			static void n_Append_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Parse.Codec.Language.DoubleMetaphone.DoubleMetaphoneResult __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Codec.Language.DoubleMetaphone.DoubleMetaphoneResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.Append (p0, p1);
			}
#pragma warning restore 0169

			static IntPtr id_append_Ljava_lang_String_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.language']/class[@name='DoubleMetaphone.DoubleMetaphoneResult']/method[@name='append' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
			[Register ("append", "(Ljava/lang/String;Ljava/lang/String;)V", "GetAppend_Ljava_lang_String_Ljava_lang_String_Handler")]
			public virtual void Append (string p0, string p1)
			{
				if (id_append_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_append_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "append", "(Ljava/lang/String;Ljava/lang/String;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				IntPtr native_p1 = JNIEnv.NewString (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_append_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(Ljava/lang/String;Ljava/lang/String;)V"), new JValue (native_p0), new JValue (native_p1));
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}

			static Delegate cb_appendAlternate_C;
#pragma warning disable 0169
			static Delegate GetAppendAlternate_CHandler ()
			{
				if (cb_appendAlternate_C == null)
					cb_appendAlternate_C = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, char>) n_AppendAlternate_C);
				return cb_appendAlternate_C;
			}

			static void n_AppendAlternate_C (IntPtr jnienv, IntPtr native__this, char p0)
			{
				global::Com.Parse.Codec.Language.DoubleMetaphone.DoubleMetaphoneResult __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Codec.Language.DoubleMetaphone.DoubleMetaphoneResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.AppendAlternate (p0);
			}
#pragma warning restore 0169

			static IntPtr id_appendAlternate_C;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.language']/class[@name='DoubleMetaphone.DoubleMetaphoneResult']/method[@name='appendAlternate' and count(parameter)=1 and parameter[1][@type='char']]"
			[Register ("appendAlternate", "(C)V", "GetAppendAlternate_CHandler")]
			public virtual void AppendAlternate (char p0)
			{
				if (id_appendAlternate_C == IntPtr.Zero)
					id_appendAlternate_C = JNIEnv.GetMethodID (class_ref, "appendAlternate", "(C)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_appendAlternate_C, new JValue (p0));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "appendAlternate", "(C)V"), new JValue (p0));
			}

			static Delegate cb_appendAlternate_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetAppendAlternate_Ljava_lang_String_Handler ()
			{
				if (cb_appendAlternate_Ljava_lang_String_ == null)
					cb_appendAlternate_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AppendAlternate_Ljava_lang_String_);
				return cb_appendAlternate_Ljava_lang_String_;
			}

			static void n_AppendAlternate_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Parse.Codec.Language.DoubleMetaphone.DoubleMetaphoneResult __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Codec.Language.DoubleMetaphone.DoubleMetaphoneResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.AppendAlternate (p0);
			}
#pragma warning restore 0169

			static IntPtr id_appendAlternate_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.language']/class[@name='DoubleMetaphone.DoubleMetaphoneResult']/method[@name='appendAlternate' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("appendAlternate", "(Ljava/lang/String;)V", "GetAppendAlternate_Ljava_lang_String_Handler")]
			public virtual void AppendAlternate (string p0)
			{
				if (id_appendAlternate_Ljava_lang_String_ == IntPtr.Zero)
					id_appendAlternate_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "appendAlternate", "(Ljava/lang/String;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_appendAlternate_Ljava_lang_String_, new JValue (native_p0));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "appendAlternate", "(Ljava/lang/String;)V"), new JValue (native_p0));
				JNIEnv.DeleteLocalRef (native_p0);
			}

			static Delegate cb_appendPrimary_C;
#pragma warning disable 0169
			static Delegate GetAppendPrimary_CHandler ()
			{
				if (cb_appendPrimary_C == null)
					cb_appendPrimary_C = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, char>) n_AppendPrimary_C);
				return cb_appendPrimary_C;
			}

			static void n_AppendPrimary_C (IntPtr jnienv, IntPtr native__this, char p0)
			{
				global::Com.Parse.Codec.Language.DoubleMetaphone.DoubleMetaphoneResult __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Codec.Language.DoubleMetaphone.DoubleMetaphoneResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.AppendPrimary (p0);
			}
#pragma warning restore 0169

			static IntPtr id_appendPrimary_C;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.language']/class[@name='DoubleMetaphone.DoubleMetaphoneResult']/method[@name='appendPrimary' and count(parameter)=1 and parameter[1][@type='char']]"
			[Register ("appendPrimary", "(C)V", "GetAppendPrimary_CHandler")]
			public virtual void AppendPrimary (char p0)
			{
				if (id_appendPrimary_C == IntPtr.Zero)
					id_appendPrimary_C = JNIEnv.GetMethodID (class_ref, "appendPrimary", "(C)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_appendPrimary_C, new JValue (p0));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "appendPrimary", "(C)V"), new JValue (p0));
			}

			static Delegate cb_appendPrimary_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetAppendPrimary_Ljava_lang_String_Handler ()
			{
				if (cb_appendPrimary_Ljava_lang_String_ == null)
					cb_appendPrimary_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AppendPrimary_Ljava_lang_String_);
				return cb_appendPrimary_Ljava_lang_String_;
			}

			static void n_AppendPrimary_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Parse.Codec.Language.DoubleMetaphone.DoubleMetaphoneResult __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Codec.Language.DoubleMetaphone.DoubleMetaphoneResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.AppendPrimary (p0);
			}
#pragma warning restore 0169

			static IntPtr id_appendPrimary_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.language']/class[@name='DoubleMetaphone.DoubleMetaphoneResult']/method[@name='appendPrimary' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("appendPrimary", "(Ljava/lang/String;)V", "GetAppendPrimary_Ljava_lang_String_Handler")]
			public virtual void AppendPrimary (string p0)
			{
				if (id_appendPrimary_Ljava_lang_String_ == IntPtr.Zero)
					id_appendPrimary_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "appendPrimary", "(Ljava/lang/String;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_appendPrimary_Ljava_lang_String_, new JValue (native_p0));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "appendPrimary", "(Ljava/lang/String;)V"), new JValue (native_p0));
				JNIEnv.DeleteLocalRef (native_p0);
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/parse/codec/language/DoubleMetaphone", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DoubleMetaphone); }
		}

		protected DoubleMetaphone (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.parse.codec.language']/class[@name='DoubleMetaphone']/constructor[@name='DoubleMetaphone' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public DoubleMetaphone () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (DoubleMetaphone)) {
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

		static Delegate cb_getMaxCodeLen;
#pragma warning disable 0169
		static Delegate GetGetMaxCodeLenHandler ()
		{
			if (cb_getMaxCodeLen == null)
				cb_getMaxCodeLen = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMaxCodeLen);
			return cb_getMaxCodeLen;
		}

		static int n_GetMaxCodeLen (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.Codec.Language.DoubleMetaphone __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Codec.Language.DoubleMetaphone> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxCodeLen;
		}
#pragma warning restore 0169

		static Delegate cb_setMaxCodeLen_I;
#pragma warning disable 0169
		static Delegate GetSetMaxCodeLen_IHandler ()
		{
			if (cb_setMaxCodeLen_I == null)
				cb_setMaxCodeLen_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetMaxCodeLen_I);
			return cb_setMaxCodeLen_I;
		}

		static void n_SetMaxCodeLen_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Parse.Codec.Language.DoubleMetaphone __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Codec.Language.DoubleMetaphone> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MaxCodeLen = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMaxCodeLen;
		static IntPtr id_setMaxCodeLen_I;
		public virtual int MaxCodeLen {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.language']/class[@name='DoubleMetaphone']/method[@name='getMaxCodeLen' and count(parameter)=0]"
			[Register ("getMaxCodeLen", "()I", "GetGetMaxCodeLenHandler")]
			get {
				if (id_getMaxCodeLen == IntPtr.Zero)
					id_getMaxCodeLen = JNIEnv.GetMethodID (class_ref, "getMaxCodeLen", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getMaxCodeLen);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMaxCodeLen", "()I"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.language']/class[@name='DoubleMetaphone']/method[@name='setMaxCodeLen' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMaxCodeLen", "(I)V", "GetSetMaxCodeLen_IHandler")]
			set {
				if (id_setMaxCodeLen_I == IntPtr.Zero)
					id_setMaxCodeLen_I = JNIEnv.GetMethodID (class_ref, "setMaxCodeLen", "(I)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setMaxCodeLen_I, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMaxCodeLen", "(I)V"), new JValue (value));
			}
		}

		static Delegate cb_charAt_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetCharAt_Ljava_lang_String_IHandler ()
		{
			if (cb_charAt_Ljava_lang_String_I == null)
				cb_charAt_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, char>) n_CharAt_Ljava_lang_String_I);
			return cb_charAt_Ljava_lang_String_I;
		}

		static char n_CharAt_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Parse.Codec.Language.DoubleMetaphone __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Codec.Language.DoubleMetaphone> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			char __ret = __this.CharAt (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_charAt_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.language']/class[@name='DoubleMetaphone']/method[@name='charAt' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("charAt", "(Ljava/lang/String;I)C", "GetCharAt_Ljava_lang_String_IHandler")]
		protected virtual char CharAt (string p0, int p1)
		{
			if (id_charAt_Ljava_lang_String_I == IntPtr.Zero)
				id_charAt_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "charAt", "(Ljava/lang/String;I)C");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			char __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallCharMethod  (Handle, id_charAt_Ljava_lang_String_I, new JValue (native_p0), new JValue (p1));
			else
				__ret = JNIEnv.CallNonvirtualCharMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "charAt", "(Ljava/lang/String;I)C"), new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_contains_Ljava_lang_String_IIarrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.language']/class[@name='DoubleMetaphone']/method[@name='contains' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.String[]']]"
		[Register ("contains", "(Ljava/lang/String;II[Ljava/lang/String;)Z", "")]
		protected static bool Contains (string p0, int p1, int p2, string[] p3)
		{
			if (id_contains_Ljava_lang_String_IIarrayLjava_lang_String_ == IntPtr.Zero)
				id_contains_Ljava_lang_String_IIarrayLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "contains", "(Ljava/lang/String;II[Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_contains_Ljava_lang_String_IIarrayLjava_lang_String_, new JValue (native_p0), new JValue (p1), new JValue (p2), new JValue (native_p3));
			JNIEnv.DeleteLocalRef (native_p0);
			if (p3 != null) {
				JNIEnv.CopyArray (native_p3, p3);
				JNIEnv.DeleteLocalRef (native_p3);
			}
			return __ret;
		}

		static Delegate cb_doubleMetaphone_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetInvokeDoubleMetaphone_Ljava_lang_String_Handler ()
		{
			if (cb_doubleMetaphone_Ljava_lang_String_ == null)
				cb_doubleMetaphone_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_InvokeDoubleMetaphone_Ljava_lang_String_);
			return cb_doubleMetaphone_Ljava_lang_String_;
		}

		static IntPtr n_InvokeDoubleMetaphone_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.Codec.Language.DoubleMetaphone __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Codec.Language.DoubleMetaphone> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.InvokeDoubleMetaphone (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_doubleMetaphone_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.language']/class[@name='DoubleMetaphone']/method[@name='doubleMetaphone' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("doubleMetaphone", "(Ljava/lang/String;)Ljava/lang/String;", "GetInvokeDoubleMetaphone_Ljava_lang_String_Handler")]
		public virtual string InvokeDoubleMetaphone (string p0)
		{
			if (id_doubleMetaphone_Ljava_lang_String_ == IntPtr.Zero)
				id_doubleMetaphone_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "doubleMetaphone", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			string __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_doubleMetaphone_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "doubleMetaphone", "(Ljava/lang/String;)Ljava/lang/String;"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_doubleMetaphone_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetInvokeDoubleMetaphone_Ljava_lang_String_ZHandler ()
		{
			if (cb_doubleMetaphone_Ljava_lang_String_Z == null)
				cb_doubleMetaphone_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool, IntPtr>) n_InvokeDoubleMetaphone_Ljava_lang_String_Z);
			return cb_doubleMetaphone_Ljava_lang_String_Z;
		}

		static IntPtr n_InvokeDoubleMetaphone_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Parse.Codec.Language.DoubleMetaphone __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Codec.Language.DoubleMetaphone> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.InvokeDoubleMetaphone (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_doubleMetaphone_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.language']/class[@name='DoubleMetaphone']/method[@name='doubleMetaphone' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("doubleMetaphone", "(Ljava/lang/String;Z)Ljava/lang/String;", "GetInvokeDoubleMetaphone_Ljava_lang_String_ZHandler")]
		public virtual string InvokeDoubleMetaphone (string p0, bool p1)
		{
			if (id_doubleMetaphone_Ljava_lang_String_Z == IntPtr.Zero)
				id_doubleMetaphone_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "doubleMetaphone", "(Ljava/lang/String;Z)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			string __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_doubleMetaphone_Ljava_lang_String_Z, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "doubleMetaphone", "(Ljava/lang/String;Z)Ljava/lang/String;"), new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_encode_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetEncode_Ljava_lang_Object_Handler ()
		{
			if (cb_encode_Ljava_lang_Object_ == null)
				cb_encode_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Encode_Ljava_lang_Object_);
			return cb_encode_Ljava_lang_Object_;
		}

		static IntPtr n_Encode_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.Codec.Language.DoubleMetaphone __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Codec.Language.DoubleMetaphone> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Encode (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_encode_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.language']/class[@name='DoubleMetaphone']/method[@name='encode' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("encode", "(Ljava/lang/Object;)Ljava/lang/Object;", "GetEncode_Ljava_lang_Object_Handler")]
		public virtual global::Java.Lang.Object Encode (global::Java.Lang.Object p0)
		{
			if (id_encode_Ljava_lang_Object_ == IntPtr.Zero)
				id_encode_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "encode", "(Ljava/lang/Object;)Ljava/lang/Object;");

			global::Java.Lang.Object __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_encode_Ljava_lang_Object_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "encode", "(Ljava/lang/Object;)Ljava/lang/Object;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_encode_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetEncode_Ljava_lang_String_Handler ()
		{
			if (cb_encode_Ljava_lang_String_ == null)
				cb_encode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Encode_Ljava_lang_String_);
			return cb_encode_Ljava_lang_String_;
		}

		static IntPtr n_Encode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.Codec.Language.DoubleMetaphone __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Codec.Language.DoubleMetaphone> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Encode (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_encode_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.language']/class[@name='DoubleMetaphone']/method[@name='encode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("encode", "(Ljava/lang/String;)Ljava/lang/String;", "GetEncode_Ljava_lang_String_Handler")]
		public virtual string Encode (string p0)
		{
			if (id_encode_Ljava_lang_String_ == IntPtr.Zero)
				id_encode_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "encode", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			string __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_encode_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "encode", "(Ljava/lang/String;)Ljava/lang/String;"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_isDoubleMetaphoneEqual_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetIsDoubleMetaphoneEqual_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_isDoubleMetaphoneEqual_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_isDoubleMetaphoneEqual_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_IsDoubleMetaphoneEqual_Ljava_lang_String_Ljava_lang_String_);
			return cb_isDoubleMetaphoneEqual_Ljava_lang_String_Ljava_lang_String_;
		}

		static bool n_IsDoubleMetaphoneEqual_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Parse.Codec.Language.DoubleMetaphone __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Codec.Language.DoubleMetaphone> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsDoubleMetaphoneEqual (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_isDoubleMetaphoneEqual_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.language']/class[@name='DoubleMetaphone']/method[@name='isDoubleMetaphoneEqual' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("isDoubleMetaphoneEqual", "(Ljava/lang/String;Ljava/lang/String;)Z", "GetIsDoubleMetaphoneEqual_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual bool IsDoubleMetaphoneEqual (string p0, string p1)
		{
			if (id_isDoubleMetaphoneEqual_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_isDoubleMetaphoneEqual_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "isDoubleMetaphoneEqual", "(Ljava/lang/String;Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_isDoubleMetaphoneEqual_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isDoubleMetaphoneEqual", "(Ljava/lang/String;Ljava/lang/String;)Z"), new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_isDoubleMetaphoneEqual_Ljava_lang_String_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetIsDoubleMetaphoneEqual_Ljava_lang_String_Ljava_lang_String_ZHandler ()
		{
			if (cb_isDoubleMetaphoneEqual_Ljava_lang_String_Ljava_lang_String_Z == null)
				cb_isDoubleMetaphoneEqual_Ljava_lang_String_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool, bool>) n_IsDoubleMetaphoneEqual_Ljava_lang_String_Ljava_lang_String_Z);
			return cb_isDoubleMetaphoneEqual_Ljava_lang_String_Ljava_lang_String_Z;
		}

		static bool n_IsDoubleMetaphoneEqual_Ljava_lang_String_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, bool p2)
		{
			global::Com.Parse.Codec.Language.DoubleMetaphone __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Codec.Language.DoubleMetaphone> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsDoubleMetaphoneEqual (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_isDoubleMetaphoneEqual_Ljava_lang_String_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.language']/class[@name='DoubleMetaphone']/method[@name='isDoubleMetaphoneEqual' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean']]"
		[Register ("isDoubleMetaphoneEqual", "(Ljava/lang/String;Ljava/lang/String;Z)Z", "GetIsDoubleMetaphoneEqual_Ljava_lang_String_Ljava_lang_String_ZHandler")]
		public virtual bool IsDoubleMetaphoneEqual (string p0, string p1, bool p2)
		{
			if (id_isDoubleMetaphoneEqual_Ljava_lang_String_Ljava_lang_String_Z == IntPtr.Zero)
				id_isDoubleMetaphoneEqual_Ljava_lang_String_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "isDoubleMetaphoneEqual", "(Ljava/lang/String;Ljava/lang/String;Z)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_isDoubleMetaphoneEqual_Ljava_lang_String_Ljava_lang_String_Z, new JValue (native_p0), new JValue (native_p1), new JValue (p2));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isDoubleMetaphoneEqual", "(Ljava/lang/String;Ljava/lang/String;Z)Z"), new JValue (native_p0), new JValue (native_p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

	}
}
