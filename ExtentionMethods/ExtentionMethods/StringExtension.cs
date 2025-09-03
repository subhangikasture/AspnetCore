using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtentionMethods
{
    public static class StringExtension
    {
        public static string ReverseString(this string name)
        {
            char[] str = name.ToCharArray();
            Array.Reverse(str);
            return new string(str);
        }
    }
}
