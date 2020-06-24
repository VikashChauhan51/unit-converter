using System;
using System.Collections.Generic;
using System.Text;
using UnitConverter.Models;

namespace UnitConverter.Converters
{
    public class DataTransferConverter : UnitConverterBase
    {
        public DataTransferConverter() : base(new List<Factor> {

            new Factor{
 Value=8589934592,
 Name="Bit / Second (bit/s)"
 },
new Factor{
 Value=1073741824,
 Name="Byte / Second (B/s)"
 },
new Factor{
 Value=8388608,
 Name="Kilobit / Second (Kbit/s)"
 },
new Factor{
 Value=1048576,
 Name="Kilobyte / Second (KB/s)"
 },
new Factor{
 Value=8192,
 Name="Megabit / Second (Mbit/s)"
 },
new Factor{
 Value=1024,
 Name="Megabyte / Second (MB/s)"
 },
new Factor{
 Value=8,
 Name="Gigabit / Second (Gbit/s)"
 },
new Factor{
 Value=1,
 Name="Gigabyte / Second (GB/s)"
 },
new Factor{
 Value=64424509440,
 Name="Byte / Minute (B/min)"
 },
new Factor{
 Value=3865470566400,
 Name="Byte / Hour (B/h)"
 },
new Factor{
 Value=62914560,
 Name="Kilobyte / Minute (KB/min)"
 },
new Factor{
 Value=3774873600,
 Name="Kilobyte / Hour (KB/h)"
 },
new Factor{
 Value=61440,
 Name="Megabyte / Minute (MB/min)"
 },
new Factor{
 Value=3686400,
 Name="Megabyte / Hour (MB/h)"
 }
        })
        {

        }
    }
}
