public class Solution {
    public int[][] AllCellsDistOrder(int R, int C, int r0, int c0) {
        var result = new List<int[]>();
        for(var r = 0; r < R; ++r) {
            for(var c = 0; c < C; ++c) {
                result.Add(new int {
                    r, c
                });
            }
        }
        result.Sort((x, y) => {
            var distX = Math.Abs(x[0] - r0) + Math.Abs(x[1] - c0);
            var distY = Math.Abs(y[0] - r0) + Math.Abs(y[1] - c0);
            return distX - distY;
        });
        return result.ToArray();
    }
}