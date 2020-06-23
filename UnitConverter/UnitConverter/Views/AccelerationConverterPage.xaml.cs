using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitConverter.Converters;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UnitConverter.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AccelerationConverterPage : ContentPage
    {
        private readonly IUnitConverter _accelerationConverter;
        public AccelerationConverterPage()
        {
            InitializeComponent();
            Title = "Acceleration Converter";
            _accelerationConverter = new AccelerationConverter();
            UnitView.Converter = _accelerationConverter;
            UnitView.Title = "Acceleration Converter";
        }
    }
}