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
            Dictionary<int, int> store = [];

            for (int i = 0; i < nums.Length; i++)
            {
                if (store.TryGetValue(nums[i], out int value))
                {
                    return [value, i];
                }
                else
                {
                    store[target - nums[i]] = i;
                }
            }
            return null;
        }
    }
}
