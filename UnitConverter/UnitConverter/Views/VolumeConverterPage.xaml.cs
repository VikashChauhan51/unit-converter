
using UnitConverter.Converters;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UnitConverter.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VolumeConverterPage : ContentPage
    {
        private readonly IUnitConverter _volumeConverter;
        public VolumeConverterPage()
        {
            InitializeComponent();
            Title = "Volume Converter";
            _volumeConverter = new VolumeConverter();
            UnitView.Converter = _volumeConverter;
            UnitView.Title = "Volume Converter";
        }
    }
}