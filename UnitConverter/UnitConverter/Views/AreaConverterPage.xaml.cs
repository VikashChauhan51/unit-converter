using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitConverter.Components;
using UnitConverter.Converters;
using UnitConverter.Models;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UnitConverter.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AreaConverterPage : ContentPage
    {
        private readonly IUnitConverter _areaConverter;
        string message = string.Empty;
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