using Problems.Problem1470;

namespace UnitTests
{
    public class Problem1470
    {
        [Theory]
        [InlineData(new[] { 2, 5, 1, 3, 4, 7 }, 3, new[] { 2, 3, 5, 4, 1, 7 })]
        [InlineData(new[] { 1, 2, 3, 4, 4, 3, 2, 1 }, 4, new[] { 1, 4, 2, 3, 3, 2, 4, 1 })]
        [InlineData(new[] { 1, 1, 2, 2 }, 2, new[] { 1, 2, 1, 2 })]
        public void Shuffle_Returns_ExpectedResult(int[] nums, int n, int[] expectedResult)
        {
            var solution = new Solution();
            var result = solution.Shuffle(nums, n);
            result.Should().BeEquivalentTo(expectedResult, options => options.WithStrictOrdering());
        }
    }
}