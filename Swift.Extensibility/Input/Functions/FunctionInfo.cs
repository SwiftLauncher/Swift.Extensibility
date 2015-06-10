using System.Collections.Generic;

namespace Swift.Extensibility.Input.Functions
{
    /// <summary>
    /// Represents a Swift function.
    /// </summary>
    public sealed class FunctionInfo
    {
        /// <summary>
        /// The full name of the function, including subfunction qualifiers.
        /// </summary>
        public string FullName { get; }

        /// <summary>
        /// The function name qualifiers.
        /// </summary>
        public IEnumerable<string> NameParts { get; }

        /// <summary>
        /// The call mode.
        /// </summary>
        public FunctionCallMode CallMode { get; }

        /// <summary>
        /// The list of parameters.
        /// </summary>
        public IEnumerable<ParameterInfo> Parameters { get; }

        /// <summary>
        /// Creates a new instance of the <see cref="FunctionInfo"/> class.
        /// </summary>
        /// <param name="fullName">The full name of the function.</param>
        /// <param name="callMode">The callmode of the function.</param>
        /// <param name="parameters">The list of parameters of the function.</param>
        public FunctionInfo(string fullName, FunctionCallMode callMode, IEnumerable<ParameterInfo> parameters)
        {
            FullName = fullName;
            NameParts = FullName.TrimStart('.').Split('.');
            CallMode = callMode;
            Parameters = parameters;
        }
    }
}
