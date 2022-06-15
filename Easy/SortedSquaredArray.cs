using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoExpert.Easy
{
    public class SortedSquaredArray
    {
        // Time O(N)
        // Space O(N)
        public int[] SquaredArray(int[] array)
        {
            int[] output = new int[array.Length];
            int start = 0;
            int end = array.Length - 1;
            int state = array.Length - 1;
            int count = 0;

            while (count < array.Length)
            {
                if (array[start] < 0 || array[end] < 0)
                {
                    array[start] = Math.Abs(array[start]);
                    array[end] = Math.Abs(array[end]);
                }

                if (array[start] * array[start] < array[end] * array[end])
                {
                    output[state] = array[end] * array[end];
                    end--;
                    state--;
                }

                if (array[start] * array[start] > array[end] * array[end])
                {
                    output[state] = array[start] * array[start];
                    start++;
                    state--;
                }
                count++;

                if (count == array.Length)
                {
                    output[state] = array[end] * array[end];
                }
            }
            return output;
        }
    }
}
