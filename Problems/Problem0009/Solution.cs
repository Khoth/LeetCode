namespace Problems.Problem0009
{
    public class Solution
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0)
            {
                return false;
            }

            var inputString = x.ToString();

            for (int i = 0; i < inputString.Length / 2; i++)
            {
                if (inputString[i] != inputString[inputString.Length - 1 - i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}