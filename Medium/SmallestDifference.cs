using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoExpert.Medium
{
    public class SmallestDifference
    {
        //O(nlogn) + O(MlogM) - Time
        //O(n) - Space
        public int[] Difference(int[] arr1, int[] arr2)
        {
            Array.Sort(arr1);
            Array.Sort(arr2);

            int[] diff = new int[2];
            int i2 = 0;

            if (arr1[arr1.Length - 1] > arr2[arr2.Length - 1])
            {
                int[] store = arr2;
                arr2 = arr1;
                arr1 = store;
            }

            List<List<int>> record = new List<List<int>>();

            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] == arr2[i2])
                {
                    diff[0] = arr1[i];
                    diff[1] = arr2[i2];
                    return diff;
                }

                if (arr1[i] > arr2[i2])
                {
                    List<int> arr = new List<int>();
                    arr.Add(arr1[i]);
                    arr.Add(arr2[i2]);
                    arr.Add(arr1[i] - arr2[i2]);
                    record.Add(arr);
                }
                else if (arr1[i] < arr2[i2])
                {
                    List<int> arr = new List<int>();
                    arr.Add(arr1[i]);
                    arr.Add(arr2[i2]);
                    arr.Add(arr2[i2]- arr1[i]);
                    record.Add(arr);
                }

                if (i > 1 && record.Count > 1 && record[record.Count - 1][2] >= record[record.Count - 2][2] 
                    && record[record.Count - 1][2] != record[record.Count - 2][2])
                {
                    int u = record[record.Count - 1][2];
                    int t = record[record.Count - 2][2];
                    record.RemoveAt(record.Count - 1);
                    if (arr1[i] < arr2[i2])
                    {
                        continue;
                    }
                    i-=2;
                    i2++;
                    continue;
                }
            }

            diff[0] = record[record.Count - 1][0];
            diff[1] = record[record.Count - 1][1];
            Console.WriteLine($"[{diff[0]}, {diff[1]}]", diff[0], diff[1]);
            return diff;
        }
    }
}
