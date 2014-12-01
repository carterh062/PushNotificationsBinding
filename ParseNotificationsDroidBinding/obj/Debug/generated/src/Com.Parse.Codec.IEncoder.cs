using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Parse.Codec {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.parse.codec']/interface[@name='Encoder']"
	[Register ("com/parse/codec/Encoder", "", "Com.Parse.Codec.IEncoderInvoker")]
	public partial interface IEncoder : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.codec']/interface[@name='Encoder']/method[@name='encode' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("encode", "(Ljava/lang/Object;)Ljava/lang/Object;", "GetEncode_Ljava_lang_Object_Handler:Com.Parse.Codec.IEncoderInvoker, ParseNotificationsDroidBinding")]
		global::Java.Lang.Object Encode (global::Java.Lang.Object p0);

	}

	[global::Android.Runtime.Register ("com/parse/codec/Encoder", DoNotGenerateAcw=true)]
	internal class IEncoderInvoker : global::Java.Lang.Object, IEncoder {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/parse/codec/Encoder");
		IntPtr class_ref;

		public static IEncoder GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IEncoder> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.parse.codec.Encoder"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IEncoderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IEncoderInvoker); }
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
			global::Com.Parse.Codec.IEncoder __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Codec.IEncoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Encode (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_encode_Ljava_lang_Object_;
		public global::Java.Lang.Object Encode (global::Java.Lang.Object p0)
		{
			if (id_encode_Ljava_lang_Object_ == IntPtr.Zero)
				id_encode_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "encode", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::Java.Lang.Object __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (Handle, id_encode_Ljava_lang_Object_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}

}
