using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Content;
using Android.Gms.Ads;

namespace UnitConverter.Droid
{
    [Activity(Label = "Unit Converter", Icon = "@mipmap/icon", Theme = "@style/MainTheme", LaunchMode = LaunchMode.SingleTop, MainLauncher = false, ScreenOrientation = ScreenOrientation.Portrait, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);
            MobileAds.Initialize(ApplicationContext, "ca-app-pub-1735888914949943~5490391091");
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App());
        }
        public override void OnTrimMemory([GeneratedEnum] TrimMemory level)
        {

            base.OnTrimMemory(level);
            GC.Collect(GC.MaxGeneration, GCCollectionMode.Forced);
            base.OnTrimMemory(level);
        }
    }
}