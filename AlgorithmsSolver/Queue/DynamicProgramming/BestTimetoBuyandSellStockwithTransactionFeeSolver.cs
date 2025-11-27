using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsSolver.Queue.DynamicProgramming
{
    //https://leetcode.com/problems/best-time-to-buy-and-sell-stock-with-transaction-fee/description/
    internal class BestTimetoBuyandSellStockwithTransactionFeeSolver
    {
        public int MaxProfit(int[] prices, int fee)
        {
            var currMin = prices[0];
            var max = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] > currMin + fee)
                {
                    max += prices[i] - currMin - fee;
                    currMin = prices[i] - fee;
                }
                currMin = Math.Min(currMin, prices[i]);
            }
            return max;
        }
    }
}
