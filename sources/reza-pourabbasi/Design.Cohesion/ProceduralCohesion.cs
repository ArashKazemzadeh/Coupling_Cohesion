namespace Design.Cohesion.ProceduralCohesion;
public class FileProcessor
{
    public void ReadFile(string filePath)
    {
        // Code to read the file
        Console.WriteLine("Reading file: " + filePath);
    }

    public void ProcessData()
    {
        // Code to process the data
        Console.WriteLine("Processing data");
    }

    public void WriteToFile(string filePath)
    {
        // Code to write data to a file
        Console.WriteLine("Writing data to file: " + filePath);
    }
}

public class Program
{
    static void Main(string[] args)
    {
        FileProcessor fileProcessor = new FileProcessor();

        string filePath = "data.txt";

        fileProcessor.ReadFile(filePath);
        fileProcessor.ProcessData();
        fileProcessor.WriteToFile(filePath);
    }
}