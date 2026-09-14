public class Solution {
    public bool IsPalindrome(string s) {
        string newS = new String(Regex.Replace(s, "[^a-zA-Z0-9]", "").ToLower().ToCharArray());
        int i = 0;
        int j = newS.Length-1;
        for(int k = 0; k<newS.Length/2; k++)
        {
            if(newS[i] != newS[j])
                return false;
            
            i++;
            j--;
        }
        return true;
    }
}
