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
        string adUnitId = "ca-app-pub-1735888914949943/5107247712";
        //Note you may want to adjust this, see further down.
        AdSize adSize = AdSize.SmartBanner;
        AdView adView;
        private Context _context;
        public AdViewRenderer(Context context) : base(context)
        {
            _context = context;
        }

        protected override void OnElementChanged(ElementChangedEventArgs<AdControlView> e)
        {
            base.OnElementChanged(e);
            try
            {
                if (Control == null)
                {
                    CreateNativeAdControl();
                    SetNativeControl(adView);
                }
            }
            catch
            {


            }
        }

        AdView CreateNativeAdControl()
        {
            if (adView != null)
                return adView;


            adView = new AdView(_context);
            adView.AdSize = adSize;
            adView.AdUnitId = adUnitId;

            var adParams = new LinearLayout.LayoutParams(LayoutParams.WrapContent, LayoutParams.WrapContent);

            adView.LayoutParameters = adParams;

            adView.LoadAd(new AdRequest
                            .Builder()
                            .Build());
            return adView;
        }

    }
}