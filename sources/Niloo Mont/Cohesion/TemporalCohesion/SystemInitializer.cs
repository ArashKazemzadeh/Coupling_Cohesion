namespace TemporalCohesion;
internal class SystemInitializer
{
    private readonly DatabaseSubsystem databaseSubsystem;
    private readonly ConfigurationSubsystem configurationSubsystem;
    private readonly LoggingSubsystem loggingSubsystem;
    private readonly ServiceSubsystem serviceSubsystem;
    private readonly SchedulerSubsystem schedulerSubsystem;

    public SystemInitializer()
    {
        databaseSubsystem = new DatabaseSubsystem();
        configurationSubsystem = new ConfigurationSubsystem();
        loggingSubsystem = new LoggingSubsystem();
        serviceSubsystem = new ServiceSubsystem();
        schedulerSubsystem = new SchedulerSubsystem();
    }
    public void InitializeSystem()
    {
        databaseSubsystem.InitializeDatabase();
        configurationSubsystem.LoadConfiguration();
        loggingSubsystem.SetupLogging();
        serviceSubsystem.ConfigureServices();
        schedulerSubsystem.StartScheduler();        
    }
}
