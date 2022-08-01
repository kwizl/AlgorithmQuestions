using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoExpert.Easy
{
    public class ValidParenthesis
    {
        public bool IsValid(string s)
        {
            Stack<char> st = new Stack<char>();
            char[] cs = s.ToCharArray();

            for (int i = 0; i < cs.Length; i++)
            {
                char ch = s.ElementAt(i);

                if (ch == '(' || ch == '{' || ch == '[')
                {
                    st.Push(ch);
                }
                else
                {
                    if (st.Count == 0)
                    {
                        return false;
                    }
                    else if (matching(st.Peek(), ch) == false)
                    {
                        return false;
                    }
                    else
                    {
                        st.Pop();
                    }
                }
            }

            if (st.Count == 0)
                return true;
            else
                return false;
        }
        private bool matching(char a, char b)
        {
            return (a == '(' && b == ')' || a == '{' && b == '}' || a == '[' && b == ']');
        }
    }
}
