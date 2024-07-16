using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsSolver
{
    internal class LengthOfLastWordSolver
    {
        //public int LengthOfLastWord(string s) => s.Split(' ').Last(sub => !string.IsNullOrEmpty(sub)).Length;
        public int LengthOfLastWord(string s)
        {
            var i = s.Length;
            while (s[--i] == ' ' && i >= 0)
                continue;
            var res = 1;
            while (i > 0 && s[--i] != ' ')
                res++;
            return res;
        }
    }
}
