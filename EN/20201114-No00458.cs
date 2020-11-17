public class Solution {
    public int PoorPigs(int buckets, int minutesToDie, int minutesToTest) {
        var result = 0;
        while(Math.Pow((minutesToTest / minutesToDie + 1), pigs) < buckets) {
            result += 1;
        }
        return result;
    }
}