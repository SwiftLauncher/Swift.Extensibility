using System.ComponentModel.Composition;

namespace Swift.Extensibility.Input
{
    [InheritedExport]
    public interface IInputTextCompletionProvider
    {
        string GetCompletion(IInput input);
    }
}
