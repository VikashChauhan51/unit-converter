using UnitConverter.Models;
using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

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
                new HomeMenuItem { Title="Length Converter", Icon="length.png",TargetType=typeof(LengthConverterPage) },
                new HomeMenuItem { Title="Time Converter", Icon="time.png",TargetType=typeof(TimeConverterPage) },
                new HomeMenuItem { Title="Temperature Converter", Icon="temperature.png",TargetType=typeof(TemperatureConverterPage) },
                new HomeMenuItem { Title="Blood Sugar Converter", Icon="drop.png",TargetType=typeof(BloodSugarConverterPage) },
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