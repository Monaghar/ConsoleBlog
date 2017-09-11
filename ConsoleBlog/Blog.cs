using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSchoolBlog
{
    public static class Blog
    {
        public static Admin Owner = new Admin("Ryan", "Ryan.Monaghan@shiftwise.com", "total coding noob", "1234", "Hello World!");
        public static List<Post> Posts = new List<Post>();
        public static string Description = "Ryans first attempt at a blog";
        public static string Title = "Code School Blog"; 
    }
}