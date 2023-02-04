namespace Problems.Problem0013
{
    public class Solution
    {
        private readonly IReadOnlyDictionary<char, int> _symbolWeights = new Dictionary<char, int>
        {
            {'I', 1 },
            {'V', 5 },
            {'X', 10 },
            {'L', 50 },
            {'C', 100 },
            {'D', 500 },
            {'M', 1000 }
        };

        public int RomanToInt(string input)
        {
            var result = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (i < input.Length - 1 &&
                    (input[i] == 'I' && (input[i + 1] == 'V' || input[i + 1] == 'X') ||
                     input[i] == 'X' && (input[i + 1] == 'L' || input[i + 1] == 'C') ||
                     input[i] == 'C' && (input[i + 1] == 'D' || input[i + 1] == 'M')))
                {
                    result -= _symbolWeights[input[i]];
                }
                else
                {
                    result += _symbolWeights[input[i]];
                }
            }

            return result;
        }
    }
}