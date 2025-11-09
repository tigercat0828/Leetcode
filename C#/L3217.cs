public class Solution {
    public ListNode ModifiedList(int[] nums, ListNode head) {

        HashSet<int> set = [.. nums];
        ListNode dummy = new(0 ,head);

        ListNode current = head;
        ListNode previous = dummy;
        
        while (current != null) {
            if(set.Contains(current.val)) {
                previous.next = current.next;
            }else{
                previous = current;
            }
            current = current.next;
        }
        return dummy.next;
    }
}