using System;
using System.Collections.Generic;
using System.Text;
using UnitConverter.Models;

namespace UnitConverter.Converters
{
    public class AccelerationConverter : UnitConverterBase
    {
        
         
        public AccelerationConverter() : base(new List<Factor>
        {
            new Factor
            {
                Value=1,
                Name="Meter / Square Second (m/sec²)"
            },
            new Factor
            {
                Value=100,
                Name="Centimeter / Square Second (cm/sec²)"
            },
            new Factor
            {
                Value=3.280839895,
                Name="Foot / Square Second (ft/sec²)"
            },
            new Factor
            {
                Value=0.1019716213,
                Name="Standard Gravity (grav)"
            },
            new Factor
            {
                Value=100,
                Name="Gal(cm/s²)"
            },
            new Factor
            {
                Value=0.1019716213,
                Name="G-Unit"
            },
            new Factor
            {
                Value=12960,
                Name="Kilometer / Square Hour (km/h²)"
            },
            new Factor
            {
                Value=3.6,
                Name="Kilometer / Hour Second(km/h-s)"
            },
            new Factor
            {
                Value=134.21617752,
                Name="Mile / Hour Minute(mi/h-min)"
            },
            new Factor
            {
                Value=2.2369362921,
                Name="Mile / Hour Second (mi/hr-s)"
            },
            new Factor
            {
                Value=0.00062137119224,
                Name="Mile / Square Second (mi/sec²)"
            },
            new Factor
            {
                Value=39.37007874,
                Name="Inch / Square Second (in/s²)"
            }
        })
        {

        }
    }
}
