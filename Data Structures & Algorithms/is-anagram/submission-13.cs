public class Solution {
    public bool IsAnagram(string s, string t) {
        int l = s.Length;
        char[] arrayS = s.ToCharArray();
        char[] arrayT = t.ToCharArray();
        
        if(l != t.Length)
            return false;

        Array.Sort(arrayS);
        Array.Sort(arrayT);

        return arrayS.SequenceEqual(arrayT);
    }
}
