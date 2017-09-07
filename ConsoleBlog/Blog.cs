using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSchoolBlog
{
    public static class Blog : IBlog
    {
        public static Author Owner { get; set; }
        public static List<Post> Posts { get; set; }

        public static string Description { get; set; }
        public static string Title { get; set; }

        public Blog(Author owner, string title, string description)
        {
            if (owner != null && !string.IsNullOrEmpty(title) && !string.IsNullOrEmpty(description))
            {
                Owner = owner;
                Title = title;
                Description = description;
            }
            else { throw new ArgumentNullException("Yo your Blog params are null fix em"); }
        }
    }
}
