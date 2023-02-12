using System.Text.RegularExpressions;

namespace Problems.Problem0008
{
    public class Solution
    {
        public int MyAtoi(string s)
        {
            var match = Regex.Match(s, "^\\s*(\\+|\\-)?\\d+");

            if (!match.Success)
            {
                return 0;
            }

            try
            {
                return int.Parse(match.Value);
            }
            catch
            {
                return match.Value.Contains('-')
                    ? int.MinValue
                    : int.MaxValue;
            }
        }
    }
}
