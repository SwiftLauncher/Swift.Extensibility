using System.Collections.Generic;
using System.ComponentModel.Composition;

namespace Swift.Extensibility.Services.Settings
{
    /// <summary>
    /// Interface for classes that have settings.
    /// </summary>
    public interface ISettingsSource
    {
        /// <summary>
        /// Gets the display name of this ISettingsSource.
        /// </summary>
        string DisplayName { get; }

        /// <summary>
        /// Gets the parent of this ISettingsSource. This is only used to display the settings hierarchically. Can be null.
        /// </summary>
        /// <value>
        /// The parent.
        /// </value>
        ISettingsSource Parent { get; }

        /// <summary>
        /// Gets the settings.
        /// </summary>
        /// <value>
        /// The settings.
        /// </value>
        IEnumerable<ISetting> Settings { get; }
    }
}
