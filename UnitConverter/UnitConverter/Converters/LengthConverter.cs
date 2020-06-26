using System;
using System.Collections.Generic;
using System.Text;
using UnitConverter.Models;

namespace UnitConverter.Converters
{
    public class LengthConverter : UnitConverterBase
    {
        public LengthConverter() : base(new List<Factor> {
        new Factor{
 Value=10000000000,
 Name="Angstrom"
 },
new Factor{
 Value=6.6845871226706E-12,
 Name="Astronomical Unit (au)"
 },
new Factor{
 Value=100,
 Name="Centimeter (cm)"
 },
new Factor{
 Value=0.049709695378987,
 Name="Chain"
 },
new Factor{
 Value=10,
 Name="Decimeter (dm)"
 },
new Factor{
 Value=0.54680664916885,
 Name="Fathom"
 },
new Factor{
 Value=3.2808398950131,
 Name="Foot (ft)"
 },
new Factor{
 Value=0.0049709695378987,
 Name="Furlong"
 },
new Factor{
 Value=39.370078740157,
 Name="Inch (in)"
 },
new Factor{
 Value=0.001,
 Name="Kilometer (km)"
 },
new Factor{
 Value=0.00020712373074577,
 Name="League"
 },
new Factor{
 Value=1.0570008340246E-16,
 Name="Light year"
 },
new Factor{
 Value=1,
 Name="Meter (m)"
 },
new Factor{
 Value=0.00062137119223733,
 Name="Mile (mi)"
 },
new Factor{
 Value=1000,
 Name="Millimeter (mm)"
 },
new Factor{
 Value=1000000,
 Name="Micrometer (µm)"
 },
new Factor{
 Value=1000000,
 Name="Micron (µ)"
 },
new Factor{
 Value=1000000000,
 Name="Nanometer (nm)"
 },
new Factor{
 Value=0.00053995680345572,
 Name="Nautical mile"
 },
new Factor{
 Value=3.2407792896393E-17,
 Name="Parsec"
 },
new Factor{
 Value=0.19883878151595,
 Name="Rod"
 },
new Factor{
 Value=1.0936132983377,
 Name="Yard (yd)"
 }
        })
        {

        }

    }
}
