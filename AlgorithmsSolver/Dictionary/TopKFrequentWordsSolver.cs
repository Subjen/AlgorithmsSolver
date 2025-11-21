using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AlgorithmsSolver.Dictionary
{
    //https://leetcode.com/problems/top-k-frequent-words/description/
    internal class TopKFrequentWordsSolver
    {
        class WordCount
        {
            public string word;
            public int count;

            public WordCount(string word, int count)
            {
                this.word = word;
                this.count = count;
            }
        }

        class WordCountComparer : IComparer<WordCount>
        {
            public int Compare(WordCount? x, WordCount? y)
            {
                if (x.count == y.count)
                {
                    return x.word.CompareTo(y.word);
                }
                else
                    return -x.count.CompareTo(y.count);
            }
        }

        public IList<string> TopKFrequent(string[] words, int k)
        {
            var counter = new Dictionary<string, int>();

            foreach (string word in words)
            {
                counter[word] = counter.GetValueOrDefault(word, 0) + 1;
            }

            //var wordCounts = words.GroupBy(word => word).Select(group => new WordCount(group.Key, group.Count()));

            PriorityQueue<string, WordCount> queue = new(counter.Select(pair => (pair.Key, new WordCount(pair.Key, pair.Value))), new WordCountComparer());

            var res = new List<string>();
            for (int i = 0; i < k; i++)
            {
                res.Add(queue.Dequeue());
            }
            return res;
        }
    }
}
