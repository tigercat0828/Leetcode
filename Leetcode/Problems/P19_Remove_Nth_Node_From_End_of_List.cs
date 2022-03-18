﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems {
    public class P19_Remove_Nth_Node_From_End_of_List {

        public class ListNode {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null) {
                this.val = val;
                this.next = next;
            }
        }
        public ListNode RemoveNthFromEnd(ListNode head, int n) {
            ListNode fast = head;
            for (int i = 0; i < n; i++) {
                fast = fast.next;
            }
            // delete from head
            if(fast == null) {
                head = head.next;
                return head;
            }
            ListNode slow = head;
            while(fast.next != null) {
                fast= fast.next;
                slow= slow.next;
            }
            slow.next = slow.next.next;

            return head;
        }
    }
}
