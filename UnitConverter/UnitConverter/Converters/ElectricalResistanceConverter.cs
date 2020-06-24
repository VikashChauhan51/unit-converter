using System;
using System.Collections.Generic;
using System.Text;
using UnitConverter.Models;

namespace UnitConverter.Converters
{
    public class ElectricalResistanceConverter : UnitConverterBase
    {
         public ElectricalResistanceConverter():base(new List<Factor> {
         new Factor{
 Value=1000000000,
 Name="Abohm (abΩ)"
 },
new Factor{
 Value=1.0E-9,
 Name="Gigaohm (GΩ)"
 },
new Factor{
 Value=0.001,
 Name="Kiloohm (kΩ)"
 },
new Factor{
 Value=1.0E-6,
 Name="Megaohm (MΩ)"
 },
new Factor{
 Value=1000000,
 Name="Microohm (µΩ)"
 },
new Factor{
 Value=1000,
 Name="Milliohm (mΩ)"
 },
new Factor{
 Value=1000000000,
 Name="Nanoohm (nΩ)"
 },
new Factor{
 Value=1,
 Name="Ohm (Ω)"
 },
new Factor{
 Value=1,
 Name="Volt Per Ampere (V/A)"
 }
         })
        {

        }
    }
}
