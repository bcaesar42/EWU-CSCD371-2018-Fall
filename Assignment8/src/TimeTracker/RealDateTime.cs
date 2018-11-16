using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTracker
{
    public class RealDateTime : IDateTime
    {
        public DateTime Now()
        {
            return DateTime.Now;
        }
    }
}
