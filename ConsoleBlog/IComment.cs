using System;

namespace CodeSchoolBlog
{
    interface IComment : IOwner
    {
        string Body { get; set; }
        string SignatureBlock {get; set;}
        DateTime dateTime { get; set; }
        List<Comment> {get: set:}
    }
}
