using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Questions
{
    internal class BinarySearch
    {
        public static int SearchElement(int[] arr, int n)
        {
            int index = -1;
            int start = 0;
            int end = arr.Length - 1;

            //How to decide should it be < or <=
            while(start <= end)  //{ 1, 2, 5, 6, 8, 9} 3, 5: 3, 3 
            {
                int mid = (start + end) / 2;
                if (arr[mid] == n )
                {
                    return mid;
                }
                else if (n > arr[mid])
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }
            }

            return index;
        }
    }
}
