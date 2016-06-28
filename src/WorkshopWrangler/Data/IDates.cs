using System;
using System.Collections.Generic;

namespace WorkshopWrangler.Data
{
    public interface IDates
    {
        IEnumerable<DateTimeOffset> GetAvailableDates();
    }
}
