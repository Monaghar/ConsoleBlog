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

            Assert.ThrowsException<ArgumentNullException>(() => new Author(name, eMail, bio, password));
        }

        [TestMethod()]
        public void AuthorEMailNullTest()
        {
            string name = "Hodor";
            string eMail = null;
            string bio = "I got turned simple by my time traveling master";
            string password = "432221";

            Assert.ThrowsException<ArgumentNullException>(() => new Author(name, eMail, bio, password));
        }

        [TestMethod()]
        public void AuthorBioNullTest()
        {
            string name = "Hodor";
            string eMail = "HOR@DOR";
            string bio = null;
            string password = "432221";

            Assert.ThrowsException<ArgumentNullException>(() => new Author(name, eMail, bio, password));
        }

        [TestMethod()]
        public void AuthorPasswordNullTest()
        {
            string name = "Hodor";
            string eMail = "HOR@DOR";
            string bio = "I got turned simple by my time traveling master";
            string password = null;

            Assert.ThrowsException<ArgumentNullException>(() => new Author(name, eMail, bio, password));
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

        [TestMethod()]
        public void AuthorLogOutTest()
        {
            string name = "Hodor";
            string eMail = "HOR@DOR";
            string bio = "I got turned simple by my time traveling master";
            string password = "432221";

            var author = new Author(name, eMail, bio, password);

            author.LogIn("432221");
            Assert.AreEqual(true, author.IsLoggedIn);
            author.LogOut();
            Assert.AreEqual(false, author.IsLoggedIn);
        }

        [TestMethod()]
        public void CreateCommentUnderCommentTest()
        {
            string name = "Hodor";
            string eMail = "HOR@DOR";
            string bio = "I got turned simple by my time traveling master";
            string password = "432221";

            var author = new Author(name, eMail, bio, password);
            var comment = new Comment("this is a test comment");
            string body = "so much testing";

            author.LogIn("432221");
            author.CreateComment(comment, body);

            Assert.IsNotNull(author.CommentHistory[0]);
            Assert.IsNotNull(comment.CommentChain[0]);
        }
    }
}