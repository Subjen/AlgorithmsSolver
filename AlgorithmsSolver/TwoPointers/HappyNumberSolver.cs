using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsSolver.TwoPointers
{
    internal class HappyNumberSolver
    {
        public bool IsHappy(int n)
        {
            var square = new Dictionary<int, int>()
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

            var sums = new HashSet<int>();

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

            while (n != 1)
            {
                n = GetSumOfSquare(n);
                if (!sums.Add(n))
                    return false;
            }

            return n == 1;
        }
    }
}
