
using UnitConverter.Converters;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UnitConverter.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MetricConverterPage : ContentPage
    {
        private readonly IUnitConverter _metricConverter;
        public MetricConverterPage()
        {
            InitializeComponent();
            Title = "Metric Converter";
            _metricConverter = new MetricConverter();
            UnitView.Converter = _metricConverter;
            UnitView.Title = "Metric Converter";
        }
    }
}