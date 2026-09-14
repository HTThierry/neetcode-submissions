public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> ans = new Dictionary<string, List<string>>();

       foreach(string s in strs)
       {
        char[] sort = s.ToCharArray();
        Array.Sort(sort);
        string sortString = new string(sort);
        if(!ans.ContainsKey(sortString))
        {
            ans[sortString] = new List<string>();
        }
        ans[sortString].Add(s);
       }

        return ans.Values.ToList();
    }
}
