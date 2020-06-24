using System;
using System.Collections.Generic;
using System.Text;
using UnitConverter.Models;

namespace UnitConverter.Converters
{
    public class DataStorageConverter : UnitConverterBase
    {
        public DataStorageConverter() : base(new List<Factor>
        {
          new Factor{
 Value=8589934592,
 Name="Bit (bit)"
 },
new Factor{
 Value=1073741824,
 Name="Byte (B)"
 },
new Factor{
 Value=8388608,
 Name="Kilobit (Kbit)"
 },
new Factor{
 Value=1048576,
 Name="Kilobyte (KB)"
 },
new Factor{
 Value=8192,
 Name="Megabit (Mbit)"
 },
new Factor{
 Value=1024,
 Name="Megabyte (MB)"
 },
new Factor{
 Value=8,
 Name="Gigabit (Gbit)"
 },
new Factor{
 Value=1,
 Name="Gigabyte (GB)"
 },
new Factor{
 Value=0.0078125,
 Name="Terabit (Tbit)"
 },
new Factor{
 Value=0.0009766,
 Name="Terabyte (TB)"
 },
new Factor{
 Value=7.6293945E-6,
 Name="Petabit (Pbit)"
 },
new Factor{
 Value=2.5367432,
 Name="Petabyte (PB)"
 },
new Factor{
 Value=1473.23639,
 Name="Floppy disk (3.5, DD)"
 },
new Factor{
 Value=736.6181945,
 Name="Floppy disk (3.5, HD)"
 },
new Factor{
 Value=2946.4727757,
 Name="Floppy disk (5.25, DD)"
 },
new Factor{
 Value=884.5010542,
 Name="Floppy disk (5.25, HD)"
 },
new Factor{
 Value=10.6912457,
 Name="Zip 100"
 },
new Factor{
 Value=4.2764983,
 Name="Zip 250"
 },
new Factor{
 Value=1,
 Name="Jaz 1GB"
 },
new Factor{
 Value=0.5,
 Name="Jaz 2GB"
 },
new Factor{
 Value=1.5765784,
 Name="CD (74 minute)"
 },
new Factor{
 Value=1.458335,
 Name="CD (80 minute)"
 },
new Factor{
 Value=0.212766,
 Name="DVD (1 layer)"
 },
new Factor{
 Value=0.1176471,
 Name="DVD (2 layer)"
 },
new Factor{
 Value=0.04,
 Name="Blu-ray (1 layer)"
 },
new Factor{
 Value=0.02,
 Name="Blu-ray (2 layer)"
 },
new Factor{
 Value=0.06666666666,
 Name="HD-DVD (1 layer)"
 },
new Factor{
 Value=0.0333333,
 Name="HD-DVD (2 layer)"
 }
        })
        {
        }
    }
}
