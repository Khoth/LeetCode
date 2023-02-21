using Problems.Problem0540;

namespace UnitTests
{
    public class Problem0540
    {
        [Theory]
        [InlineData(new[] { 1, 1, 2, 3, 3, 4, 4, 8, 8 }, 2)]
        [InlineData(new[] { 3, 3, 7, 7, 10, 11, 11 }, 10)]
        [InlineData(new[] { 1 }, 1)]
        [InlineData(new[] { 1, 1, 2 }, 2)]
        public void SingleNonDuplicate_Returns_ExpectedResult(int[] nums, int expectedResult)
        {
            var solution = new Solution();
            var result = solution.SingleNonDuplicate(nums);
            result.Should().Be(expectedResult);
        }
    }
}
