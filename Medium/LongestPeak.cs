using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoExpert.Medium
{
    public class LongestPeak
    {
        // Longest Peak in an array
        // O(n^2) - Time
        // O(1) - Space
        public int Peak(int[] arr)
        {
            List<int> peak = new();
            List<int> seq = new();
            int count = 0;

            // Find all peaks
            for (int i = 1; i < arr.Length; i++)
            {
                if (i+1 == arr.Length) break;

                if (arr[i-1] < arr[i] && arr[i] > arr[i+1])
                {
                    peak.Add(i);                    
                    continue;
                }                
            }

            // Compare peaks
            for (int i = 0; i < peak.Count; i++)
            {
                // Compare to the left side of peak
                for (int j = 0; j < arr.Length; j++)
                {
                    if (peak[i] - j == 0) break;

                    if (arr[peak[i] - j + 1] < arr[peak[i] - j])
                    {
                        count++;
                    }
                }

                // Compare to the right side of peak
                for (int j = 0; j < arr.Length; j++)
                {
                    if (peak[i] + j + 1 == arr.Length) break;

                    if (arr[peak[i] + j] > arr[peak[i] + j + 1])
                    {
                        count++;
                    }
                }

                seq.Add(count);
                count = 0;
            }

            return seq.Max();
        }

        // O(n) - Time
        // O(1) - Space
        public int AlgoPeak(int[] arr)
        {
            int peak = 0;
            int i = 1;

            while (i < arr.Length - 1)
            {
                bool state = arr[i - 1] < arr[i] && arr[i] > arr[i + 1];
                if (!state)
                {
                    i++;
                    continue;
                }

                int leftIdx = i - 2;
                while (leftIdx >= 0 && arr[leftIdx] < arr[leftIdx + 1])
                {
                    leftIdx -= 1;
                }

                int rightIdx = i + 2;
                while (rightIdx < arr.Length && arr[rightIdx] < arr[rightIdx - 1])
                {
                    rightIdx += 1;
                }

                int currentpeak = rightIdx - leftIdx - 1;

                if (currentpeak > peak)
                {
                    peak = currentpeak;
                }

                i = rightIdx;
            }
            Console.WriteLine($"{peak}", peak);
            return peak;
        }
    }
}
