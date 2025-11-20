using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsSolver.Stack
{
    //https://leetcode.com/problems/valid-parentheses/description/
    internal class ValidParenthesesSolver
    {
        public bool IsValid(string s)
        {
            Stack<char> simbols = new();
            Dictionary<char, char> map = new()
            {
                ['}'] = '{',
                [')'] = '(',
                [']'] = '['
            };

            for (int i = 0; i < s.Length; i++)
            {
                var curr = s[i];
                if (curr == '{' || curr == '[' || curr == '(')
                {
                    simbols.Push(curr);
                }
                else
                {
                    if (simbols.Count > 0 && simbols.Peek() == map[curr])
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
    }
}
