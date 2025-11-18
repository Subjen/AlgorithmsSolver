using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsSolver.BinarySearch
{
    // https://leetcode.com/problems/guess-number-higher-or-lower/description/
    internal class GuessNumberHigherOrLowerSolver
    {
        private int target;

        public GuessNumberHigherOrLowerSolver(int n)
        {
            target = n;
        }

        private int guess(int n)
        {
            return target.CompareTo(n);
        }

        public int GuessNumber(int n)
        {
            int l = 1, r = n;

            int res;
            do
            {
                var mid = (int)(((long)r + l) / 2);
                res = guess(mid);
                if (res < 0)
                    r = mid - 1;
                else if (res > 0)
                    l = mid + 1;
                else
                    return mid;
            }
            while (res != 0);
            return 0;
        }
    }
}
