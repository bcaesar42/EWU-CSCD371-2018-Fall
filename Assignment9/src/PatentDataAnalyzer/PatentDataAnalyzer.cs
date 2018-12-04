using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment9
{
    public static class PatentDataAnalyzer
    {
        public static List<string> InventorNames(string country)
        {
            if (string.IsNullOrEmpty(country))
            {
                throw new ArgumentException("The country being specified cannot be null or empty.");
            }

            IEnumerable<string> query = from Inventor in PatentData.Inventors
                                        where Inventor.Country.Equals(country)
                                        select Inventor.Name;

            return query.ToList<string>();
        }

        public static List<string> InventorLastNames()
        {
            IEnumerable<string> query = from Inventor in PatentData.Inventors
                                        let lastName = Inventor.Name.Split().Last<string>()
                                        orderby Inventor.Id descending
                                        select lastName;

            return query.ToList<string>();
        }

        public static string LocationsWithInventors()
        {
            IEnumerable<string> uniqueStatesQuery = from Inventor in PatentData.Inventors
                                                    group Inventor by Inventor.State into stateGroup
                                                    select stateGroup.Key;

            IEnumerable<string> uniqueCountriesQuery = from Inventor in PatentData.Inventors
                                                       group Inventor by Inventor.Country into countryGroup
                                                       select countryGroup.Key;

            IEnumerable<string> resultQuery = from state in uniqueStatesQuery
                                              from country in uniqueCountriesQuery
                                              select $"{state}-{country}";

            return string.Join<string>(", ", resultQuery);
        }

        public static List<Inventor> GetInventorsWithMultiplePatents(int n)
        {
            IEnumerable<(string Name, int PatentCount)> patentCounts = from Inventor in PatentData.Inventors
                                                                       from Patent in PatentData.Patents
                                                                       where Patent.InventorIds.Contains<long>(Inventor.Id)
                                                                       group Inventor by Inventor.Name into InventorsPatents
                                                                       select (InventorsPatents.Key, InventorsPatents.Key.Count());

            IEnumerable<Inventor> inventorsWithN = from Inventor in PatentData.Inventors
                                                   from Counter in patentCounts
                                                   where Inventor.Name == Counter.Name && Counter.PatentCount == n
                                                   select Inventor;

            return inventorsWithN.ToList<Inventor>();
        }
    }
}
