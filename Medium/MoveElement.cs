using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoExpert.Medium
{
    public class MoveElement
    {
        //O(n) - Time
        //O(n) - Space
        public int[] ToEnd(int[] arr, int target)
        {
            Array.Sort(arr);
            int swap = 0;
            int len = arr.Length - 1;
            int idx = 0;

            if (!arr.Contains(target))
            {
                throw new Exception("The array does not contain the target!");
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != target) continue;

                if (i == len - (idx + 1)) break;

                if (arr[i] == target && arr[i] == arr[len - idx])
                {
                    i--;
                    idx++;
                    continue;
                }
                else
                {
                    swap = arr[i];
                    arr[i] = arr[len - idx];
                    arr[len - idx] = swap;
                    idx++;
                }
            }
            Console.WriteLine($"[{arr[0]}, {arr[1]}, {arr[2]}, {arr[3]}, {arr[4]}, {arr[5]}, {arr[6]}, {arr[7]}]", arr[0], arr[1], arr[2], arr[3], arr[4], arr[5], arr[6], arr[7]);
            return arr;
        }
    }
}
