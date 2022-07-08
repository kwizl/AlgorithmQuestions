using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoExpert.Medium
{
    public class MonotonicArray
    {
        // O(n) - Time
        // O(1) - Space
        public bool Check(int[] arr)
        {
            bool state1 = true;
            bool state2 = true;
            bool state = true;

            for (int i = 0; i < arr.Length; i++)
            {
                if (i + 1 > arr.Length - 1) break;

                if (arr[i] >= arr[i + 1] && i == 0)
                {
                    state1 = true;
                    state2 = false;
                    continue;
                }

                if (arr[i] <= arr[i + 1] && i == 0)
                {
                    state1 = false;
                    state2 = true;
                    continue;
                }

                if (state1 && arr[i] < arr[i + 1])
                {
                    state = false;
                    break;
                }

                if (state1 && arr[i - 1] >= arr[i] && arr[i] >= arr[i + 1])
                {
                    state = state1;
                    continue;
                }

                if (state2 && arr[i] > arr[i+1])
                {
                    state = false;
                    break;
                }

                if (state2 && arr[i - 1] <= arr[i] && arr[i] <= arr[i+1])
                {
                    state = state2;
                    continue;
                }
            }
            Console.WriteLine($"{state.ToString()}", state);
            return state;
        }
    }
}
