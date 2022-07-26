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
            int[] arr = { 7, 1, 5, 3, 6, 4 };
            BuySellStock bss = new();
            bss.MaxProfit(arr);
        }
    }
}
