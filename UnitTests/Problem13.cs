using Problem13;

namespace UnitTests
{
    public class Problem13
    {
        [Theory]
        [InlineData("III", 3)]
        [InlineData("LVIII", 58)]
        [InlineData("MCMXCIV", 1994)]
        [InlineData("IX", 9)]
        public void RomanToInt_Returns_ExpectedResult(string input, int expectedResult)
        {
            var solution = new Solution();
            var result = solution.RomanToInt(input);
            result.Should().Be(expectedResult);
        }
    }
}
