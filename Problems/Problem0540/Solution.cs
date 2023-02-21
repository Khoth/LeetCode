namespace Problems.Problem0540
{
    public class Solution
    {
        public int SingleNonDuplicate(int[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }

            int currentCount = 1;
            int current = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] == current)
                {
                    currentCount++;
                }
                else
                {
                    if (currentCount == 1)
                    {
                        return current;
                    }

                    currentCount = 1;
                    current = nums[i];
                }
            }
            
            return currentCount == 1 ? current : 0;
        }
    }
}
