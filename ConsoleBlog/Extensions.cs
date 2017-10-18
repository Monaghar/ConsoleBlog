using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSchoolBlog
{
    public static class Extensions
    {
        public static string Quotes(this string quote)
        {
            string qoote ="\"" + quote + "\" ";
            return qoote;
        }
    }
}