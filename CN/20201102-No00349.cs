using System.Collections.Generic;

public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        var s = new HashSet<int>();
        var r = new HashSet<int>();
        foreach(var n in nums1) {
            s.Add(n);
        }
        foreach(var n in nums2) {
            if(s.Contains(n) && !r.Contains(n)) {
                r.Add(n);
            }
        }
        var result = new int[r.Count];
        r.CopyTo(result);
        return result;
    }
}