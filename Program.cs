using System;
using System.Collections.Generic;
using AlgoExpert.Easy;
using AlgoExpert.Medium;

namespace AlgoExpert
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 12, 6, 5, 10, 9, 8, 15, 22 };
            InsertionSort bst = new();
            bst.Sort(arr);
        }
    }
}
