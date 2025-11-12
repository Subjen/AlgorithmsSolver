using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsSolver.MergeIntervals
{
    //https://leetcode.com/problems/merge-intervals/description/
    internal class MergeIntervalsSolver
    {
        public int[][] Merge(int[][] intervals)
        {
            var ints = new List<(int l, int r)>(intervals.Select(arr => (arr[0], arr[1])));

            ints.Sort();

            var res = new List<(int l, int r)>
            {
                ints[0]
            };

            for (int i = 1; i < ints.Count; i++)
            {
                var (l, r) = res[^1];
                if (ints[i].l <= r)
                {
                    res[^1] = (l, Math.Max(ints[i].r, r));
                }
                else
                {
                    res.Add(ints[i]);
                }
            }

            return res.Select(pair => new int[] { pair.l, pair.r }).ToArray();
        }
    }
}
