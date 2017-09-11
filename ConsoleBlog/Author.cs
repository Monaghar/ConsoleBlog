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
        public string Signature { get; set; }
        public string Password { get; private set; }
        public int ID { get; set; }
        public bool IsLoggedIn { get; set; } = false;
       
        public List<Comment> CommentHistory { get; set; }

        public Author(string name, string eMail, string bio, string password, string signature)
        {
            if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(eMail)
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
            }
            else { throw new ArgumentNullException("Yo your Author params are null fix em"); }
        }

        public Author(string name, string eMail, string bio, string password)
        {
            if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(eMail)
                                           && !string.IsNullOrEmpty(bio)
                                           && !string.IsNullOrEmpty(password))
            {
                Name = name;
                EMail = eMail;
                Bio = bio;
                Password = password;
                CommentHistory = new List<Comment>();
            }
            else { throw new ArgumentNullException("Yo your Author params are null fix em"); }
        }
        
         public Author(string name, string eMail, string password)
        {
            if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(eMail)
                                           && !string.IsNullOrEmpty(password))
            {
                Name = name;
                EMail = eMail;
                Password = password;
                CommentHistory = new List<Comment>();
            }
            else { throw new ArgumentNullException("Yo your Author params are null fix em"); }
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
            if (this.IsLoggedIn)
            {
                Console.WriteLine("Logging out " + this.Name);
            }
            return this.IsLoggedIn = false;
        }

        public void CreateComment(Comment comment, string body)
        {
            if (this.IsLoggedIn)
            {
                Comment myComment = new Comment(body);
                this.CommentHistory.Add(myComment);
                comment.CommentChain.Add(myComment);
                if (!string.IsNullOrEmpty(this.Signature))
                {
                    myComment.SignatureBlock = this.Signature;
                }
            }
        }
        
        public void CreateComment(Comment comment, string body, string quote)
        {
            if (this.IsLoggedIn)
            {
                Comment myComment = new Comment(body);
                myComment.Body = string.Quotes(quote) + myComment.Body;
                this.CommentHistory.Add(myComment);
                comment.CommentChain.Add(myComment);
                if (!string.IsNullOrEmpty(this.Signature))
                {
                    myComment.SignatureBlock = this.Signature;
                }
            }
        }

        public void CreateComment(Post post, string body)
        {
            if (this.IsLoggedIn)
            {
                Comment myComment = new Comment(body);
                this.CommentHistory.Add(myComment);
                post.CommentChain.Add(myComment);
                if (!string.IsNullOrEmpty(this.Signature))
                {
                    myComment.SignatureBlock = this.Signature;
                }
            }
        }
        
        public void CreateComment(Post post, string body, string quote)
        {
            if (this.IsLoggedIn)
            {
                Comment myComment = new Comment(body);
                myComment.Body = string.Quotes(quote) + myComment.Body;
                this.CommentHistory.Add(myComment);
                post.CommentChain.Add(myComment);
                if (!string.IsNullOrEmpty(this.Signature))
                {
                    myComment.SignatureBlock = this.Signature;
                }
            }
        }

        public void EditComment(Comment comment, string newBody)
        {
            if (this.CommentHistory.Contains(comment))
            {
                comment.Body = newBody;
                comment.EditTime = DateTime.Now;
            }
        }
        
        public static string Quotes(this string quote)
        {
            return quote = "\"" + quote + "\" ";
        }
    }
}
