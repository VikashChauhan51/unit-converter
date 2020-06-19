using System;
using System.Collections.Generic;
using System.Text;
using UnitConverter.Models;

namespace UnitConverter.Converters
{
    public class ElectricChargeConverter : IUnitConverter
    {
        static readonly string[] Length_Name = new[] { "Abcoulomb (abC)", "Ampere-hour (Ah)", "Coulomb (C)", "Elementary charge (e)", "Faraday (F)",
            "Kilocoulomb (kC)", "Megacoulomb (MC)", "Microcoulomb (µC)", "Milliampere-hour (mAh)", "Millicoulomb (mC)", "Nanocoulomb (nC)", "Statcoulomb (statC)" };
        static readonly double[] Factors = new[] { 0.1, 0.000277777777778, 1, 6241509474153816705, 1.036426864904E-5, 0.001, 1.0E-6, 1000000, 0.277777777778, 1000,
            1000000000, 2997924580};
        public string Convert(int from, int to, double value)
        {
            var faqsorg = Factors[to] / Factors[from];
            var resfaqs = value * faqsorg;
            return resfaqs.ToString();
        }

        public IEnumerable<Unit> GetUnitTypes()
        {
            yield return new Unit { Id = 0, Text = "Abcoulomb (abC)" };
            yield return new Unit { Id = 1, Text = "Ampere-hour (Ah)" };
            yield return new Unit { Id = 2, Text = "Coulomb (C)" };
            yield return new Unit { Id = 3, Text = "Elementary Charge (e)" };
            yield return new Unit { Id = 4, Text = "Faraday (F)" };
            yield return new Unit { Id = 5, Text = "Kilocoulomb (kC)" };
            yield return new Unit { Id = 6, Text = "Megacoulomb (MC)" };
            yield return new Unit { Id = 7, Text = "Microcoulomb (µC)" };
            yield return new Unit { Id = 8, Text = "Milliampere-hour (mAh)" };
            yield return new Unit { Id = 9, Text = "Millicoulomb (mC)" };
            yield return new Unit { Id = 10, Text = "Nanocoulomb (nC)" };
            yield return new Unit { Id = 11, Text = "Statcoulomb (statC)" };

        }
    }
}
