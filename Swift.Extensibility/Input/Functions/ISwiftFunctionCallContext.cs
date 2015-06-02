namespace Swift.Extensibility.Input.Functions
{
    /// <summary>
    /// Interface for a SwiftFunctionCallContext.
    /// </summary>
    public interface ISwiftFunctionCallContext
    {
        /// <summary>
        /// Gets a value indicating from where the current call was initiated.
        /// </summary>
        FunctionCallOrigin CallOrigin { get; }
    }

    /// <summary>
    /// Describes from where a call to a Swift function was initiated.
    /// </summary>
    public enum FunctionCallOrigin
    {
        /// <summary>
        /// Indicates that the current call is the result of an explicit execution request issued by the user (e.g. by pressing Enter in the input box).
        /// </summary>
        UserRequested,
        /// <summary>
        /// Indicates that the current call is the result of continuous evaluation (i.e. the input changed).
        /// </summary>
        ContinuousEvaluation,
        /// <summary>
        /// Indicates that the current call is the result of a call to this function from code (e.g. another plugin).
        /// </summary>
        CodeCall
    }
}
