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
        public string Signature {get; set;}
        public string Password { get; private set; }
        public int ID {get; set;}
        public bool IsLoggedIn { get; set; } = false;
        public List<Post> PostHistory { get; set; }
        public List<Comment> CommentHistory { get; set; }

        public Author(string name, string eMail, string bio, string password, string signature)
        {
            if(!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(eMail) 
                                           && !string.IsNullOrEmpty(bio) 
                                           && !string.IsNullOrEmpty(password)
                                           && !string.IsNullOrEmpty(signature))
            {
                Name = name;
                EMail = eMail;
                Bio = bio;
                Password = password;
                Signature = signature;
                CommentHistory = new List<Comment>();
                PostHistory = new List<Post>();
            }
            else{throw new ArgumentNullException("Yo your Author params are null fix em");} 
        }

        public bool LogIn(string password)
        {
            if (this.Password == password)
            {
                Console.WriteLine("You Logged in!");
                return this.IsLoggedIn = true;
            }
            Console.WriteLine("Wrong password or username");
            return this.IsLoggedIn = false;
        }
        
        public bool LogOut()
        {
            if(this.IsLoggedIn)
            {   
                Console.WriteLine("Logging out " + this.Name);
                return this.IsLoggedIn = false;
            }
        }
        
        public void CreatePost(string title, string body, string signature)
        {
            if(this.IsLoggedIn)
            {
                Post myPost = new Post(title, body, signature);
                this.PostHistory.Add(myPost);
                Blog.Posts.Add(myPost);
            }
        }
        
        public void CreatePost(string title, string body)
        {
            if(this.IsLoggedIn)
            {
                Post myPost = new Post(title, body);
                this.PostHistory.Add(myPost);
                Blog.Posts.Add(myPost);
            }
        }
        
        public void EditPost(Post post, string newBody)
        {
            post.Body = newBody;
            post.EditTime = DateTime.Now;
        }
        
        public void CreateComment(Post post, string body)
        {
            if(this.IsLoggedIn)
            {
                Comment myComment = new Comment(body);
                this.CommentHistory.Add(myComment);
                post.Comments.Add(myComment);
            }
        }
        
        public void CreateComment(Post post, string body, signature)
        {
            if(this.IsLoggedIn)
            {
                Comment myComment = new Comment(body, signature);
                this.CommentHistory.Add(myComment);
                post.Comments.Add(myComment);
            }
        }
        
        public void CreateComment(Comment comment, string body)
        {
            if(this.IsLoggedIn)
            {
                Comment myComment = new Comment(body);
                this.CommentHistory.Add(myComment);
                comment.CommentChain.Add(myComment);
            }
        }
        
        public void CreateComment(Comment comment, string body, signature)
        {
            if(this.IsLoggedIn)
            {
                Comment myComment = new Comment(body, signature);
                this.CommentHistory.Add(myComment);
                comment.CommentChain.Add(myComment);
            }
        }
        
        public void EditComment(Comment comment, string newBody)
        {
            comment.Body = newBody;
            comment.EditTime = DateTime.Now;
        }
    }
}
