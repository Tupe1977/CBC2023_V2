using Xunit;

public class CalculatorTests
{
    [Fact]
    public void TestAddition()
    {
        // Arrange
        int x = 5;
        int y = 6;
        int expectedResult = x + y;

        // Act
        int result = Calculator.Addition(x, y);

        // Assert
        Assert.Equal(expectedResult, result);
    }
}
