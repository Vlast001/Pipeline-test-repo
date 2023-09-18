using Xunit;

public class CalculatorTests
{
    [Fact]
    public void TestAddition()
    {
        // Arrange
        Calculator calculator = Calculator.GetCalculator();

        // Act
        double result = calculator.Add(2, 3);

        // Assert
        Assert.Equal(5, result);
    }
}