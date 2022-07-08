using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoExpert.Easy
{
    public class BubbleSort
    {
        // O(n) - Time
        // O(1) - Space
        public int[] Sort(int[] arr)
        {
            int x = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == arr.Length - (x + 1))
                {
                    x = 0;
                    continue;
                }

                int swap = 0;
                if (arr[i] > arr[arr.Length - (x + 1)])
                {
                    swap = arr[i];
                    arr[i] = arr[arr.Length - (x + 1)];
                    arr[arr.Length - (x + 1)] = swap;

                    x++;
                    i--;
                    continue;
                }
                else if (arr[i] <= arr[arr.Length - (x + 1)])
                {
                    x++;
                    i--;
                    continue;
                }
            }
            Console.WriteLine($"[{arr[0]}, {arr[1]}, {arr[2]}, {arr[3]}, {arr[4]}, {arr[5]}, {arr[6]}]", arr[0], arr[1], arr[2], arr[3], arr[4], arr[5], arr[6]);
            return arr;
        }
    }
}
