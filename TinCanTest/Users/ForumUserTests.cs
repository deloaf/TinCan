using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TinCan.Users;

namespace TinCanTest.Users
{
    [TestClass]
    public class ForumUserTests
    {
        [TestMethod]
        public void UsernameTest() {
            ForumUser forumUserToTest = GetTestForumUser();
            const string testUsername = "TestUsername";
            forumUserToTest.Username = testUsername;
            Assert.AreEqual(testUsername, forumUserToTest.Username);
        }

        [TestMethod]
        public void FullNameTest() {
            ForumUser forumUserToTest = GetTestForumUser();

            const string testFirstName = "TestFirstName", testLastName = "TestLastName";            
            forumUserToTest.SetFullName(testFirstName, testLastName);
            
            string expectedFullName = testFirstName + " " + testLastName;
            string retrievedFullName = forumUserToTest.GetFullName();            
            Assert.AreEqual(expectedFullName, retrievedFullName);
        }

        [TestMethod]
        public void DateCreatedTest() {
            ForumUser userToTest = GetTestForumUser();           
            DateTime retreivedUserDateCreated = userToTest.GetDateCreated();            
            DateTime expectedDateTimeCreated = DateTime.Now.Date;            
            Assert.AreEqual(expectedDateTimeCreated, retreivedUserDateCreated);
        }

        private ForumUser GetTestForumUser(){
            TinCan.Users.ForumUserFactory newUserFactory = new ForumUserFactory();
            return newUserFactory.CreateForumUser("TestForumUser");
        }


    }
}
