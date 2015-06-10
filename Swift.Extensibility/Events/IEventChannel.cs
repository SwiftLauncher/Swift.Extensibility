using System;

namespace Swift.Extensibility.Events
{
    /// <summary>
    /// Interface for read-only EventChannels with simple handlers.
    /// </summary>
    public interface IReadOnlyEventChannel
    {
        /// <summary>
        /// Gets the name of this channel.
        /// </summary>
        /// <value>
        /// The name of this channel.
        /// </value>
        string Name { get; }

        /// <summary>
        /// Subscribes to this channel using the specified handler.
        /// </summary>
        /// <param name="handler">The handler.</param>
        /// <returns>An IDisposable that will unsubscribe the given handler when disposed.</returns>
        IDisposable Subscribe(Action handler);
    }

    /// <summary>
    /// Interface for EventChannels with simple handlers.
    /// </summary>
    public interface IEventChannel : IReadOnlyEventChannel
    {
        /// <summary>
        /// Fires an event on this channel.
        /// </summary>
        void Publish();
    }

    /// <summary>
    /// Interface for read-only EventChannels with parametrized handlers.
    /// </summary>
    /// <typeparam name="T">The type of the argument.</typeparam>
    public interface IReadOnlyEventChannel<out T>
    {
        /// <summary>
        /// Gets the name of this channel.
        /// </summary>
        /// <value>
        /// The name of this channel.
        /// </value>
        string Name { get; }

        /// <summary>
        /// Subscribes to this channel using the specified handler.
        /// </summary>
        /// <param name="handler">The handler.</param>
        /// <returns>An IDisposable that will unsubscribe the given handler when disposed.</returns>
        IDisposable Subscribe(Action<T> handler);
    }

    /// <summary>
    /// Interface for EventChannels with parametrized handlers.
    /// </summary>
    /// <typeparam name="T">The type of the argument.</typeparam>
    public interface IEventChannel<T> : IReadOnlyEventChannel<T>
    {
        /// <summary>
        /// Fires an event on this channel with the specified arguments.
        /// </summary>
        /// <param name="arguments">The arguments.</param>
        void Publish(T arguments);
    }
}
