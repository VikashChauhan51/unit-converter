using UnitConverter.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UnitConverter.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : MasterDetailPage
    {
        Dictionary<Type, NavigationPage> MenuPages = new Dictionary<Type, NavigationPage>();
        public MainPage()
        {
            InitializeComponent();

            MasterBehavior = MasterBehavior.Popover;

            MenuPages.Add(typeof(AreaConverterPage), (NavigationPage)Detail);
        }

        public async Task NavigateFromMenu(Type page)
        {
            if (!MenuPages.ContainsKey(page))
                MenuPages.Add(page, new NavigationPage((Page)Activator.CreateInstance(page)));
            var newPage = MenuPages[page];

            if (newPage != null && Detail != newPage)
            {
                Detail = newPage;

                if (Device.RuntimePlatform == Device.Android)
                    await Task.Delay(100);

                IsPresented = false;
            }
        }
    }
}