using System;
using System.Collections.Generic;
using System.Text;
using UnitConverter.Models;

namespace UnitConverter.Converters
{
    public class RadioactiveDecay : UnitConverterBase
    {
        public RadioactiveDecay():base(new List<Factor>
        {
            new Factor{
 Value=1,
 Name="Becquerel (Bq)"
 },
new Factor{
 Value=2.702702702E-11,
 Name="Curie (Ci)"
 },
new Factor{
 Value=60,
 Name="Disintegrations Per Minute (dpm)"
 },
new Factor{
 Value=1.0E-9,
 Name="Gigabecquerel (GBq)"
 },
new Factor{
 Value=0.001,
 Name="Kilobecquerel (kBq)"
 },
new Factor{
 Value=1.0E-6,
 Name="Megabecquerel (MBq)"
 },
new Factor{
 Value=1.0E-6,
 Name="Rutherford (Rd)"
 },
new Factor{
 Value=1.0E-12,
 Name="Terabecquerel (TBq)"
 }
        })
        {

        }
    }
}
