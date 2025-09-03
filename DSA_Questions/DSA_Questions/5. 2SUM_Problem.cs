using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Questions
{
    internal class _2SUM_Problem
    {
        internal static void Two_Sum(int[] arr, int target)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)  //2, 8, 7, 4, 5     10
            {
                int val = target - arr[i];

                if (dict.ContainsKey(val))
                {
                    Console.WriteLine(i + ", " + dict[val]);
                    return;
                }
                else
                {
                    if (!dict.ContainsKey(arr[i]))
                    {
                        dict.Add(arr[i], i);
                    }
                }
            }

            Console.WriteLine("Oop's! Pair doesn't exists.");
        }
    }
}
