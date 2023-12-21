namespace Design.Cohesion.TemporalCohesion;
public class EventProcessor
{
    public void FetchEventData()
    {
        // Code to fetch event data from a database or external source
        Console.WriteLine("Fetching event data");
    }

    public void ProcessEventData()
    {
        // Code to process the event data
        Console.WriteLine("Processing event data");
    }

    public void GenerateReport()
    {
        // Code to generate a report based on the processed event data
        Console.WriteLine("Generating report");
    }
}

public class Program
{
    static void Main(string[] args)
    {
        EventProcessor eventProcessor = new EventProcessor();

        eventProcessor.FetchEventData();
        eventProcessor.ProcessEventData();
        eventProcessor.GenerateReport();
    }
}