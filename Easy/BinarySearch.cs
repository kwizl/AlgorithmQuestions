using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoExpert.Easy
{
    public class BinarySearch
    {
        public int Search(int[] arr, int num)
        {
            return SearchLogic(arr, 0, arr.Length - 1, num);
        }
        public int SearchLogic(int[] arr, int startIdx, int endIdx, int num)
        {
            int midIdx = (startIdx + endIdx) / 2;

            if (startIdx > endIdx)
            {
                return -1;
            }

            if (arr[midIdx] == num)
            {
                return num;
            }

            if (arr[midIdx] > num)
            {
                endIdx = midIdx - 1;
                return SearchLogic(arr, startIdx, endIdx, num);
            }

            if (arr[midIdx] < num)
            {
                startIdx = midIdx + 1;
                return SearchLogic(arr, startIdx, endIdx, num);
            }

            return num;
        }
    }
}
