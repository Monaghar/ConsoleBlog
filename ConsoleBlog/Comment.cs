using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSchoolBlog
{
    public class Comment : IComment
    {
        public string Body { get; set; }
        public DateTime dateTime { get; set; }
        //public Author Owner { get; set; }
        public List<Comment> {get; set;}

        public Comment() { }

        public Comment(string body)
        {
            if(body != null)
            {
                Body = body;
                this.dateTime = DateTime.Now;
                //Owner = owner;
                //owner.MyComments.Add(this);
                //post.Comments.Add(this);
            }
            else{throw new ArgumentNullException("Yo your Comment params are null fix em");}
        }
    }
}
