using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Parse.Entity.Mime.Content {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.parse.entity.mime.content']/class[@name='ByteArrayBody']"
	[global::Android.Runtime.Register ("com/parse/entity/mime/content/ByteArrayBody", DoNotGenerateAcw=true)]
	public partial class ByteArrayBody : global::Com.Parse.Entity.Mime.Content.AbstractContentBody {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/parse/entity/mime/content/ByteArrayBody", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ByteArrayBody); }
		}

		protected ByteArrayBody (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_arrayBLjava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.parse.entity.mime.content']/class[@name='ByteArrayBody']/constructor[@name='ByteArrayBody' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register (".ctor", "([BLjava/lang/String;Ljava/lang/String;)V", "")]
		public ByteArrayBody (byte[] p0, string p1, string p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewArray (p0);;
			IntPtr native_p1 = JNIEnv.NewString (p1);;
			IntPtr native_p2 = JNIEnv.NewString (p2);;
			if (GetType () != typeof (ByteArrayBody)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "([BLjava/lang/String;Ljava/lang/String;)V", new JValue (native_p0), new JValue (native_p1), new JValue (native_p2)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "([BLjava/lang/String;Ljava/lang/String;)V", new JValue (native_p0), new JValue (native_p1), new JValue (native_p2));
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				return;
			}

			if (id_ctor_arrayBLjava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_ctor_arrayBLjava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "([BLjava/lang/String;Ljava/lang/String;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayBLjava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1), new JValue (native_p2)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_arrayBLjava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1), new JValue (native_p2));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static IntPtr id_ctor_arrayBLjava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.parse.entity.mime.content']/class[@name='ByteArrayBody']/constructor[@name='ByteArrayBody' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "([BLjava/lang/String;)V", "")]
		public ByteArrayBody (byte[] p0, string p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewArray (p0);;
			IntPtr native_p1 = JNIEnv.NewString (p1);;
			if (GetType () != typeof (ByteArrayBody)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "([BLjava/lang/String;)V", new JValue (native_p0), new JValue (native_p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "([BLjava/lang/String;)V", new JValue (native_p0), new JValue (native_p1));
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				JNIEnv.DeleteLocalRef (native_p1);
				return;
			}

			if (id_ctor_arrayBLjava_lang_String_ == IntPtr.Zero)
				id_ctor_arrayBLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "([BLjava/lang/String;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayBLjava_lang_String_, new JValue (native_p0), new JValue (native_p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_arrayBLjava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_getCharset;
#pragma warning disable 0169
		static Delegate GetGetCharsetHandler ()
		{
			if (cb_getCharset == null)
				cb_getCharset = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCharset);
			return cb_getCharset;
		}

		static IntPtr n_GetCharset (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.Entity.Mime.Content.ByteArrayBody __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Entity.Mime.Content.ByteArrayBody> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Charset);
		}
#pragma warning restore 0169

		static IntPtr id_getCharset;
		public override string Charset {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.entity.mime.content']/class[@name='ByteArrayBody']/method[@name='getCharset' and count(parameter)=0]"
			[Register ("getCharset", "()Ljava/lang/String;", "GetGetCharsetHandler")]
			get {
				if (id_getCharset == IntPtr.Zero)
					id_getCharset = JNIEnv.GetMethodID (class_ref, "getCharset", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getCharset), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCharset", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getContentLength;
#pragma warning disable 0169
		static Delegate GetGetContentLengthHandler ()
		{
			if (cb_getContentLength == null)
				cb_getContentLength = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetContentLength);
			return cb_getContentLength;
		}

		static long n_GetContentLength (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.Entity.Mime.Content.ByteArrayBody __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Entity.Mime.Content.ByteArrayBody> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ContentLength;
		}
#pragma warning restore 0169

		static IntPtr id_getContentLength;
		public override long ContentLength {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.entity.mime.content']/class[@name='ByteArrayBody']/method[@name='getContentLength' and count(parameter)=0]"
			[Register ("getContentLength", "()J", "GetGetContentLengthHandler")]
			get {
				if (id_getContentLength == IntPtr.Zero)
					id_getContentLength = JNIEnv.GetMethodID (class_ref, "getContentLength", "()J");

				if (GetType () == ThresholdType)
					return JNIEnv.CallLongMethod  (Handle, id_getContentLength);
				else
					return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getContentLength", "()J"));
			}
		}

		static Delegate cb_getFilename;
#pragma warning disable 0169
		static Delegate GetGetFilenameHandler ()
		{
			if (cb_getFilename == null)
				cb_getFilename = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFilename);
			return cb_getFilename;
		}

		static IntPtr n_GetFilename (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.Entity.Mime.Content.ByteArrayBody __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Entity.Mime.Content.ByteArrayBody> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Filename);
		}
#pragma warning restore 0169

		static IntPtr id_getFilename;
		public override string Filename {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.entity.mime.content']/class[@name='ByteArrayBody']/method[@name='getFilename' and count(parameter)=0]"
			[Register ("getFilename", "()Ljava/lang/String;", "GetGetFilenameHandler")]
			get {
				if (id_getFilename == IntPtr.Zero)
					id_getFilename = JNIEnv.GetMethodID (class_ref, "getFilename", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getFilename), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFilename", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getTransferEncoding;
#pragma warning disable 0169
		static Delegate GetGetTransferEncodingHandler ()
		{
			if (cb_getTransferEncoding == null)
				cb_getTransferEncoding = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTransferEncoding);
			return cb_getTransferEncoding;
		}

		static IntPtr n_GetTransferEncoding (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.Entity.Mime.Content.ByteArrayBody __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Entity.Mime.Content.ByteArrayBody> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TransferEncoding);
		}
#pragma warning restore 0169

		static IntPtr id_getTransferEncoding;
		public override string TransferEncoding {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.entity.mime.content']/class[@name='ByteArrayBody']/method[@name='getTransferEncoding' and count(parameter)=0]"
			[Register ("getTransferEncoding", "()Ljava/lang/String;", "GetGetTransferEncodingHandler")]
			get {
				if (id_getTransferEncoding == IntPtr.Zero)
					id_getTransferEncoding = JNIEnv.GetMethodID (class_ref, "getTransferEncoding", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getTransferEncoding), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTransferEncoding", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_writeTo_Ljava_io_OutputStream_;
#pragma warning disable 0169
		static Delegate GetWriteTo_Ljava_io_OutputStream_Handler ()
		{
			if (cb_writeTo_Ljava_io_OutputStream_ == null)
				cb_writeTo_Ljava_io_OutputStream_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_WriteTo_Ljava_io_OutputStream_);
			return cb_writeTo_Ljava_io_OutputStream_;
		}

		static void n_WriteTo_Ljava_io_OutputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.Entity.Mime.Content.ByteArrayBody __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Entity.Mime.Content.ByteArrayBody> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream p0 = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.WriteTo (p0);
		}
#pragma warning restore 0169

		static IntPtr id_writeTo_Ljava_io_OutputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.entity.mime.content']/class[@name='ByteArrayBody']/method[@name='writeTo' and count(parameter)=1 and parameter[1][@type='java.io.OutputStream']]"
		[Register ("writeTo", "(Ljava/io/OutputStream;)V", "GetWriteTo_Ljava_io_OutputStream_Handler")]
		public override void WriteTo (global::System.IO.Stream p0)
		{
			if (id_writeTo_Ljava_io_OutputStream_ == IntPtr.Zero)
				id_writeTo_Ljava_io_OutputStream_ = JNIEnv.GetMethodID (class_ref, "writeTo", "(Ljava/io/OutputStream;)V");
			IntPtr native_p0 = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_writeTo_Ljava_io_OutputStream_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeTo", "(Ljava/io/OutputStream;)V"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}
}
