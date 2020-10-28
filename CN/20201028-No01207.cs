using System.Collections.Generic;

public class Solution {
    public bool UniqueOccurrences(int[] arr) {
        var m = new Dictionary<int, int>();
        foreach(var i in arr) {
            if(!m.ContainsKey(i)) {
                m.Add(i, 0);
            }
            m[i] += 1;
        }
        var s = new HashSet<int>();
        foreach(var p in m) {
            if(s.Contains(p.Value)) {
                return false;
            }
            s.Add(p.Value);
        }
        return true;
    }
}