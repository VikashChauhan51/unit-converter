
using UnitConverter.Converters;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UnitConverter.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DataTransferConverterPage : ContentPage
    {
        private readonly IUnitConverter _dataTransferConverter;
        public DataTransferConverterPage()
        {
            InitializeComponent();
            Title = "Data Transfer Converter";
            _dataTransferConverter = new DataTransferConverter();
            UnitView.Converter = _dataTransferConverter;
            UnitView.Title = "Data Transfer Converter";
        }
    }
}