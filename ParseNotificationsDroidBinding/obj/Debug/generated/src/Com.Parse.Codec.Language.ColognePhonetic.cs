using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Parse.Codec.Language {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.parse.codec.language']/class[@name='ColognePhonetic']"
	[global::Android.Runtime.Register ("com/parse/codec/language/ColognePhonetic", DoNotGenerateAcw=true)]
	public partial class ColognePhonetic : global::Java.Lang.Object, global::Com.Parse.Codec.IStringEncoder {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.parse.codec.language']/class[@name='ColognePhonetic.CologneBuffer']"
		[global::Android.Runtime.Register ("com/parse/codec/language/ColognePhonetic$CologneBuffer", DoNotGenerateAcw=true)]
		public abstract partial class CologneBuffer : global::Java.Lang.Object {


			static IntPtr data_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse.codec.language']/class[@name='ColognePhonetic.CologneBuffer']/field[@name='data']"
			[Register ("data")]
			protected IList<char> Data {
				get {
					if (data_jfieldId == IntPtr.Zero)
						data_jfieldId = JNIEnv.GetFieldID (class_ref, "data", "[C");
					return JavaArray<char>.FromJniHandle (JNIEnv.GetObjectField (Handle, data_jfieldId), JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (data_jfieldId == IntPtr.Zero)
						data_jfieldId = JNIEnv.GetFieldID (class_ref, "data", "[C");
					IntPtr native_value = JavaArray<char>.ToLocalJniHandle (value);
					JNIEnv.SetField (Handle, data_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/parse/codec/language/ColognePhonetic$CologneBuffer", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (CologneBuffer); }
			}

			protected CologneBuffer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_parse_codec_language_ColognePhonetic_arrayC;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.parse.codec.language']/class[@name='ColognePhonetic.CologneBuffer']/constructor[@name='ColognePhonetic.CologneBuffer' and count(parameter)=2 and parameter[1][@type='com.parse.codec.language.ColognePhonetic'] and parameter[2][@type='char[]']]"
			[Register (".ctor", "(Lcom/parse/codec/language/ColognePhonetic;[C)V", "")]
			public CologneBuffer (global::Com.Parse.Codec.Language.ColognePhonetic __self, char[] p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				IntPtr native_p1 = JNIEnv.NewArray (p1);;
				if (GetType () != typeof (CologneBuffer)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";[C)V", new JValue (__self), new JValue (native_p1)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";[C)V", new JValue (__self), new JValue (native_p1));
					if (p1 != null) {
						JNIEnv.CopyArray (native_p1, p1);
						JNIEnv.DeleteLocalRef (native_p1);
					}
					return;
				}

				if (id_ctor_Lcom_parse_codec_language_ColognePhonetic_arrayC == IntPtr.Zero)
					id_ctor_Lcom_parse_codec_language_ColognePhonetic_arrayC = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/parse/codec/language/ColognePhonetic;[C)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_parse_codec_language_ColognePhonetic_arrayC, new JValue (__self), new JValue (native_p1)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_parse_codec_language_ColognePhonetic_arrayC, new JValue (__self), new JValue (native_p1));
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}

			static IntPtr id_ctor_Lcom_parse_codec_language_ColognePhonetic_I;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.parse.codec.language']/class[@name='ColognePhonetic.CologneBuffer']/constructor[@name='ColognePhonetic.CologneBuffer' and count(parameter)=2 and parameter[1][@type='com.parse.codec.language.ColognePhonetic'] and parameter[2][@type='int']]"
			[Register (".ctor", "(Lcom/parse/codec/language/ColognePhonetic;I)V", "")]
			public CologneBuffer (global::Com.Parse.Codec.Language.ColognePhonetic __self, int p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (CologneBuffer)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";I)V", new JValue (__self), new JValue (p1)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";I)V", new JValue (__self), new JValue (p1));
					return;
				}

				if (id_ctor_Lcom_parse_codec_language_ColognePhonetic_I == IntPtr.Zero)
					id_ctor_Lcom_parse_codec_language_ColognePhonetic_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/parse/codec/language/ColognePhonetic;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_parse_codec_language_ColognePhonetic_I, new JValue (__self), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_parse_codec_language_ColognePhonetic_I, new JValue (__self), new JValue (p1));
			}

			static Delegate cb_copyData_II;
#pragma warning disable 0169
			static Delegate GetCopyData_IIHandler ()
			{
				if (cb_copyData_II == null)
					cb_copyData_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr>) n_CopyData_II);
				return cb_copyData_II;
			}

			static IntPtr n_CopyData_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
			{
				global::Com.Parse.Codec.Language.ColognePhonetic.CologneBuffer __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Codec.Language.ColognePhonetic.CologneBuffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewArray (__this.CopyData (p0, p1));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.language']/class[@name='ColognePhonetic.CologneBuffer']/method[@name='copyData' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register ("copyData", "(II)[C", "GetCopyData_IIHandler")]
			protected abstract char[] CopyData (int p0, int p1);

			static Delegate cb_length;
#pragma warning disable 0169
			static Delegate GetLengthHandler ()
			{
				if (cb_length == null)
					cb_length = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Length);
				return cb_length;
			}

			static int n_Length (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Parse.Codec.Language.ColognePhonetic.CologneBuffer __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Codec.Language.ColognePhonetic.CologneBuffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Length ();
			}
