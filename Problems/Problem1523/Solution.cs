namespace Problems.Problem1523
{
    public class Solution
    {
        public int CountOdds(int low, int high) =>
            (high - low) / 2 + (low % 2 | high % 2);
    }
}
