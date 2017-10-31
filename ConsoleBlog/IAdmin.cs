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
    }
}
