using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoExpert.Medium
{
    public class FourSumII
    {
        public int FourSumCount(int[] nums1, int[] nums2, int[] nums3, int[] nums4)
        {
            Dictionary<int, int> h = new();
            Dictionary<int, int> hh = new();

            foreach (int n in nums1)
            {
                foreach (int p in nums2)
                {

                    if (h.ContainsKey(n + p))
                        h.Add(n + p, h[n + p] + 1);
                    else
                        h.Add(n + p, 1);
                }
            }

            foreach (var n in nums3)
            {
                foreach (int p in nums4)
                {

                    if (hh.ContainsKey(n + p))
                        hh.Add(n + p, hh[n + p] + 1);
                    else
                        hh.Add(n + p, 1);
                }
            }


            int ans = 0;

            foreach (int n in h.Keys)
            {
                if (hh.ContainsKey(-n))
                {
                    ans += hh[ -n] * h[n];
                }
            }
            return ans;
        }
    }
}
