using System.Collections.Generic;

public class Solution {
    public int[] AsteroidCollision(int[] asteroids) {
        var s = new Stack<int>();
        for(var i = 0; i < asteroids.Length; ++i) {
            var e = asteroids[i];
            while(s.Count > 0) {
                var top = s.Peek();
                if(top > 0 && e < 0) {
                    if(-e >= top) {
                        s.Pop();
                    }
                    
                    if(-e <= top) {
                        e = 0;
                        break;
                    }
                } else {
                    break;
                }
            }
            
            if(e != 0) {
                s.Push(e);
            }
        }

        var result = s.ToArray();
        Array.Reverse(result);
        return result;
    }
}