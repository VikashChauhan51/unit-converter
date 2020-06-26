using System;
using System.Collections.Generic;
using System.Text;
using UnitConverter.Models;

namespace UnitConverter.Converters
{
    public class MagneticFieldConverter : UnitConverterBase
    {
        public MagneticFieldConverter() : base(new List<Factor> {
             new Factor{
 Value=1000000000,
 Name="Gamma (γ)"
 },
new Factor{
 Value=10000,
 Name="Gauss (G)"
 },
new Factor{
 Value=0.001,
 Name="Kilotesla (kT)"
 },
new Factor{
 Value=10000,
 Name="Line Per Square Centimetre"
 },
new Factor{
 Value=10000,
 Name="Maxwell Per Square Centimetre (Mw/cm²)"
 },
new Factor{
 Value=1.0E-6,
 Name="Megatesla"
 },
new Factor{
 Value=1000000,
 Name="Microtesla (µT)"
 },
new Factor{
 Value=1000,
 Name="Millitesla (mT)"
 },
new Factor{
 Value=1000000000,
 Name="Nanotesla (nT)"
 },
new Factor{
 Value=1000000000000,
 Name="Picotesla (pT)"
 },
new Factor{
 Value=1,
 Name="Tesla (T)"
 },
new Factor{
 Value=1,
 Name="Weber Per Square Metre (Wb/m²)"
 }
         })
        {

        }
    }
}
