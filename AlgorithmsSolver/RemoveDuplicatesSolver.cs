using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsSolver
{
    internal class RemoveDuplicatesSolver
    {
        public int RemoveDuplicates(int[] nums)
        {
            int diff = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] == nums[i - 1])
                {
                    diff++;
                }
                nums[i - diff] = nums[i];
            }
            return nums.Length - diff;
        }
    }
}
