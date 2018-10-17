using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LoginStuff.Tests
{
    [TestClass]
    public class PersonTests
    {
        [TestMethod]
        public void Create_Person_Success()
        {
            Person person = new Person("Inigo", "Montoya", "Password");
            Assert.AreEqual("Inigo", person.FirstName);
            Assert.AreEqual("Inigo", person.LastName);
            Assert.AreEqual("Inigo.Montoya", person.UserName);

        }

        [TestMethod]
        public void UserName_ChangeName_Success()
        {
            Person person = new Person("Inigo", "Montoya", "Password");
            person.FirstName = "Frank";
            Assert.AreEqual("Frank", person.FirstName);
            person.LastName = "Nelson";
            Assert.AreEqual("Nelson", person.LastName);
        }

        [TestMethod]
        public void Deconstructor_Returns_FirstName_LastName()
        {
            var person = new Person("Inigo", "Montoya");

            (string firstName, string lastName) = person;
        }
    }


}
