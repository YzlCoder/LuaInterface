using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLibrary
{
    public static class Algorithm
    {
        public static void Sort(int[] arr)
        {
            int nSize = arr.Length;
            for (int i = 0; i < nSize; i++)
            {
                for (int j = 0; j < nSize - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int step = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = step;
                    }
                }
            }
        }

        public static int Add(int a,int b)
        {
            return a + b;
        }
    }
}
