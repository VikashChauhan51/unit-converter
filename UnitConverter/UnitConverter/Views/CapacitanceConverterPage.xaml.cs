
using UnitConverter.Converters;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UnitConverter.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CapacitanceConverterPage : ContentPage
    {
        private readonly IUnitConverter _capacitanceConverter;
        public CapacitanceConverterPage()
        {
            InitializeComponent();
            Title = "Capacitance Converter";
            _capacitanceConverter = new CapacitanceConverter();
            UnitView.Converter = _capacitanceConverter;
            UnitView.Title = "Capacitance Converter";
        }
    }
}