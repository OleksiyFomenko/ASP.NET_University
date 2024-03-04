public class LoggerProvider : ILoggerProvider
{
    string path;
    LogLevel minimumLogLevel;

    public LoggerProvider(string path, LogLevel minimumLogLevel)
    {
        this.path = path;
        this.minimumLogLevel = minimumLogLevel;
    }

    public ILogger CreateLogger(string categoryName)
    {
        return new Logger(path, minimumLogLevel);
    }

    public void Dispose() {}
}
