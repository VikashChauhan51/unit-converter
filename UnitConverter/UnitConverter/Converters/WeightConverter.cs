using System;
using System.Collections.Generic;
using System.Text;
using UnitConverter.Models;

namespace UnitConverter.Converters
{
    public class WeightConverter : UnitConverterBase
    {
         public WeightConverter() : base(new List<Factor>
         {
             new Factor{
 Value=6.0221366516752E+26,
 Name="Atomic Mass Unit (amu)"
 },
new Factor{
 Value=5000,
 Name="Carat (metric)"
 },
new Factor{
 Value=0.022046226218488,
 Name="Cental"
 },
new Factor{
 Value=100000,
 Name="Centigram"
 },
new Factor{
 Value=100,
 Name="Dekagram"
 },
new Factor{
 Value=564.38339119329,
 Name="Dram (dr)"
 },
new Factor{
 Value=15432.358352941,
 Name="Grain (gr)"
 },
new Factor{
 Value=1000,
 Name="Gram (g)"
 },
new Factor{
 Value=0.019684130552221,
 Name="Hundredweight (UK)"
 },
new Factor{
 Value=1,
 Name="Kilogram (kg)"
 },
new Factor{
 Value=1000000000,
 Name="Microgram (µg)"
 },
new Factor{
 Value=1000000,
 Name="Milligram (mg)"
 },
new Factor{
 Value=9.80665,
 Name="Newton (Earth)"
 },
new Factor{
 Value=35.27396194958,
 Name="Ounce (oz)"
 },
new Factor{
 Value=643.01493137256,
 Name="Pennyweight (dwt)"
 },
new Factor{
 Value=2.2046226218488,
 Name="Pound (lb)"
 },
new Factor{
 Value=0.078736522208885,
 Name="Quarter"
 },
new Factor{
 Value=0.15747304441777,
 Name="Stone"
 },
new Factor{
 Value=0.00098420652761106,
 Name="Ton (UK, long)"
 },
new Factor{
 Value=0.0011023113109244,
 Name="Ton (US, short)"
 },
new Factor{
 Value=0.001,
 Name="Tonne (t)"
 },
new Factor{
 Value=32.150746568628,
 Name="Troy Ounce"
 }
         })
        {

        }
    }
}
