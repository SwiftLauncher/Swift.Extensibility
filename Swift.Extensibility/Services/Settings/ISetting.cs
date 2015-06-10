using System;

namespace Swift.Extensibility.Services.Settings
{
    /// <summary>
    /// Interface for settings.
    /// </summary>
    public interface ISetting
    {
        /// <summary>
        /// Gets or sets the display name.
        /// </summary>
        string DisplayName { get; }

        /// <summary>
        /// Gets or sets the tool tip. Can be null to hide tooltips.
        /// </summary>
        string ToolTip { get; }

        /// <summary>
        /// Gets or sets the description. Can be null to hide the description.
        /// </summary>
        string Description { get; }
    }

    /// <summary>
    /// Interface for generic settings or settings with a given type.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface ISetting<T> : ISetting
    {
        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        T Value { get; set; }

        /// <summary>
        /// Gets or sets the default value.
        /// </summary>
        T DefaultValue { get; }

        /// <summary>
        /// Gets the change callback.
        /// </summary>
        /// <value>
        /// The change callback.
        /// </value>
        Action<T> ChangeCallback { get; }
    }
}