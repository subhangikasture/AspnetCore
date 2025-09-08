using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Questions
{
    internal class _2DSpiralMove
    {
        public static List<int> SpiralMove_2DMatrix(int[,] arr)
        {
            List<int> list = new List<int>();
            int n = arr.GetLength(0);
            int m = arr.GetLength(1);

            int rowBegin = 0;
            int rowEnd = n - 1;

            int colBegin = 0;
            int colEnd = m - 1;

            while(rowBegin <= rowEnd && colBegin <= colEnd)
            {
                for(int j = colBegin; j <= colEnd; j++)
                {
                    list.Add(arr[rowBegin, j]);
                }
                rowBegin++;

                for(int i = rowBegin; i <= rowEnd; i++)
                {
                    list.Add(arr[i , colEnd]);
                }
                colEnd--;

                if (rowBegin < rowEnd)
                {
                    for (int j = colEnd; j >= colBegin; j--)
                    {
                        list.Add(arr[rowEnd, j]);
                    }
                    rowEnd--;
                }

                if (colBegin < colEnd)
                {
                    for (int i = rowEnd; i >= rowBegin; i--)
                    {
                        list.Add(arr[i, colBegin]);
                    }
                    colBegin++;
                }

            }    

            return list;
        }
    }
}
