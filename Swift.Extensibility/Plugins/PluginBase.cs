using System;
using Swift.Extensibility.Services;
using Swift.Extensibility.Services.Logging;

namespace Swift.Extensibility.Plugins
{
    /// <summary>
    /// Base class for swift plugins implementing the <see cref="IPlugin"/> interface;
    /// </summary>
    public abstract class PluginBase : IPlugin, IPluginServiceUser, ILogSource
    {
        #region Initialization and Shutdown

        public int InitializationPriority { get; } = 0;

        public int ShutdownPriority { get; } = 0;

        public virtual void OnInitialization(InitializationEventArgs args) { }

        public virtual void OnShutdown(ShutdownEventArgs args) { }

        #endregion

        #region Properties

        protected IPluginServices PluginServices { get; private set; }

        protected ILoggingChannel Log { get; private set; }

        #endregion

        #region IPluginServiceUser Implementation

        public void SetPluginServices(IPluginServices pluginServices)
        {
            PluginServices = PluginServices ?? pluginServices;
        }

        #endregion

        #region ILogSource Implementation

        public void SetLoggingChannel(ILoggingChannel channel)
        {
            Log = Log ?? channel;
        }

        #endregion
    }
}
