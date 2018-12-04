namespace Assignment9
{
    //Copied from: https://github.com/IntelliTect/EssentialCSharp/blob/v7.0/src/Chapter15/Listing15.10.FilteringWithSystem.Linq.Enumerable.Where.cs
    public class Patent
    {
        // Title of the published application
        public string Title { get; set; }

        // The date the application was officially published
        public string YearOfPublication { get; set; }

        // A unique number assigned to published applications
        public string ApplicationNumber { get; set; }

        public long[] InventorIds { get; set; }

        public override string ToString()
        {
            return $"{ Title } ({ YearOfPublication })";
        }
    }
}
