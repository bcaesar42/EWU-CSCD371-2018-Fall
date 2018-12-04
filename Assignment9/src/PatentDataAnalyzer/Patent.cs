using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment9
{
    public class Patent
    {
        // Title of the published application
        public string Title { get; set; }

        // The date the application was officially published
        public string YearOfPublication { get; set; }

        // A unique number assigned to published applications
        public string ApplicationNumber { get; set; }

        public long[] InventorIds { get; set; }

        public override string ToString()
        {
            return $"{ Title } ({ YearOfPublication })";
        }
    }
}
