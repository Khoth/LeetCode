using Problems.Problem0007;

namespace UnitTests
{
    public class Problem0007
    {
        [Theory]
        [InlineData(123, 321)]
        [InlineData(-123, -321)]
        [InlineData(120, 21)]
        public void Reverse_Returns_ExpectedResult(int input, int expectedResult)
        {
            var solution = new Solution();
            var result = solution.Reverse(input);
            result.Should().Be(expectedResult);
        }
    }
}
