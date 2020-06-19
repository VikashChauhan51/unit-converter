using System;
using System.Collections.Generic;
using System.Text;
using UnitConverter.Models;

namespace UnitConverter.Converters
{
    public class WeightConverter : IUnitConverter
    {
        static string[] Unit_Name = new[]{"atomic mass unit (amu)", "carat (metric)", "cental", "centigram", "dekagram", "dram (dr)", "grain (gr)", "gram (g)", "hundredweight (UK)",
            "kilogram (kg)", "microgram (µg)", "milligram (mg)", "newton (Earth)", "ounce (oz)", "pennyweight (dwt)",
            "pound (lb)", "quarter", "stone", "ton (UK, long)", "ton (US, short)", "tonne (t)", "troy ounce"};
        static double[] Factors = new[]{6.0221366516752E+26, 5000, 0.022046226218488, 100000, 100, 564.38339119329, 15432.358352941, 1000, 0.019684130552221,
            1, 1000000000, 1000000, 9.80665, 35.27396194958, 643.01493137256, 2.2046226218488, 0.078736522208885, 0.15747304441777, 0.00098420652761106,
            0.0011023113109244, 0.001, 32.150746568628};
        public string Convert(int from, int to, double value)
        {
            var faqsorg = Factors[to] / Factors[from];
            var resfaqs = value * faqsorg;
            return resfaqs.ToString();
        }

        public IEnumerable<Unit> GetUnitTypes()
        {
            yield return new Unit { Id = 0, Text = "Atomic Mass Unit (amu)" };
            yield return new Unit { Id = 1, Text = "Carat (metric)" };
            yield return new Unit { Id = 2, Text = "Cental" };
            yield return new Unit { Id = 3, Text = "Centigram" };
            yield return new Unit { Id = 4, Text = "Dekagram" };
            yield return new Unit { Id = 5, Text = "Dram (dr)" };
            yield return new Unit { Id = 6, Text = "Grain (gr)" };
            yield return new Unit { Id = 7, Text = "Gram (g)" };
            yield return new Unit { Id = 8, Text = "Hundredweight (UK)" };
            yield return new Unit { Id = 9, Text = "Kilogram (kg)" };
            yield return new Unit { Id = 10, Text = "Microgram (µg)" };
            yield return new Unit { Id = 11, Text = "Milligram (mg)" };
            yield return new Unit { Id = 12, Text = "Newton (Earth)" };
            yield return new Unit { Id = 13, Text = "Ounce (oz)" };
            yield return new Unit { Id = 14, Text = "Pennyweight (dwt)" };
            yield return new Unit { Id = 15, Text = "Pound (lb)" };
            yield return new Unit { Id = 16, Text = "Quarter" };
            yield return new Unit { Id = 17, Text = "Stone" };
            yield return new Unit { Id = 18, Text = "Ton (UK, long)" };
            yield return new Unit { Id = 19, Text = "Ton (US, short)" };
            yield return new Unit { Id = 20, Text = "Tonne (t)" };
            yield return new Unit { Id = 21, Text = "Troy Ounce" };
        }
    }
}
