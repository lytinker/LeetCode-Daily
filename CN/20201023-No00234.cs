public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int x) { val = x; }
}

public class Solution {
    public bool IsPalindrome(ListNode head) {
        if(head == null) {
            return true;
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

        var p1 = pointer;
        var p2 = pointer.next;
        while(p2 != null) {
            var temp = p2.next;
            p2.next = p1;
            p1 = p2;
            p2 = temp;
        }

        var head1 = head;
        var head2 = p1;
        for(var i = 0; i < length / 2; ++i) {
            if(head1.val != head2.val) {
                return false;
            }
            head1 = head1.next;
            head2 = head2.next;
        }

        return true;
    }
}