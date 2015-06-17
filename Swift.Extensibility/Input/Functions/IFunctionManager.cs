using System.Collections.Generic;

namespace Swift.Extensibility.Input.Functions
{
    /// <summary>
    /// Interface for managing functions.
    /// </summary>
    public interface IFunctionManager
    {
        /// <summary>
        /// Gets all available functions.
        /// </summary>
        /// <returns>An enumerable with all available functions.</returns>
        IEnumerable<FunctionInfo> GetFunctions();

        /// <summary>
        /// Gets a matching function, if available.
        /// </summary>
        /// <param name="input">The input to match against.</param>
        /// <returns>A <see cref="FunctionInfo"/> representing the matching function.</returns>
        FunctionInfo GetMatchingFunction(Input input);

        /// <summary>
        /// Gets a value indicating whether there is a function that matches the given input.
        /// </summary>
        /// <param name="input">The input to match against.</param>
        /// <returns>True, if a matching function was found. False otherwise.</returns>
        bool HasMatchingFunction(Input input);

        /// <summary>
        /// Invokes the specified function with the parameters from the given input.
        /// </summary>
        /// <param name="info">The <see cref="FunctionInfo" /> representing the function to invoke.</param>
        /// <param name="input">The input to use for the parameters.</param>
        /// <param name="context">The context.</param>
        void Invoke(FunctionInfo info, Input input, SwiftFunctionCallContext context);
    }
}
