using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoExpert.Easy
{
    public class ValidateSubsequence
    {
        // Time O(N)
        // Space O(N)
        public bool SubsequenceOne(int[] arr, int[] seq)
        {
            int arridx = 0;
            int seqidx = 0;

            while (arridx < arr.Length && seqidx < seq.Length)
            {
                if (arr[arridx] == seq[seqidx])
                {
                    seqidx++;
                }
                arridx++;
            }

            return seqidx == seq.Length;
        }

        // Time O(N)
        // Space O(N)
        public bool SubsequenceTwo(int[] arr, int[] seq)
        {
            int seqidx = 0;

            foreach (var val in arr)
            {
                if (seqidx == seq.Length) return true;
                
                if (seq[seqidx] == val)
                {
                    seqidx++;
                }
            }

            return seqidx == seq.Length;
        }
    }
}
