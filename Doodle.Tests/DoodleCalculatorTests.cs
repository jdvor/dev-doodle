namespace Doodle.Tests;

public class DoodleCalculatorTests
{
    [Theory]
    [InlineData(2, 5, 28)]
    [InlineData(0, 100, 10100)]
    public void Calculate(int from, int to, int expected)
    {
        var sut = new DoodleCalculator();
        var actual = sut.Calculate(from, to);
        Assert.Equal(expected, actual);
    }
}
