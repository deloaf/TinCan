using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TinCanTest.Users {
    [TestClass]
    public class ForumUserFactoryTests {
        [TestMethod]
        public void CreateNewUserTest() {            
            TinCan.Users.ForumUserFactory testUserFactory = new TinCan.Users.ForumUserFactory();            
            string testUsername = "TestUserName";            
            TinCan.Users.ForumUser testForumUser = testUserFactory.CreateForumUser(testUsername);            
            Assert.AreEqual(testUsername, testForumUser.Username);
        }
    }
}
