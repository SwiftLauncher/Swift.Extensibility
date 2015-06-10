using System;
using Swift.Extensibility.Input.Functions;

namespace Swift.Extensibility.UI
{
    /// <summary>
    /// Represents a MenuItem in one of Swift's menus.
    /// </summary>
    public sealed class MenuItem
    {
        /// <summary>
        /// Gets the text.
        /// </summary>
        public string Text { get; }

        /// <summary>
        /// Gets the on click callback.
        /// </summary>
        public FunctionInfo OnClickFunction { get; }

        /// <summary>
        /// Gets the icon.
        /// </summary>
        public Uri IconSource { get; }

        /// <summary>
        /// Gets the target menu.
        /// </summary>
        public MenuTarget TargetMenu { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MenuItem"/> class.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <param name="onClickFunction">The on click callback.</param>
        /// <param name="targetMenu">The target Menu.</param>
        /// <param name="iconSource">The icon.</param>
        public MenuItem(string text, FunctionInfo onClickFunction, MenuTarget targetMenu, Uri iconSource = null)
        {
            Text = text;
            OnClickFunction = onClickFunction;
            TargetMenu = targetMenu;
            IconSource = iconSource;
        }
    }
}
