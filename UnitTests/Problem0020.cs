using Problems.Problem0020;

namespace UnitTests
{
    public class Problem0020
    {
        [Theory]
        [InlineData("()", true)]
        [InlineData("()[]{}", true)]
        [InlineData("(]", false)]
        [InlineData("[", false)]
        [InlineData("}", false)]
        public void IsValid_Returns_ExpectedResult(string input, bool expectedResult)
        {
            var solution = new Solution();
            var result = solution.IsValid(input);
            result.Should().Be(expectedResult);
        }
    }
}
