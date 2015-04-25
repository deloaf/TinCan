using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TinCanTest.Users
{
    [TestClass]
    public class ForumUserTests
    {
        [TestMethod]
        public void UsernameTest() {
            TinCan.Users.ForumUser forumUserToTest = new TinCan.Users.ForumUserImp();
            const string testUsername = "TestUsername";
            forumUserToTest.Username = testUsername;
            Assert.AreEqual(testUsername, forumUserToTest.Username);
        }

        [TestMethod]
        public void FullNameTest() {            
            TinCan.Users.ForumUser forumUserToTest = new TinCan.Users.ForumUserImp();

            const string testFirstName = "TestFirstName", testLastName = "TestLastName";            
            forumUserToTest.SetFullName(testFirstName, testLastName);
            
            string expectedFullName = testFirstName + " " + testLastName;
            string retrievedFullName = forumUserToTest.GetFullName();            
            Assert.AreEqual(expectedFullName, retrievedFullName);
        }

        [TestMethod]
        public void DateCreatedTest() {
            TinCan.Users.ForumUser userToTest = new TinCan.Users.ForumUserImp();            
            DateTime retreivedUserDateCreated = userToTest.GetDateCreated();            
            DateTime expectedDateTimeCreated = DateTime.Now.Date;            
            Assert.AreEqual(expectedDateTimeCreated, retreivedUserDateCreated);
        }


    }
}
