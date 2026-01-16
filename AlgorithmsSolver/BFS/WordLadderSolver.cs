using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsSolver.BFS
{
    //https://leetcode.com/problems/word-ladder/description/
    internal class WordLadderSolver
    {
        public int LadderLength(string beginWord, string endWord, IList<string> wordList)
        {
            var queue = new Queue<string>();
            var usedWords = new HashSet<string>();
            var words = new HashSet<string>(wordList);

            int iterCount = 1;
            queue.Enqueue(beginWord);
            usedWords.Add(beginWord);

            Span<char> buffer = stackalloc char[beginWord.Length];
            while (queue.Count > 0)
            {
                var wordsCount = queue.Count;

                for (int i = 0; i < wordsCount; i++)
                {
                    queue.Dequeue().AsSpan().CopyTo(buffer);

                    for (int j = 0; j < buffer.Length; j++)
                    {
                        var original = buffer[j];
                        for (char c = 'a'; c <= 'z';  c++)
                        {
                            buffer[j] = c;
                            var w = new string(buffer);

                            if (words.Remove(w) && usedWords.Add(w))
                            {
                                if (w == endWord)
                                    return iterCount + 1;
                                queue.Enqueue(w);
                            }
                        }
                        buffer[j] = original;
                    }
                }

                iterCount++;
            }

            return 0;
        }
    }
}
