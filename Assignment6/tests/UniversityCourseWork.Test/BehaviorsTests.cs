using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Runtime.InteropServices;

namespace Assignment6.Tests
{
    [TestClass]
    public class BehaviorsTests
    {
        private void ChangeStructAge(BehaviorStruct str)
        {
            str.age = 102;
        }

        private void ChangeStructAgeByRef(ref BehaviorStruct str)
        {
            str.age = 102;
        }

        [TestMethod]
        public void Struct_ValueNotChangedAfterMethod()
        {
            BehaviorStruct behave = new BehaviorStruct("Bob", 42);
            ChangeStructAge(behave);
            Assert.AreEqual(42, behave.age);
        }

        [TestMethod]
        public void Struct_ValueIsChangedAfterMethod()
        {
            BehaviorStruct behave = new BehaviorStruct("Bob", 42);
            ChangeStructAge(behave);
            Assert.AreEqual(102, behave.age);
        }
    }
}
