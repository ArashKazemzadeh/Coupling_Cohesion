namespace Design.Cohesion.FunctionalCohesion;

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

    public int Multiply(int a, int b)
    {
        return a * b;
    }

    public int Divide(int a, int b)
    {
        if (b != 0)
        {
            return a / b;
        }
        else
        {
            throw new DivideByZeroException("Cannot divide by zero.");
        }
    }
}

public class Program
{
    static void Main(string[] args)
    {
        Calculator calculator = new Calculator();

        int result = calculator.Add(5, 3);
        Console.WriteLine("Addition: " + result);

        result = calculator.Subtract(5, 3);
        Console.WriteLine("Subtraction: " + result);

        result = calculator.Multiply(5, 3);
        Console.WriteLine("Multiplication: " + result);

        result = calculator.Divide(5, 3);
        Console.WriteLine("Division: " + result);
    }
}