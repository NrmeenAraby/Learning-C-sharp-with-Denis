using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oldSchool
{
    internal class BubbleSortAlgo
    {
        public static void BubbleSort(int[] arr)
        {
            int sz=arr.Length;
            bool swapped;

            for (int i = 0; i < sz - 1; i++)
            {
                swapped = false;
                for (int j = 0; j < sz - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int tmp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = tmp;
                        swapped = true;
                    }
                }
                if (!swapped)
                    break;
            }
        }
    }
}
