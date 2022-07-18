using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoExpert.Easy
{
    public class FindThreeLargestNumber
    {
        public int[] ThreeLargest(int[] arr)
        {
            int[] three = { 0, 0, 0 };

            for (int i = 0; i < arr.Length; i++)
            {
                int swap = 0;
                if (arr[i] < three[0] && arr[i] < three[1] && arr[i] < three[2])
                {
                    continue;
                }
                else if (arr[i] > three[0] && arr[i] < three[1] && arr[i] < three[2])
                {
                    three[0] = arr[i];
                }
                else if (arr[i] > three[0] && arr[i] > three[1] && arr[i] < three[2])
                {
                    three[0] = three[1];
                    three[1] = arr[i];                    
                }
                else if (arr[i] > three[0] && arr[i] > three[1] && arr[i] > three[2])
                {
                    three[0] = three[1];
                    three[1] = three[2];
                    three[2] = arr[i];
                }
            }

            return three;
        }
    }
}
