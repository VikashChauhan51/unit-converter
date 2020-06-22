using System;
using System.Collections.Generic;
using System.Text;
using UnitConverter.Models;

namespace UnitConverter.Converters
{
    public abstract class UnitConverterBase : IUnitConverter
    {
        protected abstract List<Factor> Factors { get; }
        public virtual string Convert(int from, int to, double value)
        {
            var faqsorg = Factors[to].Value / Factors[from].Value;
            var result = value * faqsorg;
            return result.ToString();
        }

        public virtual IEnumerable<Unit> GetUnitTypes()
        {
            for (int i = 0; i < Factors.Count; i++)
                yield return new Unit { Id = i, Text = Factors[i].Name };
        }
    }
}
