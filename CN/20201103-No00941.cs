public class Solution {
    public bool ValidMountainArray(int[] A) {
        if(A.Length < 3) {
            return false;
        }

        var max = int.MinValue;
        var maxIndex = -1;
        for(var i = 0; i < A.Length; ++i) {
            if(A[i] > max) {
                max = A[i];
                maxIndex = i;
            }
        }

        if(maxIndex == 0 || maxIndex == A.Length - 1) {
            return false;
        }

        for(var i = 0; i < maxIndex; ++i) {
            if(A[i] >= A[i + 1]) {
                return false;
            }
        }
        for(var i = maxIndex + 1; i < A.Length; ++i) {
            if(A[i] >= A[i - 1]) {
                return false;
            }
        }

        return true;
    }
}