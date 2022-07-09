using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoExpert.Medium
{
    public class ArrayProducts
    {
        // O(n) - Space
        // O(n^2) - Time
        public List<int> Products(int[] arr)
        {
            List<int> result = new();
            int i = 0;

            while (i < arr.Length)
            {
                int prod = 1;

                for (int j = 0; j < arr.Length; j++)
                {
                    if (i == j) continue;

                    prod = prod * arr[j];
                }

                result.Add(prod);
                i++;
            }
            Console.WriteLine($"[{result[0]}, {result[1]}, {result[2]}, {result[3]}]", result[0], result[1], result[2], result[3]);
            return result;
        }

        // O(n) - Space
        // O(n) - Time
        public List<int> AlgoProducts(int[] arr)
        {
            List<int> productRight = new();
            List<int> productLeft = new();
            List<int> products = new();

            for (int i = 0; i < arr.Length; i++)
            {
                productRight.Add(1);
                productLeft.Add(1);
            }

            int leftSide = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                productLeft[i] = leftSide;
                leftSide *= arr[i];
            }

            int rightSide = 1;
            Array.Reverse(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                productRight[i] = rightSide;
                rightSide *= arr[i];
            }

            productRight.Reverse();

            for (int i = 0; i < arr.Length; i++)
            {
                products.Add(productLeft[i] * productRight[i]);
            }

            Console.WriteLine($"[{products[0]}, {products[1]}, {products[2]}, {products[3]}]", products[0], products[1], products[2], products[3]);
            return products;
        }
    }
}
