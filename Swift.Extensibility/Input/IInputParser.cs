namespace Swift.Extensibility.Input
{
    /// <summary>
    /// Interface for input parsers.
    /// </summary>
    public interface IInputParser
    {
        /// <summary>
        /// Parses the given input into an <see cref="IInput"/> object.
        /// </summary>
        /// <param name="inputText">The textual input.</param>
        /// <returns>An <see cref="IInput"/> object representing the parsed input text.</returns>
        IInput Parse(string inputText);
    }
}
