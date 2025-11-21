using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsSolver.BFS
{
    internal class RemoveInvalidParenthesesSolver
    {
        //https://leetcode.com/problems/remove-invalid-parentheses/description/
        public IList<string> RemoveInvalidParentheses(string s)
        {
            const char openCh = '(', closeCh = ')';

            bool IsValid(string s)
            {
                Stack<char> simbols = new();

                for (int i = 0; i < s.Length; i++)
                {
                    var curr = s[i];
                    if (curr == openCh)
                    {
                        simbols.Push(curr);
                    }
                    else if (curr != closeCh)
                    {
                        continue;
                    }
                    else
                    {
                        if (simbols.Count > 0 && simbols.Peek() == openCh)
                        {
                            simbols.Pop();
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                return simbols.Count == 0;
            }

            var res = new Dictionary<string, bool>();

            int maxLength = s.Length;
            bool firstFinded = IsValid(s);
            Queue<string> queue = new Queue<string>();
            queue.Enqueue(s);
            res.Add(s, firstFinded);
            while (queue.Count > 0)
            {
                var currSubstr = queue.Dequeue();

                if (firstFinded && currSubstr.Length < maxLength)
                    break;

                for (int i = 0; i < currSubstr.Length; i++)
                {
                    if (currSubstr[i] == closeCh || currSubstr[i] == openCh)
                    {
                        var sub = string.Concat(currSubstr[0..i], currSubstr[(i+1)..]);
                        if (!res.ContainsKey(sub))
                        {
                            var isValid = IsValid(sub);

                            if (isValid && !firstFinded)
                            {
                                firstFinded = isValid;
                                maxLength = currSubstr.Length;
                            }

                            res[sub] = isValid;
                            queue.Enqueue(sub);
                        }
                    }

                }
            }

            return res.Where(pair => pair.Value == true).Select(KeyValuePair => KeyValuePair.Key).ToList();
        }
    }
}
