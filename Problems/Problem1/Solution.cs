namespace Problem1
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var result = new int[2];

            for (int i = 0; i < nums.Length - 1; i++)
            {
                result[0] = i;

                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[result[0]] + nums[j] == target)
                    {
                        result[1] = j;
                        return result;
                    }
                }
            }

            return Array.Empty<int>();
        }
    }
}