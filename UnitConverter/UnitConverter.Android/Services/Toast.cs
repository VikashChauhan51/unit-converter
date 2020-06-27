
using Android.App;
using Android.Widget;
using UnitConverter.Models;

[assembly: Xamarin.Forms.Dependency(typeof(UnitConverter.Droid.Services.Toast))]
namespace UnitConverter.Droid.Services
{
    public class Toast : IToast
    {
        public void Show(string message)
        {
            Android.Widget.Toast.MakeText(Application.Context, message, ToastLength.Short).Show();
        }
    }
}