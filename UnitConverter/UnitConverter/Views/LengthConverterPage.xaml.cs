using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitConverter.Converters;
using UnitConverter.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UnitConverter.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LengthConverterPage : ContentPage
    {
        private readonly IUnitConverter _lengthConverter;
        public LengthConverterPage()
        {
            InitializeComponent();
            Title = "Length Converter";
            _lengthConverter = new LengthConverter();
            FromUnitPicker.ItemsSource = _lengthConverter.GetUnitTypes().ToList();
            ToUnitPicker.ItemsSource = _lengthConverter.GetUnitTypes().ToList();
            FromUnitPicker.SelectedIndex = 0;
            ToUnitPicker.SelectedIndex = 0;

        }
        private async void Button_Clicked(object sender, EventArgs e)
        {

            try
            {
                double from;
                var fromType = FromUnitPicker.SelectedItem as Unit;
                var toType = ToUnitPicker.SelectedItem as Unit;
                if (fromType != null && toType != null)
                {
                    if (double.TryParse(FromEntry.Text, out from))
                    {
                        ToEntry.Text = _lengthConverter.Convert(fromType.Id, toType.Id, from);
                    }

                }
            }
            catch
            {
                await DisplayAlert("Error", "Something went wrong. Please try again.", "Ok");

            }
        }

         
    }
}