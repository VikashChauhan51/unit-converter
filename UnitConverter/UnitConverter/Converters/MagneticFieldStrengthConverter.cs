using System;
using System.Collections.Generic;
using System.Text;
using UnitConverter.Models;

namespace UnitConverter.Converters
{
    public class MagneticFieldStrengthConverter : UnitConverterBase
    {
        public MagneticFieldStrengthConverter() : base(new List<Factor> {

             new Factor{
 Value=79.577471545948,
 Name="Ampere Per Meter (A/m)"
 },
new Factor{
 Value=79.577471545948,
 Name="Ampere-turn Per Meter (AT/m)"
 },
new Factor{
 Value=100,
 Name="Gilbert Per Meter (Gi/m)"
 },
new Factor{
 Value=1,
 Name="Oersted (Oe)"
 }
         })
        {

        }
    }
}
