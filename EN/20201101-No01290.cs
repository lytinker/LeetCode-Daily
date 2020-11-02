public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) {
        this.val = val;
        this.next = next;
    }
}

public class Solution {
    public int GetDecimalValue(ListNode head) {
        var p = head;
        var result = 0;
        while(p != null) {
            result <<= 1;
            result += p.val;
            p = p.next;
        }

        return result;
    }
}