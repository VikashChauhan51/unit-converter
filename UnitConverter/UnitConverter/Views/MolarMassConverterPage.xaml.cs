
using UnitConverter.Converters;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UnitConverter.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MolarMassConverterPage : ContentPage
    {
        private readonly IUnitConverter _molarMassConverter;
        public MolarMassConverterPage()
        {
            InitializeComponent();
            Title = "Molar Mass Converter";
            _molarMassConverter = new MolarMassConverter();
            UnitView.Converter = _molarMassConverter;
            UnitView.Title = "Molar Mass Converter";
        }
    }
}