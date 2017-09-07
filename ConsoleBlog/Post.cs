using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSchoolBlog
{
    public class Post : IPost, IComment
    {
        public Author Owner { get; set; }
        public string Body { get; set; }
        public DateTime dateTime { get; set; }
        public List<Comment> Comments { get; set; }
        public string Title { get; set; }

        public Post(Author owner, string title, string body)
        {
             if(owner != null && title != null && body != null)
            {
                Title = title;
                Body = body;
                this.dateTime = DateTime.Now;
                owner.MyPosts.Add(this);
                Comments = new List<Comment>();
            }
            else {throw new ArgumentNullException("Yo your Post params are null fix em");} 
        }
    }
}
