namespace Swift.Extensibility.Input
{
    /// <summary>
    /// Interface for input parsers.
    /// </summary>
    public interface IInputParser
    {
        /// <summary>
        /// Parses the given input into an <see cref="Input"/> object.
        /// </summary>
        /// <param name="inputText">The textual input.</param>
        /// <returns>An <see cref="Input"/> object representing the parsed input text.</returns>
        Input Parse(string inputText);
    }
}
