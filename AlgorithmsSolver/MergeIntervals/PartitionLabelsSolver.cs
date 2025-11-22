using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsSolver.MergeIntervals
{
    //https://leetcode.com/problems/partition-labels/description/
    internal class PartitionLabelsSolver
    {
        class Range 
        {
            public int Min { get; set; }
            public int Max { get; set; }
        }

        public IList<int> PartitionLabels(string s)
        {
            Dictionary<char, int> ranges = new();
            for (int i = 0; i < s.Length; i++)
            {
                ranges[s[i]] = i;
            }

            var res = new List<int>();

            for (int i = 0, min = 0, max = 0; i < s.Length; i++)
            {
                max = Math.Max(max, ranges[s[i]]);

                if (max == i)
                {
                    res.Add(max - min + 1);
                    min = i + 1;
                }
            }

            return res;
        }

        public IList<int> PartitionLabels2(string s)
        {
            Dictionary<char, Range> ranges = new();
            for (int i = 0; i < s.Length; i ++)
            {
                char ch = s[i];

                if (ranges.TryGetValue(ch, out Range? value))
                {
                    value.Max = i;
                }
                else
                {
                    ranges[ch] = new Range { Min = i, Max = i };
                }
            }

            var res = new List<int>();

            var lastRange = ranges[s[0]];

            for (int i = 1; i < s.Length; i++)
            {
                var currRange = ranges[s[i]];

                if (lastRange.Max > currRange.Min)
                {
                    lastRange.Max = Math.Max(lastRange.Max, currRange.Max);
                }
                else
                {
                    res.Add(lastRange.Max - lastRange.Min + 1);
                    lastRange = currRange;
                }
            }
            res.Add(lastRange.Max - lastRange.Min + 1);

            return res;
        }
    }
}
