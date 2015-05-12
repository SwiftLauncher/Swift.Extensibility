namespace Swift.Extensibility.Services.Logging
{
    public interface ILogMessage
    {
        string ChannelID { get; }
        string Message { get; }
        LogMessageSeverity Severity { get; }
        string Sender { get; }
        string SourceFile { get; }
        int SourceLine { get; }
    }

    public enum LogMessageSeverity
    {
        Output,
        Information,
        Warning,
        Error
    }
}
