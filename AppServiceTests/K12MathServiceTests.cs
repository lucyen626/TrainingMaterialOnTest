using AppService;
using Xunit;

namespace AppServiceTests;

public class K12MathServiceTests
{
    [Theory]
    [InlineData(1)]
    [InlineData(3)]
    [InlineData(5)]
    public void When_IsOdd_ProvideOddNumbers_Should_ReturnsTrue(int number)
    {
        var sut = new K12MathServiceImplementation();

        var result = sut.IsOdd(number);

        Assert.True(result);
    }

    [Theory]
    [InlineData(2)]
    [InlineData(4)]
    [InlineData(6)]
    public void When_IsOdd_ProvideEvenNumbers_Should_ReturnsFalse(int number)
    {
        var sut = new K12MathServiceImplementation();

        var result = sut.IsOdd(number);

        Assert.False(result);
    }

}
