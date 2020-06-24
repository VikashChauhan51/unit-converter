using System;
using System.Collections.Generic;
using System.Text;
using UnitConverter.Models;

namespace UnitConverter.Converters
{
    public class ElectricChargeConverter : UnitConverterBase
    {
        public ElectricChargeConverter():base(new List<Factor> {
            new Factor{
 Value=0.1,
 Name="Abcoulomb (abC)"
 },
new Factor{
 Value=0.000277777777778,
 Name="Ampere-hour (Ah)"
 },
new Factor{
 Value=1,
 Name="Coulomb (C)"
 },
new Factor{
 Value=6241509474153816705,
 Name="Elementary charge (e)"
 },
new Factor{
 Value=1.036426864904E-5,
 Name="Faraday (F)"
 },
new Factor{
 Value=0.001,
 Name="Kilocoulomb (kC)"
 },
new Factor{
 Value=1.0E-6,
 Name="Megacoulomb (MC)"
 },
new Factor{
 Value=1000000,
 Name="Microcoulomb (µC)"
 },
new Factor{
 Value=0.277777777778,
 Name="Milliampere-hour (mAh)"
 },
new Factor{
 Value=1000,
 Name="Millicoulomb (mC)"
 },
new Factor{
 Value=1000000000,
 Name="Nanocoulomb (nC)"
 },
new Factor{
 Value=2997924580,
 Name="Statcoulomb (statC)"
 }

        })
        {

        }
        
         
    }
}
