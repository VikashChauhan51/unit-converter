
using UnitConverter.Converters;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UnitConverter.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RadioactiveDecayPage : ContentPage
    {
        private readonly IUnitConverter _radioactiveDecayConverter;
        public RadioactiveDecayPage()
        {
            InitializeComponent();
            Title = "Radioactive Decay Converter";
            _radioactiveDecayConverter = new RadioactiveDecay();
            UnitView.Converter = _radioactiveDecayConverter;
            UnitView.Title = "Radioactive Decay Converter";
        }
    }
}