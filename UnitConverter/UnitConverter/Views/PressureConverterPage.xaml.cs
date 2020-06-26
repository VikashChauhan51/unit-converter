
using UnitConverter.Converters;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UnitConverter.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PressureConverterPage : ContentPage
    {
        private readonly IUnitConverter _pressureConverter;
        public PressureConverterPage()
        {
            InitializeComponent();
            Title = "Pressure Converter";
            _pressureConverter = new PressureConverter();
            UnitView.Converter = _pressureConverter;
            UnitView.Title = "Pressure Converter";
        }
    }
}