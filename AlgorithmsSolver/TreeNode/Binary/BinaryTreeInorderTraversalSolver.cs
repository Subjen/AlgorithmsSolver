using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsSolver.TreeNode.Binary
{
    //https://leetcode.com/problems/binary-tree-inorder-traversal/description/
    internal class BinaryTreeInorderTraversalSolver
    {
        public IList<int> InorderTraversal(TreeNode root)
        {
            var nodes = new List<int>();
            void DFS(TreeNode node, List<int> nodes)
            {
                if (node == null)
                    return;

                if (node.left != null)
                {
                    DFS(node.left, nodes);
                }
                nodes.Add(node.val);
                if (node.right != null)
                {
                    DFS(node.right, nodes);
                }
            }
            DFS(root, nodes);
            return nodes;
        }
    }
}
