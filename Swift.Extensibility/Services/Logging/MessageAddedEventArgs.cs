using System;

namespace Swift.Extensibility.Services.Logging
{
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
        public LogMessage Message { get; }

        /// <summary>
        /// Gets the channel identifier.
        /// </summary>
        /// <value>
        /// The channel identifier.
        /// </value>
        public string ChannelId { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageAddedEventArgs"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="channelId">The channel identifier.</param>
        public MessageAddedEventArgs(LogMessage message, string channelId)
        {
            Message = message;
            ChannelId = channelId;
        }
    }
}