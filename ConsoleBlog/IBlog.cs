using System.Collections.Generic;

namespace CodeSchoolBlog
{
    interface IBlog : IOwner
    {
        string Description { get; set; }
        string Title { get; set; }
        List<Post> Posts { get; set; }
    }
}