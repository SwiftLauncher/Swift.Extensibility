using System;

namespace Swift.Extensibility.Input.Functions
{
    /// <summary>
    /// Attribute to further describe parameters of Swift functions.
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
    public sealed class ParameterDescriptionAttribute : Attribute
    {
        /// <summary>
        /// The name of the parameter the is described by this attribute.
        /// It is recommended that you use the C# 6 "nameof()" feature for this.
        /// </summary>
        public string ParameterName { get; }

        /// <summary>
        /// The parameter description (e.g. expected input, what it does,...)
        /// </summary>
        public string Description { get; }

        /// <summary>
        /// An example showing how to use the parameter.
        /// </summary>
        public string ExampleUsage { get; set; }

        /// <summary>
        /// Creates a new instance of the <see cref="ParameterDescriptionAttribute"/> class.
        /// </summary>
        /// <param name="parameterName">The name of the parameter that is described by this attribute. (Use nameof() if possible)</param>
        /// <param name="description">The description for the parameter.</param>
        public ParameterDescriptionAttribute(string parameterName, string description)
        {
            ParameterName = parameterName;
            Description = description;
        }
    }
}
