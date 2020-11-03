public class Solution {
    public int MaxPower(string s) {
        var ch = '\0';
        var length = 0;
        var result = 0;
        foreach(var c in s) {
            if(c == ch) {
                ++length;
            } else {
                if(length > result) {
                    result = length;
                }
                length = 1;
                ch = c;
            }
        }

        return Math.Max(result, length);
    }
}