using System;
using System.Collections.Generic;
using System.Text;
using UnitConverter.Models;

namespace UnitConverter.Converters
{
    public class VolumeConverter : IUnitConverter
    {
        static string[] Unit_Name = new[]{"barrel (petroleum) (bbl, bo)", "bushel (UK) (bu)", "bushel (US dry) (bu)", "centiliter (cl)", "cubic centimeter (cc, cm³)", "cubic decimeter (dm³)",
            "cubic foot (ft³, cu ft)", "cubic inch (in³, cu in) ", "cubic meter (m³)", "cubic millimeter (mm³)", "cubic yard (yd³)",
            "dekaliter (dal)", "fluid dram (fl dr)", "fluid ounce (fl oz)", "fluid ounce (UK) (fl oz)", "gallon (fluid) (gal)", "gallon (UK) (gal)", "gill (gi)",
            "hectoliter (hl)", "kiloliter (kl)", "liter (l)", "microliter (µl)", "milliliter (ml)", "minim (min)", "peck (US dry) (pk)", "pint (fluid) (pt)", "pint (UK) (pt)",
            "pint (US dry) (pt)", "quart (fluid) (qt)", "quart (UK) (qt)", "quart (US dry) (qt)"};
        static double[] Factors = new[]{6.2898107704321, 27.496156037386, 28.377593258402, 100000, 1000000, 1000, 35.314666721489, 61023.744094732, 1, 1000000000, 1.3079506193144,
            100, 270512.18161474, 33814.022701843, 35195.079727854, 264.17205235815, 219.96924829909, 8453.5056754608, 10, 1, 1000, 1000000000, 1000000, 16230730.896885,
            113.51037303361, 2113.3764188652, 1759.7539863927, 1816.1659685377, 1056.6882094326, 879.87699319635, 908.08298426886 };
        public string Convert(int from, int to, double value)
        {
            var faqsorg = Factors[to] / Factors[from];
            var resfaqs = value * faqsorg;
            return resfaqs.ToString();
        }

        public IEnumerable<Unit> GetUnitTypes()
        {
            yield return new Unit { Id = 0, Text = "Barrel (bbl, bo)" };
            yield return new Unit { Id = 1, Text = "Bushel (UK) (bu)" };
            yield return new Unit { Id = 2, Text = "Bushel (US dry) (bu)" };
            yield return new Unit { Id = 3, Text = "Centiliter (cl)" };
            yield return new Unit { Id = 4, Text = "Cubic Centimeter (cc, cm³)" };
            yield return new Unit { Id = 5, Text = "Cubic Decimeter (dm³)" };
            yield return new Unit { Id = 6, Text = "Cubic Foot (ft³, cu ft)" };
            yield return new Unit { Id = 7, Text = "Cubic Inch (in³, cu in) " };
            yield return new Unit { Id = 8, Text = "Cubic meter (m³)" };
            yield return new Unit { Id = 9, Text = "Cubic Millimeter (mm³)" };
            yield return new Unit { Id = 10, Text = "Cubic Yard (yd³)" };
            yield return new Unit { Id = 11, Text = "Dekaliter (dal)" };
            yield return new Unit { Id = 12, Text = "Fluid Dram (fl dr)" };
            yield return new Unit { Id = 13, Text = "Fluid Ounce (fl oz)" };
            yield return new Unit { Id = 14, Text = "Fluid Ounce (UK) (fl oz)" };
            yield return new Unit { Id = 15, Text = "Gallon (gal)" };
            yield return new Unit { Id = 16, Text = "Gallon (UK) (gal)" };
            yield return new Unit { Id = 17, Text = "Gill (gi)" };
            yield return new Unit { Id = 18, Text = "Hectoliter (hl)" };
            yield return new Unit { Id = 19, Text = "Kiloliter (kl)" };
            yield return new Unit { Id = 20, Text = "Liter (l)" };
            yield return new Unit { Id = 21, Text = "Microliter (µl)" };
            yield return new Unit { Id = 22, Text = "Milliliter (ml)" };
            yield return new Unit { Id = 23, Text = "Minim (min)" };
            yield return new Unit { Id = 24, Text = "Peck (US dry) (pk)" };
            yield return new Unit { Id = 25, Text = "Pint (pt)" };
            yield return new Unit { Id = 26, Text = "Pint (UK) (pt)" };
            yield return new Unit { Id = 27, Text = "Pint (US dry) (pt)" };
            yield return new Unit { Id = 28, Text = "Quart (qt)" };
            yield return new Unit { Id = 29, Text = "Quart (UK) (qt)" };
            yield return new Unit { Id = 30, Text = "Quart (US dry) (qt)" };
        }
    }
}