#pragma warning restore 0169

			static IntPtr id_length;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.language']/class[@name='ColognePhonetic.CologneBuffer']/method[@name='length' and count(parameter)=0]"
			[Register ("length", "()I", "GetLengthHandler")]
			public virtual int Length ()
			{
				if (id_length == IntPtr.Zero)
					id_length = JNIEnv.GetMethodID (class_ref, "length", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_length);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "length", "()I"));
			}

		}

		[global::Android.Runtime.Register ("com/parse/codec/language/ColognePhonetic$CologneBuffer", DoNotGenerateAcw=true)]
		internal partial class CologneBufferInvoker : CologneBuffer {

			public CologneBufferInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

			protected override global::System.Type ThresholdType {
				get { return typeof (CologneBufferInvoker); }
			}

			static IntPtr id_copyData_II;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.language']/class[@name='ColognePhonetic.CologneBuffer']/method[@name='copyData' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register ("copyData", "(II)[C", "GetCopyData_IIHandler")]
			protected override char[] CopyData (int p0, int p1)
			{
				if (id_copyData_II == IntPtr.Zero)
					id_copyData_II = JNIEnv.GetMethodID (class_ref, "copyData", "(II)[C");
				return (char[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_copyData_II, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef, typeof (char));
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.parse.codec.language']/class[@name='ColognePhonetic.CologneInputBuffer']"
		[global::Android.Runtime.Register ("com/parse/codec/language/ColognePhonetic$CologneInputBuffer", DoNotGenerateAcw=true)]
		public partial class CologneInputBuffer : global::Com.Parse.Codec.Language.ColognePhonetic.CologneBuffer {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/parse/codec/language/ColognePhonetic$CologneInputBuffer", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (CologneInputBuffer); }
			}

			protected CologneInputBuffer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_parse_codec_language_ColognePhonetic_arrayC;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.parse.codec.language']/class[@name='ColognePhonetic.CologneInputBuffer']/constructor[@name='ColognePhonetic.CologneInputBuffer' and count(parameter)=2 and parameter[1][@type='com.parse.codec.language.ColognePhonetic'] and parameter[2][@type='char[]']]"
			[Register (".ctor", "(Lcom/parse/codec/language/ColognePhonetic;[C)V", "")]
			public CologneInputBuffer (global::Com.Parse.Codec.Language.ColognePhonetic __self, char[] p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				IntPtr native_p1 = JNIEnv.NewArray (p1);;
				if (GetType () != typeof (CologneInputBuffer)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";[C)V", new JValue (__self), new JValue (native_p1)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";[C)V", new JValue (__self), new JValue (native_p1));
					if (p1 != null) {
						JNIEnv.CopyArray (native_p1, p1);
						JNIEnv.DeleteLocalRef (native_p1);
					}
					return;
				}

				if (id_ctor_Lcom_parse_codec_language_ColognePhonetic_arrayC == IntPtr.Zero)
					id_ctor_Lcom_parse_codec_language_ColognePhonetic_arrayC = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/parse/codec/language/ColognePhonetic;[C)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_parse_codec_language_ColognePhonetic_arrayC, new JValue (__self), new JValue (native_p1)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_parse_codec_language_ColognePhonetic_arrayC, new JValue (__self), new JValue (native_p1));
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}

			static Delegate cb_getNextChar;
#pragma warning disable 0169
			static Delegate GetGetNextCharHandler ()
			{
				if (cb_getNextChar == null)
					cb_getNextChar = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, char>) n_GetNextChar);
				return cb_getNextChar;
			}

			static char n_GetNextChar (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Parse.Codec.Language.ColognePhonetic.CologneInputBuffer __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Codec.Language.ColognePhonetic.CologneInputBuffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.NextChar;
			}
