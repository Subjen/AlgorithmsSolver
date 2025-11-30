using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsSolver.Queue.DynamicProgramming
{
    internal class BestTimetoBuyandSellStockwithCooldownSolver
    {
        //https://leetcode.com/problems/best-time-to-buy-and-sell-stock-with-cooldown/
        public int MaxProfit(int[] prices)
        {
            var result = new int[prices.Length, 2];
            const int buy = 0, sell = 1;
            result[0, sell] = 0;
            result[0, buy] = -prices[0];
            for (int i = 1; i < prices.Length; i++)
            {
                if (i > 1)
                    result[i, buy] = Math.Max(result[i - 1, buy], result[i - 2, sell] - prices[i]);
                else
                    result[i, buy] = Math.Max(result[i - 1, buy], -prices[i]);

                result[i, sell] = Math.Max(result[i - 1, sell], result[i - 1, buy] + prices[i]);
            }

            return result[prices.Length - 1, sell];
        }
    }
}
