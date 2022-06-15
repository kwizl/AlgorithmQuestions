using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgoExpert.Easy
{
    public class TwoNumberSum
    {
        // Use a HasTable or HashSet in order to avoid using nested loops. This improves the performance of the system but uses more space
        // Space Complexity - O(N)
        // Time Complexity - O(N)
        public string Sum(int[] arr, int total)
        {             
            HashSet<int> ht = new();            
            var sumarr = new int[] { };
            foreach (var num in arr)
            {
                int x = total - num;                
                if (ht.Count() == 0)
                {
                    ht.Add(num);
                    continue;
                }

                if (!ht.Contains(x) && (num * 2) != total)
                {
                    ht.Add(num);
                    continue;
                }
                else if (ht.Contains(x) && (num + x) == total)
                {
                    sumarr = new int[] { num, x };
                    Console.WriteLine($"[{num}, {x}]", num, x);
                    break;
                }
            }
            return sumarr.ToString();
        }
    }
}
