using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment6
{
    public struct BehaviorStruct
    {
        public string name { get; set; }
        public int age { get; set; }

        public BehaviorStruct(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }
}
