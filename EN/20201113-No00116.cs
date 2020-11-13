// Definition for a Node.
public class Node {
    public int val;
    public Node left;
    public Node right;
    public Node next;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, Node _left, Node _right, Node _next) {
        val = _val;
        left = _left;
        right = _right;
        next = _next;
    }
}

public class Solution {
    public Node Connect(Node root) {
        return root == null ? root : Solve(root);
    }

    private Node Solve(Node node) {
        if(node.left != null) {
            node.left.next = node.right;
            Solve(node.left);
        }

        if(node.right != null) {
            node.right.next = node.next == null ? null : node.next.left;
            Solve(node.right);
        }

        return node;
    }
}