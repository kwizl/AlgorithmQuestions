using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoExpert.Easy
{
    public class TandemBicycle
    {
        // O(nlogn) - Time
        // O(1) - Space
        public int CumulativeSpeed(int[] red, int[] blue, bool fastest)
        {
            if (red.Length != blue.Length || (red.Length == 0 || blue.Length == 0))
                throw new Exception("Invalid red and blue array length don't match or empty array.");

            int speed = 0;
            
            Array.Sort(red);
            Array.Sort(blue);

            if (fastest == true)
            {
                if (red[red.Length - 1] > blue[blue.Length - 1])
                {
                    Array.Reverse(red);
                }
                else if (red[red.Length - 1] < blue[blue.Length - 1])
                {
                    Array.Reverse(blue);
                }

                for (int i = 0; i < red.Length; i++)
                {
                    if (red[i] > blue[i])
                    {
                        speed += red[i];
                    }
                    if (red[i] < blue[i])
                    {
                        speed += blue[i];
                    }
                    if (red[i] == blue[i])
                    {
                        speed += red[i];
                    }
                }
                return speed;
            }
            else
            {
                for (int i = 0; i < red.Length; i++)
                {
                    if (red[i] > blue[i])
                    {
                        speed += red[i];
                    }
                    if (red[i] < blue[i])
                    {
                        speed += blue[i];
                    }
                    if (red[i] == blue[i])
                    {
                        speed += red[i];
                    }
                }
                return speed;
            }
        }
    }
}
