public class Solution {
    public int SmallestDivisor(int[] nums, int threshold) {
        var lo = 1;
        var hi = 1000000;
        while(lo < hi) {
            var mid = (lo + hi) / 2;
            var sum = 0;
            foreach(var n in nums) {
                sum += (int)Math.Ceiling((double)n / mid);
            }
            if(sum > threshold) {
                lo = mid + 1;
            } else {
                hi = mid;
            }
        }

        return lo;
    }
}