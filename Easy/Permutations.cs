using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoExpert.Easy
{
    public class Permutations
    {
        public bool Check(string strOne, string strTwo)
        {
            bool check = true;

            for (int i = 0; i < strOne.Length; i++)
            {
                if (strTwo.Contains(strOne[i]))
                {
                    check = true;
                }
                else
                {
                    check = false;
                    break;
                }
            }

            return check;
        }
    }
}
