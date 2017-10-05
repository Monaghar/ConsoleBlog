using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSchoolBlog
{
    public class Admin : Author, IAdmin
    {
        public List<Post> PostHistory { get; set; }

        public Admin(string name, string eMail, string bio, string password, string signature) : base(name, eMail, bio, password, signature)
        {
            PostHistory = new List<Post>();
        }
        public Admin()
        { }

            public void CreatePost(string title, string body)
        {
            if (this.IsLoggedIn)
            {
                Post myPost = new Post(title, body, this.Signature);
                this.PostHistory.Add(myPost);
                Blog.Posts.Add(myPost);
            }
        }
            //admins can edit eachother's posts
        public void EditPost(Post post, string newBody)
        {
            post.Body = newBody;
            post.EditTime = DateTime.Now;
        }

    }
}
