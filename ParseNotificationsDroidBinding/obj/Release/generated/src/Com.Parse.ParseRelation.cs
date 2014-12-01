using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Parse {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.parse']/class[@name='ParseRelation']"
	[global::Android.Runtime.Register ("com/parse/ParseRelation", DoNotGenerateAcw=true)]
	public partial class ParseRelation : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/parse/ParseRelation", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ParseRelation); }
		}

		protected ParseRelation (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getQuery;
#pragma warning disable 0169
		static Delegate GetGetQueryHandler ()
		{
			if (cb_getQuery == null)
				cb_getQuery = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetQuery);
			return cb_getQuery;
		}

		static IntPtr n_GetQuery (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.ParseRelation __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseRelation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Query);
		}
#pragma warning restore 0169

		static IntPtr id_getQuery;
		public virtual global::Com.Parse.ParseQuery Query {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseRelation']/method[@name='getQuery' and count(parameter)=0]"
			[Register ("getQuery", "()Lcom/parse/ParseQuery;", "GetGetQueryHandler")]
			get {
				if (id_getQuery == IntPtr.Zero)
					id_getQuery = JNIEnv.GetMethodID (class_ref, "getQuery", "()Lcom/parse/ParseQuery;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (JNIEnv.CallObjectMethod  (Handle, id_getQuery), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Parse.ParseQuery> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getQuery", "()Lcom/parse/ParseQuery;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_add_Lcom_parse_ParseObject_;
#pragma warning disable 0169
		static Delegate GetAdd_Lcom_parse_ParseObject_Handler ()
		{
			if (cb_add_Lcom_parse_ParseObject_ == null)
				cb_add_Lcom_parse_ParseObject_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Add_Lcom_parse_ParseObject_);
			return cb_add_Lcom_parse_ParseObject_;
		}

		static void n_Add_Lcom_parse_ParseObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.ParseRelation __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseRelation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Add (p0);
		}
#pragma warning restore 0169

		static IntPtr id_add_Lcom_parse_ParseObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseRelation']/method[@name='add' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("add", "(Lcom/parse/ParseObject;)V", "GetAdd_Lcom_parse_ParseObject_Handler")]
		public virtual void Add (global::Java.Lang.Object p0)
		{
			if (id_add_Lcom_parse_ParseObject_ == IntPtr.Zero)
				id_add_Lcom_parse_ParseObject_ = JNIEnv.GetMethodID (class_ref, "add", "(Lcom/parse/ParseObject;)V");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_add_Lcom_parse_ParseObject_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "add", "(Lcom/parse/ParseObject;)V"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_remove_Lcom_parse_ParseObject_;
#pragma warning disable 0169
		static Delegate GetRemove_Lcom_parse_ParseObject_Handler ()
		{
			if (cb_remove_Lcom_parse_ParseObject_ == null)
				cb_remove_Lcom_parse_ParseObject_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Remove_Lcom_parse_ParseObject_);
			return cb_remove_Lcom_parse_ParseObject_;
		}

		static void n_Remove_Lcom_parse_ParseObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.ParseRelation __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseRelation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Remove (p0);
		}
#pragma warning restore 0169

		static IntPtr id_remove_Lcom_parse_ParseObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseRelation']/method[@name='remove' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("remove", "(Lcom/parse/ParseObject;)V", "GetRemove_Lcom_parse_ParseObject_Handler")]
		public virtual void Remove (global::Java.Lang.Object p0)
		{
			if (id_remove_Lcom_parse_ParseObject_ == IntPtr.Zero)
				id_remove_Lcom_parse_ParseObject_ = JNIEnv.GetMethodID (class_ref, "remove", "(Lcom/parse/ParseObject;)V");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_remove_Lcom_parse_ParseObject_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "remove", "(Lcom/parse/ParseObject;)V"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}
}
