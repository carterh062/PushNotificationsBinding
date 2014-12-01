using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Parse {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.parse']/class[@name='ParseGeoPoint']"
	[global::Android.Runtime.Register ("com/parse/ParseGeoPoint", DoNotGenerateAcw=true)]
	public partial class ParseGeoPoint : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/parse/ParseGeoPoint", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ParseGeoPoint); }
		}

		protected ParseGeoPoint (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.parse']/class[@name='ParseGeoPoint']/constructor[@name='ParseGeoPoint' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public ParseGeoPoint () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ParseGeoPoint)) {
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

		static IntPtr id_ctor_DD;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.parse']/class[@name='ParseGeoPoint']/constructor[@name='ParseGeoPoint' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='double']]"
		[Register (".ctor", "(DD)V", "")]
		public ParseGeoPoint (double p0, double p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ParseGeoPoint)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(DD)V", new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(DD)V", new JValue (p0), new JValue (p1));
				return;
			}

			if (id_ctor_DD == IntPtr.Zero)
				id_ctor_DD = JNIEnv.GetMethodID (class_ref, "<init>", "(DD)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_DD, new JValue (p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_DD, new JValue (p0), new JValue (p1));
		}

		static Delegate cb_getLatitude;
#pragma warning disable 0169
		static Delegate GetGetLatitudeHandler ()
		{
			if (cb_getLatitude == null)
				cb_getLatitude = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetLatitude);
			return cb_getLatitude;
		}

		static double n_GetLatitude (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.ParseGeoPoint __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseGeoPoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Latitude;
		}
#pragma warning restore 0169

		static Delegate cb_setLatitude_D;
#pragma warning disable 0169
		static Delegate GetSetLatitude_DHandler ()
		{
			if (cb_setLatitude_D == null)
				cb_setLatitude_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetLatitude_D);
			return cb_setLatitude_D;
		}

		static void n_SetLatitude_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Com.Parse.ParseGeoPoint __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseGeoPoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Latitude = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getLatitude;
		static IntPtr id_setLatitude_D;
		public virtual double Latitude {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseGeoPoint']/method[@name='getLatitude' and count(parameter)=0]"
			[Register ("getLatitude", "()D", "GetGetLatitudeHandler")]
			get {
				if (id_getLatitude == IntPtr.Zero)
					id_getLatitude = JNIEnv.GetMethodID (class_ref, "getLatitude", "()D");

				if (GetType () == ThresholdType)
					return JNIEnv.CallDoubleMethod  (Handle, id_getLatitude);
				else
					return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLatitude", "()D"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseGeoPoint']/method[@name='setLatitude' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setLatitude", "(D)V", "GetSetLatitude_DHandler")]
			set {
				if (id_setLatitude_D == IntPtr.Zero)
					id_setLatitude_D = JNIEnv.GetMethodID (class_ref, "setLatitude", "(D)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setLatitude_D, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLatitude", "(D)V"), new JValue (value));
			}
		}

		static Delegate cb_getLongitude;
#pragma warning disable 0169
		static Delegate GetGetLongitudeHandler ()
		{
			if (cb_getLongitude == null)
				cb_getLongitude = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetLongitude);
			return cb_getLongitude;
		}

		static double n_GetLongitude (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Parse.ParseGeoPoint __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseGeoPoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Longitude;
		}
#pragma warning restore 0169

		static Delegate cb_setLongitude_D;
#pragma warning disable 0169
		static Delegate GetSetLongitude_DHandler ()
		{
			if (cb_setLongitude_D == null)
				cb_setLongitude_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetLongitude_D);
			return cb_setLongitude_D;
		}

		static void n_SetLongitude_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Com.Parse.ParseGeoPoint __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseGeoPoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Longitude = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getLongitude;
		static IntPtr id_setLongitude_D;
		public virtual double Longitude {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseGeoPoint']/method[@name='getLongitude' and count(parameter)=0]"
			[Register ("getLongitude", "()D", "GetGetLongitudeHandler")]
			get {
				if (id_getLongitude == IntPtr.Zero)
					id_getLongitude = JNIEnv.GetMethodID (class_ref, "getLongitude", "()D");

				if (GetType () == ThresholdType)
					return JNIEnv.CallDoubleMethod  (Handle, id_getLongitude);
				else
					return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLongitude", "()D"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseGeoPoint']/method[@name='setLongitude' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setLongitude", "(D)V", "GetSetLongitude_DHandler")]
			set {
				if (id_setLongitude_D == IntPtr.Zero)
					id_setLongitude_D = JNIEnv.GetMethodID (class_ref, "setLongitude", "(D)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setLongitude_D, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLongitude", "(D)V"), new JValue (value));
			}
		}

		static Delegate cb_distanceInKilometersTo_Lcom_parse_ParseGeoPoint_;
