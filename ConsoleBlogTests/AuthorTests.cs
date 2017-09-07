using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeSchool;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeSchoolBlog;



namespace CodeSchool.Tests
{
    [TestClass()]
    public class AuthorTests
    {
        [TestMethod()]
        public void AuthorTest()
        {
            string name = "Hodor";
            string eMail = "HOR@DOR";
            string bio = "I got turned simple by my time traveling master";
            string password = "432221";

            var author = new Author(name, eMail, bio, password);

            Assert.AreEqual(name, author.Name);
            Assert.AreEqual(eMail, author.EMail);
            Assert.AreEqual(bio, author.Bio);
            Assert.AreEqual(password, author.Password);
        }
        
        [TestMethod()]
        public void AuthorNameNullTest()
        {
            string name = null;
            string eMail = "HOR@DOR";
            string bio = "I got turned simple by my time traveling master";
            string password = "432221";

            var author;

            try
            {
                author  = new Author(name, eMail, bio, password);
                Assert.IsNull(author.Name);
            }
            catch(ArgumentNullException)
            {
                Assert.Pass("Author Constructor Name nulll test passed");
            }
        }

        [TestMethod()]
        public void AuthorEMailNullTest()
        {
            string name = "Hodor";
            string eMail = null;
            string bio = "I got turned simple by my time traveling master";
            string password = "432221";

            var author;

            try
            {
                author  = new Author(name, eMail, bio, password);
                Assert.IsNull(author.EMail);
            }
            catch(ArgumentNullException)
            {
                Assert.Pass("Author Constructor EMail nulll test passed");
            }
        }
        
        [TestMethod()]
        public void AuthorBioNullTest()
        {
            string name = "Hodor";
            string eMail = "HOR@DOR";
            string bio = null;
            string password = "432221";

            var author;

            try
            {
                author  = new Author(name, eMail, bio, password);
                Assert.IsNull(author.Bio);
            }
            catch(ArgumentNullException)
            {
                Assert.Pass("Author Constructor Bio nulll test passed");
            }
        }
        
        [TestMethod()]
        public void AuthorPasswordNullTest()
        {
            string name = "Hodor";
            string eMail = "HOR@DOR";
            string bio = "I got turned simple by my time traveling master";
            string password = null;

            var author;

            try
            {
                author  = new Author(name, eMail, bio, password);
                Assert.IsNull(author.Password);
            }
            catch(ArgumentNullException)
            {
                Assert.Pass("Author Constructor Password nulll test passed");
            }
        }
        
        [TestMethod()]
        public void AuthorLoggedInTest()
        {
            string name = "Hodor";
            string eMail = "HOR@DOR";
            string bio = "I got turned simple by my time traveling master";
            string password = "432221";

            var author = new Author(name, eMail, bio, password);

            author.LogIn("432221");

            Assert.AreEqual(true, author.IsLoggedIn);
        }
    }
}
