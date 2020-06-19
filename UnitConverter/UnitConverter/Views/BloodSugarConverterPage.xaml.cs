using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitConverter.Converters;
using UnitConverter.Models;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UnitConverter.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class BloodSugarConverterPage : ContentPage
	{
        private readonly IUnitConverter _bloodSugarConverter;
        string message = string.Empty;
        public BloodSugarConverterPage ()
		{
			InitializeComponent ();
            Title = "Blood Sugar Converter";
            _bloodSugarConverter = new BloodSugarConverter();
            FromUnitPicker.ItemsSource = _bloodSugarConverter.GetUnitTypes().ToList();
            ToUnitPicker.ItemsSource = _bloodSugarConverter.GetUnitTypes().ToList();
            FromUnitPicker.SelectedIndex = 0;
            ToUnitPicker.SelectedIndex = 0;
            Reset();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {

            try
            {
                Reset();
                Unit fromType = FromUnitPicker.SelectedItem as Unit;
                Unit toType = ToUnitPicker.SelectedItem as Unit;
                if (fromType != null && toType != null)
                {
                    if (double.TryParse(FromEntry.Text, out double from))
                    {
                        ToEntry.Text = _bloodSugarConverter.Convert(fromType.Id, toType.Id, from);
                        message = $"{FromEntry.Text} {fromType.Text} is equal to {ToEntry.Text} {toType.Text}";
                    }

                }
            }
            catch
            {
                await DisplayAlert("Error", "Something went wrong. Please try again.", "Ok");

            }
        }

        private void Reset()
        {
            message = string.Empty;
            ToEntry.Text = string.Empty;
        }

        private void FromEntry_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender is Entry fromText)
            {
                Reset();

            }
        }

        private async void BtnShare_Clicked(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(message))
            {
                await Share.RequestAsync(new ShareTextRequest
                {
                    Text = message,
                    Title = "Blood Sugar Converter"
                });
            }
        }

        private async void BtnCopy_Clicked(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(message))
            {
                await Clipboard.SetTextAsync(message);
            }
        }

        private void OnSelectedIndexChanged(object sender, EventArgs e)
        {
            Reset();
        }
    }
}