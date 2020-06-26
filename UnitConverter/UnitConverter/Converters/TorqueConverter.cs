using System;
using System.Collections.Generic;
using System.Text;
using UnitConverter.Models;

namespace UnitConverter.Converters
{
    public class TorqueConverter : UnitConverterBase
    {
        public TorqueConverter() : base(new List<Factor>
        {
            new Factor{
 Value=10000000,
 Name="Dyne Centimeter"
 },
new Factor{
 Value=100000,
 Name="Dyne Meter"
 },
new Factor{
 Value=100000000,
 Name="Dyne Milimeter"
 },
new Factor{
 Value=10197.162129779,
 Name="Gram-force Centimeter"
 },
new Factor{
 Value=101.97162129779,
 Name="Gram-force Meter"
 },
new Factor{
 Value=101971.62129779,
 Name="Gram-force Milimeter"
 },
new Factor{
 Value=10.197162129779,
 Name="Kilogram-force Centimeter"
 },
new Factor{
 Value=0.10197162129779,
 Name="Kilogram-force Meter"
 },
new Factor{
 Value=101.97162129779,
 Name="Kilogram-force Milimeter"
 },
new Factor{
 Value=0.001,
 Name="Kilonewton Meter"
 },
new Factor{
 Value=1.0E-6,
 Name="Meganewton Meter"
 },
new Factor{
 Value=1000000,
 Name="Micronewton Meter"
 },
new Factor{
 Value=1000,
 Name="Milinewton Meter"
 },
new Factor{
 Value=100,
 Name="Newton Centimeter"
 },
new Factor{
 Value=1000,
 Name="Newton Milimeter"
 },
new Factor{
 Value=1,
 Name="Newton Meter"
 },
new Factor{
 Value=11.800994356505,
 Name="Ounce-force Foot"
 },
new Factor{
 Value=141.611932278,
 Name="Ounce-force Inch"
 },
new Factor{
 Value=0.73756214728,
 Name="Pound-force Feet"
 },
new Factor{
 Value=8.8507457676,
 Name="Pound-force Inch"
 }
        })
        {

        }

    }
}
