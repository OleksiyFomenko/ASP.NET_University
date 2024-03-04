public static class LoggerExtensions
{
    public static ILoggingBuilder AddFile(this ILoggingBuilder builder, string filePath, LogLevel minimumLogLevel = LogLevel.Trace)
    {
        builder.AddProvider(new LoggerProvider(filePath, minimumLogLevel));
        return builder;
    }
}
