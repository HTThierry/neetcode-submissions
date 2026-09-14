public class Solution {
    public int LongestConsecutive(int[] nums) {
        if(nums.Length == 0)
            return 0;
        
        Array.Sort(nums);
        List<int> sNums = nums.ToList();
        sNums = sNums.Distinct().ToList();

        int ans = 1;
        int tempAns = 1;
        
        for(int i = 1; i < sNums.Count; i++)
        {
            if(i != 0 && sNums[i] == sNums[i-1])
                continue;
            
            if(sNums[i] == sNums[i-1] +1)
            {
                tempAns++;
                ans = Math.Max(ans, tempAns);
            }
            else
                tempAns = 1;
        }

        return ans;
    }
}
