using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSchoolBlog
{
    public class Blog : IBlog
    {
        public Author Owner { get; set; }
        public List<Post> Posts { get; set; }

        public string Description { get; set; }
        public string Title { get; set; }

        public Blog(Author owner, string title, string description)
        {
            if (owner != null && title != null && description != null)
            {
                Owner = owner;
                Title = title;
                Description = description;
            }
            else { throw new ArgumentNullException("Yo your stuff is null fix it"); }
        }
    }
}
