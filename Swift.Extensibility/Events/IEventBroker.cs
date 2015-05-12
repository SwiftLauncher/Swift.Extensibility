namespace Swift.Extensibility.Events
{

    /// <summary>
    /// Interface for EventBrokers handling access to EventChannels.
    /// </summary>
    public interface IEventBroker
    {
        /// <summary>
        /// Gets the channel with the given name. If no such channel exists, it will be created.
        /// </summary>
        /// <param name="name">The name of the channel to get.</param>
        /// <returns>A reference to the IEventChannel with the given name.</returns>
        IEventChannel GetChannel(string name);

        /// <summary>
        /// Gets the channel with the given name and argument type. If no such channel exists, it will be created.
        /// </summary>
        /// <typeparam name="T">The type of the event arguments</typeparam>
        /// <param name="name">The name of the channel to get.</param>
        /// <returns>A reference to the IEventChannel with the given name and argument type.</returns>
        IEventChannel<T> GetChannel<T>(string name);
    }
}
