using System.Collections.Generic;
using System.ComponentModel.Composition;

namespace Swift.Extensibility.Functions
{
    [InheritedExport]
    public interface IFunctionInfo
    {
        string DisplayName { get; }
        string CallName { get; }
        string Description { get; }
        IEnumerable<string> Aliases { get; }
        IEnumerable<ParameterInfo> Parameters { get; }
    }
}
