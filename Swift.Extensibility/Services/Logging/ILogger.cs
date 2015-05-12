using System.ComponentModel.Composition;

namespace Swift.Extensibility.Services.Logging
{
    /// <summary>
    /// Interface for Loggers.
    /// </summary>
    [InheritedExport]
    public interface ILogger
    {
        /// <summary>
        /// Gets the channel.
        /// </summary>
        /// <typeparam name="T">The requesting type.</typeparam>
        /// <returns>The ILoggingChannel for the specified type.</returns>
        ILoggingChannel GetChannel<T>();

        /// <summary>
        /// Gets the channel.
        /// </summary>
        /// <param name="channelName">Name of the channel.</param>
        /// <returns>The ILoggingChannel with the given name.</returns>
        ILoggingChannel GetChannel(string channelName);
    }
}
