using System;
using System.Collections.Generic;
using System.Text;
using UnitConverter.Models;

namespace UnitConverter.Converters
{
    public class MetricConverter : UnitConverterBase
    {
        public MetricConverter() : base(new List<Factor>
         {
             new Factor{
 Value=1.0E+24,
 Name="Yocto (y)"
 },
new Factor{
 Value=1.0E+21,
 Name="Zepto (z)"
 },
new Factor{
 Value=1.0E+18,
 Name="Atto (a)"
 },
new Factor{
 Value=1.0E+15,
 Name="Femto (f)"
 },
new Factor{
 Value=1000000000000,
 Name="Pico (p)"
 },
new Factor{
 Value=1000000000,
 Name="Nano (n)"
 },
new Factor{
 Value=1000000,
 Name="Micro (µ)"
 },
new Factor{
 Value=1000,
 Name="Milli (m)"
 },
new Factor{
 Value=100,
 Name="Centi (c)"
 },
new Factor{
 Value=10,
 Name="Deci (d)"
 },
new Factor{
 Value=1,
 Name="Base"
 },
new Factor{
 Value=0.1,
 Name="Deka (da)"
 },
new Factor{
 Value=0.01,
 Name="Hecto (h)"
 },
new Factor{
 Value=0.001,
 Name="Kilo (k)"
 },
new Factor{
 Value=1.0E-6,
 Name="Mega (M)"
 },
new Factor{
 Value=1.0E-9,
 Name="Giga (G)"
 },
new Factor{
 Value=1.0E-12,
 Name="Tera (T)"
 },
new Factor{
 Value=1.0E-15,
 Name="Peta (P)"
 },
new Factor{
 Value=1.0E-18,
 Name="Exa (E)"
 },
new Factor{
 Value=1.0E-21,
 Name="Zetta (Z)"
 },
new Factor{
 Value=1.0E-24,
 Name="Yotta (Y)"
 }
         })
        {

        }
    }
}
