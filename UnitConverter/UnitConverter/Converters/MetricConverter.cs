using System;
using System.Collections.Generic;
using System.Text;
using UnitConverter.Models;

namespace UnitConverter.Converters
{
    public class MetricConverter : IUnitConverter
    {
        public string Convert(int from, int to, double value)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Unit> GetUnitTypes()
        {
            throw new NotImplementedException();
        }
    }
}
