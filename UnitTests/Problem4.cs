using Problem4;

namespace UnitTests
{
    public class Problem4
    {
        [Theory]
        [InlineData(new int[] { 1, 3 }, new int[] { 2 }, 2)]
        [InlineData(new int[] { 1, 2 }, new int[] { 3, 4 }, 2.5)]
        public void FindMedianSortedArrays_Returns_ExpectedResult(int[] array1, int[] array2, double expectedResult)
        {
            var solution = new Solution();
            var result = solution.FindMedianSortedArrays(array1, array2);
            result.Should().Be(expectedResult);
        }
    }
}