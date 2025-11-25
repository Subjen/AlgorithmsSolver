using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsSolver.PriorityQueue
{
    internal class SlidingWindowMaximumSolver
    {
        //https://leetcode.com/problems/sliding-window-maximum/description/

        public int[] MaxSlidingWindow(int[] nums, int k)
        {
            int[] result = new int[nums.Length - k + 1];

            LinkedList<int> priorityQueue = new();

            for (int i = 0; i < nums.Length; i++)
            {
                var index = i - k;
                while (priorityQueue.Count > 0 && priorityQueue.First.Value < index)
                {
                    priorityQueue.RemoveFirst();
                }

                while (priorityQueue.Count > 0 && nums[i] >= priorityQueue.Last.Value)
                {
                    priorityQueue.RemoveLast();
                }
                priorityQueue.AddLast(i);
                
                if (index >= -1)
                    result[index + 1] = nums[priorityQueue.First.Value];
            }

            return result;
        }

        public int[] MaxSlidingWindow2(int[] nums, int k)
        {
            int[] result = new int[nums.Length - k + 1];

            PriorityQueue<int, int> priorityQueue = new(Comparer<int>.Create((x, y) => y.CompareTo(x)));

            for (int i = 0; i < k; i++)
            {
                priorityQueue.Enqueue(i, nums[i]);
            }

            for (int i = k; i < nums.Length; i++)
            {
                var index = i - k;
                result[index] = nums[priorityQueue.Peek()];
                while (priorityQueue.Count > 0 && priorityQueue.Peek() <= index)
                {
                    priorityQueue.Dequeue();
                }
                priorityQueue.Enqueue(i, nums[i]);
            }
            result[^1] = nums[priorityQueue.Peek()];

            return result;
        }
    }
}
