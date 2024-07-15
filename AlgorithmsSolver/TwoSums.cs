using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsSolver
{
    internal class TwoSums
    {
        public int[] TwoSum(int[] nums, int target)
        {
            HashSet<int> result = new();

            for (int i = 0; i < nums.Length; i++)
            {
                var snd = target - nums[i];
                if (result.Contains(snd))
                {
                    return;
                }
                else
                {
                    result.Add(nums[i]);
                }
            }
        }
    }
}
