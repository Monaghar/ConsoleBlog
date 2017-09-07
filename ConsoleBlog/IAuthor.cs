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
        List<Comment> CommentHistory { get; set; }
        List<Post> PostHistory { get; set; }
        
        void CreatePost(string title, string body);
        void CreateComment(Post post, string body);
        void CreateComment(Comment comment, string body);
        bool LogIn(string password);
        bool LogOut();
    }
}
