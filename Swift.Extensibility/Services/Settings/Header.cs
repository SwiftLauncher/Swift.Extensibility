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
        public string ToolTip { get; set; }

        /// <summary>
        /// Gets or sets the description. Can be null to hide the description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Header" /> class.
        /// </summary>
        /// <param name="title">The title.</param>
        public Header(string title)
        {
            DisplayName = title;
        }
    }
}
