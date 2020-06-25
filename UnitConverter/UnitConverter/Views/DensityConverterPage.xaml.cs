
using UnitConverter.Converters;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UnitConverter.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DensityConverterPage : ContentPage
    {
        private readonly IUnitConverter _densityConverter;
        public DensityConverterPage()
        {
            InitializeComponent();
            Title = "Density Converter";
            _densityConverter = new DensityConverter();
            UnitView.Converter = _densityConverter;
            UnitView.Title = "Density Converter";
        }
    }
}