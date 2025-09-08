using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Questions
{
    internal class Sum2DElementsExcludingDiagonal
    {
        public static int GetSum(int[][] arr)
        {
            int sum = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                for(int j = 0; j < arr[0].Length; j++)
                {
                    if(i == j || j == arr.Length - 1 - i)
                    {
                        continue;
                    }
                    sum += arr[i][j];
                }
            }


            return sum;
        }
    }
}
