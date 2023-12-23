namespace Design.Coupling.ComponentCoupling;
public class DataAccessComponent
{
    public void SaveData(string data)
    {
        // Code to save data to a database
        Console.WriteLine("Data saved: " + data);
    }
}

// BusinessLogicComponent.cs
public class BusinessLogicComponent
{
    private DataAccessComponent dataAccessComponent;

    public BusinessLogicComponent()
    {
        dataAccessComponent = new DataAccessComponent();
    }

    public void ProcessData(string data)
    {
        // Code to process the data

        // Save the processed data
        dataAccessComponent.SaveData(data);
    }
}

class Program
{
    static void Main(string[] args)
    {
        BusinessLogicComponent businessLogicComponent = new BusinessLogicComponent();
        businessLogicComponent.ProcessData("Sample data");
    }
}