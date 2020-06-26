using System;
using System.Collections.Generic;
using System.Text;
using UnitConverter.Models;

namespace UnitConverter.Converters
{
    public class MolarMassConverter : UnitConverterBase
    {
        public MolarMassConverter() : base(new List<Factor>
         {
             new Factor{
 Value=0.028206357713029,
 Name="Chlorine (Cl)"
 },
new Factor{
 Value=0.014103178856514,
 Name="Chlorine Molecule (Cl₂)"
 },
new Factor{
 Value=1,
 Name="Gram Per Mole (g/mol)"
 },
new Factor{
 Value=0.992122546977,
 Name="Hydrogen (H)"
 },
new Factor{
 Value=0.4960612734885,
 Name="Hydrogen Molecule (H₂)"
 },
new Factor{
 Value=0.01790670606142,
 Name="Iron (Fe)"
 },
new Factor{
 Value=0.001,
 Name="Kilogram Per Mole (kg/mol)"
 },
new Factor{
 Value=0.062502343837894,
 Name="Oxygen (O)"
 },
new Factor{
 Value=0.031186652112896,
 Name="Sulfur (S)"
 },
new Factor{
 Value=0.003898331514112,
 Name="Sulfur Molecule (S₈)"
 },
new Factor{
 Value=0.017110756596919,
 Name="Table Salt (Sodium Chloride) (NaCl)"
 },
new Factor{
 Value=0.0029214440066693,
 Name="Table Sugar (Sucrose) (C₁₂H₂₂O₁₁)"
 },
new Factor{
 Value=0.055508435061792,
 Name="Water Molecule (H₂O)"
 }
         })
        {

        }
    }
}
