using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TinCanTest.Users
{
    [TestClass]
    public class UserTests
    {
        [TestMethod]
        public void UsernameTest()
        {
            const string testName = "TestUsername";
            TinCan.Users.User userToTest = new TinCan.Users.User();
            userToTest.Username = testName;
            Assert.AreEqual(testName, userToTest.Username);
        }

        [TestMethod]
        public void FirstNameTest()
        {
            const string testFirstName = "TestFirstName";
            TinCan.Users.User userToTest = new TinCan.Users.User();
            userToTest.FirstName = testFirstName;
            Assert.AreEqual(testFirstName, userToTest.FirstName);
        }

        [TestMethod]
        public void LastNameTest()
        {
            const string testLastName = "TestLastName";
            TinCan.Users.User userToTest = new TinCan.Users.User();
            userToTest.LastName = testLastName;
            Assert.AreEqual(testLastName, userToTest.LastName);
        }

        [TestMethod]
        public void DateJoinedTest()
        {
            DateTime testDateTimeCreated = DateTime.Now.AddMinutes(10);
            TinCan.Users.User userToTest = new TinCan.Users.User();
            userToTest.DateTimeCreated = testDateTimeCreated;
            Assert.AreEqual(testDateTimeCreated, userToTest.DateTimeCreated);
        }
    }
}
