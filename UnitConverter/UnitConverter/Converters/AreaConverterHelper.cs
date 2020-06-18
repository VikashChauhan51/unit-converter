using System;
using System.Collections.Generic;
using System.Text;
using UnitConverter.Models;

namespace UnitConverter.Converters
{

    public class AreaConverterHelper : IUnitConverter
    {
        public static readonly string[] Aread_Name = new[]{"acre", "are (a)", "barn (b)", "hectare (ha)", "homestead", "rood",
    "square centimeter (cm<sup>2</sup>)", "square foot (ft<sup>2</sup>)", "square inch (in<sup>2</sup>)",
    "square kilometer (km<sup>2</sup>)", "square meter (m<sup>2</sup>)", "square mile", "square millimeter (mm<sup>2</sup>)",
    "square rod", "square yard (yd<sup>2</sup>)", "township (twp)" };
        public static readonly double[] Factors_Area = new[] {.00024710538146717, .01, 1e28, 1e-4, 15444086341698e-19,
            .00098842152586866, 1e4, 10.76391041671, 1550.0031000062, 1e-6, 1, 3.8610215854245e-7, 1e6,
            .039536861034746, 1.1959900463011, 1.0725059959512e-8 };

        public IEnumerable<Unit> GetUnitTypes()
        {
            yield return new Unit { Id = 0, Text = "Are" };
            yield return new Unit { Id = 1, Text = "Are (a)" };
            yield return new Unit { Id = 2, Text = "Barn (b)" };
            yield return new Unit { Id = 3, Text = "Hectare (ha)" };
            yield return new Unit { Id = 4, Text = "Homestead" };
            yield return new Unit { Id = 5, Text = "Rood" };
            yield return new Unit { Id = 6, Text = "Square Centimeter (cm²)" };
            yield return new Unit { Id = 7, Text = "Square Foot (ft²)" };
            yield return new Unit { Id = 8, Text = "Square Inch (in²)" };
            yield return new Unit { Id = 9, Text = "Square Kilometer (km²)" };
            yield return new Unit { Id = 10, Text = "Square Meter (m²)" };
            yield return new Unit { Id = 11, Text = "Square Mile" };
            yield return new Unit { Id = 12, Text = "Square Millimeter (mm²)" };
            yield return new Unit { Id = 13, Text = "Square Rod" };
            yield return new Unit { Id = 14, Text = "Square Yard (yd²)" };
            yield return new Unit { Id = 15, Text = "Township (twp)" };
        }
        public string Convert(int from, int to, double value)
        {
            var faqsorg = Factors_Area[to] / Factors_Area[from];
            var result = value * faqsorg;
            return result.ToString();
        }
    }
}
