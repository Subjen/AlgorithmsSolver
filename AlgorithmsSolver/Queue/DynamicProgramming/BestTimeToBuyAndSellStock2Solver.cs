using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsSolver.Queue.DynamicProgramming
{
    internal class BestTimeToBuyAndSellStock2Solver
    {
        //https://leetcode.com/problems/best-time-to-buy-and-sell-stock-ii/description/
        public int MaxProfit(int[] prices)
        {
            var currMin = prices[0];
            var max = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] > currMin)
                {
                    max += prices[i] - currMin;
                }
                currMin = prices[i];
            }
            return max;
        }
    }
}
