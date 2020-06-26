using System;
using System.Collections.Generic;
using System.Text;
using UnitConverter.Models;

namespace UnitConverter.Converters
{
    public class IlluminanceConverter : UnitConverterBase
    {
        public IlluminanceConverter() : base(new List<Factor> {
     new Factor{
 Value=0.09290304,
 Name="Foot-candle (fc)"
 },
new Factor{
 Value=0.001,
 Name="Kilolux (klx)"
 },
new Factor{
 Value=0.0001,
 Name="Lumen Per Square Centimeter (lm/cm²)"
 },
new Factor{
 Value=1,
 Name="Lumen Per Square Meter (lm/m²)"
 },
new Factor{
 Value=1,
 Name="Lux (lx)"
 },
new Factor{
 Value=1000000,
 Name="Microlux (µlx)"
 },
new Factor{
 Value=1000,
 Name="Millilux (mlx)"
 },
new Factor{
 Value=1000,
 Name="Nox"
 },
new Factor{
 Value=0.0001,
 Name="Phot (ph)"
 }
     })
        {

        }
    }
}
