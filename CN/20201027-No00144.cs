using System.Collections.Generic;

public class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public class Solution {
    public IList<int> PreorderTraversal(TreeNode root) {
        var result = new List<int>();
        var s = new Stack<TreeNode>();
        s.Push(root);
        while(s.Count > 0) {
            var n = s.Pop();
            if(n == null) {
                continue;
            }
            result.Add(n.val);
            s.Push(n.right);
            s.Push(n.left);
        }

        return result;
    }
}