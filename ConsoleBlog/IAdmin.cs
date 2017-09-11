using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSchoolBlog
{
    interface IAdmin
    {
        List<Post> PostHistory { get; set; }
        void CreatePost(string title, string body);
        void EditPost(Post post, string newbody);
    }
}
