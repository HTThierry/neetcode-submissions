public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        Dictionary<int,int> map = new Dictionary<int,int>();

        for(int i=0; i < numbers.Length; i++)
        {
            int complement = target - numbers[i];

            if(map.ContainsKey(complement))
                return [map[complement]+1, i+1];
            else
            {
                if(map.ContainsKey(numbers[i]))
                    continue;
                map.Add(numbers[i], i);
            }
        }

        return null;
    }
}
