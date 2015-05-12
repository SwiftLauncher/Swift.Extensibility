using System;
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
        string ID { get; }

        /// <summary>
        /// Gets the messages.
        /// </summary>
        /// <value>
        /// The messages.
        /// </value>
        IEnumerable<ILogMessage> Messages { get; }

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

    /// <summary>
    /// EventArgs for MessageAdded events.
    /// </summary>
    public class MessageAddedEventArgs : EventArgs
    {
        /// <summary>
        /// Gets the message.
        /// </summary>
        /// <value>
        /// The message.
        /// </value>
        public ILogMessage Message { get; private set; }

        /// <summary>
        /// Gets the channel identifier.
        /// </summary>
        /// <value>
        /// The channel identifier.
        /// </value>
        public string ChannelID { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageAddedEventArgs"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="channelID">The channel identifier.</param>
        public MessageAddedEventArgs(ILogMessage message, string channelID)
        {
            Message = message;
            ChannelID = channelID;
        }
    }
}
