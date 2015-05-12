using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
