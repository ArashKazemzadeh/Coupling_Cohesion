

namespace Coupling
{
    // Module with Stamp Coupling
    public class StampCouplingModule
    {
        public void ProcessData(DataStructure structure)
        {
            // Process data structure
        }
    }

    // Data Structure
    public class DataStructure
    {
        // Define data structure
    }

    // Caller Module
    public class CallrModule
    {
        public void CallStampCouplingModule()
        {
            StampCouplingModule stampModule = new StampCouplingModule();
            DataStructure data = new DataStructure();
            stampModule.ProcessData(data);
        }
    }

}
