using System;

namespace CodeSchoolBlog
{
    interface IComment : IOwner
    {
        string Body { get; set; }
        DateTime dateTime { get; set; }
    }
}