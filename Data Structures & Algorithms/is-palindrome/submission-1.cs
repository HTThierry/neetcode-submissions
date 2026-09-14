public class Solution {
    public bool IsPalindrome(string s) {
        char[] arrayS = Regex.Replace(s, "[^a-zA-Z0-9]", "").ToLower().ToCharArray();
        int i = 0;
        int j = arrayS.Length-1;

        for(int k = 0; k<arrayS.Length/2; k++)
        {
            if(arrayS[i] != arrayS[j])
                return false;
            
            i++;
            j--;
        }
        return true;
    }
}
