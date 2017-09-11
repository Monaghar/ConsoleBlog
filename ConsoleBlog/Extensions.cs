using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSchoolBlog
{
    class Extensions
    {
        public static string Quotes(this string quote)
            {
                return quote = "\"" + quote + "\" ";
            }
    }
}
