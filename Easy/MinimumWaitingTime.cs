using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoExpert.Easy
{
    public class MinimumWaitingTime
    {
        // O(nlog n) - Time
        //O(1) - Space
        public int Time(int[] array)
        {
            int sum = 0;
            int time = 0;

            // Sort array
            Array.Sort(array);

            // Loop through array
            for (int i = 0; i < array.Length; i++)
            {
                // If item is first in array add 0 to time
                if (i == 0)
                {
                    sum = 0;
                    continue;
                }
                
                // Compound time with the previous array
                sum = sum + array[i - 1];
                time += sum;
            }
            Console.WriteLine($"{time}", time);
            return time;
        }
    }
}
