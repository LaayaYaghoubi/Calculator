using Calculator.Model.Exceptions;
using FluentAssertions;

namespace Calculator.Unit.Tests;

public class CalculatorTests
{
    [Theory]
    [InlineData(0,0,0)]
    [InlineData(0,-3,3)]
    [InlineData(5,3,2)]
    public void Add_adds_two_number_properly(
        decimal expected,
        decimal firstNum,
        decimal secondNum)
    {
        //arrange
        var calculator = new Model.Calculator();

        //act
        var actual = calculator.Add(firstNum, secondNum);

        //assert
        actual.Should().Be(expected);
    }

    [Fact]
    public void Subtract_subtracts_two_number_properly()
    {
        //arrange
        var firstNum = 10;
        var secondNum = 5;
        var expected = 5;
        var calculator = new Model.Calculator();

        //act
        var actual = calculator.Subtract(firstNum, secondNum);

        //assert
        actual.Should().Be(expected);
    }

    [Fact]
    public void
        Subtract_throws_Exception_when_second_number_is_greater_than_first_number()
    {
        var firstNum = 5;
        var secondNum = 10;
        var calculator = new Model.Calculator();

        var actual = () => calculator.Subtract(firstNum, secondNum);

        actual.Should()
            .ThrowExactly<FirstNumberShouldBeGreaterThanSecondNumber>();
    }

    [Fact]
    public void Divide_divides_two_number_properly()
    {
        //arrange
        var firstNum = 10;
        var secondNumber = 5;
        var expected = 2;
        var calulator = new Model.Calculator();

        //act
        var actual = calulator.Divide(firstNum, secondNumber);

        //assert
        actual.Should().Be(expected);
    }

    [Fact]
    public void
        Divide_throws_SecondNumberCanNotBeZero_when_second_number_is_zero()
    {
        //arrange
        var firstNum = 10;
        var secondNumber = 0;
        var calculator = new Model.Calculator();

        //act
        var actual = () => calculator.Divide(firstNum, secondNumber);

        //assert
        actual.Should().ThrowExactly<SecondNumberCanNotBeZeroException>();
    }
    
    [Fact]
    public void
        Divide_throws_SecondNumberCanNotBeNegativeException_when_second_number_is_zero()
    {
        //arrange
        var firstNum = 10;
        var secondNumber = -3;
        var calculator = new Model.Calculator();

        //act
        var actual = () => calculator.Divide(firstNum, secondNumber);

        //assert
        actual.Should().ThrowExactly<SecondNumberCanNotBeNegativeException>();
    }

    [Theory]
    [InlineData("Even", 2)]
    [InlineData("Odd", 1)]
    public void OddOrEven_returns_num_type(string expected, decimal num)
    {
        var calculator = new Model.Calculator();

       string actual = calculator.OddOrEven(num);

       actual.Should().Be(expected);
    }

    [Fact]
    public void Multiply_Multiplies_two_number_properly()
    {
        //arrange
        var firstNum = 5;
        var secondNumber = 2;
        var expected = 10;
        var calulator = new Model.Calculator();

        //act
        var actual = calulator.Multiply(firstNum, secondNumber);

        //assert
        actual.Should().Be(expected);
    }
}