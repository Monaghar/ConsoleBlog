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
    public class PoasterTests
    {
        [TestMethod()]
        public void CreateCommentUnderPostTest()
        {
            string name = "Hodor";
            string eMail = "HOR@DOR";
            string bio = "I got turned simple by my time traveling master";
            string password = "432221";

            var author = new Author(name, eMail, bio, password);
            var post = new Post("this is a test post", "OOooo lookit dat body");
            string body = "so much testing";

            author.LogIn("432221");
            Poaster.CreateComment(author, post, body);

            Assert.IsNotNull(author.CommentHistory[0]);
            Assert.IsNotNull(post.CommentChain[0]);
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
            Poaster.CreateComment(author, comment, body);

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
        //    Poaster.CreateComment(author, comment, body, quote);

        //    Assert.AreEqual(comment.Body, "\"look at my quote!\" so much testing");
        //}


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
        //    Poaster.CreateComment(author, post, body, quote);

        //    Assert.AreEqual(comment.Body, "\"look at my quote!\" so much testing");
        //}
    }
}