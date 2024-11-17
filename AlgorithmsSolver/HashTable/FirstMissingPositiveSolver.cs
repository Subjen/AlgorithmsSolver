using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsSolver.HashTable
{
    //https://leetcode.com/problems/first-missing-positive/description/?envType=problem-list-v2&envId=hash-table
    internal class FirstMissingPositiveSolver
    {
        public int FirstMissingPositive(int[] nums)
        {
            // ищем макссимальное число в последовательности, оно не может быть больше длины массива
            int maxSeqNum = nums.Length;
            // все числа, которые нам не подходят (НЕ положительные, и больше максимвльного числа) помечаем макс+1
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] <= 0 || nums[i] > maxSeqNum)
                    nums[i] = maxSeqNum + 1;
            }

            // Проходим по массиву и отмечаем числа, которые встретились 
            // Для этого идем по индексу, равному текущему числу и помечаем его отрицательным значением
            for (int i = 0; i < nums.Length; i++)
            {
                var currNum = Math.Abs(nums[i]);
                if (currNum > maxSeqNum)
                    continue;
                currNum--;
                if (nums[currNum] >= 0)
                {
                    nums[currNum] = -1 * nums[currNum];
                }
            }

            // Последний раз проходим по массиву, ища первое попавшееся положительное число
            // Оно означает, что текущий индекс не проходился, следовательно, такого числа мы не находили
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0)
                    return i + 1;
            }

            return maxSeqNum + 1;
        }
    }
}
