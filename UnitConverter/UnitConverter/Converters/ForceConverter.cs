using System;
using System.Collections.Generic;
using System.Text;
using UnitConverter.Models;

namespace UnitConverter.Converters
{
    public class ForceConverter : IUnitConverter
    {
        static string[] Unit_Name = new[] {"attonewton", "centinewton", "decigram-force", "decinewton", "dekagram-force", "dekanewton", "dyne (dyn)", "exanewton",
            "femtonewton", "giganewton (GN)", "gram-force", "hectonewton", "joule / meter (J/m)", "kilogram-force (kgf)", "kilonewton (kN)",
            "kilopond (kp)", "kip (kip)", "meganewton", "megapond", "micronewton (µN)", "millinewton (mN)", "nanonewton (nN)", "newton (N)",
            "ounce-force (ozf)", "petanewton", "piconewton", "pond", "pound-force (lbf)", "poundal (pdl)", "sthene (sn)", "teranewton", "ton-force (long)(tnf)",
            "ton-force (metric)(tnf)", "ton-force (short)(tnf)", "yoctonewton", "yottanewton", "zeptonewton", "zettanewton"};
        static double[] Factors = new[] {1.0E+19, 100, 1019.716213, 10, 10.19716213, 0.1, 100000, 1.0E-17, 1.0E+16, 1.0E-8, 101.9716213, 0.01, 1, 0.1019716, 0.001,
            0.1019716, 0.0002248, 1.0E-5, 0.0001019716213, 1000000, 1000, 1000000000, 1, 3.5969431019, 1.0E-14, 1000000000000, 101.9716213, 0.22480894387,
            7.2330140801, 0.001, 1.0E-11, 0.00010036113566, 0.0001019716213, 0.00011240447194, 1.0E+25, 1.0E-23, 1.0E+22, 1.0E-20 };
        public string Convert(int from, int to, double value)
        {
            var faqsorg = Factors[to] / Factors[from];
            var resfaqs = value * faqsorg;
            return resfaqs.ToString();
        }

        public IEnumerable<Unit> GetUnitTypes()
        {
            yield return new Unit { Id = 0, Text = "Attonewton" };
            yield return new Unit { Id = 1, Text = "Centinewton" };
            yield return new Unit { Id = 2, Text = "Decigram-force" };
            yield return new Unit { Id = 3, Text = "Decinewton" };
            yield return new Unit { Id = 4, Text = "Dekagram-force" };
            yield return new Unit { Id = 5, Text = "Dekanewton" };
            yield return new Unit { Id = 6, Text = "Dyne (dyn)" };
            yield return new Unit { Id = 7, Text = "Exanewton" };
            yield return new Unit { Id = 8, Text = "Femtonewton" };
            yield return new Unit { Id = 9, Text = "Giganewton (GN)" };
            yield return new Unit { Id = 10, Text = "Gram-force" };
            yield return new Unit { Id = 11, Text = "Hectonewton" };
            yield return new Unit { Id = 12, Text = "Joule / Meter (J/m)" };
            yield return new Unit { Id = 13, Text = "Kilogram-force (kgf)" };
            yield return new Unit { Id = 14, Text = "Kilonewton (kN)" };
            yield return new Unit { Id = 15, Text = "Kilopond (kp)" };
            yield return new Unit { Id = 16, Text = "Kip (kip)" };
            yield return new Unit { Id = 17, Text = "Meganewton" };
            yield return new Unit { Id = 18, Text = "Megapond" };
            yield return new Unit { Id = 19, Text = "Micronewton (µN)" };
            yield return new Unit { Id = 20, Text = "Millinewton (mN)" };
            yield return new Unit { Id = 21, Text = "Nanonewton (nN)" };
            yield return new Unit { Id = 22, Text = "Newton (N)" };
            yield return new Unit { Id = 23, Text = "Ounce-force (ozf)" };
            yield return new Unit { Id = 24, Text = "Petanewton" };
            yield return new Unit { Id = 25, Text = "Piconewton" };
            yield return new Unit { Id = 26, Text = "Pound" };
            yield return new Unit { Id = 27, Text = "Pound-force (lbf)" };
            yield return new Unit { Id = 28, Text = "Poundal (pdl)" };
            yield return new Unit { Id = 29, Text = "Sthene (sn)" };
            yield return new Unit { Id = 30, Text = "Teranewton" };
            yield return new Unit { Id = 31, Text = "Ton-force (long)(tnf)" };
            yield return new Unit { Id = 32, Text = "Ton-force (metric)(tnf)" };
            yield return new Unit { Id = 33, Text = "Ton-force (short)(tnf)" };
            yield return new Unit { Id = 34, Text = "Yoctonewton" };
            yield return new Unit { Id = 35, Text = "Yottanewton" };
            yield return new Unit { Id = 36, Text = "Zeptonewton" };
            yield return new Unit { Id = 37, Text = "Zettanewton" };
        }
    }
}
