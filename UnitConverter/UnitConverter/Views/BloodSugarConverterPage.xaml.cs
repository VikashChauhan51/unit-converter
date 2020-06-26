
using UnitConverter.Converters;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UnitConverter.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BloodSugarConverterPage : ContentPage
    {
        private readonly IUnitConverter _bloodSugarConverter;
        public BloodSugarConverterPage()
        {
            InitializeComponent();
            Title = "Blood Sugar Converter";
            _bloodSugarConverter = new BloodSugarConverter();
            UnitView.Converter = _bloodSugarConverter;
            UnitView.Title = "Blood Sugar Converter";
        }

    }
}