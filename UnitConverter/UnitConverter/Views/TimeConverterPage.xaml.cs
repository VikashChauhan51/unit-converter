
using UnitConverter.Converters;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UnitConverter.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TimeConverterPage : ContentPage
    {
        private readonly IUnitConverter _timeConverter;

        public TimeConverterPage()
        {
            InitializeComponent();
            Title = "Time Converter";
            _timeConverter = new TimeConverter();
            UnitView.Converter = _timeConverter;
            UnitView.Title = "Time Converter";
        }

    }
}