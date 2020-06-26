
using UnitConverter.Converters;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UnitConverter.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WeightConverterPage : ContentPage
    {
        private readonly IUnitConverter _weightConverter;
        public WeightConverterPage()
        {
            InitializeComponent();
            Title = "Weight Converter";
            _weightConverter = new WeightConverter();
            UnitView.Converter = _weightConverter;
            UnitView.Title = "Weight Converter";
        }
    }
}