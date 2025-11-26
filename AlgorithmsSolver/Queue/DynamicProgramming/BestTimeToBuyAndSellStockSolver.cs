using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsSolver.Queue.DynamicProgramming
{
    internal class BestTimeToBuyAndSellStockSolver
    {
        //https://leetcode.com/problems/best-time-to-buy-and-sell-stock/
        public int MaxProfit(int[] prices)
        {
            var max = 0; var min = prices[0];

            for (int i = 1; i < prices.Length; i++)
            {
                max = Math.Max(max, prices[i] - min);

                min = Math.Min(min, prices[i]);
            }
            return max;
        }
    }
}