#pragma warning disable 0169
		static Delegate GetDistanceInKilometersTo_Lcom_parse_ParseGeoPoint_Handler ()
		{
			if (cb_distanceInKilometersTo_Lcom_parse_ParseGeoPoint_ == null)
				cb_distanceInKilometersTo_Lcom_parse_ParseGeoPoint_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, double>) n_DistanceInKilometersTo_Lcom_parse_ParseGeoPoint_);
			return cb_distanceInKilometersTo_Lcom_parse_ParseGeoPoint_;
		}

		static double n_DistanceInKilometersTo_Lcom_parse_ParseGeoPoint_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.ParseGeoPoint __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseGeoPoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Parse.ParseGeoPoint p0 = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseGeoPoint> (native_p0, JniHandleOwnership.DoNotTransfer);
			double __ret = __this.DistanceInKilometersTo (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_distanceInKilometersTo_Lcom_parse_ParseGeoPoint_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseGeoPoint']/method[@name='distanceInKilometersTo' and count(parameter)=1 and parameter[1][@type='com.parse.ParseGeoPoint']]"
		[Register ("distanceInKilometersTo", "(Lcom/parse/ParseGeoPoint;)D", "GetDistanceInKilometersTo_Lcom_parse_ParseGeoPoint_Handler")]
		public virtual double DistanceInKilometersTo (global::Com.Parse.ParseGeoPoint p0)
		{
			if (id_distanceInKilometersTo_Lcom_parse_ParseGeoPoint_ == IntPtr.Zero)
				id_distanceInKilometersTo_Lcom_parse_ParseGeoPoint_ = JNIEnv.GetMethodID (class_ref, "distanceInKilometersTo", "(Lcom/parse/ParseGeoPoint;)D");

			double __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallDoubleMethod  (Handle, id_distanceInKilometersTo_Lcom_parse_ParseGeoPoint_, new JValue (p0));
			else
				__ret = JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "distanceInKilometersTo", "(Lcom/parse/ParseGeoPoint;)D"), new JValue (p0));
			return __ret;
		}

		static Delegate cb_distanceInMilesTo_Lcom_parse_ParseGeoPoint_;
#pragma warning disable 0169
		static Delegate GetDistanceInMilesTo_Lcom_parse_ParseGeoPoint_Handler ()
		{
			if (cb_distanceInMilesTo_Lcom_parse_ParseGeoPoint_ == null)
				cb_distanceInMilesTo_Lcom_parse_ParseGeoPoint_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, double>) n_DistanceInMilesTo_Lcom_parse_ParseGeoPoint_);
			return cb_distanceInMilesTo_Lcom_parse_ParseGeoPoint_;
		}

		static double n_DistanceInMilesTo_Lcom_parse_ParseGeoPoint_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.ParseGeoPoint __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseGeoPoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Parse.ParseGeoPoint p0 = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseGeoPoint> (native_p0, JniHandleOwnership.DoNotTransfer);
			double __ret = __this.DistanceInMilesTo (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_distanceInMilesTo_Lcom_parse_ParseGeoPoint_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseGeoPoint']/method[@name='distanceInMilesTo' and count(parameter)=1 and parameter[1][@type='com.parse.ParseGeoPoint']]"
		[Register ("distanceInMilesTo", "(Lcom/parse/ParseGeoPoint;)D", "GetDistanceInMilesTo_Lcom_parse_ParseGeoPoint_Handler")]
		public virtual double DistanceInMilesTo (global::Com.Parse.ParseGeoPoint p0)
		{
			if (id_distanceInMilesTo_Lcom_parse_ParseGeoPoint_ == IntPtr.Zero)
				id_distanceInMilesTo_Lcom_parse_ParseGeoPoint_ = JNIEnv.GetMethodID (class_ref, "distanceInMilesTo", "(Lcom/parse/ParseGeoPoint;)D");

			double __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallDoubleMethod  (Handle, id_distanceInMilesTo_Lcom_parse_ParseGeoPoint_, new JValue (p0));
			else
				__ret = JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "distanceInMilesTo", "(Lcom/parse/ParseGeoPoint;)D"), new JValue (p0));
			return __ret;
		}

		static Delegate cb_distanceInRadiansTo_Lcom_parse_ParseGeoPoint_;
