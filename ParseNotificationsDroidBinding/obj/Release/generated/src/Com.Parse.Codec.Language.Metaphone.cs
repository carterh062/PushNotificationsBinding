using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Parse.Codec.Language {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.parse.codec.language']/class[@name='Metaphone']"
	[global::Android.Runtime.Register ("com/parse/codec/language/Metaphone", DoNotGenerateAcw=true)]
	public partial class Metaphone : global::Java.Lang.Object, global::Com.Parse.Codec.IStringEncoder {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/parse/codec/language/Metaphone", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Metaphone); }
		}

		protected Metaphone (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.parse.codec.language']/class[@name='Metaphone']/constructor[@name='Metaphone' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public Metaphone () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (Metaphone)) {
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
			global::Com.Parse.Codec.Language.Metaphone __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Codec.Language.Metaphone> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Parse.Codec.Language.Metaphone __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Codec.Language.Metaphone> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MaxCodeLen = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMaxCodeLen;
		static IntPtr id_setMaxCodeLen_I;
		public virtual int MaxCodeLen {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.language']/class[@name='Metaphone']/method[@name='getMaxCodeLen' and count(parameter)=0]"
			[Register ("getMaxCodeLen", "()I", "GetGetMaxCodeLenHandler")]
			get {
				if (id_getMaxCodeLen == IntPtr.Zero)
					id_getMaxCodeLen = JNIEnv.GetMethodID (class_ref, "getMaxCodeLen", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getMaxCodeLen);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMaxCodeLen", "()I"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.language']/class[@name='Metaphone']/method[@name='setMaxCodeLen' and count(parameter)=1 and parameter[1][@type='int']]"
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
			global::Com.Parse.Codec.Language.Metaphone __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Codec.Language.Metaphone> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Encode (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_encode_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.language']/class[@name='Metaphone']/method[@name='encode' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
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
			global::Com.Parse.Codec.Language.Metaphone __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Codec.Language.Metaphone> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Encode (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_encode_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.language']/class[@name='Metaphone']/method[@name='encode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_isMetaphoneEqual_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetIsMetaphoneEqual_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_isMetaphoneEqual_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_isMetaphoneEqual_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_IsMetaphoneEqual_Ljava_lang_String_Ljava_lang_String_);
			return cb_isMetaphoneEqual_Ljava_lang_String_Ljava_lang_String_;
		}

		static bool n_IsMetaphoneEqual_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Parse.Codec.Language.Metaphone __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Codec.Language.Metaphone> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsMetaphoneEqual (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_isMetaphoneEqual_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.language']/class[@name='Metaphone']/method[@name='isMetaphoneEqual' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("isMetaphoneEqual", "(Ljava/lang/String;Ljava/lang/String;)Z", "GetIsMetaphoneEqual_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual bool IsMetaphoneEqual (string p0, string p1)
		{
			if (id_isMetaphoneEqual_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_isMetaphoneEqual_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "isMetaphoneEqual", "(Ljava/lang/String;Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_isMetaphoneEqual_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isMetaphoneEqual", "(Ljava/lang/String;Ljava/lang/String;)Z"), new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_metaphone_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetInvokeMetaphone_Ljava_lang_String_Handler ()
		{
			if (cb_metaphone_Ljava_lang_String_ == null)
				cb_metaphone_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_InvokeMetaphone_Ljava_lang_String_);
			return cb_metaphone_Ljava_lang_String_;
		}

		static IntPtr n_InvokeMetaphone_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.Codec.Language.Metaphone __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Codec.Language.Metaphone> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.InvokeMetaphone (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_metaphone_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.language']/class[@name='Metaphone']/method[@name='metaphone' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("metaphone", "(Ljava/lang/String;)Ljava/lang/String;", "GetInvokeMetaphone_Ljava_lang_String_Handler")]
		public virtual string InvokeMetaphone (string p0)
		{
			if (id_metaphone_Ljava_lang_String_ == IntPtr.Zero)
				id_metaphone_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "metaphone", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			string __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_metaphone_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "metaphone", "(Ljava/lang/String;)Ljava/lang/String;"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}
}
