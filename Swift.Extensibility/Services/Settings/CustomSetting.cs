using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swift.Extensibility.Services.Settings
{
    /// <summary>
    /// Represents a setting with a custom content. The content can be any object, however, you have to make sure that a proper DataTemplate is in place for it to be rendered.
    /// </summary>
    public sealed class CustomSetting : ISetting
    {
        /// <summary>
        /// Gets or sets the display name.
        /// </summary>
        public string DisplayName { get; private set; }

        /// <summary>
        /// Gets or sets the tool tip. Can be null to hide tooltips.
        /// </summary>
        public string ToolTip { get; private set; }

        /// <summary>
        /// Gets or sets the description. Can be null to hide the description.
        /// </summary>
        public string Description { get; private set; }

        /// <summary>
        /// Gets the content.
        /// </summary>
        /// <value>
        /// The content.
        /// </value>
        public object Content { get; private set; }

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
