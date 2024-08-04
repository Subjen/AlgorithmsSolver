using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsSolver.TwoPointers
{
    internal class RemoveElementSolver
    {
        public int RemoveElement(int[] nums, int val)
        {
            var targetValueIndex = 0;
            var nontargetValueIndex = 0;

            while (nontargetValueIndex < nums.Length)
            {
                while (targetValueIndex < nums.Length && nums[targetValueIndex] != val)
                    targetValueIndex++;

                nontargetValueIndex = targetValueIndex + 1;

                while (nontargetValueIndex < nums.Length && nums[nontargetValueIndex] == val)
                    nontargetValueIndex++;

                if (nontargetValueIndex < nums.Length)
                {
                    var temp = nums[nontargetValueIndex];
                    nums[nontargetValueIndex] = nums[targetValueIndex];
                    nums[targetValueIndex] = temp;

                    nontargetValueIndex++;
                    targetValueIndex++;
                }
            }

            return targetValueIndex;
        }
    }
}