#pragma warning restore 0169

			static IntPtr id_getNextChar;
			public virtual char NextChar {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.language']/class[@name='ColognePhonetic.CologneInputBuffer']/method[@name='getNextChar' and count(parameter)=0]"
				[Register ("getNextChar", "()C", "GetGetNextCharHandler")]
				get {
					if (id_getNextChar == IntPtr.Zero)
						id_getNextChar = JNIEnv.GetMethodID (class_ref, "getNextChar", "()C");

					if (GetType () == ThresholdType)
						return JNIEnv.CallCharMethod  (Handle, id_getNextChar);
					else
						return JNIEnv.CallNonvirtualCharMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNextChar", "()C"));
				}
			}

			static Delegate cb_getNextPos;
#pragma warning disable 0169
			static Delegate GetGetNextPosHandler ()
			{
				if (cb_getNextPos == null)
					cb_getNextPos = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNextPos);
				return cb_getNextPos;
			}

			static int n_GetNextPos (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Parse.Codec.Language.ColognePhonetic.CologneInputBuffer __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Codec.Language.ColognePhonetic.CologneInputBuffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.NextPos;
			}
#pragma warning restore 0169

			static IntPtr id_getNextPos;
			protected virtual int NextPos {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.language']/class[@name='ColognePhonetic.CologneInputBuffer']/method[@name='getNextPos' and count(parameter)=0]"
				[Register ("getNextPos", "()I", "GetGetNextPosHandler")]
				get {
					if (id_getNextPos == IntPtr.Zero)
						id_getNextPos = JNIEnv.GetMethodID (class_ref, "getNextPos", "()I");

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getNextPos);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNextPos", "()I"));
				}
			}

			static Delegate cb_addLeft_C;
#pragma warning disable 0169
			static Delegate GetAddLeft_CHandler ()
			{
				if (cb_addLeft_C == null)
					cb_addLeft_C = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, char>) n_AddLeft_C);
				return cb_addLeft_C;
			}

			static void n_AddLeft_C (IntPtr jnienv, IntPtr native__this, char p0)
			{
				global::Com.Parse.Codec.Language.ColognePhonetic.CologneInputBuffer __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Codec.Language.ColognePhonetic.CologneInputBuffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.AddLeft (p0);
			}
#pragma warning restore 0169

			static IntPtr id_addLeft_C;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.language']/class[@name='ColognePhonetic.CologneInputBuffer']/method[@name='addLeft' and count(parameter)=1 and parameter[1][@type='char']]"
			[Register ("addLeft", "(C)V", "GetAddLeft_CHandler")]
			public virtual void AddLeft (char p0)
			{
				if (id_addLeft_C == IntPtr.Zero)
					id_addLeft_C = JNIEnv.GetMethodID (class_ref, "addLeft", "(C)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_addLeft_C, new JValue (p0));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addLeft", "(C)V"), new JValue (p0));
			}

			static Delegate cb_copyData_II;
#pragma warning disable 0169
			static Delegate GetCopyData_IIHandler ()
			{
				if (cb_copyData_II == null)
					cb_copyData_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr>) n_CopyData_II);
				return cb_copyData_II;
			}

			static IntPtr n_CopyData_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
			{
				global::Com.Parse.Codec.Language.ColognePhonetic.CologneInputBuffer __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Codec.Language.ColognePhonetic.CologneInputBuffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewArray (__this.CopyData (p0, p1));
			}
