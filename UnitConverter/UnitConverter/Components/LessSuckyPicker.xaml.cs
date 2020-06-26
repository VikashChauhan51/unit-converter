using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UnitConverter.Components
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LessSuckyPicker : ContentView
    {
        public event EventHandler SelectedIndexChanged;
        public LessSuckyPicker()
        {
            InitializeComponent();
            borderlessPicker.SelectedIndexChanged += BorderlessPicker_SelectedIndexChanged;
        }

        private void BorderlessPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedIndexChanged?.Invoke(sender, e);
        }

        public BorderlessPicker Picker { get => borderlessPicker; set => borderlessPicker = value; }

        public string Title { get => borderlessPicker.Title; set => borderlessPicker.Title = value; }
        public BindingBase ItemDisplayBinding { get => borderlessPicker.ItemDisplayBinding; set => borderlessPicker.ItemDisplayBinding = value; }
        public System.Collections.IList ItemsSource { get => borderlessPicker.ItemsSource; set => borderlessPicker.ItemsSource = value; }
        public object SelectedItem { get => borderlessPicker.SelectedItem; }
        public int SelectedIndex { get => borderlessPicker.SelectedIndex; set => borderlessPicker.SelectedIndex = value; }
    }
}