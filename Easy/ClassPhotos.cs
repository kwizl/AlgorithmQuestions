using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoExpert.Easy
{
    public class ClassPhotos
    {
        // O(nlogn) - Time
        // O(n) - Space
        public List<int[]> Height(int[] red, int[] blue)
        {
            if (red.Length != blue.Length) throw new Exception("Length or arrays must be equal");


            List<int[]> rows = new List<int[]>();

            Array.Sort(red);
            Array.Sort(blue);

            Array.Reverse(red);
            Array.Reverse(blue);

            int r = red[red.Length - 1];
            int b = blue[blue.Length - 1];

            if (r > b)
            {
                rows.Add(red);
                rows.Add(blue);
                return rows;
            }
            else if (r == b)
            {
                for (int i = red.Length - 1; i > 1; i--)
                {
                    if (red[i] == blue[i])
                    {
                        continue;
                    }
                    else if (red[i] > blue[i])
                    {
                        rows.Add(red);
                        rows.Add(blue);
                        return rows;
                    }
                    else
                    {
                        rows.Add(blue);
                        rows.Add(red);
                        return rows;
                    }
                }
            }
            else
            {
                rows.Add(blue);
                rows.Add(red);
                return rows;
            }
            return rows;
        }
    }
}
