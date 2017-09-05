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
            Author testAuthor = null;
            string testTitle = "my test title";
            string testBody = "alot of great info";

            var testPost; 
            
            try
            {
               testPost = new Post(testAuthor, testTitle, testBody);
               Assert.IsNull(testPost.Owner);
            }
            catch(ArgumentNullException)
            {
                Assert.Pass("Post Constructor Author nulll test passed");
            }
        }

        [TestMethod()]
        public void PostTestNullTitleConstructor()
        {
            Author testAuthor = new Author("Geoff", "Geoff@.Com", "total noob", "12334");
            string testTitle = null;
            string testBody = "alot of great info";

            var testPost; 
            
            try
            {
               testPost = new Post(testAuthor, testTitle, testBody);
               Assert.IsNull(testPost.Title);
            }
            catch(ArgumentNullException)
            {
                Assert.Pass("Post Constructor Title nulll test passed");
            }
        }
        
        [TestMethod()]
        public void PostTestNullBodyConstructor()
        {
            Author testAuthor = new Author("Geoff", "Geoff@.Com", "total noob", "12334");
            string testTitle = "my test title";
            string testBody = null;

            var testPost; 
            
            try
            {
               testPost = new Post(testAuthor, testTitle, testBody);
               Assert.IsNull(testPost.Body);
            }
            catch(ArgumentNullException)
            {
                Assert.Pass("Post Constructor Body nulll test passed");
            }
        }
    }
}
