using System;

public class Solution {
    public double ChampagneTower(int poured, int query_row, int query_glass) {
        var result = new double[query_row + 1, query_row + 1];
        result[0, 0] = poured;
        for(var row = 1; row <= query_row; ++row) {
            for(var col = 0; col < row; ++col) {
                result[row, col] += Math.Max(0.0, (result[row - 1, col] - 1.0) / 2);
                result[row, col + 1] += Math.Max(0.0, (result[row - 1, col] - 1.0) / 2);
            }
        }
        return Math.Min(1.0, result[query_row, query_glass]);
    }
}