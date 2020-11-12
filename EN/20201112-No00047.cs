public class Solution {
    public IList<IList<int>> PermuteUnique(int[] nums) {
        Array.Sort(nums);
        var r = new List<IList<int>>();
        Recursion(new List<int>(nums), 0, r);
        return r;
    }

    public void Recursion(List<int> num, int i, List<IList<int>> res) {
        if(i == num.Count - 1) {
            res.Add(num);
            return;
        }

        for(var k = i; k < num.Count; k++) {
            if(i != k && num[i] == num[k]) {
                continue;
            }
            var t = num[i];
            num[i] = num[k];
            num[k] = t;
            Recursion(new List<int>(num), i + 1, res);
        }
    }
}