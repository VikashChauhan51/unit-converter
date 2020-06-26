
using UnitConverter.Converters;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UnitConverter.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MagneticFieldStrengthConverterPage : ContentPage
    {
        private readonly IUnitConverter _magneticFieldStrengthConverter;
        public MagneticFieldStrengthConverterPage()
        {
            InitializeComponent();
            Title = "Magnetic Field Strength";
            _magneticFieldStrengthConverter = new MagneticFieldStrengthConverter();
            UnitView.Converter = _magneticFieldStrengthConverter;
            UnitView.Title = "Magnetic Field Strength";
        }
    }
}