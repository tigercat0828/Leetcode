using Leetcode;
using Leetcode.Problems;
using System.Collections;
using static System.Console;



ListNode A = new(1);
ListNode B = new(2);
ListNode C = new(3);


A.next = B;
B.next = C;
;


P206_Reverse_Linked_List problem = new();
problem.ReverseList2(A);



public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null) {
        this.val = val;
        this.next = next;
    }

}
