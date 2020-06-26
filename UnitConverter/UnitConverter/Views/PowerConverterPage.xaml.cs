
using UnitConverter.Converters;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UnitConverter.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PowerConverterPage : ContentPage
    {
        private readonly IUnitConverter _powerConverter;
        public PowerConverterPage()
        {
            InitializeComponent();
            Title = "Power Converter";
            _powerConverter = new PowerConverter();
            UnitView.Converter = _powerConverter;
            UnitView.Title = "Power Converter";
        }
    }
}