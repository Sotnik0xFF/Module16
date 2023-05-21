using Module16.Application;
using NUnit.Framework;

namespace Module16.Tests;

[TestFixture]
public class CalculatorTests
{
    [Test]
    public void Additional_MustReturnCorrectValue()
    {
        Calculator calculator = new Calculator();
        Assert.True(calculator.Additional(10, 20) == 30);
    }

    [Test]
    public void Subtraction_MustReturnCorrectValue()
    {
        Calculator calculator = new Calculator();
        Assert.True(calculator.Subtraction(3, 2) == 1);
    }

    [Test]
    public void Multiplication_MustReturnCorrectValue()
    {
        Calculator calculator = new Calculator();
        Assert.True(calculator.Multiplication(3, 2) == 6);
    }

    [Test]
    public void Division_MustReturnCorrectValue()
    {
        Calculator calculator = new Calculator();
        Assert.True(calculator.Division(10, 2) == 5);
    }

    [Test]
    public void Division_MustThrowDivideByZeroException()
    {
        Calculator calculator = new Calculator();
        Assert.Throws<DivideByZeroException>(() => calculator.Division(10, 0));
    }
}