using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsSolver.TreeNode.Binary
{
    //https://leetcode.com/problems/binary-tree-cameras/
    // NOT SOLVED
    internal class BinaryTreeCamerasSolver
    {
        public int MinCameraCover(TreeNode root)
        {
            int DFS(TreeNode node)
            {
                int count = 0;
                var childHasCam = false;
                if (node == null)
                    return 0;

                if (node.left != null)
                {
                    count += DFS(node.left);
                    if (node.left.val != 0)
                    {
                        childHasCam = true;
                    }
                }

                if (node.right != null)
                {
                    count += DFS(node.right);
                    if (node.right.val != 0)
                    {
                        childHasCam = true;
                    }
                }

                if (node.left == null && node.right == null)
                    return 0;

                if (!childHasCam)
                {
                    node.val = 1;
                    count++;
                }
                return count;
            }

            var count = 0;
            count = DFS(root);
            return count;

        }
    }
}
