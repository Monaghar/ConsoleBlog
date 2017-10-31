using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;

namespace CodeSchoolBlog
{
    public class Post : IPost, IComment
    {
        public string Body { get; set; }
        public string SignatureBlock { get; set; }
        public int ID { get; set; }
        public DateTime dateTime { get; set; }
        public DateTime EditTime { get; set; }
        public List<Comment> CommentChain{ get; set; }
        public string Title { get; set; }
        public int Rating { get; set; }
        public bool IsReported { get; set; }


        public Post(string title, string body)
        {
            if (Verify.VerifyPost(title, body))
            {
                Title = title;
                Body = body;
                dateTime = DateTime.Now;
                CommentChain = new List<Comment>();
            }
            else { throw new ArgumentNullException("Yo your Post params are null fix em"); }
        }
    }
}