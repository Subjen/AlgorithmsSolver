using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsSolver.BinarySearch
{
    //https://leetcode.com/problems/find-minimum-in-rotated-sorted-array/description/
    internal class FindMinimumInRotatedSortedArray
    {
        public int FindMin(int[] nums)
        {
            int FindMinIndex(int[] nums)
            {
                int left = 0, right = nums.Length - 1;
                if (left == right) return 0;
                while (left <= right)
                {
                    int i = left + (right - left) / 2;
                    if (nums[i] < nums[(i + nums.Length - 1) % nums.Length] && nums[i] < nums[(i + 1) % nums.Length])
                    {
                        return i;
                    }
                    else if (nums[i] > nums[^1])
                    {
                        left = i + 1;
                    }
                    else if (nums[i] < nums[^1])
                    {
                        right = i - 1;
                    }
                }
                return -1;
            }
            return nums[FindMinIndex(nums)];
        }
    }
}
