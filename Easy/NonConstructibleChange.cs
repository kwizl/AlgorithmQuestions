using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoExpert.Easy
{
    public class NonConstructibleChange
    {
        // Use a HasTable or HashSet in order to avoid using nested loops. This improves the performance of the system but uses more space
        // Space Complexity - O(NlogN)
        // Time Complexity - O(N)
        public int Change()
        {
            int[] array = new int[] { 5, 7, 1, 1, 2, 3, 22 };
            Array.Sort(array);
            Dictionary<int, int> set = new Dictionary<int, int>();
            int change = 0;
            int arrayCount = 0;
            int i = 0;
            int sum = 0;
            int val = array[0];


            while (i < array[array.Length - 1])
            {
                set.Add(i, val);

                if (array[arrayCount] == array[arrayCount + 1])
                {
                    arrayCount++;
                    change = set[i];
                    sum += set[i] * 2;
                    val += 1;
                    i++;
                    continue;
                }

                if (array.Contains(set[i]))
                {
                    arrayCount++;
                    change = set[i];
                    sum += set[i];
                    val += 1;
                    i++;
                    continue;
                }

                if (!array.Contains(set[i]) && sum + 1 > array[arrayCount + 1])
                {
                    change = set[i];
                    val += 1;
                }

                if (!array.Contains(set[i]) && sum + 1 < array[arrayCount + 1])
                {
                    change = sum + 1;
                    break;
                }
                i++;
            }

            return change;
        }

        // Space = O(NlogN)
        // Time = O(1)
        public int ChangeAlgoExpert()
        {
            int[] array = new int[] { 5, 7, 1, 1, 2, 3, 22 };
            Array.Sort(array);
            int change = 0;
            int currentChangeCreated = 0;

            foreach (var coin in array)
            {
                if (coin > currentChangeCreated + 1)
                {
                    change = currentChangeCreated + 1;
                    Console.WriteLine($"{change.ToString()}", change.ToString());
                    return change;
                }

                currentChangeCreated += coin;
            }

            change = currentChangeCreated + 1;
            Console.WriteLine($"{change.ToString()}", change.ToString());

            return currentChangeCreated + 1;
        }
    }
}
