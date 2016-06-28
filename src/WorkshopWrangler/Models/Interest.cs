using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkshopWrangler.Models
{
    public class Interest
    {
        public Interest()
        {
        }

        public string Name { get; set; }
        public string Email { get; set; }
        public string Comments { get; set; }
        public string[] Dates { get; set; }
    }
}
