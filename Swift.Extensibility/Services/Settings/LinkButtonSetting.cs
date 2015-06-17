using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Input;
using Swift.Extensibility.UI;

namespace Swift.Extensibility.Services.Settings
{
    /// <summary>
    /// Represents a Setting with a LinkButton.
    /// </summary>
    public class LinkButtonSetting : ISetting
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
        /// Gets the on click URI.
        /// </summary>
        /// <value>
        /// The on click URI.
        /// </value>
        public Uri OnClickUri { get; }

        /// <summary>
        /// Gets the on click command.
        /// </summary>
        /// <value>
        /// The on click command.
        /// </value>
        public ICommand OnClickCommand { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="LinkButtonSetting"/> class.
        /// </summary>
        /// <param name="displayName">The display name.</param>
        /// <param name="onClickUri">The on click URI.</param>
        public LinkButtonSetting(string displayName, Uri onClickUri)
        {
            DisplayName = displayName;
            OnClickUri = onClickUri;
            OnClickCommand = new RelayCommand(Launch);
        }

        private void Launch()
        {
            if (OnClickUri.Scheme == "swift-function")
            {
                var function = InternalExtensibilityHelper.FunctionManager.GetFunctions().FirstOrDefault(_ => _.FullName == OnClickUri.Authority);
                if (function == null) return;
                InternalExtensibilityHelper.FunctionManager.Invoke(function,
                    new Input.Input(OnClickUri.Authority + " " + OnClickUri.Query, OnClickUri.Authority),
                    new Input.Functions.SwiftFunctionCallContext(Input.Functions.FunctionCallOrigin.CodeCall));
            }
            else
            {
                Process.Start(OnClickUri.AbsoluteUri);
            }
        }
    }
}
