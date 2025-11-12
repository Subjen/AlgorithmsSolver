using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsSolver.Stack.MonotonicStack
{
    //https://leetcode.com/problems/daily-temperatures/
    internal class DailyTemperaturesSolver
    {
        public int[] DailyTemperatures(int[] temperatures)
        {
            var maxStack = new Stack<int>();
            var res = new int[temperatures.Length];

            for (int i = 0; i < temperatures.Length; i++)
            {
                while (maxStack.Count > 0 && temperatures[maxStack.Peek()] < temperatures[i])
                {
                    var index = maxStack.Pop();
                    res[index] = i - index;
                }
                maxStack.Push(i);
            }
            while (maxStack.Count > 0)
            {
                res[maxStack.Pop()] = 0;
            }

            return res;
        }
    }
}
