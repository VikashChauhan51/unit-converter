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
    public partial class TemperatureConverterPage : ContentPage
    {
        private readonly IUnitConverter _temperatureConverter;
        public TemperatureConverterPage()
        {
            InitializeComponent();
            Title = "Temperature Converter";
            _temperatureConverter = new TemperatureConverter();
            UnitView.Converter = _temperatureConverter;
            UnitView.Title = "Temperature Converter";
        }

    }
}