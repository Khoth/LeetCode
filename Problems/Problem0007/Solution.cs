namespace Problems.Problem0007
{
    public class Solution
    {
        public int Reverse(int x)
        {
            try
            {
                int.TryParse(string.Join("", Math.Abs(x).ToString().Reverse()), out int result);
                return x >= 0 ? result : -result;
            }
            catch
            {
                return 0;
            }
        }
    }
}
