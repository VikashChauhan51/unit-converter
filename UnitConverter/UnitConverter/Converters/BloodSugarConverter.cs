using System;
using System.Collections.Generic;
using System.Text;
using UnitConverter.Models;

namespace UnitConverter.Converters
{
    public class BloodSugarConverter : UnitConverterBase
    {
        public BloodSugarConverter() : base(
            new List<Factor>
        {
            new Factor
            {
                Value=1,
                Name="mmol/l"
            },
            new Factor
            {
                Value=18,
                Name="mg/dl"
            },
            new Factor
            {
                Value=18,
                Name="mg%"
            }
            })
        {

        }

    }
}
