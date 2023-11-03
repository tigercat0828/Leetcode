﻿using Leetcode.CSharp.Common;

namespace Leetcode.CSharp.Problems {
    public class P1290_Convert_Binary_Number_in_a_Linked_List_to_Integer {
        // bit manupulation O(n)
        public int GetDecimalValue(ListNode head) {
            int result = 0;
            ListNode current = head;
            while (current != null) {
                result <<= 1;
                result |= current.val;
                current = current.next;
            }
            return result;
        }

        // O(n) space and time
        public int GetDecimalValue2(ListNode head) {
            List<int> bits = new List<int>();
            ListNode current = head;
            while (current != null) {
                bits.Add(current.val);
                current = current.next;
            }
            int sum = 0;

            bits.Reverse();
            for (int i = 0; i < bits.Count; i++) {
                sum += bits[i] * (int)Math.Pow(2, i);
            }
            return sum;
        }
    }
}