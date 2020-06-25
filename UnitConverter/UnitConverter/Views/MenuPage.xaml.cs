using UnitConverter.Models;
using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Linq;

namespace UnitConverter.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        MainPage RootPage { get => Application.Current.MainPage as MainPage; }
        List<HomeMenuItem> menuItems;
        public MenuPage()
        {
            InitializeComponent();

            menuItems = new List<HomeMenuItem>
            {
                new HomeMenuItem { Title="Area Converter", Icon="area.png",TargetType=typeof(AreaConverterPage) },
                new HomeMenuItem { Title="Angle Converter", Icon="angle.png",TargetType=typeof(AngleConverterPage) },
                new HomeMenuItem { Title="Acceleration Converter", Icon="acceleration.png",TargetType=typeof(AccelerationConverterPage) },
                new HomeMenuItem { Title="Blood Sugar Converter", Icon="drop.png",TargetType=typeof(BloodSugarConverterPage) },
                new HomeMenuItem { Title="Capacitance Converter", Icon="capacitor.png",TargetType=typeof(CapacitanceConverterPage) },
                new HomeMenuItem { Title="Data Storage Converter", Icon="disk.png",TargetType=typeof(DataStorageConverterPage) },
                new HomeMenuItem { Title="Data Transfer Converter", Icon="transfer.png",TargetType=typeof(DataTransferConverterPage) },
                new HomeMenuItem { Title="Density Converter", Icon="filter.png",TargetType=typeof(DensityConverterPage) },
                new HomeMenuItem { Title="Resistance Converter", Icon="flash.png",TargetType=typeof(ElectricalResistanceConverterPage) },
                new HomeMenuItem { Title="Electric Charge Converter", Icon="electricity.png",TargetType=typeof(ElectricChargeConverterPage) },
                new HomeMenuItem { Title="Energy Converter", Icon="lightning.png",TargetType=typeof(EnergyConverterPage) },
                new HomeMenuItem { Title="Length Converter", Icon="length.png",TargetType=typeof(LengthConverterPage) },
                new HomeMenuItem { Title="Time Converter", Icon="time.png",TargetType=typeof(TimeConverterPage) },
                new HomeMenuItem { Title="Temperature Converter", Icon="temperature.png",TargetType=typeof(TemperatureConverterPage) },

                new HomeMenuItem {Title="About",Icon="info.png",TargetType=typeof(AboutPage) }
            };

            ListViewMenu.ItemsSource = menuItems;
            ListViewMenu.SelectedItem = menuItems[0];
            ListViewMenu.ItemSelected += async (sender, e) =>
            {
                if (e.SelectedItem == null)
                    return;

                var page = ((HomeMenuItem)e.SelectedItem).TargetType;
                await RootPage.NavigateFromMenu(page);
            };
        }
    }
}