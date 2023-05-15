using AmazingCalculator;
using FluentAssertions;
using Xunit;

namespace AmazingCalculator.Tests.Unit;

public class IntCalculatorTests
{
    [Fact]
    public void Add_ShouldAddTwoIntegers_WhenBothArePositive()
    {
        // Arrange
        var sut = new IntCalculator();
        
        // Act
        var result = sut.Add(1, 2);
        
        // Assert
        result.Should().Be(3);
    }
}
