using System.Diagnostics;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Microsoft.AppCenter.Push;

using Xamarin.Forms;

namespace PushSample
{
    public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

            Push.PushNotificationReceived += (s, e) =>
            {
                Debug.WriteLine("Notification Received!!!");
                Debug.WriteLine($"Title: {e.Title}");
                Debug.WriteLine($"Message: {e.Message}");
            };

            AppCenter.Start("android=6bdc104b-28ae-4cb8-bbf0-d7e5d2732357;ios=6b25b60d-25f4-45b1-aaed-9570197cf3cf",
                typeof(Analytics), typeof(Crashes), typeof(Push));

            MainPage = new PushSample.MainPage();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
