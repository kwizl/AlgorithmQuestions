using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoExpert.Easy
{
    public class BuySellStock
    {
        public int MaxProfit(int[] prices)
        {
            int min_val = Int32.MaxValue;
            int max_profit = 0;

            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] < min_val)
                {
                    min_val = prices[i];
                } 
                else if (prices[i]  - min_val > max_profit)
                {
                    max_profit = prices[i] - min_val;
                }
            }

            return max_profit;
        }
    }
}
