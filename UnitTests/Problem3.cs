using Problem3;

namespace UnitTests
{
    public class Problem3
    {
        [Theory]
        [InlineData("abcabcbb", 3)]
        [InlineData("bbbbb", 1)]
        [InlineData("pwwkew", 3)]
        public void LengthOfLongestSubstring_Returns_ExpectedResult(string input, int expectedResult)
        {
            var solution = new Solution();
            var result = solution.LengthOfLongestSubstring(input);
            result.Should().Be(expectedResult);
        }
    }
}