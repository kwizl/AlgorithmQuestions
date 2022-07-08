using System;
using AlgoExpert.Easy;
using AlgoExpert.Medium;

namespace AlgoExpert
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 3, 4, 0, 10, 6, 5, -1, -3, 2, 3 };

            LongestPeak peak = new();
            peak.AlgoPeak(array);
        }
    }
}
