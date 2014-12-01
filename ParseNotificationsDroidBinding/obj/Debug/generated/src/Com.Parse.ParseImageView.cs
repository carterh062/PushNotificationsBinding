using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Parse {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.parse']/class[@name='ParseImageView']"
	[global::Android.Runtime.Register ("com/parse/ParseImageView", DoNotGenerateAcw=true)]
	public partial class ParseImageView : global::Android.Widget.ImageView {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/parse/ParseImageView", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ParseImageView); }
		}

		protected ParseImageView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.parse']/class[@name='ParseImageView']/constructor[@name='ParseImageView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public ParseImageView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ParseImageView)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;)V", new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;)V", new JValue (p0), new JValue (p1));
				return;
			}

			if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, new JValue (p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.parse']/class[@name='ParseImageView']/constructor[@name='ParseImageView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public ParseImageView (global::Android.Content.Context p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ParseImageView)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_, new JValue (p0));
		}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.parse']/class[@name='ParseImageView']/constructor[@name='ParseImageView' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public ParseImageView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1, int p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ParseImageView)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", new JValue (p0), new JValue (p1), new JValue (p2)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", new JValue (p0), new JValue (p1), new JValue (p2));
				return;
			}

			if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I == IntPtr.Zero)
				id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, new JValue (p0), new JValue (p1), new JValue (p2)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static Delegate cb_loadInBackground;
#pragma warning disable 0169
		static Delegate GetLoadInBackgroundHandler ()
		{
			if (cb_loadInBackground == null)
				cb_loadInBackground = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_LoadInBackground);
			return cb_loadInBackground;
		}

		static void n_LoadInBackground (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.ParseImageView __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.LoadInBackground ();
		}
#pragma warning restore 0169

		static IntPtr id_loadInBackground;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseImageView']/method[@name='loadInBackground' and count(parameter)=0]"
		[Register ("loadInBackground", "()V", "GetLoadInBackgroundHandler")]
		public virtual void LoadInBackground ()
		{
			if (id_loadInBackground == IntPtr.Zero)
				id_loadInBackground = JNIEnv.GetMethodID (class_ref, "loadInBackground", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_loadInBackground);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "loadInBackground", "()V"));
		}

		static Delegate cb_loadInBackground_Lcom_parse_GetDataCallback_;
#pragma warning disable 0169
		static Delegate GetLoadInBackground_Lcom_parse_GetDataCallback_Handler ()
		{
			if (cb_loadInBackground_Lcom_parse_GetDataCallback_ == null)
				cb_loadInBackground_Lcom_parse_GetDataCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_LoadInBackground_Lcom_parse_GetDataCallback_);
			return cb_loadInBackground_Lcom_parse_GetDataCallback_;
		}

		static void n_LoadInBackground_Lcom_parse_GetDataCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.ParseImageView __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Parse.GetDataCallback p0 = global::Java.Lang.Object.GetObject<global::Com.Parse.GetDataCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LoadInBackground (p0);
		}
#pragma warning restore 0169

		static IntPtr id_loadInBackground_Lcom_parse_GetDataCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseImageView']/method[@name='loadInBackground' and count(parameter)=1 and parameter[1][@type='com.parse.GetDataCallback']]"
		[Register ("loadInBackground", "(Lcom/parse/GetDataCallback;)V", "GetLoadInBackground_Lcom_parse_GetDataCallback_Handler")]
		public virtual void LoadInBackground (global::Com.Parse.GetDataCallback p0)
		{
			if (id_loadInBackground_Lcom_parse_GetDataCallback_ == IntPtr.Zero)
				id_loadInBackground_Lcom_parse_GetDataCallback_ = JNIEnv.GetMethodID (class_ref, "loadInBackground", "(Lcom/parse/GetDataCallback;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_loadInBackground_Lcom_parse_GetDataCallback_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "loadInBackground", "(Lcom/parse/GetDataCallback;)V"), new JValue (p0));
		}

		static Delegate cb_setParseFile_Lcom_parse_ParseFile_;
#pragma warning disable 0169
		static Delegate GetSetParseFile_Lcom_parse_ParseFile_Handler ()
		{
			if (cb_setParseFile_Lcom_parse_ParseFile_ == null)
				cb_setParseFile_Lcom_parse_ParseFile_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetParseFile_Lcom_parse_ParseFile_);
			return cb_setParseFile_Lcom_parse_ParseFile_;
		}

		static void n_SetParseFile_Lcom_parse_ParseFile_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.ParseImageView __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Parse.ParseFile p0 = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseFile> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetParseFile (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setParseFile_Lcom_parse_ParseFile_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseImageView']/method[@name='setParseFile' and count(parameter)=1 and parameter[1][@type='com.parse.ParseFile']]"
		[Register ("setParseFile", "(Lcom/parse/ParseFile;)V", "GetSetParseFile_Lcom_parse_ParseFile_Handler")]
		public virtual void SetParseFile (global::Com.Parse.ParseFile p0)
		{
			if (id_setParseFile_Lcom_parse_ParseFile_ == IntPtr.Zero)
				id_setParseFile_Lcom_parse_ParseFile_ = JNIEnv.GetMethodID (class_ref, "setParseFile", "(Lcom/parse/ParseFile;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setParseFile_Lcom_parse_ParseFile_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setParseFile", "(Lcom/parse/ParseFile;)V"), new JValue (p0));
		}

		static Delegate cb_setPlaceholder_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetSetPlaceholder_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_setPlaceholder_Landroid_graphics_drawable_Drawable_ == null)
				cb_setPlaceholder_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPlaceholder_Landroid_graphics_drawable_Drawable_);
			return cb_setPlaceholder_Landroid_graphics_drawable_Drawable_;
		}

		static void n_SetPlaceholder_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.ParseImageView __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetPlaceholder (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setPlaceholder_Landroid_graphics_drawable_Drawable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseImageView']/method[@name='setPlaceholder' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register ("setPlaceholder", "(Landroid/graphics/drawable/Drawable;)V", "GetSetPlaceholder_Landroid_graphics_drawable_Drawable_Handler")]
		public virtual void SetPlaceholder (global::Android.Graphics.Drawables.Drawable p0)
		{
			if (id_setPlaceholder_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
				id_setPlaceholder_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID (class_ref, "setPlaceholder", "(Landroid/graphics/drawable/Drawable;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setPlaceholder_Landroid_graphics_drawable_Drawable_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPlaceholder", "(Landroid/graphics/drawable/Drawable;)V"), new JValue (p0));
		}

	}
}
