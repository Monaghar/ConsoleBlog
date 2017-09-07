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
            DateTime testDateTime = DateTime.Now;

            var testComment = new Comment(testBody);

            Assert.AreEqual(testBody, testComment.Body);
        }
        
        [TestMethod()]
        public void CommentNullBodyTest()
        {
            string testBody = null;
            DateTime testDateTime = DateTime.Now;

            Assert.Throws<ArgumentNullException>(()=> new Comment(testBody));
        }
    }
}
