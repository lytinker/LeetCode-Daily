public class Solution {
    public void MoveZeroes(int[] nums) {
        for(var i = 0; i < nums.Length; ++i) {
            if(nums[i] == 0) {
                var p = i;
                while(p < nums.Length && nums[p] == 0) {
                    ++p;
                }

                if(p >= nums.Length) {
                    break;
                } else {
                    nums[i] = nums[p];
                    nums[p] = 0;
                }
            }
        }
    }
}