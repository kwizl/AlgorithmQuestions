using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoExpert.Medium
{
    public class SpiralTraverse
    {
        // O(n) - Space
        // O(n) - Time
        public List<int> SpiralArray(int[][] arr)
        {
            List<int> list = new List<int>();
            int startRow = 0;
            int endRow = arr.Length - 1;
            int startCol = 0;
            int endCol = arr[0].Length - 1;

            while (startRow <= endRow && startCol <= endCol)
            {
                foreach (int col in Enumerable.Range(startCol, endCol + 1))
                {
                    list.Add(arr[startRow][col]);
                }

                foreach (int row in Enumerable.Range(startRow + 1, endCol + 1))
                {
                    list.Add(arr[row][endCol]);
                }

                foreach (int col in Enumerable.Range(startCol, endCol).Reverse())
                {
                    list.Add(arr[endRow][col]);
                }

                foreach (int row in Enumerable.Range(startRow, endCol).Reverse())
                {
                    list.Add(arr[row][startCol]);
                }

                startRow++;
                endRow--;
                startCol++;
                endCol--;
            }

            return list;
        }
    }
}
