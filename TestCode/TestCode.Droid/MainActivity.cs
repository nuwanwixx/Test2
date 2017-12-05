using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace TestCode.Droid
{
	[Activity (Label = "TestCode.Droid", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		int count = 1;
        int c = 1;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button> (Resource.Id.myButton);
            Button submitBtn = FindViewById<Button>(Resource.Id.Button1);
			button.Click += delegate {
				button.Text = string.Format ("{0} clicks!", count++);
			};
            submitBtn.Click += delegate {
                button.Text = string.Format("{0} clicks!", c++); };
		}
	}
}


