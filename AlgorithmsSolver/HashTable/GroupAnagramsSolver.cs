using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsSolver.HashTable
{
    internal class GroupAnagramsSolver
    {
        //https://leetcode.com/problems/group-anagrams/description/
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            Dictionary<string, IList<string>> dictionary = new();

            foreach (var str in strs)
            {
                var counter = new char[26];
                foreach (var c in str) 
                    counter[c - 'a']++; 
                var key = new string(counter);
                if (dictionary.ContainsKey(key))
                {
                    dictionary[key].Add(str);
                }
                else
                {
                    dictionary[key] = [str];
                }
            }

            return dictionary.Values.ToList();
        }

        // slower than first variant couse have sorting
        public IList<IList<string>> GroupAnagrams2(string[] strs)
        {
            Dictionary<string, IList<string>> dictionary = new();

            foreach (var str in strs)
            {
                var key = string.Concat(str.OrderBy(c => c));
                if (dictionary.ContainsKey(key))
                {
                    dictionary[key].Add(str);
                }
                else
                {
                    dictionary[key] = [str];
                }
            }

            return dictionary.Values.ToList();
        }
    }
}
