namespace Design.Coupling;

public class DataProvider
{
    public int GetData()
    {
        //Retrieve data from a database or another source
        int data = 42;
        return data;
    }
}

public class DataProcessor
{
    private readonly DataProvider _dataProvider;

    public DataProcessor(DataProvider dataProvider)
    {
        _dataProvider = dataProvider;
    }
    public int ProcessData()
    {
        int data = _dataProvider.GetData();
        int result = data * 2;
        return result;
    }

    public class Program
    {
        public void Main(string[] args)
        {
            DataProvider dataProvider = new();
            DataProcessor dataProcessor = new(dataProvider);
            int processedData = dataProcessor.ProcessData();
            Console.WriteLine("Processed data: " + processedData);
        }
    }
}
