using Leetcode.CSharp.Common;

namespace Leetcode.CSharp.Solutions;

public class Leetcode0019 {

    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        ListNode fast = head;
        for (int i = 0; i < n; i++) {
            fast = fast.next;
        }
        // delete from head
        if (fast == null) {
            head = head.next;
            return head;
        }
        ListNode slow = head;
        while (fast.next != null) {
            fast = fast.next;
            slow = slow.next;
        }
        slow.next = slow.next.next;

        return head;
    }
}