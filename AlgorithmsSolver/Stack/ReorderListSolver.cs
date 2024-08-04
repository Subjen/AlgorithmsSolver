using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsSolver.Stack
{

    //Definition for singly-linked list.
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    internal class ReorderListSolver
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

        public void ReorderList(ListNode head)
        {
            var stack = new Stack<ListNode>();
            var start = head;
            while (head != null) {
                stack.Push(head);
                head = head.next;
            }

            int iterationCount = stack.Count / 2;

            var currNode = start;
            for (int i = 0; i < iterationCount; i++)
            {
                var last = stack.Pop();
                var next = currNode.next;
                last.next = next;
                currNode.next = last;
                currNode = next;
            }
            currNode.next = null;
        }

    }
}
