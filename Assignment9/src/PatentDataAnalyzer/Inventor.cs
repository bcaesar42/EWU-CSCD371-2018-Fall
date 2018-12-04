namespace Assignment9
{
    //Copied from: https://github.com/IntelliTect/EssentialCSharp/blob/v7.0/src/Chapter15/Listing15.10.FilteringWithSystem.Linq.Enumerable.Where.cs
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
