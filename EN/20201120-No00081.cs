public class Solution {
    public bool Search(int[] nums, int target) {
        var pivot = 0;
        for(var i = 1; i < nums.Length; ++i) {
            if(nums[i] < nums[i - 1]) {
                pivot = i;
                break;
            }
        }

        var lo = 0;
        var hi = nums.Length;
        while(lo < hi) {
            var mid = (lo + hi) / 2;
            if(arr[(mid + pivot) % nums.Length] > target) {
                hi = mid;
            } else {
                lo = mid + 1;
            }
        }

        return nums[hi - 1] == target;
    }
}