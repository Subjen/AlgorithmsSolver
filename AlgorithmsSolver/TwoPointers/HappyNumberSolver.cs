using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsSolver.TwoPointers
{
    internal class HappyNumberSolver
    {
        Dictionary<int, int> square = new()
        {
            [0] = 0,
            [1] = 1,
            [2] = 4,
            [3] = 9,
            [4] = 16,
            [5] = 25,
            [6] = 36,
            [7] = 49,
            [8] = 64,
            [9] = 81,
        };

        HashSet<int> sums = new();

        int GetSumOfSquare(int n)
        {
            var sum = 0;
            while (n > 0)
            {
                sum += square[n % 10];
                n /= 10;
            }
            return sum;
        }

        public bool IsHappy2(int n)
        {
            while (n != 1)
            {
                n = GetSumOfSquare(n);
                if (!sums.Add(n))
                    return false;
            }

            return n == 1;
        }

        // two pointers algorithm
        // Floyd Cycle Detection (the one we used in Detect Linked List Cycle)
        // don't have to use hashtable
        public bool IsHappy(int n)
        {
            int slow, fast;
            slow = fast = n;
            do
            {
                slow = GetSumOfSquare(slow);
                fast = GetSumOfSquare(fast);
                fast = GetSumOfSquare(fast);
                if (fast == 1) 
                    return true;
            } 
            while (slow != fast);
            return false;
        }
    }
}