#pragma warning disable 0169
		static Delegate GetDistanceInRadiansTo_Lcom_parse_ParseGeoPoint_Handler ()
		{
			if (cb_distanceInRadiansTo_Lcom_parse_ParseGeoPoint_ == null)
				cb_distanceInRadiansTo_Lcom_parse_ParseGeoPoint_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, double>) n_DistanceInRadiansTo_Lcom_parse_ParseGeoPoint_);
			return cb_distanceInRadiansTo_Lcom_parse_ParseGeoPoint_;
		}

		static double n_DistanceInRadiansTo_Lcom_parse_ParseGeoPoint_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Parse.ParseGeoPoint __this = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseGeoPoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Parse.ParseGeoPoint p0 = global::Java.Lang.Object.GetObject<global::Com.Parse.ParseGeoPoint> (native_p0, JniHandleOwnership.DoNotTransfer);
			double __ret = __this.DistanceInRadiansTo (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_distanceInRadiansTo_Lcom_parse_ParseGeoPoint_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseGeoPoint']/method[@name='distanceInRadiansTo' and count(parameter)=1 and parameter[1][@type='com.parse.ParseGeoPoint']]"
		[Register ("distanceInRadiansTo", "(Lcom/parse/ParseGeoPoint;)D", "GetDistanceInRadiansTo_Lcom_parse_ParseGeoPoint_Handler")]
		public virtual double DistanceInRadiansTo (global::Com.Parse.ParseGeoPoint p0)
		{
			if (id_distanceInRadiansTo_Lcom_parse_ParseGeoPoint_ == IntPtr.Zero)
				id_distanceInRadiansTo_Lcom_parse_ParseGeoPoint_ = JNIEnv.GetMethodID (class_ref, "distanceInRadiansTo", "(Lcom/parse/ParseGeoPoint;)D");

			double __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallDoubleMethod  (Handle, id_distanceInRadiansTo_Lcom_parse_ParseGeoPoint_, new JValue (p0));
			else
				__ret = JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "distanceInRadiansTo", "(Lcom/parse/ParseGeoPoint;)D"), new JValue (p0));
			return __ret;
		}

		static IntPtr id_getCurrentLocationInBackground_JLandroid_location_Criteria_Lcom_parse_LocationCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseGeoPoint']/method[@name='getCurrentLocationInBackground' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='android.location.Criteria'] and parameter[3][@type='com.parse.LocationCallback']]"
		[Register ("getCurrentLocationInBackground", "(JLandroid/location/Criteria;Lcom/parse/LocationCallback;)V", "")]
		public static void GetCurrentLocationInBackground (long p0, global::Android.Locations.Criteria p1, global::Com.Parse.LocationCallback p2)
		{
			if (id_getCurrentLocationInBackground_JLandroid_location_Criteria_Lcom_parse_LocationCallback_ == IntPtr.Zero)
				id_getCurrentLocationInBackground_JLandroid_location_Criteria_Lcom_parse_LocationCallback_ = JNIEnv.GetStaticMethodID (class_ref, "getCurrentLocationInBackground", "(JLandroid/location/Criteria;Lcom/parse/LocationCallback;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_getCurrentLocationInBackground_JLandroid_location_Criteria_Lcom_parse_LocationCallback_, new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static IntPtr id_getCurrentLocationInBackground_JLcom_parse_LocationCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.parse']/class[@name='ParseGeoPoint']/method[@name='getCurrentLocationInBackground' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='com.parse.LocationCallback']]"
		[Register ("getCurrentLocationInBackground", "(JLcom/parse/LocationCallback;)V", "")]
		public static void GetCurrentLocationInBackground (long p0, global::Com.Parse.LocationCallback p1)
		{
			if (id_getCurrentLocationInBackground_JLcom_parse_LocationCallback_ == IntPtr.Zero)
				id_getCurrentLocationInBackground_JLcom_parse_LocationCallback_ = JNIEnv.GetStaticMethodID (class_ref, "getCurrentLocationInBackground", "(JLcom/parse/LocationCallback;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_getCurrentLocationInBackground_JLcom_parse_LocationCallback_, new JValue (p0), new JValue (p1));
		}

	}
}
