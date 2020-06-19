using System;
using System.Collections.Generic;
using System.Text;
using UnitConverter.Models;

namespace UnitConverter.Converters
{
    public class DensityConverter : IUnitConverter
    {
        static string[] Unit_Name = new[] { "gram / cubic centimeter (g/cm³)", "gram / cubic decimeter", "gram / cubic meter (g/m³)", "gram / liter", "gram / milliliter", "megagram / cubic centimeter", "megagram / cubic meter", "megagram / liter", "megagram / milliliter", "milligram / cubic centimeter (mg/cm³)",
            "milligram / cubic decimeter", "milligram / cubic meter (mg/m³)", "milligram / liter", "milligram / milliliter", "kilogram / cubic centimeter (kg/cm³)",
            "kilogram / cubic decimeter", "kilogram / cubic meter (kg/m³)", "kilogram / liter", "kilogram / milliliter", "ounce / cubic foot", "ounce / cubic inch", "ounce / cubic yard", "ounce / gallon (U.K.)(oz/gal)", "ounce / gallon (U.S.)(oz/gal)", "pound / circular mil foot",
            "pound / cubic foot (lb/ft³)", "pound / cubic inch (lb/in³)", "pound / cubic yard", "pound / gallon (U.K.)(lb/gal)", "pound / gallon (U.S.)(lb/gal)",
            "grain / cubic foot", "grain / cubic inch", "grain / cubic yard", "grain / gallon (U.K.)", "grain / gallon (U.S.)", "tonne / cubic centimeter",
            "tonne / cubic decimeter", "tonne / cubic meter", "tonne / liter", "tonne / milliliter" };
        static double[] Factors = new[] {1, 1000, 1000000, 1000, 1, 1.0E-5, 1, 0.001, 1.0E-5, 1000, 1000000, 1000000000, 1000000, 1000, 0.001, 1, 1000, 1, 0.001, 998.84737348,
            0.57803667444, 26968.879083, 160.35860568, 133.5264718, 340.4917061, 62.427960841, 0.036127292153, 1685.5549427, 10.022412855, 8.3454044873, 436995.72588,
            252.89104507, 11798884.599, 70156.889986, 58417.831411, 1.0E-5, 0.001, 1, 0.001, 1.0E-5};
        public string Convert(int from, int to, double value)
        {
            var faqsorg = Factors[to] / Factors[from];
            var resfaqs = value * faqsorg;
            return resfaqs.ToString();
        }

        public IEnumerable<Unit> GetUnitTypes()
        {
            yield return new Unit { Id = 0, Text = "Gram / Cubic Centimeter (g/cm³)" };
            yield return new Unit { Id = 1, Text = "Gram / Cubic Decimeter" };
            yield return new Unit { Id = 2, Text = "Gram / Cubic Meter (g/m³)" };
            yield return new Unit { Id = 3, Text = "Gram / Liter" };
            yield return new Unit { Id = 4, Text = "Gram / Milliliter" };
            yield return new Unit { Id = 5, Text = "Megagram / Cubic Centimeter" };
            yield return new Unit { Id = 6, Text = "Megagram / Cubic Meter" };
            yield return new Unit { Id = 7, Text = "Megagram / Liter" };
            yield return new Unit { Id = 8, Text = "Megagram / Milliliter" };
            yield return new Unit { Id = 9, Text = "Milligram / Cubic Centimeter (mg/cm³)" };
            yield return new Unit { Id = 10, Text = "Milligram / Cubic Decimeter" };
            yield return new Unit { Id = 11, Text = "Milligram / Cubic Meter (mg/m³)" };
            yield return new Unit { Id = 12, Text = "Milligram / Liter" };
            yield return new Unit { Id = 13, Text = "Milligram / Milliliter" };
            yield return new Unit { Id = 14, Text = "Kilogram / Cubic Centimeter (kg/cm³)" };
            yield return new Unit { Id = 15, Text = "Kilogram / Cubic Decimeter" };
            yield return new Unit { Id = 16, Text = "Kilogram / Cubic Meter (kg/m³)" };
            yield return new Unit { Id = 17, Text = "Kilogram / Liter" };
            yield return new Unit { Id = 18, Text = "Kilogram / Milliliter" };
            yield return new Unit { Id = 19, Text = "Ounce / Cubic Foot" };
            yield return new Unit { Id = 20, Text = "Ounce / Cubic Inch" };
            yield return new Unit { Id = 21, Text = "Ounce / Cubic Yard" };
            yield return new Unit { Id = 22, Text = "Ounce / Gallon (U.K.)(oz/gal)" };
            yield return new Unit { Id = 23, Text = "Ounce / Gallon (U.S.)(oz/gal)" };
            yield return new Unit { Id = 24, Text = "Pound / Circular Mil Foot" };
            yield return new Unit { Id = 25, Text = "Pound / Cubic Foot (lb/ft³)" };
            yield return new Unit { Id = 26, Text = "Pound / Cubic Inch (lb/in³)" };
            yield return new Unit { Id = 27, Text = "Pound / Cubic Yard" };
            yield return new Unit { Id = 28, Text = "Pound / Gallon (U.K.)(lb/gal)" };
            yield return new Unit { Id = 29, Text = "Pound / Gallon (U.S.)(lb/gal)" };
            yield return new Unit { Id = 30, Text = "Grain / Cubic Foot" };
            yield return new Unit { Id = 31, Text = "Grain / Cubic Inch" };
            yield return new Unit { Id = 32, Text = "Grain / Cubic Yard" };
            yield return new Unit { Id = 33, Text = "Grain / Gallon (U.K.)" };
            yield return new Unit { Id = 34, Text = "Grain / Gallon (U.S.)" };
            yield return new Unit { Id = 35, Text = "Tonne / Cubic Centimeter" };
            yield return new Unit { Id = 36, Text = "Tonne / Cubic Decimeter" };
            yield return new Unit { Id = 37, Text = "Tonne / Cubic meter" };
            yield return new Unit { Id = 38, Text = "Tonne / Liter" };
            yield return new Unit { Id = 39, Text = "Tonne / Milliliter" };
        }
    }
}
