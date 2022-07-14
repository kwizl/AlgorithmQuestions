using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoExpert.Medium
{
    public class FirstDuplicate
    {
        // Space Complexity - O(N2)
        // Time Complexity - O(N)
        public int Duplicate(int[] arr)
        {
            int el = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 1; j < arr.Length; j++)
                {
                    if (i == j) continue;

                    if (arr[i] == arr[j])
                    {
                        el = arr[i];
                        return el;
                    }
                }
            }
            return -1;
        }

        // Space Complexity - O(N)
        // Time Complexity - O(N)
        public int DuplicateTwo(int[] arr)
        {
            int el = 0;
            HashSet<int> set = new HashSet<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (i != 0 && set.Contains(arr[i]))
                {
                    Console.WriteLine($"{arr[i].ToString()}", arr[i]);
                    return arr[i];
                }
                set.Add(arr[i]);
            }
            return -1;
        }
    }
}
