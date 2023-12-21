namespace Design.Coupling.CommonCoupling;
public class DataRepository
{
    private List<int> data;

    public DataRepository()
    {
        data = new List<int>();
    }

    public void AddData(int value)
    {
        data.Add(value);
    }

    public void ProcessData()
    {
        foreach (int value in data)
        {
            // Code to process the data
            Console.WriteLine(value);
        }
    }
}

// Program.cs
public class Program
{
    static void Main(string[] args)
    {
        DataRepository repository = new DataRepository();

        repository.AddData(10);
        repository.AddData(20);
        repository.AddData(30);

        repository.ProcessData();
    }
}