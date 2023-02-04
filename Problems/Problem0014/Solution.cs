namespace Problems.Problem0014
{
    public class Solution
    {
        public string LongestCommonPrefix(string[] strs)
        {
            var maxLength = strs.Min(x => x.Length);

            for (int i = 0; i < maxLength; i++)
            {
                if (strs.Any(x => x[i] != strs.First()[i]))
                {
                    return strs.First()[..i];
                }
            }

            return strs.First()[..maxLength];
        }
    }
}