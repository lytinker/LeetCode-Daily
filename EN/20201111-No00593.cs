public class Solution {
    public bool ValidSquare(int[] p1, int[] p2, int[] p3, int[] p4) {
        var pList = new List<int[]> {
            p1, p2, p3, p4
        };
        var lList = new List<int>();
        for(var i = 0; i < 4; ++i) {
            for(var j = i + 1; j < 4; ++j) {
                lList.Add(Distance(pList[i], pList[j]));
            }
        }
        lList.Sort();
        return lList[0] > 0 &&
            lList[0] == lList[1] && 
            lList[0] == lList[2] && 
            lList[0] == lList[3] && 
            lList[4] == lList[5] &&
            lList[4] == 2 * lList[0]; 
    }

    public int Distance(int[] p1, int[] p2) {
        var dx = p1[0] - p2[0];
        var dy = p1[1] - p2[1];
        return dx * dx + dy * dy;
    }
}