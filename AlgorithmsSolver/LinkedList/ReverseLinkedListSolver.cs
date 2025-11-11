using AlgorithmsSolver.Stack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsSolver.LinkedList
{
    // https://leetcode.com/problems/reverse-linked-list/description/
    internal class ReverseLinkedListSolver
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

        public ListNode ReverseList(ListNode head)
        {
            ListNode prev = null;
            ListNode curr = head;
            ListNode next = null;

            while (curr != null)
            {
                next = curr.next;
                curr.next = prev;
                prev = curr;
                curr = next;
            }

            return prev;
        }
    }
}
