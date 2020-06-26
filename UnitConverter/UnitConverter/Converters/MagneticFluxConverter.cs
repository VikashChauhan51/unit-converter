using System;
using System.Collections.Generic;
using System.Text;
using UnitConverter.Models;

namespace UnitConverter.Converters
{
    public class MagneticFluxConverter : UnitConverterBase
    {
        public MagneticFluxConverter() : base(new List<Factor>
        {
            new Factor{
 Value=100000000,
 Name="Gauss Square Centimeter (G·cm²)"
 },
new Factor{
 Value=4.835978981048E+14,
 Name="Magnetic Flux Quantum"
 },
new Factor{
 Value=100000000,
 Name="Maxwell (Mw)"
 },
new Factor{
 Value=1000000,
 Name="Microweber (µWb)"
 },
new Factor{
 Value=1000,
 Name="Milliweber (mWb)"
 },
new Factor{
 Value=1000000000,
 Name="Nanoweber (nWb)"
 },
new Factor{
 Value=1,
 Name="Tesla Square Meter (T·m²)"
 },
new Factor{
 Value=1,
 Name="Volt-second (Vs)"
 },
new Factor{
 Value=1,
 Name="Weber (Wb)"
 }
        })
        {

        }
    }
}
