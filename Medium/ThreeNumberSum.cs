using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoExpert.Medium
{
    public class ThreeNumberSum
    {
        //O(n) - Time
        //O(n) - Space
        public string Sum(int[] array, int target)
        {
            Array.Sort(array);
            List<List<int>> result = new List<List<int>>();

            int countLeft = 0;
            int countRight = 0;
            int move = 0;
            bool state = true;

            for (int i = 0; i < array.Length; i++)
            {
                if (i + 1 + countLeft < array.Length - (1 + countRight))
                {
                    move = array[i] + array[i + 1 + countLeft] + array[array.Length - (1 + countRight)];
                }
                else
                {
                    countLeft = 0;
                    countRight = 0;
                    continue;
                }

                if (move < target)
                {
                    countLeft++;
                    state = false;
                    i--;
                }

                if (move > target)
                {
                    countRight++;
                    state = true;
                    i--;
                }

                if (move == target)
                {
                    List<int> arr = new List<int>();
                    arr.Add(array[i]);
                    arr.Add(array[i + 1 + countLeft]);
                    arr.Add(array.Length - (1 + countRight));
                    result.Add(arr);

                    if (state == true)
                    {
                        countRight++;
                        i--;
                    }
                    else
                    {
                        countLeft++;
                        i--;
                    }
                }
            }
            Console.WriteLine($"[{result[0][0]}, {result[0][1]}, {result[0][2]}]", result[0][0], result[0][1], result[0][2]);
            Console.WriteLine($"[{result[1][0]}, {result[1][1]}, {result[1][2]}]", result[1][0], result[1][1], result[1][2]);
            Console.WriteLine($"[{result[2][0]}, {result[2][1]}, {result[2][2]}]", result[2][0], result[2][1], result[2][2]);
            return result.ToString();
        }
    }
}
