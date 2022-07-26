using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoExpert.Medium
{
    public class OverlappingIntervals
    {
        public int[][] Merge(int[][] intervals)
        {
            if (intervals.Length <= 1)
            {
                return intervals;
            }

            List<int[]> output_dir = new();
            int[] current_interval = intervals[0];
            int i = 0;
            foreach (int[] item in intervals)
            {
                i++;
                int current_begin = current_interval[0];
                int current_end = current_interval[1];
                int next_begin = item[0];
                int next_end = item[1];

                if (current_end >= next_begin)
                {
                    current_interval[1] = Math.Max(current_end, next_end);
                }
                else
                {
                    output_dir.Add(current_interval);
                    current_interval = item;
                    if (i == intervals.Length)
                    {
                        output_dir.Add(current_interval);
                    }
                }
            }

            return output_dir.ToArray();
        }
    }
}
