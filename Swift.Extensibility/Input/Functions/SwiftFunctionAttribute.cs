using System;

namespace Swift.Extensibility.Input.Functions
{
    /// <summary>
    /// Marks a method as a Swift-Function with the given name.
    /// A class that has methods marked with this Attribute needs to implement <see cref="ISwiftFunctionSource"/>.
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, Inherited = false)]
    public sealed class SwiftFunctionAttribute : Attribute
    {
        /// <summary>
        /// The name of the function in Swift context.
        /// </summary>
        public string FunctionName { get; }

        /// <summary>
        /// Gets or sets the callmode for this function.
        /// </summary>
        public FunctionCallMode CallMode { get; set; }

        /// <summary>
        /// Creates a new instance of the <see cref="SwiftFunctionAttribute"/> class.
        /// </summary>
        /// <param name="functionName">The function name that should represent this method inside Swift.</param>
        public SwiftFunctionAttribute(string functionName)
        {
            FunctionName = functionName;
        }
    }

    /// <summary>
    /// Contains values for FunctionCallModes.
    /// </summary>
    public enum FunctionCallMode
    {
        /// <summary>
        /// The function will be executed when execution is explicitly requested.
        /// </summary>
        Explicit = 0,
        /// <summary>
        /// The function will be executed whenever the input changes.
        /// </summary>
        Continuous = 1,
        /// <summary>
        /// The function will be evaluated continuously and called, when the execution is explicitly requested.
        /// </summary>
        Both = 2
    }
}
