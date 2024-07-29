using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsSolver.Stack
{
    internal class BaseballGameSolver
    {
        public int CalPoints(string[] operations)
        {
            Stack<int> Numbers = new();

            foreach (string op in operations)
            {
                if (op == "+")
                {
                    var a = Numbers.Pop();
                    var b = Numbers.Peek();
                    Numbers.Push(a);
                    Numbers.Push(a + b);
                }
                else if (op == "C")
                {
                    Numbers.Pop();
                }
                else if (op == "D")
                { 
                    var n = Numbers.Peek();
                    Numbers.Push(n * 2);
                }
                else
                {
                    var num = int.Parse(op);
                    Numbers.Push(num);
                }
            }

            return Numbers.Sum();

        }

    }
}
