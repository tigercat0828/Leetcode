using Leetcode.CSharp.Common;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.CSharp.Solutions {
    public class Leetcode3217 {

        public class ListNode {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null) {
                this.val = val;
                this.next = next;
            }
        }
        public ListNode ModifiedList(int[] nums, ListNode head) {
            HashSet<int> banned = new(nums);
            List<int> list = [];
            ListNode current = head;
            while (current != null) {
                if (!banned.Contains(current.val)) {
                    list.Add(current.val);
                }
                current = current.next;
            }
            ListNode newHead = new();
            newHead.val = list[0];
            ListNode tail = newHead;
            for (int i = 1; i < list.Count; i++) {
                ListNode node = new();
                node.val = list[i];
                tail.next = node;
                tail = tail.next;
            }
            current = newHead;
            return newHead;
        }
    }
}
