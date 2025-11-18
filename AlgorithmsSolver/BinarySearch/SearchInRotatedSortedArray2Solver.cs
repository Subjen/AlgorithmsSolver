using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsSolver.BinarySearch
{
    //https://leetcode.com/problems/search-in-rotated-sorted-array-ii/description/
    internal class SearchInRotatedSortedArray2Solver
    {
        public bool Search(int[] nums, int target)
        {
            var right = nums.Length - 1;
            int left = 0, mid;

            while (left <= right)
            {
                mid = (left + right) / 2;

                if (nums[left] == nums[right] && nums[left] == nums[mid] && left != mid)
                {
                    left++;
                    right--;
                    continue;
                }

                if (nums[mid] == target)
                    return true;

                if (nums[mid] >= nums[left])
                {
                    if (nums[left] <= target && nums[mid] > target)
                    {
                        right = mid - 1;
                    }
                    else
                    {
                        left = mid + 1;
                    }
                }
                else
                {
                    if (nums[right] >= target && nums[mid] < target)
                    {
                        left = mid + 1;
                    }
                    else
                    {
                        right = mid - 1;
                    }
                }
            }

            return false;
        }
    }
}
