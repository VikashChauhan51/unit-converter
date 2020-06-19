using System;
using System.Collections.Generic;
using System.Text;
using UnitConverter.Models;

namespace UnitConverter.Converters
{
    public class PressureConverter : IUnitConverter
    {
        static string[] Unit_Name = new[] { "atmosphere (atm)", "bar (b)", "hectopascal (hPa)", "kilogram per sq. cm (kgf/cm²)", "kilogram per sq. meter (kgf/m²)", "kilopascal (kPa)", "millibar", "millimeter of mercury (mmHg) ",
            "pascal (Pa)", "pounds per square foot (psf)", "pounds per square inch (psi)", "torr (Torr)" };
        static double[] Factors = new[] { 0.98692326671601, 1, 1000, 1.0197162129779, 10197.162129779, 100, 1000, 750.06168270417, 100000, 2088.5456325465,
            14.503789114906, 750.06168270417 };
        public string Convert(int from, int to, double value)
        {
            var faqsorg = Factors[to] / Factors[from];
            var resfaqs = value * faqsorg;
            return resfaqs.ToString();
        }

        public IEnumerable<Unit> GetUnitTypes()
        {
            yield return new Unit { Id = 0, Text = "Atmosphere (atm)" };
            yield return new Unit { Id = 1, Text = "Bar (b)" };
            yield return new Unit { Id = 2, Text = "Hectopascal (hPa)" };
            yield return new Unit { Id = 3, Text = "Kilogram Per Square cm (kgf/cm²)" };
            yield return new Unit { Id = 4, Text = "Kilogram Per Square meter (kgf/m²)" };
            yield return new Unit { Id = 5, Text = "Kilopascal (kPa)" };
            yield return new Unit { Id = 6, Text = "Millibar" };
            yield return new Unit { Id = 7, Text = "Millimeter Of Mercury (mmHg) " };
            yield return new Unit { Id = 8, Text = "Pascal (Pa)" };
            yield return new Unit { Id = 9, Text = "Pounds Per Square Foot (psf)" };
            yield return new Unit { Id = 10, Text = "Pounds Per Square Inch (psi) (m²)" };
            yield return new Unit { Id = 11, Text = "Torr (Torr)" };
        }
    }
}
