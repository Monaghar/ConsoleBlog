using System;
using System.Collections.Generic;

namespace CodeSchoolBlog
{
    interface IPost
    {
        List<Comment> Comments { get; set; }
        string Title { get; set; }
    }
}
