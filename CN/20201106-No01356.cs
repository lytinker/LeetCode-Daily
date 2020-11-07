public class Solution {
    public int[] SortByBits(int[] arr) {
        Array.Sort(arr, new BitComparer());
        return arr;
    }
}

public class BitComparer: IComparer<int> {
    public int Compare(int x, int y) {
        var xBit = CountBit(x);
        var yBit = CountBit(y);
        return xBit == yBit ? x - y : xBit - yBit;
    }

    private int CountBit(int x) {
        var result = 0;
        while(x > 0) {
            result += x & 1;
            x >>= 1;
        }

        return result;
    }
}