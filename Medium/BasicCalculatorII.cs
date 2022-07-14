using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoExpert.Medium
{
    public class BasicCalculatorII
    {
        public int Calculate(string s)
        {
            s = String.Concat(s.Where(c => !Char.IsWhiteSpace(c)));
            List<char> symbols = new List<char>();
            List<string> expression = new List<string>();
            symbols.Add('+');
            symbols.Add('-');
            symbols.Add('*');
            symbols.Add('/');

            if (1 <= s.Length && s.Length <= 3 * Math.Pow(10, 5))
            {             
                for (int i = 0; i < s.Length; i++)
                {
                    if (!symbols.Contains(s[i]))
                    {
                        expression.Add(s[i].ToString());
                    }
                    else
                    {
                        expression.Add("");
                    }
                }

                if (!expression.Any(el => string.IsNullOrWhiteSpace(el)))
                {
                    Int32 val = 0;
                    Int32.TryParse(s, out val);
                    return val;
                }

                for (int i = 0; i < expression.Count; i++)
                {
                    if (i + 1 == s.Length) break;
                    if (s[i] == '/')
                    {
                        int num1 = 0, num2 = 0;
                        Int32.TryParse(expression[i - 1].ToString(), out num1);
                        Int32.TryParse(expression[i + 1].ToString(), out num2);

                        if (num1 >= 0 && num2 >= 0) {
                            if (num1 == 0)
                            {
                                expression[i] = "0";
                                continue;
                            }

                            if (num2 == 0)
                            {
                                expression[i] = "0";
                                continue;
                            }

                            Int32 answer = num1 / num2;
                            expression.Insert(i - 1, answer.ToString());
                            expression.RemoveAt(i);
                            expression.RemoveAt(i + 1);
                        }
                    }
                }

                for (int i = 0; i<expression.Count; i++) {
                    if (i + 1 == s.Length) break;
                    if (s[i] == '*') {
                        int num1 = 0, num2 = 0;
                        Int32.TryParse(expression[i - 1].ToString(), out num1);
                        Int32.TryParse(expression[i + 1].ToString(), out num2);

                        if (num1 >= 0 && num2 >= 0)
                        {
                            if (num1 == 0)
                            {
                                expression[i] = "0";
                                continue;
                            }

                            if (num2 == 0)
                            {
                                expression[i] = "0";
                                continue;
                            }
                            Int32 answer = num1 * num2;
                            expression.Insert(i-1, answer.ToString());
                            expression.RemoveAt(i);
                            expression.RemoveAt(i+1);
                        }
                    }
                }

                for (int i = 0; i < expression.Count; i++)
                {
                    if (i + 1 == s.Length) break;
                    if (s[i] == '+')
                    {
                        int num1 = 0, num2 = 0;
                        Int32.TryParse(expression[i - 1].ToString(), out num1);
                        Int32.TryParse(expression[i + 1].ToString(), out num2);

                        if (num1 >= 0 && num2 >= 0)
                        {
                            Int32 answer = num1 + num2;
                            expression.Insert(i - 1, answer.ToString());
                            expression.RemoveAt(i);
                            expression.RemoveAt(i + 1);
                        }
                    }
                }

                for (int i = 0; i < expression.Count; i++)
                {
                    if (i + 1 == s.Length) break;
                    if (s[i] == '-')
                    {
                        int num1 = 0, num2 = 0;
                        Int32.TryParse(expression[i - 1].ToString(), out num1);
                        Int32.TryParse(expression[i + 1].ToString(), out num2);

                        if (num1 >= 0 && num2 >= 0)
                        {
                            Int32 answer = num1 - num2;
                            expression.Insert(i - 1, answer.ToString());
                            expression.RemoveAt(i);
                            expression.RemoveAt(i + 1);
                        }
                    }
                }
            }
            expression.RemoveAll(el => string.IsNullOrEmpty(el));
            Int32 total = 0;
            Int32.TryParse(expression[0], out total);
            
            return total;
        }
    }
}
