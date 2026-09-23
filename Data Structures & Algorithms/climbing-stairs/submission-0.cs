public class Solution {
    public int ClimbStairs(int n) {
        if(n <= 2)
            return n;

        int s1 = 1;
        int s2 = 2;
        int res = 3;
        for(int i = 2; i < n; i++)
        {
            res = s1 + s2;
            s1 = s2;
            s2 = res;
        }

        return res;
    }
}
