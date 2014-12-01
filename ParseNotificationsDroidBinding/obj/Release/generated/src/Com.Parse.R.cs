using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Parse {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.parse']/class[@name='R']"
	[global::Android.Runtime.Register ("com/parse/R", DoNotGenerateAcw=true)]
	public sealed partial class R : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.parse']/class[@name='R.attr']"
		[global::Android.Runtime.Register ("com/parse/R$attr", DoNotGenerateAcw=true)]
		public sealed partial class Attr : global::Java.Lang.Object {


			static IntPtr confirm_logout_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.attr']/field[@name='confirm_logout']"
			[Register ("confirm_logout")]
			public static int ConfirmLogout {
				get {
					if (confirm_logout_jfieldId == IntPtr.Zero)
						confirm_logout_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "confirm_logout", "I");
					return JNIEnv.GetStaticIntField (class_ref, confirm_logout_jfieldId);
				}
				set {
					if (confirm_logout_jfieldId == IntPtr.Zero)
						confirm_logout_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "confirm_logout", "I");
					JNIEnv.SetStaticField (class_ref, confirm_logout_jfieldId, value);
				}
			}

			static IntPtr done_button_background_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.attr']/field[@name='done_button_background']"
			[Register ("done_button_background")]
			public static int DoneButtonBackground {
				get {
					if (done_button_background_jfieldId == IntPtr.Zero)
						done_button_background_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "done_button_background", "I");
					return JNIEnv.GetStaticIntField (class_ref, done_button_background_jfieldId);
				}
				set {
					if (done_button_background_jfieldId == IntPtr.Zero)
						done_button_background_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "done_button_background", "I");
					JNIEnv.SetStaticField (class_ref, done_button_background_jfieldId, value);
				}
			}

			static IntPtr done_button_text_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.attr']/field[@name='done_button_text']"
			[Register ("done_button_text")]
			public static int DoneButtonText {
				get {
					if (done_button_text_jfieldId == IntPtr.Zero)
						done_button_text_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "done_button_text", "I");
					return JNIEnv.GetStaticIntField (class_ref, done_button_text_jfieldId);
				}
				set {
					if (done_button_text_jfieldId == IntPtr.Zero)
						done_button_text_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "done_button_text", "I");
					JNIEnv.SetStaticField (class_ref, done_button_text_jfieldId, value);
				}
			}

			static IntPtr extra_fields_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.attr']/field[@name='extra_fields']"
			[Register ("extra_fields")]
			public static int ExtraFields {
				get {
					if (extra_fields_jfieldId == IntPtr.Zero)
						extra_fields_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "extra_fields", "I");
					return JNIEnv.GetStaticIntField (class_ref, extra_fields_jfieldId);
				}
				set {
					if (extra_fields_jfieldId == IntPtr.Zero)
						extra_fields_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "extra_fields", "I");
					JNIEnv.SetStaticField (class_ref, extra_fields_jfieldId, value);
				}
			}

			static IntPtr fetch_user_info_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.attr']/field[@name='fetch_user_info']"
			[Register ("fetch_user_info")]
			public static int FetchUserInfo {
				get {
					if (fetch_user_info_jfieldId == IntPtr.Zero)
						fetch_user_info_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "fetch_user_info", "I");
					return JNIEnv.GetStaticIntField (class_ref, fetch_user_info_jfieldId);
				}
				set {
					if (fetch_user_info_jfieldId == IntPtr.Zero)
						fetch_user_info_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "fetch_user_info", "I");
					JNIEnv.SetStaticField (class_ref, fetch_user_info_jfieldId, value);
				}
			}

			static IntPtr is_cropped_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.attr']/field[@name='is_cropped']"
			[Register ("is_cropped")]
			public static int IsCropped {
				get {
					if (is_cropped_jfieldId == IntPtr.Zero)
						is_cropped_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "is_cropped", "I");
					return JNIEnv.GetStaticIntField (class_ref, is_cropped_jfieldId);
				}
				set {
					if (is_cropped_jfieldId == IntPtr.Zero)
						is_cropped_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "is_cropped", "I");
					JNIEnv.SetStaticField (class_ref, is_cropped_jfieldId, value);
				}
			}

			static IntPtr login_text_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.attr']/field[@name='login_text']"
			[Register ("login_text")]
			public static int LoginText {
				get {
					if (login_text_jfieldId == IntPtr.Zero)
						login_text_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "login_text", "I");
					return JNIEnv.GetStaticIntField (class_ref, login_text_jfieldId);
				}
				set {
					if (login_text_jfieldId == IntPtr.Zero)
						login_text_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "login_text", "I");
					JNIEnv.SetStaticField (class_ref, login_text_jfieldId, value);
				}
			}

			static IntPtr logout_text_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.attr']/field[@name='logout_text']"
			[Register ("logout_text")]
			public static int LogoutText {
				get {
					if (logout_text_jfieldId == IntPtr.Zero)
						logout_text_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "logout_text", "I");
					return JNIEnv.GetStaticIntField (class_ref, logout_text_jfieldId);
				}
				set {
					if (logout_text_jfieldId == IntPtr.Zero)
						logout_text_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "logout_text", "I");
					JNIEnv.SetStaticField (class_ref, logout_text_jfieldId, value);
				}
			}

			static IntPtr multi_select_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.attr']/field[@name='multi_select']"
			[Register ("multi_select")]
			public static int MultiSelect {
				get {
					if (multi_select_jfieldId == IntPtr.Zero)
						multi_select_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "multi_select", "I");
					return JNIEnv.GetStaticIntField (class_ref, multi_select_jfieldId);
				}
				set {
					if (multi_select_jfieldId == IntPtr.Zero)
						multi_select_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "multi_select", "I");
					JNIEnv.SetStaticField (class_ref, multi_select_jfieldId, value);
				}
			}

			static IntPtr preset_size_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.attr']/field[@name='preset_size']"
			[Register ("preset_size")]
			public static int PresetSize {
				get {
					if (preset_size_jfieldId == IntPtr.Zero)
						preset_size_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "preset_size", "I");
					return JNIEnv.GetStaticIntField (class_ref, preset_size_jfieldId);
				}
				set {
					if (preset_size_jfieldId == IntPtr.Zero)
						preset_size_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "preset_size", "I");
					JNIEnv.SetStaticField (class_ref, preset_size_jfieldId, value);
				}
			}

			static IntPtr radius_in_meters_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.attr']/field[@name='radius_in_meters']"
			[Register ("radius_in_meters")]
			public static int RadiusInMeters {
				get {
					if (radius_in_meters_jfieldId == IntPtr.Zero)
						radius_in_meters_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "radius_in_meters", "I");
					return JNIEnv.GetStaticIntField (class_ref, radius_in_meters_jfieldId);
				}
				set {
					if (radius_in_meters_jfieldId == IntPtr.Zero)
						radius_in_meters_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "radius_in_meters", "I");
					JNIEnv.SetStaticField (class_ref, radius_in_meters_jfieldId, value);
				}
			}

			static IntPtr results_limit_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.attr']/field[@name='results_limit']"
			[Register ("results_limit")]
			public static int ResultsLimit {
				get {
					if (results_limit_jfieldId == IntPtr.Zero)
						results_limit_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "results_limit", "I");
					return JNIEnv.GetStaticIntField (class_ref, results_limit_jfieldId);
				}
				set {
					if (results_limit_jfieldId == IntPtr.Zero)
						results_limit_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "results_limit", "I");
					JNIEnv.SetStaticField (class_ref, results_limit_jfieldId, value);
				}
			}

			static IntPtr search_text_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.attr']/field[@name='search_text']"
			[Register ("search_text")]
			public static int SearchText {
				get {
					if (search_text_jfieldId == IntPtr.Zero)
						search_text_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "search_text", "I");
					return JNIEnv.GetStaticIntField (class_ref, search_text_jfieldId);
				}
				set {
					if (search_text_jfieldId == IntPtr.Zero)
						search_text_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "search_text", "I");
					JNIEnv.SetStaticField (class_ref, search_text_jfieldId, value);
				}
			}

			static IntPtr show_pictures_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.attr']/field[@name='show_pictures']"
			[Register ("show_pictures")]
			public static int ShowPictures {
				get {
					if (show_pictures_jfieldId == IntPtr.Zero)
						show_pictures_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "show_pictures", "I");
					return JNIEnv.GetStaticIntField (class_ref, show_pictures_jfieldId);
				}
				set {
					if (show_pictures_jfieldId == IntPtr.Zero)
						show_pictures_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "show_pictures", "I");
					JNIEnv.SetStaticField (class_ref, show_pictures_jfieldId, value);
				}
			}

			static IntPtr show_search_box_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.attr']/field[@name='show_search_box']"
			[Register ("show_search_box")]
			public static int ShowSearchBox {
				get {
					if (show_search_box_jfieldId == IntPtr.Zero)
						show_search_box_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "show_search_box", "I");
					return JNIEnv.GetStaticIntField (class_ref, show_search_box_jfieldId);
				}
				set {
					if (show_search_box_jfieldId == IntPtr.Zero)
						show_search_box_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "show_search_box", "I");
					JNIEnv.SetStaticField (class_ref, show_search_box_jfieldId, value);
				}
			}

			static IntPtr show_title_bar_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.attr']/field[@name='show_title_bar']"
			[Register ("show_title_bar")]
			public static int ShowTitleBar {
				get {
					if (show_title_bar_jfieldId == IntPtr.Zero)
						show_title_bar_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "show_title_bar", "I");
					return JNIEnv.GetStaticIntField (class_ref, show_title_bar_jfieldId);
				}
				set {
					if (show_title_bar_jfieldId == IntPtr.Zero)
						show_title_bar_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "show_title_bar", "I");
					JNIEnv.SetStaticField (class_ref, show_title_bar_jfieldId, value);
				}
			}

			static IntPtr title_bar_background_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.attr']/field[@name='title_bar_background']"
			[Register ("title_bar_background")]
			public static int TitleBarBackground {
				get {
					if (title_bar_background_jfieldId == IntPtr.Zero)
						title_bar_background_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "title_bar_background", "I");
					return JNIEnv.GetStaticIntField (class_ref, title_bar_background_jfieldId);
				}
				set {
					if (title_bar_background_jfieldId == IntPtr.Zero)
						title_bar_background_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "title_bar_background", "I");
					JNIEnv.SetStaticField (class_ref, title_bar_background_jfieldId, value);
				}
			}

			static IntPtr title_text_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.attr']/field[@name='title_text']"
			[Register ("title_text")]
			public static int TitleText {
				get {
					if (title_text_jfieldId == IntPtr.Zero)
						title_text_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "title_text", "I");
					return JNIEnv.GetStaticIntField (class_ref, title_text_jfieldId);
				}
				set {
					if (title_text_jfieldId == IntPtr.Zero)
						title_text_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "title_text", "I");
					JNIEnv.SetStaticField (class_ref, title_text_jfieldId, value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/parse/R$attr", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Attr); }
			}

			internal Attr (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.parse']/class[@name='R.attr']/constructor[@name='R.attr' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public Attr () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (Attr)) {
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

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.parse']/class[@name='R.color']"
		[global::Android.Runtime.Register ("com/parse/R$color", DoNotGenerateAcw=true)]
		public sealed partial class Color : global::Java.Lang.Object {


			static IntPtr com_facebook_blue_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.color']/field[@name='com_facebook_blue']"
			[Register ("com_facebook_blue")]
			public static int ComFacebookBlue {
				get {
					if (com_facebook_blue_jfieldId == IntPtr.Zero)
						com_facebook_blue_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_blue", "I");
					return JNIEnv.GetStaticIntField (class_ref, com_facebook_blue_jfieldId);
				}
				set {
					if (com_facebook_blue_jfieldId == IntPtr.Zero)
						com_facebook_blue_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_blue", "I");
					JNIEnv.SetStaticField (class_ref, com_facebook_blue_jfieldId, value);
				}
			}

			static IntPtr com_facebook_loginview_text_color_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.color']/field[@name='com_facebook_loginview_text_color']"
			[Register ("com_facebook_loginview_text_color")]
			public static int ComFacebookLoginviewTextColor {
				get {
					if (com_facebook_loginview_text_color_jfieldId == IntPtr.Zero)
						com_facebook_loginview_text_color_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_loginview_text_color", "I");
					return JNIEnv.GetStaticIntField (class_ref, com_facebook_loginview_text_color_jfieldId);
				}
				set {
					if (com_facebook_loginview_text_color_jfieldId == IntPtr.Zero)
						com_facebook_loginview_text_color_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_loginview_text_color", "I");
					JNIEnv.SetStaticField (class_ref, com_facebook_loginview_text_color_jfieldId, value);
				}
			}

			static IntPtr com_facebook_picker_search_bar_background_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.color']/field[@name='com_facebook_picker_search_bar_background']"
			[Register ("com_facebook_picker_search_bar_background")]
			public static int ComFacebookPickerSearchBarBackground {
				get {
					if (com_facebook_picker_search_bar_background_jfieldId == IntPtr.Zero)
						com_facebook_picker_search_bar_background_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_picker_search_bar_background", "I");
					return JNIEnv.GetStaticIntField (class_ref, com_facebook_picker_search_bar_background_jfieldId);
				}
				set {
					if (com_facebook_picker_search_bar_background_jfieldId == IntPtr.Zero)
						com_facebook_picker_search_bar_background_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_picker_search_bar_background", "I");
					JNIEnv.SetStaticField (class_ref, com_facebook_picker_search_bar_background_jfieldId, value);
				}
			}

			static IntPtr com_facebook_picker_search_bar_text_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.color']/field[@name='com_facebook_picker_search_bar_text']"
			[Register ("com_facebook_picker_search_bar_text")]
			public static int ComFacebookPickerSearchBarText {
				get {
					if (com_facebook_picker_search_bar_text_jfieldId == IntPtr.Zero)
						com_facebook_picker_search_bar_text_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_picker_search_bar_text", "I");
					return JNIEnv.GetStaticIntField (class_ref, com_facebook_picker_search_bar_text_jfieldId);
				}
				set {
					if (com_facebook_picker_search_bar_text_jfieldId == IntPtr.Zero)
						com_facebook_picker_search_bar_text_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_picker_search_bar_text", "I");
					JNIEnv.SetStaticField (class_ref, com_facebook_picker_search_bar_text_jfieldId, value);
				}
			}

			static IntPtr com_facebook_usersettingsfragment_connected_shadow_color_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.color']/field[@name='com_facebook_usersettingsfragment_connected_shadow_color']"
			[Register ("com_facebook_usersettingsfragment_connected_shadow_color")]
			public static int ComFacebookUsersettingsfragmentConnectedShadowColor {
				get {
					if (com_facebook_usersettingsfragment_connected_shadow_color_jfieldId == IntPtr.Zero)
						com_facebook_usersettingsfragment_connected_shadow_color_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_usersettingsfragment_connected_shadow_color", "I");
					return JNIEnv.GetStaticIntField (class_ref, com_facebook_usersettingsfragment_connected_shadow_color_jfieldId);
				}
				set {
					if (com_facebook_usersettingsfragment_connected_shadow_color_jfieldId == IntPtr.Zero)
						com_facebook_usersettingsfragment_connected_shadow_color_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_usersettingsfragment_connected_shadow_color", "I");
					JNIEnv.SetStaticField (class_ref, com_facebook_usersettingsfragment_connected_shadow_color_jfieldId, value);
				}
			}

			static IntPtr com_facebook_usersettingsfragment_connected_text_color_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.color']/field[@name='com_facebook_usersettingsfragment_connected_text_color']"
			[Register ("com_facebook_usersettingsfragment_connected_text_color")]
			public static int ComFacebookUsersettingsfragmentConnectedTextColor {
				get {
					if (com_facebook_usersettingsfragment_connected_text_color_jfieldId == IntPtr.Zero)
						com_facebook_usersettingsfragment_connected_text_color_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_usersettingsfragment_connected_text_color", "I");
					return JNIEnv.GetStaticIntField (class_ref, com_facebook_usersettingsfragment_connected_text_color_jfieldId);
				}
				set {
					if (com_facebook_usersettingsfragment_connected_text_color_jfieldId == IntPtr.Zero)
						com_facebook_usersettingsfragment_connected_text_color_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_usersettingsfragment_connected_text_color", "I");
					JNIEnv.SetStaticField (class_ref, com_facebook_usersettingsfragment_connected_text_color_jfieldId, value);
				}
			}

			static IntPtr com_facebook_usersettingsfragment_not_connected_text_color_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.color']/field[@name='com_facebook_usersettingsfragment_not_connected_text_color']"
			[Register ("com_facebook_usersettingsfragment_not_connected_text_color")]
			public static int ComFacebookUsersettingsfragmentNotConnectedTextColor {
				get {
					if (com_facebook_usersettingsfragment_not_connected_text_color_jfieldId == IntPtr.Zero)
						com_facebook_usersettingsfragment_not_connected_text_color_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_usersettingsfragment_not_connected_text_color", "I");
					return JNIEnv.GetStaticIntField (class_ref, com_facebook_usersettingsfragment_not_connected_text_color_jfieldId);
				}
				set {
					if (com_facebook_usersettingsfragment_not_connected_text_color_jfieldId == IntPtr.Zero)
						com_facebook_usersettingsfragment_not_connected_text_color_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_usersettingsfragment_not_connected_text_color", "I");
					JNIEnv.SetStaticField (class_ref, com_facebook_usersettingsfragment_not_connected_text_color_jfieldId, value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/parse/R$color", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Color); }
			}

			internal Color (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.parse']/class[@name='R.color']/constructor[@name='R.color' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public Color () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (Color)) {
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

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.parse']/class[@name='R.dimen']"
		[global::Android.Runtime.Register ("com/parse/R$dimen", DoNotGenerateAcw=true)]
		public sealed partial class Dimen : global::Java.Lang.Object {


			static IntPtr com_facebook_loginview_compound_drawable_padding_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.dimen']/field[@name='com_facebook_loginview_compound_drawable_padding']"
			[Register ("com_facebook_loginview_compound_drawable_padding")]
			public static int ComFacebookLoginviewCompoundDrawablePadding {
				get {
					if (com_facebook_loginview_compound_drawable_padding_jfieldId == IntPtr.Zero)
						com_facebook_loginview_compound_drawable_padding_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_loginview_compound_drawable_padding", "I");
					return JNIEnv.GetStaticIntField (class_ref, com_facebook_loginview_compound_drawable_padding_jfieldId);
				}
				set {
					if (com_facebook_loginview_compound_drawable_padding_jfieldId == IntPtr.Zero)
						com_facebook_loginview_compound_drawable_padding_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_loginview_compound_drawable_padding", "I");
					JNIEnv.SetStaticField (class_ref, com_facebook_loginview_compound_drawable_padding_jfieldId, value);
				}
			}

			static IntPtr com_facebook_loginview_padding_bottom_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.dimen']/field[@name='com_facebook_loginview_padding_bottom']"
			[Register ("com_facebook_loginview_padding_bottom")]
			public static int ComFacebookLoginviewPaddingBottom {
				get {
					if (com_facebook_loginview_padding_bottom_jfieldId == IntPtr.Zero)
						com_facebook_loginview_padding_bottom_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_loginview_padding_bottom", "I");
					return JNIEnv.GetStaticIntField (class_ref, com_facebook_loginview_padding_bottom_jfieldId);
				}
				set {
					if (com_facebook_loginview_padding_bottom_jfieldId == IntPtr.Zero)
						com_facebook_loginview_padding_bottom_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_loginview_padding_bottom", "I");
					JNIEnv.SetStaticField (class_ref, com_facebook_loginview_padding_bottom_jfieldId, value);
				}
			}

			static IntPtr com_facebook_loginview_padding_left_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.dimen']/field[@name='com_facebook_loginview_padding_left']"
			[Register ("com_facebook_loginview_padding_left")]
			public static int ComFacebookLoginviewPaddingLeft {
				get {
					if (com_facebook_loginview_padding_left_jfieldId == IntPtr.Zero)
						com_facebook_loginview_padding_left_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_loginview_padding_left", "I");
					return JNIEnv.GetStaticIntField (class_ref, com_facebook_loginview_padding_left_jfieldId);
				}
				set {
					if (com_facebook_loginview_padding_left_jfieldId == IntPtr.Zero)
						com_facebook_loginview_padding_left_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_loginview_padding_left", "I");
					JNIEnv.SetStaticField (class_ref, com_facebook_loginview_padding_left_jfieldId, value);
				}
			}

			static IntPtr com_facebook_loginview_padding_right_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.dimen']/field[@name='com_facebook_loginview_padding_right']"
			[Register ("com_facebook_loginview_padding_right")]
			public static int ComFacebookLoginviewPaddingRight {
				get {
					if (com_facebook_loginview_padding_right_jfieldId == IntPtr.Zero)
						com_facebook_loginview_padding_right_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_loginview_padding_right", "I");
					return JNIEnv.GetStaticIntField (class_ref, com_facebook_loginview_padding_right_jfieldId);
				}
				set {
					if (com_facebook_loginview_padding_right_jfieldId == IntPtr.Zero)
						com_facebook_loginview_padding_right_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_loginview_padding_right", "I");
					JNIEnv.SetStaticField (class_ref, com_facebook_loginview_padding_right_jfieldId, value);
				}
			}

			static IntPtr com_facebook_loginview_padding_top_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.dimen']/field[@name='com_facebook_loginview_padding_top']"
			[Register ("com_facebook_loginview_padding_top")]
			public static int ComFacebookLoginviewPaddingTop {
				get {
					if (com_facebook_loginview_padding_top_jfieldId == IntPtr.Zero)
						com_facebook_loginview_padding_top_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_loginview_padding_top", "I");
					return JNIEnv.GetStaticIntField (class_ref, com_facebook_loginview_padding_top_jfieldId);
				}
				set {
					if (com_facebook_loginview_padding_top_jfieldId == IntPtr.Zero)
						com_facebook_loginview_padding_top_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_loginview_padding_top", "I");
					JNIEnv.SetStaticField (class_ref, com_facebook_loginview_padding_top_jfieldId, value);
				}
			}

			static IntPtr com_facebook_loginview_text_size_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.dimen']/field[@name='com_facebook_loginview_text_size']"
			[Register ("com_facebook_loginview_text_size")]
			public static int ComFacebookLoginviewTextSize {
				get {
					if (com_facebook_loginview_text_size_jfieldId == IntPtr.Zero)
						com_facebook_loginview_text_size_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_loginview_text_size", "I");
					return JNIEnv.GetStaticIntField (class_ref, com_facebook_loginview_text_size_jfieldId);
				}
				set {
					if (com_facebook_loginview_text_size_jfieldId == IntPtr.Zero)
						com_facebook_loginview_text_size_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_loginview_text_size", "I");
					JNIEnv.SetStaticField (class_ref, com_facebook_loginview_text_size_jfieldId, value);
				}
			}

			static IntPtr com_facebook_picker_divider_width_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.dimen']/field[@name='com_facebook_picker_divider_width']"
			[Register ("com_facebook_picker_divider_width")]
			public static int ComFacebookPickerDividerWidth {
				get {
					if (com_facebook_picker_divider_width_jfieldId == IntPtr.Zero)
						com_facebook_picker_divider_width_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_picker_divider_width", "I");
					return JNIEnv.GetStaticIntField (class_ref, com_facebook_picker_divider_width_jfieldId);
				}
				set {
					if (com_facebook_picker_divider_width_jfieldId == IntPtr.Zero)
						com_facebook_picker_divider_width_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_picker_divider_width", "I");
					JNIEnv.SetStaticField (class_ref, com_facebook_picker_divider_width_jfieldId, value);
				}
			}

			static IntPtr com_facebook_picker_place_image_size_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.dimen']/field[@name='com_facebook_picker_place_image_size']"
			[Register ("com_facebook_picker_place_image_size")]
			public static int ComFacebookPickerPlaceImageSize {
				get {
					if (com_facebook_picker_place_image_size_jfieldId == IntPtr.Zero)
						com_facebook_picker_place_image_size_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_picker_place_image_size", "I");
					return JNIEnv.GetStaticIntField (class_ref, com_facebook_picker_place_image_size_jfieldId);
				}
				set {
					if (com_facebook_picker_place_image_size_jfieldId == IntPtr.Zero)
						com_facebook_picker_place_image_size_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_picker_place_image_size", "I");
					JNIEnv.SetStaticField (class_ref, com_facebook_picker_place_image_size_jfieldId, value);
				}
			}

			static IntPtr com_facebook_profilepictureview_preset_size_large_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.dimen']/field[@name='com_facebook_profilepictureview_preset_size_large']"
			[Register ("com_facebook_profilepictureview_preset_size_large")]
			public static int ComFacebookProfilepictureviewPresetSizeLarge {
				get {
					if (com_facebook_profilepictureview_preset_size_large_jfieldId == IntPtr.Zero)
						com_facebook_profilepictureview_preset_size_large_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_profilepictureview_preset_size_large", "I");
					return JNIEnv.GetStaticIntField (class_ref, com_facebook_profilepictureview_preset_size_large_jfieldId);
				}
				set {
					if (com_facebook_profilepictureview_preset_size_large_jfieldId == IntPtr.Zero)
						com_facebook_profilepictureview_preset_size_large_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_profilepictureview_preset_size_large", "I");
					JNIEnv.SetStaticField (class_ref, com_facebook_profilepictureview_preset_size_large_jfieldId, value);
				}
			}

			static IntPtr com_facebook_profilepictureview_preset_size_normal_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.dimen']/field[@name='com_facebook_profilepictureview_preset_size_normal']"
			[Register ("com_facebook_profilepictureview_preset_size_normal")]
			public static int ComFacebookProfilepictureviewPresetSizeNormal {
				get {
					if (com_facebook_profilepictureview_preset_size_normal_jfieldId == IntPtr.Zero)
						com_facebook_profilepictureview_preset_size_normal_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_profilepictureview_preset_size_normal", "I");
					return JNIEnv.GetStaticIntField (class_ref, com_facebook_profilepictureview_preset_size_normal_jfieldId);
				}
				set {
					if (com_facebook_profilepictureview_preset_size_normal_jfieldId == IntPtr.Zero)
						com_facebook_profilepictureview_preset_size_normal_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_profilepictureview_preset_size_normal", "I");
					JNIEnv.SetStaticField (class_ref, com_facebook_profilepictureview_preset_size_normal_jfieldId, value);
				}
			}

			static IntPtr com_facebook_profilepictureview_preset_size_small_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.dimen']/field[@name='com_facebook_profilepictureview_preset_size_small']"
			[Register ("com_facebook_profilepictureview_preset_size_small")]
			public static int ComFacebookProfilepictureviewPresetSizeSmall {
				get {
					if (com_facebook_profilepictureview_preset_size_small_jfieldId == IntPtr.Zero)
						com_facebook_profilepictureview_preset_size_small_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_profilepictureview_preset_size_small", "I");
					return JNIEnv.GetStaticIntField (class_ref, com_facebook_profilepictureview_preset_size_small_jfieldId);
				}
				set {
					if (com_facebook_profilepictureview_preset_size_small_jfieldId == IntPtr.Zero)
						com_facebook_profilepictureview_preset_size_small_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_profilepictureview_preset_size_small", "I");
					JNIEnv.SetStaticField (class_ref, com_facebook_profilepictureview_preset_size_small_jfieldId, value);
				}
			}

			static IntPtr com_facebook_usersettingsfragment_profile_picture_height_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.dimen']/field[@name='com_facebook_usersettingsfragment_profile_picture_height']"
			[Register ("com_facebook_usersettingsfragment_profile_picture_height")]
			public static int ComFacebookUsersettingsfragmentProfilePictureHeight {
				get {
					if (com_facebook_usersettingsfragment_profile_picture_height_jfieldId == IntPtr.Zero)
						com_facebook_usersettingsfragment_profile_picture_height_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_usersettingsfragment_profile_picture_height", "I");
					return JNIEnv.GetStaticIntField (class_ref, com_facebook_usersettingsfragment_profile_picture_height_jfieldId);
				}
				set {
					if (com_facebook_usersettingsfragment_profile_picture_height_jfieldId == IntPtr.Zero)
						com_facebook_usersettingsfragment_profile_picture_height_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_usersettingsfragment_profile_picture_height", "I");
					JNIEnv.SetStaticField (class_ref, com_facebook_usersettingsfragment_profile_picture_height_jfieldId, value);
				}
			}

			static IntPtr com_facebook_usersettingsfragment_profile_picture_width_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.dimen']/field[@name='com_facebook_usersettingsfragment_profile_picture_width']"
			[Register ("com_facebook_usersettingsfragment_profile_picture_width")]
			public static int ComFacebookUsersettingsfragmentProfilePictureWidth {
				get {
					if (com_facebook_usersettingsfragment_profile_picture_width_jfieldId == IntPtr.Zero)
						com_facebook_usersettingsfragment_profile_picture_width_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_usersettingsfragment_profile_picture_width", "I");
					return JNIEnv.GetStaticIntField (class_ref, com_facebook_usersettingsfragment_profile_picture_width_jfieldId);
				}
				set {
					if (com_facebook_usersettingsfragment_profile_picture_width_jfieldId == IntPtr.Zero)
						com_facebook_usersettingsfragment_profile_picture_width_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_usersettingsfragment_profile_picture_width", "I");
					JNIEnv.SetStaticField (class_ref, com_facebook_usersettingsfragment_profile_picture_width_jfieldId, value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/parse/R$dimen", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Dimen); }
			}

			internal Dimen (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.parse']/class[@name='R.dimen']/constructor[@name='R.dimen' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public Dimen () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (Dimen)) {
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

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.parse']/class[@name='R.drawable']"
		[global::Android.Runtime.Register ("com/parse/R$drawable", DoNotGenerateAcw=true)]
		public sealed partial class Drawable : global::Java.Lang.Object {


			static IntPtr com_facebook_button_blue_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.drawable']/field[@name='com_facebook_button_blue']"
			[Register ("com_facebook_button_blue")]
			public static int ComFacebookButtonBlue {
				get {
					if (com_facebook_button_blue_jfieldId == IntPtr.Zero)
						com_facebook_button_blue_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_button_blue", "I");
					return JNIEnv.GetStaticIntField (class_ref, com_facebook_button_blue_jfieldId);
				}
				set {
					if (com_facebook_button_blue_jfieldId == IntPtr.Zero)
						com_facebook_button_blue_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_button_blue", "I");
					JNIEnv.SetStaticField (class_ref, com_facebook_button_blue_jfieldId, value);
				}
			}

			static IntPtr com_facebook_button_blue_focused_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.drawable']/field[@name='com_facebook_button_blue_focused']"
			[Register ("com_facebook_button_blue_focused")]
			public static int ComFacebookButtonBlueFocused {
				get {
					if (com_facebook_button_blue_focused_jfieldId == IntPtr.Zero)
						com_facebook_button_blue_focused_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_button_blue_focused", "I");
					return JNIEnv.GetStaticIntField (class_ref, com_facebook_button_blue_focused_jfieldId);
				}
				set {
					if (com_facebook_button_blue_focused_jfieldId == IntPtr.Zero)
						com_facebook_button_blue_focused_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_button_blue_focused", "I");
					JNIEnv.SetStaticField (class_ref, com_facebook_button_blue_focused_jfieldId, value);
				}
			}

			static IntPtr com_facebook_button_blue_normal_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.drawable']/field[@name='com_facebook_button_blue_normal']"
			[Register ("com_facebook_button_blue_normal")]
			public static int ComFacebookButtonBlueNormal {
				get {
					if (com_facebook_button_blue_normal_jfieldId == IntPtr.Zero)
						com_facebook_button_blue_normal_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_button_blue_normal", "I");
					return JNIEnv.GetStaticIntField (class_ref, com_facebook_button_blue_normal_jfieldId);
				}
				set {
					if (com_facebook_button_blue_normal_jfieldId == IntPtr.Zero)
						com_facebook_button_blue_normal_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_button_blue_normal", "I");
					JNIEnv.SetStaticField (class_ref, com_facebook_button_blue_normal_jfieldId, value);
				}
			}

			static IntPtr com_facebook_button_blue_pressed_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.drawable']/field[@name='com_facebook_button_blue_pressed']"
			[Register ("com_facebook_button_blue_pressed")]
			public static int ComFacebookButtonBluePressed {
				get {
					if (com_facebook_button_blue_pressed_jfieldId == IntPtr.Zero)
						com_facebook_button_blue_pressed_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_button_blue_pressed", "I");
					return JNIEnv.GetStaticIntField (class_ref, com_facebook_button_blue_pressed_jfieldId);
				}
				set {
					if (com_facebook_button_blue_pressed_jfieldId == IntPtr.Zero)
						com_facebook_button_blue_pressed_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_button_blue_pressed", "I");
					JNIEnv.SetStaticField (class_ref, com_facebook_button_blue_pressed_jfieldId, value);
				}
			}

			static IntPtr com_facebook_button_check_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.drawable']/field[@name='com_facebook_button_check']"
			[Register ("com_facebook_button_check")]
			public static int ComFacebookButtonCheck {
				get {
					if (com_facebook_button_check_jfieldId == IntPtr.Zero)
						com_facebook_button_check_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_button_check", "I");
					return JNIEnv.GetStaticIntField (class_ref, com_facebook_button_check_jfieldId);
				}
				set {
					if (com_facebook_button_check_jfieldId == IntPtr.Zero)
						com_facebook_button_check_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_button_check", "I");
					JNIEnv.SetStaticField (class_ref, com_facebook_button_check_jfieldId, value);
				}
			}

			static IntPtr com_facebook_button_check_off_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.drawable']/field[@name='com_facebook_button_check_off']"
			[Register ("com_facebook_button_check_off")]
			public static int ComFacebookButtonCheckOff {
				get {
					if (com_facebook_button_check_off_jfieldId == IntPtr.Zero)
						com_facebook_button_check_off_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_button_check_off", "I");
					return JNIEnv.GetStaticIntField (class_ref, com_facebook_button_check_off_jfieldId);
				}
				set {
					if (com_facebook_button_check_off_jfieldId == IntPtr.Zero)
						com_facebook_button_check_off_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_button_check_off", "I");
					JNIEnv.SetStaticField (class_ref, com_facebook_button_check_off_jfieldId, value);
				}
			}

			static IntPtr com_facebook_button_check_on_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.drawable']/field[@name='com_facebook_button_check_on']"
			[Register ("com_facebook_button_check_on")]
			public static int ComFacebookButtonCheckOn {
				get {
					if (com_facebook_button_check_on_jfieldId == IntPtr.Zero)
						com_facebook_button_check_on_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_button_check_on", "I");
					return JNIEnv.GetStaticIntField (class_ref, com_facebook_button_check_on_jfieldId);
				}
				set {
					if (com_facebook_button_check_on_jfieldId == IntPtr.Zero)
						com_facebook_button_check_on_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_button_check_on", "I");
					JNIEnv.SetStaticField (class_ref, com_facebook_button_check_on_jfieldId, value);
				}
			}

			static IntPtr com_facebook_button_grey_focused_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.drawable']/field[@name='com_facebook_button_grey_focused']"
			[Register ("com_facebook_button_grey_focused")]
			public static int ComFacebookButtonGreyFocused {
				get {
					if (com_facebook_button_grey_focused_jfieldId == IntPtr.Zero)
						com_facebook_button_grey_focused_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_button_grey_focused", "I");
					return JNIEnv.GetStaticIntField (class_ref, com_facebook_button_grey_focused_jfieldId);
				}
				set {
					if (com_facebook_button_grey_focused_jfieldId == IntPtr.Zero)
						com_facebook_button_grey_focused_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_button_grey_focused", "I");
					JNIEnv.SetStaticField (class_ref, com_facebook_button_grey_focused_jfieldId, value);
				}
			}

			static IntPtr com_facebook_button_grey_normal_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.drawable']/field[@name='com_facebook_button_grey_normal']"
			[Register ("com_facebook_button_grey_normal")]
			public static int ComFacebookButtonGreyNormal {
				get {
					if (com_facebook_button_grey_normal_jfieldId == IntPtr.Zero)
						com_facebook_button_grey_normal_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_button_grey_normal", "I");
					return JNIEnv.GetStaticIntField (class_ref, com_facebook_button_grey_normal_jfieldId);
				}
				set {
					if (com_facebook_button_grey_normal_jfieldId == IntPtr.Zero)
						com_facebook_button_grey_normal_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_button_grey_normal", "I");
					JNIEnv.SetStaticField (class_ref, com_facebook_button_grey_normal_jfieldId, value);
				}
			}

			static IntPtr com_facebook_button_grey_pressed_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.drawable']/field[@name='com_facebook_button_grey_pressed']"
			[Register ("com_facebook_button_grey_pressed")]
			public static int ComFacebookButtonGreyPressed {
				get {
					if (com_facebook_button_grey_pressed_jfieldId == IntPtr.Zero)
						com_facebook_button_grey_pressed_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_button_grey_pressed", "I");
					return JNIEnv.GetStaticIntField (class_ref, com_facebook_button_grey_pressed_jfieldId);
				}
				set {
					if (com_facebook_button_grey_pressed_jfieldId == IntPtr.Zero)
						com_facebook_button_grey_pressed_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_button_grey_pressed", "I");
					JNIEnv.SetStaticField (class_ref, com_facebook_button_grey_pressed_jfieldId, value);
				}
			}

			static IntPtr com_facebook_close_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.drawable']/field[@name='com_facebook_close']"
			[Register ("com_facebook_close")]
			public static int ComFacebookClose {
				get {
					if (com_facebook_close_jfieldId == IntPtr.Zero)
						com_facebook_close_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_close", "I");
					return JNIEnv.GetStaticIntField (class_ref, com_facebook_close_jfieldId);
				}
				set {
					if (com_facebook_close_jfieldId == IntPtr.Zero)
						com_facebook_close_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_close", "I");
					JNIEnv.SetStaticField (class_ref, com_facebook_close_jfieldId, value);
				}
			}

			static IntPtr com_facebook_inverse_icon_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.drawable']/field[@name='com_facebook_inverse_icon']"
			[Register ("com_facebook_inverse_icon")]
			public static int ComFacebookInverseIcon {
				get {
					if (com_facebook_inverse_icon_jfieldId == IntPtr.Zero)
						com_facebook_inverse_icon_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_inverse_icon", "I");
					return JNIEnv.GetStaticIntField (class_ref, com_facebook_inverse_icon_jfieldId);
				}
				set {
					if (com_facebook_inverse_icon_jfieldId == IntPtr.Zero)
						com_facebook_inverse_icon_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_inverse_icon", "I");
					JNIEnv.SetStaticField (class_ref, com_facebook_inverse_icon_jfieldId, value);
				}
			}

			static IntPtr com_facebook_list_divider_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.drawable']/field[@name='com_facebook_list_divider']"
			[Register ("com_facebook_list_divider")]
			public static int ComFacebookListDivider {
				get {
					if (com_facebook_list_divider_jfieldId == IntPtr.Zero)
						com_facebook_list_divider_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_list_divider", "I");
					return JNIEnv.GetStaticIntField (class_ref, com_facebook_list_divider_jfieldId);
				}
				set {
					if (com_facebook_list_divider_jfieldId == IntPtr.Zero)
						com_facebook_list_divider_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_list_divider", "I");
					JNIEnv.SetStaticField (class_ref, com_facebook_list_divider_jfieldId, value);
				}
			}

			static IntPtr com_facebook_list_section_header_background_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.drawable']/field[@name='com_facebook_list_section_header_background']"
			[Register ("com_facebook_list_section_header_background")]
			public static int ComFacebookListSectionHeaderBackground {
				get {
					if (com_facebook_list_section_header_background_jfieldId == IntPtr.Zero)
						com_facebook_list_section_header_background_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_list_section_header_background", "I");
					return JNIEnv.GetStaticIntField (class_ref, com_facebook_list_section_header_background_jfieldId);
				}
				set {
					if (com_facebook_list_section_header_background_jfieldId == IntPtr.Zero)
						com_facebook_list_section_header_background_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_list_section_header_background", "I");
					JNIEnv.SetStaticField (class_ref, com_facebook_list_section_header_background_jfieldId, value);
				}
			}

			static IntPtr com_facebook_loginbutton_silver_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.drawable']/field[@name='com_facebook_loginbutton_silver']"
			[Register ("com_facebook_loginbutton_silver")]
			public static int ComFacebookLoginbuttonSilver {
				get {
					if (com_facebook_loginbutton_silver_jfieldId == IntPtr.Zero)
						com_facebook_loginbutton_silver_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_loginbutton_silver", "I");
					return JNIEnv.GetStaticIntField (class_ref, com_facebook_loginbutton_silver_jfieldId);
				}
				set {
					if (com_facebook_loginbutton_silver_jfieldId == IntPtr.Zero)
						com_facebook_loginbutton_silver_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_loginbutton_silver", "I");
					JNIEnv.SetStaticField (class_ref, com_facebook_loginbutton_silver_jfieldId, value);
				}
			}

			static IntPtr com_facebook_logo_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.drawable']/field[@name='com_facebook_logo']"
			[Register ("com_facebook_logo")]
			public static int ComFacebookLogo {
				get {
					if (com_facebook_logo_jfieldId == IntPtr.Zero)
						com_facebook_logo_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_logo", "I");
					return JNIEnv.GetStaticIntField (class_ref, com_facebook_logo_jfieldId);
				}
				set {
					if (com_facebook_logo_jfieldId == IntPtr.Zero)
						com_facebook_logo_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_logo", "I");
					JNIEnv.SetStaticField (class_ref, com_facebook_logo_jfieldId, value);
				}
			}

			static IntPtr com_facebook_picker_default_separator_color_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.drawable']/field[@name='com_facebook_picker_default_separator_color']"
			[Register ("com_facebook_picker_default_separator_color")]
			public static int ComFacebookPickerDefaultSeparatorColor {
				get {
					if (com_facebook_picker_default_separator_color_jfieldId == IntPtr.Zero)
						com_facebook_picker_default_separator_color_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_picker_default_separator_color", "I");
					return JNIEnv.GetStaticIntField (class_ref, com_facebook_picker_default_separator_color_jfieldId);
				}
				set {
					if (com_facebook_picker_default_separator_color_jfieldId == IntPtr.Zero)
						com_facebook_picker_default_separator_color_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_picker_default_separator_color", "I");
					JNIEnv.SetStaticField (class_ref, com_facebook_picker_default_separator_color_jfieldId, value);
				}
			}

			static IntPtr com_facebook_picker_item_background_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.drawable']/field[@name='com_facebook_picker_item_background']"
			[Register ("com_facebook_picker_item_background")]
			public static int ComFacebookPickerItemBackground {
				get {
					if (com_facebook_picker_item_background_jfieldId == IntPtr.Zero)
						com_facebook_picker_item_background_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_picker_item_background", "I");
					return JNIEnv.GetStaticIntField (class_ref, com_facebook_picker_item_background_jfieldId);
				}
				set {
					if (com_facebook_picker_item_background_jfieldId == IntPtr.Zero)
						com_facebook_picker_item_background_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_picker_item_background", "I");
					JNIEnv.SetStaticField (class_ref, com_facebook_picker_item_background_jfieldId, value);
				}
			}

			static IntPtr com_facebook_picker_list_focused_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.drawable']/field[@name='com_facebook_picker_list_focused']"
			[Register ("com_facebook_picker_list_focused")]
			public static int ComFacebookPickerListFocused {
				get {
					if (com_facebook_picker_list_focused_jfieldId == IntPtr.Zero)
						com_facebook_picker_list_focused_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_picker_list_focused", "I");
					return JNIEnv.GetStaticIntField (class_ref, com_facebook_picker_list_focused_jfieldId);
				}
				set {
					if (com_facebook_picker_list_focused_jfieldId == IntPtr.Zero)
						com_facebook_picker_list_focused_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_picker_list_focused", "I");
					JNIEnv.SetStaticField (class_ref, com_facebook_picker_list_focused_jfieldId, value);
				}
			}

			static IntPtr com_facebook_picker_list_longpressed_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.drawable']/field[@name='com_facebook_picker_list_longpressed']"
			[Register ("com_facebook_picker_list_longpressed")]
			public static int ComFacebookPickerListLongpressed {
				get {
					if (com_facebook_picker_list_longpressed_jfieldId == IntPtr.Zero)
						com_facebook_picker_list_longpressed_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_picker_list_longpressed", "I");
					return JNIEnv.GetStaticIntField (class_ref, com_facebook_picker_list_longpressed_jfieldId);
				}
				set {
					if (com_facebook_picker_list_longpressed_jfieldId == IntPtr.Zero)
						com_facebook_picker_list_longpressed_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_picker_list_longpressed", "I");
					JNIEnv.SetStaticField (class_ref, com_facebook_picker_list_longpressed_jfieldId, value);
				}
			}

			static IntPtr com_facebook_picker_list_pressed_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.drawable']/field[@name='com_facebook_picker_list_pressed']"
			[Register ("com_facebook_picker_list_pressed")]
			public static int ComFacebookPickerListPressed {
				get {
					if (com_facebook_picker_list_pressed_jfieldId == IntPtr.Zero)
						com_facebook_picker_list_pressed_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_picker_list_pressed", "I");
					return JNIEnv.GetStaticIntField (class_ref, com_facebook_picker_list_pressed_jfieldId);
				}
				set {
					if (com_facebook_picker_list_pressed_jfieldId == IntPtr.Zero)
						com_facebook_picker_list_pressed_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_picker_list_pressed", "I");
					JNIEnv.SetStaticField (class_ref, com_facebook_picker_list_pressed_jfieldId, value);
				}
			}

			static IntPtr com_facebook_picker_list_selector_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.drawable']/field[@name='com_facebook_picker_list_selector']"
			[Register ("com_facebook_picker_list_selector")]
			public static int ComFacebookPickerListSelector {
				get {
					if (com_facebook_picker_list_selector_jfieldId == IntPtr.Zero)
						com_facebook_picker_list_selector_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_picker_list_selector", "I");
					return JNIEnv.GetStaticIntField (class_ref, com_facebook_picker_list_selector_jfieldId);
				}
				set {
					if (com_facebook_picker_list_selector_jfieldId == IntPtr.Zero)
						com_facebook_picker_list_selector_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_picker_list_selector", "I");
					JNIEnv.SetStaticField (class_ref, com_facebook_picker_list_selector_jfieldId, value);
				}
			}

			static IntPtr com_facebook_picker_list_selector_background_transition_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.drawable']/field[@name='com_facebook_picker_list_selector_background_transition']"
			[Register ("com_facebook_picker_list_selector_background_transition")]
			public static int ComFacebookPickerListSelectorBackgroundTransition {
				get {
					if (com_facebook_picker_list_selector_background_transition_jfieldId == IntPtr.Zero)
						com_facebook_picker_list_selector_background_transition_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_picker_list_selector_background_transition", "I");
					return JNIEnv.GetStaticIntField (class_ref, com_facebook_picker_list_selector_background_transition_jfieldId);
				}
				set {
					if (com_facebook_picker_list_selector_background_transition_jfieldId == IntPtr.Zero)
						com_facebook_picker_list_selector_background_transition_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_picker_list_selector_background_transition", "I");
					JNIEnv.SetStaticField (class_ref, com_facebook_picker_list_selector_background_transition_jfieldId, value);
				}
			}

			static IntPtr com_facebook_picker_list_selector_disabled_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.drawable']/field[@name='com_facebook_picker_list_selector_disabled']"
			[Register ("com_facebook_picker_list_selector_disabled")]
			public static int ComFacebookPickerListSelectorDisabled {
				get {
					if (com_facebook_picker_list_selector_disabled_jfieldId == IntPtr.Zero)
						com_facebook_picker_list_selector_disabled_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_picker_list_selector_disabled", "I");
					return JNIEnv.GetStaticIntField (class_ref, com_facebook_picker_list_selector_disabled_jfieldId);
				}
				set {
					if (com_facebook_picker_list_selector_disabled_jfieldId == IntPtr.Zero)
						com_facebook_picker_list_selector_disabled_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_picker_list_selector_disabled", "I");
					JNIEnv.SetStaticField (class_ref, com_facebook_picker_list_selector_disabled_jfieldId, value);
				}
			}

			static IntPtr com_facebook_picker_magnifier_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.drawable']/field[@name='com_facebook_picker_magnifier']"
			[Register ("com_facebook_picker_magnifier")]
			public static int ComFacebookPickerMagnifier {
				get {
					if (com_facebook_picker_magnifier_jfieldId == IntPtr.Zero)
						com_facebook_picker_magnifier_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_picker_magnifier", "I");
					return JNIEnv.GetStaticIntField (class_ref, com_facebook_picker_magnifier_jfieldId);
				}
				set {
					if (com_facebook_picker_magnifier_jfieldId == IntPtr.Zero)
						com_facebook_picker_magnifier_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_picker_magnifier", "I");
					JNIEnv.SetStaticField (class_ref, com_facebook_picker_magnifier_jfieldId, value);
				}
			}

			static IntPtr com_facebook_picker_top_button_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.drawable']/field[@name='com_facebook_picker_top_button']"
			[Register ("com_facebook_picker_top_button")]
			public static int ComFacebookPickerTopButton {
				get {
					if (com_facebook_picker_top_button_jfieldId == IntPtr.Zero)
						com_facebook_picker_top_button_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_picker_top_button", "I");
					return JNIEnv.GetStaticIntField (class_ref, com_facebook_picker_top_button_jfieldId);
				}
				set {
					if (com_facebook_picker_top_button_jfieldId == IntPtr.Zero)
						com_facebook_picker_top_button_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_picker_top_button", "I");
					JNIEnv.SetStaticField (class_ref, com_facebook_picker_top_button_jfieldId, value);
				}
			}

			static IntPtr com_facebook_place_default_icon_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.drawable']/field[@name='com_facebook_place_default_icon']"
			[Register ("com_facebook_place_default_icon")]
			public static int ComFacebookPlaceDefaultIcon {
				get {
					if (com_facebook_place_default_icon_jfieldId == IntPtr.Zero)
						com_facebook_place_default_icon_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_place_default_icon", "I");
					return JNIEnv.GetStaticIntField (class_ref, com_facebook_place_default_icon_jfieldId);
				}
				set {
					if (com_facebook_place_default_icon_jfieldId == IntPtr.Zero)
						com_facebook_place_default_icon_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_place_default_icon", "I");
					JNIEnv.SetStaticField (class_ref, com_facebook_place_default_icon_jfieldId, value);
				}
			}

			static IntPtr com_facebook_profile_default_icon_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.drawable']/field[@name='com_facebook_profile_default_icon']"
			[Register ("com_facebook_profile_default_icon")]
			public static int ComFacebookProfileDefaultIcon {
				get {
					if (com_facebook_profile_default_icon_jfieldId == IntPtr.Zero)
						com_facebook_profile_default_icon_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_profile_default_icon", "I");
					return JNIEnv.GetStaticIntField (class_ref, com_facebook_profile_default_icon_jfieldId);
				}
				set {
					if (com_facebook_profile_default_icon_jfieldId == IntPtr.Zero)
						com_facebook_profile_default_icon_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_profile_default_icon", "I");
					JNIEnv.SetStaticField (class_ref, com_facebook_profile_default_icon_jfieldId, value);
				}
			}

			static IntPtr com_facebook_profile_picture_blank_portrait_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.drawable']/field[@name='com_facebook_profile_picture_blank_portrait']"
			[Register ("com_facebook_profile_picture_blank_portrait")]
			public static int ComFacebookProfilePictureBlankPortrait {
				get {
					if (com_facebook_profile_picture_blank_portrait_jfieldId == IntPtr.Zero)
						com_facebook_profile_picture_blank_portrait_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_profile_picture_blank_portrait", "I");
					return JNIEnv.GetStaticIntField (class_ref, com_facebook_profile_picture_blank_portrait_jfieldId);
				}
				set {
					if (com_facebook_profile_picture_blank_portrait_jfieldId == IntPtr.Zero)
						com_facebook_profile_picture_blank_portrait_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_profile_picture_blank_portrait", "I");
					JNIEnv.SetStaticField (class_ref, com_facebook_profile_picture_blank_portrait_jfieldId, value);
				}
			}

			static IntPtr com_facebook_profile_picture_blank_square_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.drawable']/field[@name='com_facebook_profile_picture_blank_square']"
			[Register ("com_facebook_profile_picture_blank_square")]
			public static int ComFacebookProfilePictureBlankSquare {
				get {
					if (com_facebook_profile_picture_blank_square_jfieldId == IntPtr.Zero)
						com_facebook_profile_picture_blank_square_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_profile_picture_blank_square", "I");
					return JNIEnv.GetStaticIntField (class_ref, com_facebook_profile_picture_blank_square_jfieldId);
				}
				set {
					if (com_facebook_profile_picture_blank_square_jfieldId == IntPtr.Zero)
						com_facebook_profile_picture_blank_square_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_profile_picture_blank_square", "I");
					JNIEnv.SetStaticField (class_ref, com_facebook_profile_picture_blank_square_jfieldId, value);
				}
			}

			static IntPtr com_facebook_top_background_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.drawable']/field[@name='com_facebook_top_background']"
			[Register ("com_facebook_top_background")]
			public static int ComFacebookTopBackground {
				get {
					if (com_facebook_top_background_jfieldId == IntPtr.Zero)
						com_facebook_top_background_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_top_background", "I");
					return JNIEnv.GetStaticIntField (class_ref, com_facebook_top_background_jfieldId);
				}
				set {
					if (com_facebook_top_background_jfieldId == IntPtr.Zero)
						com_facebook_top_background_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_top_background", "I");
					JNIEnv.SetStaticField (class_ref, com_facebook_top_background_jfieldId, value);
				}
			}

			static IntPtr com_facebook_top_button_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.drawable']/field[@name='com_facebook_top_button']"
			[Register ("com_facebook_top_button")]
			public static int ComFacebookTopButton {
				get {
					if (com_facebook_top_button_jfieldId == IntPtr.Zero)
						com_facebook_top_button_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_top_button", "I");
					return JNIEnv.GetStaticIntField (class_ref, com_facebook_top_button_jfieldId);
				}
				set {
					if (com_facebook_top_button_jfieldId == IntPtr.Zero)
						com_facebook_top_button_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_top_button", "I");
					JNIEnv.SetStaticField (class_ref, com_facebook_top_button_jfieldId, value);
				}
			}

			static IntPtr com_facebook_usersettingsfragment_background_gradient_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.drawable']/field[@name='com_facebook_usersettingsfragment_background_gradient']"
			[Register ("com_facebook_usersettingsfragment_background_gradient")]
			public static int ComFacebookUsersettingsfragmentBackgroundGradient {
				get {
					if (com_facebook_usersettingsfragment_background_gradient_jfieldId == IntPtr.Zero)
						com_facebook_usersettingsfragment_background_gradient_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_usersettingsfragment_background_gradient", "I");
					return JNIEnv.GetStaticIntField (class_ref, com_facebook_usersettingsfragment_background_gradient_jfieldId);
				}
				set {
					if (com_facebook_usersettingsfragment_background_gradient_jfieldId == IntPtr.Zero)
						com_facebook_usersettingsfragment_background_gradient_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_usersettingsfragment_background_gradient", "I");
					JNIEnv.SetStaticField (class_ref, com_facebook_usersettingsfragment_background_gradient_jfieldId, value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/parse/R$drawable", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Drawable); }
			}

			internal Drawable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.parse']/class[@name='R.drawable']/constructor[@name='R.drawable' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public Drawable () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (Drawable)) {
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

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.parse']/class[@name='R.id']"
		[global::Android.Runtime.Register ("com/parse/R$id", DoNotGenerateAcw=true)]
		public sealed partial class Id : global::Java.Lang.Object {


			static IntPtr com_facebook_login_activity_progress_bar_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.id']/field[@name='com_facebook_login_activity_progress_bar']"
			[Register ("com_facebook_login_activity_progress_bar")]
			public static int ComFacebookLoginActivityProgressBar {
				get {
					if (com_facebook_login_activity_progress_bar_jfieldId == IntPtr.Zero)
						com_facebook_login_activity_progress_bar_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_login_activity_progress_bar", "I");
					return JNIEnv.GetStaticIntField (class_ref, com_facebook_login_activity_progress_bar_jfieldId);
				}
				set {
					if (com_facebook_login_activity_progress_bar_jfieldId == IntPtr.Zero)
						com_facebook_login_activity_progress_bar_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_login_activity_progress_bar", "I");
					JNIEnv.SetStaticField (class_ref, com_facebook_login_activity_progress_bar_jfieldId, value);
				}
			}

			static IntPtr com_facebook_picker_activity_circle_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.id']/field[@name='com_facebook_picker_activity_circle']"
			[Register ("com_facebook_picker_activity_circle")]
			public static int ComFacebookPickerActivityCircle {
				get {
					if (com_facebook_picker_activity_circle_jfieldId == IntPtr.Zero)
						com_facebook_picker_activity_circle_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_picker_activity_circle", "I");
					return JNIEnv.GetStaticIntField (class_ref, com_facebook_picker_activity_circle_jfieldId);
				}
				set {
					if (com_facebook_picker_activity_circle_jfieldId == IntPtr.Zero)
						com_facebook_picker_activity_circle_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_picker_activity_circle", "I");
					JNIEnv.SetStaticField (class_ref, com_facebook_picker_activity_circle_jfieldId, value);
				}
			}

			static IntPtr com_facebook_picker_checkbox_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.id']/field[@name='com_facebook_picker_checkbox']"
			[Register ("com_facebook_picker_checkbox")]
			public static int ComFacebookPickerCheckbox {
				get {
					if (com_facebook_picker_checkbox_jfieldId == IntPtr.Zero)
						com_facebook_picker_checkbox_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_picker_checkbox", "I");
					return JNIEnv.GetStaticIntField (class_ref, com_facebook_picker_checkbox_jfieldId);
				}
				set {
					if (com_facebook_picker_checkbox_jfieldId == IntPtr.Zero)
						com_facebook_picker_checkbox_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_picker_checkbox", "I");
					JNIEnv.SetStaticField (class_ref, com_facebook_picker_checkbox_jfieldId, value);
				}
			}

			static IntPtr com_facebook_picker_checkbox_stub_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.id']/field[@name='com_facebook_picker_checkbox_stub']"
			[Register ("com_facebook_picker_checkbox_stub")]
			public static int ComFacebookPickerCheckboxStub {
				get {
					if (com_facebook_picker_checkbox_stub_jfieldId == IntPtr.Zero)
						com_facebook_picker_checkbox_stub_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_picker_checkbox_stub", "I");
					return JNIEnv.GetStaticIntField (class_ref, com_facebook_picker_checkbox_stub_jfieldId);
				}
				set {
					if (com_facebook_picker_checkbox_stub_jfieldId == IntPtr.Zero)
						com_facebook_picker_checkbox_stub_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_picker_checkbox_stub", "I");
					JNIEnv.SetStaticField (class_ref, com_facebook_picker_checkbox_stub_jfieldId, value);
				}
			}

			static IntPtr com_facebook_picker_divider_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.id']/field[@name='com_facebook_picker_divider']"
			[Register ("com_facebook_picker_divider")]
			public static int ComFacebookPickerDivider {
				get {
					if (com_facebook_picker_divider_jfieldId == IntPtr.Zero)
						com_facebook_picker_divider_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_picker_divider", "I");
					return JNIEnv.GetStaticIntField (class_ref, com_facebook_picker_divider_jfieldId);
				}
				set {
					if (com_facebook_picker_divider_jfieldId == IntPtr.Zero)
						com_facebook_picker_divider_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_picker_divider", "I");
					JNIEnv.SetStaticField (class_ref, com_facebook_picker_divider_jfieldId, value);
				}
			}

			static IntPtr com_facebook_picker_done_button_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.id']/field[@name='com_facebook_picker_done_button']"
			[Register ("com_facebook_picker_done_button")]
			public static int ComFacebookPickerDoneButton {
				get {
					if (com_facebook_picker_done_button_jfieldId == IntPtr.Zero)
						com_facebook_picker_done_button_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_picker_done_button", "I");
					return JNIEnv.GetStaticIntField (class_ref, com_facebook_picker_done_button_jfieldId);
				}
				set {
					if (com_facebook_picker_done_button_jfieldId == IntPtr.Zero)
						com_facebook_picker_done_button_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_picker_done_button", "I");
					JNIEnv.SetStaticField (class_ref, com_facebook_picker_done_button_jfieldId, value);
				}
			}

			static IntPtr com_facebook_picker_image_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.id']/field[@name='com_facebook_picker_image']"
			[Register ("com_facebook_picker_image")]
			public static int ComFacebookPickerImage {
				get {
					if (com_facebook_picker_image_jfieldId == IntPtr.Zero)
						com_facebook_picker_image_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_picker_image", "I");
					return JNIEnv.GetStaticIntField (class_ref, com_facebook_picker_image_jfieldId);
				}
				set {
					if (com_facebook_picker_image_jfieldId == IntPtr.Zero)
						com_facebook_picker_image_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_picker_image", "I");
					JNIEnv.SetStaticField (class_ref, com_facebook_picker_image_jfieldId, value);
				}
			}

			static IntPtr com_facebook_picker_list_section_header_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.id']/field[@name='com_facebook_picker_list_section_header']"
			[Register ("com_facebook_picker_list_section_header")]
			public static int ComFacebookPickerListSectionHeader {
				get {
					if (com_facebook_picker_list_section_header_jfieldId == IntPtr.Zero)
						com_facebook_picker_list_section_header_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_picker_list_section_header", "I");
					return JNIEnv.GetStaticIntField (class_ref, com_facebook_picker_list_section_header_jfieldId);
				}
				set {
					if (com_facebook_picker_list_section_header_jfieldId == IntPtr.Zero)
						com_facebook_picker_list_section_header_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_picker_list_section_header", "I");
					JNIEnv.SetStaticField (class_ref, com_facebook_picker_list_section_header_jfieldId, value);
				}
			}

			static IntPtr com_facebook_picker_list_view_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.id']/field[@name='com_facebook_picker_list_view']"
			[Register ("com_facebook_picker_list_view")]
			public static int ComFacebookPickerListView {
				get {
					if (com_facebook_picker_list_view_jfieldId == IntPtr.Zero)
						com_facebook_picker_list_view_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_picker_list_view", "I");
					return JNIEnv.GetStaticIntField (class_ref, com_facebook_picker_list_view_jfieldId);
				}
				set {
					if (com_facebook_picker_list_view_jfieldId == IntPtr.Zero)
						com_facebook_picker_list_view_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_picker_list_view", "I");
					JNIEnv.SetStaticField (class_ref, com_facebook_picker_list_view_jfieldId, value);
				}
			}

			static IntPtr com_facebook_picker_profile_pic_stub_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.id']/field[@name='com_facebook_picker_profile_pic_stub']"
			[Register ("com_facebook_picker_profile_pic_stub")]
			public static int ComFacebookPickerProfilePicStub {
				get {
					if (com_facebook_picker_profile_pic_stub_jfieldId == IntPtr.Zero)
						com_facebook_picker_profile_pic_stub_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_picker_profile_pic_stub", "I");
					return JNIEnv.GetStaticIntField (class_ref, com_facebook_picker_profile_pic_stub_jfieldId);
				}
				set {
					if (com_facebook_picker_profile_pic_stub_jfieldId == IntPtr.Zero)
						com_facebook_picker_profile_pic_stub_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_picker_profile_pic_stub", "I");
					JNIEnv.SetStaticField (class_ref, com_facebook_picker_profile_pic_stub_jfieldId, value);
				}
			}

			static IntPtr com_facebook_picker_row_activity_circle_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.id']/field[@name='com_facebook_picker_row_activity_circle']"
			[Register ("com_facebook_picker_row_activity_circle")]
			public static int ComFacebookPickerRowActivityCircle {
				get {
					if (com_facebook_picker_row_activity_circle_jfieldId == IntPtr.Zero)
						com_facebook_picker_row_activity_circle_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_picker_row_activity_circle", "I");
					return JNIEnv.GetStaticIntField (class_ref, com_facebook_picker_row_activity_circle_jfieldId);
				}
				set {
					if (com_facebook_picker_row_activity_circle_jfieldId == IntPtr.Zero)
						com_facebook_picker_row_activity_circle_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_picker_row_activity_circle", "I");
					JNIEnv.SetStaticField (class_ref, com_facebook_picker_row_activity_circle_jfieldId, value);
				}
			}

			static IntPtr com_facebook_picker_search_text_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.id']/field[@name='com_facebook_picker_search_text']"
			[Register ("com_facebook_picker_search_text")]
			public static int ComFacebookPickerSearchText {
				get {
					if (com_facebook_picker_search_text_jfieldId == IntPtr.Zero)
						com_facebook_picker_search_text_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_picker_search_text", "I");
					return JNIEnv.GetStaticIntField (class_ref, com_facebook_picker_search_text_jfieldId);
				}
				set {
					if (com_facebook_picker_search_text_jfieldId == IntPtr.Zero)
						com_facebook_picker_search_text_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_picker_search_text", "I");
					JNIEnv.SetStaticField (class_ref, com_facebook_picker_search_text_jfieldId, value);
				}
			}

			static IntPtr com_facebook_picker_title_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.id']/field[@name='com_facebook_picker_title']"
			[Register ("com_facebook_picker_title")]
			public static int ComFacebookPickerTitle {
				get {
					if (com_facebook_picker_title_jfieldId == IntPtr.Zero)
						com_facebook_picker_title_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_picker_title", "I");
					return JNIEnv.GetStaticIntField (class_ref, com_facebook_picker_title_jfieldId);
				}
				set {
					if (com_facebook_picker_title_jfieldId == IntPtr.Zero)
						com_facebook_picker_title_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_picker_title", "I");
					JNIEnv.SetStaticField (class_ref, com_facebook_picker_title_jfieldId, value);
				}
			}

			static IntPtr com_facebook_picker_title_bar_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.id']/field[@name='com_facebook_picker_title_bar']"
			[Register ("com_facebook_picker_title_bar")]
			public static int ComFacebookPickerTitleBar {
				get {
					if (com_facebook_picker_title_bar_jfieldId == IntPtr.Zero)
						com_facebook_picker_title_bar_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_picker_title_bar", "I");
					return JNIEnv.GetStaticIntField (class_ref, com_facebook_picker_title_bar_jfieldId);
				}
				set {
					if (com_facebook_picker_title_bar_jfieldId == IntPtr.Zero)
						com_facebook_picker_title_bar_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_picker_title_bar", "I");
					JNIEnv.SetStaticField (class_ref, com_facebook_picker_title_bar_jfieldId, value);
				}
			}

			static IntPtr com_facebook_picker_title_bar_stub_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.id']/field[@name='com_facebook_picker_title_bar_stub']"
			[Register ("com_facebook_picker_title_bar_stub")]
			public static int ComFacebookPickerTitleBarStub {
				get {
					if (com_facebook_picker_title_bar_stub_jfieldId == IntPtr.Zero)
						com_facebook_picker_title_bar_stub_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_picker_title_bar_stub", "I");
					return JNIEnv.GetStaticIntField (class_ref, com_facebook_picker_title_bar_stub_jfieldId);
				}
				set {
					if (com_facebook_picker_title_bar_stub_jfieldId == IntPtr.Zero)
						com_facebook_picker_title_bar_stub_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_picker_title_bar_stub", "I");
					JNIEnv.SetStaticField (class_ref, com_facebook_picker_title_bar_stub_jfieldId, value);
				}
			}

			static IntPtr com_facebook_picker_top_bar_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.id']/field[@name='com_facebook_picker_top_bar']"
			[Register ("com_facebook_picker_top_bar")]
			public static int ComFacebookPickerTopBar {
				get {
					if (com_facebook_picker_top_bar_jfieldId == IntPtr.Zero)
						com_facebook_picker_top_bar_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_picker_top_bar", "I");
					return JNIEnv.GetStaticIntField (class_ref, com_facebook_picker_top_bar_jfieldId);
				}
				set {
					if (com_facebook_picker_top_bar_jfieldId == IntPtr.Zero)
						com_facebook_picker_top_bar_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_picker_top_bar", "I");
					JNIEnv.SetStaticField (class_ref, com_facebook_picker_top_bar_jfieldId, value);
				}
			}

			static IntPtr com_facebook_search_bar_view_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.id']/field[@name='com_facebook_search_bar_view']"
			[Register ("com_facebook_search_bar_view")]
			public static int ComFacebookSearchBarView {
				get {
					if (com_facebook_search_bar_view_jfieldId == IntPtr.Zero)
						com_facebook_search_bar_view_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_search_bar_view", "I");
					return JNIEnv.GetStaticIntField (class_ref, com_facebook_search_bar_view_jfieldId);
				}
				set {
					if (com_facebook_search_bar_view_jfieldId == IntPtr.Zero)
						com_facebook_search_bar_view_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_search_bar_view", "I");
					JNIEnv.SetStaticField (class_ref, com_facebook_search_bar_view_jfieldId, value);
				}
			}

			static IntPtr com_facebook_usersettingsfragment_login_button_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.id']/field[@name='com_facebook_usersettingsfragment_login_button']"
			[Register ("com_facebook_usersettingsfragment_login_button")]
			public static int ComFacebookUsersettingsfragmentLoginButton {
				get {
					if (com_facebook_usersettingsfragment_login_button_jfieldId == IntPtr.Zero)
						com_facebook_usersettingsfragment_login_button_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_usersettingsfragment_login_button", "I");
					return JNIEnv.GetStaticIntField (class_ref, com_facebook_usersettingsfragment_login_button_jfieldId);
				}
				set {
					if (com_facebook_usersettingsfragment_login_button_jfieldId == IntPtr.Zero)
						com_facebook_usersettingsfragment_login_button_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_usersettingsfragment_login_button", "I");
					JNIEnv.SetStaticField (class_ref, com_facebook_usersettingsfragment_login_button_jfieldId, value);
				}
			}

			static IntPtr com_facebook_usersettingsfragment_logo_image_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.id']/field[@name='com_facebook_usersettingsfragment_logo_image']"
			[Register ("com_facebook_usersettingsfragment_logo_image")]
			public static int ComFacebookUsersettingsfragmentLogoImage {
				get {
					if (com_facebook_usersettingsfragment_logo_image_jfieldId == IntPtr.Zero)
						com_facebook_usersettingsfragment_logo_image_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_usersettingsfragment_logo_image", "I");
					return JNIEnv.GetStaticIntField (class_ref, com_facebook_usersettingsfragment_logo_image_jfieldId);
				}
				set {
					if (com_facebook_usersettingsfragment_logo_image_jfieldId == IntPtr.Zero)
						com_facebook_usersettingsfragment_logo_image_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_usersettingsfragment_logo_image", "I");
					JNIEnv.SetStaticField (class_ref, com_facebook_usersettingsfragment_logo_image_jfieldId, value);
				}
			}

			static IntPtr com_facebook_usersettingsfragment_profile_name_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.id']/field[@name='com_facebook_usersettingsfragment_profile_name']"
			[Register ("com_facebook_usersettingsfragment_profile_name")]
			public static int ComFacebookUsersettingsfragmentProfileName {
				get {
					if (com_facebook_usersettingsfragment_profile_name_jfieldId == IntPtr.Zero)
						com_facebook_usersettingsfragment_profile_name_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_usersettingsfragment_profile_name", "I");
					return JNIEnv.GetStaticIntField (class_ref, com_facebook_usersettingsfragment_profile_name_jfieldId);
				}
				set {
					if (com_facebook_usersettingsfragment_profile_name_jfieldId == IntPtr.Zero)
						com_facebook_usersettingsfragment_profile_name_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_usersettingsfragment_profile_name", "I");
					JNIEnv.SetStaticField (class_ref, com_facebook_usersettingsfragment_profile_name_jfieldId, value);
				}
			}

			static IntPtr large_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.id']/field[@name='large']"
			[Register ("large")]
			public static int Large {
				get {
					if (large_jfieldId == IntPtr.Zero)
						large_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "large", "I");
					return JNIEnv.GetStaticIntField (class_ref, large_jfieldId);
				}
				set {
					if (large_jfieldId == IntPtr.Zero)
						large_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "large", "I");
					JNIEnv.SetStaticField (class_ref, large_jfieldId, value);
				}
			}

			static IntPtr normal_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.id']/field[@name='normal']"
			[Register ("normal")]
			public static int Normal {
				get {
					if (normal_jfieldId == IntPtr.Zero)
						normal_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "normal", "I");
					return JNIEnv.GetStaticIntField (class_ref, normal_jfieldId);
				}
				set {
					if (normal_jfieldId == IntPtr.Zero)
						normal_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "normal", "I");
					JNIEnv.SetStaticField (class_ref, normal_jfieldId, value);
				}
			}

			static IntPtr picker_subtitle_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.id']/field[@name='picker_subtitle']"
			[Register ("picker_subtitle")]
			public static int PickerSubtitle {
				get {
					if (picker_subtitle_jfieldId == IntPtr.Zero)
						picker_subtitle_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "picker_subtitle", "I");
					return JNIEnv.GetStaticIntField (class_ref, picker_subtitle_jfieldId);
				}
				set {
					if (picker_subtitle_jfieldId == IntPtr.Zero)
						picker_subtitle_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "picker_subtitle", "I");
					JNIEnv.SetStaticField (class_ref, picker_subtitle_jfieldId, value);
				}
			}

			static IntPtr small_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.id']/field[@name='small']"
			[Register ("small")]
			public static int Small {
				get {
					if (small_jfieldId == IntPtr.Zero)
						small_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "small", "I");
					return JNIEnv.GetStaticIntField (class_ref, small_jfieldId);
				}
				set {
					if (small_jfieldId == IntPtr.Zero)
						small_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "small", "I");
					JNIEnv.SetStaticField (class_ref, small_jfieldId, value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/parse/R$id", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Id); }
			}

			internal Id (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.parse']/class[@name='R.id']/constructor[@name='R.id' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public Id () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (Id)) {
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

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.parse']/class[@name='R.layout']"
		[global::Android.Runtime.Register ("com/parse/R$layout", DoNotGenerateAcw=true)]
		public sealed partial class Layout : global::Java.Lang.Object {


			static IntPtr com_facebook_friendpickerfragment_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.layout']/field[@name='com_facebook_friendpickerfragment']"
			[Register ("com_facebook_friendpickerfragment")]
			public static int ComFacebookFriendpickerfragment {
				get {
					if (com_facebook_friendpickerfragment_jfieldId == IntPtr.Zero)
						com_facebook_friendpickerfragment_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_friendpickerfragment", "I");
					return JNIEnv.GetStaticIntField (class_ref, com_facebook_friendpickerfragment_jfieldId);
				}
				set {
					if (com_facebook_friendpickerfragment_jfieldId == IntPtr.Zero)
						com_facebook_friendpickerfragment_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_friendpickerfragment", "I");
					JNIEnv.SetStaticField (class_ref, com_facebook_friendpickerfragment_jfieldId, value);
				}
			}

			static IntPtr com_facebook_login_activity_layout_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.layout']/field[@name='com_facebook_login_activity_layout']"
			[Register ("com_facebook_login_activity_layout")]
			public static int ComFacebookLoginActivityLayout {
				get {
					if (com_facebook_login_activity_layout_jfieldId == IntPtr.Zero)
						com_facebook_login_activity_layout_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_login_activity_layout", "I");
					return JNIEnv.GetStaticIntField (class_ref, com_facebook_login_activity_layout_jfieldId);
				}
				set {
					if (com_facebook_login_activity_layout_jfieldId == IntPtr.Zero)
						com_facebook_login_activity_layout_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_login_activity_layout", "I");
					JNIEnv.SetStaticField (class_ref, com_facebook_login_activity_layout_jfieldId, value);
				}
			}

			static IntPtr com_facebook_picker_activity_circle_row_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.layout']/field[@name='com_facebook_picker_activity_circle_row']"
			[Register ("com_facebook_picker_activity_circle_row")]
			public static int ComFacebookPickerActivityCircleRow {
				get {
					if (com_facebook_picker_activity_circle_row_jfieldId == IntPtr.Zero)
						com_facebook_picker_activity_circle_row_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_picker_activity_circle_row", "I");
					return JNIEnv.GetStaticIntField (class_ref, com_facebook_picker_activity_circle_row_jfieldId);
				}
				set {
					if (com_facebook_picker_activity_circle_row_jfieldId == IntPtr.Zero)
						com_facebook_picker_activity_circle_row_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_picker_activity_circle_row", "I");
					JNIEnv.SetStaticField (class_ref, com_facebook_picker_activity_circle_row_jfieldId, value);
				}
			}

			static IntPtr com_facebook_picker_checkbox_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.layout']/field[@name='com_facebook_picker_checkbox']"
			[Register ("com_facebook_picker_checkbox")]
			public static int ComFacebookPickerCheckbox {
				get {
					if (com_facebook_picker_checkbox_jfieldId == IntPtr.Zero)
						com_facebook_picker_checkbox_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_picker_checkbox", "I");
					return JNIEnv.GetStaticIntField (class_ref, com_facebook_picker_checkbox_jfieldId);
				}
				set {
					if (com_facebook_picker_checkbox_jfieldId == IntPtr.Zero)
						com_facebook_picker_checkbox_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_picker_checkbox", "I");
					JNIEnv.SetStaticField (class_ref, com_facebook_picker_checkbox_jfieldId, value);
				}
			}

			static IntPtr com_facebook_picker_image_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.layout']/field[@name='com_facebook_picker_image']"
			[Register ("com_facebook_picker_image")]
			public static int ComFacebookPickerImage {
				get {
					if (com_facebook_picker_image_jfieldId == IntPtr.Zero)
						com_facebook_picker_image_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_picker_image", "I");
					return JNIEnv.GetStaticIntField (class_ref, com_facebook_picker_image_jfieldId);
				}
				set {
					if (com_facebook_picker_image_jfieldId == IntPtr.Zero)
						com_facebook_picker_image_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_picker_image", "I");
					JNIEnv.SetStaticField (class_ref, com_facebook_picker_image_jfieldId, value);
				}
			}

			static IntPtr com_facebook_picker_list_row_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.layout']/field[@name='com_facebook_picker_list_row']"
			[Register ("com_facebook_picker_list_row")]
			public static int ComFacebookPickerListRow {
				get {
					if (com_facebook_picker_list_row_jfieldId == IntPtr.Zero)
						com_facebook_picker_list_row_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_picker_list_row", "I");
					return JNIEnv.GetStaticIntField (class_ref, com_facebook_picker_list_row_jfieldId);
				}
				set {
					if (com_facebook_picker_list_row_jfieldId == IntPtr.Zero)
						com_facebook_picker_list_row_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_picker_list_row", "I");
					JNIEnv.SetStaticField (class_ref, com_facebook_picker_list_row_jfieldId, value);
				}
			}

			static IntPtr com_facebook_picker_list_section_header_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.layout']/field[@name='com_facebook_picker_list_section_header']"
			[Register ("com_facebook_picker_list_section_header")]
			public static int ComFacebookPickerListSectionHeader {
				get {
					if (com_facebook_picker_list_section_header_jfieldId == IntPtr.Zero)
						com_facebook_picker_list_section_header_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_picker_list_section_header", "I");
					return JNIEnv.GetStaticIntField (class_ref, com_facebook_picker_list_section_header_jfieldId);
				}
				set {
					if (com_facebook_picker_list_section_header_jfieldId == IntPtr.Zero)
						com_facebook_picker_list_section_header_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_picker_list_section_header", "I");
					JNIEnv.SetStaticField (class_ref, com_facebook_picker_list_section_header_jfieldId, value);
				}
			}

			static IntPtr com_facebook_picker_search_box_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.layout']/field[@name='com_facebook_picker_search_box']"
			[Register ("com_facebook_picker_search_box")]
			public static int ComFacebookPickerSearchBox {
				get {
					if (com_facebook_picker_search_box_jfieldId == IntPtr.Zero)
						com_facebook_picker_search_box_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_picker_search_box", "I");
					return JNIEnv.GetStaticIntField (class_ref, com_facebook_picker_search_box_jfieldId);
				}
				set {
					if (com_facebook_picker_search_box_jfieldId == IntPtr.Zero)
						com_facebook_picker_search_box_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_picker_search_box", "I");
					JNIEnv.SetStaticField (class_ref, com_facebook_picker_search_box_jfieldId, value);
				}
			}

			static IntPtr com_facebook_picker_title_bar_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.layout']/field[@name='com_facebook_picker_title_bar']"
			[Register ("com_facebook_picker_title_bar")]
			public static int ComFacebookPickerTitleBar {
				get {
					if (com_facebook_picker_title_bar_jfieldId == IntPtr.Zero)
						com_facebook_picker_title_bar_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_picker_title_bar", "I");
					return JNIEnv.GetStaticIntField (class_ref, com_facebook_picker_title_bar_jfieldId);
				}
				set {
					if (com_facebook_picker_title_bar_jfieldId == IntPtr.Zero)
						com_facebook_picker_title_bar_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_picker_title_bar", "I");
					JNIEnv.SetStaticField (class_ref, com_facebook_picker_title_bar_jfieldId, value);
				}
			}

			static IntPtr com_facebook_picker_title_bar_stub_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.layout']/field[@name='com_facebook_picker_title_bar_stub']"
			[Register ("com_facebook_picker_title_bar_stub")]
			public static int ComFacebookPickerTitleBarStub {
				get {
					if (com_facebook_picker_title_bar_stub_jfieldId == IntPtr.Zero)
						com_facebook_picker_title_bar_stub_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_picker_title_bar_stub", "I");
					return JNIEnv.GetStaticIntField (class_ref, com_facebook_picker_title_bar_stub_jfieldId);
				}
				set {
					if (com_facebook_picker_title_bar_stub_jfieldId == IntPtr.Zero)
						com_facebook_picker_title_bar_stub_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_picker_title_bar_stub", "I");
					JNIEnv.SetStaticField (class_ref, com_facebook_picker_title_bar_stub_jfieldId, value);
				}
			}

			static IntPtr com_facebook_placepickerfragment_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.layout']/field[@name='com_facebook_placepickerfragment']"
			[Register ("com_facebook_placepickerfragment")]
			public static int ComFacebookPlacepickerfragment {
				get {
					if (com_facebook_placepickerfragment_jfieldId == IntPtr.Zero)
						com_facebook_placepickerfragment_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_placepickerfragment", "I");
					return JNIEnv.GetStaticIntField (class_ref, com_facebook_placepickerfragment_jfieldId);
				}
				set {
					if (com_facebook_placepickerfragment_jfieldId == IntPtr.Zero)
						com_facebook_placepickerfragment_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_placepickerfragment", "I");
					JNIEnv.SetStaticField (class_ref, com_facebook_placepickerfragment_jfieldId, value);
				}
			}

			static IntPtr com_facebook_placepickerfragment_list_row_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.layout']/field[@name='com_facebook_placepickerfragment_list_row']"
			[Register ("com_facebook_placepickerfragment_list_row")]
			public static int ComFacebookPlacepickerfragmentListRow {
				get {
					if (com_facebook_placepickerfragment_list_row_jfieldId == IntPtr.Zero)
						com_facebook_placepickerfragment_list_row_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_placepickerfragment_list_row", "I");
					return JNIEnv.GetStaticIntField (class_ref, com_facebook_placepickerfragment_list_row_jfieldId);
				}
				set {
					if (com_facebook_placepickerfragment_list_row_jfieldId == IntPtr.Zero)
						com_facebook_placepickerfragment_list_row_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_placepickerfragment_list_row", "I");
					JNIEnv.SetStaticField (class_ref, com_facebook_placepickerfragment_list_row_jfieldId, value);
				}
			}

			static IntPtr com_facebook_search_bar_layout_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.layout']/field[@name='com_facebook_search_bar_layout']"
			[Register ("com_facebook_search_bar_layout")]
			public static int ComFacebookSearchBarLayout {
				get {
					if (com_facebook_search_bar_layout_jfieldId == IntPtr.Zero)
						com_facebook_search_bar_layout_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_search_bar_layout", "I");
					return JNIEnv.GetStaticIntField (class_ref, com_facebook_search_bar_layout_jfieldId);
				}
				set {
					if (com_facebook_search_bar_layout_jfieldId == IntPtr.Zero)
						com_facebook_search_bar_layout_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_search_bar_layout", "I");
					JNIEnv.SetStaticField (class_ref, com_facebook_search_bar_layout_jfieldId, value);
				}
			}

			static IntPtr com_facebook_usersettingsfragment_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.layout']/field[@name='com_facebook_usersettingsfragment']"
			[Register ("com_facebook_usersettingsfragment")]
			public static int ComFacebookUsersettingsfragment {
				get {
					if (com_facebook_usersettingsfragment_jfieldId == IntPtr.Zero)
						com_facebook_usersettingsfragment_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_usersettingsfragment", "I");
					return JNIEnv.GetStaticIntField (class_ref, com_facebook_usersettingsfragment_jfieldId);
				}
				set {
					if (com_facebook_usersettingsfragment_jfieldId == IntPtr.Zero)
						com_facebook_usersettingsfragment_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_usersettingsfragment", "I");
					JNIEnv.SetStaticField (class_ref, com_facebook_usersettingsfragment_jfieldId, value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/parse/R$layout", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Layout); }
			}

			internal Layout (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.parse']/class[@name='R.layout']/constructor[@name='R.layout' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public Layout () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (Layout)) {
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

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.parse']/class[@name='R.string']"
		[global::Android.Runtime.Register ("com/parse/R$string", DoNotGenerateAcw=true)]
		public sealed partial class String : global::Java.Lang.Object {


			static IntPtr com_facebook_choose_friends_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.string']/field[@name='com_facebook_choose_friends']"
			[Register ("com_facebook_choose_friends")]
			public static int ComFacebookChooseFriends {
				get {
					if (com_facebook_choose_friends_jfieldId == IntPtr.Zero)
						com_facebook_choose_friends_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_choose_friends", "I");
					return JNIEnv.GetStaticIntField (class_ref, com_facebook_choose_friends_jfieldId);
				}
				set {
					if (com_facebook_choose_friends_jfieldId == IntPtr.Zero)
						com_facebook_choose_friends_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_choose_friends", "I");
					JNIEnv.SetStaticField (class_ref, com_facebook_choose_friends_jfieldId, value);
				}
			}

			static IntPtr com_facebook_dialogloginactivity_ok_button_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.string']/field[@name='com_facebook_dialogloginactivity_ok_button']"
			[Register ("com_facebook_dialogloginactivity_ok_button")]
			public static int ComFacebookDialogloginactivityOkButton {
				get {
					if (com_facebook_dialogloginactivity_ok_button_jfieldId == IntPtr.Zero)
						com_facebook_dialogloginactivity_ok_button_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_dialogloginactivity_ok_button", "I");
					return JNIEnv.GetStaticIntField (class_ref, com_facebook_dialogloginactivity_ok_button_jfieldId);
				}
				set {
					if (com_facebook_dialogloginactivity_ok_button_jfieldId == IntPtr.Zero)
						com_facebook_dialogloginactivity_ok_button_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_dialogloginactivity_ok_button", "I");
					JNIEnv.SetStaticField (class_ref, com_facebook_dialogloginactivity_ok_button_jfieldId, value);
				}
			}

			static IntPtr com_facebook_internet_permission_error_message_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.string']/field[@name='com_facebook_internet_permission_error_message']"
			[Register ("com_facebook_internet_permission_error_message")]
			public static int ComFacebookInternetPermissionErrorMessage {
				get {
					if (com_facebook_internet_permission_error_message_jfieldId == IntPtr.Zero)
						com_facebook_internet_permission_error_message_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_internet_permission_error_message", "I");
					return JNIEnv.GetStaticIntField (class_ref, com_facebook_internet_permission_error_message_jfieldId);
				}
				set {
					if (com_facebook_internet_permission_error_message_jfieldId == IntPtr.Zero)
						com_facebook_internet_permission_error_message_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_internet_permission_error_message", "I");
					JNIEnv.SetStaticField (class_ref, com_facebook_internet_permission_error_message_jfieldId, value);
				}
			}

			static IntPtr com_facebook_internet_permission_error_title_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.string']/field[@name='com_facebook_internet_permission_error_title']"
			[Register ("com_facebook_internet_permission_error_title")]
			public static int ComFacebookInternetPermissionErrorTitle {
				get {
					if (com_facebook_internet_permission_error_title_jfieldId == IntPtr.Zero)
						com_facebook_internet_permission_error_title_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_internet_permission_error_title", "I");
					return JNIEnv.GetStaticIntField (class_ref, com_facebook_internet_permission_error_title_jfieldId);
				}
				set {
					if (com_facebook_internet_permission_error_title_jfieldId == IntPtr.Zero)
						com_facebook_internet_permission_error_title_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_internet_permission_error_title", "I");
					JNIEnv.SetStaticField (class_ref, com_facebook_internet_permission_error_title_jfieldId, value);
				}
			}

			static IntPtr com_facebook_loading_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.string']/field[@name='com_facebook_loading']"
			[Register ("com_facebook_loading")]
			public static int ComFacebookLoading {
				get {
					if (com_facebook_loading_jfieldId == IntPtr.Zero)
						com_facebook_loading_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_loading", "I");
					return JNIEnv.GetStaticIntField (class_ref, com_facebook_loading_jfieldId);
				}
				set {
					if (com_facebook_loading_jfieldId == IntPtr.Zero)
						com_facebook_loading_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_loading", "I");
					JNIEnv.SetStaticField (class_ref, com_facebook_loading_jfieldId, value);
				}
			}

			static IntPtr com_facebook_loginview_cancel_action_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.string']/field[@name='com_facebook_loginview_cancel_action']"
			[Register ("com_facebook_loginview_cancel_action")]
			public static int ComFacebookLoginviewCancelAction {
				get {
					if (com_facebook_loginview_cancel_action_jfieldId == IntPtr.Zero)
						com_facebook_loginview_cancel_action_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_loginview_cancel_action", "I");
					return JNIEnv.GetStaticIntField (class_ref, com_facebook_loginview_cancel_action_jfieldId);
				}
				set {
					if (com_facebook_loginview_cancel_action_jfieldId == IntPtr.Zero)
						com_facebook_loginview_cancel_action_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_loginview_cancel_action", "I");
					JNIEnv.SetStaticField (class_ref, com_facebook_loginview_cancel_action_jfieldId, value);
				}
			}

			static IntPtr com_facebook_loginview_log_in_button_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.string']/field[@name='com_facebook_loginview_log_in_button']"
			[Register ("com_facebook_loginview_log_in_button")]
			public static int ComFacebookLoginviewLogInButton {
				get {
					if (com_facebook_loginview_log_in_button_jfieldId == IntPtr.Zero)
						com_facebook_loginview_log_in_button_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_loginview_log_in_button", "I");
					return JNIEnv.GetStaticIntField (class_ref, com_facebook_loginview_log_in_button_jfieldId);
				}
				set {
					if (com_facebook_loginview_log_in_button_jfieldId == IntPtr.Zero)
						com_facebook_loginview_log_in_button_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_loginview_log_in_button", "I");
					JNIEnv.SetStaticField (class_ref, com_facebook_loginview_log_in_button_jfieldId, value);
				}
			}

			static IntPtr com_facebook_loginview_log_out_action_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.string']/field[@name='com_facebook_loginview_log_out_action']"
			[Register ("com_facebook_loginview_log_out_action")]
			public static int ComFacebookLoginviewLogOutAction {
				get {
					if (com_facebook_loginview_log_out_action_jfieldId == IntPtr.Zero)
						com_facebook_loginview_log_out_action_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_loginview_log_out_action", "I");
					return JNIEnv.GetStaticIntField (class_ref, com_facebook_loginview_log_out_action_jfieldId);
				}
				set {
					if (com_facebook_loginview_log_out_action_jfieldId == IntPtr.Zero)
						com_facebook_loginview_log_out_action_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_loginview_log_out_action", "I");
					JNIEnv.SetStaticField (class_ref, com_facebook_loginview_log_out_action_jfieldId, value);
				}
			}

			static IntPtr com_facebook_loginview_log_out_button_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.string']/field[@name='com_facebook_loginview_log_out_button']"
			[Register ("com_facebook_loginview_log_out_button")]
			public static int ComFacebookLoginviewLogOutButton {
				get {
					if (com_facebook_loginview_log_out_button_jfieldId == IntPtr.Zero)
						com_facebook_loginview_log_out_button_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_loginview_log_out_button", "I");
					return JNIEnv.GetStaticIntField (class_ref, com_facebook_loginview_log_out_button_jfieldId);
				}
				set {
					if (com_facebook_loginview_log_out_button_jfieldId == IntPtr.Zero)
						com_facebook_loginview_log_out_button_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_loginview_log_out_button", "I");
					JNIEnv.SetStaticField (class_ref, com_facebook_loginview_log_out_button_jfieldId, value);
				}
			}

			static IntPtr com_facebook_loginview_logged_in_as_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.string']/field[@name='com_facebook_loginview_logged_in_as']"
			[Register ("com_facebook_loginview_logged_in_as")]
			public static int ComFacebookLoginviewLoggedInAs {
				get {
					if (com_facebook_loginview_logged_in_as_jfieldId == IntPtr.Zero)
						com_facebook_loginview_logged_in_as_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_loginview_logged_in_as", "I");
					return JNIEnv.GetStaticIntField (class_ref, com_facebook_loginview_logged_in_as_jfieldId);
				}
				set {
					if (com_facebook_loginview_logged_in_as_jfieldId == IntPtr.Zero)
						com_facebook_loginview_logged_in_as_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_loginview_logged_in_as", "I");
					JNIEnv.SetStaticField (class_ref, com_facebook_loginview_logged_in_as_jfieldId, value);
				}
			}

			static IntPtr com_facebook_loginview_logged_in_using_facebook_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.string']/field[@name='com_facebook_loginview_logged_in_using_facebook']"
			[Register ("com_facebook_loginview_logged_in_using_facebook")]
			public static int ComFacebookLoginviewLoggedInUsingFacebook {
				get {
					if (com_facebook_loginview_logged_in_using_facebook_jfieldId == IntPtr.Zero)
						com_facebook_loginview_logged_in_using_facebook_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_loginview_logged_in_using_facebook", "I");
					return JNIEnv.GetStaticIntField (class_ref, com_facebook_loginview_logged_in_using_facebook_jfieldId);
				}
				set {
					if (com_facebook_loginview_logged_in_using_facebook_jfieldId == IntPtr.Zero)
						com_facebook_loginview_logged_in_using_facebook_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_loginview_logged_in_using_facebook", "I");
					JNIEnv.SetStaticField (class_ref, com_facebook_loginview_logged_in_using_facebook_jfieldId, value);
				}
			}

			static IntPtr com_facebook_logo_content_description_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.string']/field[@name='com_facebook_logo_content_description']"
			[Register ("com_facebook_logo_content_description")]
			public static int ComFacebookLogoContentDescription {
				get {
					if (com_facebook_logo_content_description_jfieldId == IntPtr.Zero)
						com_facebook_logo_content_description_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_logo_content_description", "I");
					return JNIEnv.GetStaticIntField (class_ref, com_facebook_logo_content_description_jfieldId);
				}
				set {
					if (com_facebook_logo_content_description_jfieldId == IntPtr.Zero)
						com_facebook_logo_content_description_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_logo_content_description", "I");
					JNIEnv.SetStaticField (class_ref, com_facebook_logo_content_description_jfieldId, value);
				}
			}

			static IntPtr com_facebook_nearby_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.string']/field[@name='com_facebook_nearby']"
			[Register ("com_facebook_nearby")]
			public static int ComFacebookNearby {
				get {
					if (com_facebook_nearby_jfieldId == IntPtr.Zero)
						com_facebook_nearby_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_nearby", "I");
					return JNIEnv.GetStaticIntField (class_ref, com_facebook_nearby_jfieldId);
				}
				set {
					if (com_facebook_nearby_jfieldId == IntPtr.Zero)
						com_facebook_nearby_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_nearby", "I");
					JNIEnv.SetStaticField (class_ref, com_facebook_nearby_jfieldId, value);
				}
			}

			static IntPtr com_facebook_picker_done_button_text_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.string']/field[@name='com_facebook_picker_done_button_text']"
			[Register ("com_facebook_picker_done_button_text")]
			public static int ComFacebookPickerDoneButtonText {
				get {
					if (com_facebook_picker_done_button_text_jfieldId == IntPtr.Zero)
						com_facebook_picker_done_button_text_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_picker_done_button_text", "I");
					return JNIEnv.GetStaticIntField (class_ref, com_facebook_picker_done_button_text_jfieldId);
				}
				set {
					if (com_facebook_picker_done_button_text_jfieldId == IntPtr.Zero)
						com_facebook_picker_done_button_text_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_picker_done_button_text", "I");
					JNIEnv.SetStaticField (class_ref, com_facebook_picker_done_button_text_jfieldId, value);
				}
			}

			static IntPtr com_facebook_placepicker_subtitle_catetory_only_format_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.string']/field[@name='com_facebook_placepicker_subtitle_catetory_only_format']"
			[Register ("com_facebook_placepicker_subtitle_catetory_only_format")]
			public static int ComFacebookPlacepickerSubtitleCatetoryOnlyFormat {
				get {
					if (com_facebook_placepicker_subtitle_catetory_only_format_jfieldId == IntPtr.Zero)
						com_facebook_placepicker_subtitle_catetory_only_format_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_placepicker_subtitle_catetory_only_format", "I");
					return JNIEnv.GetStaticIntField (class_ref, com_facebook_placepicker_subtitle_catetory_only_format_jfieldId);
				}
				set {
					if (com_facebook_placepicker_subtitle_catetory_only_format_jfieldId == IntPtr.Zero)
						com_facebook_placepicker_subtitle_catetory_only_format_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_placepicker_subtitle_catetory_only_format", "I");
					JNIEnv.SetStaticField (class_ref, com_facebook_placepicker_subtitle_catetory_only_format_jfieldId, value);
				}
			}

			static IntPtr com_facebook_placepicker_subtitle_format_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.string']/field[@name='com_facebook_placepicker_subtitle_format']"
			[Register ("com_facebook_placepicker_subtitle_format")]
			public static int ComFacebookPlacepickerSubtitleFormat {
				get {
					if (com_facebook_placepicker_subtitle_format_jfieldId == IntPtr.Zero)
						com_facebook_placepicker_subtitle_format_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_placepicker_subtitle_format", "I");
					return JNIEnv.GetStaticIntField (class_ref, com_facebook_placepicker_subtitle_format_jfieldId);
				}
				set {
					if (com_facebook_placepicker_subtitle_format_jfieldId == IntPtr.Zero)
						com_facebook_placepicker_subtitle_format_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_placepicker_subtitle_format", "I");
					JNIEnv.SetStaticField (class_ref, com_facebook_placepicker_subtitle_format_jfieldId, value);
				}
			}

			static IntPtr com_facebook_placepicker_subtitle_were_here_only_format_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.string']/field[@name='com_facebook_placepicker_subtitle_were_here_only_format']"
			[Register ("com_facebook_placepicker_subtitle_were_here_only_format")]
			public static int ComFacebookPlacepickerSubtitleWereHereOnlyFormat {
				get {
					if (com_facebook_placepicker_subtitle_were_here_only_format_jfieldId == IntPtr.Zero)
						com_facebook_placepicker_subtitle_were_here_only_format_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_placepicker_subtitle_were_here_only_format", "I");
					return JNIEnv.GetStaticIntField (class_ref, com_facebook_placepicker_subtitle_were_here_only_format_jfieldId);
				}
				set {
					if (com_facebook_placepicker_subtitle_were_here_only_format_jfieldId == IntPtr.Zero)
						com_facebook_placepicker_subtitle_were_here_only_format_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_placepicker_subtitle_were_here_only_format", "I");
					JNIEnv.SetStaticField (class_ref, com_facebook_placepicker_subtitle_were_here_only_format_jfieldId, value);
				}
			}

			static IntPtr com_facebook_requesterror_password_changed_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.string']/field[@name='com_facebook_requesterror_password_changed']"
			[Register ("com_facebook_requesterror_password_changed")]
			public static int ComFacebookRequesterrorPasswordChanged {
				get {
					if (com_facebook_requesterror_password_changed_jfieldId == IntPtr.Zero)
						com_facebook_requesterror_password_changed_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_requesterror_password_changed", "I");
					return JNIEnv.GetStaticIntField (class_ref, com_facebook_requesterror_password_changed_jfieldId);
				}
				set {
					if (com_facebook_requesterror_password_changed_jfieldId == IntPtr.Zero)
						com_facebook_requesterror_password_changed_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_requesterror_password_changed", "I");
					JNIEnv.SetStaticField (class_ref, com_facebook_requesterror_password_changed_jfieldId, value);
				}
			}

			static IntPtr com_facebook_requesterror_permissions_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.string']/field[@name='com_facebook_requesterror_permissions']"
			[Register ("com_facebook_requesterror_permissions")]
			public static int ComFacebookRequesterrorPermissions {
				get {
					if (com_facebook_requesterror_permissions_jfieldId == IntPtr.Zero)
						com_facebook_requesterror_permissions_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_requesterror_permissions", "I");
					return JNIEnv.GetStaticIntField (class_ref, com_facebook_requesterror_permissions_jfieldId);
				}
				set {
					if (com_facebook_requesterror_permissions_jfieldId == IntPtr.Zero)
						com_facebook_requesterror_permissions_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_requesterror_permissions", "I");
					JNIEnv.SetStaticField (class_ref, com_facebook_requesterror_permissions_jfieldId, value);
				}
			}

			static IntPtr com_facebook_requesterror_reconnect_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.string']/field[@name='com_facebook_requesterror_reconnect']"
			[Register ("com_facebook_requesterror_reconnect")]
			public static int ComFacebookRequesterrorReconnect {
				get {
					if (com_facebook_requesterror_reconnect_jfieldId == IntPtr.Zero)
						com_facebook_requesterror_reconnect_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_requesterror_reconnect", "I");
					return JNIEnv.GetStaticIntField (class_ref, com_facebook_requesterror_reconnect_jfieldId);
				}
				set {
					if (com_facebook_requesterror_reconnect_jfieldId == IntPtr.Zero)
						com_facebook_requesterror_reconnect_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_requesterror_reconnect", "I");
					JNIEnv.SetStaticField (class_ref, com_facebook_requesterror_reconnect_jfieldId, value);
				}
			}

			static IntPtr com_facebook_requesterror_relogin_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.string']/field[@name='com_facebook_requesterror_relogin']"
			[Register ("com_facebook_requesterror_relogin")]
			public static int ComFacebookRequesterrorRelogin {
				get {
					if (com_facebook_requesterror_relogin_jfieldId == IntPtr.Zero)
						com_facebook_requesterror_relogin_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_requesterror_relogin", "I");
					return JNIEnv.GetStaticIntField (class_ref, com_facebook_requesterror_relogin_jfieldId);
				}
				set {
					if (com_facebook_requesterror_relogin_jfieldId == IntPtr.Zero)
						com_facebook_requesterror_relogin_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_requesterror_relogin", "I");
					JNIEnv.SetStaticField (class_ref, com_facebook_requesterror_relogin_jfieldId, value);
				}
			}

			static IntPtr com_facebook_requesterror_web_login_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.string']/field[@name='com_facebook_requesterror_web_login']"
			[Register ("com_facebook_requesterror_web_login")]
			public static int ComFacebookRequesterrorWebLogin {
				get {
					if (com_facebook_requesterror_web_login_jfieldId == IntPtr.Zero)
						com_facebook_requesterror_web_login_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_requesterror_web_login", "I");
					return JNIEnv.GetStaticIntField (class_ref, com_facebook_requesterror_web_login_jfieldId);
				}
				set {
					if (com_facebook_requesterror_web_login_jfieldId == IntPtr.Zero)
						com_facebook_requesterror_web_login_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_requesterror_web_login", "I");
					JNIEnv.SetStaticField (class_ref, com_facebook_requesterror_web_login_jfieldId, value);
				}
			}

			static IntPtr com_facebook_usersettingsfragment_log_in_button_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.string']/field[@name='com_facebook_usersettingsfragment_log_in_button']"
			[Register ("com_facebook_usersettingsfragment_log_in_button")]
			public static int ComFacebookUsersettingsfragmentLogInButton {
				get {
					if (com_facebook_usersettingsfragment_log_in_button_jfieldId == IntPtr.Zero)
						com_facebook_usersettingsfragment_log_in_button_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_usersettingsfragment_log_in_button", "I");
					return JNIEnv.GetStaticIntField (class_ref, com_facebook_usersettingsfragment_log_in_button_jfieldId);
				}
				set {
					if (com_facebook_usersettingsfragment_log_in_button_jfieldId == IntPtr.Zero)
						com_facebook_usersettingsfragment_log_in_button_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_usersettingsfragment_log_in_button", "I");
					JNIEnv.SetStaticField (class_ref, com_facebook_usersettingsfragment_log_in_button_jfieldId, value);
				}
			}

			static IntPtr com_facebook_usersettingsfragment_logged_in_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.string']/field[@name='com_facebook_usersettingsfragment_logged_in']"
			[Register ("com_facebook_usersettingsfragment_logged_in")]
			public static int ComFacebookUsersettingsfragmentLoggedIn {
				get {
					if (com_facebook_usersettingsfragment_logged_in_jfieldId == IntPtr.Zero)
						com_facebook_usersettingsfragment_logged_in_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_usersettingsfragment_logged_in", "I");
					return JNIEnv.GetStaticIntField (class_ref, com_facebook_usersettingsfragment_logged_in_jfieldId);
				}
				set {
					if (com_facebook_usersettingsfragment_logged_in_jfieldId == IntPtr.Zero)
						com_facebook_usersettingsfragment_logged_in_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_usersettingsfragment_logged_in", "I");
					JNIEnv.SetStaticField (class_ref, com_facebook_usersettingsfragment_logged_in_jfieldId, value);
				}
			}

			static IntPtr com_facebook_usersettingsfragment_not_logged_in_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.string']/field[@name='com_facebook_usersettingsfragment_not_logged_in']"
			[Register ("com_facebook_usersettingsfragment_not_logged_in")]
			public static int ComFacebookUsersettingsfragmentNotLoggedIn {
				get {
					if (com_facebook_usersettingsfragment_not_logged_in_jfieldId == IntPtr.Zero)
						com_facebook_usersettingsfragment_not_logged_in_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_usersettingsfragment_not_logged_in", "I");
					return JNIEnv.GetStaticIntField (class_ref, com_facebook_usersettingsfragment_not_logged_in_jfieldId);
				}
				set {
					if (com_facebook_usersettingsfragment_not_logged_in_jfieldId == IntPtr.Zero)
						com_facebook_usersettingsfragment_not_logged_in_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_usersettingsfragment_not_logged_in", "I");
					JNIEnv.SetStaticField (class_ref, com_facebook_usersettingsfragment_not_logged_in_jfieldId, value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/parse/R$string", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (String); }
			}

			internal String (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.parse']/class[@name='R.string']/constructor[@name='R.string' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public String () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (String)) {
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

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.parse']/class[@name='R.style']"
		[global::Android.Runtime.Register ("com/parse/R$style", DoNotGenerateAcw=true)]
		public sealed partial class Style : global::Java.Lang.Object {


			static IntPtr com_facebook_loginview_default_style_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.style']/field[@name='com_facebook_loginview_default_style']"
			[Register ("com_facebook_loginview_default_style")]
			public static int ComFacebookLoginviewDefaultStyle {
				get {
					if (com_facebook_loginview_default_style_jfieldId == IntPtr.Zero)
						com_facebook_loginview_default_style_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_loginview_default_style", "I");
					return JNIEnv.GetStaticIntField (class_ref, com_facebook_loginview_default_style_jfieldId);
				}
				set {
					if (com_facebook_loginview_default_style_jfieldId == IntPtr.Zero)
						com_facebook_loginview_default_style_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_loginview_default_style", "I");
					JNIEnv.SetStaticField (class_ref, com_facebook_loginview_default_style_jfieldId, value);
				}
			}

			static IntPtr com_facebook_loginview_silver_style_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.style']/field[@name='com_facebook_loginview_silver_style']"
			[Register ("com_facebook_loginview_silver_style")]
			public static int ComFacebookLoginviewSilverStyle {
				get {
					if (com_facebook_loginview_silver_style_jfieldId == IntPtr.Zero)
						com_facebook_loginview_silver_style_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_loginview_silver_style", "I");
					return JNIEnv.GetStaticIntField (class_ref, com_facebook_loginview_silver_style_jfieldId);
				}
				set {
					if (com_facebook_loginview_silver_style_jfieldId == IntPtr.Zero)
						com_facebook_loginview_silver_style_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_loginview_silver_style", "I");
					JNIEnv.SetStaticField (class_ref, com_facebook_loginview_silver_style_jfieldId, value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/parse/R$style", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Style); }
			}

			internal Style (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.parse']/class[@name='R.style']/constructor[@name='R.style' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public Style () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (Style)) {
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

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.parse']/class[@name='R.styleable']"
		[global::Android.Runtime.Register ("com/parse/R$styleable", DoNotGenerateAcw=true)]
		public sealed partial class Styleable : global::Java.Lang.Object {


			static IntPtr com_facebook_friend_picker_fragment_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.styleable']/field[@name='com_facebook_friend_picker_fragment']"
			[Register ("com_facebook_friend_picker_fragment")]
			public static IList<int> ComFacebookFriendPickerFragment {
				get {
					if (com_facebook_friend_picker_fragment_jfieldId == IntPtr.Zero)
						com_facebook_friend_picker_fragment_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_friend_picker_fragment", "[I");
					return JavaArray<int>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, com_facebook_friend_picker_fragment_jfieldId), JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (com_facebook_friend_picker_fragment_jfieldId == IntPtr.Zero)
						com_facebook_friend_picker_fragment_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_friend_picker_fragment", "[I");
					IntPtr native_value = JavaArray<int>.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, com_facebook_friend_picker_fragment_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.styleable']/field[@name='com_facebook_friend_picker_fragment_multi_select']"
			[Register ("com_facebook_friend_picker_fragment_multi_select")]
			public const int ComFacebookFriendPickerFragmentMultiSelect = (int) 0;

			static IntPtr com_facebook_login_view_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.styleable']/field[@name='com_facebook_login_view']"
			[Register ("com_facebook_login_view")]
			public static IList<int> ComFacebookLoginView {
				get {
					if (com_facebook_login_view_jfieldId == IntPtr.Zero)
						com_facebook_login_view_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_login_view", "[I");
					return JavaArray<int>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, com_facebook_login_view_jfieldId), JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (com_facebook_login_view_jfieldId == IntPtr.Zero)
						com_facebook_login_view_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_login_view", "[I");
					IntPtr native_value = JavaArray<int>.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, com_facebook_login_view_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.styleable']/field[@name='com_facebook_login_view_confirm_logout']"
			[Register ("com_facebook_login_view_confirm_logout")]
			public const int ComFacebookLoginViewConfirmLogout = (int) 0;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.styleable']/field[@name='com_facebook_login_view_fetch_user_info']"
			[Register ("com_facebook_login_view_fetch_user_info")]
			public const int ComFacebookLoginViewFetchUserInfo = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.styleable']/field[@name='com_facebook_login_view_login_text']"
			[Register ("com_facebook_login_view_login_text")]
			public const int ComFacebookLoginViewLoginText = (int) 2;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.styleable']/field[@name='com_facebook_login_view_logout_text']"
			[Register ("com_facebook_login_view_logout_text")]
			public const int ComFacebookLoginViewLogoutText = (int) 3;

			static IntPtr com_facebook_picker_fragment_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.styleable']/field[@name='com_facebook_picker_fragment']"
			[Register ("com_facebook_picker_fragment")]
			public static IList<int> ComFacebookPickerFragment {
				get {
					if (com_facebook_picker_fragment_jfieldId == IntPtr.Zero)
						com_facebook_picker_fragment_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_picker_fragment", "[I");
					return JavaArray<int>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, com_facebook_picker_fragment_jfieldId), JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (com_facebook_picker_fragment_jfieldId == IntPtr.Zero)
						com_facebook_picker_fragment_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_picker_fragment", "[I");
					IntPtr native_value = JavaArray<int>.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, com_facebook_picker_fragment_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.styleable']/field[@name='com_facebook_picker_fragment_done_button_background']"
			[Register ("com_facebook_picker_fragment_done_button_background")]
			public const int ComFacebookPickerFragmentDoneButtonBackground = (int) 6;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.styleable']/field[@name='com_facebook_picker_fragment_done_button_text']"
			[Register ("com_facebook_picker_fragment_done_button_text")]
			public const int ComFacebookPickerFragmentDoneButtonText = (int) 4;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.styleable']/field[@name='com_facebook_picker_fragment_extra_fields']"
			[Register ("com_facebook_picker_fragment_extra_fields")]
			public const int ComFacebookPickerFragmentExtraFields = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.styleable']/field[@name='com_facebook_picker_fragment_show_pictures']"
			[Register ("com_facebook_picker_fragment_show_pictures")]
			public const int ComFacebookPickerFragmentShowPictures = (int) 0;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.styleable']/field[@name='com_facebook_picker_fragment_show_title_bar']"
			[Register ("com_facebook_picker_fragment_show_title_bar")]
			public const int ComFacebookPickerFragmentShowTitleBar = (int) 2;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.styleable']/field[@name='com_facebook_picker_fragment_title_bar_background']"
			[Register ("com_facebook_picker_fragment_title_bar_background")]
			public const int ComFacebookPickerFragmentTitleBarBackground = (int) 5;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.styleable']/field[@name='com_facebook_picker_fragment_title_text']"
			[Register ("com_facebook_picker_fragment_title_text")]
			public const int ComFacebookPickerFragmentTitleText = (int) 3;

			static IntPtr com_facebook_place_picker_fragment_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.styleable']/field[@name='com_facebook_place_picker_fragment']"
			[Register ("com_facebook_place_picker_fragment")]
			public static IList<int> ComFacebookPlacePickerFragment {
				get {
					if (com_facebook_place_picker_fragment_jfieldId == IntPtr.Zero)
						com_facebook_place_picker_fragment_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_place_picker_fragment", "[I");
					return JavaArray<int>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, com_facebook_place_picker_fragment_jfieldId), JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (com_facebook_place_picker_fragment_jfieldId == IntPtr.Zero)
						com_facebook_place_picker_fragment_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_place_picker_fragment", "[I");
					IntPtr native_value = JavaArray<int>.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, com_facebook_place_picker_fragment_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.styleable']/field[@name='com_facebook_place_picker_fragment_radius_in_meters']"
			[Register ("com_facebook_place_picker_fragment_radius_in_meters")]
			public const int ComFacebookPlacePickerFragmentRadiusInMeters = (int) 0;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.styleable']/field[@name='com_facebook_place_picker_fragment_results_limit']"
			[Register ("com_facebook_place_picker_fragment_results_limit")]
			public const int ComFacebookPlacePickerFragmentResultsLimit = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.styleable']/field[@name='com_facebook_place_picker_fragment_search_text']"
			[Register ("com_facebook_place_picker_fragment_search_text")]
			public const int ComFacebookPlacePickerFragmentSearchText = (int) 2;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.styleable']/field[@name='com_facebook_place_picker_fragment_show_search_box']"
			[Register ("com_facebook_place_picker_fragment_show_search_box")]
			public const int ComFacebookPlacePickerFragmentShowSearchBox = (int) 3;

			static IntPtr com_facebook_profile_picture_view_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.styleable']/field[@name='com_facebook_profile_picture_view']"
			[Register ("com_facebook_profile_picture_view")]
			public static IList<int> ComFacebookProfilePictureView {
				get {
					if (com_facebook_profile_picture_view_jfieldId == IntPtr.Zero)
						com_facebook_profile_picture_view_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_profile_picture_view", "[I");
					return JavaArray<int>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, com_facebook_profile_picture_view_jfieldId), JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (com_facebook_profile_picture_view_jfieldId == IntPtr.Zero)
						com_facebook_profile_picture_view_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "com_facebook_profile_picture_view", "[I");
					IntPtr native_value = JavaArray<int>.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, com_facebook_profile_picture_view_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.styleable']/field[@name='com_facebook_profile_picture_view_is_cropped']"
			[Register ("com_facebook_profile_picture_view_is_cropped")]
			public const int ComFacebookProfilePictureViewIsCropped = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.parse']/class[@name='R.styleable']/field[@name='com_facebook_profile_picture_view_preset_size']"
			[Register ("com_facebook_profile_picture_view_preset_size")]
			public const int ComFacebookProfilePictureViewPresetSize = (int) 0;
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/parse/R$styleable", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Styleable); }
			}

			internal Styleable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.parse']/class[@name='R.styleable']/constructor[@name='R.styleable' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public Styleable () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (Styleable)) {
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

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/parse/R", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (R); }
		}

		internal R (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.parse']/class[@name='R']/constructor[@name='R' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public R () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (R)) {
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

	}
}
