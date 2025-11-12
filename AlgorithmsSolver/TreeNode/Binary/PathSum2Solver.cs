using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AlgorithmsSolver.TreeNode.Binary
{
    //https://leetcode.com/problems/path-sum-ii/description/
    internal class PathSum2Solver
    {
        public IList<IList<int>> PathSum(TreeNode root, int targetSum)
        {
            var res = new List<IList<int>>();
            var stack = new Stack<(TreeNode node, int sum, List<int> nodes)>();
            if (root == null)
                return res;
            stack.Push((root, root.val, new List<int>() { root.val }));

            while (stack.Count > 0)
            {
                var (currNode, sum, nodes) = stack.Pop();

                if (currNode.left != null)
                {
                    stack.Push((currNode.left, sum + currNode.left.val, new (nodes) { currNode.left.val }));
                }
                if (currNode.right != null)
                {
                    stack.Push((currNode.right, sum + currNode.right.val, new(nodes) { currNode.right.val }));
                }

                if (sum == targetSum && (currNode.left == null && currNode.right == null))
                {
                    res.Add(nodes);
                }
            }
            
            return res;
        }
    }
}
