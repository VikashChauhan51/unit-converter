using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitConverter.Converters;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UnitConverter.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ForceConverterPage : ContentPage
    {
        private readonly IUnitConverter _forceConverter;
        public ForceConverterPage()
        {
            InitializeComponent();
            Title = "Force Converter";
            _forceConverter = new ForceConverter();
            UnitView.Converter = _forceConverter;
            UnitView.Title = "Force Converter";
        }
    }
}