#pragma warning restore 0169

			static IntPtr id_copyData_II;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.language']/class[@name='ColognePhonetic.CologneInputBuffer']/method[@name='copyData' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register ("copyData", "(II)[C", "GetCopyData_IIHandler")]
			protected override char[] CopyData (int p0, int p1)
			{
				if (id_copyData_II == IntPtr.Zero)
					id_copyData_II = JNIEnv.GetMethodID (class_ref, "copyData", "(II)[C");

				if (GetType () == ThresholdType)
					return (char[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_copyData_II, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef, typeof (char));
				else
					return (char[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "copyData", "(II)[C"), new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef, typeof (char));
			}

			static Delegate cb_removeNext;
#pragma warning disable 0169
			static Delegate GetRemoveNextHandler ()
			{
				if (cb_removeNext == null)
					cb_removeNext = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, char>) n_RemoveNext);
				return cb_removeNext;
			}

			static char n_RemoveNext (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Parse.Codec.Language.ColognePhonetic.CologneInputBuffer __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Codec.Language.ColognePhonetic.CologneInputBuffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.RemoveNext ();
			}
#pragma warning restore 0169

			static IntPtr id_removeNext;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.language']/class[@name='ColognePhonetic.CologneInputBuffer']/method[@name='removeNext' and count(parameter)=0]"
			[Register ("removeNext", "()C", "GetRemoveNextHandler")]
			public virtual char RemoveNext ()
			{
				if (id_removeNext == IntPtr.Zero)
					id_removeNext = JNIEnv.GetMethodID (class_ref, "removeNext", "()C");

				if (GetType () == ThresholdType)
					return JNIEnv.CallCharMethod  (Handle, id_removeNext);
				else
					return JNIEnv.CallNonvirtualCharMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeNext", "()C"));
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.parse.codec.language']/class[@name='ColognePhonetic.CologneOutputBuffer']"
		[global::Android.Runtime.Register ("com/parse/codec/language/ColognePhonetic$CologneOutputBuffer", DoNotGenerateAcw=true)]
		public partial class CologneOutputBuffer : global::Com.Parse.Codec.Language.ColognePhonetic.CologneBuffer {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/parse/codec/language/ColognePhonetic$CologneOutputBuffer", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (CologneOutputBuffer); }
			}

			protected CologneOutputBuffer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_parse_codec_language_ColognePhonetic_I;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.parse.codec.language']/class[@name='ColognePhonetic.CologneOutputBuffer']/constructor[@name='ColognePhonetic.CologneOutputBuffer' and count(parameter)=2 and parameter[1][@type='com.parse.codec.language.ColognePhonetic'] and parameter[2][@type='int']]"
			[Register (".ctor", "(Lcom/parse/codec/language/ColognePhonetic;I)V", "")]
			public CologneOutputBuffer (global::Com.Parse.Codec.Language.ColognePhonetic __self, int p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (CologneOutputBuffer)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";I)V", new JValue (__self), new JValue (p1)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";I)V", new JValue (__self), new JValue (p1));
					return;
				}

				if (id_ctor_Lcom_parse_codec_language_ColognePhonetic_I == IntPtr.Zero)
					id_ctor_Lcom_parse_codec_language_ColognePhonetic_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/parse/codec/language/ColognePhonetic;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_parse_codec_language_ColognePhonetic_I, new JValue (__self), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_parse_codec_language_ColognePhonetic_I, new JValue (__self), new JValue (p1));
			}

			static Delegate cb_addRight_C;
#pragma warning disable 0169
			static Delegate GetAddRight_CHandler ()
			{
				if (cb_addRight_C == null)
					cb_addRight_C = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, char>) n_AddRight_C);
				return cb_addRight_C;
			}

			static void n_AddRight_C (IntPtr jnienv, IntPtr native__this, char p0)
			{
				global::Com.Parse.Codec.Language.ColognePhonetic.CologneOutputBuffer __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Codec.Language.ColognePhonetic.CologneOutputBuffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.AddRight (p0);
			}
#pragma warning restore 0169

			static IntPtr id_addRight_C;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.language']/class[@name='ColognePhonetic.CologneOutputBuffer']/method[@name='addRight' and count(parameter)=1 and parameter[1][@type='char']]"
			[Register ("addRight", "(C)V", "GetAddRight_CHandler")]
			public virtual void AddRight (char p0)
			{
				if (id_addRight_C == IntPtr.Zero)
					id_addRight_C = JNIEnv.GetMethodID (class_ref, "addRight", "(C)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_addRight_C, new JValue (p0));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addRight", "(C)V"), new JValue (p0));
			}

			static Delegate cb_copyData_II;
