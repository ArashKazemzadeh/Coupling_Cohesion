namespace Design.Cohesion.LayerCohesion;
public class DataAccessLayer
{
    public void ConnectToDatabase()
    {
        // Code to establish a connection to the database
        Console.WriteLine("Connecting to the database");
    }

    public List<string> RetrieveData()
    {
        // Code to retrieve data from the database
        Console.WriteLine("Retrieving data from the database");
        return new List<string>() { "Data 1", "Data 2", "Data 3" };
    }

    public void CloseConnection()
    {
        // Code to close the database connection
        Console.WriteLine("Closing the database connection");
    }
}

public class BusinessLogicLayer
{
    private DataAccessLayer dataAccessLayer;

    public BusinessLogicLayer()
    {
        dataAccessLayer = new DataAccessLayer();
    }

    public void ProcessData()
    {
        dataAccessLayer.ConnectToDatabase();

        List<string> data = dataAccessLayer.RetrieveData();

        // Code to perform business logic operations on the retrieved data
        Console.WriteLine("Processing data: " + string.Join(", ", data));

        dataAccessLayer.CloseConnection();
    }
}

public class PresentationLayer
{
    private BusinessLogicLayer businessLogicLayer;

    public PresentationLayer()
    {
        businessLogicLayer = new BusinessLogicLayer();
    }

    public void DisplayData()
    {
        businessLogicLayer.ProcessData();

        // Code to display the processed data to the user
        Console.WriteLine("Displaying data");
    }
}

public class Program
{
    static void Main(string[] args)
    {
        PresentationLayer presentationLayer = new PresentationLayer();
        presentationLayer.DisplayData();
    }
}