using System;
using System.Collections.Generic;
using System.Text;
using UnitConverter.Models;

namespace UnitConverter.Converters
{
    public class InductanceConverter : UnitConverterBase
    {
         public InductanceConverter():base(new List<Factor> {
         new Factor{
 Value=1000000000,
 Name="Abhenry (abH)"
 },
new Factor{
 Value=1.0E-9,
 Name="Gigahenry (GH)"
 },
new Factor{
 Value=1,
 Name="Henry (H)"
 },
new Factor{
 Value=0.001,
 Name="Kilohenry (kH)"
 },
new Factor{
 Value=1.0E-6,
 Name="Megahenry (MH)"
 },
new Factor{
 Value=1000000,
 Name="Microhenry (µH)"
 },
new Factor{
 Value=1000,
 Name="Millihenry (mH)"
 },
new Factor{
 Value=1000000000,
 Name="Nanohenry (nH)"
 },
new Factor{
 Value=1,
 Name="Weber Per Ampere (Wb/A)"
 }
         })
        {

        }
    }
}
