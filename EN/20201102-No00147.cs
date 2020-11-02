public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) {
        this.val = val;
        this.next = next;
    }
}

public class Solution {
    public ListNode InsertionSortList(ListNode head) {
        var g = new ListNode(int.MinValue, null);
    
        var np = head;
        while(np != null) {
            var cp = np;
            np = np.next;
            var p1 = g;
            var p2 = g;
            while(p1 != null && p1.val <= cp.val) {
                p2 = p1;
                p1 = p1.next;
            }

            p2.next = cp;
            cp.next = p1;
        }

        return g.next;
    }
}