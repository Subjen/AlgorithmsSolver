using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsSolver.Stack
{
    //https://leetcode.com/problems/jump-game/description/
    internal class JumpGameSolver
    {
        public bool CanJump(int[] nums)
        {
            var jump = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                jump--;
                jump = Math.Max(jump, nums[i]);

                if (jump + i >= nums.Length - 1) 
                    return true;

                if (jump == 0 && i != nums.Length - 1) 
                    return false;
            }
            return true;
        }

        //неоптимально памяти (и времени?)
        private class Solution
        {
            public bool CanJump(int[] nums)
            {
                var stack = new Stack<int>();
                var ReachedIndexes = new HashSet<int>();

                stack.Push(0);
                ReachedIndexes.Add(0);

                while (stack.Count > 0)
                {
                    var index = stack.Pop();

                    if (index + nums[index] >= nums.Length - 1)
                        return true;

                    for (int i = 1; i <= nums[index]; i++)
                    {
                        var nextIndex = index + i;

                        if (ReachedIndexes.Add(nextIndex))
                        {
                            stack.Push(nextIndex);
                        }
                    }
                }

                return false;
            }
        }

    }
}
