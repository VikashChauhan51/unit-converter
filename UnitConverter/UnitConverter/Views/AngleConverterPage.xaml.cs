
using UnitConverter.Converters;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UnitConverter.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AngleConverterPage : ContentPage
    {
        private readonly IUnitConverter _angleConverter;
        public AngleConverterPage()
        {
            InitializeComponent();
            Title = "Angle Converter";
            _angleConverter = new AngleConverter();
            UnitView.Converter = _angleConverter;
            UnitView.Title = "Angle Converter";
        }
    }
}