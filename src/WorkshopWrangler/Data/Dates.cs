using System;
using System.Collections.Generic;

namespace WorkshopWrangler.Data
{
    public class Dates : IDates
    {
        private static readonly Dictionary<int, int[]> MonthDays = new Dictionary<int, int[]> {
            { 8, new[] {6, 13, 27} },
            { 9, new[] {3, 17, 24} },
            { 10, new[] {1, 8, 15, 22, 29} },
            { 11, new[] {12, 19, 26} },
            { 12, new[] {3, 10} }
        };

        public IEnumerable<DateTimeOffset> GetAvailableDates()
        {
            foreach (var kvp in MonthDays)
            {
                foreach (var day in kvp.Value)
                {
                    yield return new DateTimeOffset(2016, kvp.Key, day, 0, 0, 0, TimeSpan.Zero);
                }
            }
        }
    }
}
