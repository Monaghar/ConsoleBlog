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
        
        [TestMethod()]
        public void CommentNullBodyTest()
        {
            string testBody = null;
            Author testAuthor = new Author("Geoff", "Geoff@.Com", "total noob", "12334");
            Post testPost = new Post(testAuthor, "How to write posts", "just do it");
            DateTime testDateTime = DateTime.Now;

            Comment testComment;
            
            try
            {
                testComment = new Comment(testBody, testAuthor, testPost);
                Assert.IsNull(testComment.Body);
            }
            catch(ArgumentNullException)
            {
                Console.WriteLine("Comment body test null passed");
            }
        }
        
        [TestMethod()]
        public void CommentNullAuthorTest()
        {
            string testBody = "you make good posts";
            Author testAuthor = null;
            Post testPost = new Post(testAuthor, "How to write posts", "just do it");
            DateTime testDateTime = DateTime.Now;

            Comment testComment;
            
            try
            {
                testComment = new Comment(testBody, testAuthor, testPost);
                Assert.IsNull(testComment.Author);
            }
            catch(ArgumentNullException)
            {
                Console.WriteLine("Comment Author test null passed");
            }
        }
        
        [TestMethod()]
        public void CommentNullPostTest()
        {
            string testBody = "you make good posts";
            Author testAuthor = new Author("Geoff", "Geoff@.Com", "total noob", "12334");
            Post testPost = null;
            DateTime testDateTime = DateTime.Now;

            Comment testComment;
            
            try
            {
                testComment = new Comment(testBody, testAuthor, testPost);
                Assert.IsNull(testComment.Post);
            }
            catch(ArgumentNullException)
            {
                Console.WriteLine("Comment Post test null passed");
            }
        }
    }
}
