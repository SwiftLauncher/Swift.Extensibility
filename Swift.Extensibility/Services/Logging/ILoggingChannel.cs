using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Swift.Extensibility.Services.Logging
{
    /// <summary>
    /// Interface for LoggingChannels.
    /// </summary>
    public interface ILoggingChannel
    {
        /// <summary>
        /// Gets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        string Id { get; }

        /// <summary>
        /// Gets the messages.
        /// </summary>
        /// <value>
        /// The messages.
        /// </value>
        IEnumerable<LogMessage> Messages { get; }

        /// <summary>
        /// Logs the specified message.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="severity">The severity.</param>
        /// <param name="sender">The sender.</param>
        /// <param name="sourceFile">The source file.</param>
        /// <param name="sourceLine">The source line.</param>
        void Log(string message, LogMessageSeverity severity = LogMessageSeverity.Output, [CallerMemberName] string sender = "", [CallerFilePath] string sourceFile = "", [CallerLineNumber] int sourceLine = 0);

        /// <summary>
        /// Occurs when a message is added.
        /// </summary>
        event MessageAddedEventHandler MessageAdded;
    }

    /// <summary>
    /// Event handler for MessageAdded events.
    /// </summary>
    /// <param name="args">The <see cref="MessageAddedEventArgs"/> instance containing the event data.</param>
    public delegate void MessageAddedEventHandler(MessageAddedEventArgs args);
}
