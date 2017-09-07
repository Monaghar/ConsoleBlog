using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSchoolBlog
{
    public class Author : IAuthor
    {
        public string Name { get; set; }
        public string EMail { get; set; }
        public string Bio { get; set; }
        public List<Post> PostHistory { get; set; }
        public List<Comment> CommentHistory { get; set; }
        public String Password { get; private set; }
        public bool IsLoggedIn { get; set; }

        public Author(string name, string eMail, string bio, string password)
        {
            if(owner != null && title != null && body != null)
            {
                Name = name;
                EMail = eMail;
                Bio = bio;
                Password = password;
                CommentHistory = new List<Comment>();
                PostHistory = new List<Post>();
            }
            else{throw new ArgumentNullException("Yo your Author params are null fix em");} 
        }

        public bool LogIn(string password)
        {
            if (Password == password)
            {
                Console.WriteLine("You Logged in!");
                return IsLoggedIn = true;
            }
            Console.WriteLine("Wrong password or username");
            return IsLoggedIn = false;
        }
        
        public void CreatePost(Author owner, string title, string body)
        {
            if(owner.IsLoggedIn)
            {
                Post myPost = new Post(title, body);
                owner.PostHistory.Add(myPost);
            }
        }
        
        public void CreateComment(Author owner, Post post, string body)
        {
            if(owner.IsLoggedIn)
            {
                Comment myComment = new Comment(body);
                owner.CommentHistory.Add(myComment);
            }
        }
        
        public void CreateComment(Author owner, Comment comment, string body)
        {
            if(owner.IsLoggedIn)
            {
                Comment myComment = new Comment(body);
                owner.CommentHistory.Add(myComment);
                comment.CommentChain.Add(myComment);
            }
        }
    }
}
