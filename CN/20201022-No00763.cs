public class Solution {
    public IList<int> PartitionLabels(string S) {
        var lastCh = new int[26];
        for(var i = 0; i < S.Length; ++i) {
            lastCh[S[i] - 'a'] = i;
        }
        var result = new List<int>();
        var start = -1;
        var stop = -1;
        for(var i = 0; i < S.Length; ++i) {
            var newStop = lastCh[S[i] - 'a'];
            if(newStop > stop) {
                stop = newStop;
            }
            if(stop == i) {
                result.Add(stop - start);
                start = stop;
            }
        }
        return result;
    }
}