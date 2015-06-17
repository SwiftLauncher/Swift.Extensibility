using System;
using Swift.Extensibility.Input.Functions;

namespace Swift.Extensibility.Services.Settings
{
    /// <summary>
    /// Represents a setting with a FunctionInfo value.
    /// </summary>
    public sealed class FunctionSetting : Setting<FunctionInfo>
    {
        /// <summary>
        /// The filter that selects which functions are selectable.
        /// </summary>
        public Predicate<FunctionInfo> Filter { get; set; } = _ => true;

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionSetting" /> class.
        /// </summary>
        /// <param name="displayName">The display name.</param>
        /// <param name="value">if set to <c>true</c> [value].</param>
        /// <param name="changeCallback">The change callback.</param>
        public FunctionSetting(string displayName, FunctionInfo value, Action<FunctionInfo> changeCallback) : base(displayName, value, changeCallback)
        { }
    }
}
