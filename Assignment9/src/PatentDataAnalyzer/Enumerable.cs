using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatentDataAnalyzer
{
    public static class Enumerable
    {
        public static IEnumerable<T> Randomize<T>(this IEnumerable<T> items)
        {
            //List<T> originalList = items.ToList<T>();
            //List<T> randomizedList = new List<T>(originalList.Count);

            //foreach (T item in originalList)
            //{

            //}

            Random random = new Random();

            IEnumerable<T> randomizedQuery = from item in items
                                             orderby random.Next()
                                             select item;

            return randomizedQuery;
        }
    }
}
