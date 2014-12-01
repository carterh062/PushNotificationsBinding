using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Parse.Entity.Mime.Content {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.parse.entity.mime.content']/class[@name='AbstractContentBody']"
	[global::Android.Runtime.Register ("com/parse/entity/mime/content/AbstractContentBody", DoNotGenerateAcw=true)]
	public abstract partial class AbstractContentBody : global::Java.Lang.Object, global::Com.Parse.Entity.Mime.Content.IContentBody {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/parse/entity/mime/content/AbstractContentBody", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AbstractContentBody); }
		}

		protected AbstractContentBody (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.parse.entity.mime.content']/class[@name='AbstractContentBody']/constructor[@name='AbstractContentBody' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public AbstractContentBody (string p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);;
			if (GetType () != typeof (AbstractContentBody)) {
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

		static Delegate cb_getMediaType;
#pragma warning disable 0169
		static Delegate GetGetMediaTypeHandler ()
		{
			if (cb_getMediaType == null)
				cb_getMediaType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMediaType);
			return cb_getMediaType;
		}

		static IntPtr n_GetMediaType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.Entity.Mime.Content.AbstractContentBody __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Entity.Mime.Content.AbstractContentBody> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MediaType);
		}
#pragma warning restore 0169

		static IntPtr id_getMediaType;
		public virtual string MediaType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.entity.mime.content']/class[@name='AbstractContentBody']/method[@name='getMediaType' and count(parameter)=0]"
			[Register ("getMediaType", "()Ljava/lang/String;", "GetGetMediaTypeHandler")]
			get {
				if (id_getMediaType == IntPtr.Zero)
					id_getMediaType = JNIEnv.GetMethodID (class_ref, "getMediaType", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getMediaType), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMediaType", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getMimeType;
#pragma warning disable 0169
		static Delegate GetGetMimeTypeHandler ()
		{
			if (cb_getMimeType == null)
				cb_getMimeType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMimeType);
			return cb_getMimeType;
		}

		static IntPtr n_GetMimeType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.Entity.Mime.Content.AbstractContentBody __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Entity.Mime.Content.AbstractContentBody> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MimeType);
		}
#pragma warning restore 0169

		static IntPtr id_getMimeType;
		public virtual string MimeType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.entity.mime.content']/class[@name='AbstractContentBody']/method[@name='getMimeType' and count(parameter)=0]"
			[Register ("getMimeType", "()Ljava/lang/String;", "GetGetMimeTypeHandler")]
			get {
				if (id_getMimeType == IntPtr.Zero)
					id_getMimeType = JNIEnv.GetMethodID (class_ref, "getMimeType", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getMimeType), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMimeType", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getSubType;
#pragma warning disable 0169
		static Delegate GetGetSubTypeHandler ()
		{
			if (cb_getSubType == null)
				cb_getSubType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSubType);
			return cb_getSubType;
		}

		static IntPtr n_GetSubType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.Entity.Mime.Content.AbstractContentBody __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Entity.Mime.Content.AbstractContentBody> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SubType);
		}
#pragma warning restore 0169

		static IntPtr id_getSubType;
		public virtual string SubType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.entity.mime.content']/class[@name='AbstractContentBody']/method[@name='getSubType' and count(parameter)=0]"
			[Register ("getSubType", "()Ljava/lang/String;", "GetGetSubTypeHandler")]
			get {
				if (id_getSubType == IntPtr.Zero)
					id_getSubType = JNIEnv.GetMethodID (class_ref, "getSubType", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getSubType), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSubType", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Parse.Entity.Mime.Content.AbstractContentBody __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Entity.Mime.Content.AbstractContentBody> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream p0 = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.WriteTo (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.entity.mime.content']/class[@name='AbstractContentBody']/method[@name='writeTo' and count(parameter)=1 and parameter[1][@type='java.io.OutputStream']]"
		[Register ("writeTo", "(Ljava/io/OutputStream;)V", "GetWriteTo_Ljava_io_OutputStream_Handler")]
		public abstract void WriteTo (global::System.IO.Stream p0);

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
			global::Com.Parse.Entity.Mime.Content.AbstractContentBody __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Entity.Mime.Content.AbstractContentBody> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Filename);
		}
#pragma warning restore 0169

		public abstract string Filename {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.entity.mime.content']/class[@name='AbstractContentBody']/method[@name='getFilename' and count(parameter)=0]"
			[Register ("getFilename", "()Ljava/lang/String;", "GetGetFilenameHandler")] get;
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
			global::Com.Parse.Entity.Mime.Content.AbstractContentBody __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Entity.Mime.Content.AbstractContentBody> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Charset);
		}
