namespace Design.Cohesion.SequentialCohesion;
public class DataProcessor
{
    public void ReadDataFromFile(string filePath)
    {
        // Code to read data from a file
        Console.WriteLine("Reading data from file: " + filePath);
    }

    public void ProcessData()
    {
        // Code to process the data
        Console.WriteLine("Processing data");
    }

    public void SaveDataToDatabase()
    {
        // Code to save data to a database
        Console.WriteLine("Saving data to the database");
    }
}

// Program.cs
public class Program
{
    static void Main(string[] args)
    {
        DataProcessor dataProcessor = new DataProcessor();

        dataProcessor.ReadDataFromFile("data.txt");
        dataProcessor.ProcessData();
        dataProcessor.SaveDataToDatabase();
    }
}