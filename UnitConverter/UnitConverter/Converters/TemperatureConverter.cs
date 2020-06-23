using System;
using System.Collections.Generic;
using Xamarin.Essentials;
using UnitConverter.Models;

namespace UnitConverter.Converters
{
    public class TemperatureConverter : UnitConverterBase
    {

        public TemperatureConverter() : base(new List<Factor> {

         new Factor {
             Value = 1,
             Name = "Celsius (°C)" },
         new Factor {
             Value = 33.8,
             Name = "Fahrenheit (°F)" },
         new Factor {
             Value = 274.15,
             Name = "kelvin (K)" }
        })
        {

        }
        public override string Convert(int from, int to, double value)
        {
            string result = string.Empty;

            //Celsius
            if (from == 0 && to == 0)
                result = value.ToString();
            else if (from == 0 && to == 1)
                result = UnitConverters.CelsiusToFahrenheit(value).ToString();
            else if (from == 0 && to == 2)
                result = UnitConverters.CelsiusToKelvin(value).ToString();

            //Fahrenheit
            else if (from == 1 && to == 0)
                result = UnitConverters.FahrenheitToCelsius(value).ToString();
            else if (from == 1 && to == 1)
                result = value.ToString();
            else if (from == 1 && to == 2)
                result = UnitConverters.CelsiusToKelvin(UnitConverters.FahrenheitToCelsius(value)).ToString();

            //kelvin
            else if (from == 2 && to == 0)
                result = UnitConverters.KelvinToCelsius(value).ToString();
            else if (from == 2 && to == 1)
                result = UnitConverters.CelsiusToFahrenheit(UnitConverters.KelvinToCelsius(value)).ToString();
            else if (from == 2 && to == 2)
                result = value.ToString();

            return result;
        }


    }
}
