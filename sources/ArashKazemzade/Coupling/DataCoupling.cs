
namespace Coupling
{
    // Module with Data Coupling
    public class DataCouplingModule
    {
        public void ProcessData(int data)
        {
            // Process data
        }
    }

    // Caller Module
    public class CallerModule
    {
        public void CallDataCouplingModule()
        {
            DataCouplingModule dataModule = new DataCouplingModule();
            int data = 42;
            dataModule.ProcessData(data);
        }
    }

}
