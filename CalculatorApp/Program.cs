if (args.Length != 2)
{
    Console.WriteLine("Usage: CalculatorApp <number1> <number2>");
    return;
}

if (double.TryParse(args[0], out double num1) && double.TryParse(args[1], out double num2))
{
    Calculator calculator = Calculator.GetCalculator();
    double sum = calculator.Add(num1, num2);
    Console.WriteLine($"Sum: {sum}");
}
else
{
    Console.WriteLine("Invalid input. Please enter valid numbers.");
}