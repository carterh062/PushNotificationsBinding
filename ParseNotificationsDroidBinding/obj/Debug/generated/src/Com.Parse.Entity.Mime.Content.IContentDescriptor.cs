using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Parse.Entity.Mime.Content {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.parse.entity.mime.content']/interface[@name='ContentDescriptor']"
	[Register ("com/parse/entity/mime/content/ContentDescriptor", "", "Com.Parse.Entity.Mime.Content.IContentDescriptorInvoker")]
	public partial interface IContentDescriptor : IJavaObject {

		string Charset {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.entity.mime.content']/interface[@name='ContentDescriptor']/method[@name='getCharset' and count(parameter)=0]"
			[Register ("getCharset", "()Ljava/lang/String;", "GetGetCharsetHandler:Com.Parse.Entity.Mime.Content.IContentDescriptorInvoker, ParseNotificationsDroidBinding")] get;
		}

		long ContentLength {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.entity.mime.content']/interface[@name='ContentDescriptor']/method[@name='getContentLength' and count(parameter)=0]"
			[Register ("getContentLength", "()J", "GetGetContentLengthHandler:Com.Parse.Entity.Mime.Content.IContentDescriptorInvoker, ParseNotificationsDroidBinding")] get;
		}

		string MediaType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.entity.mime.content']/interface[@name='ContentDescriptor']/method[@name='getMediaType' and count(parameter)=0]"
			[Register ("getMediaType", "()Ljava/lang/String;", "GetGetMediaTypeHandler:Com.Parse.Entity.Mime.Content.IContentDescriptorInvoker, ParseNotificationsDroidBinding")] get;
		}

		string MimeType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.entity.mime.content']/interface[@name='ContentDescriptor']/method[@name='getMimeType' and count(parameter)=0]"
			[Register ("getMimeType", "()Ljava/lang/String;", "GetGetMimeTypeHandler:Com.Parse.Entity.Mime.Content.IContentDescriptorInvoker, ParseNotificationsDroidBinding")] get;
		}

		string SubType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.entity.mime.content']/interface[@name='ContentDescriptor']/method[@name='getSubType' and count(parameter)=0]"
			[Register ("getSubType", "()Ljava/lang/String;", "GetGetSubTypeHandler:Com.Parse.Entity.Mime.Content.IContentDescriptorInvoker, ParseNotificationsDroidBinding")] get;
		}

		string TransferEncoding {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse.entity.mime.content']/interface[@name='ContentDescriptor']/method[@name='getTransferEncoding' and count(parameter)=0]"
			[Register ("getTransferEncoding", "()Ljava/lang/String;", "GetGetTransferEncodingHandler:Com.Parse.Entity.Mime.Content.IContentDescriptorInvoker, ParseNotificationsDroidBinding")] get;
		}

	}

	[global::Android.Runtime.Register ("com/parse/entity/mime/content/ContentDescriptor", DoNotGenerateAcw=true)]
	internal class IContentDescriptorInvoker : global::Java.Lang.Object, IContentDescriptor {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/parse/entity/mime/content/ContentDescriptor");
		IntPtr class_ref;

		public static IContentDescriptor GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IContentDescriptor> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.parse.entity.mime.content.ContentDescriptor"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IContentDescriptorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IContentDescriptorInvoker); }
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
			global::Com.Parse.Entity.Mime.Content.IContentDescriptor __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Entity.Mime.Content.IContentDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Parse.Entity.Mime.Content.IContentDescriptor __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Entity.Mime.Content.IContentDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Parse.Entity.Mime.Content.IContentDescriptor __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Entity.Mime.Content.IContentDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Parse.Entity.Mime.Content.IContentDescriptor __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Entity.Mime.Content.IContentDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Parse.Entity.Mime.Content.IContentDescriptor __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Entity.Mime.Content.IContentDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Parse.Entity.Mime.Content.IContentDescriptor __this = global::Java.Lang.Object.GetObject<global::Com.Parse.Entity.Mime.Content.IContentDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
