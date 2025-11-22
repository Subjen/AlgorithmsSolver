using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsSolver.TwoPointers
{
    internal class ContainerWithMostWaterSolver
    {
        //https://leetcode.com/problems/container-with-most-water/description/
        public int MaxArea(int[] height)
        {
            int left = 0, right = height.Length - 1;

            var maxArea = 0;
            while (left < right)
            {
                var currLength = right - left;

                var minHeght = Math.Min(height[left], height[right]);
                maxArea = Math.Max(maxArea, currLength * minHeght);

                if (height[left] > height[right])
                {
                    var currRight = height[right];
                    while (left < right && height[right] <= currRight)
                    {
                        right--;
                    }
                }
                else
                {
                    var currLeft = height[left];
                    while (left < right && height[left] <= currLeft)
                    {
                        left++;
                    }
                }
            }

            return maxArea;
        }
    }
}
