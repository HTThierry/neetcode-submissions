public class Solution {
    public int MaxProfit(int[] prices) {
        int l = 0, r = 1, ans = 0;

        while(r < prices.Length)
        {
            if(prices[l] < prices[r])
            {
                int profit = prices[r] - prices[l];
                ans = Math.Max(profit, ans);
            }
            else
                l = r;
            r++;
        }
        
        return ans;
    }
}
