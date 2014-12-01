using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Parse.Codec.Language {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.parse.codec.language']/class[@name='Soundex']"
	[global::Android.Runtime.Register ("com/parse/codec/language/Soundex", DoNotGenerateAcw=true)]
	public partial class Soundex : global::Java.Lang.Object, global::Com.Parse.Codec.IStringEncoder {


		static IntPtr US_ENGLISH_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.parse.codec.language']/class[@name='Soundex']/field[@name='US_ENGLISH']"
		[Register ("US_ENGLISH")]
		public static global::Com.Parse.Codec.Language.Soundex UsEnglish {
			get {
				if (US_ENGLISH_jfieldId == IntPtr.Zero)
					US_ENGLISH_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "US_ENGLISH", "Lcom/parse/codec/language/Soundex;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, US_ENGLISH_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Parse.Codec.Language.Soundex> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (US_ENGLISH_jfieldId == IntPtr.Zero)
					US_ENGLISH_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "US_ENGLISH", "Lcom/parse/codec/language/Soundex;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, US_ENGLISH_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.parse.codec.language']/class[@name='Soundex']/field[@name='US_ENGLISH_MAPPING_STRING']"
		[Register ("US_ENGLISH_MAPPING_STRING")]
		public const string UsEnglishMappingString = (string) "01230120022455012623010202";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/parse/codec/language/Soundex", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Soundex); }
		}

		protected Soundex (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.parse.codec.language']/class[@name='Soundex']/constructor[@name='Soundex' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public Soundex (string p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);;
			if (GetType () != typeof (Soundex)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.parse.codec.language']/class[@name='Soundex']/constructor[@name='Soundex' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public Soundex () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (Soundex)) {
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

		static IntPtr id_ctor_arrayC;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.parse.codec.language']/class[@name='Soundex']/constructor[@name='Soundex' and count(parameter)=1 and parameter[1][@type='char[]']]"
		[Register (".ctor", "([C)V", "")]
		public Soundex (char[] p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewArray (p0);;
			if (GetType () != typeof (Soundex)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "([C)V", new JValue (native_p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "([C)V", new JValue (native_p0));
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				return;
			}

			if (id_ctor_arrayC == IntPtr.Zero)
				id_ctor_arrayC = JNIEnv.GetMethodID (class_ref, "<init>", "([C)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayC, new JValue (native_p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_arrayC, new JValue (native_p0));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getMaxLength;
#pragma warning disable 0169
		static Delegate GetGetMaxLengthHandler ()
		{
			if (cb_getMaxLength == null)
				cb_getMaxLength = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMaxLength);
			return cb_getMaxLength;
		}

		static int n_GetMaxLength (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.Codec.Language.Soundex __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Codec.Language.Soundex> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxLength;
		}
#pragma warning restore 0169

		static Delegate cb_setMaxLength_I;
#pragma warning disable 0169
		static Delegate GetSetMaxLength_IHandler ()
		{
			if (cb_setMaxLength_I == null)
				cb_setMaxLength_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetMaxLength_I);
			return cb_setMaxLength_I;
		}

		static void n_SetMaxLength_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Parse.Codec.Language.Soundex __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Codec.Language.Soundex> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MaxLength = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMaxLength;
		static IntPtr id_setMaxLength_I;
		public virtual int MaxLength {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.language']/class[@name='Soundex']/method[@name='getMaxLength' and count(parameter)=0]"
			[Register ("getMaxLength", "()I", "GetGetMaxLengthHandler")]
			get {
				if (id_getMaxLength == IntPtr.Zero)
					id_getMaxLength = JNIEnv.GetMethodID (class_ref, "getMaxLength", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getMaxLength);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMaxLength", "()I"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.language']/class[@name='Soundex']/method[@name='setMaxLength' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMaxLength", "(I)V", "GetSetMaxLength_IHandler")]
			set {
				if (id_setMaxLength_I == IntPtr.Zero)
					id_setMaxLength_I = JNIEnv.GetMethodID (class_ref, "setMaxLength", "(I)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setMaxLength_I, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMaxLength", "(I)V"), new JValue (value));
			}
		}

		static Delegate cb_difference_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDifference_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_difference_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_difference_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_Difference_Ljava_lang_String_Ljava_lang_String_);
			return cb_difference_Ljava_lang_String_Ljava_lang_String_;
		}

		static int n_Difference_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Parse.Codec.Language.Soundex __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Codec.Language.Soundex> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Difference (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_difference_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.language']/class[@name='Soundex']/method[@name='difference' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("difference", "(Ljava/lang/String;Ljava/lang/String;)I", "GetDifference_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual int Difference (string p0, string p1)
		{
			if (id_difference_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_difference_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "difference", "(Ljava/lang/String;Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);

			int __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallIntMethod  (Handle, id_difference_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			else
				__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "difference", "(Ljava/lang/String;Ljava/lang/String;)I"), new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
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
			global::Com.Parse.Codec.Language.Soundex __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Codec.Language.Soundex> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Encode (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_encode_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.language']/class[@name='Soundex']/method[@name='encode' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
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
			global::Com.Parse.Codec.Language.Soundex __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Codec.Language.Soundex> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Encode (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_encode_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.language']/class[@name='Soundex']/method[@name='encode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_soundex_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetInvokeSoundex_Ljava_lang_String_Handler ()
		{
			if (cb_soundex_Ljava_lang_String_ == null)
				cb_soundex_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_InvokeSoundex_Ljava_lang_String_);
			return cb_soundex_Ljava_lang_String_;
		}

		static IntPtr n_InvokeSoundex_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.Codec.Language.Soundex __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Codec.Language.Soundex> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.InvokeSoundex (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_soundex_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.language']/class[@name='Soundex']/method[@name='soundex' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("soundex", "(Ljava/lang/String;)Ljava/lang/String;", "GetInvokeSoundex_Ljava_lang_String_Handler")]
		public virtual string InvokeSoundex (string p0)
		{
			if (id_soundex_Ljava_lang_String_ == IntPtr.Zero)
				id_soundex_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "soundex", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			string __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_soundex_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "soundex", "(Ljava/lang/String;)Ljava/lang/String;"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}
}
