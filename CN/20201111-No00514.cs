public class Solution {
    private Dictionary<char, List<int>> _map;
    private Dictionary<KeyValuePair<int, int>, int> _memo;
    private string _key;
    private int _ringLength;

    public int FindRotateSteps(string ring, string key) {
        _key = key;
        _ringLength = ring.Length;
        _memo = new Dictionary<KeyValuePair<int, int>, int>();
        _map = new Dictionary<char, List<int>>();
        for(var i = 0; i < ring.Length; ++i) {
            var ch = ring[i];
            if(!_map.ContainsKey(ch)) {
                _map.Add(ch, new List<int>());
            }
            _map[ch].Add(i);
        }
        

        return Runner(0, 0);
    }

    public int Runner(int ringIndex, int keyIndex) {
        var kvp = new KeyValuePair<int, int>(ringIndex, keyIndex);
        if(_memo.TryGetValue(kvp, out var save)) {
            return save;
        }

        if(keyIndex >= _key.Length) {
            return 0;
        }

        var result = int.MaxValue;
        var ch = _key[keyIndex];
        var targetList = _map[ch];
        foreach(var targetIndex in targetList) {
            var distance = Math.Abs(ringIndex - targetIndex);
            distance = Math.Min(distance, _ringLength - distance);
            var newResult = distance + 1 + Runner(targetIndex, keyIndex + 1);
            if(newResult < result) {
                result = newResult;
            }
        }
        _memo.Add(kvp, result);
        return result;
    }
}