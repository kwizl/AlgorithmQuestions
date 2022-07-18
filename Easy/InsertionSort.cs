using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoExpert.Easy
{
    public class InsertionSort
    {

        public int[] Sort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int j = i;
                while (j > 0 && arr[j] < arr[j - 1])
                {
                    int swap = arr[j];
                    arr[j] = arr[j - 1];
                    arr[j - 1] = swap;
                    j -= 1;
                }
            }
            return arr;
        }
    }
}
