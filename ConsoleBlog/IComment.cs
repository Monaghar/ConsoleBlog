using System;
using System.Collections.Generic;

namespace CodeSchoolBlog
{
    interface IComment
    {
        int ID { get; set; }
        int Rating { get; set; }
        string Body { get; set; }
        string SignatureBlock { get; set; }
        DateTime dateTime { get; set; }
        DateTime EditTime { get; set; }
        List<Comment> CommentChain { get; set; }
    }
}
