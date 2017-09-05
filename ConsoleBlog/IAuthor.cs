using System.Collections.Generic;

namespace CodeSchoolBlog
{
    interface IAuthor
    {
        string Bio { get; set; }
        string EMail { get; set; }
        bool IsLoggedIn { get; set; }
        List<Comment> MyComments { get; set; }
        List<Post> MyPosts { get; set; }
        string Name { get; set; }
        string Password { get; }

        bool LogIn(string password);
    }
}