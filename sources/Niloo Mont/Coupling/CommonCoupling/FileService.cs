using Dumpify;
namespace CommonCoupling;
public class FileService
{
    public void ReadFromFile(string filePath)
    {
        try
        {
            $"File Content: {File.ReadAllText(filePath)}".Dump();
        }
        catch (FileNotFoundException)
        {
            "File not found.".Dump();
        }
        catch (IOException ex)
        {
            $"{ex.Message}".Dump();
        }
    }
    public void WriteToFile(string filePath, string text)
    {
        try
        {
            ;
            File.WriteAllText(filePath, text);

            Console.WriteLine("Data written to file successfully.");
        }
        catch (IOException ex)
        {
            $"{ex.Message}".Dump();
        }
    }
}
