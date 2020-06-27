using System;
using System.Linq;
using UnitConverter.Converters;
using UnitConverter.Models;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UnitConverter.Components
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UnitConverterView : ContentView
    {
        string message = string.Empty;
        public UnitConverterView()
        {
            InitializeComponent();
            Reset();

        }

        private void Init()
        {
            var source = Converter?.GetUnitTypes().ToList();
            FromUnitPicker.ItemsSource = source;
            ToUnitPicker.ItemsSource = source;
            FromUnitPicker.SelectedIndex = 0;
            ToUnitPicker.SelectedIndex = 1;
        }

        public static readonly BindableProperty ConverterProperty =
  BindableProperty.Create(nameof(Converter), typeof(IUnitConverter), typeof(UnitConverterView), null, propertyChanged: (bindable, oldV, newV) => ((UnitConverterView)bindable).UpdateConverter((IUnitConverter)oldV, (IUnitConverter)newV));

        public IUnitConverter Converter
        {
            get { return (IUnitConverter)GetValue(ConverterProperty); }
            set { SetValue(ConverterProperty, value); }
        }
        void UpdateConverter(IUnitConverter oldValue, IUnitConverter newValue)
        {
            if (oldValue != newValue)
            {
                Converter = newValue;
                Init();
            }


        }
        public static readonly BindableProperty TitleProperty =
  BindableProperty.Create(nameof(Title), typeof(string), typeof(UnitConverterView), null, propertyChanged: (bindable, oldV, newV) => ((UnitConverterView)bindable).UpdateTitle((string)oldV, (string)newV));

        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }
        void UpdateTitle(string oldValue, string newValue)
        {
            if (oldValue != newValue)
                Title = newValue;

        }

        private async void Button_Clicked(object sender, EventArgs e)
        {

            try
            {
                Reset();
                Unit fromType = FromUnitPicker.SelectedItem as Unit;
                Unit toType = ToUnitPicker.SelectedItem as Unit;
                if (fromType != null && toType != null)
                {
                    if (double.TryParse(FromEntry.Text, out double from))
                    {
                        ToEntry.Text = Converter.Convert(fromType.Id, toType.Id, from);
                        message = $"{FromEntry.Text} {fromType.Text} is equal to {ToEntry.Text} {toType.Text}";
                    }

                }
            }
            catch
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Something went wrong. Please try again.", "Ok");

            }
        }

        private void Reset()
        {
            message = string.Empty;
            ToEntry.Text = string.Empty;
        }

        private void FromEntry_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender is Entry fromText)
            {
                Reset();

            }
        }

        private async void BtnShare_Clicked(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(message))
            {
                await Share.RequestAsync(new ShareTextRequest
                {
                    Text = message,
                    Title = Title
                });
            }
        }

        private async void BtnCopy_Clicked(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(message))
            {
                await Clipboard.SetTextAsync(message);
                DependencyService.Get<IToast>().Show("Copied!");
            }
                
        }

        private void OnSelectedIndexChanged(object sender, EventArgs e)
        {
            Reset();
        }
    }
}