using System;

public class Solution {
    public int BagOfTokensScore(int[] tokens, int P) {
        Array.Sort(tokens);
        var i = 0;
        var j = tokens.Length - 1;
        var score = 0;
        var result = 0;
        while(i <= j) {
            if(P >= tokens[i]) {
                P -= tokens[i];
                ++i;
                result = Math.Max(result, ++score);
            } else if(score > 0) {
                --score;
                P += tokens[j];
                --j;
            } else {
                break;
            }
        }

        return result;
    }
}