
using UnitConverter.Converters;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UnitConverter.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MagneticFluxConverterPage : ContentPage
    {
        private readonly IUnitConverter _magneticFluxConverter;
        public MagneticFluxConverterPage()
        {
            InitializeComponent();
            Title = "Magnetic Flux Converter";
            _magneticFluxConverter = new MagneticFluxConverter();
            UnitView.Converter = _magneticFluxConverter;
            UnitView.Title = "Magnetic Flux Converter";
        }
    }
}