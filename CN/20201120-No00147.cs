public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int x) { val = x; }
}

public class Solution {
    public ListNode InsertionSortList(ListNode head) {
        if(head == null) {
            return head;
        }
        var guard = new ListNode(int.MinValue);
        
        var next = head;
        while(next != null) {
            var curr = next;
            next = curr.next;
            var p = guard;
            while(p.next != null && p.next.val < curr.val) {
                p = p.next;
            }

            curr.next = p.next;
            p.next = curr;
        }

        return guard.next;
    }
}