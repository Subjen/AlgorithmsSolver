using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsSolver.TwoPointers
{
    internal class SortColorsSolver
    {
        public void SortColors(int[] nums)
        {
            // 0 - red
            // 1 - white
            // 2 - blue
            void Swap(int x, int y)
            {
                (nums[y], nums[x]) = (nums[x], nums[y]);
            }

            int leftIndex = 0, currIndex = 0, rightIndex = nums.Length - 1;

            while (currIndex <= rightIndex)
            {
                while (leftIndex < rightIndex && nums[leftIndex] == 0)
                    leftIndex++;

                while (rightIndex > leftIndex && nums[rightIndex] == 2)
                    rightIndex--;

                currIndex = leftIndex;

                while (currIndex <= rightIndex)
                {
                    if (nums[currIndex] == 0 && currIndex != leftIndex)
                    {
                        Swap(currIndex, leftIndex);
                        leftIndex++;
                    }
                    else if (nums[currIndex] == 2 && currIndex != rightIndex)
                    {
                        Swap(currIndex, rightIndex);
                        rightIndex--;
                    }
                    else
                    {
                        currIndex++;
                    }
                }

            }
        }
    }
}
