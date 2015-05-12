using System.ComponentModel.Composition;
using Swift.Extensibility.Services;

namespace Swift.Extensibility.Plugins
{
    [InheritedExport]
    public interface IPlugin : IInitializationAware, IShutdownAware, ISwiftExtender
    {
    }
}
