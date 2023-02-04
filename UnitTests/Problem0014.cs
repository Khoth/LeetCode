using Problems.Problem0014;

namespace UnitTests
{
    public class Problem0014
    {
        [Theory]
        [InlineData(new[] { "flower", "flow", "flight" }, "fl")]
        [InlineData(new[] { "dog", "racecar", "car" }, "")]
        [InlineData(new[] { "a" }, "a")]
        public void LongestCommonPrefix_Returns_ExpectedResult(string[] strs, string expectedResult)
        {
            var solution = new Solution();
            var result = solution.LongestCommonPrefix(strs);
            result.Should().Be(expectedResult);
        }
    }
}
