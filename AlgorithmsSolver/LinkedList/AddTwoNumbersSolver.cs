using AlgorithmsSolver.Stack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsSolver.LinkedList
{
    // https://leetcode.com/problems/add-two-numbers/
    internal class AddTwoNumbersSolver
    {
        public ListNode Build(int[] arr)
        {
            ListNode myHead = null;
            int i = arr.Length;

            while (i-- > 0)
            {
                ListNode tempNode = new ListNode(arr[i], null);
                if (myHead == null)
                {
                    myHead = tempNode;
                }
                else
                {
                    tempNode.next = myHead;
                    myHead = tempNode;
                }
            }

            return myHead;
        }

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode AddTwoNumbers(ListNode l1, ListNode l2, bool Add = false)
            {
                if (l1 != null || l2 != null)
                {
                    l1 ??= new ListNode(0);
                    l2 ??= new ListNode(0);
                    var val = (l1.val + l2.val + (Add ? 1 : 0));
                    var currNode = new ListNode(val % 10);
                    var node = AddTwoNumbers(l1.next, l2.next, val > 9);
                    currNode.next = node;
                    return currNode;
                }
                else if (Add)
                {
                    return new ListNode(1);
                }
                else
                    return null;
            }
            
            var node = AddTwoNumbers(l1, l2);
            return node;
        }
    }
}
