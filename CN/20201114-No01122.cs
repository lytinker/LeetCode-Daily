public class Solution {
    public int[] RelativeSortArray(int[] arr1, int[] arr2) {
        var map = new Dictionary<int, List<int>>();
        foreach(var n in arr2) {
            map.Add(n, new List<int>());
        }
        map.Add(-1, new List<int>());
        foreach(var n in arr1) {
            if(map.ContainsKey(n)) {
                map[n].Add(n);
            } else {
                map[-1].Add(n);
            }
        }
        var result = new List<int>();
        foreach(var n in arr2) {
            result.AddRange(map[n]);
        }
        map[-1].Sort();
        result.AddRange(map[-1]);
        return result.ToArray();
    }
}