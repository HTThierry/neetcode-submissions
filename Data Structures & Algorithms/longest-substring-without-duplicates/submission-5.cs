public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if(s.Length == 0)
            return 0;
        
        int l = 0, maxL = 0;
        Dictionary<char, int> map = new Dictionary<char, int>();
        for(int r = 0; r < s.Length; r++)
        {
            if(map.ContainsKey(s[r]))
            {
                l = Math.Max(l, map[s[r]]+1);
            }
            map[s[r]] = r;
            maxL = Math.Max(maxL, r-l+1);
        }
        return maxL;
    }
}
