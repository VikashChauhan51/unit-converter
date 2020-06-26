
using UnitConverter.Converters;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UnitConverter.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InductanceConverterPage : ContentPage
    {
        private readonly IUnitConverter _inductanceConverter;
        public InductanceConverterPage()
        {
            InitializeComponent();
            Title = "Inductance Converter";
            _inductanceConverter = new InductanceConverter();
            UnitView.Converter = _inductanceConverter;
            UnitView.Title = "Inductance Converter";
        }
    }
}