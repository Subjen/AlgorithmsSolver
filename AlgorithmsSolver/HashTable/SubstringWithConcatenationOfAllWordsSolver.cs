using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsSolver.HashTable
{
    //https://leetcode.com/problems/substring-with-concatenation-of-all-words/
    internal class SubstringWithConcatenationOfAllWordsSolver
    {
        public IList<int> FindSubstring(string s, string[] words)
        {
            var expectedWordsCount = new Dictionary<string, int>();
            foreach (var word in words) {
                if (expectedWordsCount.TryGetValue(word, out int value))
                {
                    expectedWordsCount[word] = ++value;
                }
                else
                {
                    expectedWordsCount[word] = 1;
                }
            }
            var res = new List<int>();
            var wordLength = words.First().Length;

            var wordsCount = words.Length;

            for (int i = 0; i < wordLength; i++)
            {
                var currentWordsCount = new Dictionary<string, int>();
                foreach (var word in words.Distinct())
                {
                    currentWordsCount[word] = 0;
                }

                int j = i;
                int count = 0;
                var left = i;

                while (j <= s.Length - wordLength)
                {
                    var currWord = s.Substring(j, wordLength);

                    if (currentWordsCount.ContainsKey(currWord))
                    {

                        count++;
                        currentWordsCount[currWord]++;
                        while (currentWordsCount[currWord] > expectedWordsCount[currWord])
                        {
                            if (left < 0)
                                left = 0;
                            {
                                var leftWord = s.Substring(left, wordLength);
                                if (currentWordsCount.ContainsKey(leftWord) && currentWordsCount[leftWord] > 0)
                                {
                                    currentWordsCount[leftWord]--;
                                    count--;
                                }
                                left += wordLength;
                            }
                        }
                    }
                    else
                    {
                        foreach (var w in words)
                        {
                            currentWordsCount[w] = 0;
                        }
                        count = 0;
                        left = j + wordLength;
                    }

                    if (count == wordsCount)
                    {
                        res.Add(left);
                        var leftWord = s.Substring(left, wordLength);
                        if (currentWordsCount.ContainsKey(leftWord))
                        {
                            currentWordsCount[leftWord]--;
                            count--;
                        }
                        left += wordLength;
                    }

                    j += wordLength;
                }
            }
            return res;
        }
    }
}
