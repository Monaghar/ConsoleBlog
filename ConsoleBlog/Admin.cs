using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSchoolBlog
{
    public class Admin : Author, IAdmin
    {
        public List<Post> PostHistory { get; set; }

        public Admin(string name, string eMail, string bio, string password, string signature) : base(name, eMail, bio, password, signature)
        {
            PostHistory = new List<Post>();
        }
        public Admin()
        { }

    }
}
