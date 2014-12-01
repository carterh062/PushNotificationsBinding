using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Parse.Entity.Mime.Content {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.parse.entity.mime.content']/interface[@name='ContentBody']"
	[Register ("com/parse/entity/mime/content/ContentBody", "", "Com.Parse.Entity.Mime.Content.IContentBodyInvoker")]
	public partial interface IContentBody : global::Com.Parse.Entity.Mime.Content.IContentDescriptor {

		string Filename {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.entity.mime.content']/interface[@name='ContentBody']/method[@name='getFilename' and count(parameter)=0]"
			[Register ("getFilename", "()Ljava/lang/String;", "GetGetFilenameHandler:Com.Parse.Entity.Mime.Content.IContentBodyInvoker, ParseNotificationsDroidBinding")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.entity.mime.content']/interface[@name='ContentBody']/method[@name='writeTo' and count(parameter)=1 and parameter[1][@type='java.io.OutputStream']]"
		[Register ("writeTo", "(Ljava/io/OutputStream;)V", "GetWriteTo_Ljava_io_OutputStream_Handler:Com.Parse.Entity.Mime.Content.IContentBodyInvoker, ParseNotificationsDroidBinding")]
		void WriteTo (global::System.IO.Stream p0);

	}

	[global::Android.Runtime.Register ("com/parse/entity/mime/content/ContentBody", DoNotGenerateAcw=true)]
	internal class IContentBodyInvoker : global::Java.Lang.Object, IContentBody {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/parse/entity/mime/content/ContentBody");
		IntPtr class_ref;

		public static IContentBody GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IContentBody> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.parse.entity.mime.content.ContentBody"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IContentBodyInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IContentBodyInvoker); }
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
			global::Com.Parse.Entity.Mime.Content.IContentBody __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Entity.Mime.Content.IContentBody> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Filename);
		}
#pragma warning restore 0169

		IntPtr id_getFilename;
		public string Filename {
			get {
				if (id_getFilename == IntPtr.Zero)
					id_getFilename = JNIEnv.GetMethodID (class_ref, "getFilename", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getFilename), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Parse.Entity.Mime.Content.IContentBody __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Entity.Mime.Content.IContentBody> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream p0 = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.WriteTo (p0);
		}
#pragma warning restore 0169

		IntPtr id_writeTo_Ljava_io_OutputStream_;
		public void WriteTo (global::System.IO.Stream p0)
		{
			if (id_writeTo_Ljava_io_OutputStream_ == IntPtr.Zero)
				id_writeTo_Ljava_io_OutputStream_ = JNIEnv.GetMethodID (class_ref, "writeTo", "(Ljava/io/OutputStream;)V");
			IntPtr native_p0 = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (p0);
			JNIEnv.CallVoidMethod (Handle, id_writeTo_Ljava_io_OutputStream_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
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
			global::Com.Parse.Entity.Mime.Content.IContentBody __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Entity.Mime.Content.IContentBody> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Charset);
		}
#pragma warning restore 0169

		IntPtr id_getCharset;
		public string Charset {
			get {
				if (id_getCharset == IntPtr.Zero)
					id_getCharset = JNIEnv.GetMethodID (class_ref, "getCharset", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getCharset), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Parse.Entity.Mime.Content.IContentBody __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Entity.Mime.Content.IContentBody> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ContentLength;
		}
#pragma warning restore 0169

		IntPtr id_getContentLength;
		public long ContentLength {
			get {
				if (id_getContentLength == IntPtr.Zero)
					id_getContentLength = JNIEnv.GetMethodID (class_ref, "getContentLength", "()J");
				return JNIEnv.CallLongMethod (Handle, id_getContentLength);
			}
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
			global::Com.Parse.Entity.Mime.Content.IContentBody __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Entity.Mime.Content.IContentBody> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MediaType);
		}
#pragma warning restore 0169

		IntPtr id_getMediaType;
		public string MediaType {
			get {
				if (id_getMediaType == IntPtr.Zero)
					id_getMediaType = JNIEnv.GetMethodID (class_ref, "getMediaType", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getMediaType), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Parse.Entity.Mime.Content.IContentBody __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Entity.Mime.Content.IContentBody> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MimeType);
		}
#pragma warning restore 0169

		IntPtr id_getMimeType;
		public string MimeType {
			get {
				if (id_getMimeType == IntPtr.Zero)
					id_getMimeType = JNIEnv.GetMethodID (class_ref, "getMimeType", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getMimeType), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Parse.Entity.Mime.Content.IContentBody __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Entity.Mime.Content.IContentBody> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SubType);
		}
#pragma warning restore 0169

		IntPtr id_getSubType;
		public string SubType {
			get {
				if (id_getSubType == IntPtr.Zero)
					id_getSubType = JNIEnv.GetMethodID (class_ref, "getSubType", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getSubType), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Parse.Entity.Mime.Content.IContentBody __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Entity.Mime.Content.IContentBody> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TransferEncoding);
		}
#pragma warning restore 0169

		IntPtr id_getTransferEncoding;
		public string TransferEncoding {
			get {
				if (id_getTransferEncoding == IntPtr.Zero)
					id_getTransferEncoding = JNIEnv.GetMethodID (class_ref, "getTransferEncoding", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getTransferEncoding), JniHandleOwnership.TransferLocalRef);
			}
		}

	}

}
