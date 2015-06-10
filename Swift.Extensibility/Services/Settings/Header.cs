namespace Swift.Extensibility.Services.Settings
{
    /// <summary>
    /// Represents a header.
    /// </summary>
    public sealed class Header : ISetting
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
        /// Initializes a new instance of the <see cref="Header"/> class.
        /// </summary>
        /// <param name="title">The title.</param>
        /// <param name="tooltip">The tooltip.</param>
        /// <param name="description">The description.</param>
        public Header(string title, string tooltip = "", string description = "")
        {
            DisplayName = title;
            ToolTip = tooltip;
            Description = description;
        }
    }
}
