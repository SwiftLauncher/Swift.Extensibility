using System;

namespace Swift.Extensibility.Input.Functions
{
    /// <summary>
    /// Represents a function parameter.
    /// </summary>
    public sealed class ParameterInfo
    {
        /// <summary>
        /// The name of the parameter.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// The type of the parameter.
        /// </summary>
        public Type Type { get; }

        /// <summary>
        /// The description of the parameter.
        /// </summary>
        public string Description { get; }

        /// <summary>
        /// An example of the usage of this parameter.
        /// </summary>
        public string Example { get; }

        /// <summary>
        /// Creates a new instance of the <see cref="ParameterInfo"/> class.
        /// </summary>
        /// <param name="name">The name of the parameter.</param>
        /// <param name="type">The type of the parameter.</param>
        /// <param name="description">The description of the parameter.</param>
        /// <param name="example">An example usage of the parameter.</param>
        public ParameterInfo(string name, Type type, string description, string example)
        {
            Name = name;
            Type = type;
            Description = description;
            Example = example;
        }
    }
}