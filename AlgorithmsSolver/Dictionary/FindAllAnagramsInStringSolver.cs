using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsSolver.Dictionary
{
    //https://leetcode.com/problems/find-all-anagrams-in-a-string/
    internal class FindAllAnagramsInStringSolver
    {
        public IList<int> FindAnagrams(string s, string p)
        {
            var res = new List<int>();

            if (p.Length > s.Length)
                return res;

            static Dictionary<char, int> InitDict()
            {
                Dictionary<char, int> dict = new();
                for (char c = 'a'; c <= 'z'; c++)
                {
                    dict.Add(c, 0);
                }
                return dict;
            }

            var source = InitDict();

            foreach (char c in p)
            {
                source[c]++;
            }
            var diff = p.Length;
            
            var anagramDict = InitDict();

            for (int i = 0; i < s.Length; i++)
            {
                var left = i - p.Length + 1;

                var currChar = s[i];
                diff += (source[currChar] >= ++anagramDict[currChar]) ? -1 : 1;
                
                if (diff == 0)
                {
                    res.Add(left);
                }

                if (left >= 0)
                {
                    diff += (source[s[left]] > --anagramDict[s[left]]) ? 1 : -1;
                }
            }

            return res;
        }
    }
}
