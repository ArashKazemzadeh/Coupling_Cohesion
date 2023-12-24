
namespace Coupling
{
    // Module with External Coupling
    public class ExternalCouplingModule
    {
        public void ProcessExternalInput(string externalData)
        {
            // Process external input
        }
    }

    // Caller Module
    public class CallerModule
    {
        public void CallExternalCouplingModule(string externalData)
        {
            ExternalCouplingModule externalModule = new ExternalCouplingModule();
            externalModule.ProcessExternalInput(externalData);
        }
    }

}
