using System;
using System.Collections.Generic;
using System.Text;
using UnitConverter.Models;

namespace UnitConverter.Converters
{
    public class PressureConverter : UnitConverterBase
    {
        public PressureConverter():base(new List<Factor>
        {
            new Factor{
 Value=0.98692326671601,
 Name="Atmosphere (atm)"
 },
new Factor{
 Value=1,
 Name="Bar (b)"
 },
new Factor{
 Value=1000,
 Name="Hectopascal (hPa)"
 },
new Factor{
 Value=1.0197162129779,
 Name="Kilogram Per Square Cemtimeter (kgf/cm²)"
 },
new Factor{
 Value=10197.162129779,
 Name="Kilogram Per Square Meter (kgf/m²)"
 },
new Factor{
 Value=100,
 Name="Kilopascal (kPa)"
 },
new Factor{
 Value=1000,
 Name="Millibar"
 },
new Factor{
 Value=750.06168270417,
 Name="Millimeter Of Mercury (mmHg)"
 },
new Factor{
 Value=100000,
 Name="Pascal (Pa)"
 },
new Factor{
 Value=2088.5456325465,
 Name="Pounds Per Square Foot (psf)"
 },
new Factor{
 Value=14.503789114906,
 Name="Pounds Per Square Inch (psi)"
 },
new Factor{
 Value=750.06168270417,
 Name="Torr (Torr)"
 }
        })
        {

        }
     
        
    }
}
