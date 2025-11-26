using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsSolver.TreeNode.Binary
{
    //https://leetcode.com/problems/balanced-binary-tree/description/
    internal class BalancedBinaryTreeSolver
    {
        public bool IsBalanced(TreeNode root)
        {
            Stack<TreeNode> stack = new Stack<TreeNode>();
            HashSet<TreeNode> visited = new();

            if (root == null)
                return true;
            
            stack.Push(root);
            
            while (stack.Count > 0)
            {
                var currNode = stack.Peek();
                if (currNode.left == null && currNode.right == null)
                {
                    currNode.val = 1;
                    visited.Add(currNode);
                    stack.Pop();
                }
                else if (!visited.Contains(currNode))
                {
                    if (currNode.left != null)
                    {
                        stack.Push(currNode.left);
                    }
                    if (currNode.right != null)
                    {
                        stack.Push(currNode.right);
                    }
                    visited.Add(currNode);
                }
                else
                {
                    var leftDepth = currNode.left == null ? 0 : currNode.left.val;
                    var rightDepth = currNode.right == null ? 0 : currNode.right.val;

                    if (Math.Abs(leftDepth - rightDepth) > 1)
                        return false;

                    currNode.val = Math.Max(leftDepth, rightDepth) + 1;
                    stack.Pop();
                }
            }
            return true;
        }
    }
}
