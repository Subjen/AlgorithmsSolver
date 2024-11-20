using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsSolver.TreeNode.Binary
{
    //https://leetcode.com/problems/unique-binary-search-trees/description/
    internal class UniqueBinarySearchTreesSolver
    {
        // ищем комбинацию предыдущих решений 
        public int NumTrees(int n)
        {
            var res = new int[n + 1];
            res[0] = 1;
            res[1] = 1;

            for (int i = 2; i < n + 1; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    res[i] += res[j] * res[i - j - 1]; 
                }
            }

            return res[n];
        }

    }
}
