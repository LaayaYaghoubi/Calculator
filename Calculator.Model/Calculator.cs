using Calculator.Model.Exceptions;

namespace Calculator.Model;

public class Calculator
{
    public decimal Add(decimal first, decimal second)
    {
        return first + second;
    }

    public decimal Subtract(decimal first, decimal second)
    {
        if (first < second)
        {
            throw new FirstNumberShouldBeGreaterThanSecondNumber();
        }

        return first - second;
    }

    public decimal Divide(decimal firstNum, decimal secondNumber)
    {
        if (secondNumber == 0)
        {
            throw new SecondNumberCanNotBeZeroException();
        }

        if (secondNumber < 0)
        {
            throw new SecondNumberCanNotBeNegativeException();
        }

        return firstNum / secondNumber;
    }

    public string OddOrEven(decimal num)
    {
        var result = num % 2;
        if (result == 0)
        {
            return "Even";
        }
        else
        {
            return "Odd";
        }
    }

    public decimal Multiply(decimal firstNum, decimal secondNumber)
    {
        return firstNum * secondNumber;
    }
}