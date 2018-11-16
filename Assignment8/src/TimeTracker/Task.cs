using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTracker
{
    public class Task
    {
        public string Name { get; private set; }
        public DateTime StartTime { get; private set; }
        public DateTime EndTime { get; set; }
        public TimeSpan EllapsedTime
        {
            get
            {
                return EndTime - StartTime;
            }
        }

        public Task(string name, IDateTime startTime)
        {
            Name = name;
            StartTime = startTime.Now();
        }
    }
}
