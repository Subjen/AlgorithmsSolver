using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsSolver.Queue.DynamicProgramming
{
    internal class JumpGame6
    {
        // Faster then MaxResult2
        public int MaxResult(int[] nums, int k)
        {
            LinkedList<int> window = new();

            window.AddLast(0);

            for (int i = 1; i < nums.Length; i++)
            {
                nums[i] += nums[window.First.Value];
                while(window.Count > 0 && nums[window.Last.Value] <= nums[i])
                {
                    window.RemoveLast();
                }
                window.AddLast(i);

                if (i - window.First.Value >= k)
                    window.RemoveFirst();
            }

            return nums.Last();
        }

        public int MaxResult2(int[] nums, int k)
        {
            var results = new int[nums.Length];
            for(int i = 0; i < results.Length; i++)
            {
                results[i] = int.MinValue;
            }

            results[0] = nums[0];
            var max = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                for (int j = 1; j <= k && i - j >= 0; j++)
                {
                    var path = results[i - j] + nums[i];
                    if (results[i] < path)
                    {
                        results[i] = path;
                    }
                }
            }

            return results.Last();
        }
    }
}
