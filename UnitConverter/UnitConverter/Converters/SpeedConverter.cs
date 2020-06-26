using System;
using System.Collections.Generic;
using System.Text;
using UnitConverter.Models;

namespace UnitConverter.Converters
{
    public class SpeedConverter : UnitConverterBase
    {
        public SpeedConverter() : base(new List<Factor>
        {
             new Factor{
 Value=100,
 Name="Centimeter / Second (cm/s)"
 },
new Factor{
 Value=3.2808398950131,
 Name="Foot / Second (ft/s)"
 },
new Factor{
 Value=3.6,
 Name="Kilometer / Hour (km/h)"
 },
new Factor{
 Value=0.06,
 Name="Kilometer / Minute (km/min)"
 },
new Factor{
 Value=0.001,
 Name="Kilometer / Second (km/s)"
 },
new Factor{
 Value=1.9438444924406,
 Name="Knot (kn)"
 },
new Factor{
 Value=0.0029154518950437,
 Name="Mach (at std. atm.) (M)"
 },
new Factor{
 Value=60,
 Name="Meter / Minute (m/min)"
 },
new Factor{
 Value=1,
 Name="Meter / Second (m/s)"
 },
new Factor{
 Value=2.2369362920544,
 Name="Mile / Hour (mph)"
 },
new Factor{
 Value=3.3356409519815E-9,
 Name="Speed Of Light"
 },
new Factor{
 Value=0.0029154518950437,
 Name="Speed Of Sound (at std. atm.)"
 },
new Factor{
 Value=1.0936132983377,
 Name="Yard / Second"
 }
        })
        {

        }
    }
}
