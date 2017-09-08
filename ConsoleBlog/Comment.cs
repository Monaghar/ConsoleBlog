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
        public string SignatureBlock {get; set;}
        public DateTime dateTime { get; set; }
        public List<Comment> CommentChain {get; set;}

        public Comment() { }

        public Comment(string body)
        {
            if(!string.IsNullOrEmpty(body))
            {
                Body = body;
                this.dateTime = DateTime.Now;
                CommentChain = new List<Comment>();
            }
            else{throw new ArgumentNullException("Yo your Comment params are null fix em");}
        }
    }
}
