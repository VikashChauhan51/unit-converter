
using UnitConverter.Converters;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UnitConverter.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LengthConverterPage : ContentPage
    {
        private readonly IUnitConverter _lengthConverter;
         
        public LengthConverterPage()
        {
            InitializeComponent();
            Title = "Length Converter";
            _lengthConverter = new LengthConverter();
            UnitView.Converter = _lengthConverter;
            UnitView.Title = "Length Converter";
        }
        
    }
}