using Problem9;

namespace UnitTests
{
    public class Problem9
    {
        [Theory]
        [InlineData(121, true)]
        [InlineData(-121, false)]
        [InlineData(10, false)]
        public void IsPalindrome_Returns_ExpectedResult(int input, bool expectedResult)
        {
            var solution = new Solution();
            var result = solution.IsPalindrome(input);
            result.Should().Be(expectedResult);
        }
    }
}