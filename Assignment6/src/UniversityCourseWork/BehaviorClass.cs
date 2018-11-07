using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment6
{
    public class BehaviorClass
    {
        public string name { get; set; }
        public int age { get; set; }

        public BehaviorClass(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }
}
