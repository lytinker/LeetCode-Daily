public class Solution {
    public void Rotate(int[] nums, int k) {
        k = k % nums.Length;

        Reverse(nums, 0, nums.Length - 1);
        Reverse(nums, 0, k - 1);
        Reverse(nums, k, nums.Length - 1);
    }

    private void Reverse(int[] nums, int lo, int hi) {
        while(lo < hi) {
            var temp = nums[lo];
            nums[lo] = nums[hi];
            nums[hi] = temp;
            ++lo;
            --hi;
        }
    }
}