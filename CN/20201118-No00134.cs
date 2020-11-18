public class Solution {
    public int CanCompleteCircuit(int[] gas, int[] cost) {
        var save = new List<int>();
        for(var i = 0; i < gas.Length; ++i) {
            save.Add(gas[i] - cost[i]);
        }

        var prefix = 0;
        var current = 0;
        var start = 0;
        for(var i = 0; i < save.Count; ++i) {
            current += save[i];
            if(current < 0) {
                prefix += current;
                current = 0;
                start = i + 1;
            }
        }
        if(start >= save.Count) {
            return -1;
        } else if(current < -prefix) {
            return -1;
        } else {
            return start;
        }
    }
}