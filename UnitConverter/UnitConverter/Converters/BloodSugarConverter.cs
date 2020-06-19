using System;
using System.Collections.Generic;
using System.Text;
using UnitConverter.Models;

namespace UnitConverter.Converters
{
    public class BloodSugarConverter : IUnitConverter
    {
        static string[] Unit_Name = new[] { "mmol/l", "mg/dl", "mg%" };
        static int[] Factors = new[] { 1, 18, 18 };
        public string Convert(int from, int to, double value)
        {
            var faqsorg = Factors[to] / Factors[from];
            var resfaqs = value * faqsorg;
            return resfaqs.ToString();
        }

        public IEnumerable<Unit> GetUnitTypes()
        {
            yield return new Unit { Id = 0, Text = "mmol/l" };
            yield return new Unit { Id = 1, Text = "mg/dl" };
            yield return new Unit { Id = 2, Text = "mg%" };
        }
    }
}
