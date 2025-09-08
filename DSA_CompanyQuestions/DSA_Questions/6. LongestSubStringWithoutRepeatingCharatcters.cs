using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Questions
{
    internal class LongestSubStringWithoutRepeatingCharatcters
    {
        public static int LengthOfLongestSubStringWithoutRepeatingCHaracters(string str)
        {
            int maxLength = 1;
            Dictionary<char, int> dict = new Dictionary<char, int>();
            int i = 0;
            int j = 0;
            while(j < str.Length)
            {
                if (dict.ContainsKey(str[j]))
                {
                    while (str[i] != str[j])
                    {
                        dict.Remove(str[i]);
                        i++;
                    }
                    i++;
                }
                else
                {
                    dict.Add(str[j], 1);
                }
                maxLength = Math.Max(maxLength, j - i + 1);
                j++;
            }
            return maxLength;
            
        }
    }
}
