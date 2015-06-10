﻿namespace Swift.Extensibility.Services.Settings
{
    /// <summary>
    /// Represents a setting with a custom content. The content can be any object, however, you have to make sure that a proper DataTemplate is in place for it to be rendered.
    /// </summary>
    public sealed class CustomSetting : ISetting
    {
        /// <summary>
        /// Gets or sets the display name.
        /// </summary>
        public string DisplayName { get; }

        /// <summary>
        /// Gets or sets the tool tip. Can be null to hide tooltips.
        /// </summary>
        public string ToolTip { get; }

        /// <summary>
        /// Gets or sets the description. Can be null to hide the description.
        /// </summary>
        public string Description { get; }

        /// <summary>
        /// Gets the content.
        /// </summary>
        /// <value>
        /// The content.
        /// </value>
        public object Content { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomSetting"/> class.
        /// </summary>
        /// <param name="displayName">The display name.</param>
        /// <param name="content">The content.</param>
        /// <param name="tooltip">The tooltip.</param>
        /// <param name="description">The description.</param>
        public CustomSetting(string displayName, object content, string tooltip = "", string description = "")
        {
            DisplayName = displayName;
            Content = content;
            ToolTip = tooltip;
            Description = description;
        }
    }
}
