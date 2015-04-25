using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TinCan.Users;
using TinCan.Posts;

namespace TinCanTest.Posts {

    [TestClass]
    public class PostTests {

        [TestMethod]
        public void PostIDNotNullTest() {
            Post postToTest = new Post();
            Guid testIdForPost = System.Guid.NewGuid();
            postToTest.Id = testIdForPost;
            Assert.AreEqual(testIdForPost, postToTest.Id);
        }

        [TestMethod]
        public void PostDateTimeTest() {
            Post postToTest = new Post();
            DateTime testDateTime = System.DateTime.Now;
            postToTest.DateCreated = testDateTime;
            Assert.AreEqual(testDateTime, postToTest.DateCreated);
        }

        [TestMethod]
        public void PostMessageTest() {
            Post postToTest = new Post();
            string testMessage = "This is a test message!";
            postToTest.Message = testMessage;
            Assert.AreEqual(testMessage, postToTest.Message);
        }

        [TestMethod]
        public void PostUserTest() {
            ForumUser testUser = CreateForumUser();
            Post postToTest = new Post();
            postToTest.Creator = testUser;
            Assert.AreEqual(testUser, postToTest.Creator);
        }

        private ForumUser CreateForumUser() {
            ForumUserFactory testFactory = new ForumUserFactory();
            string testUsername = "testUsername";
            return testFactory.CreateForumUser(testUsername);
        }
    }

}
