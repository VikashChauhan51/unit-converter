using System;
using System.Collections.Generic;
using System.Text;
using UnitConverter.Models;

namespace UnitConverter.Converters
{
    public class LengthConverter : IUnitConverter
    {

        static readonly string[] Length_Name = new[]{ "angstrom", "astronomical unit (au)", "centimeter (cm)", "chain",
            "decimeter (dm)", "fathom", "foot (ft)", "furlong", "inch (in)", "kilometer (km)", "league", "light year",
            "meter (m)", "mile (mi)", "millimeter (mm)", "micrometer (µm)", "micron (µ)", "nanometer (nm)", "nautical mile", "parsec", "rod", "yard (yd)" };
        static readonly double[] Factors_Length = new[] { 10000000000, 6.6845871226706E-12, 100, 0.049709695378987, 10, 0.54680664916885,
            3.2808398950131, 0.0049709695378987, 39.370078740157, 0.001, 0.00020712373074577, 1.0570008340246E-16, 1, 0.00062137119223733, 1000, 1000000,
            1000000, 1000000000, 0.00053995680345572, 3.2407792896393E-17, 0.19883878151595, 1.0936132983377 };
        public string Convert(int from, int to, double value)
        {
            var faqsorg = Factors_Length[to] / Factors_Length[from];
            var resfaqs = value * faqsorg;
            return resfaqs.ToString();
        }

        public IEnumerable<Unit> GetUnitTypes()
        {
            yield return new Unit { Id = 0, Text = "Angstrom" };
            yield return new Unit { Id = 1, Text = "Astronomical Unit (au)" };
            yield return new Unit { Id = 2, Text = "Centimeter (cm)" };
            yield return new Unit { Id = 3, Text = "Chain" };
            yield return new Unit { Id = 4, Text = "Decimeter (dm)" };
            yield return new Unit { Id = 5, Text = "Fathom" };
            yield return new Unit { Id = 6, Text = "Foot (ft)" };
            yield return new Unit { Id = 7, Text = "Furlong" };
            yield return new Unit { Id = 8, Text = "Inch (in)" };
            yield return new Unit { Id = 9, Text = "Kilometer (km)" };
            yield return new Unit { Id = 10, Text = "League" };
            yield return new Unit { Id = 11, Text = "Light Year" };
            yield return new Unit { Id = 12, Text = "Meter (m)" };
            yield return new Unit { Id = 13, Text = "Mile (mi)" };
            yield return new Unit { Id = 14, Text = "Millimeter (mm)" };
            yield return new Unit { Id = 15, Text = "Micrometer (µm)" };
            yield return new Unit { Id = 16, Text = "Micron (µ)" };
            yield return new Unit { Id = 17, Text = "Nanometer (nm)" };
            yield return new Unit { Id = 18, Text = "Nautical Mile" };
            yield return new Unit { Id = 19, Text = "Parsec" };
            yield return new Unit { Id = 20, Text = "Rod" };
            yield return new Unit { Id = 21, Text = "Yard" };
         
        }
    }
}
