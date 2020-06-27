using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace UnitConverter.Droid
{
    [Activity(Theme = "@style/SplashTheme", MainLauncher = true, NoHistory = true, ScreenOrientation = ScreenOrientation.Portrait, ConfigurationChanges = ConfigChanges.ScreenSize)]
    public class SplashActivity : Activity
    {
        public override void OnCreate(Bundle savedInstanceState, PersistableBundle persistentState)
        {
            base.OnCreate(savedInstanceState, persistentState);

        }

        // Launches the startup task
        protected override void OnResume()
        {
            base.OnResume();
            SimulateStartup();

        }

        // Simulates background work that happens behind the splash screen
        void SimulateStartup() => StartActivity(new Intent(Application.Context, typeof(MainActivity)));
    }
}