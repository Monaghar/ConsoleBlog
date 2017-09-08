using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSchoolBlog
{
    public class Post : IPost, IComment
    {
        public string Body { get; set; }
        public string SingatureBlock {get; set;}
        public DateTime dateTime { get; set; }
        public List<Comment> Comments { get; set; }
        public string Title { get; set; }

        public Post(string title, string body, string signature)
        {
             if(!string.IsNullOrEmpty(title) && !string.IsNullOrEmpty(body) && !string.IsNullOrEmpty(signature))
            {
                Title = title;
                Body = body;
                SignatureBlock = signature;
                this.dateTime = DateTime.Now;
                Comments = new List<Comment>();
            }
            else {throw new ArgumentNullException("Yo your Post params are null fix em");} 
        }
        
        public Post(string title, string body)
        {
             if(!string.IsNullOrEmpty(title) && !string.IsNullOrEmpty(body))
            {
                Title = title;
                Body = body;
                this.dateTime = DateTime.Now;
                Comments = new List<Comment>();
            }
            else {throw new ArgumentNullException("Yo your Post params are null fix em");} 
        }
    }
}
