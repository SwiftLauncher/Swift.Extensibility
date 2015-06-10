using System.ComponentModel.Composition;
using Swift.Extensibility.Services;

namespace Swift.Extensibility.Plugins
{
    /// <summary>
    /// Interface for Swift plugins.
    /// </summary>
    [InheritedExport]
    public interface IPlugin : IInitializationAware, IShutdownAware, ISwiftExtender
    {
    }
}
