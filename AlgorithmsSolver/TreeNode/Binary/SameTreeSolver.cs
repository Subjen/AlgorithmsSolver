using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AlgorithmsSolver.TreeNode.Binary
{
    internal class SameTreeSolver
    {
        //https://leetcode.com/problems/same-tree/description/
        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            var stack1 = new Stack<TreeNode>([p]);
            var stack2 = new Stack<TreeNode>([q]);

            void PushChilds(Stack<TreeNode> stack, TreeNode node)
            {
                stack.Push(node.left);
                stack.Push(node.right);
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
                    PushChilds(stack1, node1);
                    PushChilds(stack2, node2);
                }
            }

            return stack1.Count == 0 && stack2.Count == 0;
        }
    }
}
