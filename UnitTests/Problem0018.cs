using Problems.Problem0018;

namespace UnitTests
{
    public class Problem0018
    {
        public static IEnumerable<object[]> TestData = new List<object[]>
        {
            new object[] { new int[]{ 1, 0, -1, 0, -2, 2 }, 0, new int[][] { new int[] { -2, -1, 1, 2 }, new int[] { -2, 0, 0, 2 }, new int[] { -1, 0, 0, 1 } } },
            new object[] { Enumerable.Repeat(2, 5).ToArray(), 8, new int[][] { new int[] { 2, 2, 2, 2 } } },
            new object[] { new int[]{ -5, 5, 4, -3, 0, 0, 4, -2 }, 4, new int[][] { new int[] { -5, 0, 4, 5 }, new int[] { -3, -2, 4, 5 } } },
            new object[] { Enumerable.Repeat(2, 200).ToArray(), 8, new int[][] { new int[] { 2, 2, 2, 2 } } },
            new object[] { new int[]{ 0 }, 0, Array.Empty<int[]>() },
            new object[] { new int[] { 1000000000, 1000000000, 1000000000, 1000000000 }, -294967296, Array.Empty<int[]>() },
            new object[] { new int[] { -1000000000, -1000000000, 1000000000, -1000000000, -1000000000 }, 294967296, Array.Empty<int[]>() },
            new object[] { new int[]{ 0, 0, 0, 0 }, 1, Array.Empty<int[]>() },
        };

        [Theory]
        [MemberData(nameof(TestData))]
        public void FourSum_Returns_ExpectedResult(int[] nums, int target, IList<IList<int>> expectedResult)
        {
            var solution = new Solution();
            var result = solution.FourSum(nums, target);
            result.Should().BeEquivalentTo(expectedResult);
        }
    }
}
