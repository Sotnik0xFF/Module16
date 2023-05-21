using Module16.Application;
using NUnit.Framework;

namespace Module16.Tests;

[TestFixture, Parallelizable]
public class CalculatorTests
{
    private Calculator? _calculator;

    [SetUp]
    public void Init()
    {
        _calculator = new Calculator();
    }

    [Test]
    public void Additional_MustReturnCorrectValue()
    {
        Assert.True(_calculator!.Additional(10, 20) == 30);
    }

    [Test]
    public void Subtraction_MustReturnCorrectValue()
    {
        Assert.True(_calculator!.Subtraction(3, 2) == 1);
    }

    [Test]
    public void Multiplication_MustReturnCorrectValue()
    {
        Assert.True(_calculator!.Multiplication(3, 2) == 6);
    }

    [Test]
    public void Division_MustReturnCorrectValue()
    {
        Assert.True(_calculator!.Division(10, 2) == 5);
    }

    [Test]
    public void Division_MustThrowDivideByZeroException()
    {
        Assert.Throws<DivideByZeroException>(() => _calculator!.Division(10, 0));
    }
}