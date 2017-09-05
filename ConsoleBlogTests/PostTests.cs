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
            Author testAuthor = new Author("Geoff", "Geoff@.Com", "total noob", "12334");
            string testTitle = "my test title";
            string testBody = "alot of great info";

            var testPost = new Post(testAuthor, testTitle, testBody);

            Assert.AreEqual(testTitle, testPost.Title);
            Assert.AreEqual(testBody, testPost.Body);
        }

        [TestMethod()]
        public void PostTestNullAuthorConstructor()
        {
            Author testAuthor = new Author("Geoff", "Geoff@.Com", "total noob", "12334");
            string testTitle = "my test title";
            string testBody = "alot of great info";

            var testPost = new Post(testAuthor, testTitle, testBody);

            Assert.AreEqual(testTitle, testPost.Title);
            Assert.AreEqual(testBody, testPost.Body);
        }

    }
}