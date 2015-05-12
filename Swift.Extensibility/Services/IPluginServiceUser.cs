using System.ComponentModel.Composition;

namespace Swift.Extensibility.Services
{
    /// <summary>
    /// Classes that want to utilize plugin services should implement this interface and use the reference provided by the SetPluginServices method.
    /// </summary>
    [InheritedExport]
    public interface IPluginServiceUser
    {
        /// <summary>
        /// Provides an implementation of plugin services.
        /// </summary>
        /// <param name="pluginServices">The plugin services.</param>
        void SetPluginServices(IPluginServices pluginServices);
    }
}
