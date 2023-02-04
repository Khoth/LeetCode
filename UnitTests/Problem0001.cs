using Problems.Problem0001;

namespace UnitTests
{
    public class Problem0001
    {
        [Theory]
        [InlineData(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
        [InlineData(new int[] { 3, 2, 4 }, 6, new int[] { 1, 2 })]
        [InlineData(new int[] { 3, 3 }, 6, new int[] { 0, 1 })]
        public void TwoSum_Returns_ExpectedResult(int[] nums, int target, int[] expectedResult)
        {
            var solution = new Solution();
            var result = solution.TwoSum(nums, target);
            result.Should().BeEquivalentTo(expectedResult);
        }
    }
}