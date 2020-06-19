using System;
using System.Collections.Generic;
using System.Text;
using UnitConverter.Models;

namespace UnitConverter.Converters
{
    public class AngleConverter : IUnitConverter
    {
        static string[] Unit_Name = new[] { "degrees (deg)", "full circle", "grad", "radians (rad)" };
        static double[] Factors = new[] { 57.295779513082, 0.1591549430919, 63.661977236758, 1 };
        public string Convert(int from, int to, double value)
        {
            var faqsorg = Factors[to] / Factors[from];
            var resfaqs = value * faqsorg;
            return resfaqs.ToString();
        }

        public IEnumerable<Unit> GetUnitTypes()
        {
            yield return new Unit { Id = 0, Text = "degrees (deg)" };
            yield return new Unit { Id = 1, Text = "Full Circle" };
            yield return new Unit { Id = 2, Text = "Grad" };
            yield return new Unit { Id = 3, Text = "Radians (rad)" };
        }
    }
}
