using Xunit;

namespace InnerCycle
{
    public class BuggyCalculatorTests
    {
        [Fact]
        public void When_Substract_TwoNumbers_Success()
        {
            var sut = new BuggyCalculator();

            int result = sut.Substract(2, 1);

            Assert.Equal(1, result);
        }

        [Fact]
        public void When_Substract_And_SecondNumberGreaterThanFirstOne_ShouldReturnZero()
        {
            var sut = new BuggyCalculator();

            int result = sut.Substract(1, 2);

            Assert.Equal(0, result);
        }
    }
}