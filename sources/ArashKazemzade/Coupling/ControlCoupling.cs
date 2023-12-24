

namespace Coupling
{
    // Module with Control Coupling
    public class ControlCouplingModule
    {
        public void ExecuteOperation(bool condition)
        {
            if (condition)
            {
                // Perform operation
            }
            else
            {
                // Perform alternative operation
            }
        }
    }

    // Caller Module
    public class CallModule
    {
        public void CallControlCouplingModule()
        {
            ControlCouplingModule controlModule = new ControlCouplingModule();
            bool condition = true;
            controlModule.ExecuteOperation(condition);
        }
    }

}
