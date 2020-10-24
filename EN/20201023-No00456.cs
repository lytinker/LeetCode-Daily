public class Solution {
    public bool Find132pattern(int[] nums) {
        var s3 = int.MinValue;
        var s = new Stack<int>();
        for(var i = nums.Length - 1; i >= 0; --i) {
            if(nums[i] < s3) {
                return true;
            }
            while(s.Count > 0 && nums[i] > s.Peek()) {
                s3 = s.Pop();
            }
            s.Push(nums[i]);
        }

        return false;
    }
}