using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsSolver.TreeNode.Binary
{
    internal class SymmetricTreeSolver
    {
        //https://leetcode.com/problems/symmetric-tree/description/
        public bool IsSymmetric(TreeNode root)
        {
            var stack1 = new Stack<TreeNode>([root.left]);
            var stack2 = new Stack<TreeNode>([root.right]);

            void PushChilds(Stack<TreeNode> stack, TreeNode leftnode, TreeNode rightnode)
            {
                stack.Push(leftnode);
                stack.Push(rightnode);
            }

            while (stack1.Count > 0 && stack2.Count > 0)
            {
                var node1 = stack1.Pop();
                var node2 = stack2.Pop();

                if (node1 == null && node2 == null)
                    continue;
                else if (node1?.val != node2?.val)
                {
                    return false;
                }
                else
                {
                    PushChilds(stack1, node1.left, node1.right);
                    PushChilds(stack2, node2.right, node2.left);
                }
            }

            return stack1.Count == 0 && stack2.Count == 0;
        }
    }
}
