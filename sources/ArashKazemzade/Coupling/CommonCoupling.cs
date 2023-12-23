
namespace Coupling
{
    // Module with Common Coupling
    public static class CommonCouplingModule
    {
        public static int SharedData; // Shared global data area
    }

    // Modules accessing shared data
    public class ModuleA
    {
        public void UseSharedData()
        {
            int data = CommonCouplingModule.SharedData;
            // Use data
        }
    }

    public class ModuleB
    {
        public void ModifySharedData()
        {
            CommonCouplingModule.SharedData = 42;
        }
    }

}
