public class Solution {
    public IList<string> SummaryRanges(int[] nums) {
        var result = new List<string>();
        var head = long.MinValue;
        var tail = long.MinValue;
        foreach(var n in nums) {
            if(n != tail + 1) {
                if(head != long.MinValue) {
                    result.Add(head == tail ? $"{head}" : $"{head}->{tail}");
                }
                head = n;
                tail = n;
            } else {
                tail = n;
            }
        }
        if(head != long.MinValue) {
            result.Add(head == tail ? $"{head}" : $"{head}->{tail}");
        }
        return result;
    }
}