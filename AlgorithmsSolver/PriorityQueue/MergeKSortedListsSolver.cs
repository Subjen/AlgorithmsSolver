using AlgorithmsSolver.Stack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsSolver.PriorityQueue
{
    //https://leetcode.com/problems/merge-k-sorted-lists/description/
    internal class MergeKSortedListsSolver
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

        public ListNode MergeKLists(ListNode[] lists)
        {
            ListNode result = null;
            PriorityQueue<ListNode, int> queue = new();

            for (int i = 0; i < lists.Length; i++)
            {
                var currNode = lists[i];
                if (currNode != null)
                {
                    queue.Enqueue(currNode, currNode.val);
                    lists[i] = currNode.next;
                }
            }

            if (queue.Count == 0)
                return result;

            var lastNode = new ListNode(0);

            while (queue.Count > 0)
            {
                var currNode = queue.Dequeue();

                if (currNode.next != null)
                {
                    queue.Enqueue(currNode.next, currNode.next.val);
                }

                result ??= currNode;

                lastNode.next = currNode;
                lastNode = currNode;
            }
            return result;
        }
    }
}
