using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsSolver.Dictionary
{
    internal class TopKFrequentElementsSolver
    {
        //https://leetcode.com/problems/top-k-frequent-elements/description/
        public int[] TopKFrequent(int[] nums, int k)
        {
            Dictionary<int, int> numsCount = new();
            PriorityQueue<int, int> queue = new();
            foreach (var num in nums)
            {
                numsCount[num] = numsCount.GetValueOrDefault(num, 0) + 1;
            }

            foreach(var (key, value) in numsCount)
            {
                queue.Enqueue(key, value);

                if (queue.Count > k)
                {
                    queue.Dequeue();
                }
            }

            var res = new int[k];
            for (int i = 0; i < k; i++)
            {
                res[i] = queue.Dequeue();
            }
            return res;
        }
    }
}
