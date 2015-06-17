using System;

namespace Swift.Extensibility.Services.Settings
{
    /// <summary>
    /// Represents a setting with a boolean value.
    /// </summary>
    public sealed class BooleanSetting : Setting<bool>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BooleanSetting" /> class.
        /// </summary>
        /// <param name="displayName">The display name.</param>
        /// <param name="value">if set to <c>true</c> [value].</param>
        /// <param name="changeCallback">The change callback.</param>
        public BooleanSetting(string displayName, bool value, Action<bool> changeCallback) : base(displayName, value, changeCallback)
        { }
    }
}
