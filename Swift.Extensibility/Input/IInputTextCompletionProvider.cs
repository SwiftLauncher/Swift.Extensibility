using System.Collections.Generic;

namespace Swift.Extensibility.Input
{
    /// <summary>
    /// Interface for completion providers.
    /// </summary>
    public interface IInputTextCompletionProvider
    {
        /// <summary>
        /// Returns an enumeration of completion strings for the given input.
        /// </summary>
        /// <param name="input">The current input.</param>
        /// <returns>An enumeration of completions.</returns>
        IEnumerable<string> GetCompletion(IInput input);
    }
}
