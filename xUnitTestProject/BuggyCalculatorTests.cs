using Xunit;

namespace xUnitTestProject;

public class BuggyCalculatorTests
{

    
    [Fact]
    public void When_Add_TwoNumbers_Success()
    {
        // arrange
        var sut = new BuggyCalculator();

        // act
        var result = sut.Add(1, 2);

        // assert
        Assert.Equal(3, result);
    }

    [Fact]
    public void When_Subtract_TwoNumbers_Success()
    {
        var sut = new BuggyCalculator();

        var result = sut.Subtract(2, 1);

        Assert.Equal(1, result);
    }

    [Fact]
    public void When_Multiply_TwoNumbers_Success()
    {
        var sut = new BuggyCalculator();

        var result = sut.Multiply(4, 2);

        Assert.Equal(8, result);
    }

    [Fact]
    public void When_Divide_TwoNumbers_Success()
    {
        var sut = new BuggyCalculator();

        var result = sut.Divide(4, 2);

        Assert.Equal(2, result);
    }
}
