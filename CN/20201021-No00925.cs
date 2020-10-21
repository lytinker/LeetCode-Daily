public class Solution {
    public bool IsLongPressedName(string name, string typed) {
        var pName = 0;
        var pType = 0;
        var prevCh = char.MinValue;
        while(pName < name.Length && pType < typed.Length) {
            if(name[pName] != typed[pType]) {
                if(pType <= 0) {
                    return false;
                }
                while(pType < typed.Length && typed[pType] == prevCh) {
                    ++pType;
                }
                if(pType >= typed.Length || name[pName] != typed[pType]) {
                    return false;
                }
            }
            
            prevCh = name[pName];
            ++pName;
            ++pType;
        }

        while(pType < typed.Length && typed[pType] == prevCh) {
            ++pType;
        }

        return pName == name.Length && pType == typed.Length;
    }
}