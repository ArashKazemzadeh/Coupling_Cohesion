namespace Design.Coupling.SequentialCoupling;
// DataProcessor.cs
public class DataProcessor
{
    public void ProcessData(string data)
    {
        string cleanedData = CleanData(data);
        string transformedData = TransformData(cleanedData);
        SaveData(transformedData);
    }

    private string CleanData(string data)
    {
        // Code to clean the data
        Console.WriteLine("Cleaning data...");
        return "Cleaned " + data;
    }

    private string TransformData(string data)
    {
        // Code to transform the data
        Console.WriteLine("Transforming data...");
        return "Transformed " + data;
    }

    private void SaveData(string data)
    {
        // Code to save the data to a file or database
        Console.WriteLine("Saving data...");
        Console.WriteLine($"Data saved: {data}");
    }
}

// Program.cs
public class Program
{
    static void Main(string[] args)
    {
        string inputData = "Raw data to process";

        DataProcessor dataProcessor = new DataProcessor();
        dataProcessor.ProcessData(inputData);
    }
}