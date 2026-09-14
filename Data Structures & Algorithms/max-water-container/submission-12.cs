public class Solution {
    public int MaxArea(int[] heights) {
        int i = 0;
        int j = heights.Length-1;

        int capacity = 0;
        while(i != j)
        {
            int h = Math.Min(heights[i], heights[j]);
            int l = Math.Abs(j - i);
            int a = h * l;
            capacity = a > capacity ? a : capacity;

            if(heights[i]<heights[j])
                i++;
            else
                j--;
        }
        return capacity;
    }
}
