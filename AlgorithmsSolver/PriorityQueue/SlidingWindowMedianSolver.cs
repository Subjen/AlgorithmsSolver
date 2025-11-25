using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsSolver.PriorityQueue
{
    //https://leetcode.com/problems/sliding-window-median/description/
    internal class SlidingWindowMedianSolver
    {
        record Item(int num, int index);

        // быстрое решение, но хер его разберешь из-за балансировки с фейковым количеством элементов в очереди
        public double[] MedianSlidingWindow(int[] nums, int k)
        {
            var left = new PriorityQueue<int, int>(Comparer<int>.Create((x, y) => y.CompareTo(x)));
            var right = new PriorityQueue<int, int>();
            Dictionary<int, int> NumsToRemove = new();
            var result = new double[nums.Length - k + 1];
            int balance = 0;

            void Add(int num)
            {
                if (left.Count == 0 || num <= left.Peek())
                {
                    left.Enqueue(num, num);
                }
                else
                {
                    right.Enqueue(num, num);
                }
                Balance();
            }

            void Balance()
            {

                if (left.Count + balance - 1 > right.Count)
                {
                    var item = left.Dequeue();
                    right.Enqueue(item, item);
                }
                else if (left.Count + balance < right.Count)
                {
                    var item = right.Dequeue();
                    left.Enqueue(item, item);
                }
                Remove();
                    
            }

            void MarkToRemove(int num)
            {
                if (left.Count > 0 && num <= left.Peek()) 
                    balance--;
                else
                    balance++;

                if (!NumsToRemove.ContainsKey(num)) 
                    NumsToRemove[num] = 0;
                NumsToRemove[num]++;
                Balance();
            }

            void Remove()
            {
                while (left.Count > 0 && NumsToRemove.ContainsKey(left.Peek()) && NumsToRemove[left.Peek()] > 0)
                {
                    var item = left.Dequeue();
                    NumsToRemove[item]--;
                    balance++;
                }
                while (right.Count > 0 && NumsToRemove.ContainsKey(right.Peek()) && NumsToRemove[right.Peek()] > 0)
                {
                    var item = right.Dequeue();
                    NumsToRemove[item]--;
                    balance--;
                }
            }

            double GetMedian() =>
                k % 2 == 1
                    ? left.Peek()
                    : ((double)left.Peek() + right.Peek()) / 2.0;

            for (int i = 0; i < nums.Length; i++)
            {
                Add(nums[i]);
                var index = i - k;
                if (index >= 0)
                    MarkToRemove(nums[index]);
                if (index >= -1)
                    result[index + 1] = GetMedian();
            }

            return result;
        }

        public double[] MedianSlidingWindow2(int[] nums, int k)
        {
            var list = new SortedList<Item, int>(Comparer<Item>.Create((x, y) => y.num == x.num ? x.index.CompareTo(y.index) : x.num.CompareTo(y.num)));
            var result = new double[nums.Length - k + 1];

            void Add(int i)
            {
                list.Add(new(nums[i], i), nums[i]);
            }

            void Remove(int index)
            {
                list.Remove(new(nums[index], index));
            }

            double GetMedian()
            {
                var index = k / 2;
                
                return k % 2 == 0
                    ? ((double)list[list.GetKeyAtIndex(index - 1)] + list[list.GetKeyAtIndex(index)]) / 2.0
                    : list[list.GetKeyAtIndex(index)];
            }

            for (int i = 0; i < k; i++)
            {
                Add(i);
            }

            for (int i = k; i <= nums.Length; i++)
            {
                var index = i - k;
                result[index] = GetMedian();
                if (i < nums.Length)
                {
                    Add(i);
                    Remove(index);
                }  

            }

            return result;
        }

        
    }
}
