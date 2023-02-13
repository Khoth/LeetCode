using Problems.Problem1523;

namespace UnitTests
{
    public class Problem1523
    {
        [Theory]
        [InlineData(3, 7, 3)]
        [InlineData(8, 10, 1)]
        [InlineData(14, 17, 2)]
        public void CountOdds_Returns_ExpectedResult(int low, int high, int expectedResult)
        {
            var solution = new Solution();
            var result = solution.CountOdds(low, high);
            result.Should().Be(expectedResult);
        }
    }
}
