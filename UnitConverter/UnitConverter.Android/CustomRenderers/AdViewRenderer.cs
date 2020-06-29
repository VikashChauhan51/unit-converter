using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Gms.Ads;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using UnitConverter.Components;
using UnitConverter.Droid.CustomRenderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(AdControlView), typeof(AdViewRenderer))]
namespace UnitConverter.Droid.CustomRenderers
{
    public class AdViewRenderer : ViewRenderer<AdControlView, AdView>
    {
        static readonly string adUnitId = "ca-app-pub-1735888914949943/5107247712";
        //Note you may want to adjust this, see further down.

        public AdViewRenderer(Context context) : base(context)
        {

        }

        protected override void OnElementChanged(ElementChangedEventArgs<AdControlView> e)
        {
            base.OnElementChanged(e);
            try
            {
                if (e.NewElement != null && Control == null)
                {
                    SetNativeControl(CreateAdView());
                }
            }
            catch
            {


            }
        }

        private AdView CreateAdView()
        {
            var adView = new AdView(Context)
            {
                AdSize = AdSize.SmartBanner,
                AdUnitId = adUnitId
            };

            adView.LayoutParameters = new LinearLayout.LayoutParams(LayoutParams.MatchParent, LayoutParams.MatchParent);

            adView.LoadAd(new AdRequest.Builder().Build());

            return adView;
        }

    }
}