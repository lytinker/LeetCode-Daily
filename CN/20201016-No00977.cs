public class Solution {
    public int[] SortedSquares(int[] A) {
        var result = new int[A.Length];
        var lo = 0;
        var hi = A.Length - 1;
        var p = A.Length - 1;
        while(lo <= hi) {
            if(Math.Abs(A[lo]) <= Math.Abs(A[hi])) {
                result[p--] = A[hi] * A[hi];
                --hi;
            } else {
                result[p--] = A[lo] * A[lo];
                ++lo;
            }
        }

        return result;
    }
}