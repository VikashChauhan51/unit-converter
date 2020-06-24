using System;
using System.Collections.Generic;
using System.Text;
using UnitConverter.Models;

namespace UnitConverter.Converters
{
    public class EnergyConverter : UnitConverterBase
    {
        public EnergyConverter():base(new List<Factor> {
        new Factor{
 Value=0.00094781698791344,
 Name="BTU"
 },
new Factor{
 Value=0.2388458966275,
 Name="Calorie (cal)"
 },
new Factor{
 Value=6.2415097445115E+18,
 Name="Electronvolt (eV)"
 },
new Factor{
 Value=10000000,
 Name="Erg"
 },
new Factor{
 Value=0.73756214927727,
 Name="Foot-pound"
 },
new Factor{
 Value=1.0E-9,
 Name="Gigajoule (GJ)"
 },
new Factor{
 Value=1,
 Name="Joule (J)"
 },
new Factor{
 Value=0.0002388458966275,
 Name="Kilocalorie (kcal)"
 },
new Factor{
 Value=0.001,
 Name="Kilojoule (kJ)"
 },
new Factor{
 Value=2.7777777777778E-7,
 Name="Kilowatt hour (kWh)"
 },
new Factor{
 Value=1.0E-6,
 Name="Megajoule (MJ)"
 },
new Factor{
 Value=0.0002388458966275,
 Name="Nutrition Calorie (Cal)"
 },
new Factor{
 Value=2.3900573613767E-10,
 Name="Ton Of TNT (tn)"
 },
new Factor{
 Value=0.00027777777777778,
 Name="Watt Hour (Wh)"
 }
        })
        {

        }
        
    }
}
