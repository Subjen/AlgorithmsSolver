using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsSolver.Stack
{
    internal class NextGreaterElement1Solver
    {
        public int[] NextGreaterElement(int[] nums1, int[] nums2)
        {
            var decreasingStack = new Stack<int>();
            var map = new Dictionary<int, int>();

            for (int i = 0; i < nums2.Length; i++)
            {
                var currNum = nums2[i];
                map[currNum] = -1;
                while (decreasingStack.Count > 0 && decreasingStack.Peek() < currNum)
                {
                    var num = decreasingStack.Pop();
                    map[num] = currNum;
                }
                decreasingStack.Push(currNum);
            }

            return nums1.Select(num => map[num]).ToArray();

        }
    }
}
