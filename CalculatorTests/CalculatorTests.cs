using Calculator.Services;

namespace CalculatorTests;

public class CalculatorTests
{
    private ImplementationCalculator _calc;

    public CalculatorTests()
    {
        _calc = new ImplementationCalculator();
    }

    [Fact] // precisamos usar o [Fact] para o XUnit considerar o método abaixo como teste
    public void YouMustSumTwoNumbersAndReturnTheSum()
    {
        // arrange - as informações para o teste
        int num1 = 10, num2 = 5;

        // act - a execução do teste
        int result = _calc.Sum(num1, num2);

        // assert - a verifcação do resultado do teste
        Assert.Equal(15, result);
        // (esperando, valor obtido)
    }

    [Fact]
    public void YouMustSubtractTwoNumbersAndReturnTheSubtraction()
    {
        int num1 = 10, num2 = 5;
        int result = _calc.Subtract(num1, num2);
        Assert.Equal(5, result);
    }

    [Fact]
    public void YouMustMultiplyTwoNumbersAndReturnTheMultiplication()
    {
        int num1 = 10, num2 = 5;
        int result = _calc.Multiply(num1, num2);
        Assert.Equal(50, result);
    }

    [Fact]
    public void YouMustDivideTwoNumbersAndReturnTheDivision()
    {
        int num1 = 10, num2 = 5;
        double result = _calc.Divide(num1, num2);
        Assert.Equal(2, result);
    }
}
