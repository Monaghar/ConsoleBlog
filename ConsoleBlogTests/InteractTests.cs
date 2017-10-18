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
    public class InteractTests
    {
        [TestMethod()]
        public void EditComment()
        {
            string name = "Hodor";
            string eMail = "HOR@DOR";
            string bio = "I got turned simple by my time traveling master";
            string quote = "look at my quote!";
            string password = "432221";
            var author = new Author(name, eMail, bio, password);
            var post = new Post("this is a test post", "OOooo lookit dat body");
            string body = "so much testing";
            string newBody = "Way so much testing";
            author.LogIn("432221");
            Comment comment = Poaster.CreateComment(author, post, body);
            Interact.EditComment(author, author.CommentHistory[0], newBody);

            Assert.AreEqual(comment.Body, newBody);
        }

        [TestMethod()]
        public void GoodRateComment()
        {
            string name = "Hodor";
            string eMail = "HOR@DOR";
            string bio = "I got turned simple by my time traveling master";
            string quote = "look at my quote!";
            string password = "432221";
            var author = new Author(name, eMail, bio, password);
            var post = new Post("this is a test post", "OOooo lookit dat body");
            string body = "so much testing";
            string newBody = "Way so much testing";
            author.LogIn("432221");
            Comment comment = Poaster.CreateComment(author, post, body);
            Interact.RateComment(author, author.CommentHistory[0], true);

            Assert.AreEqual(comment.Rating, 1);
        }

        [TestMethod()]
        public void BadRateComment()
        {
            string name = "Hodor";
            string eMail = "HOR@DOR";
            string bio = "I got turned simple by my time traveling master";
            string quote = "look at my quote!";
            string password = "432221";
            var author = new Author(name, eMail, bio, password);
            var post = new Post("this is a test post", "OOooo lookit dat body");
            string body = "so much testing";
            string newBody = "Way so much testing";
            author.LogIn("432221");
            Comment comment = Poaster.CreateComment(author, post, body);
            Interact.RateComment(author, author.CommentHistory[0], false);

            Assert.AreEqual(comment.Rating, -0);
        }

        [TestMethod()]
        public void ReportComment()
        {
            string name = "Hodor";
            string eMail = "HOR@DOR";
            string bio = "I got turned simple by my time traveling master";
            string password = "432221";
            var author = new Author(name, eMail, bio, password);
            var post = new Post("this is a test post", "OOooo lookit dat body");
            string body = "so much testing";
            author.LogIn("432221");
            Comment comment = Poaster.CreateComment(author, post, body);
            Interact.ReportComment(author, author.CommentHistory[0], true);
        
            Assert.AreEqual(comment.IsReported, true);
        }

        [TestMethod()]
        public void UnReportComment()
        {
            string name = "Hodor";
            string eMail = "HOR@DOR";
            string bio = "I got turned simple by my time traveling master";
            string password = "432221";
            var author = new Author(name, eMail, bio, password);
            var admin = new Admin(name, eMail, bio, password, "signature");
            var post = new Post("this is a test post", "OOooo lookit dat body");
            string body = "so much testing";
            author.LogIn("432221");
            Comment comment = Poaster.CreateComment(author, post, body);
            Interact.ReportComment(author, author.CommentHistory[0], false);

            Assert.AreEqual(comment.IsReported, false);
        }
    }
}