using System;
using System.Collections.Generic;
using System.Text;
using UnitConverter.Models;

namespace UnitConverter.Converters
{
    public class AngleConverter : UnitConverterBase
    {
        public AngleConverter() : base(new List<Factor> {

         new Factor {
             Value = 57.295779513082,
             Name = "Degrees (deg)" },
         new Factor {
             Value = 0.1591549430919,
             Name = "Full Circle" },
         new Factor {
             Value = 63.661977236758,
             Name = "Grad" },
         new Factor {
             Value = 1,
             Name = "Radians (rad)" }

        })
        {

        }
     
    }
}
