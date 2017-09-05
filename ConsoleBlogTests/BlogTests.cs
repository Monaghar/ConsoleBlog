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
    public class BlogTests
    {
        [TestMethod()]
        public void BlogConstructorTest()
        {
            Author testAuthor = new Author("Geoff", "Geoff@.Com", "total noob", "12334");
            string testDescription = "This is for code school.";
            string testTitle = "My Blog";

            var testBlog = new Blog(testAuthor, testTitle, testDescription);

            Assert.AreEqual(testAuthor, testBlog.Owner);
            Assert.AreEqual(testDescription, testBlog.Description);
        }

        [TestMethod()]
        public void BlogConstructorTitleNullTest()
        {
            Author testAuthor = new Author("Geoff", "Geoff@.Com", "total noob", "12334");
            string testDescription = "This is for code school.";
            string testTitle = null;

            Blog testBlog;

            try
            {
                testBlog = new Blog(testAuthor, testTitle, testDescription);
                Assert.IsNull(testBlog.Title);
            }
            catch(ArgumentNullException)
            {
                Assert.Pass("Blog Constructor Title null test passed");
            }
        }

        [TestMethod()]
        public void BlogConstructorDescriptionNullTest()
        {
            Author testAuthor = new Author("Geoff", "Geoff@.Com", "total noob", "12334");
            string testDescription = null;
            string testTitle = "My Blog";

            Blog testBlog;

            try
            {
                testBlog = new Blog(testAuthor, testTitle, testDescription);
                Assert.IsNull(testBlog.Description);
            }
            catch (ArgumentNullException)
            {
                Assert.Pass("Blog Constructor Description null test passed");
            }
        }

        [TestMethod()]
        public void BlogConstructorAuthorNullTest()
        {
            Author testAuthor = null;
            string testDescription = "This is for code school.";
            string testTitle = "My Blog";

            Blog testBlog;

            try
            {
                testBlog = new Blog(testAuthor, testTitle, testDescription);
                Assert.IsNull(testBlog.Owner);
            }
            catch (ArgumentNullException)
            {
                Assert.Pass("Blog Constructor Author null test passed");
            }
        }
    }
}
