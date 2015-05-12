using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;

namespace Swift.Extensibility.Functions
{
    [InheritedExport]
    public abstract class Function : IFunctionInfo, ISwiftExtender
    {
        public string DisplayName { get; protected set; }
        public string CallName { get; protected set; }
        public string Description { get; protected set; }
        public IEnumerable<string> Aliases { get; protected set; }
        public IEnumerable<ParameterInfo> Parameters { get; protected set; }

        public abstract void Execute();

        public Function(string displayName, string callName)
        {
            DisplayName = displayName;
            CallName = callName;
            Aliases = Enumerable.Empty<string>();
            Parameters = Enumerable.Empty<ParameterInfo>();
        }
    }
}
