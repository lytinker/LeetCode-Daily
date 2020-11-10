public class Solution {
    public int[][] FlipAndInvertImage(int[][] A) {
        if(A.Length <= 0 || A[0].Length <= 0) {
            return A;
        }

        var row = A.Length;
        var col = A[0].Length;
        for(var i = 0; i < row; ++i) {
            var p1 = 0;
            var p2 = col - 1;
            while(p1 <= p2) {
                if(A[i][p1] == A[i][p2]) {
                    var n = A[i][p1];
                    A[i][p1] = 1 - n;
                    A[i][p2] = 1 - n;
                }
                ++p1;
                --p2;
            }
        }

        return A;
    }
}