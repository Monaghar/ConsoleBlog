using System;

namespace CodeSchoolBlog
{
    interface IComment
    {
        string Body { get; set; }
        string SignatureBlock {get; set;}
        DateTime dateTime { get; set; }
        DateTime EditTime {get; set;}
        List<Comment> {get: set:}
    }
}
