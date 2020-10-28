public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int x) {
        val = x;
        next = null;
    }
}

public class Solution {
    public ListNode DetectCycle(ListNode head) {
        if (head == null) {
            return null;
        }

        var p1 = head;
        var p2 = head;
        bool result = false;
        
        while(p1 != null && p2 != null) {
            p1 = p1.next;
            if(p2.next == null) {
                return null;
            }
            p2 = p2.next.next;
            if(p1 == p2) { 
                result = true;
                break;
            }
        }
        
        if(!result) {
            return null;
        }
        p1 = head;
        while( p1 != p2) {
            p1 = p1.next;
            p2 = p2.next;
        }

        return p1;
    }
}