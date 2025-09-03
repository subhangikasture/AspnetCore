using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Questions
{
    internal class PrintDuplicateElements
    {
        public static void printDuplicateElements(string s)
        {
            string _s = s.ToLower();
            int[] arr = new int[26];
            for(int i = 0; i < s.Length; i++)
            {
                arr[_s[i] - 'a']++;
                if (arr[_s[i] - 'a'] > 1)
                {
                    Console.WriteLine(_s[i]);
                }
            }
        }
    }
}
