using System.Collections.Generic;

namespace CodeSchoolBlog
{
    interface IAuthor
    {
        string Name { get; set; }
        string EMail { get; set; }
        string Bio { get; set; }
        string Password { get; }
        string ID { get; set; }
        string Password { get; }
        bool IsLoggedIn { get; set; }
        List<Comment> MyComments { get; set; }
        List<Post> MyPosts { get; set; }
        
        void CreatePost(Author owner, string title, string body);
        void CreateComment(Author owner, Post post, string body);
        void CreateComment(Author owner, Comment comment, string body);
        bool LogIn(Author owner, string password);
        bool LogOut(Authoer owner);
    }
}
