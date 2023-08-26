using SimpleCalculator;

var calculatorService = new CalculatorService();

var isFirstInputNumber = double.TryParse(Console.ReadLine(), out var firstNumber);
var isSecondInputNumber = double.TryParse(Console.ReadLine(), out var secondNumber);
var operation = Console.ReadLine();

if (isFirstInputNumber && isSecondInputNumber && !string.IsNullOrEmpty(operation))
{
    double result;

    switch(operation)
    {
        case "+":
            result = calculatorService.Add(firstNumber, secondNumber);
            break;
        
        case "-":
            result = calculatorService.Subtract(firstNumber, secondNumber);
            break;

        case "*":
            result = calculatorService.Multiply(firstNumber, secondNumber);
            break;

        case "/":
            result = calculatorService.Divide(firstNumber, secondNumber);
            break;

        default:
            throw new InvalidOperationException($"Invalid operation: {operation}");
    }

    Console.WriteLine(result);
}