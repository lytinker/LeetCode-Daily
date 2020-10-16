public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        if(matrix.Length <= 0 || matrix[0].Length <= 0) {
            return false;
        }
        
        var rowNum = SearchRow(matrix, target);
        if(rowNum < 0) {
            return false;
        }

        var row = matrix[rowNum];
        var colNum = SearchCol(row, target);

        return row[colNum] == target;
    }

    private int SearchRow(int[][] matrix, int target) {
        var lo = 0;
        var hi = matrix.Length;
        while(lo < hi) {
            var mid = (lo + hi) / 2;
            if(matrix[mid][0] > target) {
                hi = mid;
            } else {
                lo = mid + 1;
            }
        }

        return hi - 1;
    }

    private int SearchCol(int[] arr, int target) {
        var lo = 0;
        var hi = arr.Length;
        while(lo < hi) {
            var mid = (lo + hi) / 2;
            if(arr[mid] > target) {
                hi = mid;
            } else {
                lo = mid + 1;
            }
        }

        return hi - 1;
    }
}