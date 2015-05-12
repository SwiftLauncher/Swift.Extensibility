using System;
using System.Windows.Media.Imaging;

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
        public string Text { get; private set; }

        /// <summary>
        /// Gets the on click callback.
        /// </summary>
        public Action OnClickCallback { get; private set; }

        /// <summary>
        /// Gets the icon.
        /// </summary>
        public Uri IconSource { get; private set; }

        /// <summary>
        /// Gets the target menu.
        /// </summary>
        public MenuTarget TargetMenu { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MenuItem"/> class.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <param name="onClickCallback">The on click callback.</param>
        /// <param name="iconSource">The icon.</param>
        public MenuItem(string text, Action onClickCallback, MenuTarget targetMenu, Uri iconSource = null)
        {
            Text = text;
            OnClickCallback = onClickCallback;
            TargetMenu = targetMenu;
            IconSource = iconSource;
        }
    }

    public enum MenuTarget
    {
        TopBar
    }
}
