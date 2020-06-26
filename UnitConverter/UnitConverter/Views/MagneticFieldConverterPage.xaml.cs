
using UnitConverter.Converters;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UnitConverter.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MagneticFieldConverterPage : ContentPage
    {
        private readonly IUnitConverter _magneticFieldConverter;
        public MagneticFieldConverterPage()
        {
            InitializeComponent();
            Title = "Magnetic Field Converter";
            _magneticFieldConverter = new MagneticFieldConverter();
            UnitView.Converter = _magneticFieldConverter;
            UnitView.Title = "Magnetic Field Converter";
        }
    }
}