#pragma warning restore 0169

		public abstract string Charset {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.entity.mime.content']/class[@name='AbstractContentBody']/method[@name='getCharset' and count(parameter)=0]"
			[Register ("getCharset", "()Ljava/lang/String;", "GetGetCharsetHandler")] get;
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
			global::Com.Parse.Entity.Mime.Content.AbstractContentBody __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Entity.Mime.Content.AbstractContentBody> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ContentLength;
		}
#pragma warning restore 0169

		public abstract long ContentLength {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.entity.mime.content']/class[@name='AbstractContentBody']/method[@name='getContentLength' and count(parameter)=0]"
			[Register ("getContentLength", "()J", "GetGetContentLengthHandler")] get;
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
			global::Com.Parse.Entity.Mime.Content.AbstractContentBody __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Entity.Mime.Content.AbstractContentBody> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TransferEncoding);
		}
#pragma warning restore 0169

		public abstract string TransferEncoding {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.entity.mime.content']/class[@name='AbstractContentBody']/method[@name='getTransferEncoding' and count(parameter)=0]"
			[Register ("getTransferEncoding", "()Ljava/lang/String;", "GetGetTransferEncodingHandler")] get;
		}

	}

	[global::Android.Runtime.Register ("com/parse/entity/mime/content/AbstractContentBody", DoNotGenerateAcw=true)]
	internal partial class AbstractContentBodyInvoker : AbstractContentBody {

		public AbstractContentBodyInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (AbstractContentBodyInvoker); }
		}

		static IntPtr id_getFilename;
		public override string Filename {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.entity.mime.content']/class[@name='AbstractContentBody']/method[@name='getFilename' and count(parameter)=0]"
			[Register ("getFilename", "()Ljava/lang/String;", "GetGetFilenameHandler")]
			get {
				if (id_getFilename == IntPtr.Zero)
					id_getFilename = JNIEnv.GetMethodID (class_ref, "getFilename", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getFilename), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_writeTo_Ljava_io_OutputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.entity.mime.content']/class[@name='AbstractContentBody']/method[@name='writeTo' and count(parameter)=1 and parameter[1][@type='java.io.OutputStream']]"
		[Register ("writeTo", "(Ljava/io/OutputStream;)V", "GetWriteTo_Ljava_io_OutputStream_Handler")]
		public override void WriteTo (global::System.IO.Stream p0)
		{
			if (id_writeTo_Ljava_io_OutputStream_ == IntPtr.Zero)
				id_writeTo_Ljava_io_OutputStream_ = JNIEnv.GetMethodID (class_ref, "writeTo", "(Ljava/io/OutputStream;)V");
			IntPtr native_p0 = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (p0);
			JNIEnv.CallVoidMethod  (Handle, id_writeTo_Ljava_io_OutputStream_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_getCharset;
		public override string Charset {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.entity.mime.content']/class[@name='AbstractContentBody']/method[@name='getCharset' and count(parameter)=0]"
			[Register ("getCharset", "()Ljava/lang/String;", "GetGetCharsetHandler")]
			get {
				if (id_getCharset == IntPtr.Zero)
					id_getCharset = JNIEnv.GetMethodID (class_ref, "getCharset", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getCharset), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getContentLength;
		public override long ContentLength {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.entity.mime.content']/class[@name='AbstractContentBody']/method[@name='getContentLength' and count(parameter)=0]"
			[Register ("getContentLength", "()J", "GetGetContentLengthHandler")]
			get {
				if (id_getContentLength == IntPtr.Zero)
					id_getContentLength = JNIEnv.GetMethodID (class_ref, "getContentLength", "()J");
				return JNIEnv.CallLongMethod  (Handle, id_getContentLength);
			}
		}

		static IntPtr id_getTransferEncoding;
		public override string TransferEncoding {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.entity.mime.content']/class[@name='AbstractContentBody']/method[@name='getTransferEncoding' and count(parameter)=0]"
			[Register ("getTransferEncoding", "()Ljava/lang/String;", "GetGetTransferEncodingHandler")]
			get {
				if (id_getTransferEncoding == IntPtr.Zero)
					id_getTransferEncoding = JNIEnv.GetMethodID (class_ref, "getTransferEncoding", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getTransferEncoding), JniHandleOwnership.TransferLocalRef);
			}
		}

	}

}
