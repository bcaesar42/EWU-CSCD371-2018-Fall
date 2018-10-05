using System;
using System.Collections.Generic;

namespace Notes_10_2_18
{
    class Program
    {
        static void Main(string[] args)
        {
            (string name, int age) tuple = ("kevin", 42);
            var number = 42.1234;
            string foo = $"My number is {number:F2}";
            DateTime today = DateTime.Now;
            Console.WriteLine(today);

            List<int> list = new List<int> {1, 2, 3, 4};
            list.Count; //Equivilent of array.length
            
            var array = new int[3] {1, 2, 3};

            System.Array.Sort(array);
        }

        public static int AddStuff(params int[] numbers)
        {
            //The "params" keyword will automatically fit parameters into an array, if it can.
            int sum = 0;
            for (int num = 0; num < numbers.Length; num++)
                sum += numbers[num];

            return sum;
        }
    }
}

/*
    Value types (primitives) live in stack.
    Reference types (objects) live in heap.

    DateTime is a value type.

    Tuples are structs.
    Tuples are mutable.
    Tuples can be used to return multiple values from a method.
    You can't deconstruct tuples into existing variable names.
    Pages 34-35 in the book.

    Dont use: System.Tuple

    Arrays are refernce types.
 */