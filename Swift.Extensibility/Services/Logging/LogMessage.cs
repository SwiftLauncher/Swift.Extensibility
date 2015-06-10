namespace Swift.Extensibility.Services.Logging
{
    /// <summary>
    /// Represents a LogMessage.
    /// </summary>
    public sealed class LogMessage
    {
        /// <summary>
        /// Gets the channel identifier.
        /// </summary>
        /// <value>
        /// The channel identifier.
        /// </value>
        public string ChannelId { get; }

        /// <summary>
        /// Gets the message.
        /// </summary>
        /// <value>
        /// The message.
        /// </value>
        public string Message { get; }

        /// <summary>
        /// Gets the severity.
        /// </summary>
        /// <value>
        /// The severity.
        /// </value>
        public LogMessageSeverity Severity { get; }

        /// <summary>
        /// Gets the sender.
        /// </summary>
        /// <value>
        /// The sender.
        /// </value>
        public string Sender { get; }

        /// <summary>
        /// Gets the source file.
        /// </summary>
        /// <value>
        /// The source file.
        /// </value>
        public string SourceFile { get; }

        /// <summary>
        /// Gets the source line.
        /// </summary>
        /// <value>
        /// The source line.
        /// </value>
        public int SourceLine { get; }

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
