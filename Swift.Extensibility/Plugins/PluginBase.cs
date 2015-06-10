using System.ComponentModel.Composition;
using Swift.Extensibility.Services;
using Swift.Extensibility.Services.Logging;

namespace Swift.Extensibility.Plugins
{
    /// <summary>
    /// Base class for swift plugins implementing the <see cref="IPlugin"/> interface;
    /// </summary>
    public abstract class PluginBase : IPlugin
    {
        /// <summary>
        /// Gets the initialization priority. Higher values lead to later initialization.
        /// </summary>
        /// <value>
        /// The initialization priority.
        /// </value>
        public int InitializationPriority { get; } = 0;

        /// <summary>
        /// Gets the shutdown priority.
        /// </summary>
        /// <value>
        /// The shutdown priority.
        /// </value>
        public int ShutdownPriority { get; } = 0;

        /// <summary>
        /// Raises the <see cref="E:Initialization" /> event.
        /// </summary>
        /// <param name="args">The <see cref="InitializationEventArgs" /> instance containing the event data.</param>
        public virtual void OnInitialization(InitializationEventArgs args) { }

        /// <summary>
        /// Raises the <see cref="E:Shutdown" /> event.
        /// </summary>
        /// <param name="args">The <see cref="ShutdownEventArgs" /> instance containing the event data.</param>
        public virtual void OnShutdown(ShutdownEventArgs args) { }

        /// <summary>
        /// Gets the plugin services.
        /// </summary>
        /// <value>
        /// The plugin services.
        /// </value>
        [Import]
        protected IPluginServices PluginServices { get; }

        /// <summary>
        /// Sets the logger.
        /// </summary>
        /// <value>
        /// The logger.
        /// </value>
        [Import]
        private ILogger Logger { set { Log = value.GetChannel(GetType().FullName); } }

        /// <summary>
        /// Gets the log.
        /// </summary>
        /// <value>
        /// The log.
        /// </value>
        protected ILoggingChannel Log { get; private set; }
    }
}
