using System.Collections.Generic;

namespace Swift.Extensibility.Input
{
    /// <summary>
    /// Represents an input from the user.
    /// </summary>
    public sealed class Input
    {
        /// <summary>
        /// Gets the complete string representation of this <see cref="Input"/>.
        /// </summary>
        public string TextValue { get; }

        /// <summary>
        /// Gets the function descriptor part (if any).
        /// </summary>
        public string FunctionDescriptor { get; }

        /// <summary>
        /// Gets the parameters.
        /// </summary>
        public IEnumerable<string> Parameters { get; }

        /// <summary>
        /// Creates a new <see cref="Input"/>.
        /// </summary>
        /// <param name="textValue">The full text of the input.</param>
        /// <param name="functionDescriptor">The function descriptor, if any.</param>
        /// <param name="parameters">The parameters.</param>
        public Input(string textValue, string functionDescriptor, params string[] parameters)
        {
            TextValue = textValue;
            FunctionDescriptor = functionDescriptor ?? string.Empty;
            Parameters = parameters;
        }
    }
}