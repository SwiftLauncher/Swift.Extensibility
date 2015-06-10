namespace Swift.Extensibility.Services.Logging
{
    /// <summary>
    /// Represents a LogMessage.
    /// </summary>
    public sealed class LogMessage
    {
        string ChannelId { get; }
        string Message { get; }
        LogMessageSeverity Severity { get; }
        string Sender { get; }
        string SourceFile { get; }
        int SourceLine { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="LogMessage"/> class.
        /// </summary>
        /// <param name="channelId">The channel identifier.</param>
        /// <param name="message">The message.</param>
        /// <param name="severity">The severity.</param>
        /// <param name="sender">The sender.</param>
        /// <param name="sourceFile">The source file.</param>
        /// <param name="sourceLine">The source line.</param>
        public LogMessage(string channelId, string message, LogMessageSeverity severity, string sender, string sourceFile, int sourceLine)
        {
            ChannelId = channelId;
            Message = message;
            Severity = severity;
            Sender = sender;
            SourceFile = sourceFile;
            SourceLine = SourceLine;
        }
    }

    /// <summary>
    /// Log message severity levels.
    /// </summary>
    public enum LogMessageSeverity
    {
        /// <summary>
        /// The output
        /// </summary>
        Output,
        /// <summary>
        /// The information
        /// </summary>
        Information,
        /// <summary>
        /// The warning
        /// </summary>
        Warning,
        /// <summary>
        /// The error
        /// </summary>
        Error
    }
}
