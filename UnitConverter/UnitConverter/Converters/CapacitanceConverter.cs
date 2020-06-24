using System;
using System.Collections.Generic;
using System.Text;
using UnitConverter.Models;

namespace UnitConverter.Converters
{
    public class CapacitanceConverter : UnitConverterBase
    {
        public CapacitanceConverter() : base(
            new List<Factor>
        {
           new Factor{
 Value=1.0E-9,
 Name="Abfarad (abF)"
 },
new Factor{
 Value=1000000000000000000,
 Name="Attofarad (aF)"
 },
new Factor{
 Value=100,
 Name="Centifarad (cF)"
 },
new Factor{
 Value=1,
 Name="Coulomb per volt"
 },
new Factor{
 Value=0.1,
 Name="Decafarad (daF)"
 },
new Factor{
 Value=10,
 Name="Decifarad (dF)"
 },
new Factor{
 Value=1.0E-18,
 Name="Exafarad (EF)"
 },
new Factor{
 Value=1,
 Name="Farad (F)"
 },
new Factor{
 Value=1000000000000000,
 Name="Femtofarad (fF)"
 },
new Factor{
 Value=1.0E-9,
 Name="Gigafarad (GF)"
 },
new Factor{
 Value=0.01,
 Name="Hectofarad (hF)"
 },
new Factor{
 Value=0.001,
 Name="Kilofarad (kF)"
 },
new Factor{
 Value=1.0E-6,
 Name="Megafarad (MF)"
 },
new Factor{
 Value=1000000,
 Name="Microfarad (µF)"
 },
new Factor{
 Value=1000,
 Name="Millifarad (mF)"
 },
new Factor{
 Value=1000000000,
 Name="Nanofarad (nF)"
 },
new Factor{
 Value=1.0E-15,
 Name="Petafarad (PF)"
 },
new Factor{
 Value=1000000000000,
 Name="Picofarad (pF)"
 },
new Factor{
 Value=898755178736.5,
 Name="Statfarad (statF)"
 },
new Factor{
 Value=1.0E-12,
 Name="Terafarad (TF)"
 },
new Factor{
 Value=1.0E+24,
 Name="Yoctofarad (yF)"
 },
new Factor{
 Value=1E-24,
 Name="Yottafarad (YF)"
 },
new Factor{
 Value=1.0E+21,
 Name="Zeptofarad (zF)"
 },
new Factor{
 Value=1.0E-21,
 Name="Zettafarad (ZF)"
 }
            })
        {

        }

       
    }
}
