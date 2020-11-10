public class Solution {
    public void NextPermutation(int[] nums) {
        if(nums.Length < 2) {
            return;
        }

        var p1 = -1;
        var p2 = -1;
        for(var i = nums.Length - 2; i >= 0; --i) {
            if(nums[i] < nums[i + 1]) {
                p1 = i;
                break;
            }
        }

        if(p1 < 0) {
            Reverse(nums, 0, nums.Length - 1);
        } else {
            for(var i = nums.Length - 1; i > p1; --i) {
                if(nums[i] > nums[p1]) {
                    p2 = i;
                    break;
                }
            }
            var temp = nums[p1];
            nums[p1] = nums[p2];
            nums[p2] = temp;
            Reverse(nums, p1 + 1, nums.Length - 1);
        }
    }

    public void Reverse(int[] nums, int lo, int hi) {
        while(lo < hi) {
            var temp = nums[lo];
            nums[lo] = nums[hi];
            nums[hi] = temp;
            ++lo;
            --hi;
        }
    }
}