public class Solution {
    private StringBuilder _sb;
    private string _s;
    private int _p;

    public string DecodeString(string s) {
        _s = s;
        _p = 0;

        return Parse();
    }

    private string Parse() {
        var sb = new StringBuilder();
        while(_p < _s.Length) {
            if(char.IsLetter(_s[_p])) {
                sb.Append(_s[_p]);
                ++_p;
            } else if(char.IsDigit(_s[_p])) {
                var repeat = 0;
                while(_s[_p] != '[') {
                    repeat *= 10;
                    repeat += _s[_p] - '0';
                    ++_p;
                }
                ++_p;
                var sub = Parse();
                ++_p;
                for(var i = 0; i < repeat; ++i) {
                    sb.Append(sub);
                }
            } else {
                break;
            }
        }

        return sb.ToString();
    }
}