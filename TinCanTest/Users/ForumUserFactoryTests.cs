using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TinCan.Users;

namespace TinCanTest.Users {
    [TestClass]
    public class ForumUserFactoryTests {
        [TestMethod]
        public void CreateNewUserTest() {            
            ForumUserFactory testUserFactory = new ForumUserFactory();            
            string testUsername = "TestUserName";            
            ForumUser testForumUser = testUserFactory.CreateForumUser(testUsername);            
            Assert.AreEqual(testUsername, testForumUser.Username);
        }
    }
}
