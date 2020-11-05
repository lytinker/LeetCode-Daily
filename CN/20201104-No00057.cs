using System;
using System.Collections.Generic;

public class Solution {
    public int[][] Insert(int[][] intervals, int[] newInterval) {
        var l = new List<KeyValuePair<int, int>>();
        var start = newInterval[0];
        var stop = newInterval[1];
        var p = 0;
        while(p < intervals.Length && intervals[p][1] < start) {
            l.Add(new KeyValuePair<int, int>(intervals[p][0], intervals[p][1]));
            ++p;
        }

        while(p < intervals.Length && intervals[p][0] <= stop) {
            start = Math.Min(intervals[p][0], start);
            stop = Math.Max(intervals[p][1], stop);
            ++p;
        }
        l.Add(new KeyValuePair<int, int>(start, stop));

        while(p < intervals.Length) {
            l.Add(new KeyValuePair<int, int>(intervals[p][0], intervals[p][1]));
            ++p;
        }

        var result = new int[l.Count][];
        for(var i = 0; i < l.Count; ++i) {
            result[i] = new int[] { l[i].Key, l[i].Value };
        }

        return result;
    }
}