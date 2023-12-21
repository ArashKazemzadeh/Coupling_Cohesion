namespace Design.Coupling.ControlCoupling;
public class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }
    public int Subtract(int a, int b)
    {
        return a - b;
    }
}

public class CalculatorClient
{
    private Calculator _calculator;
    public CalculatorClient() => _calculator = new Calculator();
    public int PerformOperation(string operation, int a, int b)
    {
        int result = 0;

        switch (operation)
        {
            case "add":
                result = _calculator.Add(a, b);
                break;
            case "subtract":
                result = _calculator.Subtract(a, b);
                break;
                // More cases for other operations...
        }

        return result;
    }

}


public class Program
{
    public void Main(string[] args)
    {
        CalculatorClient client = new CalculatorClient();

        int a = 10;
        int b = 5;

        int additionResult = client.PerformOperation("add", a, b);
        Console.WriteLine($"Addition result: {additionResult}");

        int subtractionResult = client.PerformOperation("subtract", a, b);
        Console.WriteLine($"Subtraction result: {subtractionResult}");
    }
}