using System;
using System.Collections.Generic;
using System.Text;
using UnitConverter.Models;

namespace UnitConverter.Converters
{
    public class TimeConverter : UnitConverterBase
    {
        
        public TimeConverter() : base(new List<Factor>
        {
        new Factor{
 Value=2.7397260273973E-6,
 Name="Millennium"
 },
new Factor{
 Value=2.7397260273973E-5,
 Name="Century"
 },
new Factor{
 Value=0.00027397260273973,
 Name="Decade"
 },
new Factor{
 Value=0.0027378507871321,
 Name="Julian Year"
 },
new Factor{
 Value=0.0027379070069885,
 Name="Gregorian Year"
 },
new Factor{
 Value=0.0027379092633269,
 Name="Tropical Year"
 },
new Factor{
 Value=0.0027397260273973,
 Name="Year"
 },
new Factor{
 Value=0.032853922534821,
 Name="Month"
 },
new Factor{
 Value=0.071428571428571,
 Name="Fortnight"
 },
new Factor{
 Value=0.14285714285714,
 Name="Week"
 },
new Factor{
 Value=1,
 Name="Day"
 },
new Factor{
 Value=24,
 Name="Hour"
 },
new Factor{
 Value=1440,
 Name="Minute"
 },
new Factor{
 Value=86400,
 Name="Second"
 },
new Factor{
 Value=86400000,
 Name="Millisecond"
 },
new Factor{
 Value=86400000000,
 Name="Microsecond"
 },
new Factor{
 Value=86400000000000,
 Name="Nanosecond"
 }
        })
        {

        }

    }
}
