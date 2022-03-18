using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems {
    public class P141_Linked_List_Cycle {

        public class ListNode {
            public int val;
            public ListNode next;
            public ListNode(int x) {
                val = x;
                next = null;
            }
        }
        public bool HasCycle(ListNode head) {
            if(head == null ) return false;
            ListNode fast = head.next;
            ListNode slow = head;
            while (fast != null && slow != null) {
                fast = fast.next?.next;
                slow = slow.next;
                if(fast == slow) {
                    return true;
                }
            }
            return false;
        }

        public bool HasCycle2(ListNode head) {
            // solute problem with counter
            ListNode current = head;
            int count = 0;
            while (current != null) { 
                current = current.next;
                count++;
                if(count > 10001) {
                    return true;    
                }
            }
            return false;
        }
    }
}
