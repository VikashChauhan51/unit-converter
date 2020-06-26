
using UnitConverter.Converters;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UnitConverter.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TorqueConverterPage : ContentPage
    {
        private readonly IUnitConverter _torqueConverter;
        public TorqueConverterPage()
        {
            InitializeComponent();
            Title = "Torque Converter";
            _torqueConverter = new TorqueConverter();
            UnitView.Converter = _torqueConverter;
            UnitView.Title = "Torque Converter";
        }
    }
}