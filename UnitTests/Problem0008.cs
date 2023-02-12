using Problems.Problem0008;

namespace UnitTests
{
    public class Problem0008
    {
        [Theory]
        [InlineData("42", 42)]
        [InlineData("   -42", -42)]
        [InlineData("4193 with words", 4193)]
        [InlineData("words and 987", 0)]
        [InlineData("-91283472332", int.MinValue)]
        public void MyAtoi_Returns_ExpectedResult(string input, int expectedResult)
        {
            var solution = new Solution();
            var result = solution.MyAtoi(input);
            result.Should().Be(expectedResult);
        }
    }
}
