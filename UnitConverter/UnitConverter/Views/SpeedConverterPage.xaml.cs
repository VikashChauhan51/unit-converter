
using UnitConverter.Converters;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UnitConverter.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SpeedConverterPage : ContentPage
    {
        private readonly IUnitConverter _speedConverter;
        public SpeedConverterPage()
        {
            InitializeComponent();
            Title = "Speed Converter";
            _speedConverter = new SpeedConverter();
            UnitView.Converter = _speedConverter;
            UnitView.Title = "Speed Converter";
        }
    }
}