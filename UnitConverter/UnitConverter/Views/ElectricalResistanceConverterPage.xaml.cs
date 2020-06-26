
using UnitConverter.Converters;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UnitConverter.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ElectricalResistanceConverterPage : ContentPage
    {
        private readonly IUnitConverter _resistanceConverter;
        public ElectricalResistanceConverterPage()
        {
            InitializeComponent();
            Title = "Resistance Converter";
            _resistanceConverter = new ElectricalResistanceConverter();
            UnitView.Converter = _resistanceConverter;
            UnitView.Title = "Resistance Converter";
        }
    }
}