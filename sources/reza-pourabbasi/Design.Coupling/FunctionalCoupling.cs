namespace Design.Coupling.FunctionalCoupling;
// MathOperations.cs
public class MathOperations
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Multiply(int a, int b)
    {
        return a * b;
    }
}

// Program.cs
class Program
{
    static void Main(string[] args)
    {
        MathOperations mathOperations = new MathOperations();

        int sum = mathOperations.Add(2, 3);
        int result = mathOperations.Multiply(sum, 4);

        Console.WriteLine("Result: " + result);
    }
}