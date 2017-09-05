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
        public List<Post> MyPosts { get; set; }
        public List<Comment> MyComments { get; set; }
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
                MyComments = new List<Comment>();
                MyPosts = new List<Post>();
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
    }
}