#pragma warning disable 0169
			static Delegate GetCopyData_IIHandler ()
			{
				if (cb_copyData_II == null)
					cb_copyData_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr>) n_CopyData_II);
				return cb_copyData_II;
			}

			static IntPtr n_CopyData_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
			{
				global::Com.Parse.Codec.Language.ColognePhonetic.CologneOutputBuffer __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Codec.Language.ColognePhonetic.CologneOutputBuffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewArray (__this.CopyData (p0, p1));
			}
#pragma warning restore 0169

			static IntPtr id_copyData_II;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.language']/class[@name='ColognePhonetic.CologneOutputBuffer']/method[@name='copyData' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register ("copyData", "(II)[C", "GetCopyData_IIHandler")]
			protected override char[] CopyData (int p0, int p1)
			{
				if (id_copyData_II == IntPtr.Zero)
					id_copyData_II = JNIEnv.GetMethodID (class_ref, "copyData", "(II)[C");

				if (GetType () == ThresholdType)
					return (char[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_copyData_II, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef, typeof (char));
				else
					return (char[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "copyData", "(II)[C"), new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef, typeof (char));
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/parse/codec/language/ColognePhonetic", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ColognePhonetic); }
		}

		protected ColognePhonetic (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.parse.codec.language']/class[@name='ColognePhonetic']/constructor[@name='ColognePhonetic' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public ColognePhonetic () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ColognePhonetic)) {
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

		static Delegate cb_colognePhonetic_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetInvokeColognePhonetic_Ljava_lang_String_Handler ()
		{
			if (cb_colognePhonetic_Ljava_lang_String_ == null)
				cb_colognePhonetic_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_InvokeColognePhonetic_Ljava_lang_String_);
			return cb_colognePhonetic_Ljava_lang_String_;
		}

		static IntPtr n_InvokeColognePhonetic_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.Codec.Language.ColognePhonetic __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Codec.Language.ColognePhonetic> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.InvokeColognePhonetic (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_colognePhonetic_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.language']/class[@name='ColognePhonetic']/method[@name='colognePhonetic' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("colognePhonetic", "(Ljava/lang/String;)Ljava/lang/String;", "GetInvokeColognePhonetic_Ljava_lang_String_Handler")]
		public virtual string InvokeColognePhonetic (string p0)
		{
			if (id_colognePhonetic_Ljava_lang_String_ == IntPtr.Zero)
				id_colognePhonetic_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "colognePhonetic", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			string __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_colognePhonetic_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "colognePhonetic", "(Ljava/lang/String;)Ljava/lang/String;"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Parse.Codec.Language.ColognePhonetic __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Codec.Language.ColognePhonetic> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Encode (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_encode_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.language']/class[@name='ColognePhonetic']/method[@name='encode' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
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
			global::Com.Parse.Codec.Language.ColognePhonetic __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Codec.Language.ColognePhonetic> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Encode (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_encode_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.language']/class[@name='ColognePhonetic']/method[@name='encode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_isEncodeEqual_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetIsEncodeEqual_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_isEncodeEqual_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_isEncodeEqual_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_IsEncodeEqual_Ljava_lang_String_Ljava_lang_String_);
			return cb_isEncodeEqual_Ljava_lang_String_Ljava_lang_String_;
		}

		static bool n_IsEncodeEqual_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Parse.Codec.Language.ColognePhonetic __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Codec.Language.ColognePhonetic> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsEncodeEqual (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_isEncodeEqual_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec.language']/class[@name='ColognePhonetic']/method[@name='isEncodeEqual' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("isEncodeEqual", "(Ljava/lang/String;Ljava/lang/String;)Z", "GetIsEncodeEqual_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual bool IsEncodeEqual (string p0, string p1)
		{
			if (id_isEncodeEqual_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_isEncodeEqual_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "isEncodeEqual", "(Ljava/lang/String;Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_isEncodeEqual_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isEncodeEqual", "(Ljava/lang/String;Ljava/lang/String;)Z"), new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

	}
}
