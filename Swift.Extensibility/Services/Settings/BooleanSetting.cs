using System;

namespace Swift.Extensibility.Services.Settings
{
    /// <summary>
    /// Represents a setting with a boolean value.
    /// </summary>
    public sealed class BooleanSetting : Setting<bool>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BooleanSetting"/> class.
        /// </summary>
        /// <param name="displayName">The display name.</param>
        /// <param name="defaultValue">if set to <c>true</c> [default value].</param>
        /// <param name="changeCallback">The change callback.</param>
        /// <param name="value">if set to <c>true</c> [value].</param>
        /// <param name="tooltip">The tooltip.</param>
        /// <param name="description">The description.</param>
        public BooleanSetting(string displayName, bool defaultValue, Action<bool> changeCallback, bool value = false, string tooltip = "", string description = "")
        {
            DisplayName = displayName;
            Value = value;
            ChangeCallback = changeCallback;
            DefaultValue = defaultValue;
            ToolTip = tooltip;
            Description = description;
        }
    }
}
