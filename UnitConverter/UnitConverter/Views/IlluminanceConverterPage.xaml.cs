
using UnitConverter.Converters;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UnitConverter.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IlluminanceConverterPage : ContentPage
    {
        private readonly IUnitConverter _illuminanceConverter;
        public IlluminanceConverterPage()
        {
            InitializeComponent();
            Title = "Illuminance Converter";
            _illuminanceConverter = new IlluminanceConverter();
            UnitView.Converter = _illuminanceConverter;
            UnitView.Title = "Illuminance Converter";
        }
    }
}