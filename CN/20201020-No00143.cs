public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) {
        this.val = val;
        this.next = next;
    }
}

public class Solution {
    public void ReorderList(ListNode head) {
        if(head == null) {
            return;
        }
        
        var length = 0;
        var pointer = head;
        while(pointer != null) {
            ++length;
            pointer = pointer.next;
        }

        pointer = head;
        for(var i = 0; i < length / 2; ++i) {
            pointer = pointer.next;
        }
        var mid = pointer;
        var pCurr = pointer;
        var pNext = pointer.next;
        while(pNext != null) {
            var temp = pNext.next;
            pNext.next = pCurr;
            pCurr = pNext;
            pNext = temp;
        }
        mid.next = null;

        var head1 = head;
        var head2 = pCurr;
        while(head1 != null && head2 != null) {
            var temp1 = head1.next;
            var temp2 = head2.next;
            head1.next = head2;
            if(head2 != temp1) {
                head2.next = temp1;
            }
            head1 = temp1;
            head2 = temp2;
        }
    }
}