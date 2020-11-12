public class Solution {
    public int[] SortArrayByParityII(int[] A) {
        var even = 0;
        var odd = 1;
        while(even < A.Length) {
            while(even < A.Length && A[even] % 2 == 0) {
                even += 2;
            }
            while(odd < A.Length && A[odd] % 2 == 1) {
                odd += 2;
            }
            if(even < A.Length && odd < A.Length) {
                var t = A[even];
                A[even] = A[odd];
                A[odd] = t;
            }
        }

        return A;
    }
}