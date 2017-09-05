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
    public class CommentTests
    {
        [TestMethod()]
        public void CommentTest()
        {
            string testBody = "you make good posts";
            Author testAuthor = new Author("Geoff", "Geoff@.Com", "total noob", "12334");
            Post testPost = new Post(testAuthor, "How to write posts", "just do it");
            DateTime testDateTime = DateTime.Now;

            var testComment = new Comment(testBody, testAuthor, testPost);

            Assert.AreEqual(testBody, testComment.Body);
            Assert.AreEqual(testAuthor, testComment.Owner);
            // Assert.AreEqual(testPost, testComment.Post);

        }
    }
}
    //[TestMethod()]
    //public void CommentTest1()
    //{
    //    Assert.Fail();
    //}

