public class Solution {
    public bool hasDuplicate(int[] nums) {
        List<int> unique = new List<int>();

        foreach(int num in nums)
        {
            if(unique.Contains(num))
                return true;
            else
                unique.Add(num);
        }
        return false;
    }
}