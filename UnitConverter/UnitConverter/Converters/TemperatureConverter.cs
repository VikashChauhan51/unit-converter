using System;
using System.Collections.Generic;
using Xamarin.Essentials;
using UnitConverter.Models;

namespace UnitConverter.Converters
{
    public class TemperatureConverter : IUnitConverter
    {

        public string Convert(int from, int to, double value)
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

        public IEnumerable<Unit> GetUnitTypes()
        {
            yield return new Unit { Id = 0, Text = "Celsius (°C)" };
            yield return new Unit { Id = 1, Text = "Fahrenheit (°F)" };
            yield return new Unit { Id = 2, Text = "kelvin (K)" };
        }
    }
}
