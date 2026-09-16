public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int total = 1;
        int[] res = new int[nums.Length];
        int zeroCount = 0;
        foreach(int num in nums)
        {
            if(num != 0)
                total *= num;
            else
                zeroCount++;
        }

        if(zeroCount > 1)
            return res;


        for (int i = 0; i < nums.Length; i++)
        {
            if(nums[i] == 0)
                res[i] = total;
            else if(zeroCount != 0)
                res[i] = 0;
            else
                res[i] = total / nums[i];
        }
        return res;
    }
}
