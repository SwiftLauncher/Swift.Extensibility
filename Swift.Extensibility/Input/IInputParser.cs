using System.ComponentModel.Composition;

namespace Swift.Extensibility.Input
{
    [InheritedExport]
    public interface IInputParser
    {
        IInput Parse(string inputText);
    }
}
