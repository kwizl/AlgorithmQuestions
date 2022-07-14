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
            int[] nums1 = { 1, 2 };
            int[] nums2 = { -2, -1 };
            int[] nums3 = { -1, 2 };
            int[] nums4 = { 0, 2 };

            FourSumII fr = new();
            fr.FourSumCount(nums1, nums2, nums3, nums4);
        }
    }
}
