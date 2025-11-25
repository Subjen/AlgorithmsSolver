using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsSolver.TwoPointers
{
    //https://leetcode.com/problems/longest-repeating-character-replacement/description/
    internal class LongestRepeatingCharacterReplacementSolver
    {
        public int CharacterReplacement(string s, int k)
        {
            var max = 0;
            var counter = new int[26];
            int left = 0;
            int maxFreq = 0;
            for (int right = 0; right < s.Length; right++)
            {
                var chIndex = s[right] - 'A';
                counter[chIndex]++;
                maxFreq = Math.Max(maxFreq, counter[chIndex]);

                while (right - left - maxFreq + 1 > k)
                {
                    counter[s[left] - 'A']--;
                    left++;
                }
                max = Math.Max(max, right - left + 1);

            }

            return max;
        }

        public class Solution
        {
            public int CharacterReplacement(string s, int k)
            {
                var max = 0;
                for (char ch = 'A'; ch <= 'Z'; ch++)
                {
                    int left = 0, right = 0;
                    int diff = k;
                    while (right < s.Length)
                    {
                        if (s[right] != ch)
                        {
                            diff--;
                        }
                        right++;

                        while (left < right && diff < 0)
                        {
                            if (s[left] != ch)
                            {
                                diff++;
                            }
                            left++;
                        }
                        max = Math.Max(max, right - left);

                    }
                }

                return max;
            }
        }

    }
}
