using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoExpert.Easy
{
    public class Anagram
    {
        public bool IsAnagram(string s, string t)
        {
            string[] arr_s = s.Where(c => Char.IsLetter(c)).Select(c => c.ToString()).ToArray();
            string[] arr_t = t.Where(c => Char.IsLetter(c)).Select(c => c.ToString()).ToArray();

            Array.Sort(arr_s, StringComparer.InvariantCulture);
            Array.Sort(arr_t, StringComparer.InvariantCulture);

            s = string.Join("", arr_s);
            t = string.Join("", arr_t);

            if (s == t)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
