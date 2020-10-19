using System;

public class Solution {
    public int MinDominoRotations(int[] A, int[] B) {
        var aSolve = Solve(A[0], A, B);
        var bSolve = Solve(B[0], A, B);
        if(aSolve == int.MaxValue && bSolve == int.MaxValue) {
            return -1;
        }

        return Math.Min(aSolve, bSolve);
    }

    private int Solve(int num, int[] A, int[] B) {
        var aCount = 0;
        var bCount = 0;

        for(var i = 0; i < A.Length; ++i) {
            if(A[i] != num && B[i] != num) {
                return int.MaxValue;
            }
            if(A[i] == num) {
                ++aCount;
            }
            if(B[i] == num) {
                ++bCount;
            }
        }

        return Math.Min(A.Length - aCount, A.Length - bCount);
    }
}