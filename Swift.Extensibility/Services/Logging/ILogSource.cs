using System.ComponentModel.Composition;

namespace Swift.Extensibility.Services.Logging
{
    [InheritedExport]
    public interface ILogSource
    {
        void SetLoggingChannel(ILoggingChannel channel);
    }
}
