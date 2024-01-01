using Calculator.Services;

ImplementationCalculator calculator = new ImplementationCalculator();

int num1 = 10, num2 = 5;


Console.WriteLine($"{num1} + {num2} = {calculator.Sum(num1, num2)}");
