using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment9
{
    public class Inventor
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }

        public override string ToString()
        {
            return $"{ Name } ({ City }, { State })";
        }
    }
}
