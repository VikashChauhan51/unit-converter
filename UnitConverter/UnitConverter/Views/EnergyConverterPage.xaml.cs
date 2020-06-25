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
    public partial class EnergyConverterPage : ContentPage
    {
        private readonly IUnitConverter _energyConverter;
        public EnergyConverterPage()
        {
            InitializeComponent();
            Title = "Energy Converter";
            _energyConverter = new EnergyConverter();
            UnitView.Converter = _energyConverter;
            UnitView.Title = "Energy Converter";
        }
    }
}