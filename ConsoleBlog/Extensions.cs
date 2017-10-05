using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class Extensions
    {
        public static string Quotes(this String quote)
        {
            return quote = "\"" + quote + "\" ";
        }
    }
}
