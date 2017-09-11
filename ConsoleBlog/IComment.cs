using System;
using System.Collections.Generic;

namespace CodeSchoolBlog
{
    interface IComment
    {
        string Body { get; set; }
        string SignatureBlock { get; set; }
        int ID { get; set; }
        DateTime dateTime { get; set; }
        DateTime EditTime { get; set; }
        List<Comment> CommentChain { get; set; }
    }
}
