using UnitConverter.Models;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace UnitConverter.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        MainPage RootPage { get => Application.Current.MainPage as MainPage; }
        static readonly List<HomeMenuItem> menuItems = new List<HomeMenuItem>
            {
                new HomeMenuItem { Title="Acceleration Converter", Icon="acceleration.png",TargetType=typeof(AccelerationConverterPage) },
                new HomeMenuItem { Title="Area Converter", Icon="area.png",TargetType=typeof(AreaConverterPage) },
                new HomeMenuItem { Title="Angle Converter", Icon="angle.png",TargetType=typeof(AngleConverterPage) },
                new HomeMenuItem { Title="Blood Sugar Converter", Icon="drop.png",TargetType=typeof(BloodSugarConverterPage) },
                new HomeMenuItem { Title="Capacitance Converter", Icon="capacitor.png",TargetType=typeof(CapacitanceConverterPage) },
                new HomeMenuItem { Title="Data Storage Converter", Icon="disk.png",TargetType=typeof(DataStorageConverterPage) },
                new HomeMenuItem { Title="Data Transfer Converter", Icon="transfer.png",TargetType=typeof(DataTransferConverterPage) },
                new HomeMenuItem { Title="Density Converter", Icon="filter.png",TargetType=typeof(DensityConverterPage) },
                new HomeMenuItem { Title="Electric Charge Converter", Icon="electricity.png",TargetType=typeof(ElectricChargeConverterPage) },
                new HomeMenuItem { Title="Energy Converter", Icon="lightning.png",TargetType=typeof(EnergyConverterPage) },
                new HomeMenuItem { Title="Force Converter", Icon="lever.png",TargetType=typeof(ForceConverterPage) },
                new HomeMenuItem { Title="Illuminance Converter", Icon="idea.png",TargetType=typeof(IlluminanceConverterPage) },
                new HomeMenuItem { Title="Inductance Converter", Icon="induction.png",TargetType=typeof(InductanceConverterPage) },
                new HomeMenuItem { Title="Length Converter", Icon="length.png",TargetType=typeof(LengthConverterPage) },
                new HomeMenuItem { Title="Magnetic Field Converter", Icon="magnet.png",TargetType=typeof(MagneticFieldConverterPage) },
                new HomeMenuItem { Title="Magnetic Field Strength", Icon="tower.png",TargetType=typeof(MagneticFieldStrengthConverterPage) },
                new HomeMenuItem { Title="Magnetic Flux Converter", Icon="iron.png",TargetType=typeof(MagneticFluxConverterPage) },
                new HomeMenuItem { Title="Metric Converter", Icon="task.png",TargetType=typeof(MetricConverterPage) },
                new HomeMenuItem { Title="Molar Mass Converter", Icon="dot.png",TargetType=typeof(MolarMassConverterPage) },
                new HomeMenuItem { Title="Power Converter", Icon="power.png",TargetType=typeof(PowerConverterPage) },
                new HomeMenuItem { Title="Pressure Converter", Icon="indicator.png",TargetType=typeof(PressureConverterPage) },
                new HomeMenuItem { Title="Radioactive Decay Converter", Icon="ultraviolet.png",TargetType=typeof(RadioactiveDecayPage) },
                new HomeMenuItem { Title="Resistance Converter", Icon="flash.png",TargetType=typeof(ElectricalResistanceConverterPage) },
                new HomeMenuItem { Title="Speed Converter", Icon="speed.png",TargetType=typeof(SpeedConverterPage) },
                new HomeMenuItem { Title="Time Converter", Icon="time.png",TargetType=typeof(TimeConverterPage) },
                new HomeMenuItem { Title="Temperature Converter", Icon="temperature.png",TargetType=typeof(TemperatureConverterPage) },
                new HomeMenuItem { Title="Torque Converter", Icon="system.png",TargetType=typeof(TorqueConverterPage) },
                new HomeMenuItem { Title="Volume Converter", Icon="flask.png",TargetType=typeof(VolumeConverterPage) },
                new HomeMenuItem { Title="Weight Converter", Icon="work.png",TargetType=typeof(WeightConverterPage) },

                new HomeMenuItem {Title="About",Icon="info.png",TargetType=typeof(AboutPage) }
            };
        public MenuPage()
        {
            InitializeComponent();


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