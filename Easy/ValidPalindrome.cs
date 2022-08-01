using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoExpert.Easy
{
    public class ValidPalindrome
    {
        public bool IsPalindrome(string s)
        {
            string fixed_string = "";

            foreach (char c in s.ToCharArray())
            {
                if (Char.IsDigit(c) || Char.IsLetter(c))
                {
                    fixed_string += c;
                }
            }

            fixed_string = fixed_string.ToLower();

            int a_pointer = 0;
            int b_pointer = fixed_string.ToCharArray().Length - 1;

            while (a_pointer <= b_pointer)
            {
                if (fixed_string.ElementAt(a_pointer) != fixed_string.ElementAt(b_pointer))
                {
                    return false;
                }

                a_pointer += 1;
                b_pointer -= 1;
            }

            return true;
    }
    }
}
