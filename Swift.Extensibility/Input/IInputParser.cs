using System.ComponentModel.Composition;

namespace Swift.Extensibility.Input
{
    public interface IInputParser
    {
        IInput Parse(string inputText);
    }
}
