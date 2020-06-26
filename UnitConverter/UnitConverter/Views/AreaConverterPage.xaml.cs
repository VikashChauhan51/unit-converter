
using UnitConverter.Converters;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UnitConverter.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AreaConverterPage : ContentPage
    {
        private readonly IUnitConverter _areaConverter;
        public AreaConverterPage()
        {
            InitializeComponent();
            Title = "Area Converter";
            _areaConverter = new AreaConverter();
            UnitView.Converter = _areaConverter;
            UnitView.Title = "Area Converter";
        }


    }
}