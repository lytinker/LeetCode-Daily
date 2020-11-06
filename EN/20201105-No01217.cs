public class Solution {
    public int MinCostToMoveChips(int[] position) {
        var odd = 0;
        var even = 0;
        foreach(var p in position) {
            if(p % 2 == 0) {
                ++even;
            } else {
                ++odd;
            }
        }
        return Math.Min(odd, even);
    }
}