﻿using Leetcode.CSharp.Common;

namespace Leetcode.CSharp.Solutions; 
public class Leetcode160 {

    // O(lenA + lenB)
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
        if (headA == null || headB == null) {
            return null;
        }
        List<ListNode> Anodes = [];
        List<ListNode> Bnodes = [];
        ListNode current = headA;
        while (current != null) {   // O(lenA)
            Anodes.Add(current);
            current = current.next;
        }
        current = headB;
        while (current != null) {   // O(lenB)
            Bnodes.Add(current);
            current = current.next;
        }

        Anodes.Reverse();       // O(lenA)
        Bnodes.Reverse();       // O(lenB)

        int len = Math.Min(Anodes.Count, Bnodes.Count);
        int index = -1;
        for (int i = 0; i < len; i++) {     // O(min(lenA, lebB))
            if (Anodes[i] != Bnodes[i]) {
                break;
            }
            index++;
        }
        if (index == -1) {
            return null;
        }
        return Anodes[index];
    }
}
