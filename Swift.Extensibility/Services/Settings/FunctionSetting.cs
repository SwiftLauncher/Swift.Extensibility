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
        public Predicate<FunctionInfo> Filter { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionSetting"/> class.
        /// </summary>
        /// <param name="displayName">The display name.</param>
        /// <param name="defaultValue">if set to <c>true</c> [default value].</param>
        /// <param name="changeCallback">The change callback.</param>
        /// <param name="value">if set to <c>true</c> [value].</param>
        /// <param name="tooltip">The tooltip.</param>
        /// <param name="description">The description.</param>
        /// <param name="filter">A filter to filter out not-selectable functions. By default, all functions will be available.</param>
        public FunctionSetting(string displayName, FunctionInfo defaultValue, Action<FunctionInfo> changeCallback, FunctionInfo value = null, string tooltip = "", string description = "", Predicate<FunctionInfo> filter = null)
        {
            DisplayName = displayName;
            Value = value;
            ChangeCallback = changeCallback;
            DefaultValue = defaultValue;
            ToolTip = tooltip;
            Description = description;
            Filter = filter ?? (_ => true);
        }
    }
}
