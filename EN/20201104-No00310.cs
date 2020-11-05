public class Solution {
    public IList<int> FindMinHeightTrees(int n, int[][] edges) {
        var neighbor = new List<HashSet<int>>();
        for(var i = 0; i < n; ++i) {
            neighbor.Add(new HashSet<int>());
        }
        for(var i = 0; i < edges.Length; ++i) {
            var edge = edges[i];
            neighbor[edge[0]].Add(edge[1]);
            neighbor[edge[1]].Add(edge[0]);
        }
        var s = new HashSet<int>();
        for(var i = 0; i < n; ++i) {
            s.Add(i);
        }
        var leaf = new List<int>();
        for(var i = 0; i < n; ++i) {
            if(neighbor[i].Count <= 1) {
                leaf.Add(i);
            }
        }
        while(leaf.Count > 0 && s.Count > 2) {
            var newLeaf = new List<int>();
            foreach(var x in leaf) {
                s.Remove(x);
                foreach(var nb in neighbor[x]) {
                    neighbor[nb].Remove(x);
                    if(neighbor[nb].Count <= 1) {
                        newLeaf.Add(nb);
                    }
                }
            }
            leaf = newLeaf;
        }
        var result = new List<int>();
        foreach(var r in s) {
            result.Add(r);
        }
        return result;
    }
}