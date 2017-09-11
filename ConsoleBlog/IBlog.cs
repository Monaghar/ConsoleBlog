using System.Collections.Generic;

namespace CodeSchoolBlog
{
    interface IBlog
    {
        Admin Owner { get; set; }
        string Description { get; set; }
        string Title { get; set; }
        List<Post> Posts { get; set; }
    }
}