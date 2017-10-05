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
        bool LogIn(string password);
        bool LogOut();
        List<Comment> CommentHistory { get; set; }
        void CreateComment(Comment comment, string body);
        //void CreateComment(Comment comment, string body, string quote);
        void CreateComment(Post post, string body);
        //void CreateComment(Post post, string body, string quote);
        void RateComment(Comment comment, bool rate);
        void EditComment(Comment comment, string newBody);
        void ReportComment(Comment comment, bool reported);
    }
}
