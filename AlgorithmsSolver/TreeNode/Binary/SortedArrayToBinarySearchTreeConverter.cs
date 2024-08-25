using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsSolver.TreeNode.Binary
{
    
    //Definition for a binary tree node.
    public class TreeNode {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
     
    internal class SortedArrayToBinarySearchTreeConverter
    {
        public TreeNode SortedArrayToBST(int[] nums)
        {
            TreeNode GetChildren(int left, int right, TreeNode parent = null)
            {
                var mid = (right + left) / 2;
                parent = new TreeNode(nums[mid]);
                TreeNode lNode, rNode;

                if (mid == left || left == right)
                    lNode = null;
                else 
                    lNode = GetChildren(left, mid - 1, parent);

                if (mid == right || left == right)
                    rNode = null;
                else 
                    rNode = GetChildren(mid + 1, right, parent);

                parent.left = lNode;
                parent.right = rNode;
                return parent;

            }

            int left = 0, right = nums.Length - 1;

            return GetChildren(left, right);
            
        }
    }
}
