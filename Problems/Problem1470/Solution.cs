namespace Problems.Problem1470
{
    public class Solution
    {
        public int[] Shuffle(int[] nums, int n)
        {
            var result = new int[n * 2];
            for (int i = 0; i < n * 2; i++)
                result[i] = nums[i / 2 + (i % 2 == 0 ? 0 : n)];
            return result;
        }
    }
}
