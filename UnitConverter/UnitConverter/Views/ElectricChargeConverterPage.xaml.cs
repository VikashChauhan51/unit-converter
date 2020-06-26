
using UnitConverter.Converters;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UnitConverter.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ElectricChargeConverterPage : ContentPage
    {
        private readonly IUnitConverter _electricChargeConverter;
        public ElectricChargeConverterPage()
        {
            InitializeComponent();
            Title = "Electric Charge Converter";
            _electricChargeConverter = new ElectricChargeConverter();
            UnitView.Converter = _electricChargeConverter;
            UnitView.Title = "Electric Charge Converter";
        }
    }
}