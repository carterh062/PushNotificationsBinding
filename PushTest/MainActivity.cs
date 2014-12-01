using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Net;

namespace PushTest
{
	[Activity (Label = "PushTest", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		int count = 1;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);
			//WebRequest.DefaultWebProxy = authenticateProxy ();

			Com.Parse.Parse.Initialize(this,"xxx","xxx");
			Com.Parse.PushService.SetDefaultPushCallback (this, this.Class);
			Com.Parse.PushService.StartServiceIfRequired (this);
			Com.Parse.ParseInstallation.CurrentInstallation.SaveInBackground ();
			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button> (Resource.Id.myButton);
			button.Click += delegate {
				button.Text = string.Format ("{0} clicks!", count++);
			};
		}
		}
	}
}


