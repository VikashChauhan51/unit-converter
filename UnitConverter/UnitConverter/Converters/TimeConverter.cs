using System;
using System.Collections.Generic;
using System.Text;
using UnitConverter.Models;

namespace UnitConverter.Converters
{
    public class TimeConverter : IUnitConverter
    {
        static string[] Unit_Name = new[] { "millennium", "century", "decade", "Julian year", "Gregorian year",
            "tropical year", "year", "month", "fortnight", "week", "day", "hour",
            "minute", "second", "millisecond", "microsecond", "nanosecond" };
        static double[] Factors = new[] { 2.7397260273973E-6, 2.7397260273973E-5, 0.00027397260273973,
            0.0027378507871321, 0.0027379070069885, 0.0027379092633269, 0.0027397260273973, 0.032853922534821,
            0.071428571428571, 0.14285714285714, 1, 24, 1440, 86400, 86400000, 86400000000, 86400000000000 };

        public string Convert(int from, int to, double value)
        {
            var faqsorg = Factors[to] / Factors[from];
            var resfaqs = value * faqsorg;
            return resfaqs.ToString();
        }

        public IEnumerable<Unit> GetUnitTypes()
        {
            yield return new Unit { Id = 0, Text = "Millennium" };
            yield return new Unit { Id = 1, Text = "Century" };
            yield return new Unit { Id = 2, Text = "Decade" };
            yield return new Unit { Id = 3, Text = "Julian Year" };
            yield return new Unit { Id = 4, Text = "Gregorian Year" };
            yield return new Unit { Id = 5, Text = "Tropical Year" };
            yield return new Unit { Id = 6, Text = "Year" };
            yield return new Unit { Id = 7, Text = "Month" };
            yield return new Unit { Id = 8, Text = "Fortnight" };
            yield return new Unit { Id = 9, Text = "Week" };
            yield return new Unit { Id = 10, Text = "Day" };
            yield return new Unit { Id = 11, Text = "Hour" };
            yield return new Unit { Id = 12, Text = "Minute" };
            yield return new Unit { Id = 13, Text = "Second" };
            yield return new Unit { Id = 14, Text = "Millisecond" };
            yield return new Unit { Id = 15, Text = "Microsecond" };
            yield return new Unit { Id = 16, Text = "Nanosecond" };
        }
    }
}
