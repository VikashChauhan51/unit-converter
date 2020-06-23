using System;
using System.Collections.Generic;
using System.Text;
using UnitConverter.Models;

namespace UnitConverter.Converters
{

    public class AreaConverter : UnitConverterBase
    {

        public AreaConverter() : base(new List<Factor>
        {
            new Factor
            {
                Value=0.00024710538146717,
                Name="Are"
            },
            new Factor
            {
                Value=0.01,
                Name="Are (a)"
            },
            new Factor
            {
                Value=1e28,
                Name="Barn (b)"
            },
            new Factor
            {
                Value=1e-4,
                Name="Hectare (ha)"
            },
            new Factor
            {
                Value=15444086341698e-19,
                Name="Homestead"
            },
            new Factor
            {
                Value=0.00098842152586866,
                Name="Rood"
            },
            new Factor
            {
                Value=1e4,
                Name="Square Centimeter (cm²)"
            },
            new Factor
            {
                Value=10.76391041671,
                Name="Square Foot (ft²)"
            },
            new Factor
            {
                Value=1550.0031000062,
                Name="Square Inch (in²)"
            },
            new Factor
            {
                Value=1e-6,
                Name="Square Kilometer (km²)"
            },
            new Factor
            {
                Value=1,
                Name="Square Meter (m²)"
            },
            new Factor
            {
                Value=3.8610215854245e-7,
                Name="Square Mile"
            },
            new Factor
            {
                Value=1e6,
                Name="Square Millimeter (mm²)"
            },
            new Factor
            {
                Value=0.039536861034746,
                Name="Square Rod"
            },
            new Factor
            {
                Value=1.1959900463011,
                Name="Square Yard (yd²)"
            },
            new Factor
            {
                Value=1.0725059959512e-8,
                Name="Township (twp)"
            }
        })
        {

        }


    }
}
