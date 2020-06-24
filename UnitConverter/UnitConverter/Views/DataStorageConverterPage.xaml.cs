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
    public partial class DataStorageConverterPage : ContentPage
    {
        private readonly IUnitConverter _dataStorageConverter;
        public DataStorageConverterPage()
        {
            InitializeComponent();
            Title = "Data Storage Converter";
            _dataStorageConverter = new DataStorageConverter();
            UnitView.Converter = _dataStorageConverter;
            UnitView.Title = "Data Storage Converter";
        }
    }
}