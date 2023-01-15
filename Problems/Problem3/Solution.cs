namespace Problem3
{
    public class Solution
    {
        public int LengthOfLongestSubstring(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return 0;
            }

            var uniqueLetters = new HashSet<char>();
            var result = 0;
            var currentResult = 0;

            for (int i = 0; i < s.Length; i++)
            {
                for (int j = i; j < s.Length; j++)
                {
                    if (uniqueLetters.Contains(s[j]))
                    {
                        break;
                    }
                    else
                    {
                        uniqueLetters.Add(s[j]);
                        currentResult++;
                    }
                }

                if (currentResult > result)
                {
                    result = currentResult;
                }

                currentResult = 0;
                uniqueLetters.Clear();
            }

            return result;
        }
    }
}