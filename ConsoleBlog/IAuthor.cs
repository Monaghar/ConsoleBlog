using System.Collections.Generic;

namespace CodeSchoolBlog
{
    interface IAuthor
    {
        string Name { get; set; }
        string EMail { get; set; }
        string Bio { get; set; }
        string Password { get; }
        int ID { get; set; }
        string Signature { get; set; }
        bool IsLoggedIn { get; set; }
        List<Comment> CommentHistory { get; set; }
        void CreateComment(Comment comment, string body);
        bool LogIn(string password);
        bool LogOut();
    }
}