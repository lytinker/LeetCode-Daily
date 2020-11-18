public class Solution {
    public int[][] Merge(int[][] intervals) {
        var l = new List<int[]>();
        foreach(var i in intervals) {
            l.Add(i);
        }
        l.Add(new int[] {
            int.MaxValue, int.MaxValue
        });
        l.Sort((x, y) => x[0] - y[0]);
        var r = new List<int[]>();
        var cur = l[0];
        foreach(var i in l) {
            if(i[0] <= cur[1]) {
                cur[1] = Math.Max(cur[1], i[1]);
            } else {
                r.Add(cur);
                cur = i;
            }
        }
        return r.ToArray();
    }
}