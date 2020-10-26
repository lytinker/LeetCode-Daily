public class Solution {
    public int[] SmallerNumbersThanCurrent(int[] nums) {
        const int Upper = 100 + 10;
        var count = new int[Upper];
        for(var i = 0; i < nums.Length; ++i) {
            count[nums[i]] += 1;
        }
        var total = 0;
        for(var i = 0; i < Upper; ++i) {
            var c = count[i];
            count[i] = total;
            total += c;
        }
        var result = new int[nums.Length];
        for(var i = 0; i < nums.Length; ++i) {
            result[i] = count[nums[i]];
        }

        return result;
    }
}