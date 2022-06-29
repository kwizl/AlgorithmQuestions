using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoExpert.Easy
{
    public class Fibonacci
    {
        private List<int> memo { get; set; }
        private int sum1 = 0;
        private int sum2 = 0;
        private int sum3 = 0;

        // Use memoization to speed up the data structure
        // 0(n) - Time
        // 0(n) - Space
        public int Fib(int nth)
        {
            if (nth <= 0)
            {
                return 0;
            }
            else if (nth == 1)
            {
                return 1;
            }
            else if (memo[nth] == 0)
            {
                memo[nth] = Fib(nth - 1) + Fib(nth - 2);
            }
            return memo[nth];
        }

        // 0(n) - Time
        // 0(1) - Space
        public int FibAlgoExpert(int n)
        {
            int[] lastTwo = { 0, 1 };
            int counter = 3;

            while (counter < n)
            {
                int nextFib = lastTwo[0] + lastTwo[1];
                lastTwo[0] = lastTwo[1];
                lastTwo[1] = nextFib;
                counter++;
            }

            if (n > 1)
            {
                return lastTwo[1];
            }
            else
            {
                return lastTwo[0];
            }
        }

        public string StripZeros(string value)
        {
            if (value == null) throw new ArgumentNullException("The string value is empty!");

            if (value[0].ToString() == "0")
            {
                value = value.Substring(1);
                return StripZeros(value);
            }

            return value;
        }

        public int ProductSum(HashSet<HashSet<HashSet<int>>> array, int counter = 0)
        {
            if (array.ElementAt(counter).GetType().IsArray == false)
            {
                foreach (var item in array.ElementAt(counter))
                {
                    foreach (var i in item)
                    {
                        sum1 += i;
                    }
                }
                counter++;
                return ProductSum(array, counter);
            }
            else if (array.ElementAt(counter).Count == 2)
            {
                foreach (var item in array.ElementAt(counter))
                {
                    foreach (var i in item)
                    {
                        sum2 += i;
                    }
                }
                counter++;
            }
            else
            {
                foreach (var item in array.ElementAt(counter))
                {
                    foreach (var i in item)
                    {
                        sum3 += i;
                    }
                }
                counter++;
            }
            return (sum1) * 1 + (sum2) * 2 + (sum3) * 3;
        }
    }
}
