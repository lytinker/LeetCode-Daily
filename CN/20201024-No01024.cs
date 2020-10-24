using System;

public class Solution {
    public int VideoStitching(int[][] clips, int T) {
        var maxRight = new int[T];
        for(var i = 0; i < clips.Length; ++i) {
            if(clips[i][0] < T) {
                maxRight[clips[i][0]] = Math.Max(maxRight[clips[i][0]], clips[i][1]);
            }
        }

        var result = 0;
        var prev = 0;
        var currentMax = 0;
        for(var i = 0; i < T; ++i) {
            currentMax = Math.Max(currentMax, maxRight[i]);
            if(currentMax == i) {
                return -1;
            }
            if(i == prev) {
                ++result;
                prev = currentMax;
            }
        }

        return result;
    }
}