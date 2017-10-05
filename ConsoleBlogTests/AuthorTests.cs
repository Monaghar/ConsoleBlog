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

        //[TestMethod()]
        //public void CreateCommentWithQuoteUnderCommentTest()
        //{
        //    string name = "Hodor";
        //    string eMail = "HOR@DOR";
        //    string bio = "I got turned simple by my time traveling master";
        //    string quote = "look at my quote!";
        //    string password = "432221";

        //    var author = new Author(name, eMail, bio, password);
        //    var comment = new Comment("this is a test comment");
        //    string body = "so much testing";

        //    author.LogIn("432221");
        //    author.CreateComment(comment, body, quote);

        //    Assert.AreEqual(comment.Body, "\"look at my quote!\" so much testing");
        //}

        [TestMethod()]
        public void CreateCommentUnderPostTest()
        {
            string name = "Hodor";
            string eMail = "HOR@DOR";
            string bio = "I got turned simple by my time traveling master";
            string quote = "look at my quote!";
            string password = "432221";

            var author = new Author(name, eMail, bio, password);
            var post = new Post("this is a test post", "OOooo lookit dat body");
            string body = "so much testing";

            author.LogIn("432221");
            author.CreateComment(post, body);

            Assert.IsNotNull(author.CommentHistory[0]);
            Assert.IsNotNull(post.CommentChain[0]);
        }
        
        // [TestMethod()]
        //public void CreateCommentWithQuoteUnderPostTest()
        //{
        //    string name = "Hodor";
        //    string eMail = "HOR@DOR";
        //    string bio = "I got turned simple by my time traveling master";
        //    string quote = "look at my quote!";
        //    string password = "432221";

        //    var author = new Author(name, eMail, bio, password);
        //    var post = new Post("this is a test post", "OOooo lookit dat body");
        //    string body = "so much testing";

        //    author.LogIn("432221");
        //    author.CreateComment(post, body, quote);
            
        //    Assert.AreEqual(comment.Body, "\"look at my quote!\" so much testing");
        //}
        
        //[TestMethod()]
        //public void EditComment()
        //{
        //    string name = "Hodor";
        //    string eMail = "HOR@DOR";
        //    string bio = "I got turned simple by my time traveling master";
        //    string quote = "look at my quote!";
        //    string password = "432221";

        //    var author = new Author(name, eMail, bio, password);
        //    var post = new Post("this is a test post", "OOooo lookit dat body");
        //    string body = "so much testing";
        //    string newBody = "Way so much testing";

        //    author.LogIn("432221");
        //    author.CreateComment(post, body, quote);
        //    author.EditComment(author.CommentHistory[0], newBody);

        //    Assert.AreEqual(comment.Body, newBody);
        //}
        
        // [TestMethod()]
        //public void GoodRateComment()
        //{
        //    string name = "Hodor";
        //    string eMail = "HOR@DOR";
        //    string bio = "I got turned simple by my time traveling master";
        //    string quote = "look at my quote!";
        //    string password = "432221";

        //    var author = new Author(name, eMail, bio, password);
        //    var post = new Post("this is a test post", "OOooo lookit dat body");
        //    string body = "so much testing";
        //    string newBody = "Way so much testing";

        //    author.LogIn("432221");
        //    author.CreateComment(post, body, quote);
        //    author.RateComment(author.CommentHistory[0], true);

        //    Assert.AreEqual(comment.Rating, 1);
        //}
        
        // [TestMethod()]
        //public void BadRateComment()
        //{
        //    string name = "Hodor";
        //    string eMail = "HOR@DOR";
        //    string bio = "I got turned simple by my time traveling master";
        //    string quote = "look at my quote!";
        //    string password = "432221";

        //    var author = new Author(name, eMail, bio, password);
        //    var post = new Post("this is a test post", "OOooo lookit dat body");
        //    string body = "so much testing";
        //    string newBody = "Way so much testing";

        //    author.LogIn("432221");
        //    author.CreateComment(post, body, quote);
        //    author.RateComment(author.CommentHistory[0], false);

        //    Assert.AreEqual(comment.Rating, -0);
        //}
        
        //[TestMethod()]
        //public void ReportComment()
        //{
        //    string name = "Hodor";
        //    string eMail = "HOR@DOR";
        //    string bio = "I got turned simple by my time traveling master";
        //    string password = "432221";

        //    var author = new Author(name, eMail, bio, password);
        //    var post = new Post("this is a test post", "OOooo lookit dat body");
        //    string body = "so much testing";

        //    author.LogIn("432221");
        //    author.CreateComment(post, body);
        //    author.ReportComment(author.CommentHistory[0], true);

        //    Assert.AreEqual(comment.IsReported, true);
        //}
        
        // [TestMethod()]
        //public void UnReportComment()
        //{
        //    string name = "Hodor";
        //    string eMail = "HOR@DOR";
        //    string bio = "I got turned simple by my time traveling master";
        //    string password = "432221";

        //    var author = new Author(name, eMail, bio, password);
        //    var admin = new Admin(name, eMail, bio, password, "signature");
        //    var post = new Post("this is a test post", "OOooo lookit dat body");
        //    string body = "so much testing";

        //    author.LogIn("432221");
        //    author.CreateComment(post, body);
        //    admin.ReportComment(author.CommentHistory[0], false);

        //    Assert.AreEqual(comment.IsReported, false);
        //}
    }
}
