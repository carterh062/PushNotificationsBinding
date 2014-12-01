using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Parse.Codec {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.parse.codec']/interface[@name='Decoder']"
	[Register ("com/parse/codec/Decoder", "", "Com.Parse.Codec.IDecoderInvoker")]
	public partial interface IDecoder : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec']/interface[@name='Decoder']/method[@name='decode' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("decode", "(Ljava/lang/Object;)Ljava/lang/Object;", "GetDecode_Ljava_lang_Object_Handler:Com.Parse.Codec.IDecoderInvoker, ParseNotificationsDroidBinding")]
		global::Java.Lang.Object Decode (global::Java.Lang.Object p0);

	}

	[global::Android.Runtime.Register ("com/parse/codec/Decoder", DoNotGenerateAcw=true)]
	internal class IDecoderInvoker : global::Java.Lang.Object, IDecoder {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/parse/codec/Decoder");
		IntPtr class_ref;

		public static IDecoder GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDecoder> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.parse.codec.Decoder"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDecoderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IDecoderInvoker); }
		}

		static Delegate cb_decode_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetDecode_Ljava_lang_Object_Handler ()
		{
			if (cb_decode_Ljava_lang_Object_ == null)
				cb_decode_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Decode_Ljava_lang_Object_);
			return cb_decode_Ljava_lang_Object_;
		}

		static IntPtr n_Decode_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.Codec.IDecoder __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Codec.IDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Decode (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_decode_Ljava_lang_Object_;
		public global::Java.Lang.Object Decode (global::Java.Lang.Object p0)
		{
			if (id_decode_Ljava_lang_Object_ == IntPtr.Zero)
				id_decode_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "decode", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::Java.Lang.Object __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (Handle, id_decode_Ljava_lang_Object_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}

}
