public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) {
        this.val = val;
        this.next = next;
    }
}

public class Solution {
    public ListNode OddEvenList(ListNode head) {
        if(head == null) {
            return head;
        }

        var p0 = head.next;
        var pOdd = head;
        var pEven = head.next;
        while(pEven != null && pEven.next != null) {
            pOdd.next = pEven.next;
            pOdd = pOdd.next;
            pEven.next = pOdd.next;
            pEven = pEven.next;
        }
        pOdd.next = p0;
        return head;
    }
}