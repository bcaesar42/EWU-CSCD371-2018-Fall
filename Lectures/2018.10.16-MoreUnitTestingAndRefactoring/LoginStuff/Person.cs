namespace LoginStuff.Tests
{
    public class Person
    {
        private string _UserName;
        public string UserName
        {
            get
            {
                return _UserName;
            }
            set
            {
                _UserName = value;
            }
        }

        private string Password;

        public string LastName { get; set; }



        private string _FirstName;
        public string FirstName {
            get
            {
                return _FirstName;
            }
            set
            {
                _FirstName = value;
            }
        }

        public Person(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }

        public Person(string firstName, string lastName, string password)
        {
            UserName = $"{firstName}.{lastName}";
            Password = password;
        }

        public void Deconstruct(out string firstName, out string lastName)
        {
            firstName = FirstName;
            lastName = LastName;
        }
    }
}