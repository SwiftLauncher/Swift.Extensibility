using System.ComponentModel.Composition;

namespace Swift.Extensibility.Input
{
    public interface IInputTextCompletionProvider
    {
        string GetCompletion(IInput input);
    }
}
