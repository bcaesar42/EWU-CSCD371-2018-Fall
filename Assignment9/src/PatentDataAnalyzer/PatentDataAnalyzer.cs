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
    }
}
