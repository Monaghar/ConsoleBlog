using System;
using System.Collections.Generic;

namespace CodeSchoolBlog
{
    interface IPost : IComment
    {
        List<Comment> Comments { get; set; }
        string Title { get; set; }
    }
}