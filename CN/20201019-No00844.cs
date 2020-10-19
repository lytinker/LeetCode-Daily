using System.Collections.Generic;

public class Solution {
    public bool BackspaceCompare(string S, string T) {
        return Solve(S) == Solve(T);
    }

    private string Solve(string s) {
        var cs = new Stack<char>();
        foreach(var ch in s) {
            if(ch == '#') {
                if(cs.Count > 0) {
                    cs.Pop();
                }
            } else {
                cs.Push(ch);
            }
        }
        return new string(cs.ToArray());
    }
}