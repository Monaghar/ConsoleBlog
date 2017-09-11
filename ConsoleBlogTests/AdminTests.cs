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
    public class AdminTests
    {
        [TestMethod()]
        public void CreatePostTest()
        {
            string name = "Hodor";
            string eMail = "HOR@DOR";
            string bio = "I got turned simple by my time traveling master";
            string password = "432221";
            string signature = "Door!!";

            var admin = new Admin(name, eMail, bio, password, signature);

            string title = "this is a test post";
            string body = "so much testing";

            admin.LogIn("432221");
            Blog.Posts = new List<Post>();
            admin.CreatePost(title, body);

            Assert.IsNotNull(Blog.Posts[0]);
            Assert.IsNotNull(admin.PostHistory[0]);
        }

        [TestMethod()]
        public void CreateCommentUnderPostTest()
        {
            string name = "Hodor";
            string eMail = "HOR@DOR";
            string bio = "I got turned simple by my time traveling master";
            string password = "432221";
            string signature = "Door!!";

            var admin = new Admin(name, eMail, bio, password, signature);
            string body = "so much testing";
            string title = "test title";
            string body2 = "Gee a lot of testing indeed";

            var post = new Post(title, body);
            admin.LogIn("432221");

            admin.CreateComment(post, body2);

            Assert.IsNotNull(admin.CommentHistory[0]);
            Assert.IsNotNull(post.CommentChain[0]);
        }

        [TestMethod()]
        public void EditPostTest()
        {
            string testTitle = "my test title";
            string testBody = "alot of great info";

            var testPost = new Post(testTitle, testBody);

            string newBody = "edited text";

            testPost.Body = newBody;

            Assert.AreEqual(testPost.Body, newBody);
        }
    }
}