using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Assignment7.Tests
{
    [TestClass]
    public class NotNullableReferenceTests
    {
        [TestMethod]
        public void NotNullable_CreateNotNullableObjectAndSetItToNull_ObjectNotSetToNull()
        {
            NotNullable<TestClass> myClass = new NotNullable<TestClass>();

            myClass.Value = null;

            Assert.IsNotNull(myClass.Value);
        }
    }

    public class TestClass
    {
        public string Name { get; set; }

        public TestClass()
        {
            Name = "TestClass";
        }
    }
}
