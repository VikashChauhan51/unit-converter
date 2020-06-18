using System;
using System.Collections.Generic;
using System.Text;
using UnitConverter.Models;

namespace UnitConverter.Converters
{
    public interface IUnitConverter
    {
        IEnumerable<Unit> GetUnitTypes();
        string Convert(int from, int to, double value);
    }
}
