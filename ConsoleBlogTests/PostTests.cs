using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeSchoolBlog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSchoolBlog.Tests
{
    [TestClass()]
    public class PostTests
    {
        [TestMethod()]
        public void PostTest()
        {
            string testTitle = "my test title";
            string testBody = "alot of great info";

            var testPost = new Post(testTitle, testBody);

            Assert.AreEqual(testTitle, testPost.Title);
            Assert.AreEqual(testBody, testPost.Body);
        }

        [TestMethod()]
        public void PostTestNullTitleConstructor()
        {
            string testTitle = null;
            string testBody = "alot of great info";

            Post testPost;

            try
            {
                testPost = new Post(testTitle, testBody);
                Assert.IsNull(testPost.Title);
            }
            catch (ArgumentNullException)
            {
                Assert.ThrowsException<ArgumentNullException>(() => new Post(testTitle, testBody));
            }
        }

        [TestMethod()]
        public void PostTestNullBodyConstructor()
        {
            string testTitle = "my test title";
            string testBody = null;

            Post testPost;

            try
            {
                testPost = new Post(testTitle, testBody);
                Assert.IsNull(testPost.Body);
            }
            catch (ArgumentNullException)
            {
                Assert.ThrowsException<ArgumentNullException>(() => new Post(testTitle, testBody));
            }
        }
    }
}