namespace Problems.Problem0020
{
    public class Solution
    {
        private readonly HashSet<(char Open, char Close)> _bracketOpenClosePairs = new()
        {
            ('(', ')'),
            ('[', ']'),
            ('{', '}'),
        };

        public bool IsValid(string s)
        {
            var brackets = new Stack<char>();

            foreach (char c in s)
            {
                if (_bracketOpenClosePairs.Any(x => x.Open == c))
                {
                    brackets.Push(c);
                }
                else
                {
                    if (!brackets.TryPop(out char lastOpenBracket) ||
                        lastOpenBracket != _bracketOpenClosePairs.First(x => x.Close == c).Open)
                    {
                        return false;
                    }
                }
            }

            return brackets.Count == 0;
        }
    }
}
