// Example of Sequential Cohesion
// DataProcessingModule.cs

public class DataProcessingModule
{
    // Sequential data flow between parts
    public void ProcessData()
    {
        var inputData = FetchData();
        var processedData = TransformData(inputData);
        StoreData(processedData);
    }

    private object FetchData() { /* implementation */ }
    private object TransformData(object data) { /* implementation */ }
    private void StoreData(object data) { /* implementation */ }
}
