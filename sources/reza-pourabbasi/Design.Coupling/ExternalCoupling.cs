namespace Design.Coupling.ExternalCoupling;
public class Logger
{
    public void LogError(string message)
    {
        // Code to log an error using an external logging library

        // ExternalLoggingLibrary.Log(LogLevel.Error, message);
    }

    public void LogInfo(string message)
    {
        // Code to log an info message using an external logging library

        // ExternalLoggingLibrary.Log(LogLevel.Info, message);
    }
}

// Program.cs
public class Program
{
    static void Main(string[] args)
    {
        Logger logger = new Logger();

        logger.LogError("An error occurred.");
        logger.LogInfo("Informational message.");
    }
}