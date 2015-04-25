using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TinCan.Users;

namespace TinCanTest.Users
{
    [TestClass]
    public class UserTests
    {
        [TestMethod]
        public void UsernameTest()
        {
            const string testName = "TestUsername";
            User userToTest = new User();
            userToTest.Username = testName;
            Assert.AreEqual(testName, userToTest.Username);
        }

        [TestMethod]
        public void FirstNameTest()
        {
            const string testFirstName = "TestFirstName";
            User userToTest = new User();
            userToTest.FirstName = testFirstName;
            Assert.AreEqual(testFirstName, userToTest.FirstName);
        }

        [TestMethod]
        public void LastNameTest()
        {
            const string testLastName = "TestLastName";
            User userToTest = new User();
            userToTest.LastName = testLastName;
            Assert.AreEqual(testLastName, userToTest.LastName);
        }

        [TestMethod]
        public void DateJoinedTest()
        {
            DateTime testDateTimeCreated = DateTime.Now.AddMinutes(10);
            User userToTest = new User();
            userToTest.DateTimeCreated = testDateTimeCreated;
            Assert.AreEqual(testDateTimeCreated, userToTest.DateTimeCreated);
        }
    }
}
