using System;
using System.Windows.Input;
using Swift.Extensibility.UI;

namespace Swift.Extensibility.Services.Settings
{
    /// <summary>
    /// Represents a Setting with a button.
    /// </summary>
    public class ButtonSetting : ISetting
    {
        /// <summary>
        /// Gets or sets the display name.
        /// </summary>
        public string DisplayName { get; }

        /// <summary>
        /// Gets or sets the content of the button.
        /// </summary>
        /// <value>
        /// The content of the button.
        /// </value>
        public string ButtonContent { get; set; } = "Click here";

        /// <summary>
        /// Gets or sets the tool tip. Can be null to hide tooltips.
        /// </summary>
        public string ToolTip { get; set; }

        /// <summary>
        /// Gets or sets the description. Can be null to hide the description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets the on click callback.
        /// </summary>
        /// <value>
        /// The on click callback.
        /// </value>
        public Action OnClickCallback { get; }

        /// <summary>
        /// Gets the on click command.
        /// </summary>
        /// <value>
        /// The on click command.
        /// </value>
        public ICommand OnClickCommand { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ButtonSetting"/> class.
        /// </summary>
        /// <param name="displayName">The display name.</param>
        /// <param name="onClickCallback">The on click callback.</param>
        public ButtonSetting(string displayName, Action onClickCallback)
        {
            DisplayName = displayName;
            OnClickCallback = onClickCallback;
            OnClickCommand = new RelayCommand(OnClickCallback);
        }
    }
}
